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

            _gameLibrary = new GameLibrary();       // intialize the game library service
            _games = _gameLibrary.GetAllGames();    // build a list of games from the service

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
                    titleLabel.Text = "My Shelf";
                    break;
                case "Collections":
                    view = new CollectionsView();
                    titleLabel.Text = "Collections";
                    break;
                case "Wishlist":
                    view = new WishlistView(); //(_games.Where(g => g.IsWishlisted).ToList());
                    titleLabel.Text = "Wishlist";
                    break;
                case "Games":
                    view = new AllGamesView(_games);
                    titleLabel.Text = "All Games";
                    break;
                case "Spin":
                    view = new SelectorView(_gameLibrary);
                    titleLabel.Text = "Game Selector";
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
