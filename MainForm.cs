using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;

namespace MORDOCHKA
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();


            string connectionString = @"Server=10.10.1.24;Database=PolitDV;User id =pro-41;Password=Pro_41student;TrustServerCertificate =True;";
            string sql = "Select Clients.ID,Clients.FirstName,Clients.LastName,Clients.Patronymic,Clients.Birthday,Clients.RegistrationDate,Clients.Email,Clients.GenderCode,Clients.PhotoPath,Tag.Title as Tag from Clients, Tag, TagOfClient Where TagOfClient.ClientID = Clients.ID";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                // Создаем объект DataAdapter
                SqlDataAdapter adapter = new SqlDataAdapter(sql, connection);
                // Создаем объект DataSet
                DataSet ds = new DataSet();
                // Заполняем Dataset
                adapter.Fill(ds);
                dgvClient.DataSource = ds.Tables[0];
                connection.Close();
            }
        }

        private void dgvClient_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {
            //string connectionString = @"Server=10.10.1.24;Database=PolitDV;User id =pro-41;Password=Pro_41student;TrustServerCertificate =True;";
            //string sql = "select Tag.Title,Tag.Color from Tag,TagOfClient Where TagOfClient.TagID = Tag.ID";
            //using (SqlConnection connection = new SqlConnection(connectionString))
            //{
            //    // Создаем объект DataAdapter
            //    SqlDataAdapter adapter = new SqlDataAdapter(sql, connection);
            //    // Создаем объект DataSet
            //    DataSet ds = new DataSet();
            //    // Заполняем Dataset
            //    adapter.Fill(ds);

            //}

            for (int i = 0; i < dgvClient.ColumnCount; i++)
            {
                bool firstFound = false;
                for (int j = 0; j < dgvClient.RowCount; j++)
                {
                    if (dgvClient[i, j].Value != null && !dgvClient[i, j].Value.Equals("Постоянный") && !firstFound)
                    {
                        firstFound = true;
                    }

                    else if (dgvClient[i, j].Value != null && dgvClient[i, j].Value.ToString() == "Постоянный")
                    {
                        dgvClient[i, j].Style.ForeColor = Color.Red;
                    }
                }
            }
        }
    }
}
