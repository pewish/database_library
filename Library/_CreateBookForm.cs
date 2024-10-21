using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Library
{
    public partial class _CreateBookForm : Form
    {
        public _CreateBookForm()
        {
            InitializeComponent();
        }

        private void btnAddBook_Click(object sender, EventArgs e)
        {
            int? error = 0;
            LibraryDataSetTableAdapters.QueriesTableAdapter tableAdapter = new LibraryDataSetTableAdapters.QueriesTableAdapter();
            errorProvider1.Clear();
            if (txtName.Text == "")
            {
                errorProvider1.SetError(txtName, "Введите название книги!");
                return;
            }
            if (txtAuthor.Text == "")
            {
                errorProvider1.SetError(txtAuthor, "Введите ФИО автора!");
                return;
            }
            if (txtPub.Text == "")
            {
                errorProvider1.SetError(txtPub, "Введите название издательства!");
                return;
            }
            if (txtYear.Text == "")
            {
                errorProvider1.SetError(txtYear, "Введите год издания!");
                return;
            }
            if (txtDesc.Text == "")
            {
                errorProvider1.SetError(txtDesc, "Введите описание!");
                return;
            }
            if (txtGenre.Text == "")
            {
                errorProvider1.SetError(txtGenre, "Введите жанр!");
                return;
            }
            if (txtSection.Text == "")
            {
                errorProvider1.SetError(txtSection, "Введите раздел!");
                return;
            }
            if (txtISBN.Text == "")
            {
                errorProvider1.SetError(txtISBN, "Введите ISBN!");
                return;
            }
            try
            {
                tableAdapter.InsertBook(txtName.Text, txtAuthor.Text, txtPub.Text, Convert.ToInt32(txtYear.Text), txtDesc.Text,
                txtGenre.Text, txtSection.Text, txtISBN.Text, ref error);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                throw;
            }
            if (error == 0)
            {
                MessageBox.Show("Книга добавлена", "Успешно", MessageBoxButtons.OK);
                txtName.Clear();
                txtAuthor.Clear();
                txtPub.Clear();
                txtYear.Clear();
                txtDesc.Clear();
                txtGenre.Clear();
                txtSection.Clear();
                txtISBN.Clear();
            }
            if (error == 1)
            {
                MessageBox.Show("Книга с таким ISBN уже сущетсвует!", "Ошибка", MessageBoxButtons.OK);
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
