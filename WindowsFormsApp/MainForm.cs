using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.IO.Abstractions;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp
{
    public partial class MainForm : Form
    {
        public string MovePath { get; set; }
        public string CopyPath { get; set; }
        public MainForm()
        {
            InitializeComponent();
            DriveInfo[] drivers = DriveInfo.GetDrives();
            foreach (var driver in drivers)
            {
                if (driver.IsReady)
                {
                    TreeNode node = new TreeNode(driver.Name);
                    if (node.Text.Equals("C:\\")) node.ImageIndex = 3;
                    else node.ImageIndex = 19;
                    node.Name = driver.Name;
                    node.Tag = driver.Name;
                    var directories = Directory.EnumerateDirectories(driver.Name);
                    foreach (var folder in directories)
                    {
                        TreeNode childNode = new TreeNode(Path.GetFileName(folder));
                        childNode.Name = childNode.Text;
                        childNode.Tag = folder;
                        node.Nodes.Add(childNode);
                    }
                    FoldersTreeView.Nodes.Add(node);
                }
            }
        }

        private void FoldersTreeView_BeforeExpand(object sender, TreeViewCancelEventArgs e)
        {
            e.Node.Nodes.Clear();
            var rootDirectories = Directory.EnumerateDirectories(e.Node.Tag.ToString());
            foreach (var folder in rootDirectories)
            {
                TreeNode childNode = new TreeNode(Path.GetFileName(folder));
                childNode.Name = childNode.Text;
                childNode.Tag = folder;
                e.Node.Nodes.Add(childNode);
            }
            
            foreach (TreeNode folder in e.Node.Nodes)
            {
                try
                {
                    var directories = Directory.EnumerateDirectories(folder.Tag.ToString());
                    foreach (var childFolder in directories)
                    {
                        TreeNode childNode = new TreeNode(Path.GetFileName(childFolder));
                        childNode.Name = childNode.Text;
                        childNode.Tag = childFolder;
                        folder.Nodes.Add(childNode);
                    }
                    if(folder.Nodes.Count > 0)
                    {
                        folder.ImageIndex = 44;
                    }
                }
                catch (Exception ex)
                {
                    //MessageBox.Show(ex.Message);
                }
            }
        }
        private void FoldersTreeView_AfterSelect(object sender, TreeViewEventArgs e)
        {
            PathTextBox.Text = e.Node.Tag.ToString();
            e.Node.SelectedImageIndex = e.Node.ImageIndex;
            try
            {
                LoadFilesAndFolders(e.Node.Tag.ToString());
            }
            catch (Exception ex) { ElementsCountLabel.Text = "Elements: ?"; }
        }
        private void LoadFilesAndFolders(string path)
        {
            FilesListView.Items.Clear();
            var directories = Directory.EnumerateDirectories(path);
            foreach (var directory in directories)
            {
                ListViewItem item = new ListViewItem(Path.GetFileName(directory));
                item.Tag = directory;
                try
                {
                    if (Directory.GetFileSystemEntries(directory).Length > 0) item.ImageIndex = 44;
                    else item.ImageIndex = 24;
                }
                catch(Exception ex)
                {
                    item.ImageIndex = 28;
                }
                DirectoryInfo directoryInfo = new DirectoryInfo(directory);
                item.SubItems.Add(directoryInfo.LastWriteTime.ToShortDateString());
                item.SubItems.Add("folder");
                FilesListView.Items.Add(item);
            }
            var files = Directory.EnumerateFiles(path);
            foreach (var file in files)
            {
                ListViewItem item = new ListViewItem(Path.GetFileName(file));
                item.Tag = file;
                item.ImageIndex = 86;
                FileInfo fileInfo = new FileInfo(file);
                item.SubItems.Add(fileInfo.LastWriteTime.ToShortDateString());
                item.SubItems.Add(fileInfo.Extension.Replace(".", ""));
                item.SubItems.Add($"{(fileInfo.Length / 1024).ToString()} KB");
                FilesListView.Items.Add(item);
            }
            ElementsCountLabel.Text = $"Elements: {(directories.Count() + files.Count()).ToString()}";
        }
        private void LargeIconModeButton_Click(object sender, EventArgs e)
        {
            FilesListView.View = View.LargeIcon;
        }
        private void SmallIconModeButton_Click(object sender, EventArgs e)
        {
            FilesListView.View = View.SmallIcon;
        }
        private void ListModeButton_Click(object sender, EventArgs e)
        {
            FilesListView.View = View.List;
        }
        private void DetailModeButton_Click(object sender, EventArgs e)
        {
            FilesListView.View = View.Details;
        }
        private void FilesListView_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if(FilesListView.SelectedItems.Count == 1)
            {
                string path = FilesListView.SelectedItems[0].Tag.ToString();
                if (!Path.HasExtension(path))
                {
                    PathTextBox.Text = path;
                    string[] paths = path.Split('\\');
                    paths[0] += '\\';
                    var currentListNode = FoldersTreeView.Nodes;
                    int currentIndex = 0;
                    while(currentIndex < paths.Length)
                    {
                        foreach (TreeNode item in currentListNode)
                        {
                            if (item.Text.Equals(paths[currentIndex]))
                            {
                                item.Expand();
                                currentListNode = item.Nodes;
                            }
                            else
                            {
                                item.Collapse();
                            }
                        }
                        currentIndex++;
                    }
                    LoadFilesAndFolders(path);
                }
                else
                {
                    Process.Start(path);
                }
            }
            else if (FilesListView.SelectedItems.Count > 1)
            {
                foreach(ListViewItem item in FilesListView.SelectedItems)
                {
                    Process.Start(item.Tag.ToString());
                }
            }
        }
        private void BackPathButton_Click(object sender, EventArgs e)
        {
            if(PathTextBox.TextLength > 0 && PathTextBox.Text.Length - 1 != PathTextBox.Text.IndexOf('\\'))
            {
                int index = PathTextBox.Text.LastIndexOf('\\');
                PathTextBox.Text = PathTextBox.Text.Substring(0, index);
                if (PathTextBox.Text.IndexOf('\\') == -1) PathTextBox.Text += '\\';
                LoadFilesAndFolders(PathTextBox.Text);
            }
        }
        private void FilesListView_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                if (FilesListView.SelectedItems.Count > 0) FilesListView.ContextMenuStrip = contextMenuStrip1;
                else FilesListView.ContextMenuStrip = contextMenuStrip2;
            }
        }
        private void createFileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Create createFile = new Create();
            createFile.labelName.Text = "File name : ";
            var result = createFile.ShowDialog();
            if (result == DialogResult.OK)
            {
                var path = PathTextBox.Text + "\\" + createFile.CreatName;
                if (!Path.HasExtension(path)) path += ".txt";

                FileInfo fileInfo = new FileInfo(path);
                fileInfo.Create().Close(); 

                LoadFilesAndFolders(PathTextBox.Text);
            }
        }
        private void createFolderToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Create createFolder = new Create();
            createFolder.labelName.Text = "Folder name : ";
            var result = createFolder.ShowDialog();
            if (result == DialogResult.OK)
            {
                DirectoryInfo directoryInfo = new DirectoryInfo(PathTextBox.Text);
                if (directoryInfo.Exists)
                {
                    directoryInfo.CreateSubdirectory(createFolder.CreatName);
                    LoadFilesAndFolders(PathTextBox.Text);                   
                }
            }
        }
        private void insertMoveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                if (MovePath != null)
                {
                    DirectoryInfo directoryInfo = new DirectoryInfo(MovePath);
                    directoryInfo.MoveTo(PathTextBox.Text + "\\" + Path.GetFileName(MovePath));
                    MovePath = null;
                    try
                    {
                        LoadFilesAndFolders(PathTextBox.Text);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {            
            try
            {
                if (FilesListView.SelectedItems.Count == 1)
                {
                    string path = PathTextBox.Text + "\\" + FilesListView.SelectedItems[0].Text;

                    if (Path.HasExtension(FilesListView.SelectedItems[0].Text))
                    {
                        FileInfo fi = new FileInfo(path);
                        fi.Delete();
                    }
                    else
                    {
                        DirectoryInfo di = new DirectoryInfo(path);
                        di.Delete(true);
                    }
                }

                LoadFilesAndFolders(PathTextBox.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }        
        private void copyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (FilesListView.SelectedItems.Count == 1)  CopyPath = PathTextBox.Text + "\\" + FilesListView.SelectedItems[0].Text;
            
        }
        private void insertCopyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (CopyPath!=null)
            {
                try
                {
                    if (Path.HasExtension(CopyPath)) File.Copy(CopyPath, PathTextBox.Text + "\\" + Path.GetFileName(CopyPath));
                    else Copy(CopyPath, PathTextBox.Text + "\\" + Path.GetFileName(CopyPath));

                    LoadFilesAndFolders(PathTextBox.Text);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
        }
        public static void Copy(string sourceDirectory, string targetDirectory)
        {
            DirectoryInfo diSource = new DirectoryInfo(sourceDirectory);
            DirectoryInfo diTarget = new DirectoryInfo(targetDirectory);
                      

            try
            {
                 CopyAll(diSource, diTarget);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
        public static void CopyAll(DirectoryInfo source, DirectoryInfo target)
        {
            Directory.CreateDirectory(target.FullName);

            foreach (FileInfo fi in source.GetFiles())
            {
                Console.WriteLine(@"Copying {0}\{1}", target.FullName, fi.Name);
                fi.CopyTo(Path.Combine(target.FullName, fi.Name), true);
            }

            foreach (DirectoryInfo diSourceSubDir in source.GetDirectories())
            {
                DirectoryInfo nextTargetSubDir = target.CreateSubdirectory(diSourceSubDir.Name);
                CopyAll(diSourceSubDir, nextTargetSubDir);
            }
        }
        private void renameToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (FilesListView.SelectedItems.Count == 1)
            {

                string sourceFile = PathTextBox.Text + "\\" + FilesListView.SelectedItems[0].Text;
                FileInfo fi = new FileInfo(sourceFile);
                if (fi.Exists)
                {
                    Create rename = new Create();
                    rename.labelName.Text = "Rename : ";
                    var result = rename.ShowDialog();
                    if (result == DialogResult.OK)
                    {
                        fi.MoveTo(PathTextBox.Text + "\\" + rename.CreatName);
                    }
                    try
                    {
                        LoadFilesAndFolders(PathTextBox.Text);
                    }
                    catch (Exception) { }
                    return;
                }

                sourceFile = PathTextBox.Text + "\\" + FilesListView.SelectedItems[0].Text;
                DirectoryInfo directoryInfo = new DirectoryInfo(sourceFile);
                if (directoryInfo.Exists)
                {
                    Create rename = new Create();
                    rename.labelName.Text = "Rename : ";
                    var result = rename.ShowDialog();
                    if (result == DialogResult.OK)
                    {
                        directoryInfo.MoveTo(PathTextBox.Text + "\\" + rename.CreatName);
                    }
                }

                try
                {
                    LoadFilesAndFolders(PathTextBox.Text);
                }
                catch (Exception)
                { }
            }                   
        }
        private void MovetoolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (FilesListView.SelectedItems.Count == 1)
            {
                MovePath = PathTextBox.Text + "\\" + FilesListView.SelectedItems[0].Text;
            }
        }
    }
}
