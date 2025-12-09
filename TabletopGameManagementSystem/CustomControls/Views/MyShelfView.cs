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
    public partial class MyShelfView : UserControl
    {
        private readonly IGameLibrary _gameLibrary;
        private FilterCriteria _lastCriteria;


        public MyShelfView() : this(null) { } // so designer won't get angry!

        public MyShelfView(IGameLibrary gameLibrary)
        {
            InitializeComponent();

            _gameLibrary = gameLibrary;

            filterMenu1.OnFilterApplied += ApplyFilter;

            var ownedGames = _gameLibrary.FindGames(new FilterCriteria { IsOwned = true });
            gameCardContainer1.LoadGames(_gameLibrary, ownedGames);

            // listen for removals
            gameCardContainer1.GameRemovedFromContainer += () => RefreshGames();
        }

        private void ApplyFilter(FilterCriteria criteria)
        {
            criteria.IsOwned = true; //always owned

            if ( _lastCriteria != null && _lastCriteria.IsIdentical(criteria) )
                return;

            var filteredGames = _gameLibrary.FindGames(criteria);
            gameCardContainer1.LoadGames(_gameLibrary, filteredGames ?? new List<Game>());
            _lastCriteria = criteria;
        }

        private void RefreshGames()
        {
            var filteredGames = _gameLibrary.FindGames(_lastCriteria ?? new FilterCriteria { IsOwned = true });
            gameCardContainer1.LoadGames(_gameLibrary, filteredGames ?? new List<Game>());
        }


    }
}
