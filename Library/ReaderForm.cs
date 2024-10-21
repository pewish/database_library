using System;
using System.Windows.Forms;

namespace Library
{
    public partial class ReaderForm : Form
    {
        public ReaderForm(string id_reader)
        {
            InitializeComponent();
            this.id_reader = id_reader;
        }

        string id_reader;

        private void ReaderForm_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "libraryDataSet1.Book". При необходимости она может быть перемещена или удалена.
            this.bookTableAdapter.Fill(this.libraryDataSet1.Book);

        }

        private void btnFindR_Click(object sender, EventArgs e)
        {
            errorProvider1.Clear();
            if (txtSearch.Text == "")
            {
                errorProvider1.SetError(txtSearch, "Введите данные!");
                return;
            }
            if (tabControl1.SelectedTab == tabName)
            {
                dataGridView1.DataSource = bookTableAdapter.GetBook(txtSearch.Text);
            }
            if (tabControl1.SelectedTab == tabAuthor)
            {
                dataGridView2.DataSource = bookTableAdapter.GetAuthor(txtSearch.Text);
            }
            if (tabControl1.SelectedTab == tabPub)
            {
                dataGridView3.DataSource = bookTableAdapter.GetPub(txtSearch.Text);
            }
            if (tabControl1.SelectedTab == tabYear)
            {
                dataGridView4.DataSource = bookTableAdapter.GetYear(Convert.ToInt32(txtSearch.Text));
            }
            if (tabControl1.SelectedTab == tabGenre)
            {
                dataGridView5.DataSource = bookTableAdapter.GetGenre(txtSearch.Text);
            }
            if (tabControl1.SelectedTab == tabSection)
            {
                dataGridView6.DataSource = bookTableAdapter.GetSection(txtSearch.Text);
            }
            if (tabControl1.SelectedTab == tabAv)
            {
                dataGridView7.DataSource = bookTableAdapter.GetAv(txtSearch.Text);
            }
        }

        private void txtIDBook_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && e.KeyChar != Convert.ToChar(8))
                e.Handled = true;
        }

        private void btnBooking_Click_1(object sender, EventArgs e)
        {
            int? error = 0;
            errorProvider1.SetError(txtIDBook, "");
            if (txtIDBook.Text == "")
            {
                errorProvider1.SetError(txtIDBook, "Введите ID книги!");
                return;
            }
            try
            {
                bookTableAdapter.AddBooking(Convert.ToInt32(txtIDBook.Text), Convert.ToInt32(id_reader), DateTime.Today, ref error);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                throw;
            }
            if (error == 0)
            {
                MessageBox.Show("Вы забронировали книгу", "Успешно", MessageBoxButtons.OK);
                dataGridView1.DataSource = bookTableAdapter.GetData(); //update
            }
            if (error == 1)
            {
                MessageBox.Show("Книга уже забронирована!", "Ошибка", MessageBoxButtons.OK);
            }
        }

        private void btnShow_Click(object sender, EventArgs e)
        {
            txtSearch.Clear();
            dataGridView1.DataSource = bookTableAdapter.GetData();
            dataGridView2.DataSource = bookTableAdapter.GetData();
            dataGridView3.DataSource = bookTableAdapter.GetData();
            dataGridView4.DataSource = bookTableAdapter.GetData();
            dataGridView5.DataSource = bookTableAdapter.GetData();
            dataGridView6.DataSource = bookTableAdapter.GetData();
            dataGridView7.DataSource = bookTableAdapter.GetData();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
            LoginForm newForm = new LoginForm();
            newForm.Show();
        }
    }
}
