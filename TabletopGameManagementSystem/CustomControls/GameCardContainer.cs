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


namespace TabletopGameManagementSystem.CustomControls
{
    public partial class GameCardContainer : UserControl
    {
        public event Action GameRemovedFromContainer;

        public GameCardContainer()
        {
            InitializeComponent();
        }

        public void LoadGames(IGameLibrary gameLibrary, List<Game> games)
        {
            this.Controls.Clear();

            foreach (var game in games)
            {
                var card = new GameCardFull(gameLibrary); // I want GameCardFull to use the same gameLibrary instance - consistency is key
                card.SetGame(game);
                card.Dock = DockStyle.Top;

                // inline lambda keeps gameLibrary in scope
                card.GameRemoved += (s, removedGame) =>
                {
                    var allGames = gameLibrary.GetAllGames();
                    GameRemovedFromContainer?.Invoke();
                };

                this.Controls.Add(card);
            }
        }

        //private void Card_GameRemoved(object sender, Game game)
        //{
        //    // reload the list after removal
        //    var allGames = new GameLibrary().GetAllGames();
        //    LoadGames(_gameLibrary, allGames);
        //}


    }
}
