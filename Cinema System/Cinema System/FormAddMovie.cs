using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Cinema_System
{
    public partial class FormAddMovie : Form
    {
        private User user;
        private DatabaseCommunication dbCommunication;
        private bool edit = false;
        private string oldTitle;
        public FormAddMovie(User user)
        {
            dbCommunication = new DatabaseCommunication();
            this.user = user;
            InitializeComponent();
        }

        public FormAddMovie(User user, string oldTitle)
        {
            this.oldTitle = oldTitle;
            dbCommunication = new DatabaseCommunication();
            this.user = user;
            InitializeComponent();

            labelTitle.Text = "Edytowanie filmu ";
            labelMovieTitle.Text = oldTitle;
            edit = true;

        }

        private void buttonAddToMovies_Click(object sender, EventArgs e)
        {
            string title, genre, directorFirstName, directorLastName, year, month, day, date;

            //tytuł
            title = textBoxTitle.Text;
            if(title.Length == 0 || title.Length > 50)
            {
                MessageBox.Show("Niepoprawnie wprowadzono tytuł filmu!");
                return;
            }

            //gatunek
            genre = textBoxGenre.Text;
            if(genre.Length == 0 || genre.Length >50)
            {
                MessageBox.Show("Niepoprawnie wprowadzono gatunek filmu!");
                return;
            }

            //imię reżysera
            directorFirstName = textBoxDirectorFirstName.Text;
            if (directorFirstName.Length == 0 || directorFirstName.Length > 20)
            {
                MessageBox.Show("Niepoprawnie wprowadzono imię reżysera!");
                return;
            }

            //nazwisko reżysera
            directorLastName = textBoxDirectorLastName.Text;
            if (directorLastName.Length == 0 || directorLastName.Length > 20)
            {
                MessageBox.Show("Niepoprawnie wprowadzono nazwisko reżysera!");
                return;
            }

            //rok
            year = textBoxYear.Text;
            if (year.Length == 0 || year.Length > 4)
            {
                MessageBox.Show("Błędnie wprowadzono rok w dacie!");
                return;
            }

            //miesiąc
            month = textBoxMonth.Text;
            if (month.Length == 1)
            {
                month = "0" + month;
            }
            else if (month.Length == 0 || month.Length > 2)
            {
                MessageBox.Show("Błędnie wprowadzono miesiąc w dacie!");
                return;
            }

            //dzień
            day = textBoxDay.Text;
            if (day.Length == 1)
            {
                day = "0" + day;
            }
            else if (day.Length == 0 || day.Length > 2)
            {
                MessageBox.Show("Błędnie wprowadzono dzień w dacie!");
                return;
            }

            //cała data
            date = year + "-" + month + "-" + day;
            DateTime testDate;
            bool isDateOk = DateTime.TryParse(date, out testDate);

            if (!isDateOk)
            {
                MessageBox.Show("Wprowadzono nieprawidłową datę!");
                return;
            }

            if (edit)
            {
                dbCommunication.EditMovie(oldTitle, title, genre, directorFirstName, directorLastName, date, user);
            }
            else
            {
                dbCommunication.addMovie(title, genre, directorFirstName, directorLastName, date);
            }
            

            this.Close();
        }

        //zachowanie texboxow przy wejscu do pola i przy jego opuszczaniu
        private void textBoxTitle_Enter(object sender, EventArgs e)
        {
            textBoxTitle.Text = "";
        }

        private void textBoxTitle_Leave(object sender, EventArgs e)
        {
            if (textBoxTitle.Text == "") textBoxTitle.Text = "Tytuł filmu";
        }

        private void textBoxGenre_Enter(object sender, EventArgs e)
        {
            textBoxGenre.Text = "";
        }

        private void textBoxGenre_Leave(object sender, EventArgs e)
        {
            if (textBoxGenre.Text == "") textBoxGenre.Text = "Gatunek";
        }

        private void textBoxDirectorFirstName_Enter(object sender, EventArgs e)
        {
            textBoxDirectorFirstName.Text = "";
        }

        private void textBoxDirectorFirstName_Leave(object sender, EventArgs e)
        {
            if (textBoxDirectorFirstName.Text == "") textBoxDirectorFirstName.Text = "Imię reżysera";
        }

        private void textBoxYear_Enter(object sender, EventArgs e)
        {
            textBoxYear.Text = "";
        }

        private void textBoxYear_Leave(object sender, EventArgs e)
        {
            if (textBoxYear.Text == "") textBoxYear.Text = "YYYY";
        }

        private void textBoxMonth_Enter(object sender, EventArgs e)
        {
            textBoxMonth.Text = "";
        }

        private void textBoxMonth_Leave(object sender, EventArgs e)
        {
            if (textBoxMonth.Text == "") textBoxMonth.Text = "MM";
        }

        private void textBoxDay_Enter(object sender, EventArgs e)
        {
            textBoxDay.Text = "";
        }

        private void textBoxDay_Leave(object sender, EventArgs e)
        {
            if (textBoxDay.Text == "") textBoxDay.Text = "DD";
        }

        private void textBoxDirectorLastName_Enter(object sender, EventArgs e)
        {
            textBoxDirectorLastName.Text = "";
        }

        private void textBoxDirectorLastName_Leave(object sender, EventArgs e)
        {
            if (textBoxDirectorLastName.Text == "") textBoxDirectorLastName.Text = "Nazwisko reżysera";
        }
    }
}
