namespace HelloWindowsForms
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void bUpdateText_Click(object sender, EventArgs e)
        {
            tbDemoText.Text = "Hello";
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}