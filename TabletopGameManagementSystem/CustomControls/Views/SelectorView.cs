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

            // Store the library FIRST
            _gameLibrary = gameLibrary;

            // Initialize GameSelector once
            if (gameSelector1 != null)
                gameSelector1.Initialize(_gameLibrary);

            // Initialize SelectorMenu once
            selectorMenu1.Setup(_gameLibrary);

            // Hook up events
            gameSelector1.SpinButtonClicked += GameSelector1_SpinButtonClicked;
        }


        // Event handler for Spin button
        private void GameSelector1_SpinButtonClicked(object sender, EventArgs e)
        {
            if (selectorMenu1 == null) return;

            // Collect current criteria from SelectorMenu
            var criteria = selectorMenu1.BuildCriteria();

            // Pass criteria to GameSelector
            gameSelector1.ReceiveCriteria(criteria);
        }
    }

}
