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
        private CardMode _mode = CardMode.AllGames;
        private Game _game;
        private readonly IGameLibrary _gameLibrary;
        private int? _collectionId; // optional collection context

        private static readonly Image CachedBackground = Properties.Resources.dk_grey_square; //cache background image for performance
        public event EventHandler<Game> GameRemoved; // bubble up event

        public GameCardFull(IGameLibrary gameLibrary)
        {
            InitializeComponent();
            _gameLibrary = gameLibrary;
            this.BackgroundImage = CachedBackground;
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

        public void SetMode(CardMode mode, int? collectionId = null)
        {
            _mode = mode;
            _collectionId = collectionId; //not used here but this is where it "lands"

            switch (mode)
            {
                case CardMode.AllGames:
                    cbMyShelf.Visible = true;
                    cbWishlist.Visible = true;
                    btnRemove.Text = "Delete";
                    break;

                case CardMode.MyShelf:
                    cbMyShelf.Visible = false;
                    cbWishlist.Visible = true;
                    btnRemove.Text = "Remove";
                    break;

                case CardMode.Wishlist:
                    cbMyShelf.Visible = true;
                    cbWishlist.Visible = false;
                    btnRemove.Text = "Remove";
                    break;

                case CardMode.AddCollection:
                    cbMyShelf.Visible = false;
                    cbWishlist.Visible = false;
                    btnRemove.Text = "Add";
                    break;

                case CardMode.RemoveCollection:
                    cbMyShelf.Visible = false;
                    cbWishlist.Visible = false;
                    btnRemove.Text = "Remove";
                    break;
            }
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

            switch (_mode)
            {
                case CardMode.AllGames:
                    RemoveFromDatabase();
                    break;

                case CardMode.MyShelf:
                    UnOwnGame();
                    GameRemoved?.Invoke(this, _game);
                    break;

                case CardMode.Wishlist:
                    UnWishlistGame();
                    GameRemoved?.Invoke(this, _game);
                    break;

                case CardMode.RemoveCollection:
                    RemoveFromCollection();
                    GameRemoved?.Invoke(this, _game);
                    break;

                case CardMode.AddCollection:
                    GameRemoved?.Invoke(this, _game); // selection handled by parent
                    break;
            }

        }


        

        private void RemoveFromDatabase()
        {
            var confirm = MessageBox.Show($"Are you sure you want to remove {_game.Name}?", "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (confirm == DialogResult.Yes)
            {
                _gameLibrary.DeleteGame(_game.ID);
                GameRemoved?.Invoke(this, _game); // notify container
            }
        }

        private void UnOwnGame()
        {
            var confirm = MessageBox.Show($"Are you sure you want to remove {_game.Name} from your shelf?", "Confirm Removal", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (confirm == DialogResult.Yes)
            {
                _gameLibrary.ToggleOwned(_game.ID, false);
                _game.IsOwned = false;
                GameRemoved?.Invoke(this, _game);
            }
        }

        private void UnWishlistGame()
        {
            var confirm = MessageBox.Show($"Are you sure you want to remmove {_game.Name} from your wishlist?", "Confirm Removal", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (confirm == DialogResult.Yes)
            {
                _gameLibrary.ToggleWishlisted(_game.ID, false);
                _game.IsWishlisted = false;
                GameRemoved?.Invoke(this, _game);
            }
        }

        private void RemoveFromCollection()
        {
            if (_collectionId == null) return;

            var confirm = MessageBox.Show($"Are you sure you want to remove {_game.Name} from the collection?", "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (confirm == DialogResult.Yes)
            {
                _gameLibrary.DeleteGame(_game.ID);
                _gameLibrary.DeleteGameFromCollection(_game.ID, _collectionId.Value);
                GameRemoved?.Invoke(this, _game);
            }
        }

    }
}
