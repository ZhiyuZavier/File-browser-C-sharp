using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace libreriaUtili
{
    // Controller Class of the use case: Creat Folder
    public class CreatFolderController
    {
        public FileBrowser theBoundary;
        public Folder theFolder;        

        public CreatFolderController(FileBrowser newBoundary)
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

        // Create a folder in the current directory.
        public void creatFolder(string path)
        {
            Directory.CreateDirectory(path);
        }
    }
}
