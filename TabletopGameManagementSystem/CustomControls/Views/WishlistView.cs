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
    public partial class WishlistView : UserControl
    {
        private readonly IGameLibrary _gameLibrary;
        private FilterCriteria _lastCriteria;
        public WishlistView() : this(null) { } // so designer won't get angry!
        public WishlistView(IGameLibrary gameLibrary)
        {
            InitializeComponent();

            _gameLibrary = gameLibrary;

            filterMenu1.OnFilterApplied += ApplyFilter;
            filterMenu1.SetMyShelfMode();


            var wishlistedGames = _gameLibrary.FindGames(new FilterCriteria { IsWishlisted = true });
            gameCardContainer1.LoadGames(_gameLibrary, wishlistedGames, CardMode.Wishlist);

            // listen for removals
            gameCardContainer1.GameRemovedFromContainer += () => RefreshGames();
        }

        private void ApplyFilter(FilterCriteria criteria)
        {
            criteria.IsWishlisted = true; //always owned

            if (_lastCriteria != null && _lastCriteria.IsIdentical(criteria))
                return;

            var filteredGames = _gameLibrary.FindGames(criteria);
            gameCardContainer1.LoadGames(_gameLibrary, filteredGames ?? new List<Game>(), CardMode.Wishlist);
            _lastCriteria = criteria;
        }

        private void RefreshGames()
        {
            var filteredGames = _gameLibrary.FindGames(_lastCriteria ?? new FilterCriteria { IsWishlisted = true });
            gameCardContainer1.LoadGames(_gameLibrary, filteredGames ?? new List<Game>(), CardMode.Wishlist);
        }
    }
}
