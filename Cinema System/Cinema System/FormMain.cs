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
        private bool logged = false;
        private bool privilaged = false;
        DataTable table = new DataTable("custom table");

        public FormMain()
        {
            InitializeComponent();
            RefreshDataGridView();
        }

        private void RefreshDataGridView()
        {
            string[] row0 = { "Diuna", "2021-12-02", "12:00", "23/30" };
            string[] row1 = { "Eternals", "2021-12-02", "12:35", "11/30" };
            string[] row2 = { "Furioza", "2021-12-02", "15:30", "18/30" };
            string[] row3 = { "La Liste: Wszystko albo nic", "2021-12-02", "18:00", "5/30" };
            string[] row4 = { "Diuna", "2021-12-03", "10:00", "10/30" };
            string[] row5 = { "Nie czas umierać", "2021-12-03", "12:00", "4/30" };

            dataGridViewMain.Rows.Add(row0);
            dataGridViewMain.Rows.Add(row1);
            dataGridViewMain.Rows.Add(row2);
            dataGridViewMain.Rows.Add(row3);
            dataGridViewMain.Rows.Add(row4);
            dataGridViewMain.Rows.Add(row5);

        }

        /// <summary>
        /// Odświeżenie dostepnych funkcji, aktualizacja przycisków
        /// </summary>
        private void RefreshLoginFunctions()
        {
            if (logged)
            {
                buttonLogin.Text = "Wyloguj";
                buttonBuyTicket.Visible = true;
                buttonCheckHall.Visible = true;
                if (privilaged)
                {
                    buttonAdd.Visible = true;
                    buttonDelete.Visible = true;
                    buttonEdit.Visible = true;
                }
            }
            else
            {
                buttonLogin.Text = "Zaloguj";
                buttonBuyTicket.Visible = false;
                buttonCheckHall.Visible = false;
                buttonAdd.Visible = false;
                buttonDelete.Visible = false;
                buttonEdit.Visible = false;
            }
        }
        
        /// <summary>
        /// Obsługa przycisku logowania
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonLogin_Click(object sender, EventArgs e)
        {
            if (!logged)
            {
                FormLogin formLogin = new FormLogin();
                formLogin.ShowDialog();
                logged = true;
                RefreshLoginFunctions();
            }
            else
            {
                logged = false;
                privilaged = false;
                RefreshLoginFunctions();
            }
        }
    }
}
