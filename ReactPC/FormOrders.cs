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
using Word = Microsoft.Office.Interop.Word;

namespace ReactPC
{
    public partial class FormOrders : Form
    {
        private readonly checkAdmin _user;
        DBConnect database = new DBConnect();
        private int i;

        public FormOrders(checkAdmin user)
        {
            _user = user;
            InitializeComponent();
            LoadCategory();
            LoadCategory2();
            Serial();
            labelName();
        }

        private void labelName()
        {
            string nameUser = $"SELECT CONCAT(name_user, ' ' , surname_user) AS userss FROM users WHERE login_user  = '{_user.Login}'";
            SqlCommand command = new SqlCommand(nameUser, database.getConnection());

            database.openConnection();
            SqlDataReader read = command.ExecuteReader();

            while (read.Read())
            {
                lblUsername.Text = read["userss"].ToString();
            }
            read.Close();

        }
        public void LoadCategory()
        {
            comboBoxClient.Items.Clear();
            comboBoxClient.DataSource = database.getTable("SELECT id_client, CONCAT(name_client, ' ', surname_client) AS client FROM client");
            comboBoxClient.DisplayMember = "client";
            comboBoxClient.ValueMember = "id_client";

            comboBoxType.Items.Clear();
            comboBoxType.DataSource = database.getTable("SELECT id_devicetype, devicetype FROM devicetype");
            comboBoxType.DisplayMember = "devicetype";
            comboBoxType.ValueMember = "id_devicetype";

        }
        public void LoadCategory2()
        {

            var model = Convert.ToInt32(comboBoxType.SelectedValue);

            //comboBoxModel.Items.Clear();
            comboBoxModel.DataSource = database.getTable($"SELECT id_model, CONCAT(brand, ' ', name_model) AS models FROM model INNER JOIN brand ON(model.id_brand = brand.id_brand) WHERE id_devicetype = '{model}'");
            comboBoxModel.DisplayMember = "models";
            comboBoxModel.ValueMember = "id_model";
        }

        private void Serial()
        {

            string countSerial = $"SELECT TOP(1) serial+1 FROM orders ORDER BY id_orders DESC;";
            SqlCommand command = new SqlCommand(countSerial, database.getConnection());

            database.openConnection();
            SqlDataReader read = command.ExecuteReader();

            while (read.Read())
            {
                textBoxSerial.Text = read[0].ToString();
            }
            read.Close();

        }
        public void WordPrint()
        {
            Word.Document doc = null;
            try
            {
                Word.Application app = new Word.Application();
                string source = @"C:\\Users\dmitr\Актприема.docx";

                doc = app.Documents.Open(source);
                doc.Activate();
                app.Visible = true;
                Word.Bookmarks wBookmarks = doc.Bookmarks;
                Word.Range wRange;
                string[] data = new string[6] { comboBoxClient.Text, comboBoxType.Text, comboBoxModel.Text, textBoxSerial.Text, richTextBoxProblem.Text , dateTo.Text};
                foreach (Word.Bookmark mark in wBookmarks)
                {

                    wRange = mark.Range;
                    wRange.Text = data[i];
                    i++;
                }
                doc = null;
                i = 0;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                doc.Close();
                doc = null;
                MessageBox.Show("Ошибка", "Внимание",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Information);
            }
        }

        private void buttonNewOrder_Click(object sender, EventArgs e)
        {
            database.openConnection();
            var name = Convert.ToInt32(comboBoxClient.SelectedValue);
            var model = Convert.ToInt32(comboBoxModel.SelectedValue);
            var date = dateTo.Value.ToShortDateString();
            var problem = richTextBoxProblem.Text;
            var serial = textBoxSerial.Text;
            if (richTextBoxProblem.Text != "")
            {
                var addOrders = $"insert into orders (id_client, id_model, date_to, problem, serial) VALUES ('{name}','{model}','{date}','{problem}','{serial}')";

                var command = new SqlCommand(addOrders, database.getConnection());
                command.ExecuteNonQuery();

                MessageBox.Show("Новая заявка успешно добавлена!");
                //WordPrint();
                if (printPreviewDialog1.ShowDialog() == DialogResult.OK)
                {
                    printDocument1.Print();
                }
            }
            else
            {
                MessageBox.Show("Заполните все поля!");
            }

            Serial();
            database.closeConnection();
        }
        private void ClearFields() 
        { 
            richTextBoxProblem.Text = "";
        }

        private void iconPictureBoxClear_Click(object sender, EventArgs e)
        {
            ClearFields();  
        }

        private void comboBoxType_SelectionChangeCommitted(object sender, EventArgs e)
        {
            LoadCategory2();
            comboBoxModel.Text = "";
            LoadCategory2();
        }

        private void printPreviewDialog1_Load(object sender, EventArgs e)
        {

        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {

            StringFormat format1 = new StringFormat();
            format1.Trimming = StringTrimming.EllipsisWord;

            e.Graphics.DrawString("АКТ ПРИЕМА ИЗДЕЛИЯ", new Font("Segoe UI", 24, FontStyle.Bold), Brushes.Black, new Point(210, 50));
            e.Graphics.DrawString("────────────────────────────────────────", new Font("Segoe UI", 16, FontStyle.Regular), Brushes.Black, new Point(50, 100));
            e.Graphics.DrawString("Информация о клиенте: " + comboBoxClient.Text, new Font("Segoe UI", 14, FontStyle.Regular), Brushes.Black, new Point(50, 150));
            e.Graphics.DrawString("Контакты: 89002554582 ", new Font("Segoe UI", 14, FontStyle.Regular), Brushes.Black, new Point(50, 200));
            e.Graphics.DrawString("Исполнитель: ООО 'ReactPC'", new Font("Segoe UI", 14, FontStyle.Regular), Brushes.Black, new Point(50, 250));
            e.Graphics.DrawString("Устройство: " + comboBoxType.Text + " " + comboBoxModel.Text, new Font("Segoe UI", 14, FontStyle.Regular), Brushes.Black, new Point(50, 300));
            e.Graphics.DrawString("Серийный номер:  " + textBoxSerial.Text, new Font("Segoe UI", 14, FontStyle.Regular), Brushes.Black, new Point(50, 350));
            e.Graphics.DrawString("Неисправность (со слов заказчика): " + richTextBoxProblem.Text + "\r\n", new Font("Segoe UI", 14, FontStyle.Regular), Brushes.Black, new Point(50, 400), format1);
            e.Graphics.DrawString("Приемщик: " + lblUsername.Text, new Font("Segoe UI", 14, FontStyle.Regular), Brushes.Black, new Point(50, 450));
            e.Graphics.DrawString("Дата приема заказа:  " + dateTo.Text, new Font("Segoe UI", 14, FontStyle.Regular), Brushes.Black, new Point(50, 500));
            e.Graphics.DrawString("────────────────────────────────────────", new Font("Segoe UI", 16, FontStyle.Regular), Brushes.Black, new Point(50, 550));

            e.Graphics.DrawString("Подпись заказчика:__________________ Расшифровка подписи____________________/", new Font("Segoe UI", 14, FontStyle.Regular), Brushes.Black, new Point(50, 960));
            e.Graphics.DrawString("Подпись исполнителя:__________________ Расшифровка подписи__________________/", new Font("Segoe UI", 14, FontStyle.Regular), Brushes.Black, new Point(50, 1000));
            e.Graphics.DrawString("Компьютерный сервис ReactPC", new Font("Segoe UI", 18, FontStyle.Bold), Brushes.Black, new Point(220, 1050));
            e.Graphics.DrawString("Адрес: Краснодарский край. ст. Васюринская, ул. Западная 98", new Font("Segoe UI", 12, FontStyle.Regular), Brushes.Black, new Point(190, 1100));
            e.Graphics.DrawImage(pictureBox1.Image, 550, 710);
        }

        private void Search()
        { // поиск
            

            string searchString = $"select CONCAT(name_client, ' ' , surname_client) as client FROM client  where concat (name_client, surname_client) like '%" + textBoxPoisk.Text + "%'";
            SqlCommand command = new SqlCommand(searchString, database.getConnection());

            database.openConnection();
            SqlDataReader read = command.ExecuteReader();

            while (read.Read())
            {
                comboBoxClient.Text = read["client"].ToString();
            }
            read.Close();
        }

        private void textBoxPoisk_TextChanged(object sender, EventArgs e)
        {
            Search();
        }
    }
}
