using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace libreriaUtili
{
    public partial class inputDialog : Form
    {
        public string inputText = "";
        
        public inputDialog(string titolo, string testoIniziale)
        {
            InitializeComponent();
            this.Text = titolo;
            this.txt_input.Text = testoIniziale;
        }

        private void btn_ok_Click(object sender, EventArgs e)
        {
            inputText = this.txt_input.Text;
        }
    }
}