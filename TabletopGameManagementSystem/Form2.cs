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

        private IGameLibrary _gameLibrary;

        public Form2()
        {
            this.SetStyle(ControlStyles.OptimizedDoubleBuffer, true);
            this.UpdateStyles();

            InitializeComponent();

            _gameLibrary = new SQLGameLibrary();       // intialize the game library service

            navMenu1.OnMenuSelected += HandleNavigation;
            //HandleNavigation("Games"); // show All Games on startup
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
                    view = new MyShelfView(_gameLibrary);
                    titleLabel.Text = "My Shelf";
                    break;
                case "Collections":
                    view = new CollectionsView(_gameLibrary);
                    titleLabel.Text = "Collections";
                    break;
                case "Wishlist":
                    view = new WishlistView(_gameLibrary);
                    titleLabel.Text = "Wishlist";
                    break;
                case "Games":
                    view = new AllGamesView(_gameLibrary);
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
