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
    public partial class InputDialog : Form
    {
        public string NameValue => txtName.Text.Trim();
        public string DescriptionValue => txtDescription.Text.Trim();


        public InputDialog(string name = "", string description = "")
        {
            InitializeComponent();

            
            txtName.Text = name;
            txtDescription.Text = description;

            this.AcceptButton = btnOK;       // Enter triggers OK
            this.CancelButton = btnCancel;   // Esc triggers Cancel
        }

    }
}
