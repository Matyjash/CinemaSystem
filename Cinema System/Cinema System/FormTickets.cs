using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Cinema_System
{
    public partial class FormTickets : Form
    {
        private User user;
        private DataTable table;
        private DatabaseCommunication dbCommunication;
        public FormTickets(User user)
        {
            InitializeComponent();
            this.user = user;
            dbCommunication = new DatabaseCommunication();
            table = dbCommunication.GetBoughtTickets(user);
            dataGridViewTickets.DataSource = table;
        }
    }
}
