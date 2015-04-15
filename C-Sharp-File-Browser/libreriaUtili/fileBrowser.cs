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
    public partial class fileBrowser : UserControl
    {
        private System.Collections.Specialized.StringCollection folderCol;

        public string _ROOT = "";

        public fileBrowser()
        {
            InitializeComponent();
            folderCol = new System.Collections.Specialized.StringCollection();
        }

        private void fileBrowser_Load(object sender, EventArgs e)
        {
            PaintListView(_ROOT);
            folderCol.Add(_ROOT);
        }

        private void listViewFilesAndFolders_DragEnter(object sender, DragEventArgs e)
        {
            int len = e.Data.GetFormats().Length - 1;
            int i;
            for (i = 0; i <= len; i++)
            {
                if (e.Data.GetFormats()[i].Equals("System.Windows.Forms.ListView+SelectedListViewItemCollection"))
                {
                    //The data from the drag source is moved to the target.	
                    e.Effect = DragDropEffects.Move;
                }
            }
        }

        private void btn_indietro_Click(object sender, EventArgs e)
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

        private void listViewFilesAndFolders_ItemDrag(object sender, ItemDragEventArgs e)
        {
            //Begins a drag-and-drop operation in the ListView control.
            listViewFilesAndFolders.DoDragDrop(listViewFilesAndFolders.SelectedItems, DragDropEffects.Move);
        }

        private void listViewFilesAndFolders_DragDrop(object sender, DragEventArgs e)
        {
            //Return if the items are not selected in the ListView control.
            if (listViewFilesAndFolders.SelectedItems.Count == 0)
            {
                return;
            }
            //Returns the location of the mouse pointer in the ListView control.
            Point cp = listViewFilesAndFolders.PointToClient(new Point(e.X, e.Y));
            //Obtain the item that is located at the specified location of the mouse pointer.
            ListViewItem dragToItem = listViewFilesAndFolders.GetItemAt(cp.X, cp.Y);
            if (dragToItem == null)
            {
                return;
            }
            //Obtain the index of the item at the mouse pointer.
            int dragIndex = dragToItem.Index;
            ListViewItem[] sel = new ListViewItem[listViewFilesAndFolders.SelectedItems.Count];
            for (int i = 0; i <= listViewFilesAndFolders.SelectedItems.Count - 1; i++)
            {
                sel[i] = listViewFilesAndFolders.SelectedItems[i];
            }
            for (int i = 0; i < sel.GetLength(0); i++)
            {
                //Obtain the ListViewItem to be dragged to the target location.
                ListViewItem dragItem = sel[i];
                int itemIndex = dragIndex;
                if (itemIndex == dragItem.Index)
                {
                    return;
                }
                if (dragItem.Index < itemIndex)
                    itemIndex++;
                else
                    itemIndex = dragIndex + i;

                //Sposto i files dentro la cartella specificata
                if (Directory.Exists(labelCurrentPath.Text + "\\" + dragToItem.Text))
                {
                    if (File.Exists(dragItem.Tag.ToString()))
                        File.Move(labelCurrentPath.Text + "\\" + dragItem.Text, labelCurrentPath.Text + "\\" + dragToItem.Text + "\\" + dragItem.Text);
                    else if (Directory.Exists(dragItem.Tag.ToString()))
                        Directory.Move(labelCurrentPath.Text + "\\" + dragItem.Text, labelCurrentPath.Text + "\\" + dragToItem.Text + "\\" + dragItem.Text);
                    listViewFilesAndFolders.Items.Remove(dragItem);
                }
            }
        }

        public static string ToByteString(long bytes)
        {
            long kilobyte = 1024;
            long megabyte = 1024 * kilobyte;
            long gigabyte = 1024 * megabyte;
            long terabyte = 1024 * gigabyte;
            if (bytes > terabyte) return (bytes / terabyte).ToString("0.00 TB");
            else if (bytes > gigabyte) return (bytes / gigabyte).ToString("0.00 GB");
            else if (bytes > megabyte) return (bytes / megabyte).ToString("0.00 MB");
            else if (bytes > kilobyte) return (bytes / kilobyte).ToString("0.00 KB");
            else return bytes + " Bytes";
        }

        private void listViewFilesAndFolders_ItemSelectionChanged(object sender, ListViewItemSelectionChangedEventArgs e)
        {
            string filename = e.Item.Tag.ToString();
            lbl_info_file.Text = "";
            if (File.Exists(filename))
            {
                //Scrivo le informazioni del file nella label apposita
                FileInfo fi = new FileInfo(filename);
                lbl_info_file.Text = "File: " + fi.Name + " | Dimensione: " + ToByteString(fi.Length);
            }
            btn_sposta_su.Enabled = true;
            btn_rinomina.Enabled = true;
            if (File.Exists(filename) || Directory.Exists(filename)) btn_elimina.Enabled = true;
            else btn_elimina.Enabled = false;
        }

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

        private void btn_elimina_Click(object sender, EventArgs e)
        {
            if (listViewFilesAndFolders.SelectedItems.Count == 1)
            {
                string filename = listViewFilesAndFolders.SelectedItems[0].Tag.ToString();
                FileInfo fi = new FileInfo(filename);
                if (DialogResult.Yes == MessageBox.Show("Elimino DEFINITIVAMENTE il file selezionato?", "Eliminazione", MessageBoxButtons.YesNo, MessageBoxIcon.Question))
                {
                    try
                    {
                        if (File.Exists(filename)) File.Delete(filename);
                        else if (Directory.Exists(filename)) Directory.Delete(filename);
                        listViewFilesAndFolders.Items.Remove(listViewFilesAndFolders.SelectedItems[0]);
                    }
                    catch (IOException ioe)
                    {
                        MessageBox.Show("Errore: " + ioe.Message);
                    }
                }
            }
        }

        private void btn_nuova_cartella_Click(object sender, EventArgs e)
        {
            inputDialog i = new inputDialog("Nuova cartella", "");
            if (DialogResult.OK == i.ShowDialog())
            {
                //Codice di creazione della cartella
                try
                {
                    Directory.CreateDirectory(folderCol[folderCol.Count - 1] + @"\" + i.inputText);
                    PaintListView(folderCol[folderCol.Count - 1]);
                }
                catch (Exception ex1)
                {
                    MessageBox.Show("Errore: " + ex1.Message);
                }
            }
        }

        private void btn_rinomina_Click(object sender, EventArgs e)
        {
            if (listViewFilesAndFolders.SelectedItems.Count == 1)
            {
                string filename = listViewFilesAndFolders.SelectedItems[0].Tag.ToString();
                FileInfo fi = new FileInfo(filename);
                inputDialog i = new inputDialog("Rinomina", fi.Name);
                if (DialogResult.OK == i.ShowDialog())
                {
                    try
                    {
                        if (File.Exists(filename)) File.Move(filename, fi.DirectoryName + @"\" + i.inputText);
                        else if (Directory.Exists(filename)) Directory.Move(filename, fi.DirectoryName + @"\" + i.inputText);
                        PaintListView(folderCol[folderCol.Count - 1]);
                    }
                    catch (IOException ioe)
                    {
                        MessageBox.Show("Errore: " + ioe.Message);
                    }
                }
            }
        }

        private void PaintListView(string root)
        {
            try
            {
                btn_nuova_cartella.Enabled = true;
                btn_elimina.Enabled = false;
                btn_aggiorna.Enabled = true;
                btn_sposta_su.Enabled = false;
                btn_rinomina.Enabled = false;

                ListViewItem lvi;
                ListViewItem.ListViewSubItem lvsi;

                if (root.CompareTo("") == 0)
                    return;
                DirectoryInfo dir = new DirectoryInfo(root);
                DirectoryInfo[] dirs = dir.GetDirectories();
                FileInfo[] files = dir.GetFiles();

                this.listViewFilesAndFolders.Items.Clear();
                this.labelCurrentPath.Text = root;
                this.listViewFilesAndFolders.BeginUpdate();

                foreach (DirectoryInfo di in dirs)
                {
                    lvi = new ListViewItem();
                    lvi.Text = di.Name;
                    if (!lvi.Text.Equals("cestino"))
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

        private void btn_aggiorna_Click(object sender, EventArgs e)
        {
            PaintListView(folderCol[folderCol.Count - 1]);
        }

        private void btn_sposta_su_Click(object sender, EventArgs e)
        {
            if ((listViewFilesAndFolders.SelectedItems.Count == 1) && (folderCol.Count > 1))
            {
                string filename = listViewFilesAndFolders.SelectedItems[0].Tag.ToString();
                FileInfo fi = new FileInfo(filename);
                try
                {
                    if (File.Exists(filename)) File.Move(filename, folderCol[folderCol.Count - 2] + @"\" + fi.Name);
                    else if (Directory.Exists(filename)) Directory.Move(filename, folderCol[folderCol.Count - 2] + @"\" + fi.Name);
                    PaintListView(folderCol[folderCol.Count - 1]);
                }
                catch (IOException ioe)
                {
                    MessageBox.Show("Errore: " + ioe.Message);
                }
            }
        }

    }
}
