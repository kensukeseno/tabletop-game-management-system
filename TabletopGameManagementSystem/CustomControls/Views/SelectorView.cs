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

namespace TabletopGameManagementSystem.CustomControls.Views
{
    public partial class SelectorView : UserControl
    {
        private readonly IGameLibrary _gameLibrary;

        // Designer-friendly constructor
        public SelectorView() : this(null) { }

        // Main constructor with dependency injection
        public SelectorView(IGameLibrary gameLibrary)
        {
            InitializeComponent();
            _gameLibrary = gameLibrary;
        }
    }

}
