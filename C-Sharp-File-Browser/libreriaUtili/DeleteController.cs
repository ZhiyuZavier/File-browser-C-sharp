using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace libreriaUtili
{
    // Controller Class of the use case: Delete Folder/File
    public class DeleteController
    {
        public FileBrowser theBoundary;
        public Folder theFolder;

        public DeleteController(FileBrowser newBoundary)
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

        // Check a specific file existed or not
        public bool isFileExisted(string filename)
        {
            return File.Exists(filename);
        }

        // Delete a specific file
        public void deleteFile(string filename)
        {
            File.Delete(filename);
        }

        // Check a specific directory existed or not
        public bool isDirectoryExisted(string filename)
        {
            return Directory.Exists(filename);
        }

        // Delete a specific directory
        public void deleteDirectory(string filename)
        {
            Directory.Delete(filename);
        }
    }
}
