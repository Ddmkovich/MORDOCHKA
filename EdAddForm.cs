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
    public partial class EdAddForm : Form
    {
        Classes.Connection connection1 = new Classes.Connection();
        OpenFileDialog _fileDialog = new OpenFileDialog();
        string phPath;
        public EdAddForm(int id, string name,string lastName,string patronymic,string birthday,string email,string phone,string genderCode,string photoPath)
        {
            InitializeComponent();
            dtpBirthday.Format = DateTimePickerFormat.Custom;
            dtpBirthday.CustomFormat = "yyyy-MM-dd";
            tbId.Text = id.ToString();
            if (tbId.Text != "0")
            { 
                btSaveEdit.Text = "Изменить";
                tbName.Text = name;
                tbLName.Text = lastName;
                tbPatron.Text = patronymic;
                dtpBirthday.Text = birthday;
                tbEmail.Text = email;
                tbPhone.Text = phone;
                tbGender.Text = genderCode;
                phPath = photoPath;
                pbAvatar.Image = Image.FromFile(phPath);

            }
            else
            {
                btSaveEdit.Text = "Добавить";
            }
        }

        private void tbPhone_KeyPress(object sender, KeyPressEventArgs e)
        {
            //char number = e.KeyChar;
            //if ((e.KeyChar <= 47 || e.KeyChar >= 58) && number != 8 && (e.KeyChar == 40 || e.KeyChar == 41 || e.KeyChar == 43 || e.KeyChar == 45 || e.KeyChar == 255))
            //{
            //    e.Handled = true;
            //}
        }

        private void btAddImage_Click(object sender, EventArgs e)
        {
                if (_fileDialog.ShowDialog() == DialogResult.OK)
                {
                    pbAvatar.Image = Image.FromFile(_fileDialog.FileName);
                }
        }

        private void btSaveEdit_Click(object sender, EventArgs e)
        {
            if (btSaveEdit.Text =="Изменить")
            {
                using (SqlConnection connection = new SqlConnection(connection1.connectionString))
                using (SqlCommand command = connection.CreateCommand())
                {
                    //command.CommandText = "UPDATE Client SET FirstName = " + tbName.Text + "," +
                    //    " Lastname = " + tbLName.Text + "," + "Patronymic = " + tbPatron.Text + "," +
                    //    " Birthday = " + dtpBirthday.Text + "," + "Email = " + tbEmail.Text + "," +
                    //    " Phone = " + tbPhone.Text + "," + "GenderCode = " + tbGender.Text + "," +
                    //    " PhotoPath = " + phPath + ""+
                    //    " Where Id = " + tbId.Text+"";
                    command.CommandText = "UPDATE Clients SET FirstName = @name, LastName = @lName, Patronymic = @patronymic," +
                        "Birthday = @birthday,Email = @Email, Phone = @Phone,GenderCode = @GenderCode,PhotoPath = @PhotoPath Where Id = @Id";

                    command.Parameters.AddWithValue("@Id", tbId.Text);
                    command.Parameters.AddWithValue("@name", tbName.Text);
                    command.Parameters.AddWithValue("@lName", tbLName.Text);
                    command.Parameters.AddWithValue("@patronymic", tbPatron.Text);
                    command.Parameters.AddWithValue("@birthday", dtpBirthday.Text);
                    command.Parameters.AddWithValue("@Email", tbEmail.Text);
                    command.Parameters.AddWithValue("@Phone", tbPhone.Text);
                    command.Parameters.AddWithValue("@GenderCode", tbGender.Text);
                    command.Parameters.AddWithValue("@PhotoPath", phPath);


                    connection.Open();
                    command.ExecuteNonQuery();
                    connection.Close();
                    MessageBox.Show("Изменение заваршено");
                    this.Close();
                }
            }
            else
            {

            }
        }
    }
}
