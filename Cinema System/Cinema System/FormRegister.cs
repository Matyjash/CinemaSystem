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
        DatabaseCommunication dbCommunication;
        public FormRegister()
        {
            dbCommunication = new DatabaseCommunication();
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
            if(textBoxLogin.Text.Length == 0 || textBoxPassword.Text.Length == 0 || textBoxPasswordRe.Text.Length == 0)
            {
                MessageBox.Show("Nie wypełniono wszystkich pól w formularzu!");
            }else if(textBoxLogin.Text.Length > 50 || textBoxPassword.Text.Length > 50 || textBoxPasswordRe.Text.Length > 50)
            {
                MessageBox.Show("Wprowadzono dane są zbyt długie!");
            }else if(!textBoxPassword.Text.Equals(textBoxPasswordRe.Text)){
                MessageBox.Show("Wprowadzone hasłą różnią się!");
            }
            else
            {
                bool success = dbCommunication.Register(textBoxLogin.Text, textBoxPassword.Text);
                if (success) this.Close();
            }
        }
    }
}
