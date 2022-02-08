using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Cinema_System
{
    public partial class FormChoice : Form
    {
        public string choice = "";
        public FormChoice()
        {
            InitializeComponent();
        }

        private void buttonMovie_Click(object sender, EventArgs e)
        {
            choice = "movie";
            this.Close();
        }

        private void buttonScreening_Click(object sender, EventArgs e)
        {
            choice = "screening";
            this.Close();
        }
    }
}
