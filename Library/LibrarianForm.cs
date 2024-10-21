using System;
using System.Windows.Forms;

namespace Library
{
    public partial class LibrarianForm : Form
    {
        public LibrarianForm(string id_sotr)
        {
            InitializeComponent();
            this.id_sotr = id_sotr;
        }

        string id_sotr;

        private void LibrarianForm_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "libraryDataSet2.NewBook". При необходимости она может быть перемещена или удалена.
            this.newBookTableAdapter.Fill(this.libraryDataSet2.NewBook);
            dataGridView1.DataSource = readerTableAdapter.GetData();
            dataGridView5.DataSource = newBookTableAdapter.GetData();
            dataGridView2.DataSource = l_BookingTableAdapter.GetData();
            dataGridView3.DataSource = l_GivingTableAdapter.GetData();
            dataGridView4.DataSource = l_AdmissionTableAdapter.GetData();
        }

        private void btnAddReader_Click(object sender, EventArgs e)
        {
            _CreaterReaderForm newForm = new _CreaterReaderForm();
            newForm.Show();
        }

        private void btnGive_Click(object sender, EventArgs e)
        {
            int? error = 0;
            LibraryDataSetTableAdapters.QueriesTableAdapter tableAdapter = new LibraryDataSetTableAdapters.QueriesTableAdapter();
            errorProvider1.Clear();
            if (txtIDReader.Text == "")
            {
                errorProvider1.SetError(txtIDReader, "Введите ID читателя!");
                return;
            }
            if (txtIDBook.Text == "")
            {
                errorProvider1.SetError(txtIDBook, "Введите ID книги!");
                return;
            }
            try
            {
                tableAdapter.AddGiving(Convert.ToInt32(txtIDBook.Text), Convert.ToInt32(id_sotr), Convert.ToInt32(txtIDReader.Text), DateTime.Today, ref error);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                throw;
            }
            if (error == 0)
            {
                MessageBox.Show("Книга выдана", "Успешно", MessageBoxButtons.OK);
                dataGridView3.DataSource = l_GivingTableAdapter.GetData(); //update
            }
            if (error == 1)
            {
                MessageBox.Show("Книгу уже взяли!", "Ошибка", MessageBoxButtons.OK);
            }
            if (error == 2)
            {
                MessageBox.Show("Книги нет в наличии!", "Ошибка", MessageBoxButtons.OK);
            }
            if (error == 3)
            {
                MessageBox.Show("Книги не существует!", "Ошибка", MessageBoxButtons.OK);
            }
        }

        private void btnAdm_Click(object sender, EventArgs e)
        {
            int? error = 0;
            LibraryDataSetTableAdapters.QueriesTableAdapter tableAdapter = new LibraryDataSetTableAdapters.QueriesTableAdapter();
            errorProvider1.Clear();
            if (txtIDBook.Text == "")
            {
                errorProvider1.SetError(txtIDBook, "Введите ID книги!");
                return;
            }
            if (txtIDReader.Text == "")
            {
                errorProvider1.SetError(txtIDReader, "Введите ID читателя!");
                return;
            }
            try
            {
                tableAdapter.AddAdmission(Convert.ToInt32(txtIDBook.Text), Convert.ToInt32(id_sotr), Convert.ToInt32(txtIDReader.Text), DateTime.Today, ref error);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                throw;
            }
            if (error == 0)
            {
                MessageBox.Show("Книга возвращена", "Успешно", MessageBoxButtons.OK);
                dataGridView4.DataSource = l_AdmissionTableAdapter.GetData(); //update
            }
            if (error == 1)
            {
                MessageBox.Show("Книгу уже вернули!", "Ошибка", MessageBoxButtons.OK);
            }
            if (error == 2)
            {
                MessageBox.Show("Книга есть в наличии!", "Ошибка", MessageBoxButtons.OK);
            }
            if (error == 3)
            {
                MessageBox.Show("Книги не существует!", "Ошибка", MessageBoxButtons.OK);
            }
        }

        private void btnSearchR_Click(object sender, EventArgs e)
        {
            errorProvider1.Clear();
            if (txtSearch.Text == "")
            {
                errorProvider1.SetError(txtSearch, "Введите данные!");
                return;
            }
            if (tabControl1.SelectedTab == tabReader)
            {
                dataGridView1.DataSource = readerTableAdapter.GetFIOReader(txtSearch.Text);
            }
            if (tabControl1.SelectedTab == tabBook)
            {
                dataGridView5.DataSource = newBookTableAdapter.GetBookName(txtSearch.Text);
            }
            if (tabControl1.SelectedTab == tabBooking)
            {
                dataGridView2.DataSource = l_BookingTableAdapter.GetFIOrBook(txtSearch.Text);
            }
            if (tabControl1.SelectedTab == tabGiving)
            {
                dataGridView3.DataSource = l_GivingTableAdapter.GetFIOrGiving(txtSearch.Text);
            }
            if (tabControl1.SelectedTab == tabAdmission)
            {
                dataGridView4.DataSource = l_AdmissionTableAdapter.GetFIOrAdm(txtSearch.Text);
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtSearch.Clear();
            dataGridView1.DataSource = readerTableAdapter.GetData();
            dataGridView5.DataSource = newBookTableAdapter.GetData();
            dataGridView2.DataSource = l_BookingTableAdapter.GetData();
            dataGridView3.DataSource = l_GivingTableAdapter.GetData();
            dataGridView4.DataSource = l_AdmissionTableAdapter.GetData();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
            LoginForm newForm = new LoginForm();
            newForm.Show();
        }
    }
}
