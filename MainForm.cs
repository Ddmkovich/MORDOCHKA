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
        DataSet ds;
        Classes.Connection connection = new Classes.Connection();
        Classes.Querys querys = new Classes.Querys();
        
        public MainForm()
        {
            InitializeComponent();
            panel1.BackColor = Color.FromArgb(225, 228, 255);
            panel2.BackColor = Color.FromArgb(225, 228, 255);
            panel3.BackColor = Color.FromArgb(225, 228, 255);
            panel4.BackColor = Color.FromArgb(225, 228, 255);
            dgvClient.SelectionMode =DataGridViewSelectionMode.FullRowSelect;
            dgvClient.AllowUserToAddRows = false;
            Query(connection.connectionString, querys.GetSql(pageNumber, pageSize));
            rowCount = pageSize;
            maxRows = Convert.ToInt32(RowCount(connection.connectionString,  querys.GetSql(pageNumber,pageSize)));
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
            Query(connection.connectionString, querys.GetSql(pageNumber, pageSize));
        }

        private void btNext_Click(object sender, EventArgs e)
        {
            if (rowCount >= maxRows) return;
            pageNumber++;
            rowCount += pageSize;
            lbRows.Text = rowCount.ToString();
            Query(connection.connectionString, querys.GetSql(pageNumber, pageSize));

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
                Query(connection.connectionString, querys.GetSql(pageNumber, pageSize));
            }
            else
            {
                pageSize = 10000;
                pageNumber = 0;
                rowCount = pageSize;
                lbRows.Text = rowCount.ToString();
                Query(connection.connectionString, querys.GetSql(pageNumber, pageSize));
            }
            
        }

        private void tbFiltrName_TextChanged(object sender, EventArgs e)
        {

            if (cmbFiltrGender.Text != "ВСЕ")
            {
                (dgvClient.DataSource as DataTable).DefaultView.RowFilter =
                String.Format("FirstName like '{0}%' AND GenderCode like '{1}%' OR LastName like '{0}%' AND GenderCode like '{1}%' OR Patronymic like '{0}%' AND GenderCode like '{1}%'", tbFiltrName.Text, cmbFiltrGender.Text);
            }
            else
            {
                (dgvClient.DataSource as DataTable).DefaultView.RowFilter =
                String.Format("FirstName like '{0}%' OR LastName like '{0}%' OR Patronymic like '{0}%'", tbFiltrName.Text);
            }

        }

        private void tbFiltrMail_TextChanged(object sender, EventArgs e)
        {

            if (cmbFiltrGender.Text != "ВСЕ")
            {
                (dgvClient.DataSource as DataTable).DefaultView.RowFilter =
                String.Format("Email like '{0}%' AND GenderCode like '{1}%'", tbFiltrMail.Text, cmbFiltrGender.Text);
            }
            else
            {
                (dgvClient.DataSource as DataTable).DefaultView.RowFilter =
                String.Format("Email like '{0}%'", tbFiltrMail.Text);
            }

        }

        private void tbFiltrPhone_TextChanged(object sender, EventArgs e)
        {
            
            if (cmbFiltrGender.Text != "ВСЕ")
            {
                (dgvClient.DataSource as DataTable).DefaultView.RowFilter =
                String.Format("Phone like '{0}%' AND GenderCode like '{1}%'", tbFiltrPhone.Text, cmbFiltrGender.Text);
            }
            else
            {
                (dgvClient.DataSource as DataTable).DefaultView.RowFilter =
                String.Format("Phone like '{0}%'", tbFiltrPhone.Text);
            }
        }

        private void cmbFiltrGender_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbFiltrGender.Text != "ВСЕ")
            {
                (dgvClient.DataSource as DataTable).DefaultView.RowFilter =
                String.Format("GenderCode like '{0}%'", cmbFiltrGender.Text);
            }
            else
            {
                (dgvClient.DataSource as DataTable).DefaultView.RowFilter =
                String.Format("GenderCode like '{0}%'", "");
            }
        }
        private void btAddClient_Click(object sender, EventArgs e)
        {
            EdAddForm edAddForm = new EdAddForm(0,null,null,null,null,null,null,null,null);
            DialogResult dr = edAddForm.ShowDialog(this);
            if (dr == DialogResult.OK)
            {
                dgvClient.DataSource = null;
                Query(connection.connectionString, querys.GetSql(pageNumber, pageSize));
                rowCount = pageSize;
                maxRows = Convert.ToInt32(RowCount(connection.connectionString, querys.GetSql(pageNumber, pageSize)));
                lbRows.Text = rowCount.ToString();
                lbAllRows.Text = maxRows.ToString();
                edAddForm.Close();
            }
            else
            {
                edAddForm.Close();
            }
        }

        private void dgvClient_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewSelectedCellCollection DGV = this.dgvClient.SelectedCells;
            int id = Convert.ToInt32(this.dgvClient.CurrentRow.Cells[0].Value);
            string name = this.dgvClient.CurrentRow.Cells[1].Value.ToString();
            string lastName = this.dgvClient.CurrentRow.Cells[2].Value.ToString();
            string patronymic = this.dgvClient.CurrentRow.Cells[3].Value.ToString();
            string birthday = this.dgvClient.CurrentRow.Cells[4].Value.ToString();
            string email = this.dgvClient.CurrentRow.Cells[6].Value.ToString();
            string phone = this.dgvClient.CurrentRow.Cells[7].Value.ToString();
            string genderCode = this.dgvClient.CurrentRow.Cells[8].Value.ToString();
            string photoPath = this.dgvClient.CurrentRow.Cells[9].Value.ToString();
            EdAddForm edAddForm = new EdAddForm(id,name,lastName,patronymic,birthday,email,phone,genderCode,photoPath);
            
            edAddForm.Text = "Изменить клиента";
            DialogResult dr = edAddForm.ShowDialog(this);
            if (dr == DialogResult.OK)
            {
                Query(connection.connectionString, querys.GetSql(pageNumber, pageSize));
                rowCount = pageSize;
                maxRows = Convert.ToInt32(RowCount(connection.connectionString, querys.GetSql(pageNumber, pageSize)));
                lbRows.Text = rowCount.ToString();
                lbAllRows.Text = maxRows.ToString();
                edAddForm.Close();
            }
            else
            {
                edAddForm.Close();
            }

        }
        private void btSortLName_Click(object sender, EventArgs e)
        {
            Query(connection.connectionString, "SELECT Clients.ID, FirstName,LastName, Patronymic, Birthday, RegistrationDate, Email, Phone, GenderCode,PhotoPath,max(StartTime) as LastVisit,COUNT(StartTime) as Visit " +
        "FROM Clients LEFT JOIN ClientService " +
        "ON ClientService.ClientID = Clients.ID " +
        "Group by Clients.ID, FirstName, LastName, Patronymic, Birthday, RegistrationDate, Email, Phone, GenderCode,PhotoPath " +
        "ORDER BY LastName  OFFSET ((" + pageNumber + ") * " + pageSize + ") " +
                "ROWS FETCH NEXT " + pageSize + "ROWS ONLY");
        }
        private void btFiltrVisitCount_Click(object sender, EventArgs e)
        {
            Query(connection.connectionString, "SELECT Clients.ID, FirstName,LastName, Patronymic, Birthday, RegistrationDate, Email, Phone, GenderCode,PhotoPath,max(StartTime) as LastVisit,COUNT(StartTime) as Visit " +
        "FROM Clients LEFT JOIN ClientService " +
        "ON ClientService.ClientID = Clients.ID " +
        "Group by Clients.ID, FirstName, LastName, Patronymic, Birthday, RegistrationDate, Email, Phone, GenderCode,PhotoPath " +
        "ORDER BY Visit  DESC OFFSET ((" + pageNumber + ") * " + pageSize + ") " +
                "ROWS FETCH NEXT " + pageSize + "ROWS ONLY");
        }

        private void btFiltrLastVisit_Click(object sender, EventArgs e)
        {
            Query(connection.connectionString, "SELECT Clients.ID, FirstName,LastName, Patronymic, Birthday, RegistrationDate, Email, Phone, GenderCode,PhotoPath,max(StartTime) as LastVisit,COUNT(StartTime) as Visit " +
        "FROM Clients LEFT JOIN ClientService " +
        "ON ClientService.ClientID = Clients.ID " +
        "Group by Clients.ID, FirstName, LastName, Patronymic, Birthday, RegistrationDate, Email, Phone, GenderCode,PhotoPath " +
        "ORDER BY LastVisit DESC OFFSET ((" + pageNumber + ") * " + pageSize + ") " +
                "ROWS FETCH NEXT " + pageSize + "ROWS ONLY");
        }
    }
}
