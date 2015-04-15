namespace libreriaUtili
{
    partial class inputDialog
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

        #region Codice generato da Progettazione Windows Form

        /// <summary>
        /// Metodo necessario per il supporto della finestra di progettazione. Non modificare
        /// il contenuto del metodo con l'editor di codice.
        /// </summary>
        private void InitializeComponent()
        {
            this.txt_input = new System.Windows.Forms.TextBox();
            this.btn_ok = new System.Windows.Forms.Button();
            this.btn_annulla = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txt_input
            // 
            this.txt_input.Location = new System.Drawing.Point(11, 15);
            this.txt_input.Name = "txt_input";
            this.txt_input.Size = new System.Drawing.Size(193, 20);
            this.txt_input.TabIndex = 0;
            // 
            // btn_ok
            // 
            this.btn_ok.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btn_ok.Location = new System.Drawing.Point(17, 45);
            this.btn_ok.Name = "btn_ok";
            this.btn_ok.Size = new System.Drawing.Size(79, 34);
            this.btn_ok.TabIndex = 1;
            this.btn_ok.Text = "Ok";
            this.btn_ok.UseVisualStyleBackColor = true;
            this.btn_ok.Click += new System.EventHandler(this.btn_ok_Click);
            // 
            // btn_annulla
            // 
            this.btn_annulla.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btn_annulla.Location = new System.Drawing.Point(118, 45);
            this.btn_annulla.Name = "btn_annulla";
            this.btn_annulla.Size = new System.Drawing.Size(79, 34);
            this.btn_annulla.TabIndex = 2;
            this.btn_annulla.Text = "Annulla";
            this.btn_annulla.UseVisualStyleBackColor = true;
            // 
            // inputDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(215, 91);
            this.Controls.Add(this.btn_annulla);
            this.Controls.Add(this.btn_ok);
            this.Controls.Add(this.txt_input);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "inputDialog";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Titolo";
            this.TopMost = true;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_input;
        private System.Windows.Forms.Button btn_ok;
        private System.Windows.Forms.Button btn_annulla;
    }
}