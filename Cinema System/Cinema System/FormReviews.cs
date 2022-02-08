using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Cinema_System
{
    
    public partial class FormReviews : Form
    {
        private DatabaseCommunication dbCommunication;
        private DataTable table = new DataTable();
        private User user;
        private string title;
        public FormReviews(string title, User user)
        {
            this.user = user;
            InitializeComponent();
            labelTitle.Text = title;
            this.title = title;
            dbCommunication = new DatabaseCommunication();
            dataGridViewReviews.DataSource = dbCommunication.GetReviews(title);
            setGridView();
            getAverage();
        }

        private void setGridView()        {
           if(dataGridViewReviews.Columns.Count == 3)
            {
                dataGridViewReviews.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
                dataGridViewReviews.Columns[0].Width = 150;
                dataGridViewReviews.Columns[0].ReadOnly = true;

                dataGridViewReviews.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
                dataGridViewReviews.Columns[1].Width = 450;
                dataGridViewReviews.Columns[1].ReadOnly = true;


            }

            dataGridViewReviews.DefaultCellStyle.WrapMode = DataGridViewTriState.True;
            dataGridViewReviews.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCellsExceptHeaders;
        }

        private void getAverage()
        {
            float sum=0;
            for(int i =0; i<dataGridViewReviews.Rows.Count-1; i++)
            {
                sum += float.Parse(dataGridViewReviews[2, i].Value.ToString().Split('/')[0]);
            }
            float avg = 0;
            if (dataGridViewReviews.Rows.Count > 1)
            {
                avg = sum / (dataGridViewReviews.Rows.Count - 1);
            }

            labelAvg.Text = avg.ToString("0.00");
        }

        private void buttonAddReview_Click(object sender, EventArgs e)
        {
            if (user.logged)
            {
                FormAddReview formAddReview = new FormAddReview(title, user);
                formAddReview.ShowDialog();
            }
            else
            {
                MessageBox.Show("Musisz być zalogowany aby dodawać recenzje!");
            }
        }
    }
}
