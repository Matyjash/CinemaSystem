using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Cinema_System
{
    public partial class FormLogin : Form
    {
        private User user;
        private DatabaseCommunication dbCommunication;
        public FormLogin(User user)
        {
            this.user = user;
            dbCommunication = new DatabaseCommunication();
            InitializeComponent();
            textBoxPassword.PasswordChar = '*';
        }

        /// <summary>
        /// Przycisk zalogowania użytkownika
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonLogin_Click(object sender, EventArgs e)
        {
            if (textBoxLogin.Text.Length == 0 || textBoxPassword.Text.Length == 0)
            {
                MessageBox.Show("Nie wprowadzono poprawnie wszystkich pól!");
            }
            else
            {
                bool success = dbCommunication.Login(textBoxLogin.Text, textBoxPassword.Text, user);
                if (success) this.Close();

            }
        }
    }
}
