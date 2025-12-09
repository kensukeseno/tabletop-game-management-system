using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TabletopGameManagementSystem.Models;
using TabletopGameManagementSystem.Services;

namespace TabletopGameManagementSystem.CustomControls.Views
{

    public partial class GameSelector : UserControl
    {

        // Stored criteria coming from SelectorMenu via SelectorView
        private SelectorCriteria _criteria;
   
        private List<string> _categories = new List<string>();
        private List<string> _collections = new List<string>();

        public void SetCriteria(SelectorCriteria criteria)
        {
            _criteria = criteria;
        }

        private IGameLibrary _library;

        public GameSelector(IGameLibrary library)
        {
            InitializeComponent();
            spin_btn.Click += spin_btn_Click;
        }

        public void Initialize(IGameLibrary library)
        {
            _library = library;
        }

        public event EventHandler SpinButtonClicked;

        private void spin_btn_Click(object sender, EventArgs e)
        {
            // Raise the event so SelectorView can handle criteria collection
            SpinButtonClicked?.Invoke(this, EventArgs.Empty);

            if (_criteria == null)
            {
                MessageBox.Show("Please set your filters before spinning.", "No criteria",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            var selectedGames = SelectGames(_criteria, _criteria.Categories, _criteria.SelectedCollections);
            if (selectedGames.Count == 0)
            {
                MessageBox.Show("No games matched your criteria.", "No games", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            string gameList = string.Join(Environment.NewLine, selectedGames.Select(g => g.Name));
            MessageBox.Show(gameList, "Selected Games", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        public void ReceiveCriteria(SelectorCriteria criteria)
        {
            // Ensure criteria exists
            _criteria = criteria ?? new SelectorCriteria();

            // Ensure lists are never null
            _criteria.Categories ??= new List<string>();
            _criteria.SelectedCollections ??= new List<string>();
            _categories = _criteria.Categories;
            _collections = _criteria.SelectedCollections;

            // Set default numeric values if they are not provided
            _criteria.PlayerCount ??= 0;        // 0 means any number of players
            _criteria.AgeSuitability ??= 0;     // 0 means any age
            _criteria.PlayingTime ??= 0;        // 0 means any playing time
            _criteria.NumberOfGames = Math.Max(1, _criteria.NumberOfGames); // at least 1 game
        }


        private List<Game> SelectGames(SelectorCriteria criteria, List<string> categories, List<string> collections)
        {
            if (criteria == null) return new List<Game>();

            var allGames = _library.GetAllGames() ?? new List<Game>();

            // Start with owned games
            //var filtered = allGames.Where(g => g.IsOwned).ToList();
            
            //temp for testing --> remove when owned games are stored
            var filtered = allGames.ToList();

            // Player count filter (0 means any)
            if (criteria.PlayerCount > 0)
            {
                filtered = filtered.Where(g => g.MinPlayers <= criteria.PlayerCount && g.MaxPlayers >= criteria.PlayerCount).ToList();
            }

            // Playing time filter (0 means any)
            if (criteria.PlayingTime > 0)
            {
                filtered = filtered.Where(g => g.PlayingTime <= criteria.PlayingTime).ToList();
            }

            // Age suitability filter (0 means any)
            if (criteria.AgeSuitability > 0)
            {
                filtered = filtered.Where(g => g.AgeSuitability <= criteria.AgeSuitability).ToList();
            }

            // Filter by categories if any selected
            if (categories != null && categories.Count > 0)
            {
                filtered = filtered.Where(g => g.Categories != null && g.Categories.Any(c => categories.Contains(c))).ToList();
            }

            // Filter by collections if any selected
            if (collections != null && collections.Count > 0)
            {
                var allCollections = _library.GetAllCollections() ?? new List<Collection>();
                filtered = filtered.Where(g =>
                    allCollections.Any(col => collections.Contains(col.Name) && (col.GameIds?.Contains(g.ID) ?? false))
                ).ToList();
            }

            // Shuffle
            var rng = new Random();
            for (int i = filtered.Count - 1; i > 0; i--)
            {
                int j = rng.Next(i + 1);
                var temp = filtered[i];
                filtered[i] = filtered[j];
                filtered[j] = temp;
            }

            // Pick the requested number of games (at least 1)
            int take = Math.Max(1, criteria.NumberOfGames);
            return filtered.Take(take).ToList();
        }


    }
}
