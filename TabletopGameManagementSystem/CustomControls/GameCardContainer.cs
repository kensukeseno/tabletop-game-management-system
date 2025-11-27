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


namespace TabletopGameManagementSystem.CustomControls
{
    public partial class GameCardContainer : UserControl
    {
        public GameCardContainer()
        {
            InitializeComponent();
        }

        public void LoadGames(List<Game> games)
        {
            this.Controls.Clear();

            foreach (var game in games)
            {
                var card = new GameCardFull();
                card.SetGame(game);
                card.Dock = DockStyle.Top;
                this.Controls.Add(card);
            }
        }

    }
}
