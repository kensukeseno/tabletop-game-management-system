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
using TabletopGameManagementSystem.Services;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Window;


namespace TabletopGameManagementSystem.CustomControls
{
    public partial class CollectionsView : UserControl
    {
        private List<Collection> _collections;
        private readonly IGameLibrary _gameLibrary;

        public CollectionsView() : this(null) { }

        public CollectionsView(IGameLibrary gameLibrary)
        {
            InitializeComponent();
            _gameLibrary = gameLibrary;
            _collections = new List<Collection>();

            collectionContainer.CollectionOpened += CollectionContainer_CollectionOpened;
            collectionContainer.CollectionDeleted += CollectionContainer_CollectionDeleted;
            collectionContainer.CollectionEdited += CollectionContainer_CollectionEdited;


            LoadCollections();
        }

        public void LoadCollections()
        {
            _collections = _gameLibrary.GetAllCollections();
            collectionContainer.LoadCollections(_collections);
        }


        private void btnAddCollection_Click(object sender, EventArgs e)
        {
            using (var input = new InputDialog("New Collection Name"))
            {
                if (input.ShowDialog() == DialogResult.OK && !string.IsNullOrWhiteSpace(input.NameValue))
                {
                    var newCollection = new Collection
                    {
                        Name = input.NameValue,
                        Description = input.DescriptionValue,
                        GameIds = new List<int>()
                    };

                    _gameLibrary.AddCollection(newCollection);
                    LoadCollections();
                }
            }

        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            LoadCollections();
        }

        private void CollectionContainer_CollectionOpened(object sender, Collection collection)
        {
            using (var form = new CollectionDetailsForm(collection, _gameLibrary))
            {
                form.ShowDialog();   // blocks until the modal is closed
            }

        }

        private void CollectionContainer_CollectionDeleted(object sender, Collection collection)
        {
            _gameLibrary.DeleteCollection(collection.ID);
            LoadCollections();
        }

        private void CollectionContainer_CollectionEdited(object sender, Collection collection)
        {
            using (var dialog = new InputDialog(collection.Name, collection.Description))
            {
                if (dialog.ShowDialog() == DialogResult.OK && !string.IsNullOrWhiteSpace(dialog.NameValue))
                {
                    // Update in-memory object
                    collection.Name = dialog.NameValue;
                    collection.Description = dialog.DescriptionValue;

                    // Persist to database
                    _gameLibrary.UpdateCollection(collection.ID, collection.Name, collection.Description);

                    // Reload from DB to ensure sync
                    LoadCollections();
                }
            }
        }





    }
}
