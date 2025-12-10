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
using TabletopGameManagementSystem.CustomControls;


namespace TabletopGameManagementSystem.CustomControls
{
    public partial class SelectGameForm : Form
    {
        private readonly IGameLibrary _gameLibrary;
        public Game SelectedGame { get; private set; }

        public SelectGameForm(List<Game> allGames, IGameLibrary gameLibrary)
        {
            InitializeComponent();
            _gameLibrary = gameLibrary;

            gameCardContainer1.LoadGames(_gameLibrary, allGames, CardMode.AddCollection);

            // hook into GameRemoved event (used here as "selected")
            foreach (GameCardFull card in gameCardContainer1.Controls.OfType<GameCardFull>())
            {
                card.GameRemoved += (s, game) =>
                {
                    SelectedGame = game;
                    this.DialogResult = DialogResult.OK;
                    this.Close();
                };
            }

            btnCancel.Click += (s, e) => this.DialogResult = DialogResult.Cancel;
        }
    }
}
