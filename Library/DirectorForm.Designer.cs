namespace Library
{
    partial class DirectorForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DirectorForm));
            this.tabDirect = new System.Windows.Forms.TabControl();
            this.tabSotr = new System.Windows.Forms.TabPage();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnDeleteSotr = new System.Windows.Forms.Button();
            this.btnUpdateSotr = new System.Windows.Forms.Button();
            this.btnFind = new System.Windows.Forms.Button();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridSotr = new System.Windows.Forms.DataGridView();
            this.sotrBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.libraryDataSet = new Library.LibraryDataSet();
            this.btnCreateSotr = new System.Windows.Forms.Button();
            this.tabRead = new System.Windows.Forms.TabPage();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.idreaderDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fIOreaderDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.birthdayDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.numphoneDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.readerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.libraryDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.txtFindReader = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.sotrTableAdapter = new Library.LibraryDataSetTableAdapters.SotrTableAdapter();
            this.readerTableAdapter = new Library.LibraryDataSetTableAdapters.ReaderTableAdapter();
            this.button1 = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.idsotrDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fIOsotrDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bdayDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.experienceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.positionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.phonenumDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.emailDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.firedDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabDirect.SuspendLayout();
            this.tabSotr.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridSotr)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sotrBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.libraryDataSet)).BeginInit();
            this.tabRead.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.readerBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.libraryDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // tabDirect
            // 
            this.tabDirect.Controls.Add(this.tabSotr);
            this.tabDirect.Controls.Add(this.tabRead);
            this.tabDirect.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabDirect.Font = new System.Drawing.Font("Bookman Old Style", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tabDirect.Location = new System.Drawing.Point(0, 0);
            this.tabDirect.Margin = new System.Windows.Forms.Padding(2);
            this.tabDirect.Name = "tabDirect";
            this.tabDirect.SelectedIndex = 0;
            this.tabDirect.Size = new System.Drawing.Size(965, 586);
            this.tabDirect.TabIndex = 0;
            // 
            // tabSotr
            // 
            this.tabSotr.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("tabSotr.BackgroundImage")));
            this.tabSotr.Controls.Add(this.button1);
            this.tabSotr.Controls.Add(this.btnExit);
            this.tabSotr.Controls.Add(this.btnDeleteSotr);
            this.tabSotr.Controls.Add(this.btnUpdateSotr);
            this.tabSotr.Controls.Add(this.btnFind);
            this.tabSotr.Controls.Add(this.txtSearch);
            this.tabSotr.Controls.Add(this.label1);
            this.tabSotr.Controls.Add(this.dataGridSotr);
            this.tabSotr.Controls.Add(this.btnCreateSotr);
            this.tabSotr.Font = new System.Drawing.Font("Bookman Old Style", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tabSotr.Location = new System.Drawing.Point(4, 29);
            this.tabSotr.Margin = new System.Windows.Forms.Padding(2);
            this.tabSotr.Name = "tabSotr";
            this.tabSotr.Padding = new System.Windows.Forms.Padding(2);
            this.tabSotr.Size = new System.Drawing.Size(957, 553);
            this.tabSotr.TabIndex = 0;
            this.tabSotr.Text = "Сотрудники";
            this.tabSotr.UseVisualStyleBackColor = true;
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(877, 5);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 34);
            this.btnExit.TabIndex = 7;
            this.btnExit.Text = "Выход";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnDeleteSotr
            // 
            this.btnDeleteSotr.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDeleteSotr.AutoSize = true;
            this.btnDeleteSotr.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(188)))), ((int)(((byte)(108)))), ((int)(((byte)(37)))));
            this.btnDeleteSotr.Font = new System.Drawing.Font("Bookman Old Style", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnDeleteSotr.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(250)))), ((int)(((byte)(223)))));
            this.btnDeleteSotr.Location = new System.Drawing.Point(554, 5);
            this.btnDeleteSotr.Margin = new System.Windows.Forms.Padding(2);
            this.btnDeleteSotr.MaximumSize = new System.Drawing.Size(262, 28);
            this.btnDeleteSotr.MinimumSize = new System.Drawing.Size(210, 28);
            this.btnDeleteSotr.Name = "btnDeleteSotr";
            this.btnDeleteSotr.Size = new System.Drawing.Size(210, 28);
            this.btnDeleteSotr.TabIndex = 6;
            this.btnDeleteSotr.Text = "Уволить сотрудника";
            this.btnDeleteSotr.UseVisualStyleBackColor = false;
            this.btnDeleteSotr.Click += new System.EventHandler(this.btnDeleteSotr_Click);
            // 
            // btnUpdateSotr
            // 
            this.btnUpdateSotr.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnUpdateSotr.AutoSize = true;
            this.btnUpdateSotr.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(188)))), ((int)(((byte)(108)))), ((int)(((byte)(37)))));
            this.btnUpdateSotr.Font = new System.Drawing.Font("Bookman Old Style", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnUpdateSotr.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(250)))), ((int)(((byte)(223)))));
            this.btnUpdateSotr.Location = new System.Drawing.Point(280, 5);
            this.btnUpdateSotr.Margin = new System.Windows.Forms.Padding(2);
            this.btnUpdateSotr.MaximumSize = new System.Drawing.Size(262, 28);
            this.btnUpdateSotr.MinimumSize = new System.Drawing.Size(236, 28);
            this.btnUpdateSotr.Name = "btnUpdateSotr";
            this.btnUpdateSotr.Size = new System.Drawing.Size(262, 28);
            this.btnUpdateSotr.TabIndex = 5;
            this.btnUpdateSotr.Text = "Редактировать сотрудника";
            this.btnUpdateSotr.UseVisualStyleBackColor = false;
            // 
            // btnFind
            // 
            this.btnFind.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnFind.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(188)))), ((int)(((byte)(108)))), ((int)(((byte)(37)))));
            this.btnFind.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(250)))), ((int)(((byte)(223)))));
            this.btnFind.Location = new System.Drawing.Point(510, 135);
            this.btnFind.Margin = new System.Windows.Forms.Padding(2);
            this.btnFind.MaximumSize = new System.Drawing.Size(120, 32);
            this.btnFind.MinimumSize = new System.Drawing.Size(110, 32);
            this.btnFind.Name = "btnFind";
            this.btnFind.Size = new System.Drawing.Size(120, 32);
            this.btnFind.TabIndex = 4;
            this.btnFind.Text = "Найти";
            this.btnFind.UseVisualStyleBackColor = false;
            this.btnFind.Click += new System.EventHandler(this.btnFind_Click);
            // 
            // txtSearch
            // 
            this.txtSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtSearch.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(188)))), ((int)(((byte)(108)))), ((int)(((byte)(37)))));
            this.txtSearch.Location = new System.Drawing.Point(147, 135);
            this.txtSearch.Margin = new System.Windows.Forms.Padding(2);
            this.txtSearch.MaximumSize = new System.Drawing.Size(400, 31);
            this.txtSearch.MinimumSize = new System.Drawing.Size(256, 31);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(341, 31);
            this.txtSearch.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(188)))), ((int)(((byte)(108)))), ((int)(((byte)(37)))));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(250)))), ((int)(((byte)(223)))));
            this.label1.Location = new System.Drawing.Point(7, 141);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(136, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Введите Ф.И.О.";
            // 
            // dataGridSotr
            // 
            this.dataGridSotr.AllowUserToAddRows = false;
            this.dataGridSotr.AllowUserToDeleteRows = false;
            this.dataGridSotr.AutoGenerateColumns = false;
            this.dataGridSotr.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(108)))), ((int)(((byte)(55)))));
            this.dataGridSotr.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dataGridSotr.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridSotr.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idsotrDataGridViewTextBoxColumn,
            this.fIOsotrDataGridViewTextBoxColumn,
            this.bdayDataGridViewTextBoxColumn,
            this.experienceDataGridViewTextBoxColumn,
            this.positionDataGridViewTextBoxColumn,
            this.phonenumDataGridViewTextBoxColumn,
            this.emailDataGridViewTextBoxColumn,
            this.firedDataGridViewTextBoxColumn});
            this.dataGridSotr.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dataGridSotr.DataSource = this.sotrBindingSource;
            this.dataGridSotr.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(54)))), ((int)(((byte)(23)))));
            this.dataGridSotr.Location = new System.Drawing.Point(0, 180);
            this.dataGridSotr.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridSotr.Name = "dataGridSotr";
            this.dataGridSotr.ReadOnly = true;
            this.dataGridSotr.RowHeadersWidth = 51;
            this.dataGridSotr.RowTemplate.Height = 24;
            this.dataGridSotr.Size = new System.Drawing.Size(959, 370);
            this.dataGridSotr.TabIndex = 1;
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
            // btnCreateSotr
            // 
            this.btnCreateSotr.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCreateSotr.AutoSize = true;
            this.btnCreateSotr.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(188)))), ((int)(((byte)(108)))), ((int)(((byte)(37)))));
            this.btnCreateSotr.Font = new System.Drawing.Font("Bookman Old Style", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnCreateSotr.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(250)))), ((int)(((byte)(223)))));
            this.btnCreateSotr.Location = new System.Drawing.Point(6, 5);
            this.btnCreateSotr.Margin = new System.Windows.Forms.Padding(2);
            this.btnCreateSotr.MaximumSize = new System.Drawing.Size(262, 28);
            this.btnCreateSotr.MinimumSize = new System.Drawing.Size(236, 28);
            this.btnCreateSotr.Name = "btnCreateSotr";
            this.btnCreateSotr.Size = new System.Drawing.Size(262, 28);
            this.btnCreateSotr.TabIndex = 0;
            this.btnCreateSotr.Text = "Добавить нового сотрудника";
            this.btnCreateSotr.UseVisualStyleBackColor = false;
            this.btnCreateSotr.Click += new System.EventHandler(this.btnCreateSotr_Click);
            // 
            // tabRead
            // 
            this.tabRead.Controls.Add(this.dataGridView1);
            this.tabRead.Controls.Add(this.txtFindReader);
            this.tabRead.Controls.Add(this.label2);
            this.tabRead.Location = new System.Drawing.Point(4, 29);
            this.tabRead.Margin = new System.Windows.Forms.Padding(2);
            this.tabRead.Name = "tabRead";
            this.tabRead.Padding = new System.Windows.Forms.Padding(2);
            this.tabRead.Size = new System.Drawing.Size(957, 553);
            this.tabRead.TabIndex = 1;
            this.tabRead.Text = "Читатели";
            this.tabRead.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idreaderDataGridViewTextBoxColumn,
            this.fIOreaderDataGridViewTextBoxColumn,
            this.birthdayDataGridViewTextBoxColumn,
            this.numphoneDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.readerBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(9, 167);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(735, 376);
            this.dataGridView1.TabIndex = 9;
            // 
            // idreaderDataGridViewTextBoxColumn
            // 
            this.idreaderDataGridViewTextBoxColumn.DataPropertyName = "id_reader";
            this.idreaderDataGridViewTextBoxColumn.HeaderText = "Номер читательского билета";
            this.idreaderDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.idreaderDataGridViewTextBoxColumn.Name = "idreaderDataGridViewTextBoxColumn";
            this.idreaderDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // fIOreaderDataGridViewTextBoxColumn
            // 
            this.fIOreaderDataGridViewTextBoxColumn.DataPropertyName = "FIOreader";
            this.fIOreaderDataGridViewTextBoxColumn.HeaderText = "Ф.И.О. читателя";
            this.fIOreaderDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.fIOreaderDataGridViewTextBoxColumn.Name = "fIOreaderDataGridViewTextBoxColumn";
            this.fIOreaderDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // birthdayDataGridViewTextBoxColumn
            // 
            this.birthdayDataGridViewTextBoxColumn.DataPropertyName = "birthday";
            this.birthdayDataGridViewTextBoxColumn.HeaderText = "Дата рождения";
            this.birthdayDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.birthdayDataGridViewTextBoxColumn.Name = "birthdayDataGridViewTextBoxColumn";
            this.birthdayDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // numphoneDataGridViewTextBoxColumn
            // 
            this.numphoneDataGridViewTextBoxColumn.DataPropertyName = "num_phone";
            this.numphoneDataGridViewTextBoxColumn.HeaderText = "Номер телефона";
            this.numphoneDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.numphoneDataGridViewTextBoxColumn.Name = "numphoneDataGridViewTextBoxColumn";
            this.numphoneDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // readerBindingSource
            // 
            this.readerBindingSource.DataMember = "Reader";
            this.readerBindingSource.DataSource = this.libraryDataSetBindingSource;
            // 
            // libraryDataSetBindingSource
            // 
            this.libraryDataSetBindingSource.DataSource = this.libraryDataSet;
            this.libraryDataSetBindingSource.Position = 0;
            // 
            // txtFindReader
            // 
            this.txtFindReader.Location = new System.Drawing.Point(69, 130);
            this.txtFindReader.Margin = new System.Windows.Forms.Padding(2);
            this.txtFindReader.Name = "txtFindReader";
            this.txtFindReader.Size = new System.Drawing.Size(340, 26);
            this.txtFindReader.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 132);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Поиск:";
            // 
            // sotrTableAdapter
            // 
            this.sotrTableAdapter.ClearBeforeFill = true;
            // 
            // readerTableAdapter
            // 
            this.readerTableAdapter.ClearBeforeFill = true;
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(188)))), ((int)(((byte)(108)))), ((int)(((byte)(37)))));
            this.button1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(250)))), ((int)(((byte)(223)))));
            this.button1.Location = new System.Drawing.Point(644, 135);
            this.button1.Margin = new System.Windows.Forms.Padding(2);
            this.button1.MaximumSize = new System.Drawing.Size(140, 32);
            this.button1.MinimumSize = new System.Drawing.Size(110, 32);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(140, 32);
            this.button1.TabIndex = 8;
            this.button1.Text = "Показать все";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // idsotrDataGridViewTextBoxColumn
            // 
            this.idsotrDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.idsotrDataGridViewTextBoxColumn.DataPropertyName = "id_sotr";
            this.idsotrDataGridViewTextBoxColumn.HeaderText = "ID сотрудника";
            this.idsotrDataGridViewTextBoxColumn.Name = "idsotrDataGridViewTextBoxColumn";
            this.idsotrDataGridViewTextBoxColumn.ReadOnly = true;
            this.idsotrDataGridViewTextBoxColumn.Width = 137;
            // 
            // fIOsotrDataGridViewTextBoxColumn
            // 
            this.fIOsotrDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.fIOsotrDataGridViewTextBoxColumn.DataPropertyName = "FIO_sotr";
            this.fIOsotrDataGridViewTextBoxColumn.HeaderText = "ФИО сотрудника";
            this.fIOsotrDataGridViewTextBoxColumn.Name = "fIOsotrDataGridViewTextBoxColumn";
            this.fIOsotrDataGridViewTextBoxColumn.ReadOnly = true;
            this.fIOsotrDataGridViewTextBoxColumn.Width = 156;
            // 
            // bdayDataGridViewTextBoxColumn
            // 
            this.bdayDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.bdayDataGridViewTextBoxColumn.DataPropertyName = "bday";
            this.bdayDataGridViewTextBoxColumn.HeaderText = "Дата рождения";
            this.bdayDataGridViewTextBoxColumn.Name = "bdayDataGridViewTextBoxColumn";
            this.bdayDataGridViewTextBoxColumn.ReadOnly = true;
            this.bdayDataGridViewTextBoxColumn.Width = 144;
            // 
            // experienceDataGridViewTextBoxColumn
            // 
            this.experienceDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.experienceDataGridViewTextBoxColumn.DataPropertyName = "experience";
            this.experienceDataGridViewTextBoxColumn.HeaderText = "Стаж";
            this.experienceDataGridViewTextBoxColumn.Name = "experienceDataGridViewTextBoxColumn";
            this.experienceDataGridViewTextBoxColumn.ReadOnly = true;
            this.experienceDataGridViewTextBoxColumn.Width = 77;
            // 
            // positionDataGridViewTextBoxColumn
            // 
            this.positionDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.positionDataGridViewTextBoxColumn.DataPropertyName = "position";
            this.positionDataGridViewTextBoxColumn.HeaderText = "Должность";
            this.positionDataGridViewTextBoxColumn.Name = "positionDataGridViewTextBoxColumn";
            this.positionDataGridViewTextBoxColumn.ReadOnly = true;
            this.positionDataGridViewTextBoxColumn.Width = 120;
            // 
            // phonenumDataGridViewTextBoxColumn
            // 
            this.phonenumDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.phonenumDataGridViewTextBoxColumn.DataPropertyName = "phone_num";
            this.phonenumDataGridViewTextBoxColumn.HeaderText = "Номер телефона";
            this.phonenumDataGridViewTextBoxColumn.Name = "phonenumDataGridViewTextBoxColumn";
            this.phonenumDataGridViewTextBoxColumn.ReadOnly = true;
            this.phonenumDataGridViewTextBoxColumn.Width = 153;
            // 
            // emailDataGridViewTextBoxColumn
            // 
            this.emailDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.emailDataGridViewTextBoxColumn.DataPropertyName = "email";
            this.emailDataGridViewTextBoxColumn.HeaderText = "Почта";
            this.emailDataGridViewTextBoxColumn.Name = "emailDataGridViewTextBoxColumn";
            this.emailDataGridViewTextBoxColumn.ReadOnly = true;
            this.emailDataGridViewTextBoxColumn.Width = 83;
            // 
            // firedDataGridViewTextBoxColumn
            // 
            this.firedDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.firedDataGridViewTextBoxColumn.DataPropertyName = "fired";
            this.firedDataGridViewTextBoxColumn.HeaderText = "Уволен";
            this.firedDataGridViewTextBoxColumn.Name = "firedDataGridViewTextBoxColumn";
            this.firedDataGridViewTextBoxColumn.ReadOnly = true;
            this.firedDataGridViewTextBoxColumn.Width = 91;
            // 
            // DirectorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(965, 586);
            this.Controls.Add(this.tabDirect);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MinimumSize = new System.Drawing.Size(772, 625);
            this.Name = "DirectorForm";
            this.Text = "Директор";
            this.tabDirect.ResumeLayout(false);
            this.tabSotr.ResumeLayout(false);
            this.tabSotr.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridSotr)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sotrBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.libraryDataSet)).EndInit();
            this.tabRead.ResumeLayout(false);
            this.tabRead.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.readerBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.libraryDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabDirect;
        private System.Windows.Forms.TabPage tabSotr;
        private System.Windows.Forms.TabPage tabRead;
        private System.Windows.Forms.BindingSource libraryDataSetBindingSource;
        private LibraryDataSet libraryDataSet;
        private System.Windows.Forms.Button btnCreateSotr;
        private System.Windows.Forms.BindingSource sotrBindingSource;
        private LibraryDataSetTableAdapters.SotrTableAdapter sotrTableAdapter;
        private System.Windows.Forms.DataGridView dataGridSotr;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnFind;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Button btnDeleteSotr;
        private System.Windows.Forms.Button btnUpdateSotr;
        private System.Windows.Forms.TextBox txtFindReader;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource readerBindingSource;
        private LibraryDataSetTableAdapters.ReaderTableAdapter readerTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idreaderDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fIOreaderDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn birthdayDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn numphoneDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.DataGridViewTextBoxColumn idsotrDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fIOsotrDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn bdayDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn experienceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn positionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn phonenumDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn emailDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn firedDataGridViewTextBoxColumn;
    }
}