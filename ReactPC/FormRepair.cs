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
    public partial class FormRepair : Form
    {
        DBConnect database = new DBConnect();
        private readonly checkAdmin _user;
        int selectedRow;
        public FormRepair(checkAdmin user)
        {
            _user = user;
            InitializeComponent();
        }
        private void isAdmin() //
        {
            btnChangeRepair.Enabled = _user.IsAdmin;
        }
        private void FormRepair_Load(object sender, EventArgs e)
        {
            isAdmin();
            CreateColumns();
            RefreshDataGrid(dataGridView1);
            StyleDatagridview();
            LoadCategory();
            
        }
        public void LoadCategory()
        {
            comboBoxStatus.Items.Clear();
            comboBoxStatus.DataSource = database.getTable("SELECT * FROM order_status WHERE id_status != 1");
            comboBoxStatus.DisplayMember = "name_status";
            comboBoxStatus.ValueMember = "id_status";

        }

        private void LoadWork() {

            //comboBoxWork.Items.Clear();  SELECT * FROM work
            comboBoxWork.DataSource = database.getTable($"SELECT * FROM work INNER JOIN devicetype ON(work.id_devicetype = devicetype.id_devicetype) WHERE devicetype LIKE '%{Devtype}%'");
            comboBoxWork.DisplayMember = "work";
            comboBoxWork.ValueMember = "id_work";
            
        }
        private void LoadType() {
            //comboBoxFault.Items.Clear();
            comboBoxFault.DataSource = database.getTable($"SELECT id_fault, fault FROM fault_repair WHERE devicetype LIKE '%{Devtype}%'");
            comboBoxFault.DisplayMember = "fault";
            comboBoxFault.ValueMember = "id_fault";
        }
        private string Devtype; // необходимо для выбора неисправности и 

        private void DevType()
        {
            string dev = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            string[] parts = dev.Split(' ');
            Devtype = parts[0];
            LoadType();
            LoadWork();
        }
        private void dataGridView1_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            

        }
        private void CreateColumns()
        { // колонки для таблицы
            dataGridView1.Columns.Add("id_repair", "№");
            dataGridView1.Columns.Add("id", "Номер");
            dataGridView1.Columns.Add("name_status", "Статус");
            dataGridView1.Columns.Add("model", "Устройство");
            dataGridView1.Columns.Add("problem", "Проблема");
            dataGridView1.Columns.Add("id_fault", "Неисправность");
            dataGridView1.Columns.Add("id_work", "Работа");
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
            dataGridView1.Columns[1].Width = 100;
        }

        private void ReadSingleRows(DataGridView dgw, IDataRecord record) // предоставляет доступ к значениям столбцов к каждой строки дата ридер
        {
            dgw.Rows.Add(record.GetInt32(0), record.GetInt32(1), record.GetString(2), record.GetString(3), record.GetString(4), record.GetString(5), record.GetString(6), RowState.ModifiedNew);
        }


        //отображение serial, name_status, model, problem,fault,work  // WHERE name_status != 'На диагностке'
        private void RefreshDataGrid(DataGridView dgv)
        {
            dgv.Rows.Clear();// очистим строки
            string queryRepair = $"SELECT * FROM show_repair "; // представление show_repair

            SqlCommand command = new SqlCommand(queryRepair, database.getConnection());// переносим запрос и строку подключения к базе данных
            database.openConnection();
            SqlDataReader reader = command.ExecuteReader();

            while (reader.Read())
            {
                ReadSingleRows(dgv, reader);
            }
            reader.Close();


            try 
            {
                for (int index = 0; index < dataGridView1.Rows.Count; index++) {
                    if (dataGridView1.Rows[index].Cells[2].Value.ToString() == "На диагностике")
                    {
                        dataGridView1.Rows[index].Cells[2].Style.BackColor = Color.LightYellow;
                    }
                    else if (dataGridView1.Rows[index].Cells[2].Value.ToString() == "Диагностика завершена, ремонт возможен")
                    {
                        dataGridView1.Rows[index].Cells[2].Style.BackColor = Color.Orange;
                    }
                    else if (dataGridView1.Rows[index].Cells[2].Value.ToString() == "Диагностика завершена, ремонт невозможен")
                    {
                        dataGridView1.Rows[index].Cells[2].Style.BackColor = Color.FromArgb(235, 83, 83);
                    }
                    else if (dataGridView1.Rows[index].Cells[2].Value.ToString() == "Ремонт успешно завершен") 
                    {
                        dataGridView1.Rows[index].Cells[2].Style.BackColor = Color.LightGreen;
                    }
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                MessageBox.Show("Ошибка", "Внимание",MessageBoxButtons.OK,MessageBoxIcon.Information);
            }
            database.closeConnection();
        }

        private void EnableItem() {
            comboBoxFault.Enabled = true;
            comboBoxWork.Enabled = true;
            comboBoxStatus.Enabled = true;
            btnSave.Enabled = true;
        }
        private void DisableItem()
        {
            comboBoxFault.Enabled = false;
            comboBoxWork.Enabled = false;
            comboBoxStatus.Enabled = false;
            btnSave.Enabled = false;
        }
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            selectedRow = e.RowIndex;
            DevType();
            if (e.RowIndex >= 0)// что бы не выйти за границы индексов
            {
                DataGridViewRow row = dataGridView1.Rows[selectedRow];

                textBoxIdTable.Text = row.Cells[0].Value.ToString();
                textBoxSerial.Text = row.Cells[1].Value.ToString();
                textBox2.Text = row.Cells[4].Value.ToString();
                textBox3.Text = row.Cells[3].Value.ToString();
                comboBoxStatus.Text = row.Cells[2].Value.ToString();
                comboBoxFault.Text = row.Cells[5].Value.ToString();
                comboBoxWork.Text = row.Cells[6].Value.ToString();
            }
            
            if (comboBoxStatus.Text == "Ремонт успешно завершен" || comboBoxStatus.Text == "Диагностика завершена, ремонт невозможен")
            {
                DisableItem();
            }
            else if (comboBoxStatus.Text == "Диагностика завершена, ремонт возможен")
            {
                EnableItem();
            }
            else  {
                EnableItem();
            }

            string status = dataGridView1.CurrentRow.Cells[5].Value.ToString();
            if (status == "не определено")
            {
                comboBoxFault.Text = "Выбрать";
            }
            string work = dataGridView1.CurrentRow.Cells[6].Value.ToString();
            if (work == "не определено")
            {
                comboBoxWork.Text = "Выбрать";
            }
        }

        private void Update()
        {

            database.openConnection();

            for (int index = 0; index < dataGridView1.Rows.Count; index++)
            {
                var rowState = (RowState)dataGridView1.Rows[index].Cells[7].Value;
                if (rowState == RowState.Existed)
                    continue;

                if (rowState == RowState.Deleted)
                {
                    var id = Convert.ToInt32(dataGridView1.Rows[index].Cells[0].Value);
                    var deleteQuery = $"delete from test_repair where id_repair = {id}";

                    var command = new SqlCommand(deleteQuery, database.getConnection());
                    command.ExecuteNonQuery();
                }

                if (rowState == RowState.Modified)
                {
                    var id = dataGridView1.Rows[index].Cells[0].Value.ToString();
                    var fault = dataGridView1.Rows[index].Cells[5].Value.ToString();

                    var changeQuery = $"update repair set id_fault = '{fault}'  where id_repair = '{id}'";
                    var command = new SqlCommand(changeQuery, database.getConnection());
                    command.ExecuteNonQuery();

                    var serial = dataGridView1.Rows[index].Cells[1].Value.ToString();
                    var status = dataGridView1.Rows[index].Cells[2].Value.ToString();

                    var changeQuery2 = $"update orders set id_status = '{status}' where serial = '{serial}'";
                    var command2 = new SqlCommand(changeQuery2, database.getConnection());
                    command2.ExecuteNonQuery();


                    var date_from = DateTime.Now;

                    var changeQuery3 = $"update orders set date_from = '{date_from}' where serial = '{serial}'";
                    var command3 = new SqlCommand(changeQuery3, database.getConnection());
                    command3.ExecuteNonQuery();
                }

            }
            database.closeConnection();
        }

        private void UpdateWorkOrders()
        {

            database.openConnection();

            for (int index = 0; index < dataGridView1.Rows.Count; index++)
            {
                var rowState = (RowState)dataGridView1.Rows[index].Cells[7].Value;
                if (rowState == RowState.Existed)
                    continue;

                if (rowState == RowState.Modified)
                {
                    var id = dataGridView1.Rows[index].Cells[0].Value.ToString();
                    var work = dataGridView1.Rows[index].Cells[6].Value.ToString();

                    var changeQuery = $"update repair set id_work = '{work}' where id_repair = '{id}'";
                    var command = new SqlCommand(changeQuery, database.getConnection());
                    command.ExecuteNonQuery();
                }

            }
            database.closeConnection();
        }

        private void Change()
        {
            var selectedRowIndex = dataGridView1.CurrentCell.RowIndex;// текущий столбец и текущий индекс строки в которой находимя

            var id = textBoxIdTable.Text;
            var serial = textBoxSerial.Text;
            var problem = textBox2.Text;
            var devicetype = textBox3.Text;
            var status = comboBoxStatus.SelectedValue;
            var fault = comboBoxFault.SelectedValue;
            var work = comboBoxWork.SelectedValue;


            if (dataGridView1.Rows[selectedRowIndex].Cells[0].Value.ToString() != string.Empty)
            {

                if (comboBoxStatus.Text == "Ремонт успешно завершен" || comboBoxStatus.Text == "Диагностика завершена, ремонт невозможен")
                {

                    if (MessageBox.Show("Вы подтверждаете завершение ремонта?" + " " + textBox3.Text, "Предупреждение", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                    {
                        dataGridView1.Rows[selectedRowIndex].SetValues(id, serial, status, devicetype, problem, fault, work);
                        dataGridView1.Rows[selectedRowIndex].Cells[7].Value = RowState.Modified;
                    }

                }
                else {
                    dataGridView1.Rows[selectedRowIndex].SetValues(id, serial, status, devicetype, problem, fault, work);
                    dataGridView1.Rows[selectedRowIndex].Cells[7].Value = RowState.Modified;
                }
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (comboBoxFault.Text == "Выбрать" && comboBoxWork.Text == "Выбрать")
            {
                MessageBox.Show("Данные не заполнены");
            }
            else if (comboBoxFault.Text != "Выбрать" && comboBoxWork.Text != "Выбрать")
            {
                Change();
                Update();
                UpdateWorkOrders();
                RefreshDataGrid(dataGridView1);
            }
            else if (comboBoxFault.Text != "Выбрать")
            {
                Change();
                Update();
                RefreshDataGrid(dataGridView1);
            }
            else if (comboBoxWork.Text != "Выбрать")
            {
                Change();
                UpdateWorkOrders();
                RefreshDataGrid(dataGridView1);
            }


        }

        private void btnChangeRepair_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Вы точно хотите внести \nизменения в закрытый заказ?", "Предупреждение", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes) 
            {
                EnableItem();
            }
        }
    }
}
