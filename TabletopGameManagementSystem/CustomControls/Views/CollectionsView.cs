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

namespace TabletopGameManagementSystem.CustomControls
{
    public partial class CollectionsView : UserControl
    {
        private readonly IGameLibrary _gameLibrary;

        public CollectionsView() : this(null) { }

        public CollectionsView(IGameLibrary gameLibrary)
        {
            InitializeComponent();
            _gameLibrary = gameLibrary;

            if (_gameLibrary != null)
            {
                var collectionGames = _gameLibrary.GetAllGames();
                //gameCardContainer1.LoadGames(_gameLibrary, collectionGames);
            }
        }

    }
}
