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
    public partial class FormPaid : Form
    {
        DBConnect database = new DBConnect();
        int selectedRow;

        public FormPaid()
        {
            InitializeComponent();
        }

        private void FormPaid_Load(object sender, EventArgs e)
        {
            CreateColumns();
            RefreshDataGrid(dataGridView1);
            StyleDatagridview();
        }
        private void CreateColumns()
        { // колонки для таблицы
            dataGridView1.Columns.Add("serial", "№");
            dataGridView1.Columns.Add("name_client", "Клиент");
            dataGridView1.Columns.Add("model", "Устройство");
            dataGridView1.Columns.Add("fault", "Проблема");
            dataGridView1.Columns.Add("work", "Работа");
            dataGridView1.Columns.Add("price", "Цена");
            dataGridView1.Columns.Add("paid_status", "Статус оплаты");
            dataGridView1.Columns.Add("date_to", "Дата приема");
            dataGridView1.Columns.Add("name_status", "Статус");
            dataGridView1.Columns.Add("date_from", "Окончание");
            dataGridView1.Columns.Add("IsNew", String.Empty);
            dataGridView1.Columns[10].Visible = false;
        }
        void StyleDatagridview()
        {
            dataGridView1.BorderStyle = BorderStyle.None;
            dataGridView1.AlternatingRowsDefaultCellStyle.BackColor = Color.LightBlue;
            dataGridView1.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dataGridView1.DefaultCellStyle.SelectionBackColor = Color.FromArgb(87, 219, 255);
            dataGridView1.DefaultCellStyle.SelectionForeColor = Color.Black;
            dataGridView1.BackgroundColor = Color.Snow;
            dataGridView1.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.EnableResizing;
            dataGridView1.EnableHeadersVisualStyles = false;
            dataGridView1.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            //dataGridView1.ColumnHeadersDefaultCellStyle.Font = new Font("MS Reference Sans Serif", 10);
            dataGridView1.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(13, 60, 247);
            dataGridView1.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
        }
        private void ReadSingleRows(DataGridView dgv, IDataRecord record) // предоставляет доступ к значениям столбцов к каждой строки дата ридер
        {
            dgv.Rows.Add(record.GetInt32(0), record.GetString(1), record.GetString(2), record.GetString(3),  record.GetString(4), record.GetDecimal(5), record.GetString(6), record.GetDateTime(7), record.GetString(8), record.GetDateTime(9), RowState.ModifiedNew);
        }


        //отображение
        private void RefreshDataGrid(DataGridView dgv)
        {
            dgv.Rows.Clear();// очистим строки
            string queryNewOrders = $"SELECT * FROM notpaid WHERE name_status = 'Ремонт успешно завершен' or name_status = 'Диагностика завершена, ремонт невозможен' ORDER BY paid_status";

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
                    if (dataGridView1.Rows[index].Cells[6].Value.ToString() == "Не оплачен")
                    {
                        dataGridView1.Rows[index].Cells[6].Style.BackColor = Color.LightSalmon;
                    }
                    else if (dataGridView1.Rows[index].Cells[6].Value.ToString() == "Оплачен")
                    {
                        dataGridView1.Rows[index].Cells[6].Style.BackColor = Color.LightGreen;
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

        private void Update()
        {
            var totaltext = textBoxTotal.Text;
            
            string newtotaltext = totaltext.Remove(totaltext.Length - 3);
            database.openConnection();

            for (int index = 0; index < dataGridView1.Rows.Count; index++)
            {
                var rowState = (RowState)dataGridView1.Rows[index].Cells[10].Value;
                if (rowState == RowState.Existed)
                    continue;

                if (rowState == RowState.Modified)
                {
                    
                    var serial = dataGridView1.Rows[index].Cells[0].Value.ToString();
                    var date_from = DateTime.Now;

                    var changeQuery = $"update orders set id_paid = {2}  where serial = '{serial}'";
                    var command = new SqlCommand(changeQuery, database.getConnection());
                    command.ExecuteNonQuery();

                    var total = Convert.ToInt32(newtotaltext);
                    var changeQuery2 = $"update orders set cost = {total}  where serial = {serial}";
                    var command2 = new SqlCommand(changeQuery2, database.getConnection());
                    command2.ExecuteNonQuery();
                }

            }
            database.closeConnection();
        }
        private void Change()
        {
            var selectedRowIndex = dataGridView1.CurrentCell.RowIndex;// текущий столбец и текущий индекс строки в которой находимя

            var serial = textBoxSerial.Text;


            if (dataGridView1.Rows[selectedRowIndex].Cells[0].Value.ToString() != string.Empty)
            {
                if (textBoxSerial.Text != "")
                {

                    dataGridView1.Rows[selectedRowIndex].SetValues(serial);
                    dataGridView1.Rows[selectedRowIndex].Cells[10].Value = RowState.Modified;
                }
                else
                {
                    MessageBox.Show("Цена должна иметь числовой формат!");
                }
            }
        }
        private decimal change;
        private void Paid() {
            var total = Convert.ToDecimal(textBoxTotal.Text);
            var cash = Convert.ToDecimal(textBoxCash.Text);
            change = cash - total;


            if(total <= cash) {
                MessageBox.Show("К оплате: " + total + " руб."+"\nВзнос: " + cash + " руб." + "\nCдача: " + change + " руб.");

                if (printPreviewDialog1.ShowDialog() == DialogResult.OK)
                {
                    printDocument1.Print();
                }
                Change();
                Update();
                RefreshDataGrid(dataGridView1);
            }
            else
            {
                MessageBox.Show("Взнос меньше на " + " " + change);
            }
        }

        private void btnPaid_Click(object sender, EventArgs e)
        {
            if (textBoxCash.Text == "")
            {
                MessageBox.Show("Введите сумму оплаты");
            }
            else {
                Paid();
            }
        }

        private void CostPaid()
        {
            var serial = textBoxSerial.Text;
            string countSerial = $"SELECT cost FROM orders WHERE serial = '{serial}';";
            SqlCommand command = new SqlCommand(countSerial, database.getConnection());

            database.openConnection();
            SqlDataReader read = command.ExecuteReader();

            while (read.Read())
            {
                textBoxCash.Text = read[0].ToString();
            }
            read.Close();

        }

        private void dataGridView1_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
            selectedRow = e.RowIndex;

            if (e.RowIndex >= 0)// что бы не выйти за границы индексов
            {
                DataGridViewRow row = dataGridView1.Rows[selectedRow];

                textBoxTotal.Text = row.Cells[5].Value.ToString();
                textBoxSerial.Text = row.Cells[0].Value.ToString();
                textBoxStatusPaid.Text = row.Cells[6].Value.ToString();
            }
        }


        private void ClearFields() {
            textBoxSerial.Text = "";
            textBoxCash.Text = "";
            textBoxTotal.Text = "";
        
        }
        private void iconPictureBoxClear_Click(object sender, EventArgs e)
        {
            ClearFields();
        }

        private void printPreviewDialog1_Load(object sender, EventArgs e)
        {

        }
        private int RowsPrint; // переменная для передачи переменной в принт
        private void dataGridView1_MouseClick_1(object sender, MouseEventArgs e)
        {
            int index = dataGridView1.CurrentCell.RowIndex;
            RowsPrint = index;

            CostPaid();
            if (textBoxStatusPaid.Text == "Оплачен")// что бы не выйти за границы индексов
            {
                if (MessageBox.Show("Этот заказ уже оплачен" + " " + " Хотите просмотреть чек?", "Предупреждение", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    if (printPreviewDialog1.ShowDialog() == DialogResult.OK)
                    {
                        printDocument1.Print();
                    }
                }
            }
        }
        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            e.Graphics.DrawString("Чек по ремонту", new Font("Segoe UI", 24, FontStyle.Bold), Brushes.Black, new Point(300, 50));
            e.Graphics.DrawString("────────────────────────────────────────", new Font("Segoe UI", 16, FontStyle.Regular), Brushes.Black, new Point(50, 100));
            e.Graphics.DrawString("Кассовый чек №2789:                                                            " + DateTime.Now, new Font("Segoe UI", 14, FontStyle.Bold), Brushes.Blue, new Point(50, 150));
            e.Graphics.DrawString("Клиент ФИО:  " + dataGridView1.Rows[RowsPrint].Cells[1].Value.ToString(), new Font("Segoe UI", 14, FontStyle.Regular), Brushes.Black, new Point(50, 250));
            e.Graphics.DrawString("Наименование товара:  " + dataGridView1.Rows[RowsPrint].Cells[2].Value.ToString(), new Font("Segoe UI", 14, FontStyle.Regular), Brushes.Black, new Point(50, 300));
            e.Graphics.DrawString("Дата приема заказа:  " + dataGridView1.Rows[RowsPrint].Cells[7].Value.ToString(), new Font("Segoe UI", 14, FontStyle.Regular), Brushes.Black, new Point(50, 350));
            e.Graphics.DrawString("Обнаруженная проблема во время диагностики:  " + dataGridView1.Rows[RowsPrint].Cells[3].Value.ToString(), new Font("Segoe UI", 14, FontStyle.Regular), Brushes.Black, new Point(50, 400));
            e.Graphics.DrawString("Проведенные работы:  " + dataGridView1.Rows[RowsPrint].Cells[4].Value.ToString(), new Font("Segoe UI", 14, FontStyle.Regular), Brushes.Black, new Point(50, 450));
            e.Graphics.DrawString("Стоимость работ:  " + dataGridView1.Rows[RowsPrint].Cells[5].Value.ToString() + " руб.", new Font("Segoe UI", 14, FontStyle.Regular), Brushes.Black, new Point(50, 500));
            e.Graphics.DrawString("Экспертное заключение:  " + dataGridView1.Rows[RowsPrint].Cells[8].Value.ToString(), new Font("Segoe UI", 14, FontStyle.Regular), Brushes.Black, new Point(50, 550));
            e.Graphics.DrawString("Дата окончания заказа:  " + dataGridView1.Rows[RowsPrint].Cells[9].Value.ToString(), new Font("Segoe UI", 14, FontStyle.Regular), Brushes.Black, new Point(50, 600));
            e.Graphics.DrawString("────────────────────────────────────────", new Font("Segoe UI", 16, FontStyle.Regular), Brushes.Black, new Point(50, 650));
            e.Graphics.DrawString("Итого:  " + textBoxTotal.Text + " руб.", new Font("Segoe UI", 14, FontStyle.Bold), Brushes.Black, new Point(50, 900));
            e.Graphics.DrawString("Наличными:  " + textBoxCash.Text + " руб.", new Font("Segoe UI", 14, FontStyle.Bold), Brushes.Black, new Point(50, 925));
            e.Graphics.DrawString("Сдача:  " + change + " руб.", new Font("Segoe UI", 14, FontStyle.Bold), Brushes.Black, new Point(50, 950));
            e.Graphics.DrawString("Статус оплаты:  " + dataGridView1.Rows[RowsPrint].Cells[6].Value.ToString(), new Font("Segoe UI", 14, FontStyle.Regular), Brushes.Black, new Point(50, 1000));
            e.Graphics.DrawString("Компьютерный сервис ReactPC", new Font("Segoe UI", 18, FontStyle.Bold), Brushes.Black, new Point(220, 1050));
            e.Graphics.DrawString("Адрес: Краснодарский край. ст. Васюринская, ул. Западная 98", new Font("Segoe UI", 12, FontStyle.Regular), Brushes.Black, new Point(190, 1100));
            e.Graphics.DrawImage(znak.Image,550,820);
        }

        private void btnPaid_MouseEnter(object sender, EventArgs e)
        {
            btnPaid.BackColor = Color.FromArgb(13, 60, 247);
            btnPaid.ForeColor = Color.Snow;
        }

        private void btnPaid_MouseLeave(object sender, EventArgs e)
        {
            btnPaid.BackColor = Color.Snow;
            btnPaid.ForeColor = Color.FromArgb(13, 60, 247);
        }

        
    }
}
