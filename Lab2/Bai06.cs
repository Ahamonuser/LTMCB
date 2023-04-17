using System.IO;
using System.Windows.Forms;

namespace TestLab2
{
    public partial class Bai06 : Form
    {
        public Bai06()
        {
            InitializeComponent();
            DriveInfo[] drives = DriveInfo.GetDrives();
            foreach (DriveInfo drive in drives)
            {
                pathdisk = drive.Name;
                TreeNode root = new TreeNode(pathdisk);
                TreeDirectory.Nodes.Add(root);
                if (drive.Name == "D:\\") //Chỉ duyệt ổ D do ổ C duyệt lâu :v
                {
                    LoadExplorer(root);
                }
                root.Text = drive.VolumeLabel + " (" + pathdisk + ")";
                root.Name = drive.Name;
            }
        }

        string pathdisk;

        void LoadExplorer(TreeNode root)
        {
            if (root == null)
            {
                return;
            }
            try
            {
                DirectoryInfo[] listfolder = new DirectoryInfo(root.Text).GetDirectories();
                string[] listfile = Directory.GetFiles(root.Text);
                foreach (string item in listfile)
                {
                    FileInfo file = new FileInfo(item);
                    TreeNode filenode = new TreeNode(item);
                    root.Nodes.Add(filenode);
                    filenode.Name = item;
                    filenode.Text = file.Name;
                }
                foreach (DirectoryInfo item in listfolder)
                {
                    if (Directory.Exists(item.FullName))
                    {
                        TreeNode folder = new TreeNode(item.FullName);
                        root.Nodes.Add(folder);
                        LoadExplorer(folder);
                        folder.Name = item.FullName;
                        folder.Text = item.Name;
                    }
                }
            }
            catch
            {
                return;
            }
        }

        private void treeDirectory_NodeMouseDoubleClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            TreeNode node = e.Node;
            FileAttributes attr = File.GetAttributes(node.Name);
            while (!attr.HasFlag(FileAttributes.Directory) || node != null)
            {
                try
                {
                    attr = File.GetAttributes(node.Name);
                }
                catch (System.NullReferenceException)
                {
                    break;
                }
                node = node.NextNode;
            }
        }

        private void treeDirectory_NodeMouseClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            TreeNode node = e.Node;
            FileAttributes attr = File.GetAttributes(node.Name);
            if (!attr.HasFlag(FileAttributes.Directory))
            {
                try
                {
                    FilePictureContent.Load(node.Name);
                }
                catch (System.ArgumentException)
                {
                    MessageBox.Show("Not a picture file.", "Notice");
                }
            }
        }
    }
}
