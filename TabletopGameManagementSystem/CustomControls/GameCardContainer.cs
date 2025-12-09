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

        public void LoadGames(IGameLibrary gameLibrary, List<Game> games, CardMode mode)
        {
            this.Controls.Clear();

            foreach (var game in games.AsEnumerable().Reverse())
            {
                var card = new GameCardFull(gameLibrary); // I want GameCardFull to use the same gameLibrary instance - consistency is key
                card.SetGame(game);
                card.SetMode(mode);
                card.Dock = DockStyle.Top;

                // inline lambda keeps gameLibrary in scope
                card.GameRemoved += (s, removedGame) =>
                    GameRemovedFromContainer?.Invoke();

                this.Controls.Add(card);
            }

        }

    }
}
