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

namespace TabletopGameManagementSystem.CustomControls.Views
{
    public partial class AllGamesView : UserControl
    {
        private List<Game> _games;

        public AllGamesView(List<Game> gameslist)
        {
            InitializeComponent();
            _games = gameslist;

            filterMenu1.OnFilterApplied += ApplyFilter;

            gameCardContainer1.LoadGames(_games);
        }

        private void ApplyFilter(Func<Game, bool> filter)
        {
            var filteredGames = _games.Where(filter).ToList();
            gameCardContainer1.LoadGames(filteredGames);
        }
    }
}
