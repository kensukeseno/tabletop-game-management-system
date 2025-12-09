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
        private GameLibrary _library;

        CheckedListBox categoryCheckedListBox;   
        CheckedListBox collectionCheckedListBox;

        internal SelectorView(GameLibrary library)
        {
            InitializeComponent();
            //selectorMenu1.Initialize(library);
            gameSelector1.SpinButtonClicked += GameSelector1_SpinButtonClicked;
        }

        private void GameSelector1_SpinButtonClicked(object sender, EventArgs e)
        {
            // Collect current criteria from SelectorMenu
            var criteria = selectorMenu1.BuildCriteria();

            // Pass criteria to GameSelector
            gameSelector1.ReceiveCriteria(criteria);
        }
    }
}
