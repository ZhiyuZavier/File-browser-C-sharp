namespace libreriaUtili
{
    partial class fileBrowser
    {
        /// <summary> 
        /// Variabile di progettazione necessaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Liberare le risorse in uso.
        /// </summary>
        /// <param name="disposing">ha valore true se le risorse gestite devono essere eliminate, false in caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Codice generato da Progettazione componenti

        /// <summary> 
        /// Metodo necessario per il supporto della finestra di progettazione. Non modificare 
        /// il contenuto del metodo con l'editor di codice.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fileBrowser));
            this.btnMoveUp = new System.Windows.Forms.Button();
            this.listImages = new System.Windows.Forms.ImageList(this.components);
            this.btnRename = new System.Windows.Forms.Button();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnNewFolder = new System.Windows.Forms.Button();
            this.btn_indietro = new System.Windows.Forms.Button();
            this.labelCurrentPath = new System.Windows.Forms.Label();
            this.listViewFilesAndFolders = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lbl_info_file = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnMoveUp
            // 
            this.btnMoveUp.Enabled = false;
            this.btnMoveUp.ImageIndex = 5;
            this.btnMoveUp.ImageList = this.listImages;
            this.btnMoveUp.Location = new System.Drawing.Point(489, 366);
            this.btnMoveUp.Name = "btnMoveUp";
            this.btnMoveUp.Size = new System.Drawing.Size(111, 35);
            this.btnMoveUp.TabIndex = 20;
            this.btnMoveUp.Text = "Move Up";
            this.btnMoveUp.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnMoveUp.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnMoveUp.UseVisualStyleBackColor = true;
            this.btnMoveUp.Click += new System.EventHandler(this.btn_sposta_su_Click);
            // 
            // listImages
            // 
            this.listImages.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("listImages.ImageStream")));
            this.listImages.TransparentColor = System.Drawing.Color.Transparent;
            this.listImages.Images.SetKeyName(0, "file.png");
            this.listImages.Images.SetKeyName(1, "folder2.png");
            this.listImages.Images.SetKeyName(2, "delete.png");
            this.listImages.Images.SetKeyName(3, "refresh.png");
            this.listImages.Images.SetKeyName(4, "rename.png");
            this.listImages.Images.SetKeyName(5, "up.png");
            this.listImages.Images.SetKeyName(6, "zip.png");
            this.listImages.Images.SetKeyName(7, "doc.png");
            this.listImages.Images.SetKeyName(8, "gif.png");
            this.listImages.Images.SetKeyName(9, "jpg.png");
            this.listImages.Images.SetKeyName(10, "pdf.gif");
            this.listImages.Images.SetKeyName(11, "ppt.png");
            this.listImages.Images.SetKeyName(12, "xls.png");
            this.listImages.Images.SetKeyName(13, "txt.png");
            this.listImages.Images.SetKeyName(14, "avi.png");
            this.listImages.Images.SetKeyName(15, "mp3.png");
            this.listImages.Images.SetKeyName(16, "png.png");
            // 
            // btnRename
            // 
            this.btnRename.Enabled = false;
            this.btnRename.ImageIndex = 4;
            this.btnRename.ImageList = this.listImages;
            this.btnRename.Location = new System.Drawing.Point(372, 366);
            this.btnRename.Name = "btnRename";
            this.btnRename.Size = new System.Drawing.Size(111, 35);
            this.btnRename.TabIndex = 19;
            this.btnRename.Text = "Rename";
            this.btnRename.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnRename.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnRename.UseVisualStyleBackColor = true;
            this.btnRename.Click += new System.EventHandler(this.btn_rinomina_Click);
            // 
            // btnRefresh
            // 
            this.btnRefresh.Enabled = false;
            this.btnRefresh.ImageIndex = 3;
            this.btnRefresh.ImageList = this.listImages;
            this.btnRefresh.Location = new System.Drawing.Point(255, 366);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(111, 35);
            this.btnRefresh.TabIndex = 18;
            this.btnRefresh.Text = "Refresh";
            this.btnRefresh.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnRefresh.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.btn_aggiorna_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Enabled = false;
            this.btnDelete.ImageIndex = 2;
            this.btnDelete.ImageList = this.listImages;
            this.btnDelete.Location = new System.Drawing.Point(138, 366);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(111, 35);
            this.btnDelete.TabIndex = 17;
            this.btnDelete.Text = "Delete";
            this.btnDelete.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnDelete.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnNewFolder
            // 
            this.btnNewFolder.ImageIndex = 1;
            this.btnNewFolder.ImageList = this.listImages;
            this.btnNewFolder.Location = new System.Drawing.Point(21, 366);
            this.btnNewFolder.Name = "btnNewFolder";
            this.btnNewFolder.Size = new System.Drawing.Size(111, 35);
            this.btnNewFolder.TabIndex = 16;
            this.btnNewFolder.Text = "Create Folder";
            this.btnNewFolder.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnNewFolder.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnNewFolder.UseVisualStyleBackColor = true;
            this.btnNewFolder.Click += new System.EventHandler(this.btnNewFolder_Click);
            // 
            // btn_indietro
            // 
            this.btn_indietro.Location = new System.Drawing.Point(21, 7);
            this.btn_indietro.Name = "btn_indietro";
            this.btn_indietro.Size = new System.Drawing.Size(52, 24);
            this.btn_indietro.TabIndex = 15;
            this.btn_indietro.Text = "<<";
            this.btn_indietro.UseVisualStyleBackColor = true;
            this.btn_indietro.Click += new System.EventHandler(this.btn_indietro_Click);
            // 
            // labelCurrentPath
            // 
            this.labelCurrentPath.AutoSize = true;
            this.labelCurrentPath.Location = new System.Drawing.Point(79, 13);
            this.labelCurrentPath.Name = "labelCurrentPath";
            this.labelCurrentPath.Size = new System.Drawing.Size(31, 13);
            this.labelCurrentPath.TabIndex = 14;
            this.labelCurrentPath.Text = "route";
            // 
            // listViewFilesAndFolders
            // 
            this.listViewFilesAndFolders.AllowDrop = true;
            this.listViewFilesAndFolders.AutoArrange = false;
            this.listViewFilesAndFolders.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2});
            this.listViewFilesAndFolders.FullRowSelect = true;
            this.listViewFilesAndFolders.GridLines = true;
            this.listViewFilesAndFolders.HideSelection = false;
            this.listViewFilesAndFolders.LargeImageList = this.listImages;
            this.listViewFilesAndFolders.Location = new System.Drawing.Point(21, 37);
            this.listViewFilesAndFolders.MultiSelect = false;
            this.listViewFilesAndFolders.Name = "listViewFilesAndFolders";
            this.listViewFilesAndFolders.ShowGroups = false;
            this.listViewFilesAndFolders.Size = new System.Drawing.Size(635, 320);
            this.listViewFilesAndFolders.SmallImageList = this.listImages;
            this.listViewFilesAndFolders.TabIndex = 13;
            this.listViewFilesAndFolders.UseCompatibleStateImageBehavior = false;
            this.listViewFilesAndFolders.View = System.Windows.Forms.View.Details;
            this.listViewFilesAndFolders.ItemActivate += new System.EventHandler(this.listViewFilesAndFolders_ItemActivate);
            this.listViewFilesAndFolders.ItemDrag += new System.Windows.Forms.ItemDragEventHandler(this.listViewFilesAndFolders_ItemDrag);
            this.listViewFilesAndFolders.ItemSelectionChanged += new System.Windows.Forms.ListViewItemSelectionChangedEventHandler(this.listViewFilesAndFolders_ItemSelectionChanged);
            this.listViewFilesAndFolders.DragDrop += new System.Windows.Forms.DragEventHandler(this.listViewFilesAndFolders_DragDrop);
            this.listViewFilesAndFolders.DragEnter += new System.Windows.Forms.DragEventHandler(this.listViewFilesAndFolders_DragEnter);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "File Name";
            this.columnHeader1.Width = 440;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Last Modified";
            this.columnHeader2.Width = 150;
            // 
            // lbl_info_file
            // 
            this.lbl_info_file.Location = new System.Drawing.Point(25, 415);
            this.lbl_info_file.Name = "lbl_info_file";
            this.lbl_info_file.Size = new System.Drawing.Size(631, 20);
            this.lbl_info_file.TabIndex = 21;
            // 
            // fileBrowser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lbl_info_file);
            this.Controls.Add(this.btnMoveUp);
            this.Controls.Add(this.btnRename);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnNewFolder);
            this.Controls.Add(this.btn_indietro);
            this.Controls.Add(this.labelCurrentPath);
            this.Controls.Add(this.listViewFilesAndFolders);
            this.Name = "fileBrowser";
            this.Size = new System.Drawing.Size(680, 444);
            this.Load += new System.EventHandler(this.fileBrowser_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnMoveUp;
        private System.Windows.Forms.Button btnRename;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnNewFolder;
        private System.Windows.Forms.Button btn_indietro;
        private System.Windows.Forms.Label labelCurrentPath;
        private System.Windows.Forms.ListView listViewFilesAndFolders;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.Label lbl_info_file;
        private System.Windows.Forms.ImageList listImages;
    }
}
