namespace Library
{
    partial class _CreateSotrForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.dateBDAYsotr = new System.Windows.Forms.DateTimePicker();
            this.txtFIOsotr = new System.Windows.Forms.TextBox();
            this.txtPhoneSotr = new System.Windows.Forms.TextBox();
            this.txtEmailSotr = new System.Windows.Forms.TextBox();
            this.txtStaz = new System.Windows.Forms.TextBox();
            this.btnAddNewSotr = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.sotrBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.libraryDataSet = new Library.LibraryDataSet();
            this.sotrTableAdapter = new Library.LibraryDataSetTableAdapters.SotrTableAdapter();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.sotrBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.libraryDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(31, 52);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Ф.И.О.";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(31, 114);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(133, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Дата рождения";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(42, 192);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "Стаж";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(-1, 257);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(95, 20);
            this.label5.TabIndex = 4;
            this.label5.Text = "Должность";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(687, 145);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(77, 20);
            this.label6.TabIndex = 5;
            this.label6.Text = "Телефон";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(709, 223);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(58, 20);
            this.label7.TabIndex = 6;
            this.label7.Text = "Почта";
            // 
            // dateBDAYsotr
            // 
            this.dateBDAYsotr.Location = new System.Drawing.Point(170, 114);
            this.dateBDAYsotr.Name = "dateBDAYsotr";
            this.dateBDAYsotr.Size = new System.Drawing.Size(237, 26);
            this.dateBDAYsotr.TabIndex = 9;
            // 
            // txtFIOsotr
            // 
            this.txtFIOsotr.Location = new System.Drawing.Point(100, 52);
            this.txtFIOsotr.Name = "txtFIOsotr";
            this.txtFIOsotr.Size = new System.Drawing.Size(456, 26);
            this.txtFIOsotr.TabIndex = 8;
            // 
            // txtPhoneSotr
            // 
            this.txtPhoneSotr.Location = new System.Drawing.Point(788, 142);
            this.txtPhoneSotr.Name = "txtPhoneSotr";
            this.txtPhoneSotr.Size = new System.Drawing.Size(299, 26);
            this.txtPhoneSotr.TabIndex = 10;
            // 
            // txtEmailSotr
            // 
            this.txtEmailSotr.Location = new System.Drawing.Point(788, 220);
            this.txtEmailSotr.Name = "txtEmailSotr";
            this.txtEmailSotr.Size = new System.Drawing.Size(299, 26);
            this.txtEmailSotr.TabIndex = 11;
            // 
            // txtStaz
            // 
            this.txtStaz.Location = new System.Drawing.Point(100, 189);
            this.txtStaz.Name = "txtStaz";
            this.txtStaz.Size = new System.Drawing.Size(237, 26);
            this.txtStaz.TabIndex = 12;
            // 
            // btnAddNewSotr
            // 
            this.btnAddNewSotr.Location = new System.Drawing.Point(799, 12);
            this.btnAddNewSotr.Name = "btnAddNewSotr";
            this.btnAddNewSotr.Size = new System.Drawing.Size(120, 44);
            this.btnAddNewSotr.TabIndex = 16;
            this.btnAddNewSotr.Text = "Добавить";
            this.btnAddNewSotr.UseVisualStyleBackColor = true;
            this.btnAddNewSotr.Click += new System.EventHandler(this.btnAddNewSotr_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(967, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(120, 44);
            this.button1.TabIndex = 17;
            this.button1.Text = "Назад";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.DataSource = this.sotrBindingSource;
            this.comboBox1.DisplayMember = "position";
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(100, 254);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(237, 28);
            this.comboBox1.TabIndex = 18;
            // 
            // sotrBindingSource
            // 
            this.sotrBindingSource.DataMember = "Sotr";
            this.sotrBindingSource.DataSource = this.libraryDataSet;
            // 
            // libraryDataSet
            // 
            this.libraryDataSet.DataSetName = "LibraryDataSet";
            this.libraryDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // sotrTableAdapter
            // 
            this.sotrTableAdapter.ClearBeforeFill = true;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // _CreateSotrForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1099, 614);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnAddNewSotr);
            this.Controls.Add(this.txtStaz);
            this.Controls.Add(this.txtEmailSotr);
            this.Controls.Add(this.txtPhoneSotr);
            this.Controls.Add(this.dateBDAYsotr);
            this.Controls.Add(this.txtFIOsotr);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Font = new System.Drawing.Font("Bookman Old Style", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.Name = "_CreateSotrForm";
            this.Text = "Создать сотрудника";
            this.Load += new System.EventHandler(this._CreateSotrForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.sotrBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.libraryDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DateTimePicker dateBDAYsotr;
        private System.Windows.Forms.TextBox txtFIOsotr;
        private System.Windows.Forms.TextBox txtPhoneSotr;
        private System.Windows.Forms.TextBox txtEmailSotr;
        private System.Windows.Forms.TextBox txtStaz;
        private System.Windows.Forms.Button btnAddNewSotr;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox comboBox1;
        private LibraryDataSet libraryDataSet;
        private System.Windows.Forms.BindingSource sotrBindingSource;
        private LibraryDataSetTableAdapters.SotrTableAdapter sotrTableAdapter;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}