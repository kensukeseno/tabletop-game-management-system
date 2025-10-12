using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TabletopGameManagementSystem.CustomControls; 

namespace TabletopGameManagementSystem
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();

            var panel = new RoundedPanel
            {
                BorderRadius = 20,
              
                Margin = new Padding(5)
            };

            tableLayoutPanel1.Controls.Add(panel, column: 0, row: 0);
        }
        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }


}
