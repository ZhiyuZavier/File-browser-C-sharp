using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace libreriaUtili
{
    public class CreatFolderController
    {
        public fileBrowser theBoundary;
        public Path thePath;        

        public CreatFolderController(fileBrowser newBoundary)
        {
            theBoundary = newBoundary;
            thePath = new Path();       
        }

        //public void getFilePath()
        //{
        //    dir = theFile.getDirectory();
        //    dirs = theFile.getSubDirectories();
        //    files = theFile.getFiles();
        //}

        public DirectoryInfo getDirectory(string root)
        {
            thePath.setRoot(root);
            return thePath.getDirectory();
        }

        public DirectoryInfo[] getSubDirectories(string root)
        {
            thePath.setRoot(root);
            return thePath.getSubDirectories();
        }

        public FileInfo[] getFiles(string root)
        {
            thePath.setRoot(root);
            return thePath.getFiles();
        }

        public void creatFolder(string path)
        {
            Directory.CreateDirectory(path);
        }
    }
}
