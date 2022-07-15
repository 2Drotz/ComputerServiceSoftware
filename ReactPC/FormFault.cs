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

    public partial class FormFault : Form
    {
        DBConnect database = new DBConnect();
        int selectedRow;//  для DGV
        public FormFault()
        {
            InitializeComponent();
        }
        private void FormFault_Load(object sender, EventArgs e)
        {
            CreateColumns();
            LoadCategory();
            LoadCategory2();
            RefreshDataGrid(dataGridView1);
            StyleDatagridview();
            StyleDatagridview2();
        }
        public void LoadCategory()
        {
            comboBoxType.Items.Clear();
            comboBoxType.DataSource = database.getTable("SELECT * FROM devicetype");
            comboBoxType.DisplayMember = "devicetype";
            comboBoxType.ValueMember = "id_devicetype";

        }
        public void LoadCategory2()
        {

            //comboBoxSol.Items.Clear();
            comboBoxSol.DataSource = database.getTable("SELECT * FROM fault");
            comboBoxSol.DisplayMember = "fault";
            comboBoxSol.ValueMember = "id_fault";
        }


        private void CreateColumns()
        { // колонки для таблицы
            dataGridView1.Columns.Add("id", "№");
            dataGridView1.Columns.Add("devicetype", "Тип");
            dataGridView1.Columns.Add("fault", "Неисправность");
            dataGridView1.Columns.Add("IsNew", String.Empty);
            dataGridView1.Columns[3].Visible = false;


            dataGridView2.Columns.Add("solution", "Метод решения");
            dataGridView2.Columns.Add("IsNew", String.Empty);
            dataGridView2.Columns[1].Visible = false;
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
            dataGridView1.Columns[0].Width = 35;
            dataGridView1.Columns[1].Width = 150;

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
            dataGridView2.Columns[0].Width = 35;
            dataGridView2.Columns[1].Width = 150;
        }
        private void ReadSingleRows(DataGridView dgv, IDataRecord record) // предоставляет доступ к значениям столбцов к каждой строки дата ридер
        {
            dgv.Rows.Add(record.GetInt32(0), record.GetString(1), record.GetString(2), RowState.ModifiedNew);
        }

        private void ReadSingleRows2(DataGridView dgv, IDataRecord record) // предоставляет доступ к значениям столбцов к каждой строки дата ридер
        {
            dgv.Rows.Add(record.GetString(0), RowState.ModifiedNew);
        }


        //отображение
        private void RefreshDataGrid(DataGridView dgv)
        {
            dgv.Rows.Clear();// очистим строки
            string queryFault = $"SELECT id_fault, devicetype, fault FROM fault AS f INNER JOIN devicetype AS dv ON (f.id_devicetype = dv.id_devicetype) WHERE devicetype = '{comboBoxType.Text}'";

            SqlCommand command = new SqlCommand(queryFault, database.getConnection());// переносим запрос и строку подключения к базе данных
            database.openConnection();
            SqlDataReader reader = command.ExecuteReader();

            while (reader.Read())
            {
                ReadSingleRows(dgv, reader);
            }
            reader.Close();
            database.closeConnection();
        }
        //$"SELECT solution FROM method WHERE fault = '{comboBoxSol.Text}'"
        // используется представление method
        //$"SELECT id_solution, solution FROM solution AS s INNER JOIN fault AS f ON (s.id_fault = f.id_fault) INNER JOIN devicetype AS dv ON(f.id_devicetype = dv.id_devicetype) WHERE fault = '{comboBoxSol.Text}'"
        private void RefreshDataGrid2(DataGridView dgv)
        {
            dgv.Rows.Clear();// очистим строки
            string querySol = $"SELECT solution FROM method WHERE fault = '{comboBoxSol.Text}'";

            SqlCommand command = new SqlCommand(querySol, database.getConnection());// переносим запрос и строку подключения к базе данных
            database.openConnection();
            SqlDataReader reader = command.ExecuteReader();

            while (reader.Read())
            {
                ReadSingleRows2(dgv, reader);
            }
            reader.Close();
            database.closeConnection();
        }


        private void btnShow_Click(object sender, EventArgs e)
        {
            RefreshDataGrid(dataGridView1);
            dataGridView2.Visible = false;
            dataGridView1.Visible = true;
            
        }

        private void btnSol_Click(object sender, EventArgs e)
        {
            RefreshDataGrid2(dataGridView2);
            dataGridView1.Visible = false;
            dataGridView2.Visible = true;
        }
        // занесение значения в текст бокс
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            selectedRow = e.RowIndex;

            if (e.RowIndex >= 0)// что бы не выйти за границы индексов
            {
                DataGridViewRow row = dataGridView1.Rows[selectedRow];

                comboBoxSol.Text = row.Cells[2].Value.ToString();
            }
        }



        private void Update()
        {
            database.openConnection();

            for (int index = 0; index < dataGridView1.Rows.Count; index++)
            {
                var rowState = (RowState)dataGridView1.Rows[index].Cells[3].Value;
                if (rowState == RowState.Existed)
                    continue;

                if (rowState == RowState.Deleted)
                {
                    var id = Convert.ToInt32(dataGridView1.Rows[index].Cells[0].Value);
                    var deleteQuery = $"delete from repair where id_repair = {id}";

                    var command = new SqlCommand(deleteQuery, database.getConnection());
                    command.ExecuteNonQuery();
                }

                if (rowState == RowState.Modified)
                {
                    var id = dataGridView1.Rows[index].Cells[0].Value.ToString();
                    var devicetype = dataGridView1.Rows[index].Cells[1].Value.ToString();
                    var fault = dataGridView1.Rows[index].Cells[2].Value.ToString();


                    var changeQuery = $"update fault set devicetype = '{devicetype}', fault = '{fault}'";
                    var command = new SqlCommand(changeQuery, database.getConnection());
                    command.ExecuteNonQuery();


                }
                if (rowState == RowState.Modified)
                {
                    var id = dataGridView2.Rows[index].Cells[0].Value.ToString();
                    var solution = dataGridView2.Rows[index].Cells[1].Value.ToString();

                    var changeQuerySol = $"update solution set fault = '{id}', solution = '{solution}'";
                    var command = new SqlCommand(changeQuerySol, database.getConnection());
                    command.ExecuteNonQuery();


                }
            }
            database.closeConnection();
        }

        private void iconPictureBoxSave_Click(object sender, EventArgs e)
        {
            Update();
            //RefreshDataGrid2(dataGridView2);
            //RefreshDataGrid(dataGridView1);
            //LoadCategory2();
        }
        private void ClearField()
        {
            textBoxFault.Text = "";
            textBoxSol.Text = "";

        }
        private void iconPictureBoxPlusFault_Click(object sender, EventArgs e)
        {
            database.openConnection();
            var devicetype = Convert.ToInt32(comboBoxType.SelectedValue);
            var fault = textBoxFault.Text;
            if (textBoxFault.Text != "")
            {
                var addFault = $"insert into fault (id_devicetype, fault) VALUES ('{devicetype}','{fault}')";

                var command = new SqlCommand(addFault, database.getConnection());
                command.ExecuteNonQuery();

                MessageBox.Show("Запись создана!");
            }
            else
            {
                MessageBox.Show("Ошибка при создании записи!");
            }
            LoadCategory2();
            RefreshDataGrid(dataGridView1);
            database.closeConnection();
            ClearField();
        }

        private void iconPictureBoxPlusSol_Click(object sender, EventArgs e)
        {
            database.openConnection();
            int idfault = Convert.ToInt32(comboBoxSol.SelectedValue);
            var solution = textBoxSol.Text;
            if (textBoxSol.Text != "")
            {
                var addFault = $"insert into solution (id_fault, solution) VALUES ('{idfault}','{solution}')";

                var command = new SqlCommand(addFault, database.getConnection());
                command.ExecuteNonQuery();

                MessageBox.Show("Запись создана!");
            }
            else
            {
                MessageBox.Show("Ошибка при создании записи!");
            }
            RefreshDataGrid2(dataGridView2);
            database.closeConnection();
            ClearField();
        }
    }
}
