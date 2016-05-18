namespace Library.UI
{
    partial class JournalUserControl
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
            this.lettersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.libraryDBContextDataSet1 = new Library.LibraryDBContextDataSet1();
            this.lettersTableAdapter = new Library.LibraryDBContextDataSet1TableAdapters.LettersTableAdapter();
            this.lettersTable = new System.Windows.Forms.DataGridView();
            this.LettersRtB = new System.Windows.Forms.RichTextBox();
            this.toMainMenuLb = new System.Windows.Forms.Button();
            this.toLibraryBtn = new System.Windows.Forms.Button();
            this.dateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.topikDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.lettersBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.libraryDBContextDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lettersTable)).BeginInit();
            this.SuspendLayout();
            // 
            // lettersBindingSource
            // 
            this.lettersBindingSource.DataMember = "Letters";
            this.lettersBindingSource.DataSource = this.libraryDBContextDataSet1;
            // 
            // libraryDBContextDataSet1
            // 
            this.libraryDBContextDataSet1.DataSetName = "LibraryDBContextDataSet1";
            this.libraryDBContextDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // lettersTableAdapter
            // 
            this.lettersTableAdapter.ClearBeforeFill = true;
            // 
            // lettersTable
            // 
            this.lettersTable.AllowUserToAddRows = false;
            this.lettersTable.AllowUserToDeleteRows = false;
            this.lettersTable.AutoGenerateColumns = false;
            this.lettersTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.lettersTable.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dateDataGridViewTextBoxColumn,
            this.topikDataGridViewTextBoxColumn});
            this.lettersTable.DataSource = this.lettersBindingSource;
            this.lettersTable.Location = new System.Drawing.Point(97, 42);
            this.lettersTable.Name = "lettersTable";
            this.lettersTable.ReadOnly = true;
            this.lettersTable.Size = new System.Drawing.Size(220, 294);
            this.lettersTable.TabIndex = 24;
            this.lettersTable.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.lettersTable_CellClick);
            // 
            // LettersRtB
            // 
            this.LettersRtB.Location = new System.Drawing.Point(323, 42);
            this.LettersRtB.Name = "LettersRtB";
            this.LettersRtB.Size = new System.Drawing.Size(326, 294);
            this.LettersRtB.TabIndex = 23;
            this.LettersRtB.Text = "";
            // 
            // toMainMenuLb
            // 
            this.toMainMenuLb.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toMainMenuLb.Location = new System.Drawing.Point(27, 382);
            this.toMainMenuLb.Name = "toMainMenuLb";
            this.toMainMenuLb.Size = new System.Drawing.Size(120, 23);
            this.toMainMenuLb.TabIndex = 3;
            this.toMainMenuLb.Text = "To Main Menu";
            this.toMainMenuLb.UseVisualStyleBackColor = true;
            this.toMainMenuLb.Click += new System.EventHandler(this.toMainMenuLb_Click);
            // 
            // toLibraryBtn
            // 
            this.toLibraryBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toLibraryBtn.Location = new System.Drawing.Point(613, 382);
            this.toLibraryBtn.Name = "toLibraryBtn";
            this.toLibraryBtn.Size = new System.Drawing.Size(120, 23);
            this.toLibraryBtn.TabIndex = 2;
            this.toLibraryBtn.Text = "To library";
            this.toLibraryBtn.UseVisualStyleBackColor = true;
            this.toLibraryBtn.Click += new System.EventHandler(this.toLibraryBtn_Click);
            // 
            // dateDataGridViewTextBoxColumn
            // 
            this.dateDataGridViewTextBoxColumn.DataPropertyName = "Date";
            this.dateDataGridViewTextBoxColumn.HeaderText = "Date";
            this.dateDataGridViewTextBoxColumn.Name = "dateDataGridViewTextBoxColumn";
            this.dateDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // topikDataGridViewTextBoxColumn
            // 
            this.topikDataGridViewTextBoxColumn.DataPropertyName = "Topik";
            this.topikDataGridViewTextBoxColumn.HeaderText = "Topik";
            this.topikDataGridViewTextBoxColumn.Name = "topikDataGridViewTextBoxColumn";
            this.topikDataGridViewTextBoxColumn.ReadOnly = true;
            this.topikDataGridViewTextBoxColumn.Width = 77;
            // 
            // JournalUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Library.Properties.Resources.letters;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Controls.Add(this.lettersTable);
            this.Controls.Add(this.LettersRtB);
            this.Controls.Add(this.toMainMenuLb);
            this.Controls.Add(this.toLibraryBtn);
            this.Name = "JournalUserControl";
            this.Size = new System.Drawing.Size(760, 420);
            ((System.ComponentModel.ISupportInitialize)(this.lettersBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.libraryDBContextDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lettersTable)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button toLibraryBtn;
        private System.Windows.Forms.Button toMainMenuLb;
        private System.Windows.Forms.RichTextBox LettersRtB;
        private System.Windows.Forms.DataGridView lettersTable;
        private System.Windows.Forms.BindingSource lettersBindingSource;
        private LibraryDBContextDataSet1 libraryDBContextDataSet1;
        private LibraryDBContextDataSet1TableAdapters.LettersTableAdapter lettersTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn topikDataGridViewTextBoxColumn;
    }
}
