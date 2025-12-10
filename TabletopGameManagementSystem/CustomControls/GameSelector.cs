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
using TabletopGameManagementSystem.Properties;
using TabletopGameManagementSystem.Services;

namespace TabletopGameManagementSystem.CustomControls.Views
{
    public partial class GameSelector : UserControl
    {
        private IGameLibrary _library;
        private SelectorCriteria _criteria;

        private List<string> _categories = new();
        private List<string> _collections = new();

        public GameSelector() : this(null) { }
        public GameSelector(IGameLibrary library)
        {
            InitializeComponent();
            _library = library;

            spin_btn.Click += spin_btn_Click;
        }


        public void Initialize(IGameLibrary library)
        {
            _library = library;
        }

        public event EventHandler SpinButtonClicked;

        private async void spin_btn_Click(object sender, EventArgs e)
        {
            ClearDisplayCards();

            // Reset to default background
            selectorLayoutPanel.BackgroundImage = Properties.Resources.record_logo_purple;

            PerformSpin();
        }

        public void ReceiveCriteria(SelectorCriteria criteria)
        {
            _criteria = criteria ?? new SelectorCriteria();

            // Ensure lists are never null
            _criteria.Categories ??= new List<string>();
            _criteria.SelectedCollections ??= new List<string>();
            _categories = _criteria.Categories;
            _collections = _criteria.SelectedCollections;

            // Numeric defaults
            _criteria.PlayerCount ??= 0;
            _criteria.AgeSuitability ??= 0;
            _criteria.PlayingTime ??= 0;
            _criteria.NumberOfGames = Math.Max(1, _criteria.NumberOfGames);
        }

        private void PerformSpin()
        {
            SpinButtonClicked?.Invoke(this, EventArgs.Empty);

            if (_criteria == null)
            {
                MessageBox.Show("Please set your filters before spinning.",
                    "No criteria", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            var selectedGames = SelectGames(
                _criteria,
                _criteria.Categories,
                _criteria.SelectedCollections
            );

            if (selectedGames.Count == 0)
            {
                MessageBox.Show("No games matched your criteria.",
                    "No games", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            DisplaySpinResults(selectedGames);
        }

        private void ClearDisplayCards()
        {
            foreach (Control ctrl in spinCardPanel.Controls.Cast<Control>().ToList())
            {
                if (ctrl != spin_btn)
                {
                    spinCardPanel.Controls.Remove(ctrl);
                    ctrl.Dispose();
                }
            }
        }

        private List<Game> SelectGames(
            SelectorCriteria criteria,
            List<string> categories,
            List<string> collections)
        {
            if (criteria == null)
                return new List<Game>();

            //var allGames = _library.GetAllGames() ?? new List<Game>(); //for testing
            //var filtered = allGames.ToList(); //used for testing

            var filter = new FilterCriteria
            {
                IsOwned = true
            };
            var filtered = _library.FindGames(filter) ?? new List<Game>();
           

            // Player count
            if (criteria.PlayerCount > 0)
                filtered = filtered.Where(g =>
                    g.MinPlayers <= criteria.PlayerCount &&
                    g.MaxPlayers >= criteria.PlayerCount).ToList();

            // Playing time
            if (criteria.PlayingTime > 0)
                filtered = filtered.Where(g =>
                    g.PlayingTime <= criteria.PlayingTime).ToList();

            // Age suitability
            if (criteria.AgeSuitability > 0)
                filtered = filtered.Where(g =>
                    g.AgeSuitability <= criteria.AgeSuitability).ToList();

            // Categories
            if (categories?.Count > 0)
                filtered = filtered.Where(g =>
                    g.Categories != null &&
                    g.Categories.Any(c => categories.Contains(c))
                ).ToList();

            // Collections
            if (collections?.Count > 0)
            {
                var allCollections = _library.GetAllCollections() ?? new List<Collection>();
                filtered = filtered.Where(g =>
                    allCollections.Any(col =>
                        collections.Contains(col.Name) &&
                        (col.GameIds?.Contains(g.ID) ?? false)
                    )
                ).ToList();
            }

            // Shuffle
            var rng = new Random();
            for (int i = filtered.Count - 1; i > 0; i--)
            {
                int j = rng.Next(i + 1);
                (filtered[i], filtered[j]) = (filtered[j], filtered[i]);
            }

            return filtered.Take(Math.Max(1, criteria.NumberOfGames)).ToList();
        }

        private void DisplaySpinResults(List<Game> selectedGames)
        {
            // Remove layout background
            selectorLayoutPanel.BackgroundImage = null;

            // Change to spin again mode
            spin_btn.Text = "Spin Again";

            // Max 8 cards
            var gamesToShow = selectedGames.Take(8).ToList();

            // Clear old cards, keep center button
            foreach (Control ctrl in spinCardPanel.Controls.Cast<Control>().ToList())
            {
                if (ctrl != spin_btn)
                {
                    spinCardPanel.Controls.Remove(ctrl);
                    ctrl.Dispose();
                }
            }

            spinCardPanel.Controls.Add(spin_btn, 1, 1);

            int gameIndex = 0;

            for (int row = 0; row < spinCardPanel.RowCount; row++)
            {
                for (int col = 0; col < spinCardPanel.ColumnCount; col++)
                {
                    if (row == 1 && col == 1) continue;

                    if (gameIndex >= gamesToShow.Count)
                        return;

                    var game = gamesToShow[gameIndex++];
                    var card = new SpinCard();

                    card.SetGame(game);
                    card.Dock = DockStyle.Fill;
                    card.Margin = new Padding(5);

                    spinCardPanel.Controls.Add(card, col, row);
                }
            }
        }
    }
}