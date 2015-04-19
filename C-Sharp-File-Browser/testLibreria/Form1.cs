using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace testLibreria
{
    // Container of the user control for the test program
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            fileBrowser1._ROOT = @"c:\";
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }
    }
}