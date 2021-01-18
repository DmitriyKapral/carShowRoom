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
using MySql.Data.MySqlClient;

namespace kursovaya
{
    public partial class Form1 : Form
    {
        private readonly string connectionString = "server=localhost;user=root;database=lab-3;password=Fr1784075;";
        MySqlConnection connection;

        private void Form1_Load(object sender, EventArgs e)
        {
            connect();
            dataGridView1.AllowUserToAddRows = false;
            comboBox1.SelectedIndex = 0;
        }

        public Form1()
        {
            
            InitializeComponent();
            label8.Text = "Расчитать процент колличества\n людей с одинаковым именем";
            label9.Text = "Расчитать среднюю зарплату,\n которая меньше значения";
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

        private void loadPositions()
        {
            string sqlcar = "SELECT * FROM positions";
            MySqlCommand commander = new MySqlCommand(sqlcar, connection);
            var reader = commander.ExecuteReader();

            this.dataGridView1.Rows.Clear();
            while (reader.Read())
            {
                this.dataGridView1.Rows.Add(reader.GetInt32(0), reader.GetString(1), reader.GetInt32(2));

            }
            reader.Close();
        }
        private void loadClients()
        {
            string sqlclients = "SELECT * FROM clients";
            MySqlCommand commander = new MySqlCommand(sqlclients, connection);
            var reader = commander.ExecuteReader();

            this.dataGridView1.Rows.Clear();
            while (reader.Read())
            {
                this.dataGridView1.Rows.Add(reader.GetInt32(0), reader.GetString(1), reader.GetString(2), reader.GetString(3), reader.GetString(4), reader.GetString(5));
            }
            reader.Close();
        }
        public class Positions
        {

            public int id;

            public string name;

            public int salary;

            public Positions(int id, string name, int salary)
            {
                this.id = id;
                this.name = name;
                this.salary = salary;
            }
        }
        public class Clients
        {
            public int id;

            public string name;

            public string surname;

            public string middlename;

            public string phoneNumber;

            public string passportDate;

            public Clients(int id, string name, string surname, string middlename, string phoneNumber, string passportDate)
            {
                this.id = id;
                this.name = name;
                this.surname = surname;
                this.middlename = middlename;
                this.phoneNumber = phoneNumber;
                this.passportDate = passportDate;
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            int sum = dataGridView1.Columns.Count;
            this.dataGridView1.Rows.Clear();
            for (int i = 0; i < sum; i++)
            {
                this.dataGridView1.Columns.RemoveAt(0);
            }
            if (comboBox1.SelectedIndex == 0)
            {

                this.dataGridView1.Columns.Add("id", "id");
                dataGridView1.Columns[0].ReadOnly = true;
                this.dataGridView1.Columns.Add("name", "Имя");
                this.dataGridView1.Columns.Add("surname", "Фамилия");
                this.dataGridView1.Columns.Add("middlename", "Отчество");
                this.dataGridView1.Columns.Add("phone", "Номер телефона");
                this.dataGridView1.Columns.Add("passport", "Паспортные данные");
                loadClients();
                this.dataGridView1.AutoResizeColumns();
                addPercent.Enabled = true;
                percentToNameBox.Enabled = true;
                averageSalaryBox.Enabled = false;
                averageSalaryButton.Enabled = false;

            }
            if (comboBox1.SelectedIndex == 1)
            {
                this.dataGridView1.Columns.Add("id", "id");
                dataGridView1.Columns[0].ReadOnly = true;
                this.dataGridView1.Columns.Add("name", "Название должности");
                this.dataGridView1.Columns.Add("salary", "Заработная плата");
                loadPositions();
                this.dataGridView1.AutoResizeColumns();
                addPercent.Enabled = false;
                percentToNameBox.Enabled = false;
                averageSalaryBox.Enabled = true;
                averageSalaryButton.Enabled = true;
            }
        }

        private void Add_Click(object sender, EventArgs e)
        {
            try
            {

                if (comboBox1.SelectedIndex == 0)
                {
                    Form3 form = new Form3();
                    form.ShowDialog();
                    loadClients();
                }
                if (comboBox1.SelectedIndex == 1)
                {
                    Form2 frm = new Form2();
                    frm.ShowDialog();
                    loadPositions();
 
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка при добавлении", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Del_Click(object sender, EventArgs e)
        {
            try
            {
                if (comboBox1.SelectedIndex == 0)
                {
                    int id = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value);
                    string delete = "DELETE FROM clients WHERE id = @id";
                    MySqlCommand command = new MySqlCommand(delete, connection);
                    command.Parameters.AddWithValue("@id", id);
                    command.ExecuteNonQuery();
                    loadClients();
                }
                else if (comboBox1.SelectedIndex == 1)
                {
                    int id = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value);
                    string delete = "DELETE FROM positions WHERE id = @id";
                    MySqlCommand command = new MySqlCommand(delete, connection);
                    command.Parameters.AddWithValue("@id", id);

                    command.ExecuteNonQuery();
                    loadPositions();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка при удалении", MessageBoxButtons.OK);
            }
        }

        private void addPercent_Click(object sender, EventArgs e)
        {
            try
            {
                string name = percentToNameBox.Text;
                if (name != null)
                {
                    string percent = "SELECT (SELECT COUNT(id) FROM clients WHERE name LIKE @name)/COUNT(id)*100 FROM clients";
                    MySqlCommand command = new MySqlCommand(percent, connection);

                    command.Parameters.AddWithValue("@name", name);
                    string count = Convert.ToString(command.ExecuteScalar());
                    percentLabel.Text = "Ответ: " + count + "%";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка при удалении", MessageBoxButtons.OK);
            }
        }

        private void averageSalaryBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;

            if (!char.IsDigit(number) && number != 8)
            {
                e.Handled = true;
            }
        }

        private void averageSalaryButton_Click(object sender, EventArgs e)
        {
            try
            {
                int salary = Convert.ToInt32(averageSalaryBox.Text);
                string avg = "SELECT AVG(salary) FROM positions where salary < @salary";

                MySqlCommand command = new MySqlCommand(avg, connection);

                command.Parameters.AddWithValue("@salary", salary);

                string count = Convert.ToString(command.ExecuteScalar());
                avarageLabel.Text = "Ответ: " + count + " руб.";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка вычислении", MessageBoxButtons.OK);
            }
        }

        private void dataGridView1_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if(dataGridView1.CurrentRow != null)
            {
                DataGridViewRow dvgRow = dataGridView1.CurrentRow;
                if (comboBox1.SelectedIndex == 0)
                {
                    string update = "UPDATE clients SET name = @name, surname = @surname, middlename = @middlename, `number phone` = @numberphone, `passport date` = @passportdate WHERE id = @id";
                    MySqlCommand command = new MySqlCommand(update, connection);
                    command.Parameters.AddWithValue("@id", Convert.ToInt32(dvgRow.Cells["id"].Value));
                    command.Parameters.AddWithValue("@name", dvgRow.Cells["name"].Value.ToString());
                    command.Parameters.AddWithValue("@surname", dvgRow.Cells["surname"].Value.ToString());
                    command.Parameters.AddWithValue("@middlename", dvgRow.Cells["middlename"].Value.ToString());
                    command.Parameters.AddWithValue("@numberphone", dvgRow.Cells["phone"].Value.ToString());
                    command.Parameters.AddWithValue("@passportdate", dvgRow.Cells["passport"].Value.ToString());
                    command.ExecuteNonQuery();
                }
                if (comboBox1.SelectedIndex == 1)
                {
                    string update = "UPDATE positions SET name = @name, salary = @salary WHERE id = @id";
                    MySqlCommand command = new MySqlCommand(update, connection);
                    command.Parameters.AddWithValue("@id", Convert.ToInt32(dvgRow.Cells["id"].Value));
                    command.Parameters.AddWithValue("@name", dvgRow.Cells["name"].Value.ToString());
                    command.Parameters.AddWithValue("@salary", Convert.ToInt32(dvgRow.Cells["salary"].Value.ToString()));
                    command.ExecuteNonQuery();
                }
            }
        }
    }
}