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
            this.toMainMenuLb = new System.Windows.Forms.Button();
            this.toLibraryBtn = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Theme = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
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
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.DimGray;
            this.panel3.Controls.Add(this.dataGridView1);
            this.panel3.Location = new System.Drawing.Point(71, 36);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(250, 319);
            this.panel3.TabIndex = 22;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.date,
            this.Theme});
            this.dataGridView1.Location = new System.Drawing.Point(3, 3);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(244, 313);
            this.dataGridView1.TabIndex = 0;
            // 
            // date
            // 
            this.date.HeaderText = "Date";
            this.date.Name = "date";
            this.date.ReadOnly = true;
            // 
            // Theme
            // 
            this.Theme.HeaderText = "Theme";
            this.Theme.Name = "Theme";
            this.Theme.ReadOnly = true;
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(324, 39);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(368, 313);
            this.richTextBox1.TabIndex = 23;
            this.richTextBox1.Text = "";
            // 
            // JournalUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Library.Properties.Resources.letters;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.toMainMenuLb);
            this.Controls.Add(this.toLibraryBtn);
            this.Name = "JournalUserControl";
            this.Size = new System.Drawing.Size(760, 420);
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button toLibraryBtn;
        private System.Windows.Forms.Button toMainMenuLb;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn date;
        private System.Windows.Forms.DataGridViewTextBoxColumn Theme;
        private System.Windows.Forms.RichTextBox richTextBox1;
    }
}
