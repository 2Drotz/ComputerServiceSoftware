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
    public partial class FormJobs : Form
    {
        DBConnect database = new DBConnect();
        public FormJobs()
        {
            InitializeComponent();
        }

        private void FormJobs_Load(object sender, EventArgs e)
        {
            CreateColumns();
            StyleDatagridview();
            RefreshDataGrid(dataGridView1);
        }
        private void CreateColumns()
        { // колонки для таблицы
            dataGridView1.Columns.Add("id", "№");
            dataGridView1.Columns.Add("devicetype", "Устройство");
            dataGridView1.Columns.Add("work", "Работы");
            dataGridView1.Columns.Add("price", "Стоимость");
            dataGridView1.Columns.Add("IsNew", String.Empty);
            dataGridView1.Columns[4].Visible = false;
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
            dataGridView1.Columns[0].Width = 40;
        }
        private void ReadSingleRows(DataGridView dgv, IDataRecord record) // предоставляет доступ к значениям столбцов к каждой строки дата ридер
        {
            dgv.Rows.Add(record.GetInt32(0), record.GetString(1), record.GetString(2), record.GetDecimal(3), RowState.ModifiedNew);
        }


        //отображение
        private void RefreshDataGrid(DataGridView dgv)
        {
            dgv.Rows.Clear();// очистим строки
            string queryWork = $"SELECT id_work, devicetype, work, price FROM work " +
                $"INNER JOIN devicetype ON(work.id_devicetype = devicetype.id_devicetype) WHERE id_work >1 ";

            SqlCommand command = new SqlCommand(queryWork, database.getConnection());// переносим запрос и строку подключения к базе данных
            database.openConnection();
            SqlDataReader reader = command.ExecuteReader();

            while (reader.Read())
            {
                ReadSingleRows(dgv, reader);
            }
            reader.Close();
            database.closeConnection();
        }
        private void Update()
        {

            database.openConnection();

            for (int index = 0; index < dataGridView1.Rows.Count; index++)
            {
                var rowState = (RowState)dataGridView1.Rows[index].Cells[4].Value;
                if (rowState == RowState.Existed)
                    continue;

                if (rowState == RowState.Deleted)
                {
                    var id = Convert.ToInt32(dataGridView1.Rows[index].Cells[0].Value);
                    var deleteQuery = $"delete from work where id_work = {id}";

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
        private void Delete()
        { // удаление
            int index = dataGridView1.CurrentCell.RowIndex;
            dataGridView1.Rows[index].Visible = false;

            if (dataGridView1.Rows[index].Cells[0].Value.ToString() == string.Empty)
            {

                dataGridView1.Rows[index].Cells[4].Value = RowState.Deleted;
                return;
            }
            dataGridView1.Rows[index].Cells[4].Value = RowState.Deleted;
        }

        private void Search(DataGridView dgv)
        { // поиск
            dgv.Rows.Clear();

            string searchString = $"SELECT id_work, devicetype, work, price FROM work INNER JOIN devicetype ON(work.id_devicetype = devicetype.id_devicetype) where concat (id_work, devicetype, work, price) like '%" + textBoxSearch.Text + "%'";
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

        private void btnNew_Click(object sender, EventArgs e)
        {
            NewWork nw = new NewWork();
            nw.Show();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Вы точно хотите удалить запись", "Предупреждение", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                Delete();
                Update();
                RefreshDataGrid(dataGridView1);
            }
            else { 
            }

        }

        private void iconPictureBoxRefresh_Click(object sender, EventArgs e)
        {
            RefreshDataGrid(dataGridView1);
        }

        private void iconPictureBoxClear_Click(object sender, EventArgs e)
        {
            textBoxSearch.Text = "";
        }
    }
}
