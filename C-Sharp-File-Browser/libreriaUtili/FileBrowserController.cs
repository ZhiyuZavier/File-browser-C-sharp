using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Collections.Specialized;

namespace libreriaUtili
{
    public class FileBrowserController
    {
        public fileBrowser theBoundary;
        public Path thePath;        

        public FileBrowserController(fileBrowser newBoundary)
        {
            theBoundary = newBoundary;
            thePath = new Path();       
        }

        public void reName(ListView listViewFilesAndFolders)
        {
            if (listViewFilesAndFolders.SelectedItems.Count == 1)
            {
                string filename = listViewFilesAndFolders.SelectedItems[0].Tag.ToString();
                FileInfo fi = new FileInfo(filename);
                inputDialog i = new inputDialog("Rename", fi.Name);
                if (DialogResult.OK == i.ShowDialog())
                {
                    try
                    {
                        //if (File.Exists(filename)) File.Move(filename, fi.DirectoryName + @"\" + i.inputText);
                        //else if (Directory.Exists(filename)) Directory.Move(filename, fi.DirectoryName + @"\" + i.inputText);
                        if (thePath.isFileExisted(filename))
                        {
                            thePath.moveFile(filename, fi.DirectoryName + @"\" + i.inputText);
                        }
                        else if (thePath.isDirectoryExisted(filename))
                        {
                            thePath.moveDirectory(filename, fi.DirectoryName + @"\" + i.inputText);
                        }
                    }
                    catch (IOException ioe)
                    {
                        MessageBox.Show("Error: " + ioe.Message);
                    }
                }
            }
        }

        public void moveUp(ListView listViewFilesAndFolders, StringCollection folderCol)
        {
            if ((listViewFilesAndFolders.SelectedItems.Count == 1) && (folderCol.Count > 1))
            {
                string filename = listViewFilesAndFolders.SelectedItems[0].Tag.ToString();
                FileInfo fi = new FileInfo(filename);
                try
                {
                    //if (File.Exists(filename)) File.Move(filename, folderCol[folderCol.Count - 2] + @"\" + fi.Name);
                    //else if (Directory.Exists(filename)) Directory.Move(filename, folderCol[folderCol.Count - 2] + @"\" + fi.Name);
                    if (thePath.isFileExisted(filename))
                    {
                        thePath.moveFile(filename, folderCol[folderCol.Count - 2] + @"\" + fi.Name);
                    }
                    else if (thePath.isDirectoryExisted(filename))
                    {
                        thePath.moveDirectory(filename, folderCol[folderCol.Count - 2] + @"\" + fi.Name);
                    }
                }
                catch (IOException ioe)
                {
                    MessageBox.Show("Error: " + ioe.Message);
                }
            }
        }

    }
}
