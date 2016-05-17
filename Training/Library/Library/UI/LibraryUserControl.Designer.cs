﻿namespace Library.UI
{
    partial class LibraryUserControl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.authors = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.titleDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.returnBookPl = new System.Windows.Forms.Panel();
            this.CancelReturnBookBtn = new System.Windows.Forms.Button();
            this.chooseBookLb = new System.Windows.Forms.Label();
            this.returnBookCb = new System.Windows.Forms.ComboBox();
            this.okReturnBookBtn = new System.Windows.Forms.Button();
            this.returnBookLb = new System.Windows.Forms.Label();
            this.returnBookBtn = new System.Windows.Forms.Button();
            this.helloLb = new System.Windows.Forms.Label();
            this.addBookBtn = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.booksTable = new System.Windows.Forms.DataGridView();
            this.titleDataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.booksBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.libraryDBContextDataSet = new Library.LibraryDBContextDataSet();
            this.avalableBooksRb = new System.Windows.Forms.RadioButton();
            this.takenBooksRb = new System.Windows.Forms.RadioButton();
            this.allBooksRb = new System.Windows.Forms.RadioButton();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.addBookPl = new System.Windows.Forms.Panel();
            this.addAuthorsTb = new System.Windows.Forms.TextBox();
            this.addNewBook = new System.Windows.Forms.Button();
            this.label13 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.addNewBookLb = new System.Windows.Forms.Label();
            this.addTitleTb = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.avalableDiscrLb = new System.Windows.Forms.Label();
            this.countDiscrLb = new System.Windows.Forms.Label();
            this.removeBtn = new System.Windows.Forms.Button();
            this.ownerDiscrLb = new System.Windows.Forms.Label();
            this.ownerLb = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.authorDiscrLb = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.avalableLb = new System.Windows.Forms.Label();
            this.countLb = new System.Windows.Forms.Label();
            this.takeBtn = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.historyPl = new System.Windows.Forms.Panel();
            this.historyRtb = new System.Windows.Forms.RichTextBox();
            this.historyLb = new System.Windows.Forms.Label();
            this.toJournal = new System.Windows.Forms.Button();
            this.toMenuBtn = new System.Windows.Forms.Button();
            this.booksTableAdapter = new Library.LibraryDBContextDataSetTableAdapters.BooksTableAdapter();
            this.historyBtn = new System.Windows.Forms.Button();
            this.titleDiscrLb = new System.Windows.Forms.Label();
            this.returnBookPl.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.booksTable)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.booksBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.libraryDBContextDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.addBookPl.SuspendLayout();
            this.panel1.SuspendLayout();
            this.historyPl.SuspendLayout();
            this.SuspendLayout();
            // 
            // authors
            // 
            this.authors.DataPropertyName = "Id";
            this.authors.HeaderText = "Author(s)";
            this.authors.Name = "authors";
            this.authors.ReadOnly = true;
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn.HeaderText = "Id";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // titleDataGridViewTextBoxColumn
            // 
            this.titleDataGridViewTextBoxColumn.DataPropertyName = "Title";
            this.titleDataGridViewTextBoxColumn.HeaderText = "Title";
            this.titleDataGridViewTextBoxColumn.Name = "titleDataGridViewTextBoxColumn";
            this.titleDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // returnBookPl
            // 
            this.returnBookPl.BackColor = System.Drawing.Color.DimGray;
            this.returnBookPl.Controls.Add(this.CancelReturnBookBtn);
            this.returnBookPl.Controls.Add(this.chooseBookLb);
            this.returnBookPl.Controls.Add(this.returnBookCb);
            this.returnBookPl.Controls.Add(this.okReturnBookBtn);
            this.returnBookPl.Controls.Add(this.returnBookLb);
            this.returnBookPl.Location = new System.Drawing.Point(514, 209);
            this.returnBookPl.Name = "returnBookPl";
            this.returnBookPl.Size = new System.Drawing.Size(234, 83);
            this.returnBookPl.TabIndex = 22;
            this.returnBookPl.Visible = false;
            // 
            // CancelReturnBookBtn
            // 
            this.CancelReturnBookBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CancelReturnBookBtn.Location = new System.Drawing.Point(26, 54);
            this.CancelReturnBookBtn.Name = "CancelReturnBookBtn";
            this.CancelReturnBookBtn.Size = new System.Drawing.Size(60, 23);
            this.CancelReturnBookBtn.TabIndex = 23;
            this.CancelReturnBookBtn.Text = "Cancel";
            this.CancelReturnBookBtn.UseVisualStyleBackColor = true;
            this.CancelReturnBookBtn.Click += new System.EventHandler(this.CancelReturnBookBtn_Click);
            // 
            // chooseBookLb
            // 
            this.chooseBookLb.AutoSize = true;
            this.chooseBookLb.BackColor = System.Drawing.Color.Transparent;
            this.chooseBookLb.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.chooseBookLb.ForeColor = System.Drawing.SystemColors.Control;
            this.chooseBookLb.Location = new System.Drawing.Point(3, 28);
            this.chooseBookLb.Name = "chooseBookLb";
            this.chooseBookLb.Size = new System.Drawing.Size(100, 16);
            this.chooseBookLb.TabIndex = 22;
            this.chooseBookLb.Text = "Choose a book";
            // 
            // returnBookCb
            // 
            this.returnBookCb.FormattingEnabled = true;
            this.returnBookCb.Location = new System.Drawing.Point(109, 28);
            this.returnBookCb.Name = "returnBookCb";
            this.returnBookCb.Size = new System.Drawing.Size(121, 21);
            this.returnBookCb.TabIndex = 21;
            // 
            // okReturnBookBtn
            // 
            this.okReturnBookBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.okReturnBookBtn.Location = new System.Drawing.Point(141, 54);
            this.okReturnBookBtn.Name = "okReturnBookBtn";
            this.okReturnBookBtn.Size = new System.Drawing.Size(60, 23);
            this.okReturnBookBtn.TabIndex = 20;
            this.okReturnBookBtn.Text = "OK";
            this.okReturnBookBtn.UseVisualStyleBackColor = true;
            this.okReturnBookBtn.Click += new System.EventHandler(this.okReturnBookBtn_Click);
            // 
            // returnBookLb
            // 
            this.returnBookLb.AutoSize = true;
            this.returnBookLb.BackColor = System.Drawing.Color.Transparent;
            this.returnBookLb.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.returnBookLb.ForeColor = System.Drawing.SystemColors.Control;
            this.returnBookLb.Location = new System.Drawing.Point(64, 0);
            this.returnBookLb.Name = "returnBookLb";
            this.returnBookLb.Size = new System.Drawing.Size(110, 20);
            this.returnBookLb.TabIndex = 1;
            this.returnBookLb.Text = "Return a book";
            // 
            // returnBookBtn
            // 
            this.returnBookBtn.BackColor = System.Drawing.SystemColors.Control;
            this.returnBookBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.returnBookBtn.Location = new System.Drawing.Point(632, 358);
            this.returnBookBtn.Name = "returnBookBtn";
            this.returnBookBtn.Size = new System.Drawing.Size(112, 23);
            this.returnBookBtn.TabIndex = 23;
            this.returnBookBtn.Text = "Return a book";
            this.returnBookBtn.UseVisualStyleBackColor = false;
            this.returnBookBtn.Click += new System.EventHandler(this.returnBookBtn_Click);
            // 
            // helloLb
            // 
            this.helloLb.AutoSize = true;
            this.helloLb.BackColor = System.Drawing.Color.Transparent;
            this.helloLb.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.helloLb.ForeColor = System.Drawing.SystemColors.Control;
            this.helloLb.Location = new System.Drawing.Point(585, 6);
            this.helloLb.Name = "helloLb";
            this.helloLb.Size = new System.Drawing.Size(60, 20);
            this.helloLb.TabIndex = 21;
            this.helloLb.Text = "Hello, ";
            // 
            // addBookBtn
            // 
            this.addBookBtn.BackColor = System.Drawing.SystemColors.Control;
            this.addBookBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.addBookBtn.Location = new System.Drawing.Point(90, 122);
            this.addBookBtn.Name = "addBookBtn";
            this.addBookBtn.Size = new System.Drawing.Size(64, 23);
            this.addBookBtn.TabIndex = 22;
            this.addBookBtn.Text = "Add new book";
            this.addBookBtn.UseVisualStyleBackColor = false;
            this.addBookBtn.Click += new System.EventHandler(this.addBookBtn_Click);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.DimGray;
            this.panel3.Controls.Add(this.booksTable);
            this.panel3.Controls.Add(this.avalableBooksRb);
            this.panel3.Controls.Add(this.takenBooksRb);
            this.panel3.Controls.Add(this.allBooksRb);
            this.panel3.Controls.Add(this.dataGridView1);
            this.panel3.Location = new System.Drawing.Point(15, 6);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(483, 297);
            this.panel3.TabIndex = 21;
            // 
            // booksTable
            // 
            this.booksTable.AllowUserToAddRows = false;
            this.booksTable.AllowUserToDeleteRows = false;
            this.booksTable.AutoGenerateColumns = false;
            this.booksTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.booksTable.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.titleDataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn2});
            this.booksTable.DataSource = this.booksBindingSource1;
            this.booksTable.Location = new System.Drawing.Point(3, 28);
            this.booksTable.Name = "booksTable";
            this.booksTable.ReadOnly = true;
            this.booksTable.Size = new System.Drawing.Size(477, 266);
            this.booksTable.TabIndex = 4;
            this.booksTable.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.booksTable_CellClick);
            // 
            // titleDataGridViewTextBoxColumn3
            // 
            this.titleDataGridViewTextBoxColumn3.DataPropertyName = "Title";
            this.titleDataGridViewTextBoxColumn3.HeaderText = "Title";
            this.titleDataGridViewTextBoxColumn3.Name = "titleDataGridViewTextBoxColumn3";
            this.titleDataGridViewTextBoxColumn3.ReadOnly = true;
            this.titleDataGridViewTextBoxColumn3.Width = 200;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "authorDiscription";
            this.dataGridViewTextBoxColumn2.HeaderText = "Author(s)";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            this.dataGridViewTextBoxColumn2.Width = 233;
            // 
            // booksBindingSource1
            // 
            this.booksBindingSource1.DataMember = "Books";
            this.booksBindingSource1.DataSource = this.libraryDBContextDataSet;
            // 
            // libraryDBContextDataSet
            // 
            this.libraryDBContextDataSet.DataSetName = "LibraryDBContextDataSet";
            this.libraryDBContextDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // avalableBooksRb
            // 
            this.avalableBooksRb.AutoSize = true;
            this.avalableBooksRb.Location = new System.Drawing.Point(13, 5);
            this.avalableBooksRb.Name = "avalableBooksRb";
            this.avalableBooksRb.Size = new System.Drawing.Size(98, 17);
            this.avalableBooksRb.TabIndex = 3;
            this.avalableBooksRb.Text = "Avalable books";
            this.avalableBooksRb.UseVisualStyleBackColor = true;
            this.avalableBooksRb.CheckedChanged += new System.EventHandler(this.avalableBooksRb_CheckedChanged);
            // 
            // takenBooksRb
            // 
            this.takenBooksRb.AutoSize = true;
            this.takenBooksRb.Location = new System.Drawing.Point(117, 5);
            this.takenBooksRb.Name = "takenBooksRb";
            this.takenBooksRb.Size = new System.Drawing.Size(88, 17);
            this.takenBooksRb.TabIndex = 2;
            this.takenBooksRb.Text = "Taken books";
            this.takenBooksRb.UseVisualStyleBackColor = true;
            this.takenBooksRb.CheckedChanged += new System.EventHandler(this.takenBooksRb_CheckedChanged);
            // 
            // allBooksRb
            // 
            this.allBooksRb.AutoSize = true;
            this.allBooksRb.Location = new System.Drawing.Point(211, 5);
            this.allBooksRb.Name = "allBooksRb";
            this.allBooksRb.Size = new System.Drawing.Size(68, 17);
            this.allBooksRb.TabIndex = 1;
            this.allBooksRb.Text = "All books";
            this.allBooksRb.UseVisualStyleBackColor = true;
            this.allBooksRb.CheckedChanged += new System.EventHandler(this.allBooksRb_CheckedChanged);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(3, 28);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(477, 266);
            this.dataGridView1.TabIndex = 0;
            // 
            // addBookPl
            // 
            this.addBookPl.BackColor = System.Drawing.Color.DimGray;
            this.addBookPl.Controls.Add(this.addAuthorsTb);
            this.addBookPl.Controls.Add(this.addNewBook);
            this.addBookPl.Controls.Add(this.label13);
            this.addBookPl.Controls.Add(this.label15);
            this.addBookPl.Controls.Add(this.addNewBookLb);
            this.addBookPl.Controls.Add(this.addTitleTb);
            this.addBookPl.Location = new System.Drawing.Point(514, 209);
            this.addBookPl.Name = "addBookPl";
            this.addBookPl.Size = new System.Drawing.Size(234, 115);
            this.addBookPl.TabIndex = 21;
            this.addBookPl.Visible = false;
            // 
            // addAuthorsTb
            // 
            this.addAuthorsTb.Location = new System.Drawing.Point(86, 54);
            this.addAuthorsTb.Name = "addAuthorsTb";
            this.addAuthorsTb.Size = new System.Drawing.Size(145, 20);
            this.addAuthorsTb.TabIndex = 21;
            // 
            // addNewBook
            // 
            this.addNewBook.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.addNewBook.Location = new System.Drawing.Point(86, 89);
            this.addNewBook.Name = "addNewBook";
            this.addNewBook.Size = new System.Drawing.Size(77, 23);
            this.addNewBook.TabIndex = 20;
            this.addNewBook.Text = "OK";
            this.addNewBook.UseVisualStyleBackColor = true;
            this.addNewBook.Click += new System.EventHandler(this.addNewBook_Click);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.BackColor = System.Drawing.Color.Transparent;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label13.ForeColor = System.Drawing.SystemColors.Control;
            this.label13.Location = new System.Drawing.Point(3, 26);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(46, 20);
            this.label13.TabIndex = 14;
            this.label13.Text = "Title: ";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.BackColor = System.Drawing.Color.Transparent;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label15.ForeColor = System.Drawing.SystemColors.Control;
            this.label15.Location = new System.Drawing.Point(3, 52);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(83, 20);
            this.label15.TabIndex = 12;
            this.label15.Text = "Author(s): ";
            // 
            // addNewBookLb
            // 
            this.addNewBookLb.AutoSize = true;
            this.addNewBookLb.BackColor = System.Drawing.Color.Transparent;
            this.addNewBookLb.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.addNewBookLb.ForeColor = System.Drawing.SystemColors.Control;
            this.addNewBookLb.Location = new System.Drawing.Point(64, 0);
            this.addNewBookLb.Name = "addNewBookLb";
            this.addNewBookLb.Size = new System.Drawing.Size(110, 20);
            this.addNewBookLb.TabIndex = 1;
            this.addNewBookLb.Text = "Add new book";
            // 
            // addTitleTb
            // 
            this.addTitleTb.Location = new System.Drawing.Point(86, 28);
            this.addTitleTb.Name = "addTitleTb";
            this.addTitleTb.Size = new System.Drawing.Size(145, 20);
            this.addTitleTb.TabIndex = 8;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DimGray;
            this.panel1.Controls.Add(this.avalableDiscrLb);
            this.panel1.Controls.Add(this.countDiscrLb);
            this.panel1.Controls.Add(this.removeBtn);
            this.panel1.Controls.Add(this.ownerDiscrLb);
            this.panel1.Controls.Add(this.addBookBtn);
            this.panel1.Controls.Add(this.ownerLb);
            this.panel1.Controls.Add(this.titleDiscrLb);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.authorDiscrLb);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.avalableLb);
            this.panel1.Controls.Add(this.countLb);
            this.panel1.Controls.Add(this.takeBtn);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Location = new System.Drawing.Point(514, 34);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(234, 148);
            this.panel1.TabIndex = 18;
            // 
            // avalableDiscrLb
            // 
            this.avalableDiscrLb.AutoSize = true;
            this.avalableDiscrLb.BackColor = System.Drawing.Color.Transparent;
            this.avalableDiscrLb.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.avalableDiscrLb.ForeColor = System.Drawing.SystemColors.Control;
            this.avalableDiscrLb.Location = new System.Drawing.Point(82, 60);
            this.avalableDiscrLb.Name = "avalableDiscrLb";
            this.avalableDiscrLb.Size = new System.Drawing.Size(0, 20);
            this.avalableDiscrLb.TabIndex = 24;
            // 
            // countDiscrLb
            // 
            this.countDiscrLb.AutoSize = true;
            this.countDiscrLb.BackColor = System.Drawing.Color.Transparent;
            this.countDiscrLb.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.countDiscrLb.ForeColor = System.Drawing.SystemColors.Control;
            this.countDiscrLb.Location = new System.Drawing.Point(82, 80);
            this.countDiscrLb.Name = "countDiscrLb";
            this.countDiscrLb.Size = new System.Drawing.Size(0, 20);
            this.countDiscrLb.TabIndex = 23;
            // 
            // removeBtn
            // 
            this.removeBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.removeBtn.Location = new System.Drawing.Point(7, 122);
            this.removeBtn.Name = "removeBtn";
            this.removeBtn.Size = new System.Drawing.Size(72, 23);
            this.removeBtn.TabIndex = 19;
            this.removeBtn.Text = "Remove";
            this.removeBtn.UseVisualStyleBackColor = true;
            this.removeBtn.Visible = false;
            // 
            // ownerDiscrLb
            // 
            this.ownerDiscrLb.AutoSize = true;
            this.ownerDiscrLb.BackColor = System.Drawing.Color.Transparent;
            this.ownerDiscrLb.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ownerDiscrLb.ForeColor = System.Drawing.SystemColors.Control;
            this.ownerDiscrLb.Location = new System.Drawing.Point(82, 100);
            this.ownerDiscrLb.Name = "ownerDiscrLb";
            this.ownerDiscrLb.Size = new System.Drawing.Size(0, 20);
            this.ownerDiscrLb.TabIndex = 17;
            // 
            // ownerLb
            // 
            this.ownerLb.AutoSize = true;
            this.ownerLb.BackColor = System.Drawing.Color.Transparent;
            this.ownerLb.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ownerLb.ForeColor = System.Drawing.SystemColors.Control;
            this.ownerLb.Location = new System.Drawing.Point(3, 100);
            this.ownerLb.Name = "ownerLb";
            this.ownerLb.Size = new System.Drawing.Size(59, 20);
            this.ownerLb.TabIndex = 16;
            this.ownerLb.Text = "Owner:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.ForeColor = System.Drawing.SystemColors.Control;
            this.label4.Location = new System.Drawing.Point(2, 20);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(46, 20);
            this.label4.TabIndex = 14;
            this.label4.Text = "Title: ";
            // 
            // authorDiscrLb
            // 
            this.authorDiscrLb.AutoSize = true;
            this.authorDiscrLb.BackColor = System.Drawing.Color.Transparent;
            this.authorDiscrLb.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.authorDiscrLb.ForeColor = System.Drawing.SystemColors.Control;
            this.authorDiscrLb.Location = new System.Drawing.Point(82, 40);
            this.authorDiscrLb.Name = "authorDiscrLb";
            this.authorDiscrLb.Size = new System.Drawing.Size(0, 20);
            this.authorDiscrLb.TabIndex = 13;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.ForeColor = System.Drawing.SystemColors.Control;
            this.label6.Location = new System.Drawing.Point(3, 40);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(83, 20);
            this.label6.TabIndex = 12;
            this.label6.Text = "Author(s): ";
            // 
            // avalableLb
            // 
            this.avalableLb.AutoSize = true;
            this.avalableLb.BackColor = System.Drawing.Color.Transparent;
            this.avalableLb.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.avalableLb.ForeColor = System.Drawing.SystemColors.Control;
            this.avalableLb.Location = new System.Drawing.Point(3, 60);
            this.avalableLb.Name = "avalableLb";
            this.avalableLb.Size = new System.Drawing.Size(76, 20);
            this.avalableLb.TabIndex = 11;
            this.avalableLb.Text = "Available:";
            // 
            // countLb
            // 
            this.countLb.AutoSize = true;
            this.countLb.BackColor = System.Drawing.Color.Transparent;
            this.countLb.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.countLb.ForeColor = System.Drawing.SystemColors.Control;
            this.countLb.Location = new System.Drawing.Point(3, 80);
            this.countLb.Name = "countLb";
            this.countLb.Size = new System.Drawing.Size(56, 20);
            this.countLb.TabIndex = 10;
            this.countLb.Text = "Count:";
            // 
            // takeBtn
            // 
            this.takeBtn.Location = new System.Drawing.Point(166, 122);
            this.takeBtn.Name = "takeBtn";
            this.takeBtn.Size = new System.Drawing.Size(65, 23);
            this.takeBtn.TabIndex = 9;
            this.takeBtn.Text = "Take";
            this.takeBtn.UseVisualStyleBackColor = true;
            this.takeBtn.Click += new System.EventHandler(this.takeBtn_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label9.ForeColor = System.Drawing.SystemColors.Control;
            this.label9.Location = new System.Drawing.Point(62, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(112, 20);
            this.label9.TabIndex = 1;
            this.label9.Text = "Choosen book";
            // 
            // historyPl
            // 
            this.historyPl.BackColor = System.Drawing.Color.DimGray;
            this.historyPl.Controls.Add(this.historyRtb);
            this.historyPl.Controls.Add(this.historyLb);
            this.historyPl.Location = new System.Drawing.Point(12, 325);
            this.historyPl.Name = "historyPl";
            this.historyPl.Size = new System.Drawing.Size(486, 85);
            this.historyPl.TabIndex = 11;
            // 
            // historyRtb
            // 
            this.historyRtb.Location = new System.Drawing.Point(3, 23);
            this.historyRtb.Name = "historyRtb";
            this.historyRtb.Size = new System.Drawing.Size(480, 59);
            this.historyRtb.TabIndex = 2;
            this.historyRtb.Text = "";
            // 
            // historyLb
            // 
            this.historyLb.AutoSize = true;
            this.historyLb.BackColor = System.Drawing.Color.Transparent;
            this.historyLb.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.historyLb.ForeColor = System.Drawing.SystemColors.Control;
            this.historyLb.Location = new System.Drawing.Point(12, 0);
            this.historyLb.Name = "historyLb";
            this.historyLb.Size = new System.Drawing.Size(58, 20);
            this.historyLb.TabIndex = 1;
            this.historyLb.Text = "History";
            // 
            // toJournal
            // 
            this.toJournal.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toJournal.Location = new System.Drawing.Point(514, 387);
            this.toJournal.Name = "toJournal";
            this.toJournal.Size = new System.Drawing.Size(112, 23);
            this.toJournal.TabIndex = 1;
            this.toJournal.Text = "To your journal";
            this.toJournal.UseVisualStyleBackColor = true;
            this.toJournal.Click += new System.EventHandler(this.toJournal_Click);
            // 
            // toMenuBtn
            // 
            this.toMenuBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toMenuBtn.Location = new System.Drawing.Point(632, 387);
            this.toMenuBtn.Name = "toMenuBtn";
            this.toMenuBtn.Size = new System.Drawing.Size(113, 23);
            this.toMenuBtn.TabIndex = 0;
            this.toMenuBtn.Text = "To Main Menu";
            this.toMenuBtn.UseVisualStyleBackColor = true;
            this.toMenuBtn.Click += new System.EventHandler(this.toMenuBtn_Click);
            // 
            // booksTableAdapter
            // 
            this.booksTableAdapter.ClearBeforeFill = true;
            // 
            // historyBtn
            // 
            this.historyBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.historyBtn.Location = new System.Drawing.Point(514, 358);
            this.historyBtn.Name = "historyBtn";
            this.historyBtn.Size = new System.Drawing.Size(112, 23);
            this.historyBtn.TabIndex = 25;
            this.historyBtn.Text = "History";
            this.historyBtn.UseVisualStyleBackColor = true;
            this.historyBtn.Click += new System.EventHandler(this.historyBtn_Click);
            // 
            // titleDiscrLb
            // 
            this.titleDiscrLb.AutoSize = true;
            this.titleDiscrLb.BackColor = System.Drawing.Color.Transparent;
            this.titleDiscrLb.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.titleDiscrLb.ForeColor = System.Drawing.SystemColors.Control;
            this.titleDiscrLb.Location = new System.Drawing.Point(82, 20);
            this.titleDiscrLb.Name = "titleDiscrLb";
            this.titleDiscrLb.Size = new System.Drawing.Size(0, 20);
            this.titleDiscrLb.TabIndex = 15;
            // 
            // LibraryUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Library.Properties.Resources._32b159de59431ea9cd535d3105fdfe5e;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.Controls.Add(this.historyBtn);
            this.Controls.Add(this.returnBookPl);
            this.Controls.Add(this.returnBookBtn);
            this.Controls.Add(this.helloLb);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.addBookPl);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.historyPl);
            this.Controls.Add(this.toJournal);
            this.Controls.Add(this.toMenuBtn);
            this.Name = "LibraryUserControl";
            this.Size = new System.Drawing.Size(760, 426);
            this.returnBookPl.ResumeLayout(false);
            this.returnBookPl.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.booksTable)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.booksBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.libraryDBContextDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.addBookPl.ResumeLayout(false);
            this.addBookPl.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.historyPl.ResumeLayout(false);
            this.historyPl.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button toMenuBtn;
        private System.Windows.Forms.Button toJournal;
        private System.Windows.Forms.Panel historyPl;
        private System.Windows.Forms.TextBox addTitleTb;
        private System.Windows.Forms.Label historyLb;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label ownerDiscrLb;
        private System.Windows.Forms.Label ownerLb;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label authorDiscrLb;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label avalableLb;
        private System.Windows.Forms.Label countLb;
        private System.Windows.Forms.Button takeBtn;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.RichTextBox historyRtb;
        private System.Windows.Forms.Button removeBtn;
        private System.Windows.Forms.Panel addBookPl;
        private System.Windows.Forms.TextBox addAuthorsTb;
        private System.Windows.Forms.Button addNewBook;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label addNewBookLb;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button addBookBtn;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.RadioButton avalableBooksRb;
        private System.Windows.Forms.RadioButton allBooksRb;
        private System.Windows.Forms.Label helloLb;
        private System.Windows.Forms.RadioButton takenBooksRb;
        private System.Windows.Forms.Panel returnBookPl;
        private System.Windows.Forms.Label chooseBookLb;
        private System.Windows.Forms.ComboBox returnBookCb;
        private System.Windows.Forms.Button okReturnBookBtn;
        private System.Windows.Forms.Label returnBookLb;
        private System.Windows.Forms.Button returnBookBtn;
        private System.Windows.Forms.DataGridViewTextBoxColumn authors;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn titleDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridView booksTable;
        private System.Windows.Forms.DataGridViewTextBoxColumn titleDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn authorDiscriptionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn titleDataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.Label avalableDiscrLb;
        private System.Windows.Forms.Label countDiscrLb;
        private System.Windows.Forms.BindingSource booksBindingSource1;
        private LibraryDBContextDataSet libraryDBContextDataSet;
        private LibraryDBContextDataSetTableAdapters.BooksTableAdapter booksTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn titleDataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.Button CancelReturnBookBtn;
        private System.Windows.Forms.Button historyBtn;
        private System.Windows.Forms.Label titleDiscrLb;
    }
}
