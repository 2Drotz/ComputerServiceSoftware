using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FontAwesome.Sharp;
using MaterialSkin;
using MaterialSkin.Controls;
using System.Data.SqlClient;

namespace ReactPC
{

    enum RowState // надо пояснить
    { 
        Existed,
        New,
        Modified,
        ModifiedNew,
        Deleted
    }

    public partial class FormMainMenu : Form
    {
        private readonly checkAdmin _user;// объявление юзера


        DBConnect database = new DBConnect();

        int selectedRow;//  для DGV

        //Fields
        private IconButton currentBtn;
        private Panel leftBorderBtn;
        private Form currentChildForm;

        //Constructor
        public FormMainMenu(checkAdmin user)
        {
            _user = user;
            InitializeComponent();
            leftBorderBtn = new Panel();
            leftBorderBtn.Size = new Size(8, 60);
            panelMenu.Controls.Add(leftBorderBtn);
            //Form
            this.Text = string.Empty;
            this.ControlBox = false;
            this.DoubleBuffered = true;
            this.MaximizedBounds = Screen.FromHandle(this.Handle).WorkingArea;
        }
        private void FormMainMenu_Load(object sender, EventArgs e)
        {
            lblUsername.Text = $"{_user.Login}: {_user.Status}";
            CreateColumns();
            RefreshDataGrid(dataGridView1);
            labelClient();
            StyleDatagridview();
            labelOrders();
            labelRepair();
            labelNP();
            labelName();
            labelSumRepair();
        }

        private void CreateColumns() { // колонки для таблицы
            dataGridView1.Columns.Add("id", "id");
            dataGridView1.Columns.Add("repair_name ", "Ремонт");
            dataGridView1.Columns.Add("price", "Цена");
            dataGridView1.Columns.Add("id_devicetype", "Тип");
            dataGridView1.Columns.Add("id_brand", "Бренд");
            dataGridView1.Columns.Add("IsNew", String.Empty);
            dataGridView1.Columns[5].Visible = false;
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

        private void ReadSingleRows(DataGridView dgw, IDataRecord record) // предоставляет доступ к значениям столбцов к каждой строки дата ридер
        {
            dgw.Rows.Add(record.GetInt32(0), record.GetString(1), record.GetDecimal(2), record.GetString(3), record.GetString(4), RowState.ModifiedNew);           
        }


        //отображение
        private void RefreshDataGrid(DataGridView dgv)
        {
            dgv.Rows.Clear();// очистим строки
            string queryRepair = $"SELECT id_repair, repair_name, price, devicetype, brand FROM test_repair AS rep INNER JOIN devicetype AS dv ON (rep.id_devicetype = dv.id_devicetype) INNER JOIN brand AS br ON(rep.id_brand = br.id_brand)";

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

        //Structs
        private struct RGBColors
        {
            public static Color color1 = Color.FromArgb(172, 126, 241);
            public static Color color2 = Color.FromArgb(249, 118, 176);
            public static Color color3 = Color.FromArgb(253, 138, 114);
            public static Color color4 = Color.FromArgb(95, 77, 221);
            public static Color color5 = Color.FromArgb(255, 128, 0);
            public static Color color6 = Color.FromArgb(24, 161, 251);

        }

        //Methods
        private void ActivateButton(object senderBtn, Color color)
        {
            if (senderBtn != null)
            {
                DisableButton();
                //Button
                currentBtn = (IconButton)senderBtn;
                currentBtn.BackColor = Color.FromArgb(6, 46, 204);
                currentBtn.ForeColor = color;
                currentBtn.TextAlign = ContentAlignment.MiddleCenter;
                currentBtn.IconColor = color;
                currentBtn.TextImageRelation = TextImageRelation.TextBeforeImage;
                currentBtn.ImageAlign = ContentAlignment.MiddleRight;
                //Left border button
                leftBorderBtn.BackColor = color;
                leftBorderBtn.Location = new Point(0, currentBtn.Location.Y);
                leftBorderBtn.Visible = true;
                leftBorderBtn.BringToFront();
                //Current Child Form Icon
                iconCurrentChildForm.IconChar = currentBtn.IconChar;
                iconCurrentChildForm.IconColor = Color.FromArgb(13, 60, 247);
            }
        }

        private void DisableButton()
        {
            if (currentBtn != null)
            {
                currentBtn.BackColor = Color.FromArgb(13, 60, 247);
                currentBtn.ForeColor = Color.Snow;
                currentBtn.TextAlign = ContentAlignment.MiddleLeft;
                currentBtn.IconColor = Color.Snow;
                currentBtn.TextImageRelation = TextImageRelation.ImageBeforeText;
                currentBtn.ImageAlign = ContentAlignment.MiddleLeft;
            }
        }

        private void OpenChildForm(Form childForm)
        {
            //open only form
            if (currentChildForm != null)
            {
                currentChildForm.Close();
            }
            currentChildForm = childForm;
            //End
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panelDesktop.Controls.Add(childForm);
            panelDesktop.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
            lblTitleChildForm.Text = childForm.Text;
        }

        private void Reset()
        {
            DisableButton();
            leftBorderBtn.Visible = false;
            iconCurrentChildForm.IconChar = IconChar.Home;
            iconCurrentChildForm.IconColor = Color.FromArgb(13, 60, 247);
            lblTitleChildForm.Text = "Главная";
        }

        //Events
        //Reset
        private void btnHome1_Click(object sender, EventArgs e)
        {
            if (currentChildForm != null)
            {
                currentChildForm.Close();
            }
            Reset();
            labelClient();
            labelOrders();
            labelRepair();
            labelNP();
            labelSumRepair();

        }

        //Menu Button_Clicks

        private void btnClient_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color5);
            OpenChildForm(new FormClient(_user));
        }
        private void btnOrder_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color5);
            OpenChildForm(new FormOrders(_user));
        }

        private void btnProduct_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color5);
            OpenChildForm(new FormProducts());
        }

        private void btnCustomer_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color5);
            OpenChildForm(new FormPaid());
        }

        private void btnMarketing_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color5);
            OpenChildForm(new FormNewOrders(_user));
        }

        private void btnSetting_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color5);
            OpenChildForm(new FormSetting(_user));
        }

        //Drag Form
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();

        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        private void panelTitleBar_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        //Close-Maximize-Minimize
        private void btnExit_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Вы хотите закрыть ReactPC?", "Предупреждение", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }
        private void btnMax_Click(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Normal)
                WindowState = FormWindowState.Maximized;
            else
                WindowState = FormWindowState.Normal;
        }

        private void btnMin_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        //Remove transparent border in maximized state
        private void FormMainMenu_Resize(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Maximized)
                FormBorderStyle = FormBorderStyle.None;
            else
                FormBorderStyle = FormBorderStyle.Sizable;
        }


        // 
        private void labelOrders() {

            string countUser = $"select COUNT(*)  FROM orders WHERE id_status = 1";
            SqlCommand command = new SqlCommand(countUser, database.getConnection());

            database.openConnection();
            SqlDataReader read = command.ExecuteReader();

            while (read.Read())
            {
                lblOrders.Text = read[""].ToString();
            }
            read.Close();

        }
        private void labelRepair() {
            string countUser = $"select COUNT(*)  FROM orders WHERE id_status != 5 and id_status != 4 and id_status != 1";
            SqlCommand command = new SqlCommand(countUser, database.getConnection());

            database.openConnection();
            SqlDataReader read = command.ExecuteReader();

            while (read.Read())
            {
                lblrepair.Text = read[""].ToString();
            }
            read.Close();
        }
        private void labelClient()
        {

            string countUser = $"select COUNT(*)  FROM client";
            SqlCommand command = new SqlCommand(countUser, database.getConnection());

            database.openConnection();
            SqlDataReader read = command.ExecuteReader();

            while (read.Read())
            {
                lblClient.Text = read[""].ToString();
            }
            read.Close();

        }
        private void labelNP()
        {
            string countUser = $"select COUNT(*)  FROM orders WHERE id_paid = 1 AND id_status > 3";
            SqlCommand command = new SqlCommand(countUser, database.getConnection());

            database.openConnection();
            SqlDataReader read = command.ExecuteReader();

            while (read.Read())
            {
                labelNotPaid.Text = read[""].ToString();
            }
            read.Close();
        }

        private void labelSumRepair()
        {
            string countUser = $"SELECT SUM(cost) FROM orders WHERE date_from BETWEEN DATEADD(D, -7, GETDATE()) AND GETDATE()";
            SqlCommand command = new SqlCommand(countUser, database.getConnection());

            database.openConnection();
            SqlDataReader read = command.ExecuteReader();

            while (read.Read())
            {
                labelCostRepair.Text = read[""].ToString();
            }
            read.Close();
        }

        private void labelName()
        {
            var nameuser = lblUsername.Text;
            string nameUser = $"SELECT CONCAT(name_user, ' ' , surname_user) AS userss FROM users WHERE login_user  = '{_user.Login}'";
            SqlCommand command = new SqlCommand(nameUser, database.getConnection());

            database.openConnection();
            SqlDataReader read = command.ExecuteReader();

            while (read.Read())
            {
                labelNameUser.Text = read["userss"].ToString();
            }
            read.Close();

        }


        private void btnLogout_Click(object sender, EventArgs e)
        {

            if (MessageBox.Show("Выйти с этого аккаунта?", "Предупреждение", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                Sign frmSign = new Sign();
                this.Hide();
                frmSign.ShowDialog();
                this.Show();
            }

        }

        private void iconPictureBoxRefresh_Click(object sender, EventArgs e)
        {
            RefreshDataGrid(dataGridView1);// метод обновления
        }

        private void CurrentRow()
        {
            int index = dataGridView1.CurrentCell.RowIndex;
            MessageBox.Show(index.ToString());
        }
        //private void Search(DataGridView dgv) { // поиск
        //    dgv.Rows.Clear();

        //    string searchString = $"select id_repair, repair_name, price, devicetype, brand FROM test_repair AS rep INNER JOIN devicetype AS dv ON (rep.id_devicetype = dv.id_devicetype) INNER JOIN brand AS br ON(rep.id_brand = br.id_brand) where concat (id_repair, repair_name, price, devicetype, brand) like '%" + textBoxSearch.Text + "%'";
        //    SqlCommand command = new SqlCommand(searchString, database.getConnection());

        //    database.openConnection();
        //    SqlDataReader read = command.ExecuteReader();

        //    while (read.Read()) {
        //        ReadSingleRows(dgv, read);
        //    }
        //    read.Close();
        //}


        //обновление при удалении и изменении


      
        private void btnChange_Click(object sender, EventArgs e)
        {
            RefreshDataGrid(dataGridView1);
        }
        private void btnSave_Click(object sender, EventArgs e)
        { 
            CurrentRow();
        }

        private void btnExit_MouseEnter(object sender, EventArgs e)
        {
            btnExit.IconColor = Color.FromArgb(235, 83, 83);
        }

        private void btnExit_MouseLeave(object sender, EventArgs e)
        {
            btnExit.IconColor = Color.FromArgb(13, 60, 247);
        }
    }
}