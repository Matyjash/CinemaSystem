using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Cinema_System
{
    public partial class FormAddToProgramme : Form
    {
        private DatabaseCommunication dbCommunication;
        private User user;
        private bool edit = false;
        private int screeningId;
        private string title;
        public FormAddToProgramme(User user)
        {
            this.user = user;
            dbCommunication = new DatabaseCommunication();
            InitializeComponent();
        }

        public FormAddToProgramme(User user, int screeningId, string title)
        {
            this.user = user;
            this.screeningId = screeningId;
            this.title = title;
            dbCommunication = new DatabaseCommunication();
            InitializeComponent();
            labelTitle.Text = "Edytowanie seansu";
            buttonAddScreening.Text = "Edytuj";
            edit = true;
            textBoxTitle.Text = title;
            textBoxTitle.Enabled = false;
        }

        private void buttonAddScreening_Click(object sender, EventArgs e)
        {

            string date;
            string year, month, day, hour, minute;
            string hallId;
            int hallIdInt;
            //rok
            year = textBoxYear.Text;
            if(year.Length == 0 || year.Length>4)
            {
                MessageBox.Show("Błędnie wprowadzono rok w dacie!");
                return;
            }

            //miesiąc
            month = textBoxMonth.Text;
            if(month.Length == 1)
            {
                month = "0" + month;
            }else if(month.Length == 0 || month.Length > 2)
            {
                MessageBox.Show("Błędnie wprowadzono miesiąc w dacie!");
                return;
            }

            //dzień
            day = textBoxDay.Text;
            if(day.Length == 1)
            {
                day = "0" + day;
            }
            else if (day.Length == 0 || day.Length >2)
            {
                MessageBox.Show("Błędnie wprowadzono dzień w dacie!");
                return;
            }

            //godzina
            hour = textBoxHour.Text;
            if(hour.Length == 1)
            {
                hour = "0" + hour;
            }
            else if(hour.Length ==0 || hour.Length > 2)
            {
                MessageBox.Show("Błędnie wprowadzono godzinę w dacie!");
                return;
            }

            //minuty
            minute = textBoxMinutes.Text;
            if(minute.Length == 1)
            {
                minute = "0" + minute;
            }
            else if(minute.Length == 0 || minute.Length >2)
            {
                MessageBox.Show("Błędnie wprowadzono minuty w dacie!");
                return;
            }

            //id sali
            hallId = textBoxHallId.Text;
            bool isIdok = Int32.TryParse(hallId, out hallIdInt);
            if (!isIdok)
            {
                MessageBox.Show("Wprowadzono nieprawidłowe id sali!");
                return;
            }
            hallIdInt = Int32.Parse(hallId);

            //cała data
            date = year + "-" + month + "-" + day + " " + hour + ":" + minute;
            DateTime testDate;
            bool isDateOk = DateTime.TryParse(date, out testDate);

            if (!isDateOk)
            {
                MessageBox.Show("Wprowadzono nieprawidłową datę!");
                return;
            }

            if (edit)
            {
                dbCommunication.EditScreening(screeningId, date, hallIdInt, user);
            }
            else
            {
                dbCommunication.addScreening(textBoxTitle.Text, date, hallIdInt, user);
            }
            this.Close();
        }

        private void textBoxTitle_Enter(object sender, EventArgs e)
        {
            textBoxTitle.Text = "";
        }

        private void textBoxTitle_Leave(object sender, EventArgs e)
        {
            if (textBoxTitle.Text == "") textBoxTitle.Text = "Tytuł";
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

        private void textBoxHour_Enter(object sender, EventArgs e)
        {
            textBoxHour.Text = "";
        }

        private void textBoxHour_Leave(object sender, EventArgs e)
        {
            if (textBoxHour.Text == "") textBoxHour.Text = "hh";
        }

        private void textBoxMinutes_Enter(object sender, EventArgs e)
        {
            textBoxMinutes.Text = "";
        }

        private void textBoxMinutes_Leave(object sender, EventArgs e)
        {
            if (textBoxMinutes.Text == "") textBoxMinutes.Text = "mm";
        }

        private void textBoxHallId_Enter(object sender, EventArgs e)
        {
            textBoxHallId.Text = "";
        }

        private void textBoxHallId_Leave(object sender, EventArgs e)
        {
            if (textBoxHallId.Text == "") textBoxHallId.Text = "ID sali";
        }
    }
}
