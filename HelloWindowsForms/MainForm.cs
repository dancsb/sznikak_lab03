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

        private void MainForm_Load(object sender, EventArgs e)
        {
            TreeNode root = treeView1.Nodes.Add("Local Disk (C:)");
            root.Tag = new DirectoryInfo("C:\\");
            root.Nodes.Add("");
        }
    }
}