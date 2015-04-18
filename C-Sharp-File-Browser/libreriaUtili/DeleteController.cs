using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace libreriaUtili
{
    public class DeleteController
    {
        public FileBrowser theBoundary;
        public Folder theFolder;

        public DeleteController(FileBrowser newBoundary)
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
