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

namespace ITMO.ADO.Lab3.ex4.DBCommand
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void queryBtn_Click(object sender, EventArgs e)
        {
            StringBuilder results = new StringBuilder();
            sqlCommand1.CommandType = CommandType.Text;
            sqlConnection1.Open();
            using (SqlDataReader reader = sqlCommand1.ExecuteReader())
            {
                bool MoreResults = false;
                do
                {
                    while (reader.Read())
                    {
                        for (int i = 0; i < reader.FieldCount; i++)
                        {
                            results.Append(reader[i].ToString() + "\t");
                        }
                        results.Append(Environment.NewLine);
                    }
                    MoreResults = reader.NextResult();
                } while (MoreResults);
            }
            sqlCommand1.Connection.Close();
            resultsTextBox.Text = results.ToString();
        }

        private void procedureBtn_Click(object sender, EventArgs e)
        {
            StringBuilder results = new StringBuilder();
            sqlCommand2.CommandType = CommandType.StoredProcedure;
            sqlCommand2.CommandText = "Ten Most Expensive Products";
            sqlCommand2.Connection.Open();
            using (SqlDataReader reader = sqlCommand2.ExecuteReader())
            {
                while (reader.Read())
                {
                    for (int i = 0; i < reader.FieldCount; i++)
                    {
                        results.Append(reader[i].ToString() + "\t");
                    }
                    results.Append(Environment.NewLine);
                }
            }
            sqlCommand2.Connection.Close();
            resultsTextBox.Text = results.ToString();
        }

        private void createTableBtn_Click(object sender, EventArgs e)
        {
            try
            {
                sqlCommand3.CommandType = CommandType.Text;
                sqlCommand3.CommandText = "CREATE TABLE SalesPersons (" +
                       "[SalesPersonID] [int] IDENTITY(1,1) NOT NULL, " +
                       "[FirstName] [nvarchar](50)  NULL, " +
                       "[LastName] [nvarchar](50)  NULL)";
                sqlCommand3.Connection.Open();
                sqlCommand3.ExecuteNonQuery();
                MessageBox.Show("Таблица SalesPersons создана");
            }
            catch (SqlException ex)
            {
                foreach (SqlError error in ex.Errors)
                {
                    MessageBox.Show(error.Message);
                }
            }
            finally
            {
                sqlCommand3.Connection.Close();
            }
        }

        private void queryParamBtn_Click(object sender, EventArgs e)
        {
            StringBuilder results = new StringBuilder();
            sqlCommand4.CommandType = CommandType.Text;
            sqlCommand4.Parameters["@City"].Value = cityTextBox.Text;
            sqlConnection1.Open();
            using (SqlDataReader reader = sqlCommand4.ExecuteReader())
            {
                bool MoreResults = false;
                do
                {
                    while (reader.Read())
                    {
                        for (int i = 0; i < reader.FieldCount; i++)
                        {
                            results.Append(reader[i].ToString() + "\t");
                        }
                        results.Append(Environment.NewLine);
                    }
                    MoreResults = reader.NextResult();
                } while (MoreResults);
            }
            sqlCommand4.Connection.Close();
            resultsTextBox.Text = results.ToString();
        }

        private void procedureParamBtn_Click(object sender, EventArgs e)
        {
            StringBuilder results = new StringBuilder();
            sqlCommand5.Parameters["@CategoryName"].Value = categoryNameTextBox.Text;
            sqlCommand5.Parameters["@OrdYear"].Value = ordYearTextBox.Text;
            sqlCommand5.Connection.Open();
            using (SqlDataReader reader = sqlCommand5.ExecuteReader())
            {
                while (reader.Read())
                {
                    for (int i = 0; i < reader.FieldCount; i++)
                    {
                        results.Append(reader[i].ToString() + "\t");
                    }
                    results.Append(Environment.NewLine);
                }
            }
            sqlCommand5.Connection.Close();
            resultsTextBox.Text = results.ToString();
        }
    }
}
