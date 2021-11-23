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
        DataTable table = new DataTable("custom table");

        public FormMain()
        {
            InitializeComponent();
            RefreshDataGridView();
        }

        private void RefreshDataGridView()
        {
            DataSet dataSet = new DataSet();
            dataSet.Tables.Add(table);
            table.Columns.Add("Nazwa");
            table.Columns.Add("Data");
            table.Columns.Add("Godzina");
            table.Rows.Add("1", "2", "3");
            table.Rows.Add("1", "2", "3");
            table.Rows.Add("1", "2", "3");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            dataGridViewMain.Rows.Clear();
            dataGridViewMain.Columns.Clear();
            dataGridViewMain.Refresh();
            dataGridViewMain.DataSource = table;
            
        }
    }
}
