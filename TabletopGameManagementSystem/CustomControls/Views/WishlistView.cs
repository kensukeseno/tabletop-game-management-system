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
        public WishlistView() : this(null) { } // so designer won't get angry!
        public WishlistView(IGameLibrary gameLibrary)
        {
            InitializeComponent();

            _gameLibrary = gameLibrary;

            if (_gameLibrary != null)
            {
                var wishlistedGames = _gameLibrary.FindGames(new FilterCriteria { IsWishlisted = true });
                //gameCardContainer1.LoadGames(_gameLibrary, wishlistedGames);
            }

        }
    }
}
