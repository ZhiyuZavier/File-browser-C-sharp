using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace libreriaUtili
{
    public class DeleteController
    {
        public fileBrowser theBoundary;
        public Path thePath;

        public DeleteController(fileBrowser newBoundary)
        {
            theBoundary = newBoundary;
            thePath = new Path();       
        }

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

        public bool isFileExisted(string filename)
        {
            return File.Exists(filename);
        }

        public void deleteFile(string filename)
        {
            File.Delete(filename);
        }

        public bool isDirectoryExisted(string filename)
        {
            return Directory.Exists(filename);
        }

        public void deleteDirectory(string filename)
        {
            Directory.Delete(filename);
        }
    }
}
