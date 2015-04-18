using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace libreriaUtili
{
    public class Folder
    {
        public DirectoryInfo dir;
        public DirectoryInfo[] dirs;
        public FileInfo[] files;
        public string root;       

        public DirectoryInfo getDirectory()
        {
            this.dir = new DirectoryInfo(root);
            this.dirs = dir.GetDirectories();
            this.files = dir.GetFiles();
            return dir;
        }

        public DirectoryInfo[] getSubDirectories()
        {
            this.dir = new DirectoryInfo(root);
            this.dirs = dir.GetDirectories();
            this.files = dir.GetFiles();
            return dirs;
        }

        public FileInfo[] getFiles()
        {
            this.dir = new DirectoryInfo(root);
            this.dirs = dir.GetDirectories();
            this.files = dir.GetFiles();
            return files;
        }

        public void setRoot(string newroot)
        {
            root = newroot;
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

        public void moveFile(string sourceFileName, string destFileName)
        {
            File.Move(sourceFileName, destFileName);
        }

        public void moveDirectory(string sourceFileName, string destFileName)
        {
            Directory.Move(sourceFileName, destFileName);
        }


    }
}
