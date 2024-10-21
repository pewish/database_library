namespace Library
{
    partial class SpecialistForm
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabBook = new System.Windows.Forms.TabPage();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.idbookDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.booknameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.authorDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.publisherDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.publicyearDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descriptionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.genreDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sectionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iSBNDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.availabilityDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bookBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.libraryDataSet = new Library.LibraryDataSet();
            this.tabPub = new System.Windows.Forms.TabPage();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.idpublisherDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.namepublisherDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.yearfoundDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.publisherBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tabValuedBooks = new System.Windows.Forms.TabPage();
            this.dataGridView3 = new System.Windows.Forms.DataGridView();
            this.idbookDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.booknameDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.authorDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.publisherDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.publicyearDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.availabilityDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iSBNDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.valuedBookBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.btnAddBook = new System.Windows.Forms.Button();
            this.btnDelBook = new System.Windows.Forms.Button();
            this.btnAddPub = new System.Windows.Forms.Button();
            this.btnDelPub = new System.Windows.Forms.Button();
            this.btnSearch = new System.Windows.Forms.Button();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnClear = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.bookTableAdapter = new Library.LibraryDataSetTableAdapters.BookTableAdapter();
            this.publisherTableAdapter = new Library.LibraryDataSetTableAdapters.PublisherTableAdapter();
            this.valuedBookTableAdapter = new Library.LibraryDataSetTableAdapters.ValuedBookTableAdapter();
            this.btnExit = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.tabBook.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bookBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.libraryDataSet)).BeginInit();
            this.tabPub.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.publisherBindingSource)).BeginInit();
            this.tabValuedBooks.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.valuedBookBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabBook);
            this.tabControl1.Controls.Add(this.tabPub);
            this.tabControl1.Controls.Add(this.tabValuedBooks);
            this.tabControl1.Location = new System.Drawing.Point(2, 190);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(871, 333);
            this.tabControl1.TabIndex = 0;
            // 
            // tabBook
            // 
            this.tabBook.Controls.Add(this.dataGridView1);
            this.tabBook.Location = new System.Drawing.Point(4, 22);
            this.tabBook.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tabBook.Name = "tabBook";
            this.tabBook.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tabBook.Size = new System.Drawing.Size(863, 307);
            this.tabBook.TabIndex = 0;
            this.tabBook.Text = "Книги";
            this.tabBook.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idbookDataGridViewTextBoxColumn,
            this.booknameDataGridViewTextBoxColumn,
            this.authorDataGridViewTextBoxColumn,
            this.publisherDataGridViewTextBoxColumn,
            this.publicyearDataGridViewTextBoxColumn,
            this.descriptionDataGridViewTextBoxColumn,
            this.genreDataGridViewTextBoxColumn,
            this.sectionDataGridViewTextBoxColumn,
            this.iSBNDataGridViewTextBoxColumn,
            this.availabilityDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.bookBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(868, 498);
            this.dataGridView1.TabIndex = 0;
            // 
            // idbookDataGridViewTextBoxColumn
            // 
            this.idbookDataGridViewTextBoxColumn.DataPropertyName = "id_book";
            this.idbookDataGridViewTextBoxColumn.HeaderText = "id_book";
            this.idbookDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.idbookDataGridViewTextBoxColumn.Name = "idbookDataGridViewTextBoxColumn";
            this.idbookDataGridViewTextBoxColumn.ReadOnly = true;
            this.idbookDataGridViewTextBoxColumn.Width = 125;
            // 
            // booknameDataGridViewTextBoxColumn
            // 
            this.booknameDataGridViewTextBoxColumn.DataPropertyName = "book_name";
            this.booknameDataGridViewTextBoxColumn.HeaderText = "book_name";
            this.booknameDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.booknameDataGridViewTextBoxColumn.Name = "booknameDataGridViewTextBoxColumn";
            this.booknameDataGridViewTextBoxColumn.ReadOnly = true;
            this.booknameDataGridViewTextBoxColumn.Width = 125;
            // 
            // authorDataGridViewTextBoxColumn
            // 
            this.authorDataGridViewTextBoxColumn.DataPropertyName = "author";
            this.authorDataGridViewTextBoxColumn.HeaderText = "author";
            this.authorDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.authorDataGridViewTextBoxColumn.Name = "authorDataGridViewTextBoxColumn";
            this.authorDataGridViewTextBoxColumn.ReadOnly = true;
            this.authorDataGridViewTextBoxColumn.Width = 125;
            // 
            // publisherDataGridViewTextBoxColumn
            // 
            this.publisherDataGridViewTextBoxColumn.DataPropertyName = "publisher";
            this.publisherDataGridViewTextBoxColumn.HeaderText = "publisher";
            this.publisherDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.publisherDataGridViewTextBoxColumn.Name = "publisherDataGridViewTextBoxColumn";
            this.publisherDataGridViewTextBoxColumn.ReadOnly = true;
            this.publisherDataGridViewTextBoxColumn.Width = 125;
            // 
            // publicyearDataGridViewTextBoxColumn
            // 
            this.publicyearDataGridViewTextBoxColumn.DataPropertyName = "public_year";
            this.publicyearDataGridViewTextBoxColumn.HeaderText = "public_year";
            this.publicyearDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.publicyearDataGridViewTextBoxColumn.Name = "publicyearDataGridViewTextBoxColumn";
            this.publicyearDataGridViewTextBoxColumn.ReadOnly = true;
            this.publicyearDataGridViewTextBoxColumn.Width = 125;
            // 
            // descriptionDataGridViewTextBoxColumn
            // 
            this.descriptionDataGridViewTextBoxColumn.DataPropertyName = "description";
            this.descriptionDataGridViewTextBoxColumn.HeaderText = "description";
            this.descriptionDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.descriptionDataGridViewTextBoxColumn.Name = "descriptionDataGridViewTextBoxColumn";
            this.descriptionDataGridViewTextBoxColumn.ReadOnly = true;
            this.descriptionDataGridViewTextBoxColumn.Width = 125;
            // 
            // genreDataGridViewTextBoxColumn
            // 
            this.genreDataGridViewTextBoxColumn.DataPropertyName = "genre";
            this.genreDataGridViewTextBoxColumn.HeaderText = "genre";
            this.genreDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.genreDataGridViewTextBoxColumn.Name = "genreDataGridViewTextBoxColumn";
            this.genreDataGridViewTextBoxColumn.ReadOnly = true;
            this.genreDataGridViewTextBoxColumn.Width = 125;
            // 
            // sectionDataGridViewTextBoxColumn
            // 
            this.sectionDataGridViewTextBoxColumn.DataPropertyName = "section";
            this.sectionDataGridViewTextBoxColumn.HeaderText = "section";
            this.sectionDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.sectionDataGridViewTextBoxColumn.Name = "sectionDataGridViewTextBoxColumn";
            this.sectionDataGridViewTextBoxColumn.ReadOnly = true;
            this.sectionDataGridViewTextBoxColumn.Width = 125;
            // 
            // iSBNDataGridViewTextBoxColumn
            // 
            this.iSBNDataGridViewTextBoxColumn.DataPropertyName = "ISBN";
            this.iSBNDataGridViewTextBoxColumn.HeaderText = "ISBN";
            this.iSBNDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.iSBNDataGridViewTextBoxColumn.Name = "iSBNDataGridViewTextBoxColumn";
            this.iSBNDataGridViewTextBoxColumn.ReadOnly = true;
            this.iSBNDataGridViewTextBoxColumn.Width = 125;
            // 
            // availabilityDataGridViewTextBoxColumn
            // 
            this.availabilityDataGridViewTextBoxColumn.DataPropertyName = "availability";
            this.availabilityDataGridViewTextBoxColumn.HeaderText = "availability";
            this.availabilityDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.availabilityDataGridViewTextBoxColumn.Name = "availabilityDataGridViewTextBoxColumn";
            this.availabilityDataGridViewTextBoxColumn.ReadOnly = true;
            this.availabilityDataGridViewTextBoxColumn.Width = 125;
            // 
            // bookBindingSource
            // 
            this.bookBindingSource.DataMember = "Book";
            this.bookBindingSource.DataSource = this.libraryDataSet;
            // 
            // libraryDataSet
            // 
            this.libraryDataSet.DataSetName = "LibraryDataSet";
            this.libraryDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tabPub
            // 
            this.tabPub.Controls.Add(this.dataGridView2);
            this.tabPub.Location = new System.Drawing.Point(4, 22);
            this.tabPub.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tabPub.Name = "tabPub";
            this.tabPub.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tabPub.Size = new System.Drawing.Size(863, 307);
            this.tabPub.TabIndex = 1;
            this.tabPub.Text = "Издательства";
            this.tabPub.UseVisualStyleBackColor = true;
            // 
            // dataGridView2
            // 
            this.dataGridView2.AllowUserToAddRows = false;
            this.dataGridView2.AllowUserToDeleteRows = false;
            this.dataGridView2.AutoGenerateColumns = false;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idpublisherDataGridViewTextBoxColumn,
            this.namepublisherDataGridViewTextBoxColumn,
            this.yearfoundDataGridViewTextBoxColumn});
            this.dataGridView2.DataSource = this.publisherBindingSource;
            this.dataGridView2.Location = new System.Drawing.Point(0, 0);
            this.dataGridView2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.ReadOnly = true;
            this.dataGridView2.RowHeadersWidth = 51;
            this.dataGridView2.RowTemplate.Height = 24;
            this.dataGridView2.Size = new System.Drawing.Size(862, 498);
            this.dataGridView2.TabIndex = 0;
            // 
            // idpublisherDataGridViewTextBoxColumn
            // 
            this.idpublisherDataGridViewTextBoxColumn.DataPropertyName = "id_publisher";
            this.idpublisherDataGridViewTextBoxColumn.HeaderText = "id_publisher";
            this.idpublisherDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.idpublisherDataGridViewTextBoxColumn.Name = "idpublisherDataGridViewTextBoxColumn";
            this.idpublisherDataGridViewTextBoxColumn.ReadOnly = true;
            this.idpublisherDataGridViewTextBoxColumn.Width = 125;
            // 
            // namepublisherDataGridViewTextBoxColumn
            // 
            this.namepublisherDataGridViewTextBoxColumn.DataPropertyName = "name_publisher";
            this.namepublisherDataGridViewTextBoxColumn.HeaderText = "name_publisher";
            this.namepublisherDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.namepublisherDataGridViewTextBoxColumn.Name = "namepublisherDataGridViewTextBoxColumn";
            this.namepublisherDataGridViewTextBoxColumn.ReadOnly = true;
            this.namepublisherDataGridViewTextBoxColumn.Width = 125;
            // 
            // yearfoundDataGridViewTextBoxColumn
            // 
            this.yearfoundDataGridViewTextBoxColumn.DataPropertyName = "year_found";
            this.yearfoundDataGridViewTextBoxColumn.HeaderText = "year_found";
            this.yearfoundDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.yearfoundDataGridViewTextBoxColumn.Name = "yearfoundDataGridViewTextBoxColumn";
            this.yearfoundDataGridViewTextBoxColumn.ReadOnly = true;
            this.yearfoundDataGridViewTextBoxColumn.Width = 125;
            // 
            // publisherBindingSource
            // 
            this.publisherBindingSource.DataMember = "Publisher";
            this.publisherBindingSource.DataSource = this.libraryDataSet;
            // 
            // tabValuedBooks
            // 
            this.tabValuedBooks.Controls.Add(this.dataGridView3);
            this.tabValuedBooks.Location = new System.Drawing.Point(4, 22);
            this.tabValuedBooks.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tabValuedBooks.Name = "tabValuedBooks";
            this.tabValuedBooks.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tabValuedBooks.Size = new System.Drawing.Size(863, 307);
            this.tabValuedBooks.TabIndex = 2;
            this.tabValuedBooks.Text = "Ценные издания";
            this.tabValuedBooks.UseVisualStyleBackColor = true;
            // 
            // dataGridView3
            // 
            this.dataGridView3.AllowUserToAddRows = false;
            this.dataGridView3.AllowUserToDeleteRows = false;
            this.dataGridView3.AutoGenerateColumns = false;
            this.dataGridView3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView3.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idbookDataGridViewTextBoxColumn1,
            this.booknameDataGridViewTextBoxColumn1,
            this.authorDataGridViewTextBoxColumn1,
            this.publisherDataGridViewTextBoxColumn1,
            this.publicyearDataGridViewTextBoxColumn1,
            this.availabilityDataGridViewTextBoxColumn1,
            this.iSBNDataGridViewTextBoxColumn1});
            this.dataGridView3.DataSource = this.valuedBookBindingSource;
            this.dataGridView3.Location = new System.Drawing.Point(0, 0);
            this.dataGridView3.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dataGridView3.Name = "dataGridView3";
            this.dataGridView3.ReadOnly = true;
            this.dataGridView3.RowHeadersWidth = 51;
            this.dataGridView3.RowTemplate.Height = 24;
            this.dataGridView3.Size = new System.Drawing.Size(862, 498);
            this.dataGridView3.TabIndex = 0;
            // 
            // idbookDataGridViewTextBoxColumn1
            // 
            this.idbookDataGridViewTextBoxColumn1.DataPropertyName = "id_book";
            this.idbookDataGridViewTextBoxColumn1.HeaderText = "id_book";
            this.idbookDataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.idbookDataGridViewTextBoxColumn1.Name = "idbookDataGridViewTextBoxColumn1";
            this.idbookDataGridViewTextBoxColumn1.ReadOnly = true;
            this.idbookDataGridViewTextBoxColumn1.Width = 125;
            // 
            // booknameDataGridViewTextBoxColumn1
            // 
            this.booknameDataGridViewTextBoxColumn1.DataPropertyName = "book_name";
            this.booknameDataGridViewTextBoxColumn1.HeaderText = "book_name";
            this.booknameDataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.booknameDataGridViewTextBoxColumn1.Name = "booknameDataGridViewTextBoxColumn1";
            this.booknameDataGridViewTextBoxColumn1.ReadOnly = true;
            this.booknameDataGridViewTextBoxColumn1.Width = 125;
            // 
            // authorDataGridViewTextBoxColumn1
            // 
            this.authorDataGridViewTextBoxColumn1.DataPropertyName = "author";
            this.authorDataGridViewTextBoxColumn1.HeaderText = "author";
            this.authorDataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.authorDataGridViewTextBoxColumn1.Name = "authorDataGridViewTextBoxColumn1";
            this.authorDataGridViewTextBoxColumn1.ReadOnly = true;
            this.authorDataGridViewTextBoxColumn1.Width = 125;
            // 
            // publisherDataGridViewTextBoxColumn1
            // 
            this.publisherDataGridViewTextBoxColumn1.DataPropertyName = "publisher";
            this.publisherDataGridViewTextBoxColumn1.HeaderText = "publisher";
            this.publisherDataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.publisherDataGridViewTextBoxColumn1.Name = "publisherDataGridViewTextBoxColumn1";
            this.publisherDataGridViewTextBoxColumn1.ReadOnly = true;
            this.publisherDataGridViewTextBoxColumn1.Width = 125;
            // 
            // publicyearDataGridViewTextBoxColumn1
            // 
            this.publicyearDataGridViewTextBoxColumn1.DataPropertyName = "public_year";
            this.publicyearDataGridViewTextBoxColumn1.HeaderText = "public_year";
            this.publicyearDataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.publicyearDataGridViewTextBoxColumn1.Name = "publicyearDataGridViewTextBoxColumn1";
            this.publicyearDataGridViewTextBoxColumn1.ReadOnly = true;
            this.publicyearDataGridViewTextBoxColumn1.Width = 125;
            // 
            // availabilityDataGridViewTextBoxColumn1
            // 
            this.availabilityDataGridViewTextBoxColumn1.DataPropertyName = "availability";
            this.availabilityDataGridViewTextBoxColumn1.HeaderText = "availability";
            this.availabilityDataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.availabilityDataGridViewTextBoxColumn1.Name = "availabilityDataGridViewTextBoxColumn1";
            this.availabilityDataGridViewTextBoxColumn1.ReadOnly = true;
            this.availabilityDataGridViewTextBoxColumn1.Width = 125;
            // 
            // iSBNDataGridViewTextBoxColumn1
            // 
            this.iSBNDataGridViewTextBoxColumn1.DataPropertyName = "ISBN";
            this.iSBNDataGridViewTextBoxColumn1.HeaderText = "ISBN";
            this.iSBNDataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.iSBNDataGridViewTextBoxColumn1.Name = "iSBNDataGridViewTextBoxColumn1";
            this.iSBNDataGridViewTextBoxColumn1.ReadOnly = true;
            this.iSBNDataGridViewTextBoxColumn1.Width = 125;
            // 
            // valuedBookBindingSource
            // 
            this.valuedBookBindingSource.DataMember = "ValuedBook";
            this.valuedBookBindingSource.DataSource = this.libraryDataSet;
            // 
            // btnAddBook
            // 
            this.btnAddBook.Location = new System.Drawing.Point(8, 24);
            this.btnAddBook.Name = "btnAddBook";
            this.btnAddBook.Size = new System.Drawing.Size(108, 23);
            this.btnAddBook.TabIndex = 1;
            this.btnAddBook.Text = "Добавить книгу";
            this.btnAddBook.UseVisualStyleBackColor = true;
            this.btnAddBook.Click += new System.EventHandler(this.btnAddBook_Click);
            // 
            // btnDelBook
            // 
            this.btnDelBook.Location = new System.Drawing.Point(273, 24);
            this.btnDelBook.Name = "btnDelBook";
            this.btnDelBook.Size = new System.Drawing.Size(100, 23);
            this.btnDelBook.TabIndex = 2;
            this.btnDelBook.Text = "Удалить книгу";
            this.btnDelBook.UseVisualStyleBackColor = true;
            // 
            // btnAddPub
            // 
            this.btnAddPub.Location = new System.Drawing.Point(126, 24);
            this.btnAddPub.Name = "btnAddPub";
            this.btnAddPub.Size = new System.Drawing.Size(140, 23);
            this.btnAddPub.TabIndex = 3;
            this.btnAddPub.Text = "Добавить издательство";
            this.btnAddPub.UseVisualStyleBackColor = true;
            this.btnAddPub.Click += new System.EventHandler(this.btnAddPub_Click);
            // 
            // btnDelPub
            // 
            this.btnDelPub.Location = new System.Drawing.Point(379, 24);
            this.btnDelPub.Name = "btnDelPub";
            this.btnDelPub.Size = new System.Drawing.Size(140, 23);
            this.btnDelPub.TabIndex = 4;
            this.btnDelPub.Text = "Удалить издательство";
            this.btnDelPub.UseVisualStyleBackColor = true;
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(377, 154);
            this.btnSearch.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(56, 19);
            this.btnSearch.TabIndex = 5;
            this.btnSearch.Text = "Найти";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(47, 154);
            this.txtSearch.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(326, 20);
            this.txtSearch.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(5, 157);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Поиск:";
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(438, 154);
            this.btnClear.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(98, 19);
            this.btnClear.TabIndex = 8;
            this.btnClear.Text = "Показать все";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // bookTableAdapter
            // 
            this.bookTableAdapter.ClearBeforeFill = true;
            // 
            // publisherTableAdapter
            // 
            this.publisherTableAdapter.ClearBeforeFill = true;
            // 
            // valuedBookTableAdapter
            // 
            this.valuedBookTableAdapter.ClearBeforeFill = true;
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(784, 24);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 23);
            this.btnExit.TabIndex = 9;
            this.btnExit.Text = "Выход";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // SpecialistForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(871, 502);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.btnDelPub);
            this.Controls.Add(this.btnAddPub);
            this.Controls.Add(this.btnDelBook);
            this.Controls.Add(this.btnAddBook);
            this.Controls.Add(this.tabControl1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "SpecialistForm";
            this.Text = "Специалист по учётно-хранительской деятельности";
            this.Load += new System.EventHandler(this.SpecialistForm_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabBook.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bookBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.libraryDataSet)).EndInit();
            this.tabPub.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.publisherBindingSource)).EndInit();
            this.tabValuedBooks.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.valuedBookBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabBook;
        private System.Windows.Forms.TabPage tabPub;
        private System.Windows.Forms.TabPage tabValuedBooks;
        private System.Windows.Forms.Button btnAddBook;
        private System.Windows.Forms.Button btnDelBook;
        private System.Windows.Forms.Button btnAddPub;
        private System.Windows.Forms.Button btnDelPub;
        private LibraryDataSet libraryDataSet;
        private LibraryDataSetTableAdapters.BookTableAdapter bookTableAdapter;
        private LibraryDataSetTableAdapters.PublisherTableAdapter publisherTableAdapter;
        private LibraryDataSetTableAdapters.ValuedBookTableAdapter valuedBookTableAdapter;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn idbookDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn booknameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn authorDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn publisherDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn publicyearDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn descriptionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn genreDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sectionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iSBNDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn availabilityDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource bookBindingSource;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.DataGridViewTextBoxColumn idpublisherDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn namepublisherDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn yearfoundDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource publisherBindingSource;
        private System.Windows.Forms.DataGridView dataGridView3;
        private System.Windows.Forms.DataGridViewTextBoxColumn idbookDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn booknameDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn authorDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn publisherDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn publicyearDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn availabilityDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn iSBNDataGridViewTextBoxColumn1;
        private System.Windows.Forms.BindingSource valuedBookBindingSource;
        private System.Windows.Forms.Button btnExit;
    }
}