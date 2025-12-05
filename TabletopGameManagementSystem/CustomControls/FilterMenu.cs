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
using static System.Net.Mime.MediaTypeNames;
using TabletopGameManagementSystem.Services;

namespace TabletopGameManagementSystem.CustomControls
{


    public partial class FilterMenu : UserControl
    {
        // Event that sends a filter back to the parent view
        public event Action<FilterCriteria> OnFilterApplied;

        private GameLibrary _gameLibrary = new GameLibrary();

        public FilterMenu()
        {
            InitializeComponent();

            clbCategories.Items.AddRange(_gameLibrary.GetAllCategories().ToArray());
        }

        private void btnApply_Click(object sender, EventArgs e)
        {
            var criteria = new FilterCriteria
            {
                NameContains = txtTitleFilter.Text.Trim(),
                MinPlayers = (int)numMinPlayers.Value,
                MaxPlayers = (int)numMaxPlayers.Value,
                PlayingTime = (int)numPlayingTime.Value,
                AgeSuitability = (int)numAge.Value,
                IsWishlisted = chkWishlist.Checked,
                IsOwned = chkOwned.Checked,
                IsFavorite = chkFavorite.Checked,
                Categories = clbCategories.CheckedItems.Cast<string>().ToList()
            };

            OnFilterApplied?.Invoke(criteria);
        }
    }
}
