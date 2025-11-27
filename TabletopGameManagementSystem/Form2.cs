using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TabletopGameManagementSystem.CustomControls;
using TabletopGameManagementSystem.CustomControls.Views;
using TabletopGameManagementSystem.Models;
using TabletopGameManagementSystem.Services;

namespace TabletopGameManagementSystem
{
    public partial class Form2 : Form
    {

        private GameLibrary _gameLibrary;
        private List<Game> _games;

        public Form2()
        {
            InitializeComponent();

            var _gameLibrary = new GameLibrary();       // intialize the game library service
            var _games = _gameLibrary.GetAllGames();    // build a list of games from the service

            Debug.WriteLine(_games.Count());

            navMenu1.OnMenuSelected += HandleNavigation;    // subscribe to navigation events
        }
        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void HandleNavigation(string viewName)
        {

            UserControl view = null;

            switch (viewName)
            {
                case "MyShelf":
                    view = new MyShelfView();
                    break;
                case "Collections":
                    view = new CollectionsView();
                    break;
                case "Wishlist":
                    view = new WishlistView(); //(_games.Where(g => g.IsWishlisted).ToList());
                    break;
                case "Games":
                    view = new AllGamesView();
                    break;
                case "Spin":
                    view = new SelectorView();
                    break;
            }

            if (view != null)
            {
                panelMain.Controls.Clear();
                view.Dock = DockStyle.Fill;
                panelMain.Controls.Add(view);
            }
        }



    }


}
