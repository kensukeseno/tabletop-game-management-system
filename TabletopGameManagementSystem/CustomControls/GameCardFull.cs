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
        private readonly IGameLibrary _gameLibrary;

        public event EventHandler<Game> GameRemoved; // bubble up event

        public GameCardFull(IGameLibrary gameLibrary)
        {
            InitializeComponent();
            _gameLibrary = gameLibrary;
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
            AddDetailRow("Description", game.Desc);
        }

        private void AddDetailRow(string heading, string value)
        {
            int rowIndex = innerGamedetailsPanel.RowCount++;
            innerGamedetailsPanel.RowStyles.Add(new RowStyle(SizeType.AutoSize));

            var lblHeading = new Label { Text = heading, AutoSize = true, Font = new Font("Segoe UI", 9, FontStyle.Bold) };
            var lblValue = new Label { Text = value, AutoSize = true };
            lblValue.AutoEllipsis = true;
            lblValue.MaximumSize = new Size(400, 200);

            innerGamedetailsPanel.Controls.Add(lblHeading, 0, rowIndex);
            innerGamedetailsPanel.Controls.Add(lblValue, 1, rowIndex);
        }

        private void cbMyShelf_CheckedChanged(object sender, EventArgs e)
        {
            if (_game == null) return;

            _gameLibrary.ToggleOwned(_game.ID, cbMyShelf.Checked);
            _game.IsOwned = cbMyShelf.Checked;
        }

        private void cbWishlist_CheckedChanged(object sender, EventArgs e)
        {
            if (_game == null) return;

            _gameLibrary.ToggleWishlisted(_game.ID, cbWishlist.Checked);
            _game.IsWishlisted = cbWishlist.Checked;
        }

        private void cbFavorite_CheckedChanged(object sender, EventArgs e)
        {
            if (_game == null) return;

            _gameLibrary.ToggleFavorite(_game.ID, cbFavorite.Checked);
            _game.IsFavorite = cbFavorite.Checked;
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            if (_game == null) return;

            var confirm = MessageBox.Show( $"Are you sure you want to remove {_game.Name}?", "Confirm Delete", MessageBoxButtons.YesNo,MessageBoxIcon.Warning);

            if (confirm == DialogResult.Yes)
            {
                _gameLibrary.DeleteGame(_game.ID);
                GameRemoved?.Invoke(this, _game); // notify container
            }

        }
    }
}
