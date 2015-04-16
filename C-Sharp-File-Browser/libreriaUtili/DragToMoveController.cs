using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Windows.Forms;

namespace libreriaUtili
{
    public class DragToMoveController
    {
        public fileBrowser theBoundary;
        public Path thePath;

        public DragToMoveController(fileBrowser newBoundary)
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

        // 
        public void dragEnter(DragEventArgs e)
        {
            int len = e.Data.GetFormats().Length - 1;
            int i;
            for (i = 0; i <= len; i++)
            {
                if (e.Data.GetFormats()[i].Equals("System.Windows.Forms.ListView+SelectedListViewItemCollection"))
                {
                    //The data from the drag source is moved to the target.	
                    e.Effect = DragDropEffects.Move;
                }
            }
        }

        //
        public void startDrag(ListView listViewFilesAndFolders)
        {
            //Begins a drag-and-drop operation in the ListView control.
            listViewFilesAndFolders.DoDragDrop(listViewFilesAndFolders.SelectedItems, DragDropEffects.Move);
        }


    }
}
