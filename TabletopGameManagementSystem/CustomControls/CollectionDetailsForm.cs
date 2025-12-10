using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TabletopGameManagementSystem.Services;
using TabletopGameManagementSystem.Models;

namespace TabletopGameManagementSystem.CustomControls
{
    public partial class CollectionDetailsForm : Form
    {
        private readonly Collection _collection;
        private readonly IGameLibrary _gameLibrary;

        public CollectionDetailsForm(Collection collection, IGameLibrary gameLibrary)
        {

            InitializeComponent();
            _collection = collection;
            _gameLibrary = gameLibrary;

            lblCollectionName.Text = collection.Name;
            lblDescription.Text = collection.Description;

            LoadGames();

        }

        private void LoadGames()
        {
            var allGames = _gameLibrary.GetAllGames();
            var gamesInCollection = allGames
                .Where(g => _collection.GameIds.Contains(g.ID))
                .ToList();

            gameCardContainer1.LoadGames(_gameLibrary, gamesInCollection, CardMode.RemoveCollection, _collection.ID);

            gameCardContainer1.GameRemovedFromContainer += () =>
            {
                // reload after a removal
                LoadGames();
            };
        }

        private void btnAddGame_Click(object sender, EventArgs e)
        {
            // Quick approach: show all games in a selection dialog
            var allGames = _gameLibrary.GetAllGames();

            using (var selectForm = new SelectGameForm(allGames, _gameLibrary))
            {
                if (selectForm.ShowDialog() == DialogResult.OK)
                {
                    var selectedGame = selectForm.SelectedGame;
                    _gameLibrary.AddGameToCollection(selectedGame.ID, _collection.ID);
                    _collection.GameIds.Add(selectedGame.ID);
                    LoadGames();
                }
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
