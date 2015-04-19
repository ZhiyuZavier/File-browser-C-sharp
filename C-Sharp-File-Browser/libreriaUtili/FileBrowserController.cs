using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Collections.Specialized;

namespace libreriaUtili
{
    // Controller Class of the use cases: Navigate Directories, Rename file/folder and Move up file/folder
    public class FileBrowserController
    {
        public FileBrowser theBoundary;
        public Folder theFolder;        

        public FileBrowserController(FileBrowser newBoundary)
        {
            theBoundary = newBoundary;
            theFolder = new Folder();       
        }

        // Get current directory of a specific path
        public DirectoryInfo getDirectory(string root)
        {
            theFolder.setRoot(root);
            return theFolder.getDirectory();
        }

        // Get all folders inside of a specific directory
        public DirectoryInfo[] getSubDirectories(string root)
        {
            theFolder.setRoot(root);
            return theFolder.getSubDirectories();
        }

        // Get all files inside of a specific directory
        public FileInfo[] getFiles(string root)
        {
            theFolder.setRoot(root);
            return theFolder.getFiles();
        }

        // when the “rename” button is clicked, if user has chosen a folder or file item, 
        // the “rename” input dialog panel shows up.
        // User can change the folder or file name of the selected item.
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

        // when the “move up” button is clicked, if user has chosen a folder or file item, 
        // user can move the selected item from the current directory to its parent directory.
        public void moveUp(ListView listViewFilesAndFolders, StringCollection folderCol)
        {
            if ((listViewFilesAndFolders.SelectedItems.Count == 1) && (folderCol.Count > 1))
            {
                string filename = listViewFilesAndFolders.SelectedItems[0].Tag.ToString();
                FileInfo fi = new FileInfo(filename);
                try
                {                    
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
