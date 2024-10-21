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
    public partial class _FireSotrForm : Form
    {
        public _FireSotrForm()
        {
            InitializeComponent();
        }

        private void btnFire_Click(object sender, EventArgs e)
        {
            int? error = 0;
            LibraryDataSetTableAdapters.QueriesTableAdapter tableAdapter = new LibraryDataSetTableAdapters.QueriesTableAdapter();
            errorProvider1.SetError(txtIDsotr, "");
            if (txtIDsotr.Text == "")
            {
                errorProvider1.SetError(txtIDsotr, "Введите ID сотрудника!");
                return;
            }
            try
            {
                tableAdapter.FireSotr(Convert.ToInt32(txtIDsotr.Text), ref error);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                throw;
            }
            if (error == 0)
            {
                MessageBox.Show("Сотрудник уволен", "Успешно", MessageBoxButtons.OK);
            }
            if (error == 1)
            {
                MessageBox.Show("Такого сотрудника не существует!", "Ошибка", MessageBoxButtons.OK);
            }
            if (error == 2)
            {
                MessageBox.Show("Этот сотрудник уже уволен!", "Ошибка", MessageBoxButtons.OK);
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
