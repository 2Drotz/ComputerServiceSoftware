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
    public partial class Form1 : Form
    {

        DBConnect database = new DBConnect();
        public Form1()
        {
            InitializeComponent();
            LoadCategory();
        }

        private void buttonNew_Click(object sender, EventArgs e)
        {
            database.openConnection();
            var repair = textBox1.Text;
            int type = Convert.ToInt32(textBox3.Text);
            int brand = Convert.ToInt32(comboBox1.SelectedValue);
            decimal price;
            if(decimal.TryParse(textBox2.Text,  out price)){
                var addQuery = $"insert into test_repair (repair_name, price, id_devicetype, id_brand) VALUES ('{repair}','{price}','{type}','{brand}')";

                var command = new SqlCommand(addQuery, database.getConnection());
                command.ExecuteNonQuery();

                MessageBox.Show("Запись создана!");
            }
            else{
                MessageBox.Show("Ошибка при создании записи!");
            }
            database.closeConnection(); 
        }


        // cКОМБО БОКС
        public void LoadCategory()
        {
            comboBox1.Items.Clear();
            comboBox1.DataSource = database.getTable("SELECT * FROM brand");
            comboBox1.DisplayMember = "brand";
            comboBox1.ValueMember = "id_brand";
        }


        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
