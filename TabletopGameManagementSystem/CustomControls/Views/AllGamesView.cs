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

            games_layoutPanel.Controls.Remove(filterMenu1);
            filterMenu1 = new FilterMenu(_gameLibrary);
            filterMenu1.OnFilterApplied += ApplyFilter;
            games_layoutPanel.Controls.Add(filterMenu1);


            // load everything first
            var allGames = _gameLibrary.GetAllGames();
            gameCardContainer1.LoadGames(_gameLibrary, allGames);

            // Store initial criteria as null
            _lastCriteria = null;
        }

        private void ApplyFilter(FilterCriteria criteria)
        {
            if (_lastCriteria != null && AreCriteriaEqual(_lastCriteria, criteria))
                return; // no change, don't bother filtering

            var filteredGames = _gameLibrary.FindGames(criteria);
            gameCardContainer1.LoadGames(_gameLibrary, filteredGames ?? new List<Game>()); // load filtered list

            _lastCriteria = criteria; // update last used criteria
        }

        private bool AreCriteriaEqual(FilterCriteria a, FilterCriteria b)
        {
            bool categoriesEqual = false;

            if (a.Categories == null && b.Categories == null)
                categoriesEqual = true;
            else if (a.Categories != null && b.Categories != null)
                categoriesEqual = a.Categories.SequenceEqual(b.Categories);

            return a.NameContains == b.NameContains &&
                   a.MinPlayers == b.MinPlayers &&
                   a.MaxPlayers == b.MaxPlayers &&
                   a.PlayingTime == b.PlayingTime &&
                   a.AgeSuitability == b.AgeSuitability &&
                   a.IsWishlisted == b.IsWishlisted &&
                   a.IsOwned == b.IsOwned &&
                   a.IsFavorite == b.IsFavorite &&
                   categoriesEqual;
        }
    }
}
