using System;
using System.Windows.Forms;

namespace Library
{
    public partial class SpecialistForm : Form
    {
        public SpecialistForm()
        {
            InitializeComponent();
        }

        private void SpecialistForm_Load(object sender, EventArgs e)
        {

        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            errorProvider1.Clear();
            if (txtSearch.Text == "")
            {
                errorProvider1.SetError(txtSearch, "Введите данные!");
                return;
            }
            if (tabControl1.SelectedTab == tabBook)
            {
                dataGridView1.DataSource = bookTableAdapter.GetBook(txtSearch.Text);
            }
            if (tabControl1.SelectedTab == tabPub)
            {
                dataGridView2.DataSource = publisherTableAdapter.GetPub(txtSearch.Text);
            }
            if (tabControl1.SelectedTab == tabValuedBooks)
            {
                dataGridView3.DataSource = valuedBookTableAdapter.GetValuedBook(txtSearch.Text);
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtSearch.Clear();
            dataGridView1.DataSource = bookTableAdapter.GetData();
            dataGridView2.DataSource = publisherTableAdapter.GetData();
            dataGridView3.DataSource = valuedBookTableAdapter.GetData();
        }

        private void btnAddBook_Click(object sender, EventArgs e)
        {
            _CreateBookForm newForm = new _CreateBookForm();
            newForm.Show();
        }

        private void btnAddPub_Click(object sender, EventArgs e)
        {
            _CreatePublisherForm newForm = new _CreatePublisherForm();
            newForm.Show();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
            LoginForm newForm = new LoginForm();
            newForm.Show();
        }
    }
}
