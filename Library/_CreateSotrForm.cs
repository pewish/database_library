using System;
using System.Windows.Forms;

namespace Library
{
    public partial class _CreateSotrForm : Form
    {
        public _CreateSotrForm()
        {
            InitializeComponent();
            ToolTip help = new ToolTip();
            help.SetToolTip(txtStaz, "Стаж состоит только из цифр");
        }

        private void _CreateSotrForm_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "libraryDataSet.Sotr". При необходимости она может быть перемещена или удалена.
            this.sotrTableAdapter.Fill(this.libraryDataSet.Sotr);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAddNewSotr_Click(object sender, EventArgs e)
        {
            int? error = 0;
            LibraryDataSetTableAdapters.QueriesTableAdapter tableAdapter = new LibraryDataSetTableAdapters.QueriesTableAdapter();
            errorProvider1.SetError(txtFIOsotr, "");
            if (txtFIOsotr.Text == "")
            {
                errorProvider1.SetError(txtFIOsotr, "Введите ФИО сотрудника!");
                return;
            }
            if (txtStaz.Text == "")
            {
                errorProvider1.SetError(txtStaz, "Введите стаж сотрудника!");
                return;
            }
            if (txtPhoneSotr.Text == "")
            {
                errorProvider1.SetError(txtPhoneSotr, "Введите номер телефона сотрудника!");
                return;
            }
            try
            {
                //tableAdapter.CreateReader(txtFIO_reader.Text, DateTime.Now, txtNum.Text, ref error);
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
    }
}
