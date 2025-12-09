using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using TabletopGameManagementSystem.Models;
using TabletopGameManagementSystem.Services;
using static System.Net.Mime.MediaTypeNames;

namespace TabletopGameManagementSystem.CustomControls
{
    public partial class AddGame : UserControl
    {
        private readonly IGameLibrary _gameLibrary;
        public event Action<Game> OnGameAdded;

        public AddGame(IGameLibrary gameLibrary)
        {
            InitializeComponent();
            _gameLibrary = gameLibrary;

            var categories = _gameLibrary.GetAllCategories() ?? new List<string>();
            clbCategories.Items.Clear();
            clbCategories.Items.AddRange(categories.ToArray());
        }

        private void btnSaveNewGame_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtName.Text))
            {
                MessageBox.Show("Game name is required.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (clbCategories.CheckedItems.Count == 0)
            {
                MessageBox.Show("Please select at least one category.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (numMinPlayers.Value <= 0)
            {
                MessageBox.Show("Minimum players must be greater than 0.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (numMaxPlayers.Value <= 0)
            {
                MessageBox.Show("Maximum players must be greater than 0.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (numMinPlayers.Value > numMaxPlayers.Value)
            {
                MessageBox.Show("Minimum players cannot be greater than maximum players.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (numPlayingTime.Value <= 0)
            {
                MessageBox.Show("Playing time must be greater than 0.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (numAge.Value <= 0)
            {
                MessageBox.Show("Minimum age must be greater than 0.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }


            var newGame = new Game
            {
                Name = txtName.Text.Trim(),
                Desc = txtDescription.Text.Trim(),
                MinPlayers = (int)numMinPlayers.Value,
                MaxPlayers = (int)numMaxPlayers.Value,
                PlayingTime = (int)numPlayingTime.Value,
                AgeSuitability = (int)numAge.Value,
                IsWishlisted = false,
                IsOwned = false,
                IsFavorite = false,
                Categories = clbCategories.CheckedItems.Cast<string>().ToList()
            };

            _gameLibrary.AddGame(newGame);

            // Notify parent view
            OnGameAdded?.Invoke(newGame);
        }
    }
}
