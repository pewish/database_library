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
    public partial class DirectorForm : Form
    {
        public DirectorForm()
        {
            InitializeComponent();
        }

        private void btnCreateSotr_Click(object sender, EventArgs e)
        {
            _CreateSotrForm newForm = new _CreateSotrForm();
            newForm.Show();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
            LoginForm newForm = new LoginForm();
            newForm.Show();
        }

        private void btnFind_Click(object sender, EventArgs e)
        {
            errorProvider1.Clear();
            if (txtSearch.Text == "")
            {
                errorProvider1.SetError(txtSearch, "Введите ФИО!");
                return;
            }
                dataGridView1.DataSource = sotrTableAdapter.GetSotr(txtSearch.Text);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            txtSearch.Clear();
        }

        private void btnDeleteSotr_Click(object sender, EventArgs e)
        {
            _FireSotrForm newForm = new _FireSotrForm();
            newForm.Show();
        }
    }
}
