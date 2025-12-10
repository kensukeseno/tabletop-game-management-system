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


namespace TabletopGameManagementSystem.CustomControls
{
    public partial class CollectionCard : UserControl
    {
        private Collection _collection;


        public event EventHandler<Collection> CollectionOpened;
        public event EventHandler<Collection> CollectionDeleted;
        public event EventHandler<Collection> CollectionEdited;

        private static readonly Image CachedBackground = Properties.Resources.dk_grey_square; //cache background image for performance


        public CollectionCard() { }
        public CollectionCard(Collection collection)
        {
            InitializeComponent();
            _collection = collection;
            this.Size = new Size(295, 235);
            this.BackgroundImage = CachedBackground;
            RenderCard();
        }

        private void RenderCard()
        {
            lblName.Text = _collection.Name;
            lblDescription.Text = _collection.Description;
            lblGameCount.Text = $"{_collection.GameIds.Count} games";
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            var confirm = MessageBox.Show($"Delete collection '{_collection.Name}'?", "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (confirm == DialogResult.Yes)
                CollectionDeleted?.Invoke(this, _collection);
        }

        private void btnOpen_Click(object sender, EventArgs e)
        {
            CollectionOpened?.Invoke(this, _collection);
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            CollectionEdited?.Invoke(this, _collection);
        }
    }
}
