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

    public partial class FormNewOrders : Form
    {
        private readonly checkAdmin _user;
        DBConnect database = new DBConnect();
        int selectedRow;
        public FormNewOrders(checkAdmin user)
        {
            InitializeComponent();
            _user = user;

        }

        private void FormNewOrders_Load(object sender, EventArgs e)
        {
            CreateColumns();
            RefreshDataGrid(dataGridView1);
            StyleDatagridview();
            label_role.Text = $"{_user.Login}";
            AddOrdersCheck();
        }
        private void CreateColumns()
        { // колонки для таблицы
            dataGridView1.Columns.Add("id", "№");
            dataGridView1.Columns.Add("name_client", "Клиент");
            dataGridView1.Columns.Add("model", "Устройство");
            dataGridView1.Columns.Add("name_status", "Статус");
            dataGridView1.Columns.Add("problem", "Проблема");
            dataGridView1.Columns.Add("date_to", "Дата приема");
            dataGridView1.Columns.Add("serial", "Номер");
            dataGridView1.Columns.Add("IsNew", String.Empty);
            dataGridView1.Columns[7].Visible = false;
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
        private void ReadSingleRows(DataGridView dgv, IDataRecord record) // предоставляет доступ к значениям столбцов к каждой строки дата ридер
        {
            dgv.Rows.Add(record.GetInt32(0), record.GetString(1), record.GetString(2), record.GetString(3), record.GetString(4), record.GetDateTime(5), record.GetInt32(6), RowState.ModifiedNew);
        }


        //отображение
        private void RefreshDataGrid(DataGridView dgv)
        {
            dgv.Rows.Clear();// очистим строки
            string queryNewOrders = $"SELECT * FROM new_order WHERE name_status = 'Ожидает мастера'";

            SqlCommand command = new SqlCommand(queryNewOrders, database.getConnection());// переносим запрос и строку подключения к базе данных
            database.openConnection();
            SqlDataReader reader = command.ExecuteReader();

            while (reader.Read())
            {
                ReadSingleRows(dgv, reader);
            }
            reader.Close();

            try
            {
                for (int index = 0; index < dataGridView1.Rows.Count; index++)
                {
                    if (dataGridView1.Rows[index].Cells[3].Value.ToString() == "Ожидает мастера")
                    {
                        dataGridView1.Rows[index].Cells[3].Style.BackColor = Color.FromArgb(165, 255, 214);
                    }
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                MessageBox.Show("Ошибка", "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            database.closeConnection();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            selectedRow = e.RowIndex;

            if (e.RowIndex >= 0)// что бы не выйти за границы индексов
            {
                DataGridViewRow row = dataGridView1.Rows[selectedRow];

                textBoxid.Text = row.Cells[0].Value.ToString();

            }
        }

        private void AddOrdersCheck() {
            var loginUser = label_role.Text;// переменные дял запроса и сранения с тексбокс
            string _role = "";
            SqlDataAdapter adapter = new SqlDataAdapter(); // объекты класса


            string queryLogin = $"select id_user, login_user, password_user, admin_user, role  from users INNER JOIN role ON(users.id_role = role.id_role)" +
                $" where login_user = '{loginUser}'"; // sql запрос
            SqlCommand command = new SqlCommand(queryLogin, database.getConnection());
            database.openConnection();
            SqlDataReader reader = command.ExecuteReader();

                reader.Read();
                _role = reader["role"].ToString();
                //MessageBox.Show(reader["role_user"].ToString());
                if (_role == "Приемщик")
                {
                    btnDiagnostic.Enabled = false;
                    btnDiagnostic.Visible = false;
                }
                reader.Close();
            }

        private void Update()
        {

            database.openConnection();

            for (int index = 0; index < dataGridView1.Rows.Count; index++)
            {
                var rowState = (RowState)dataGridView1.Rows[index].Cells[7].Value;

                if (rowState == RowState.Modified)
                {
                    var id = dataGridView1.Rows[index].Cells[0].Value.ToString();

                    var changeQuery = $"update orders set id_status = {2} where id_orders = '{id}'";
                    var command = new SqlCommand(changeQuery, database.getConnection());
                    command.ExecuteNonQuery();


                }

            }
            database.closeConnection();
        }
        private void Change()
        {
            var selectedRowIndex = dataGridView1.CurrentCell.RowIndex;// текущий столбец и текущий индекс строки в которой находимя

            var id = textBoxid.Text;


            if (dataGridView1.Rows[selectedRowIndex].Cells[0].Value.ToString() != string.Empty)
            {
                if (textBoxid.Text != "")
                {

                    dataGridView1.Rows[selectedRowIndex].SetValues(id);
                    dataGridView1.Rows[selectedRowIndex].Cells[7].Value = RowState.Modified;
                }
                else
                {
                    MessageBox.Show("Цена должна иметь числовой формат!");
                }
            }
        }
        private void btnDiagnostic_Click(object sender, EventArgs e)
        {
            Change();
            Update();
            database.openConnection();
            var id = textBoxid.Text;
            if (textBoxid.Text != "")
            {
                var addQuery = $"insert into repair(id_orders) VALUES ('{id}')";

                var command = new SqlCommand(addQuery, database.getConnection());
                command.ExecuteNonQuery();

                MessageBox.Show("Отправлено на диагностику!");
            }
            else
            {
                MessageBox.Show("Ошибка при создании записи!");
            }
            database.closeConnection();
            RefreshDataGrid(dataGridView1);
        }
    }
}
