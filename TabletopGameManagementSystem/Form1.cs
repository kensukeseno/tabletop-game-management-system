namespace TabletopGameManagementSystem
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void startBtn_Click(object sender, EventArgs e)
        {
            // app form open
            Form2 form2 = new Form2();

            form2.Show();
        }
    }
}
