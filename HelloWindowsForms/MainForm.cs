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

        private void treeView1_BeforeExpand(object sender, TreeViewCancelEventArgs e)
        {
            DirectoryInfo parentDI = (DirectoryInfo)e.Node.Tag;
            e.Node.Nodes.Clear();
            try
            {
                foreach (DirectoryInfo dir in parentDI.GetDirectories())
                {
                    TreeNode node = new TreeNode(dir.Name);
                    node.Tag = dir;
                    node.Nodes.Add("");
                    e.Node.Nodes.Add(node);
                }
            }
            catch { }
        }

        private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {
            DirectoryInfo parentDI = (DirectoryInfo)e.Node.Tag;
            listView1.Items.Clear();
            try
            {
                foreach (FileInfo fi in parentDI.GetFiles())
                    listView1.Items.Add(fi.Name);
            }
            catch { }

            tbDemoText.Text = parentDI.FullName;
        }
    }
}