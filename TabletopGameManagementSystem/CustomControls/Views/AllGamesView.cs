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
    public partial class AllGamesView : UserControl
    {
        private readonly IGameLibrary _gameLibrary;

        private FilterCriteria _lastCriteria; //keep track of last used
        public AllGamesView(IGameLibrary gameLibrary)
        {
            InitializeComponent();

            _gameLibrary = gameLibrary;

            filterMenu1.OnFilterApplied += ApplyFilter;

            // load everything first
            var allGames = _gameLibrary.GetAllGames();
            gameCardContainer1.LoadGames(_gameLibrary, allGames, CardMode.AllGames);

            // lambda to listen for removals bubbled up from container
            gameCardContainer1.GameRemovedFromContainer += () => RefreshGames();

            // Store initial criteria as null
            _lastCriteria = null;
        }

        private void ApplyFilter(FilterCriteria criteria)
        {
            if (_lastCriteria != null && _lastCriteria.IsIdentical(criteria))
                return; // no change, don't bother filtering

            var filteredGames = _gameLibrary.FindGames(criteria);
            gameCardContainer1.LoadGames(_gameLibrary, filteredGames ?? new List<Game>(), CardMode.AllGames); // load filtered list

            _lastCriteria = criteria; // update last used criteria
        }

        private void btnAddNewGame_Click(object sender, EventArgs e)
        {
            using (var form = new Form())
            {
                var addGameControl = new AddGame(_gameLibrary);
                addGameControl.Dock = DockStyle.Fill;

                // Wire up the event so we refresh after a game is added
                addGameControl.OnGameAdded += game =>
                {
                    RefreshGames();
                    form.DialogResult = DialogResult.OK;
                    form.Close();
                };

                form.Controls.Add(addGameControl);
                form.StartPosition = FormStartPosition.CenterParent;
                form.Size = new Size(500, 700); // Adjust as needed
                form.Text = "Add New Game";

                form.ShowDialog();
            }

        }

        //helper to refresh current view
        private void RefreshGames()
        {
            if (_lastCriteria != null)
            {
                var filteredGames = _gameLibrary.FindGames(_lastCriteria);
                gameCardContainer1.LoadGames(_gameLibrary, filteredGames ?? new List<Game>(), CardMode.AllGames);
            }
            else
            {
                var allGames = _gameLibrary.GetAllGames();
                gameCardContainer1.LoadGames(_gameLibrary, allGames, CardMode.AllGames);
            }
        }

    }
}
