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
using TabletopGameManagementSystem.Models;
using TabletopGameManagementSystem.Services;

namespace TabletopGameManagementSystem.CustomControls
{
    public partial class GameCardFull : UserControl
    {
        private Game _game;
        private GameLibrary _gameLibrary = new GameLibrary();

        public GameCardFull()
        {
            InitializeComponent();
        }

        public void SetGame(Game game)
        {
            _game = game;
            lblGameTitle.Text = game.Name;
            cbMyShelf.Checked = game.IsOwned;
            cbWishlist.Checked = game.IsWishlisted;
            cbFavorite.Checked = game.IsFavorite;

            innerGamedetailsPanel.Controls.Clear();
            innerGamedetailsPanel.RowStyles.Clear();
            innerGamedetailsPanel.RowCount = 0;

            AddDetailRow("Players", $"{game.MinPlayers}-{game.MaxPlayers}");
            AddDetailRow("Playing Time", $"{game.PlayingTime} mins");
            AddDetailRow("Age", $"{game.AgeSuitability}+");
        }

        private void AddDetailRow(string heading, string value)
        {
            int rowIndex = innerGamedetailsPanel.RowCount++;
            innerGamedetailsPanel.RowStyles.Add(new RowStyle(SizeType.AutoSize));

            var lblHeading = new Label { Text = heading, AutoSize = true, Font = new Font("Segoe UI", 9, FontStyle.Bold) };
            var lblValue = new Label { Text = value, AutoSize = true };

            innerGamedetailsPanel.Controls.Add(lblHeading, 0, rowIndex);
            innerGamedetailsPanel.Controls.Add(lblValue, 1, rowIndex);
        }

        private void cbMyShelf_CheckedChanged(object sender, EventArgs e)
        {
            if (_game == null) return;

            // toggle in GameLibrary
            _gameLibrary.ToggleOwned(_game.ID, cbMyShelf.Checked);

            // update local state
            _game.IsOwned = cbMyShelf.Checked;

            //Debug.WriteLine("Game ID :" + _game.ID + " | Is Owned:" +_game.IsOwned);
        }

        private void cbWishlist_CheckedChanged(object sender, EventArgs e)
        {
            if (_game == null) return;

            // toggle in GameLibrary
            _gameLibrary.ToggleWishlisted(_game.ID, cbWishlist.Checked);

            // update local state
            _game.IsWishlisted = cbWishlist.Checked;

        }

        private void cbFavorite_CheckedChanged(object sender, EventArgs e)
        {
            if (_game == null) return;

            // toggle in GameLibrary
            _gameLibrary.ToggleFavorite(_game.ID, cbFavorite.Checked);

            // update local state
            _game.IsFavorite = cbFavorite.Checked;
        }
    }
}
