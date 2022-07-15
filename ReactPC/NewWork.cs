using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace ReactPC
{
    public partial class NewWork : Form
    {
        DBConnect database = new DBConnect();
        public NewWork()
        {
            InitializeComponent();
        }
        private void NewWork_Load(object sender, EventArgs e)
        {
            LoadCategory();
        }
        public void LoadCategory()
        {
            comboBox1.Items.Clear();
            comboBox1.DataSource = database.getTable("SELECT * FROM devicetype");
            comboBox1.DisplayMember = "devicetype";
            comboBox1.ValueMember = "id_devicetype";
        }
        private void buttonNew_Click(object sender, EventArgs e)
        {
            database.openConnection();
            var work = textBoxNewWork.Text;
            int price;
            var type = comboBox1.SelectedValue;
            if (int.TryParse(textBoxPriceWork.Text, out price))
            {
                var addQuery = $"insert into work (id_devicetype, work, price) VALUES ('{type}','{work}', '{price}')";

                var command = new SqlCommand(addQuery, database.getConnection());
                command.ExecuteNonQuery();

                MessageBox.Show("Новая запись добавлена!");
            }
            else
            {
                MessageBox.Show("Ошибка при создании записи!");
            }
            database.closeConnection();
        }

        private void textBoxPriceWork_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxNewWork_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
