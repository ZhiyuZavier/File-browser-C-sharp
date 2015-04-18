using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace libreriaUtili
{
    public class CreatFolderController
    {
        public FileBrowser theBoundary;
        public Folder theFolder;        

        public CreatFolderController(FileBrowser newBoundary)
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

        public void creatFolder(string path)
        {
            Directory.CreateDirectory(path);
        }
    }
}
