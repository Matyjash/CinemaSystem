using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Cinema_System
{
    public partial class FormRegister : Form
    {
        public FormRegister()
        {
            InitializeComponent();
            textBoxPassword.PasswordChar = '*';
            textBoxPasswordRe.PasswordChar = '*';
        }


        /// <summary>
        /// Przycisk zarejestrowania użytkownika
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonRegister_Click(object sender, EventArgs e)
        {

        }
    }
}
