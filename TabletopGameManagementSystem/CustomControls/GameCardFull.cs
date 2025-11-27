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
    public partial class GameCardFull : UserControl
    {
        private Game _game;

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

    }
}
