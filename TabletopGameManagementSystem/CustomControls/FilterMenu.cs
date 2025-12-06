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
        private readonly IGameLibrary _gameLibrary;

        public event Action<FilterCriteria> OnFilterApplied;

        public FilterMenu() : this(null) { } // so designer won't get angry!
        public FilterMenu(IGameLibrary gameLibrary)
        {
            InitializeComponent();
            
            _gameLibrary = gameLibrary;
            if (_gameLibrary != null)
            {
                var categories = _gameLibrary.GetAllCategories() ?? new List<string>();
                clbCategories.Items.Clear();
                clbCategories.Items.AddRange(categories.ToArray());
            }


        }

        private void btnApply_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(numMinPlayers.Text)) numMinPlayers.Value = 0;
            if (string.IsNullOrWhiteSpace(numMaxPlayers.Text)) numMaxPlayers.Value = 0;
            if (string.IsNullOrWhiteSpace(numPlayingTime.Text)) numPlayingTime.Value = 0;
            if (string.IsNullOrWhiteSpace(numAge.Text)) numAge.Value = 0;

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
