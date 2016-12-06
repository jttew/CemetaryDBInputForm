using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
using System.Data.SqlClient;

namespace CemetaryDBInputForm
{
    public partial class Form1 : Form
    {
        SqlConnection connection;
        String connectionString;

        public Form1()
        {
            InitializeComponent();

            connectionString = ConfigurationManager.ConnectionStrings["CemetaryDBInputForm.Properties.Settings.CemetaryDBConnectionString"].ConnectionString;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            populateTransactions();
        }

        private void populateTransactions()
        {
            using (connection = new SqlConnection(connectionString))
            using (SqlDataAdapter adapter = new SqlDataAdapter("SELECT * FROM Transactions", connection))
            {
                connection.Open();
                DataTable transactionsTable = new DataTable();
                adapter.Fill(transactionsTable);

                listTransactionPlotId.DisplayMember = "plot_id";
                listTransactionPlotId.ValueMember = "id";
                listTransactionPlotId.DataSource = transactionsTable;

            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
