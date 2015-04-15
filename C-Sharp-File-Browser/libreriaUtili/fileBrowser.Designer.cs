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
            this.btn_sposta_su = new System.Windows.Forms.Button();
            this.listaImmagini = new System.Windows.Forms.ImageList(this.components);
            this.btn_rinomina = new System.Windows.Forms.Button();
            this.btn_aggiorna = new System.Windows.Forms.Button();
            this.btn_elimina = new System.Windows.Forms.Button();
            this.btn_nuova_cartella = new System.Windows.Forms.Button();
            this.btn_indietro = new System.Windows.Forms.Button();
            this.labelCurrentPath = new System.Windows.Forms.Label();
            this.listViewFilesAndFolders = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lbl_info_file = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btn_sposta_su
            // 
            this.btn_sposta_su.Enabled = false;
            this.btn_sposta_su.ImageIndex = 5;
            this.btn_sposta_su.ImageList = this.listaImmagini;
            this.btn_sposta_su.Location = new System.Drawing.Point(489, 338);
            this.btn_sposta_su.Name = "btn_sposta_su";
            this.btn_sposta_su.Size = new System.Drawing.Size(111, 32);
            this.btn_sposta_su.TabIndex = 20;
            this.btn_sposta_su.Text = "Sposta su";
            this.btn_sposta_su.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_sposta_su.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_sposta_su.UseVisualStyleBackColor = true;
            this.btn_sposta_su.Click += new System.EventHandler(this.btn_sposta_su_Click);
            // 
            // listaImmagini
            // 
            this.listaImmagini.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("listaImmagini.ImageStream")));
            this.listaImmagini.TransparentColor = System.Drawing.Color.Transparent;
            this.listaImmagini.Images.SetKeyName(0, "file.png");
            this.listaImmagini.Images.SetKeyName(1, "folder2.png");
            this.listaImmagini.Images.SetKeyName(2, "delete.png");
            this.listaImmagini.Images.SetKeyName(3, "refresh.png");
            this.listaImmagini.Images.SetKeyName(4, "rename.png");
            this.listaImmagini.Images.SetKeyName(5, "up.png");
            this.listaImmagini.Images.SetKeyName(6, "zip.png");
            this.listaImmagini.Images.SetKeyName(7, "doc.png");
            this.listaImmagini.Images.SetKeyName(8, "gif.png");
            this.listaImmagini.Images.SetKeyName(9, "jpg.png");
            this.listaImmagini.Images.SetKeyName(10, "pdf.gif");
            this.listaImmagini.Images.SetKeyName(11, "ppt.png");
            this.listaImmagini.Images.SetKeyName(12, "xls.png");
            this.listaImmagini.Images.SetKeyName(13, "txt.png");
            this.listaImmagini.Images.SetKeyName(14, "avi.png");
            this.listaImmagini.Images.SetKeyName(15, "mp3.png");
            this.listaImmagini.Images.SetKeyName(16, "png.png");
            // 
            // btn_rinomina
            // 
            this.btn_rinomina.Enabled = false;
            this.btn_rinomina.ImageIndex = 4;
            this.btn_rinomina.ImageList = this.listaImmagini;
            this.btn_rinomina.Location = new System.Drawing.Point(372, 338);
            this.btn_rinomina.Name = "btn_rinomina";
            this.btn_rinomina.Size = new System.Drawing.Size(111, 32);
            this.btn_rinomina.TabIndex = 19;
            this.btn_rinomina.Text = "Rinomina";
            this.btn_rinomina.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_rinomina.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_rinomina.UseVisualStyleBackColor = true;
            this.btn_rinomina.Click += new System.EventHandler(this.btn_rinomina_Click);
            // 
            // btn_aggiorna
            // 
            this.btn_aggiorna.Enabled = false;
            this.btn_aggiorna.ImageIndex = 3;
            this.btn_aggiorna.ImageList = this.listaImmagini;
            this.btn_aggiorna.Location = new System.Drawing.Point(255, 338);
            this.btn_aggiorna.Name = "btn_aggiorna";
            this.btn_aggiorna.Size = new System.Drawing.Size(111, 32);
            this.btn_aggiorna.TabIndex = 18;
            this.btn_aggiorna.Text = "Aggiorna";
            this.btn_aggiorna.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_aggiorna.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_aggiorna.UseVisualStyleBackColor = true;
            this.btn_aggiorna.Click += new System.EventHandler(this.btn_aggiorna_Click);
            // 
            // btn_elimina
            // 
            this.btn_elimina.Enabled = false;
            this.btn_elimina.ImageIndex = 2;
            this.btn_elimina.ImageList = this.listaImmagini;
            this.btn_elimina.Location = new System.Drawing.Point(138, 338);
            this.btn_elimina.Name = "btn_elimina";
            this.btn_elimina.Size = new System.Drawing.Size(111, 32);
            this.btn_elimina.TabIndex = 17;
            this.btn_elimina.Text = "Elimina";
            this.btn_elimina.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_elimina.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_elimina.UseVisualStyleBackColor = true;
            this.btn_elimina.Click += new System.EventHandler(this.btn_elimina_Click);
            // 
            // btn_nuova_cartella
            // 
            this.btn_nuova_cartella.ImageIndex = 1;
            this.btn_nuova_cartella.ImageList = this.listaImmagini;
            this.btn_nuova_cartella.Location = new System.Drawing.Point(21, 338);
            this.btn_nuova_cartella.Name = "btn_nuova_cartella";
            this.btn_nuova_cartella.Size = new System.Drawing.Size(111, 32);
            this.btn_nuova_cartella.TabIndex = 16;
            this.btn_nuova_cartella.Text = "Crea Cartella";
            this.btn_nuova_cartella.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_nuova_cartella.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_nuova_cartella.UseVisualStyleBackColor = true;
            this.btn_nuova_cartella.Click += new System.EventHandler(this.btn_nuova_cartella_Click);
            // 
            // btn_indietro
            // 
            this.btn_indietro.Location = new System.Drawing.Point(21, 6);
            this.btn_indietro.Name = "btn_indietro";
            this.btn_indietro.Size = new System.Drawing.Size(52, 22);
            this.btn_indietro.TabIndex = 15;
            this.btn_indietro.Text = "<<";
            this.btn_indietro.UseVisualStyleBackColor = true;
            this.btn_indietro.Click += new System.EventHandler(this.btn_indietro_Click);
            // 
            // labelCurrentPath
            // 
            this.labelCurrentPath.AutoSize = true;
            this.labelCurrentPath.Location = new System.Drawing.Point(79, 12);
            this.labelCurrentPath.Name = "labelCurrentPath";
            this.labelCurrentPath.Size = new System.Drawing.Size(53, 12);
            this.labelCurrentPath.TabIndex = 14;
            this.labelCurrentPath.Text = "percorso";
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
            this.listViewFilesAndFolders.LargeImageList = this.listaImmagini;
            this.listViewFilesAndFolders.Location = new System.Drawing.Point(21, 34);
            this.listViewFilesAndFolders.MultiSelect = false;
            this.listViewFilesAndFolders.Name = "listViewFilesAndFolders";
            this.listViewFilesAndFolders.ShowGroups = false;
            this.listViewFilesAndFolders.Size = new System.Drawing.Size(635, 296);
            this.listViewFilesAndFolders.SmallImageList = this.listaImmagini;
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
            this.columnHeader1.Text = "Nome File";
            this.columnHeader1.Width = 440;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Ultima Modifica";
            this.columnHeader2.Width = 150;
            // 
            // lbl_info_file
            // 
            this.lbl_info_file.Location = new System.Drawing.Point(25, 383);
            this.lbl_info_file.Name = "lbl_info_file";
            this.lbl_info_file.Size = new System.Drawing.Size(631, 18);
            this.lbl_info_file.TabIndex = 21;
            // 
            // fileBrowser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lbl_info_file);
            this.Controls.Add(this.btn_sposta_su);
            this.Controls.Add(this.btn_rinomina);
            this.Controls.Add(this.btn_aggiorna);
            this.Controls.Add(this.btn_elimina);
            this.Controls.Add(this.btn_nuova_cartella);
            this.Controls.Add(this.btn_indietro);
            this.Controls.Add(this.labelCurrentPath);
            this.Controls.Add(this.listViewFilesAndFolders);
            this.Name = "fileBrowser";
            this.Size = new System.Drawing.Size(680, 410);
            this.Load += new System.EventHandler(this.fileBrowser_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_sposta_su;
        private System.Windows.Forms.Button btn_rinomina;
        private System.Windows.Forms.Button btn_aggiorna;
        private System.Windows.Forms.Button btn_elimina;
        private System.Windows.Forms.Button btn_nuova_cartella;
        private System.Windows.Forms.Button btn_indietro;
        private System.Windows.Forms.Label labelCurrentPath;
        private System.Windows.Forms.ListView listViewFilesAndFolders;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.Label lbl_info_file;
        private System.Windows.Forms.ImageList listaImmagini;
    }
}
