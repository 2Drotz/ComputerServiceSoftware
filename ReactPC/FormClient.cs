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

    public partial class FormClient : Form
    {
        DBConnect database = new DBConnect();
        int selectedRow;//  для DGV
        private readonly checkAdmin _user;
        public FormClient(checkAdmin user)
        {
            _user = user;
            InitializeComponent();

        }
        private void FormClient_Load(object sender, EventArgs e)
        {
            CreateColumns();
            RefreshDataGrid(dataGridView1);
            isAdmin();
            LoadCategory();
            StyleDatagridview();
        }
        private void isAdmin() //
        {
            btnDelete.Enabled = _user.IsAdmin;
        }
        public void LoadCategory()
        {
            comboBoxCity.Items.Clear();
            comboBoxCity.DataSource = database.getTable("SELECT * FROM city");
            comboBoxCity.DisplayMember = "city";
            comboBoxCity.ValueMember = "id_city";
        }
        private void CreateColumns()
        { // колонки для таблицы
            dataGridView1.Columns.Add("id", "ID");
            dataGridView1.Columns.Add("name_client ", "Имя");
            dataGridView1.Columns.Add("surname_client", "Фамилия");
            dataGridView1.Columns.Add("id_city", "Город");
            dataGridView1.Columns.Add("addres_client", "Адрес");
            dataGridView1.Columns.Add("phone_client", "Телефон");
            dataGridView1.Columns.Add("IsNew", String.Empty);
            dataGridView1.Columns[6].Visible = false;
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
            dataGridView1.Columns[0].Width = 30;
        }
        private void ReadSingleRows(DataGridView dgw, IDataRecord record) // предоставляет доступ к значениям столбцов к каждой строки дата ридер
        {
            dgw.Rows.Add(record.GetInt32(0), record.GetString(1), record.GetString(2), record.GetString(3), record.GetString(4), record.GetString(5), RowState.ModifiedNew);
        }
        private void RefreshDataGrid(DataGridView dgv)
        {
            dgv.Rows.Clear();// очистим строки
            string queryRepair = $"SELECT id_client, name_client, surname_client, city, addres_client, phone_client FROM client INNER JOIN city ON(client.id_city = city.id_city)";

            SqlCommand command = new SqlCommand(queryRepair, database.getConnection());// переносим запрос и строку подключения к базе данных
            database.openConnection();
            SqlDataReader reader = command.ExecuteReader();

            while (reader.Read())
            {
                ReadSingleRows(dgv, reader);
            }
            reader.Close();
            database.closeConnection();
        }
        private void ClearFields()
        {

            textBoxId.Text = "";
            textBoxName.Text = "";
            textBoxSurname.Text = "";
            textBoxAddres.Text = "";
            textBoxPhone.Text = "";
            comboBoxCity.Text = "";
        }
        private void iconPictureBoxRefresh_Click_1(object sender, EventArgs e)
        {
            RefreshDataGrid(dataGridView1);// метод обновления
            ClearFields();
        }
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            selectedRow = e.RowIndex;

            if (e.RowIndex >= 0)// что бы не выйти за границы индексов
            {
                DataGridViewRow row = dataGridView1.Rows[selectedRow];

                textBoxId.Text = row.Cells[0].Value.ToString();
                textBoxName.Text = row.Cells[1].Value.ToString();
                textBoxSurname.Text = row.Cells[2].Value.ToString();
                comboBoxCity.Text = row.Cells[3].Value.ToString();
                textBoxAddres.Text = row.Cells[4].Value.ToString();
                textBoxPhone.Text = row.Cells[5].Value.ToString();
            }
        }

        private void Search(DataGridView dgv)
        { // поиск
            dgv.Rows.Clear();

            string searchString = $"select id_client, name_client, surname_client, city, addres_client, phone_client FROM client INNER JOIN city ON(client.id_city = city.id_city) where concat (id_client, name_client, surname_client, city, addres_client, phone_client) like '%" + textBoxSearch.Text + "%'";
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

        //delete
        private void Delete()
        { // удаление
            int index = dataGridView1.CurrentCell.RowIndex;
            dataGridView1.Rows[index].Visible = false;

            if (dataGridView1.Rows[index].Cells[0].Value.ToString() == string.Empty)
            {

                dataGridView1.Rows[index].Cells[6].Value = RowState.Deleted;
                return;
            }
            dataGridView1.Rows[index].Cells[6].Value = RowState.Deleted;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Вы точно хотите удалить запись", "Предупреждение", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                Delete();
                ClearFields();
            }
            else
            {
            }
        }


        private void Update()
        {

            database.openConnection();

            for (int index = 0; index < dataGridView1.Rows.Count; index++)
            {
                var rowState = (RowState)dataGridView1.Rows[index].Cells[6].Value;
                if (rowState == RowState.Existed)
                    continue;

                if (rowState == RowState.Deleted)
                {
                    var id = Convert.ToInt32(dataGridView1.Rows[index].Cells[0].Value);
                    var deleteQuery = $"delete from client where id_client = {id}";

                    var command = new SqlCommand(deleteQuery, database.getConnection());
                    command.ExecuteNonQuery();
                }

                if (rowState == RowState.Modified)
                {
                    var id = dataGridView1.Rows[index].Cells[0].Value.ToString();
                    var name = dataGridView1.Rows[index].Cells[1].Value.ToString();
                    var surname = dataGridView1.Rows[index].Cells[2].Value.ToString();
                    var city = dataGridView1.Rows[index].Cells[3].Value.ToString();
                    var addres = dataGridView1.Rows[index].Cells[4].Value.ToString();
                    var phone = dataGridView1.Rows[index].Cells[5].Value.ToString();

                    var changeQuery = $"update client set name_client = '{name}', surname_client = '{surname}', id_city = '{city}', addres_client = '{addres}', phone_client = '{phone}' where id_client = '{id}'";
                    var command = new SqlCommand(changeQuery, database.getConnection());
                    command.ExecuteNonQuery();
                }

            }
            database.closeConnection();
        }


        private void btnSave_Click(object sender, EventArgs e)
        {
            Update();
        }

        private void Change()
        {
            var selectedRowIndex = dataGridView1.CurrentCell.RowIndex;// текущий столбец и текущий индекс строки в которой находимя

            var id = textBoxId.Text;
            var name = textBoxName.Text;
            var surname = textBoxSurname.Text;
            var phone = textBoxPhone.Text;
            var addres = textBoxAddres.Text;
            var city = comboBoxCity.SelectedValue;



            if (dataGridView1.Rows[selectedRowIndex].Cells[0].Value.ToString() != string.Empty)
            {
                if (textBoxAddres.Text != "")
                {

                    dataGridView1.Rows[selectedRowIndex].SetValues(id, name, surname, city, addres, phone);
                    dataGridView1.Rows[selectedRowIndex].Cells[6].Value = RowState.Modified;
                }
                else
                {
                    MessageBox.Show("Цена должна иметь числовой формат!");
                }
            }
        }

        private void btnChange_Click(object sender, EventArgs e)
        {
            Change();
            Update();
            RefreshDataGrid(dataGridView1);
            ClearFields();
        }

        private void buttonNew_Click(object sender, EventArgs e)
        {
            NewClient nc = new NewClient();
            nc.Show();
        }
    }
}
