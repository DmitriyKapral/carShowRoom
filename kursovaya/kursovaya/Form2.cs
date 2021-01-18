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
    public partial class Form2 : Form
    {
        private readonly string connectionString = "server=localhost;user=root;database=lab-3;password=Fr1784075;";
        MySqlConnection connection;
        public Form2()
        {
            InitializeComponent();
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

        private void AddButton_Click(object sender, EventArgs e)
        {
            try
            {
                string name = namePosition.Text;
                string salary = salaryPosition.Text;
                if (name.Length != 0 && salary.Length != 0)
                {
                    string query = "INSERT INTO positions (name, salary) VALUES (@name, @salary)";
                    MySqlCommand command = new MySqlCommand(query, connection);
                    command.Parameters.AddWithValue("@name", name);
                    command.Parameters.AddWithValue("@salary", Convert.ToInt32(salary));
                    command.ExecuteNonQuery();
                    connection.Close();
                    MessageBox.Show("Должность добавлена", "Добавление");
                }
                else
                    MessageBox.Show("Введите все данные", "Ошибка");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Данные не введены");
            }
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            connect();
        }

        private void salaryPosition_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;

            if (!char.IsDigit(number) && number != 8)
            {
                e.Handled = true;
            }
        }
    }
}
