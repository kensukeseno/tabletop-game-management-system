using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TabletopGameManagementSystem.CustomControls
{

    public partial class NavMenu : UserControl
    {
        public event Action<string> OnMenuSelected; //event delegate for menu selection

        public NavMenu()
        {
            InitializeComponent();
        }

        private void NavMenu_Load(object sender, EventArgs e)
        {

        }

        private void btnMyShelf_Click(object sender, EventArgs e)
        {
            OnMenuSelected?.Invoke("MyShelf");
        }

        private void btnCollections_Click(object sender, EventArgs e)
        {
            OnMenuSelected?.Invoke("Collections");
        }

        private void btnWishlist_Click(object sender, EventArgs e)
        {
            OnMenuSelected?.Invoke("Wishlist");
        }

        private void btnGames_Click(object sender, EventArgs e)
        {
            OnMenuSelected?.Invoke("Games");
        }

        private void btnSpin_Click(object sender, EventArgs e)
        {
            OnMenuSelected?.Invoke("Spin");
        }
    }
}
