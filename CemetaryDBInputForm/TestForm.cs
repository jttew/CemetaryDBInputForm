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
    public partial class TestForm : Form
    {
        SqlConnection connection;
        String connectionString;

        public TestForm()
        {
            InitializeComponent();

            connectionString = ConfigurationManager.ConnectionStrings["CemetaryDBInputForm.Properties.Settings.CemetaryDBConnectionString"].ConnectionString;
        }

        

        private void populatePlotTable()
        {
            using (connection = new SqlConnection(connectionString))
            using (SqlDataAdapter adapter = new SqlDataAdapter("SELECT * FROM Plots", connection))
            {
                connection.Open();
                DataTable plotTable = new DataTable();
                adapter.Fill(plotTable);

                plotDataGridView.DataSource = plotTable;
                connection.Close();
            }
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            string query = "INSERT INTO Plots VALUES (@PlotID, @Name, @Location, @IsSold, @IsUsed, @IsMarked, @IsDeceased, @IsRulesCompliant, @PlotNotes)";

            using (connection = new SqlConnection(connectionString))
            using (SqlCommand command = new SqlCommand(query, connection))
            {
                connection.Open();

                command.Parameters.AddWithValue("@PlotID", plotIdTextBox.Text);
                command.Parameters.AddWithValue("@Name", nameTextBox.Text);
                command.Parameters.AddWithValue("@Location", locationTextBox.Text);
                command.Parameters.AddWithValue("@IsSold", isSoldCheckBox.Checked);
                command.Parameters.AddWithValue("@IsUsed", usedCheckBox.Checked);
                command.Parameters.AddWithValue("@IsMarked", markedCheckBox.Checked);
                command.Parameters.AddWithValue("@IsDeceased", deceasedCheckBox.Checked);
                command.Parameters.AddWithValue("@IsRulesCompliant", rulesCompliantCheckBox.Checked);
                command.Parameters.AddWithValue("@PlotNotes", notesTextBox.Text);
                try
                {
                    command.ExecuteNonQuery();
                }
                catch (SqlException ex)
                {
                    switch (ex.Number)
                    {
                        case 2627: //case number where duplicate is inserted
                            MessageBox.Show("Plot ID already exists.  This entry was not logged.");
                            break;
                        case 8152:
                            MessageBox.Show("An entry item has too many characters to be saved.");
                            break;
                        default:
                            throw;
                    }
                }
            }
            populatePlotTable();
        }
        /*
        private void saveButton_Click(object sender, EventArgs e)
        {
            string queryTemplate = "INSERT INTO Plots VALUES ({0});";

            string isSoldValue = "0";
            string isUsedValue = "0";
            string isMarkedValue = "0";
            string isDeceasedValue = "0";
            string isRulesCompliantValue = "0";

            if (isSoldCheckBox.Checked)
            {
                isSoldValue = "1";
            }
            if (usedCheckBox.Checked)
            {
                isUsedValue = "1";
            }
            if (markedCheckBox.Checked)
            {
                isMarkedValue = "1";
            }
            if (deceasedCheckBox.Checked)
            {
                isDeceasedValue = "1";
            }
            if (rulesCompliantCheckBox.Checked)
            {
                isRulesCompliantValue = "1";
            }

            string queryData = "'" + plotIdTextBox.Text + "','" + nameTextBox.Text + "','" + locationTextBox.Text +
                "','" + isSoldValue + "','" + isUsedValue + "','" + isMarkedValue + "','" + isDeceasedValue + "','" +
                isRulesCompliantValue + "','" + notesTextBox.Text + "'";

            string query = String.Format(queryTemplate, queryData);

            using (connection = new SqlConnection(connectionString))
            using (SqlCommand command = new SqlCommand(query, connection))
            {
                connection.Open();

                command.Parameters.AddWithValue('@RecipeName', txtrecipename.Text);

                command.ExecuteNonQuery();
            }
            populatePlotTable();
        }
        */

        private void loadTableButton_Click(object sender, EventArgs e)
        {
            populatePlotTable();
        }

        private void TestForm_Load(object sender, EventArgs e)
        {
            populatePlotTable();
        }

        private void plotDataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }
    }
}
