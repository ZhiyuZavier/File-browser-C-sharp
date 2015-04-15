using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace libreriaUtili
{
    class Path
    {
        DirectoryInfo dir;
        DirectoryInfo[] dirs;
        FileInfo[] files;
        string root;

        //public Path(string root)
        //{
        //    this.dir = new DirectoryInfo(root);
        //    this.dirs = dir.GetDirectories();
        //    this.files = dir.GetFiles();
        //}

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
      

    }
}
