using System;
using System.Windows.Forms;

namespace Library
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
            ToolTip help = new ToolTip();
            help.SetToolTip(txtLogin, "Логин состоит только из цифр");
            help.SetToolTip(txtPassword, "Пароль состоит только из цифр");
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            errorProvider.SetError(txtLogin, "");
            errorProvider.SetError(txtPassword, "");
            if (txtLogin.Text == "")
            {
                errorProvider.SetError(txtLogin, "Введите логин!");
                return;
            }
            if (txtPassword.Text == "")
            {
                errorProvider.SetError(txtPassword, "Введите пароль!");
                return;
            }

            int login = Convert.ToInt32(txtLogin.Text);
            int password = Convert.ToInt32(txtPassword.Text);
            int? check = 0;

            sotrTableAdapter1.LoginProc(login, password, ref check);
            if (check == 5) //увольнение
            {
                MessageBox.Show("Нет доступа!", "Ошибка", MessageBoxButtons.OK);
            }
            if (check == 1)
            {
                DirectorForm newForm = new DirectorForm();
                newForm.Show();
                MessageBox.Show("Вы вошли как Директор", "Добро пожаловать!", MessageBoxButtons.OK);
                this.Hide();
            }
            if (check == 2)
            {
                LibrarianForm newForm = new LibrarianForm(login.ToString());
                newForm.Show();
                MessageBox.Show("Вы вошли как Библиотекарь", "Добро пожаловать!", MessageBoxButtons.OK);
                this.Hide();
            }
            if (check == 3)
            {
                SpecialistForm newForm = new SpecialistForm();
                newForm.Show();
                MessageBox.Show("Вы вошли как Специалист учетно-хранительской деятельности", "Добро пожаловать!", MessageBoxButtons.OK);
                this.Hide();
            }
            if (check == 4)
            {
                ReaderForm newForm = new ReaderForm(Convert.ToString(login));
                newForm.Show();
                MessageBox.Show("Вы вошли как Читатель", "Добро пожаловать!", MessageBoxButtons.OK);
                this.Hide();
            }
        }

        private void txtLogin_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && e.KeyChar != Convert.ToChar(8))
                e.Handled = true;
        }

        private void txtPassword_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && e.KeyChar != Convert.ToChar(8))
                e.Handled = true;
        }
    }
}
