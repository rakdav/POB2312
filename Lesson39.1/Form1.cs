namespace Lesson39._1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonChoice_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                string rootPath = new FileInfo(openFileDialog1.FileName).DirectoryName!;
                DirectoryInfo root = new DirectoryInfo(rootPath);
                TreeNode child = new TreeNode(root.Name);
                PrintTree(child, root, 0);
            }
        }
        public void PrintTree(TreeNode parent,DirectoryInfo directory,int level)
        {
            DirectoryInfo[] directories = directory.GetDirectories();
            for (int i = 0; i < directories.Length; i++)
            {
                TreeNode child = new TreeNode(directories[i].Name);
                parent.Nodes.Add(child);
                PrintTree(child, directories[i],level+1);
            }
            if (level == 0)
            {
                treeView1.Nodes.Add(parent);
            }
        }
    }
}