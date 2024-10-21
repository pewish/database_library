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
    public partial class _CreatePublisherForm : Form
    {
        public _CreatePublisherForm()
        {
            InitializeComponent();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAddPub_Click(object sender, EventArgs e)
        {
            int? error = 0;
            LibraryDataSetTableAdapters.QueriesTableAdapter tableAdapter = new LibraryDataSetTableAdapters.QueriesTableAdapter();
            errorProvider1.Clear();
            if (txtName.Text == "")
            {
                errorProvider1.SetError(txtName, "Введите название!");
                return;
            }
            if (txtYear.Text == "")
            {
                errorProvider1.SetError(txtYear, "Введите год основания!");
                return;
            }
            try
            {
                tableAdapter.InsertPub(txtName.Text, Convert.ToInt32(txtYear.Text), ref error);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                throw;
            }
            if (error == 0)
            {
                MessageBox.Show("Издательство добавлено", "Успешно", MessageBoxButtons.OK);
                txtName.Clear();
                txtYear.Clear();
            }
            if (error == 1)
            {
                MessageBox.Show("Такое издательство уже существует!", "Ошибка", MessageBoxButtons.OK);
            }
        }
    }
}
