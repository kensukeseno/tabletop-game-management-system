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
    public partial class CollectionsContainer : UserControl
    {
        public event EventHandler<Collection> CollectionOpened;
        public event EventHandler<Collection> CollectionDeleted;
        public event EventHandler<Collection> CollectionEdited;

        public CollectionsContainer()
        {
            InitializeComponent();
        }

        public void LoadCollections(IEnumerable<Collection> collections)
        {
            flowLayoutPanel1.Controls.Clear();

            foreach (var collection in collections)
            {
                var card = new CollectionCard(collection);
                card.Margin = new Padding(10);

                // Bubble up events
                card.CollectionOpened += (s, c) => CollectionOpened?.Invoke(this, c);
                card.CollectionDeleted += (s, c) => CollectionDeleted?.Invoke(this, c);
                card.CollectionEdited += (s, c) => CollectionEdited?.Invoke(this, c);

                flowLayoutPanel1.Controls.Add(card);
            }
        }

        public void AddCollection(Collection collection)
        {
            var card = new CollectionCard(collection);
            card.Margin = new Padding(10);

            card.CollectionOpened += (s, c) => CollectionOpened?.Invoke(this, c);
            card.CollectionDeleted += (s, c) => CollectionDeleted?.Invoke(this, c);
            card.CollectionEdited += (s, c) => CollectionEdited?.Invoke(this, c);

            flowLayoutPanel1.Controls.Add(card);
        }

    }
}
