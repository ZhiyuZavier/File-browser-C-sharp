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
        public FileBrowser theBoundary;
        public Folder theFolder;        

        public FileBrowserController(FileBrowser newBoundary)
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
                        if (theFolder.isFileExisted(filename))
                        {
                            theFolder.moveFile(filename, fi.DirectoryName + @"\" + i.inputText);
                        }
                        else if (theFolder.isDirectoryExisted(filename))
                        {
                            theFolder.moveDirectory(filename, fi.DirectoryName + @"\" + i.inputText);
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
                    if (theFolder.isFileExisted(filename))
                    {
                        theFolder.moveFile(filename, folderCol[folderCol.Count - 2] + @"\" + fi.Name);
                    }
                    else if (theFolder.isDirectoryExisted(filename))
                    {
                        theFolder.moveDirectory(filename, folderCol[folderCol.Count - 2] + @"\" + fi.Name);
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
