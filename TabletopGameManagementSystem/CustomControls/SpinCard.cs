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
    public partial class SpinCard : UserControl
    {
        public SpinCard()
        {
            InitializeComponent();
        }

        public void SetGame(Game game) 
        {
            titleLabel.Text = game.Name;
        }
    }
}
