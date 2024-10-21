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
    public partial class _CreaterReaderForm : Form
    {
        public _CreaterReaderForm()
        {
            InitializeComponent();
        }

        private void _CreaterReaderForm_Load(object sender, EventArgs e)
        {

        }

        private void btnAddRead_Click(object sender, EventArgs e)
        {
            int? error = 0;
            LibraryDataSetTableAdapters.QueriesTableAdapter tableAdapter = new LibraryDataSetTableAdapters.QueriesTableAdapter();
            errorProvider1.SetError(txtFIO_reader, "");
            if (txtFIO_reader.Text == "")
            {
                errorProvider1.SetError(txtFIO_reader, "Введите ФИО читателя!");
                return;
            }
            try
            {
                tableAdapter.CreateReader(txtFIO_reader.Text, DateTime.Now, txtNum.Text, ref error);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                throw;
            }
            if (error == 0)
            {
                MessageBox.Show("Читатель добавлен", "Успешно", MessageBoxButtons.OK);
            }
            if (error == 1)
            {
                MessageBox.Show("Такой читатель уже существует!", "Ошибка", MessageBoxButtons.OK);
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
