using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CemetaryDBInputForm
{
    public partial class CustomerView : Form
    {
        SqlConnection connection;
        String connectionString;

        public CustomerView()
        {
            InitializeComponent();

            connectionString = ConfigurationManager.ConnectionStrings["CemetaryDBInputForm.Properties.Settings.CemetaryDBConnectionString"].ConnectionString;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
