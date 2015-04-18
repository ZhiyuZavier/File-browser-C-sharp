using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Windows.Forms;
using System.Drawing;

namespace libreriaUtili
{
    public class DragToMoveController
    {
        public FileBrowser theBoundary;
        public Folder theFolder;

        public DragToMoveController(FileBrowser newBoundary)
        {
            theBoundary = newBoundary;
            theFolder = new Folder();       
        }        

        public DirectoryInfo getDirectory(string root)
        {
            theFolder.setRoot(root);
            return theFolder.getDirectory();
        }

        public DirectoryInfo[] getSubDirectories(string root)
        {
            theFolder.setRoot(root);
            return theFolder.getSubDirectories();
        }

        public FileInfo[] getFiles(string root)
        {
            theFolder.setRoot(root);
            return theFolder.getFiles();
        }

        // 
        public void dragEnter(DragEventArgs e)
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

        //
        public void startDrag(ListView listViewFilesAndFolders)
        {
            //Begins a drag-and-drop operation in the ListView control.
            listViewFilesAndFolders.DoDragDrop(listViewFilesAndFolders.SelectedItems, DragDropEffects.Move);
        }

        public void startDrop(ListView listViewFilesAndFolders, DragEventArgs e, Label labelCurrentPath)
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
                //move the files into the folder specified
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

        public string ToByteString(long bytes)
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
    }
}
