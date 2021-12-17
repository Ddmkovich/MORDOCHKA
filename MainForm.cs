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
        int pageSize = 10; // размер страницы
        int pageNumber = 0; // текущая страница
        int rowCount;
        int maxRows;
        DataTable tagTbl = new DataTable();
        DataSet ds;
        string connectionString = @"Server=10.10.1.24;Database=PolitDV;User id =pro-41;Password=Pro_41student;TrustServerCertificate =True;";
        public MainForm()
        {
            InitializeComponent();
            dgvClient.SelectionMode =DataGridViewSelectionMode.FullRowSelect;
            dgvClient.AllowUserToAddRows = false;
            Query(connectionString, GetSql());
            rowCount = pageSize;
            maxRows = Convert.ToInt32(RowCount(connectionString, GetSql()));
            lbRows.Text = rowCount.ToString();
            lbAllRows.Text = maxRows.ToString();
        }

        private void dgvClient_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {
            //Поиск тега в таблице и его окраска в цвет
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
        private void Query(string connStr,string sqlQuery)
        {
            using (SqlConnection connection = new SqlConnection(connStr))
            {
                connection.Open();
                // Создаем объект DataAdapter
                SqlDataAdapter adapter = new SqlDataAdapter(sqlQuery, connection);
                // Создаем объект DataSet
                ds = new DataSet();
                // Заполняем Dataset
                adapter.Fill(ds);
                dgvClient.DataSource = ds.Tables[0];
                dgvClient.Columns["ID"].ReadOnly = true;
                connection.Close();
                

            }
        }
        private string RowCount(string connStr, string sqlQuery)
        {
            using (SqlConnection connection = new SqlConnection(connStr))
            { 
                connection.Open();
                // Создаем объект DataAdapter
                SqlCommand command = new SqlCommand(MaxId(), connection);
                // Создаем объект DataSet
                int reader = (int)command.ExecuteScalar();
                string maxId = reader.ToString();
                connection.Close();
                return maxId;

            }

        }
        private void MainForm_Load(object sender, EventArgs e)
        {

        }

        private void btPrev_Click(object sender, EventArgs e)
        {
            if (pageNumber == 0) return;
            pageNumber--;
            rowCount -= pageSize;
            lbRows.Text = rowCount.ToString();
            Query(connectionString, GetSql());
        }

        private void btNext_Click(object sender, EventArgs e)
        {
            if (rowCount >= maxRows) return;
            pageNumber++;
            rowCount += pageSize;
            lbRows.Text = rowCount.ToString();
            Query(connectionString, GetSql());
        }
        private string GetSql()
        {
            return "SELECT * FROM Clients ORDER BY Id OFFSET ((" + pageNumber + ") * " + pageSize + ") " +
                "ROWS FETCH NEXT " + pageSize + "ROWS ONLY";
        }
        private string MaxId()
        {
            return "SELECT Count(*) FROM Clients";
        }
        private void cmbPageSizeSelectedIndexChanged(object sender, EventArgs e)
        {
            
            if (cmbPageSize.Text!="Все")
            {
                pageSize = Convert.ToInt32(cmbPageSize.Text);
                pageNumber = 0;
                rowCount = pageSize;
                if (rowCount>maxRows)
                {
                    rowCount = maxRows;
                }
                lbRows.Text = rowCount.ToString();
                Query(connectionString, GetSql());
            }
            else
            {
                pageSize = 10000;
                pageNumber = 0;
                rowCount = pageSize;
                lbRows.Text = rowCount.ToString();
                Query(connectionString, GetSql());
            }
            
        }

        private void tbFiltrName_TextChanged(object sender, EventArgs e)
        {
            (dgvClient.DataSource as DataTable).DefaultView.RowFilter =
            String.Format("FirstName like '{0}%'", tbFiltrName.Text);
        }
    }
}
