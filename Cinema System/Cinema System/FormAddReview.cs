using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Cinema_System
{
    public partial class FormAddReview : Form
    {
        private DatabaseCommunication dbCommunication;
        private User user;
        private string title;
        public FormAddReview(string title, User user)
        {
            this.title = title;
            this.user = user;
            InitializeComponent();
            dbCommunication = new DatabaseCommunication();
            setComboBox();
        }

        private void setComboBox()
        {
            for(int i =1; i<11; i++)
            {
                comboBoxRate.Items.Add(i);
            }

            comboBoxRate.SelectedIndex = 5;
            
        }

        private void buttonSend_Click(object sender, EventArgs e)
        {
            if (richTextBox1.Text != "Co sądzisz o filmie ?") 
            {
                bool success=
                dbCommunication.AddReview(user.login, richTextBox1.Text, title, Int32.Parse(comboBoxRate.SelectedItem.ToString()));

                if (success)
                {
                    MessageBox.Show("Dodano recenzje!");
                }
                else
                {
                    MessageBox.Show("Wystąpił błąd przy dodawaniu recenzji!");
                }
            }
            else
            {
                MessageBox.Show("Pole tekstowe nie może pozostać bez zmian!");
            }
     
        }

        private void richTextBox1_Enter(object sender, EventArgs e)
        {
            richTextBox1.Text = "";
        }
    }
}
