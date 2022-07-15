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

namespace ReactPC
{
    public partial class NewClient : Form
    {
        DBConnect database = new DBConnect();
        public NewClient()
        {
            InitializeComponent();
        }

        private void NewClient_Load(object sender, EventArgs e)
        {
            LoadCategory();
        }
        public void LoadCategory()
        {
            comboBox1.Items.Clear();
            comboBox1.DataSource = database.getTable("SELECT * FROM city");
            comboBox1.DisplayMember = "city";
            comboBox1.ValueMember = "id_city";
        }

        private void buttonNew_Click(object sender, EventArgs e)
        {
            database.openConnection();
            var name = textBox1.Text;
            var surname = textBox2.Text;
            var city = comboBox1.SelectedValue;
            var addres = textBox3.Text;
            var phone = textBox4.Text;
            if (textBox1.Text != "")
            {
                var addQuery = $"insert into client (name_client, surname_client, id_city, addres_client, phone_client) VALUES ('{name}','{surname}', '{city}','{addres}','{phone}')";

                var command = new SqlCommand(addQuery, database.getConnection());
                command.ExecuteNonQuery();

                MessageBox.Show("Запись создана!");
            }
            else
            {
                MessageBox.Show("Ошибка при создании записи!");
            }
            database.closeConnection();
        }
    }
}
