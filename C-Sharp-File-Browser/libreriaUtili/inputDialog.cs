using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace libreriaUtili
{
    // Helper class for the input dialog panel 
    public partial class inputDialog : Form
    {
        public string inputText = "";
        
        public inputDialog(string titolo, string testoIniziale)
        {
            InitializeComponent();
            this.Text = titolo;
            this.txt_input.Text = testoIniziale;
        }

        // Event handler of click action for btn_ok
        private void btn_ok_Click(object sender, EventArgs e)
        {
            inputText = this.txt_input.Text;
        }
    }
}