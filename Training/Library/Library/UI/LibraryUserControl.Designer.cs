namespace Library.UI
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
            this.libraryDBContextDataSet1 = new Library.LibraryDBContextDataSet();
            this.booksBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.booksTableAdapter1 = new Library.LibraryDBContextDataSetTableAdapters.BooksTableAdapter();
            this.returnBookPl = new System.Windows.Forms.Panel();
            this.chooseBookLb = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.returnBookLb = new System.Windows.Forms.Label();
            this.returnBookBtn = new System.Windows.Forms.Button();
            this.helloLb = new System.Windows.Forms.Label();
            this.addBookBtn = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.avalableBooksRb = new System.Windows.Forms.RadioButton();
            this.takenBooksRb = new System.Windows.Forms.RadioButton();
            this.allBooksRb = new System.Windows.Forms.RadioButton();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.addBookPl = new System.Windows.Forms.Panel();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.addNewBook = new System.Windows.Forms.Button();
            this.label13 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.addNewBookLb = new System.Windows.Forms.Label();
            this.regPasswordTb = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.addBtn = new System.Windows.Forms.Button();
            this.removeBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.takeBtn = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.historyPl = new System.Windows.Forms.Panel();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.historyLb = new System.Windows.Forms.Label();
            this.toJournal = new System.Windows.Forms.Button();
            this.toMenuBtn = new System.Windows.Forms.Button();
            this.titleDataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.libraryDBContextDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.booksBindingSource)).BeginInit();
            this.returnBookPl.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
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
            // libraryDBContextDataSet1
            // 
            this.libraryDBContextDataSet1.DataSetName = "LibraryDBContextDataSet";
            this.libraryDBContextDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // booksBindingSource
            // 
            this.booksBindingSource.DataMember = "Books";
            this.booksBindingSource.DataSource = this.libraryDBContextDataSet1;
            // 
            // booksTableAdapter1
            // 
            this.booksTableAdapter1.ClearBeforeFill = true;
            // 
            // returnBookPl
            // 
            this.returnBookPl.BackColor = System.Drawing.Color.DimGray;
            this.returnBookPl.Controls.Add(this.chooseBookLb);
            this.returnBookPl.Controls.Add(this.comboBox1);
            this.returnBookPl.Controls.Add(this.button1);
            this.returnBookPl.Controls.Add(this.returnBookLb);
            this.returnBookPl.Location = new System.Drawing.Point(521, 209);
            this.returnBookPl.Name = "returnBookPl";
            this.returnBookPl.Size = new System.Drawing.Size(234, 83);
            this.returnBookPl.TabIndex = 22;
            this.returnBookPl.Visible = false;
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
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(109, 28);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 21;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.Location = new System.Drawing.Point(83, 54);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(77, 23);
            this.button1.TabIndex = 20;
            this.button1.Text = "OK";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
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
            this.returnBookBtn.BackColor = System.Drawing.SystemColors.ControlDark;
            this.returnBookBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.returnBookBtn.Location = new System.Drawing.Point(639, 354);
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
            this.helloLb.Size = new System.Drawing.Size(103, 20);
            this.helloLb.TabIndex = 21;
            this.helloLb.Text = "Hello, User!";
            // 
            // addBookBtn
            // 
            this.addBookBtn.BackColor = System.Drawing.SystemColors.ControlDark;
            this.addBookBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addBookBtn.Location = new System.Drawing.Point(521, 354);
            this.addBookBtn.Name = "addBookBtn";
            this.addBookBtn.Size = new System.Drawing.Size(112, 23);
            this.addBookBtn.TabIndex = 22;
            this.addBookBtn.Text = "Add new book";
            this.addBookBtn.UseVisualStyleBackColor = false;
            this.addBookBtn.Click += new System.EventHandler(this.addBookBtn_Click);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.DimGray;
            this.panel3.Controls.Add(this.dataGridView2);
            this.panel3.Controls.Add(this.avalableBooksRb);
            this.panel3.Controls.Add(this.takenBooksRb);
            this.panel3.Controls.Add(this.allBooksRb);
            this.panel3.Controls.Add(this.dataGridView1);
            this.panel3.Location = new System.Drawing.Point(15, 6);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(483, 297);
            this.panel3.TabIndex = 21;
            // 
            // dataGridView2
            // 
            this.dataGridView2.AllowUserToAddRows = false;
            this.dataGridView2.AllowUserToDeleteRows = false;
            this.dataGridView2.AutoGenerateColumns = false;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.titleDataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn1});
            this.dataGridView2.DataSource = this.booksBindingSource;
            this.dataGridView2.Location = new System.Drawing.Point(3, 28);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.ReadOnly = true;
            this.dataGridView2.Size = new System.Drawing.Size(477, 266);
            this.dataGridView2.TabIndex = 4;
            // 
            // avalableBooksRb
            // 
            this.avalableBooksRb.AutoSize = true;
            this.avalableBooksRb.Location = new System.Drawing.Point(87, 5);
            this.avalableBooksRb.Name = "avalableBooksRb";
            this.avalableBooksRb.Size = new System.Drawing.Size(98, 17);
            this.avalableBooksRb.TabIndex = 3;
            this.avalableBooksRb.TabStop = true;
            this.avalableBooksRb.Text = "Avalable books";
            this.avalableBooksRb.UseVisualStyleBackColor = true;
            // 
            // takenBooksRb
            // 
            this.takenBooksRb.AutoSize = true;
            this.takenBooksRb.Location = new System.Drawing.Point(191, 5);
            this.takenBooksRb.Name = "takenBooksRb";
            this.takenBooksRb.Size = new System.Drawing.Size(88, 17);
            this.takenBooksRb.TabIndex = 2;
            this.takenBooksRb.TabStop = true;
            this.takenBooksRb.Text = "Taken books";
            this.takenBooksRb.UseVisualStyleBackColor = true;
            // 
            // allBooksRb
            // 
            this.allBooksRb.AutoSize = true;
            this.allBooksRb.Location = new System.Drawing.Point(13, 5);
            this.allBooksRb.Name = "allBooksRb";
            this.allBooksRb.Size = new System.Drawing.Size(68, 17);
            this.allBooksRb.TabIndex = 1;
            this.allBooksRb.TabStop = true;
            this.allBooksRb.Text = "All books";
            this.allBooksRb.UseVisualStyleBackColor = true;
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
            this.addBookPl.Controls.Add(this.textBox1);
            this.addBookPl.Controls.Add(this.addNewBook);
            this.addBookPl.Controls.Add(this.label13);
            this.addBookPl.Controls.Add(this.label15);
            this.addBookPl.Controls.Add(this.addNewBookLb);
            this.addBookPl.Controls.Add(this.regPasswordTb);
            this.addBookPl.Location = new System.Drawing.Point(521, 209);
            this.addBookPl.Name = "addBookPl";
            this.addBookPl.Size = new System.Drawing.Size(234, 115);
            this.addBookPl.TabIndex = 21;
            this.addBookPl.Visible = false;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(86, 54);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(145, 20);
            this.textBox1.TabIndex = 21;
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
            // regPasswordTb
            // 
            this.regPasswordTb.Location = new System.Drawing.Point(86, 28);
            this.regPasswordTb.Name = "regPasswordTb";
            this.regPasswordTb.Size = new System.Drawing.Size(145, 20);
            this.regPasswordTb.TabIndex = 8;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DimGray;
            this.panel1.Controls.Add(this.addBtn);
            this.panel1.Controls.Add(this.removeBtn);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.takeBtn);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Location = new System.Drawing.Point(521, 34);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(234, 148);
            this.panel1.TabIndex = 18;
            // 
            // addBtn
            // 
            this.addBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.addBtn.Location = new System.Drawing.Point(86, 122);
            this.addBtn.Name = "addBtn";
            this.addBtn.Size = new System.Drawing.Size(74, 23);
            this.addBtn.TabIndex = 20;
            this.addBtn.Text = "Add same";
            this.addBtn.UseVisualStyleBackColor = true;
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
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(83, 60);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(13, 20);
            this.label1.TabIndex = 17;
            this.label1.Text = ".";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.ForeColor = System.Drawing.SystemColors.Control;
            this.label2.Location = new System.Drawing.Point(3, 60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 20);
            this.label2.TabIndex = 16;
            this.label2.Text = "Owner:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.ForeColor = System.Drawing.SystemColors.Control;
            this.label3.Location = new System.Drawing.Point(82, 20);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(13, 20);
            this.label3.TabIndex = 15;
            this.label3.Text = ".";
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
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.ForeColor = System.Drawing.SystemColors.Control;
            this.label5.Location = new System.Drawing.Point(82, 40);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(13, 20);
            this.label5.TabIndex = 13;
            this.label5.Text = ".";
            this.label5.Visible = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.ForeColor = System.Drawing.SystemColors.Control;
            this.label6.Location = new System.Drawing.Point(2, 40);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(83, 20);
            this.label6.TabIndex = 12;
            this.label6.Text = "Author(s): ";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.ForeColor = System.Drawing.SystemColors.Control;
            this.label7.Location = new System.Drawing.Point(3, 100);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(76, 20);
            this.label7.TabIndex = 11;
            this.label7.Text = "Available:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label8.ForeColor = System.Drawing.SystemColors.Control;
            this.label8.Location = new System.Drawing.Point(3, 80);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(56, 20);
            this.label8.TabIndex = 10;
            this.label8.Text = "Count:";
            // 
            // takeBtn
            // 
            this.takeBtn.Location = new System.Drawing.Point(166, 122);
            this.takeBtn.Name = "takeBtn";
            this.takeBtn.Size = new System.Drawing.Size(65, 23);
            this.takeBtn.TabIndex = 9;
            this.takeBtn.Text = "Take";
            this.takeBtn.UseVisualStyleBackColor = true;
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
            this.historyPl.Controls.Add(this.richTextBox1);
            this.historyPl.Controls.Add(this.historyLb);
            this.historyPl.Location = new System.Drawing.Point(12, 325);
            this.historyPl.Name = "historyPl";
            this.historyPl.Size = new System.Drawing.Size(486, 81);
            this.historyPl.TabIndex = 11;
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(3, 23);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(480, 69);
            this.richTextBox1.TabIndex = 2;
            this.richTextBox1.Text = "";
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
            this.toJournal.Location = new System.Drawing.Point(521, 383);
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
            this.toMenuBtn.Location = new System.Drawing.Point(639, 383);
            this.toMenuBtn.Name = "toMenuBtn";
            this.toMenuBtn.Size = new System.Drawing.Size(113, 23);
            this.toMenuBtn.TabIndex = 0;
            this.toMenuBtn.Text = "To Main Menu";
            this.toMenuBtn.UseVisualStyleBackColor = true;
            this.toMenuBtn.Click += new System.EventHandler(this.toMenuBtn_Click);
            // 
            // titleDataGridViewTextBoxColumn2
            // 
            this.titleDataGridViewTextBoxColumn2.DataPropertyName = "Title";
            this.titleDataGridViewTextBoxColumn2.HeaderText = "Title";
            this.titleDataGridViewTextBoxColumn2.Name = "titleDataGridViewTextBoxColumn2";
            this.titleDataGridViewTextBoxColumn2.ReadOnly = true;
            this.titleDataGridViewTextBoxColumn2.Width = 200;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "authorDiscription";
            this.dataGridViewTextBoxColumn1.HeaderText = "Author(s)";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Width = 235;
            // 
            // LibraryUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Library.Properties.Resources._32b159de59431ea9cd535d3105fdfe5e;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.Controls.Add(this.returnBookPl);
            this.Controls.Add(this.returnBookBtn);
            this.Controls.Add(this.helloLb);
            this.Controls.Add(this.addBookBtn);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.addBookPl);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.historyPl);
            this.Controls.Add(this.toJournal);
            this.Controls.Add(this.toMenuBtn);
            this.Name = "LibraryUserControl";
            this.Size = new System.Drawing.Size(760, 426);
            this.Load += new System.EventHandler(this.LibraryUserControl_Load);
            ((System.ComponentModel.ISupportInitialize)(this.libraryDBContextDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.booksBindingSource)).EndInit();
            this.returnBookPl.ResumeLayout(false);
            this.returnBookPl.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
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
        private System.Windows.Forms.TextBox regPasswordTb;
        private System.Windows.Forms.Label historyLb;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button takeBtn;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Button addBtn;
        private System.Windows.Forms.Button removeBtn;
        private System.Windows.Forms.Panel addBookPl;
        private System.Windows.Forms.TextBox textBox1;
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
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label returnBookLb;
        private System.Windows.Forms.Button returnBookBtn;
        private System.Windows.Forms.DataGridViewTextBoxColumn authors;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn titleDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.DataGridViewTextBoxColumn titleDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn authorDiscriptionDataGridViewTextBoxColumn;
        private LibraryDBContextDataSetTableAdapters.BooksTableAdapter booksTableAdapter;
        private LibraryDBContextDataSet libraryDBContextDataSet;
        private System.Windows.Forms.BindingSource booksBindingSource;
        private LibraryDBContextDataSet libraryDBContextDataSet1;
        private LibraryDBContextDataSetTableAdapters.BooksTableAdapter booksTableAdapter1;
        private System.Windows.Forms.DataGridViewTextBoxColumn titleDataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
    }
}
