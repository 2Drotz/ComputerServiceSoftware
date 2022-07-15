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
    public partial class FormSetting : Form
    {
        DBConnect database = new DBConnect();
        private readonly checkAdmin _user;// объявление юзера
        public FormSetting(checkAdmin user)
        {
            _user = user;
            InitializeComponent();
        }
        private void FormSetting_Load(object sender, EventArgs e)
        {
            lblUsernameSet.Text = $"{_user.Login}";
            isAdmin();
            CreateColumns();
            RefreshDataGrid();
            txtNPass.PasswordChar = '•';
            txtRePass2.PasswordChar = '•';
            User();
            labelAdmin();
            StyleDatagridview();
            textBox_passreg.PasswordChar = '•';
            LoadCategory();
        }
        private void isAdmin() //
        {
            TabPageControl.Enabled = _user.IsAdmin;
            metroTabPage1.Enabled = _user.IsAdmin;
        }
        private void btnClear_Click(object sender, EventArgs e)
        {
            ClearCP();
        }
        public void ClearCP()
        {
            txtCurPass.Clear();
            txtNPass.Clear();
            txtRePass2.Clear();
        }

        public void LoadCategory()
        {
            comboBoxRole.Items.Clear();
            comboBoxRole.DataSource = database.getTable("SELECT * FROM role");
            comboBoxRole.DisplayMember = "role";
            comboBoxRole.ValueMember = "id_role";
        }
        private void CreateColumns()
        { // колонки для таблицы
            dataGridViewControl.Columns.Add("id", "№");
            dataGridViewControl.Columns.Add("login_user ", "Логин");
            dataGridViewControl.Columns.Add("pass_user", "Пароль");
            dataGridViewControl.Columns.Add("name_user", "Имя");
            dataGridViewControl.Columns.Add("surname_user", "Фамилия");
            dataGridViewControl.Columns.Add("role_user", "Роль");
            var checkColumn = new DataGridViewCheckBoxColumn();
            checkColumn.HeaderText = "IsAdmin";
            dataGridViewControl.Columns.Add(checkColumn);

        }
        void StyleDatagridview()
        {
            dataGridViewControl.BorderStyle = BorderStyle.None;
            dataGridViewControl.AlternatingRowsDefaultCellStyle.BackColor = Color.LightBlue;
            dataGridViewControl.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dataGridViewControl.DefaultCellStyle.SelectionBackColor = Color.FromArgb(87, 219, 255);
            dataGridViewControl.DefaultCellStyle.SelectionForeColor = Color.Black;
            dataGridViewControl.BackgroundColor = Color.Snow;
            dataGridViewControl.ColumnHeadersHeight = 40;
            //dataGridView1.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;//optional
            dataGridViewControl.EnableHeadersVisualStyles = false;
            dataGridViewControl.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            //dataGridView1.ColumnHeadersDefaultCellStyle.Font = new Font("MS Reference Sans Serif", 10);
            dataGridViewControl.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(13, 60, 247);
            dataGridViewControl.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
        }
        private void ReadSingleRows(IDataRecord record) // предоставляет доступ к значениям столбцов к каждой строки дата ридер
        {
            dataGridViewControl.Rows.Add(record.GetInt32(0), record.GetString(1), record.GetString(2), record.GetString(3), record.GetString(4), record.GetString(5), record.GetBoolean(6));
        }
        // отображение сколько пользователей
        private void User() {

            string countUser = $"select COUNT(*)  FROM users";
            SqlCommand command = new SqlCommand(countUser, database.getConnection());

            database.openConnection();
            SqlDataReader read = command.ExecuteReader();

            while (read.Read())
            {
                lblUser.Text = read[""].ToString();
            }
            read.Close();
            database.closeConnection();
        }
        // отображение сколько админов
        private void labelAdmin() {


            string countUser = $"select COUNT(admin_user)  FROM users WHERE admin_user = {1}";
            SqlCommand command = new SqlCommand(countUser, database.getConnection());

            database.openConnection();
            SqlDataReader read = command.ExecuteReader();

            while (read.Read())
            {
                lblAdmin.Text = read[""].ToString();
            }
            read.Close();
            database.closeConnection();
        }

        private void RefreshDataGrid()
        {
            dataGridViewControl.Rows.Clear();// очистим строки
            string queryRepair = $"SELECT id_user, login_user, password_user, name_user, surname_user, role, admin_user FROM users INNER JOIN role ON(users.id_role = role.id_role)";

            SqlCommand command = new SqlCommand(queryRepair, database.getConnection());// переносим запрос и строку подключения к базе данных
            database.openConnection();
            SqlDataReader reader = command.ExecuteReader();

            while (reader.Read())
            {
                ReadSingleRows(reader);
            }
            reader.Close();
            database.closeConnection();
        }

        private void btnControlSave_Click(object sender, EventArgs e)
        {
            database.openConnection();

            for (int index = 0; index < dataGridViewControl.Rows.Count; index++)
            {
                    var id = dataGridViewControl.Rows[index].Cells[0].Value.ToString();
                    var isadmin = dataGridViewControl.Rows[index].Cells[6].Value.ToString();

                    var changeQuery = $"update users set admin_user = '{isadmin}'where id_user = '{id}'";
                    var command = new SqlCommand(changeQuery, database.getConnection());
                    command.ExecuteNonQuery();
            }
            database.closeConnection();

            RefreshDataGrid();
            User();
            labelAdmin();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {

            if (MessageBox.Show("Вы точно хотите удалить пользователя", "Предупреждение", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                database.openConnection();
                var selectedRowIndex = dataGridViewControl.CurrentCell.RowIndex;

                var id = Convert.ToInt32(dataGridViewControl.Rows[selectedRowIndex].Cells[0].Value);
                var deleteQuery = $"delete from users where id_user = {id}";
                var command = new SqlCommand(deleteQuery, database.getConnection());
                command.ExecuteNonQuery();

                database.closeConnection();
                RefreshDataGrid();
            }
            
        }
        private void btnPassSave_Click(object sender, EventArgs e)
        {
            var loginUser = lblUsernameSet.Text;// переменные дял запроса и сранения с тексбокс
            var passUser = md5.hashPassword(txtCurPass.Text);
            SqlDataAdapter adapter = new SqlDataAdapter(); // объекты класса
            DataTable dtable = new DataTable();

            string querycheckpass = $"select password_user  from users" +
                $" where login_user = '{loginUser}' and password_user = '{passUser}'"; // sql запрос

            SqlCommand command = new SqlCommand(querycheckpass, database.getConnection());

            adapter.SelectCommand = command;
            adapter.Fill(dtable);

            try
            {
                ClearIcon();
                if (txtCurPass.Text == "" || txtNPass.Text == "" || txtRePass2.Text == "")
                {
                    MessageBox.Show("Заполните все поля!", "Предупреждение", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    iconNo1.Visible = true;
                    iconNo2.Visible = true;
                    iconNo3.Visible = true;
                }
                else if (txtNPass.Text != txtRePass2.Text)
                {
                    MessageBox.Show("Введеные пароли не совпадают!", "Предупреждение", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                    iconOk1.Visible=true;
                    iconNo2.Visible = true;
                    iconNo3.Visible = true;
                }
                else if (dtable.Rows.Count == 0) {
                    iconNo1.Visible=true;
                    iconOk2.Visible=true;
                    iconOk3.Visible=true;
                    MessageBox.Show("Пароль не от этого аккаунта!", "Предупреждение", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                else
                {
                    iconOk1.Visible = true;
                    database.openConnection();
                    string passQuery = $"UPDATE users SET password_user = '" + md5.hashPassword(txtNPass.Text) + "' WHERE login_user='" + lblUsernameSet.Text + "'";
                    SqlCommand command2 = new SqlCommand(passQuery, database.getConnection());
                    command2.ExecuteNonQuery();

                    database.closeConnection();
                    MessageBox.Show("Пароль успешно изменен!", "Изменение данных", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
                  
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка");
            }
        }

        private void ClearIcon() {
            iconNo1.Visible = false;
            iconNo2.Visible = false;
            iconNo3.Visible = false;
            iconOk2.Visible = false;
            iconOk3.Visible = false;
            iconNo1.Visible= false;
        }
        private void btnDelete_MouseEnter(object sender, EventArgs e)
        {
            btnDelete.BackColor = Color.FromArgb(235, 83, 83);
            btnDelete.ForeColor = Color.Snow;
        }

        private void btnDelete_MouseLeave(object sender, EventArgs e)
        {
            btnDelete.BackColor = Color.Transparent;
            btnDelete.ForeColor = Color.FromArgb(235, 83, 83);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox_passreg.Text = "";
            textBox_logreg.Text = "";
            textBox_namereg.Text = "";
            textBox_surreg.Text = "";
            comboBoxRole.Text = "";
            textBoxMail.Text = "";
        }

        private Boolean checkUser()
        { //  метод проверки созданных уже пользователей, во избежения слияний

            var login = textBox_logreg.Text;
            var password = md5.hashPassword(textBox_passreg.Text);

            string queryCheck = $"select id_user, login_user, password_user admin_user from users where login_user = '{login}' or password_user = '{password}'";
            SqlCommand command = new SqlCommand(queryCheck, database.getConnection());

            SqlDataAdapter adapter = new SqlDataAdapter(); // объекты класса
            DataTable dtable = new DataTable();
            adapter.SelectCommand = command;
            adapter.Fill(dtable);
            if (dtable.Rows.Count > 0)
            {
                MessageBox.Show("Пользователь с таким аккаунтом уже существует!", "Предупреждение", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return true;
            }
            else
            {
                return false;
            }
        }
        private void checkMail()
        { //  метод почты зарегестрированныз аккаунтов

            var mail_user = textBoxMail.Text;

            string queryCheck = $"select mail_user from users where mail_user = '{mail_user}'";
            SqlCommand command = new SqlCommand(queryCheck, database.getConnection());

            SqlDataAdapter adapter = new SqlDataAdapter(); // объекты класса
            DataTable dtable = new DataTable();
            adapter.SelectCommand = command;
            adapter.Fill(dtable);
            if (dtable.Rows.Count == 1)
            {
                MessageBox.Show("Данная почта уже зарегестрирована в ReactPC", "Предупреждение", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else {
                var loginUser = textBox_logreg.Text;
                var passUser = md5.hashPassword(textBox_passreg.Text);
                var nameUser = textBox_namereg.Text;
                var surnameUser = textBox_surreg.Text;
                var roleUser = comboBoxRole.SelectedValue;
                string queryUserreg = $"insert into users(login_user, password_user, name_user, surname_user, mail_user ,id_role) values('{loginUser}', '{passUser}', '{nameUser}','{surnameUser}','{mail_user}','{roleUser}' )";

                SqlCommand command2 = new SqlCommand(queryUserreg, database.getConnection());
                database.openConnection();
                if (command2.ExecuteNonQuery() == 1)
                {
                    MessageBox.Show("Новый пользователь добавлен!", "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Не удалось добавить пользователя");
                }
                database.closeConnection();

            }
        }
        private void btnReg_Click(object sender, EventArgs e)
        {
            if (textBox_logreg.Text == "" || textBox_namereg.Text == "" || textBox_passreg.Text == "" || textBox_surreg.Text == "" || comboBoxRole.Text == "" || textBoxMail.Text == "")
            {
                MessageBox.Show("Введите данные!", "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (textBoxMail.Text.Contains("@gmail.com") || textBoxMail.Text.Contains("@yandex.ru") || textBoxMail.Text.Contains("@mail.ru"))
            {
                if (checkUser())// проверка методом есть ли уже пользователь с такими данными
                {
                    return;
                }
                checkMail();
            }
            else
            {
                MessageBox.Show("Неверный формат почты", "Восстановление", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
