using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace libreriaUtili
{
    // Boundary Class of the cumstom control
    // When the main file browser view is showing, there are six buttons that user can click on. 
    // They are ¡°create folder¡±, ¡°delete¡±, ¡°refresh¡±, ¡°rename¡±, ¡°move up¡± and ¡°<<¡±.
    // And a list of files with their last modified time are shown.
    public partial class FileBrowser : UserControl
    {
        public System.Collections.Specialized.StringCollection folderCol;
        public CreatFolderController theCreatFolderController;
        public DeleteController theDeleteController;
        public DragToMoveController theDragToMoveController;
        public FileBrowserController theFileBrowserController;

        public string _ROOT = "";

        public FileBrowser()
        {
            InitializeComponent();
            folderCol = new System.Collections.Specialized.StringCollection();
            theCreatFolderController = new CreatFolderController(this);
            theDeleteController = new DeleteController(this);
            theDragToMoveController = new DragToMoveController(this);
            theFileBrowserController = new FileBrowserController(this);
        }

        // Load the fileBrowser user control
        private void fileBrowser_Load(object sender, EventArgs e)
        {
            PaintListView(_ROOT);
            folderCol.Add(_ROOT);
        }

        // Carry the data from the drag source and move to the target.
        private void listViewFilesAndFolders_DragEnter(object sender, DragEventArgs e)
        {            
            theDragToMoveController.dragEnter(e);
        }

        // Event handler of click action of the btnBackward
        private void btnBackward_Click(object sender, EventArgs e)
        {
            if (folderCol.Count > 1)
            {
                PaintListView(folderCol[folderCol.Count - 2].ToString());
                folderCol.RemoveAt(folderCol.Count - 1);
            }
            else
            {
                PaintListView(folderCol[0].ToString());
            }
        }

        //Begins a drag-and-drop operation in the ListView control.
        private void listViewFilesAndFolders_ItemDrag(object sender, ItemDragEventArgs e)
        {                        
            theDragToMoveController.startDrag(listViewFilesAndFolders);
        }

        // Write codes for the DragDrop event of the target control.
        private void listViewFilesAndFolders_DragDrop(object sender, DragEventArgs e)
        {            
            theDragToMoveController.startDrop(listViewFilesAndFolders, e, labelCurrentPath);
        }        

        // Write codes for the selection event of the file/folder selected
        private void listViewFilesAndFolders_ItemSelectionChanged(object sender, ListViewItemSelectionChangedEventArgs e)
        {
            string filename = e.Item.Tag.ToString();
            lbl_info_file.Text = "";
            if (File.Exists(filename))
            {
                //Write the file information in the appropriate label
                FileInfo fi = new FileInfo(filename);
                lbl_info_file.Text = "File: " + fi.Name + " | Size: " + theDragToMoveController.ToByteString(fi.Length);
            }
            btnMoveUp.Enabled = true;
            btnRename.Enabled = true;
            if (File.Exists(filename) || Directory.Exists(filename)) btnDelete.Enabled = true;
            else btnDelete.Enabled = false;
        }

        // Write codes for the activation event of the file/folder selected
        private void listViewFilesAndFolders_ItemActivate(object sender, EventArgs e)
        {
            System.Windows.Forms.ListView lw = (System.Windows.Forms.ListView)sender;
            string filename = lw.SelectedItems[0].Tag.ToString();

            if (lw.SelectedItems[0].ImageIndex != 1)
            {
                try
                {
                    System.Diagnostics.Process.Start(filename);
                }
                catch
                {
                    return;
                }
            }
            else
            {
                PaintListView(filename);
                folderCol.Add(filename);
            }
        }

        // Event handler of click action of the btnDelete
        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (listViewFilesAndFolders.SelectedItems.Count == 1)
            {
                string filename = listViewFilesAndFolders.SelectedItems[0].Tag.ToString();
                
                if (DialogResult.Yes == MessageBox.Show("PERMANENTLY delete the selected file?", "Deletion", MessageBoxButtons.YesNo, MessageBoxIcon.Question))
                {
                    try
                    {                        
                        if (theDeleteController.isFileExisted(filename))
                        {
                            theDeleteController.deleteFile(filename);
                        }
                        else if (theDeleteController.isDirectoryExisted(filename))
                        {
                            theDeleteController.deleteDirectory(filename);
                        }
                        listViewFilesAndFolders.Items.Remove(listViewFilesAndFolders.SelectedItems[0]);
                    }
                    catch (IOException ioe)
                    {
                        MessageBox.Show("Error: " + ioe.Message);
                    }
                }
            }
        }

        // Event handler of click action of the btnNewFolder
        private void btnNewFolder_Click(object sender, EventArgs e)
        {
            inputDialog i = new inputDialog("new folder", "");
            if (DialogResult.OK == i.ShowDialog())
            {
                //write codes for folder creation
                try
                {                    
                    theCreatFolderController.creatFolder(folderCol[folderCol.Count - 1] + @"\" + i.inputText);
                    PaintListView(folderCol[folderCol.Count - 1]);
                }
                catch (Exception ex1)
                {
                    MessageBox.Show("Error: " + ex1.Message);
                }
            }
        }

        // Event handler of click action of the btnRename
        private void btnRename_Click(object sender, EventArgs e)
        {            
            theFileBrowserController.reName(listViewFilesAndFolders); 
            PaintListView(folderCol[folderCol.Count - 1]);
        }

        // Reload the whole ListView control for the current directory
        private void PaintListView(string root)
        {
            try
            {
                btnNewFolder.Enabled = true;
                btnDelete.Enabled = false;
                btnRefresh.Enabled = true;
                btnMoveUp.Enabled = false;
                btnRename.Enabled = false;

                ListViewItem lvi;
                ListViewItem.ListViewSubItem lvsi;

                if (root.CompareTo("") == 0)
                    return;
               
                DirectoryInfo dir = theCreatFolderController.getDirectory(root);
                DirectoryInfo[] dirs = theCreatFolderController.getSubDirectories(root);
                FileInfo[] files = theCreatFolderController.getFiles(root);

                this.listViewFilesAndFolders.Items.Clear();
                this.labelCurrentPath.Text = root;
                this.listViewFilesAndFolders.BeginUpdate();

                foreach (DirectoryInfo di in dirs)
                {
                    lvi = new ListViewItem();
                    lvi.Text = di.Name;
                    if (!lvi.Text.Equals("bin"))
                    {
                        lvi.Tag = di.FullName;
                        lvi.ImageIndex = 1;

                        lvsi = new ListViewItem.ListViewSubItem();
                        lvsi.Text = di.LastAccessTime.ToString();
                        lvi.SubItems.Add(lvsi);

                        this.listViewFilesAndFolders.Items.Add(lvi);
                    }
                }

                foreach (FileInfo fi in files)
                {
                    lvi = new ListViewItem();
                    lvi.Text = fi.Name;
                    lvi.Tag = fi.FullName;
                    switch (fi.Extension)
                    {
                        case ".png": lvi.ImageIndex = 16; break;
                        case ".mp3": lvi.ImageIndex = 15; break;
                        case ".avi": lvi.ImageIndex = 14; break;
                        case ".txt": lvi.ImageIndex = 13; break;
                        case ".xls": lvi.ImageIndex = 12; break;
                        case ".ppt": lvi.ImageIndex = 11; break;
                        case ".pdf": lvi.ImageIndex = 10; break;
                        case ".jpg": lvi.ImageIndex = 9; break;
                        case ".gif": lvi.ImageIndex = 8; break;
                        case ".doc": lvi.ImageIndex = 7; break;
                        case ".zip": lvi.ImageIndex = 6; break;
                        default: lvi.ImageIndex = 0; break;
                    }
                    lvsi = new ListViewItem.ListViewSubItem();
                    lvsi.Text = fi.LastAccessTime.ToString();
                    lvi.SubItems.Add(lvsi);
                    this.listViewFilesAndFolders.Items.Add(lvi);
                }
                this.listViewFilesAndFolders.EndUpdate();
            }
            catch (System.Exception err)
            {
                MessageBox.Show("Error: " + err.Message);
            }
        }

        // Event handler of click action of the btnRefresh
        private void btnRefresh_Click(object sender, EventArgs e)
        {
            PaintListView(folderCol[folderCol.Count - 1]);
        }

        // Event handler of click action of the btnMoveUp
        private void btnMoveUp_Click(object sender, EventArgs e)
        {            
            theFileBrowserController.moveUp(listViewFilesAndFolders, folderCol);
            PaintListView(folderCol[folderCol.Count - 1]);
        }

    }
}
