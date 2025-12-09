using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TabletopGameManagementSystem.CustomControls.Views;
using TabletopGameManagementSystem.Models;
using TabletopGameManagementSystem.Services;

namespace TabletopGameManagementSystem.CustomControls
{
    public partial class SelectorMenu : UserControl
    {
        internal IGameLibrary _library;

        public SelectorMenu()
        {
            InitializeComponent();
        }

        public void Setup(IGameLibrary library)
        {
            _library = library;

            // Populate checklists
            if (_library != null)
            {
                LoadOptions(_library);
            }

            // Set default numeric values
            numericUpDownPlayers.Value = 1;
            numericUpDownAge.Value = 12;
            numericUpDownPlayTime.Value = 60;
            numericUpDownGameCount.Value = 4;

            // Pre-select all categories
            for (int i = 0; i < categoryCheckedListBox.Items.Count; i++)
            {
                categoryCheckedListBox.SetItemChecked(i, true);
            }
  
        }

        // Event fired when user presses the spin button
        public event Action<SelectorCriteria> OnCriteriaCollected;

        public void CollectCriteriaAndRaiseEvent()
        {
            var criteria = BuildCriteria(); 
            OnCriteriaCollected?.Invoke(criteria);
        }



        // ------------------------------------------------------------------
        //                     Methods for user inputs
        // ------------------------------------------------------------------
        public SelectorCriteria BuildCriteria()
        {
            return new SelectorCriteria
            {
                PlayerCount = (int)numericUpDownPlayers.Value,
                AgeSuitability = (int)numericUpDownAge.Value,
                PlayingTime = (int)numericUpDownPlayTime.Value,
                NumberOfGames = (int)numericUpDownGameCount.Value,

                Categories = GetSelectedCategories(),
                SelectedCollections = GetSelectedCollections(),

                //OwnedOnly = true //temporarily ignore until myShelf is implimented
            };
        }


        //get multiple selected categories from a CheckedListBox
        public List<string> GetSelectedCategories()
        {
            return categoryCheckedListBox.CheckedItems
                .Cast<string>()
                .ToList();
        }

        //returns multiple selected collections
        public List<string> GetSelectedCollections()
        {
            return collectionCheckedListBox.CheckedItems
                .Cast<string>()
                .ToList();
        }

        internal void LoadOptions(IGameLibrary library)
        {
            if (library == null) return;

            // Fill categories
            var categories = library.GetAllCategories()?.OrderBy(c => c).ToList() ?? new List<string>();
            categoryCheckedListBox.Items.Clear();
            foreach (var cat in categories)
                categoryCheckedListBox.Items.Add(cat);

            // select all categories by default
            for (int i = 0; i < categoryCheckedListBox.Items.Count; i++)
                categoryCheckedListBox.SetItemChecked(i, true);

        }
    }
}
