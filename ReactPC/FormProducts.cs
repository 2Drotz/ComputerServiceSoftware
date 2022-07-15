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
using System.Reflection;


namespace ReactPC
{

    public partial class FormProducts : Form
    {

        DBConnect database = new DBConnect();
        int selectedRow;//  для DGV
        

        public FormProducts()
        {
            InitializeComponent();
        }

        private void FormProducts_Load(object sender, EventArgs e)
        {
            CreateColumns();
            RefreshDataGrid(dataGridView1);
            RefreshDataGrid2(dataGridView2);
            RefreshDataGrid3(dataGridView3);
            LoadCategory();
            StyleDatagridview();
            StyleDatagridview2();
            StyleDatagridview3();
        }
        public void LoadCategory()
        {
            //comboBoxType.Items.Clear(); что бы в модели подгружалось после добавления
            comboBoxType.DataSource = database.getTable("SELECT * FROM devicetype");
            comboBoxType.DisplayMember = "devicetype";
            comboBoxType.ValueMember = "id_devicetype";

            //comboBoxBrand.Items.Clear();
            comboBoxBrand.DataSource = database.getTable("SELECT * FROM brand");
            comboBoxBrand.DisplayMember = "brand";
            comboBoxBrand.ValueMember = "id_brand";

        }


        private void CreateColumns()
        { // колонки для таблицы
            dataGridView1.Columns.Add("id", "Id");
            dataGridView1.Columns.Add("devicetype ", "Тип устройства");
            dataGridView1.Columns.Add("brand", "Бренд");
            dataGridView1.Columns.Add("model", "Модель");
            dataGridView1.Columns.Add("IsNew", String.Empty);
            dataGridView1.Columns[4].Visible = false;


            dataGridView2.Columns.Add("id", "Id");
            dataGridView2.Columns.Add("devicetype ", "Тип устройства");
            dataGridView2.Columns.Add("IsNew", String.Empty);
            dataGridView2.Columns[2].Visible = false;


            dataGridView3.Columns.Add("id", "Id");
            dataGridView3.Columns.Add("brand ", "Бренд");
            dataGridView3.Columns.Add("IsNew", String.Empty);
            dataGridView3.Columns[2].Visible = false;
        }
        void StyleDatagridview()
        {
            dataGridView1.BorderStyle = BorderStyle.None;
            dataGridView1.AlternatingRowsDefaultCellStyle.BackColor = Color.LightBlue;
            dataGridView1.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dataGridView1.DefaultCellStyle.SelectionBackColor = Color.FromArgb(87, 219, 255);
            dataGridView1.DefaultCellStyle.SelectionForeColor = Color.Black;
            dataGridView1.BackgroundColor = Color.Snow;
            //dataGridView1.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;//optional
            dataGridView1.EnableHeadersVisualStyles = false;
            dataGridView1.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            //dataGridView1.ColumnHeadersDefaultCellStyle.Font = new Font("MS Reference Sans Serif", 10);
            dataGridView1.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(13, 60, 247);
            dataGridView1.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
        }
        void StyleDatagridview2()
        {
            dataGridView2.BorderStyle = BorderStyle.None;
            dataGridView2.AlternatingRowsDefaultCellStyle.BackColor = Color.LightBlue;
            dataGridView2.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dataGridView2.DefaultCellStyle.SelectionBackColor = Color.FromArgb(87, 219, 255);
            dataGridView2.DefaultCellStyle.SelectionForeColor = Color.Black;
            dataGridView2.BackgroundColor = Color.Snow;
            //dataGridView2.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;//optional
            dataGridView2.EnableHeadersVisualStyles = false;
            dataGridView2.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            //dataGridView2.ColumnHeadersDefaultCellStyle.Font = new Font("MS Reference Sans Serif", 10);
            dataGridView2.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(13, 60, 247);
            dataGridView2.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
        }
        void StyleDatagridview3()
        {
            dataGridView3.BorderStyle = BorderStyle.None;
            dataGridView3.AlternatingRowsDefaultCellStyle.BackColor = Color.LightBlue;
            dataGridView3.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dataGridView3.DefaultCellStyle.SelectionBackColor = Color.FromArgb(87, 219, 255);
            dataGridView3.DefaultCellStyle.SelectionForeColor = Color.Black;
            dataGridView3.BackgroundColor = Color.Snow;
            //dataGridView3.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;//optional
            dataGridView3.EnableHeadersVisualStyles = false;
            dataGridView3.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            //dataGridView3.ColumnHeadersDefaultCellStyle.Font = new Font("MS Reference Sans Serif", 10);
            dataGridView3.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(13, 60, 247);
            dataGridView3.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
        }
        private void ReadSingleRows(DataGridView dgw, IDataRecord record) // предоставляет доступ к значениям столбцов к каждой строки дата ридер
        {
            dgw.Rows.Add(record.GetInt32(0), record.GetString(1), record.GetString(2), record.GetString(3), RowState.ModifiedNew);
        }

        //отображение ТАБЛИЦЫ МОДЕЛИ

        // представление model_show
        //SELECT * FROM model_show;
        //$"SELECT id_model, devicetype, brand, name_model, brand FROM model AS m INNER JOIN devicetype AS dv ON (m.id_devicetype = dv.id_devicetype) INNER JOIN brand AS br ON(m.id_brand = br.id_brand)"
        private void RefreshDataGrid(DataGridView dgv)
        {
            dgv.Rows.Clear();// очистим строки
            string queryModel = $"SELECT * FROM model_show";

            SqlCommand command = new SqlCommand(queryModel, database.getConnection());// переносим запрос и строку подключения к базе данных
            database.openConnection();
            SqlDataReader reader = command.ExecuteReader();

            while (reader.Read())
            {
                ReadSingleRows(dgv, reader);
            }
            reader.Close();
            database.closeConnection();
        }
        // ОТОБРАЖЕНИЕ ТАБЛИЦЫ ПРОИЗВОДИТЕЛИ
        private void ReadSingleRows2(DataGridView dgw, IDataRecord record) // предоставляет доступ к значениям столбцов к каждой строки дата ридер
        {
            dgw.Rows.Add(record.GetInt32(0), record.GetString(1), RowState.ModifiedNew);
        }
        private void RefreshDataGrid2(DataGridView dgv)
        {
            dgv.Rows.Clear();// очистим строки
            string queryType = $"SELECT * FROM devicetype";

            SqlCommand command = new SqlCommand(queryType, database.getConnection());// переносим запрос и строку подключения к базе данных
            database.openConnection();
            SqlDataReader reader = command.ExecuteReader();

            while (reader.Read())
            {
                ReadSingleRows2(dgv, reader);
            }
            reader.Close();
            database.closeConnection();
        }

        // ОТОБРАЖЕНИЕ ТАБЛИЦЫ БРЕНДЫ
        private void ReadSingleRows3(DataGridView dgw, IDataRecord record) // предоставляет доступ к значениям столбцов к каждой строки дата ридер
        {
            dgw.Rows.Add(record.GetInt32(0), record.GetString(1),  RowState.ModifiedNew);
        }
        private void RefreshDataGrid3(DataGridView dgv)
        {
            dgv.Rows.Clear();// очистим строки
            string queryBrand = $"SELECT * FROM brand";

            SqlCommand command = new SqlCommand(queryBrand, database.getConnection());// переносим запрос и строку подключения к базе данных
            database.openConnection();
            SqlDataReader reader = command.ExecuteReader();

            while (reader.Read())
            {
                ReadSingleRows3(dgv, reader);
            }
            reader.Close();
            database.closeConnection();
        }
        // метод очистки полей после добавления 
        private void ClearFields()
        {

            comboBoxType.Text = "";
            comboBoxBrand.Text = "";
            textBoxModel.Text = "";
            textBoxType.Text = "";
            textBoxBrand.Text = "";

        }
        private void iconPictureBoxRefresh_Click(object sender, EventArgs e)
        {
            RefreshDataGrid(dataGridView1);// метод обновления
            ClearFields();
        }
        // ДОБАВЛЕНЕИ НОВОЙ ЗАПИСИ
        private void iconPictureBoxNew_Click(object sender, EventArgs e)
        {
            database.openConnection();
            var model = textBoxModel.Text;
            int type = Convert.ToInt32(comboBoxType.SelectedValue);
            int brand = Convert.ToInt32(comboBoxBrand.SelectedValue);
            if (textBoxModel.Text != "")
            {
                var addModel = $"insert into model  (id_devicetype, id_brand, name_model) VALUES ('{type}','{brand}','{model}')";

                var command = new SqlCommand(addModel, database.getConnection());
                command.ExecuteNonQuery();

                MessageBox.Show("Модель добавлена!");
            }
            else
            {
                MessageBox.Show("Ошибка при создании записи!");
            }
            database.closeConnection();
        }

        // ДОБАВЛЕНИЕ ТИПА УСТРОЙСТВА
        private void iconPictureBoxNewType_Click(object sender, EventArgs e)
        {
            database.openConnection();
            var type = textBoxType.Text;
            if (textBoxType.Text != "")
            {
                var addType = $"insert into devicetype (devicetype) VALUES ('{type}') ";

                var command = new SqlCommand(addType, database.getConnection());
                command.ExecuteNonQuery();

                MessageBox.Show("Новое устройство добавлено добавлена!", "Предупреждение");
            }
            else
            {
                MessageBox.Show("Ошибка при создании записи!");
            }
            database.closeConnection();
        }

        private void iconPictureBoxUpload_Click(object sender, EventArgs e)
        {
            RefreshDataGrid2(dataGridView2);
            ClearFields();
            LoadCategory();
        }

        // ДОБАВЛЕНИЕ БРЕНДА
        private void iconPictureBoxNewBrand_Click(object sender, EventArgs e)
        {
            database.openConnection();
            var brand = textBoxBrand.Text;
            if (textBoxBrand.Text != "")
            {
                var addBrand = $"insert into brand (brand) VALUES ('{brand}') ";

                var command = new SqlCommand(addBrand, database.getConnection());
                command.ExecuteNonQuery();

                MessageBox.Show("Новый бренд успешно добавлен!", "Оповещение");
            }
            else
            {
                MessageBox.Show("Ошибка при создании записи!");
            }
            database.closeConnection();
        }

        private void iconPictureBox2Upload_Click(object sender, EventArgs e)
        {
            RefreshDataGrid3(dataGridView3);
            ClearFields();
            LoadCategory();
        }


        // поиск моделей
        private void Search(DataGridView dgv)
        { // поиск
            dgv.Rows.Clear();

            string searchString = $"select * FROM model_show WHERE concat (id_model, devicetype, brand, name_model) like '%" + textBoxSearch.Text + "%'";
            SqlCommand command = new SqlCommand(searchString, database.getConnection());

            database.openConnection();
            SqlDataReader read = command.ExecuteReader();

            while (read.Read())
            {
                ReadSingleRows(dgv, read);
            }
            read.Close();
        }

        private void textBoxSearch_TextChanged(object sender, EventArgs e)
        {
            Search(dataGridView1);
        }


    }
}
