using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
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
            btSaveEdit.DialogResult = DialogResult.OK;
            dtpBirthday.Format = DateTimePickerFormat.Custom;
            dtpBirthday.CustomFormat = "yyyy-MM-dd";
            tbId.Text = id.ToString();
            //регулирование формата открытия формы
            //если форма открыта с помощью кнопки, то id будет присвоено 0, соответственно это окно добавления пользователя
            //если форма открыта двойным щелчком по ячейке DGV, то id не будет равен 0
            if (tbId.Text != "0")
            {
                //форма для изменения
                btSaveEdit.Text = "Изменить";
                tbName.Text = name;
                tbLName.Text = lastName;
                tbPatron.Text = patronymic;
                dtpBirthday.Text = birthday;
                tbEmail.Text = email;
                tbPhone.Text = phone;
                cmbGenderCode.Text = genderCode;
                phPath = photoPath;
                pbAvatar.Image = Image.FromFile(phPath);

            }
            else
            {
                //форма для добавления
                btSaveEdit.Text = "Добавить";
            }
        }

        private void tbPhone_KeyPress(object sender, KeyPressEventArgs e)
        {
            //регулировка знаков доступных для поля телефона
            char number = e.KeyChar;
            if (Char.IsNumber(e.KeyChar) | (e.KeyChar == Convert.ToChar("+")) | (e.KeyChar == Convert.ToChar("-")) | (e.KeyChar == Convert.ToChar("-")) | (e.KeyChar == Convert.ToChar("(")) | (e.KeyChar == Convert.ToChar(")")) | e.KeyChar == '\b')
            {
                
            }
            else
            {
                e.Handled = true;
            }
        }

        private void btAddImage_Click(object sender, EventArgs e)
        {
                //Загрузка картинок в форму
                if (_fileDialog.ShowDialog() == DialogResult.OK)
                {
                    var size = new FileInfo(_fileDialog.FileName).Length;
                    size = Convert.ToInt32(size);
                    size /= 1000000;
                //ограничение картнок по размеру
                    if (size <=2)
                    {
                        pbAvatar.Image = Image.FromFile(_fileDialog.FileName);
                        phPath = _fileDialog.FileName;
                    }
                    else
                    {
                        MessageBox.Show("Слишком большой размер картинки");
                    }
                }
        }

        private void btSaveEdit_Click(object sender, EventArgs e)
        {
            //проверка на заполненность полей
            if (tbName.Text==""|tbLName.Text == ""|tbPhone.Text == "" | cmbGenderCode.Text == "" | phPath==null)
            {
                MessageBox.Show("Введите все значения и картинку");
            }
            else
            {
                //регулирование функционала кнопки, в зависимости от способа открытия формы
                //Редактирование
                if (btSaveEdit.Text == "Изменить")
                {
                    using (SqlConnection connection = new SqlConnection(connection1.connectionString))
                    using (SqlCommand command = connection.CreateCommand())
                    {
                        command.CommandText = "UPDATE Clients SET FirstName = @name, LastName = @lName, Patronymic = @patronymic," +
                            "Birthday = @birthday,Email = @Email, Phone = @Phone,GenderCode = @GenderCode,PhotoPath = @PhotoPath Where Id = @Id";
                        command.Parameters.AddWithValue("@Id", tbId.Text);
                        command.Parameters.AddWithValue("@name", tbName.Text);
                        command.Parameters.AddWithValue("@lName", tbLName.Text);
                        command.Parameters.AddWithValue("@patronymic", tbPatron.Text);
                        command.Parameters.AddWithValue("@birthday", dtpBirthday.Text);
                        command.Parameters.AddWithValue("@Email", tbEmail.Text);
                        command.Parameters.AddWithValue("@Phone", tbPhone.Text);
                        command.Parameters.AddWithValue("@GenderCode", cmbGenderCode.Text);
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
                    //добавление
                    using (SqlConnection connection = new SqlConnection(connection1.connectionString))
                    using (SqlCommand command = connection.CreateCommand())
                    {
                        //SQL запрос на добавление данныых  в БД
                        command.CommandText = "Insert into Clients (FirstName, LastName, Patronymic,Birthday,RegistrationDate,Email,Phone,GenderCode,PhotoPath) " +
                            "Values (@name, @lName,@patronymic," +
                            "@birthday,@RegistrationDate,@Email,@Phone,@GenderCode,@PhotoPath)";
                        //параметры для SQL запроса
                        command.Parameters.AddWithValue("@name", tbName.Text);
                        command.Parameters.AddWithValue("@lName", tbLName.Text);
                        command.Parameters.AddWithValue("@patronymic", tbPatron.Text);
                        command.Parameters.AddWithValue("@birthday", dtpBirthday.Text);
                        command.Parameters.AddWithValue("@RegistrationDate", DateTime.Now);
                        command.Parameters.AddWithValue("@Email", tbEmail.Text);
                        command.Parameters.AddWithValue("@Phone", tbPhone.Text);
                        command.Parameters.AddWithValue("@GenderCode", cmbGenderCode.Text);
                        command.Parameters.AddWithValue("@PhotoPath", phPath);


                        connection.Open();
                        command.ExecuteNonQuery();
                        connection.Close();
                        MessageBox.Show("Добавление заваршено");
                        this.Close();
                    }
                }
                
            }
        }
    }
}
