using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace carmanage
{
    public partial class admincar : Form
    {
        private BindingSource bindingSource1 = new BindingSource();

        public admincar()
        {
            InitializeComponent();
        }

        private void admincar_Load(object sender, EventArgs e)
        {
            bindingSource1.DataSource = GetData("Select * From cars");
            dataGridView1.DataSource = bindingSource1;




        }

        private void admincar_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.OpenForms[1].Show();

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        private static DataTable GetData(string sqlCommand)
        {


            MySqlConnection northwindConnection = new MySqlConnection(Properties.Settings.Default.localhost);

            MySqlCommand command = new MySqlCommand(sqlCommand, northwindConnection);
            MySqlDataAdapter adapter = new MySqlDataAdapter();
            adapter.SelectCommand = command;

            DataTable table = new DataTable();
            table.Locale = System.Globalization.CultureInfo.InvariantCulture;
            adapter.Fill(table);

            return table;
        }

        private void dataGridView1_CellValuePushed(object sender, DataGridViewCellValueEventArgs e)
        {
            Console.WriteLine(e.GetType());
        }
    }

}
