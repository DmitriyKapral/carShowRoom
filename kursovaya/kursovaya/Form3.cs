using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace kursovaya
{
    public partial class Form3 : Form
    {
        private readonly string connectionString = "server=localhost;user=root;database=lab-3;password=Fr1784075;";
        MySqlConnection connection;
        public Form3()
        {
            InitializeComponent();
            numberPhoneClient.MaxLength = 11;
            passportDateClient.MaxLength = 9;
        }
        private bool connect()
        {
            try
            {
                connection = new MySqlConnection(connectionString);
                connection.Open();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка подключения к БД", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            return true;
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            connect();
        }

        private void addClients_Click(object sender, EventArgs e)
        {
            try
            {
                string name = nameClient.Text;
                string surname = surnameClient.Text;
                string middlename = middlenameClient.Text;
                string numberPhone = numberPhoneClient.Text;
                string passportDate = passportDateClient.Text;
                if (name.Length != 0 && surname.Length != 0 && middlename.Length != 0 && numberPhone.Length != 0 && passportDate.Length != 0)
                {
                    string query = "INSERT INTO clients (name, surname, middlename, `number phone`, `passport date`) VALUES(@name, @surname, @middlename, @numberphone, @passportdate)";

                    MySqlCommand command = new MySqlCommand(query, connection);

                    command.Parameters.AddWithValue("@name", name);
                    command.Parameters.AddWithValue("@surname", surname);
                    command.Parameters.AddWithValue("@middlename", middlename);
                    command.Parameters.AddWithValue("@numberphone", numberPhone);
                    command.Parameters.AddWithValue("@passportdate", passportDate);

                    command.ExecuteNonQuery();
                    connection.Close();
                    MessageBox.Show("Клиент добавлен", "Добавление");
                }
                else
                    MessageBox.Show("Введены не все данные", "Ошибка");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Введите все данные", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void numberPhoneClient_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;

            if (!char.IsDigit(number) && number != 8)
            {
                e.Handled = true;
            }
        }

        private void passportDateClient_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;

            if (!char.IsDigit(number) && number != 8)
            {
                e.Handled = true;
            }
        }
    }
}
