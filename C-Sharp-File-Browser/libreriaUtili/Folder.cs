using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace libreriaUtili
{
    // Entity Class of the cumstom control
    public class Folder
    {
        public DirectoryInfo dir;
        public DirectoryInfo[] dirs;
        public FileInfo[] files;
        public string root;

        // Get current directory of a specific path
        public DirectoryInfo getDirectory()
        {
            this.dir = new DirectoryInfo(root);
            this.dirs = dir.GetDirectories();
            this.files = dir.GetFiles();
            return dir;
        }

        // Get all folders inside of a specific directory
        public DirectoryInfo[] getSubDirectories()
        {
            this.dir = new DirectoryInfo(root);
            this.dirs = dir.GetDirectories();
            this.files = dir.GetFiles();
            return dirs;
        }

        // Get all files inside of a specific directory
        public FileInfo[] getFiles()
        {
            this.dir = new DirectoryInfo(root);
            this.dirs = dir.GetDirectories();
            this.files = dir.GetFiles();
            return files;
        }

        // Setter for the property root
        public void setRoot(string newroot)
        {
            root = newroot;
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


        // Move a specified file to a new location
        public void moveFile(string sourceFileName, string destFileName)
        {
            File.Move(sourceFileName, destFileName);
        }

        // Move a specified folder to a new location
        public void moveDirectory(string sourceFileName, string destFileName)
        {
            Directory.Move(sourceFileName, destFileName);
        }
        
    }
}
