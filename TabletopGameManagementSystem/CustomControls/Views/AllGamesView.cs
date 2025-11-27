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

namespace TabletopGameManagementSystem.CustomControls.Views
{
    public partial class AllGamesView : UserControl
    {
        public AllGamesView(List<Game> gameslist)
        {
            InitializeComponent();
            gameCardContainer1.LoadGames(gameslist);
        }
    }
}
