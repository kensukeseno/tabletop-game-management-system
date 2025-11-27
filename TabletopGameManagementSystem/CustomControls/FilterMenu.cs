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

namespace TabletopGameManagementSystem.CustomControls
{


    public partial class FilterMenu : UserControl
    {
        // Event that sends a filter function back to the parent view
        public event Action<Func<Game, bool>> OnFilterApplied;
        public FilterMenu()
        {
            InitializeComponent();
        }

        private void btnApply_Click(object sender, EventArgs e)
        {
            string titleFilter = txtTitleFilter.Text.Trim().ToLower();

            Func<Game, bool> filter = g =>
            {
                bool ok = true;

                // Title contains (like %text%)
                if (!string.IsNullOrEmpty(titleFilter))
                    ok &= g.Name != null && g.Name.ToLower().Contains(titleFilter);

                // Owned
                if (chkOwned.Checked)
                    ok &= g.IsOwned;

                // Wishlisted
                if (chkWishlist.Checked)
                    ok &= g.IsWishlisted;

                // Favorite
                if (chkFavorite.Checked)
                    ok &= g.IsFavorite;

                // Min Players
                if (numMinPlayers.Value > 0)
                    ok &= g.MinPlayers >= (int)numMinPlayers.Value;

                // Max Players
                if (numMaxPlayers.Value > 0)
                    ok &= g.MaxPlayers <= (int)numMaxPlayers.Value;

                // Playing Time
                if (numPlayingTime.Value > 0)
                    ok &= g.PlayingTime <= (int)numPlayingTime.Value;

                // Age Suitability
                if (numAge.Value > 0)
                    ok &= g.AgeSuitability <= (int)numAge.Value;

                return ok;
            };

            OnFilterApplied?.Invoke(filter);
        }
    }
}
