using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cinema_System
{
    public partial class FormMain : Form
    {
        private DatabaseCommunication dbCommunication = new DatabaseCommunication();
        private User user;
        private string mode = "screenings";
 
        DataTable table = new DataTable();

        public FormMain()
        {
            InitializeComponent();
            dataGridViewMain.DataSource = table;
            user = new User();
            RefreshDataGridView();
            buttonProgramme.Enabled = false;
        }

        private void RefreshDataGridView()
        {

            if (mode == "screenings")
            {
                table = dbCommunication.GetScreenings();
                dataGridViewMain.DataSource = table;
                dataGridViewMain.Columns[0].Visible = false;
                dataGridViewMain.Columns[1].Visible = false;
                buttonProgramme.Enabled = false;
                buttonMovies.Enabled = true;
            }
            else if(mode == "movies")
            {
                table = dbCommunication.GetMovies();
                dataGridViewMain.DataSource = table;

                buttonProgramme.Enabled = true;
                buttonMovies.Enabled = false;
            }
            RefreshLoginFunctions();
        }

        /// <summary>
        /// Odświeżenie dostepnych funkcji, aktualizacja przycisków
        /// </summary>
        private void RefreshLoginFunctions()
        {
            if (user.logged)
            {
                buttonLogin.Text = "Wyloguj";
                buttonBuyTicket.Visible = true;
                buttonGetTickets.Visible = true;

                if (user.privilaged)
                {
                    buttonAdd.Visible = true;
                    buttonDelete.Visible = true;
                    buttonEdit.Visible = true;
                }

                if(mode == "screenings")
                {
                    buttonBuyTicket.Visible = true;
                    buttonCheckHall.Visible = true;
                    buttonReviews.Visible = false;
                    if (user.privilaged) buttonDelete.Enabled = true;

                }else if(mode == "movies")
                {
                    buttonReviews.Visible = true;
                    buttonBuyTicket.Visible = false;
                    buttonCheckHall.Visible = false;
                    buttonDelete.Enabled = false;
                }
            }
            else
            {
                buttonReviews.Visible = false;
                buttonLogin.Text = "Zaloguj";
                buttonBuyTicket.Visible = false;
                buttonCheckHall.Visible = false;
                buttonAdd.Visible = false;
                buttonDelete.Visible = false;
                buttonEdit.Visible = false;
                buttonGetTickets.Visible = false;
            }
        }
        
        /// <summary>
        /// Obsługa przycisku logowania
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonLogin_Click(object sender, EventArgs e)
        {
            if (!user.logged)
            {
                FormLogin formLogin = new FormLogin(user);
                formLogin.ShowDialog();
                RefreshLoginFunctions();
            }
            else
            {
                user.logged = false;
                user.privilaged = false;
                user.login = "";
                RefreshLoginFunctions();
            }
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            if(user.privilaged)
            {
                FormChoice formChoice = new FormChoice();
                formChoice.ShowDialog();

                if(formChoice.choice == "screening")
                {
                    FormAddToProgramme formAdd = new FormAddToProgramme(user);
                    formAdd.ShowDialog();

                }else if(formChoice.choice == "movie")
                {
                    FormAddMovie formAdd = new FormAddMovie(user);
                    formAdd.ShowDialog();
                }

                RefreshDataGridView();
                

            }
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            if (user.privilaged)
            {
                if(mode == "screenings")
                {
                    string idString = dataGridViewMain[0, dataGridViewMain.CurrentRow.Index].Value.ToString();
                    int id = Convert.ToInt32(idString);
                    DialogResult dialogResult = MessageBox.Show("Czy na pewno chcesz usunąć wybrany seans?", "Potwierdzenie", MessageBoxButtons.YesNo);
                    if (dialogResult == DialogResult.Yes)
                    {
                        bool success = dbCommunication.deleteScreening(id, user);
                        if (success)
                        {
                            MessageBox.Show("Usunięto podany seans!");
                        }
                        else
                        {
                            MessageBox.Show("Wystąpił błąd przy usuwaniu seansu!");
                        }
                    }
                }

                RefreshDataGridView();
            }
        }

        private void buttonEdit_Click(object sender, EventArgs e)
        {
            if (user.privilaged)
            {
                if(mode == "screenings")
                {
                    string title = dataGridViewMain[2, dataGridViewMain.CurrentRow.Index].Value.ToString();
                    string idString = dataGridViewMain[0, dataGridViewMain.CurrentRow.Index].Value.ToString();
                    int id = Convert.ToInt32(idString);
                    FormAddToProgramme formAddToProgramme = new FormAddToProgramme(user, id, title);
                    formAddToProgramme.ShowDialog();

                }else if(mode == "movies")
                {
                    string title = dataGridViewMain[0, dataGridViewMain.CurrentRow.Index].Value.ToString();
                    FormAddMovie formAddMovie = new FormAddMovie(user, title);
                    formAddMovie.ShowDialog();
                }
                RefreshDataGridView();
            }
        }

        private void buttonProgramme_Click(object sender, EventArgs e)
        {
            mode = "screenings";
            RefreshDataGridView();
        }

        private void buttonMovies_Click(object sender, EventArgs e)
        {
            mode = "movies";
            RefreshDataGridView();
        }

        private void buttonRegister_Click(object sender, EventArgs e)
        {
            if (!user.logged)
            {
                FormRegister formRegister = new FormRegister();
                formRegister.ShowDialog();
                RefreshLoginFunctions();
            }

        }

        private void textBoxSearch_TextChanged(object sender, EventArgs e)
        {
            if (textBoxSearch.Text != "Szukaj...")
            {
                table.DefaultView.RowFilter = string.Format("[{0}] LIKE '%{1}%'", "Tytuł", textBoxSearch.Text);
            }
        }

        private void buttonReviews_Click(object sender, EventArgs e)
        {

            string title = dataGridViewMain[0, dataGridViewMain.CurrentRow.Index].Value.ToString();
            if (title.Length != 0)
            {
                FormReviews formReviews = new FormReviews(title, user);
                formReviews.ShowDialog();
            }


        }

        private void textBoxSearch_Enter(object sender, EventArgs e)
        {
            textBoxSearch.Text = "";
        }
        private void textBoxSearch_Leave(object sender, EventArgs e)
        {
            if (textBoxSearch.Text == "") textBoxSearch.Text = "Szukaj...";
        }

        private void buttonBuyTicket_Click(object sender, EventArgs e)
        {
            string idString = dataGridViewMain[0, dataGridViewMain.CurrentRow.Index].Value.ToString();
            int id =Convert.ToInt32(idString);
            bool success=dbCommunication.buyTicket(user, id);
            if (success)
            {
                MessageBox.Show("Zakupiono bilet na podany seans!");
            }
            else
            {
                MessageBox.Show("Wystąpił błąd przy zakupie biletu!");
            }

        }

        private void buttonGetTickets_Click(object sender, EventArgs e)
        {
            FormTickets formTickets = new FormTickets(user);
            formTickets.ShowDialog();
        }
    }
}
