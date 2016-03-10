namespace SearchFile
{
    partial class SearchFile
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
            this.pathFileLb = new System.Windows.Forms.Label();
            this.pathFld = new System.Windows.Forms.TextBox();
            this.searchBtn = new System.Windows.Forms.Button();
            this.textFileFld = new System.Windows.Forms.TextBox();
            this.zipBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // pathFileLb
            // 
            this.pathFileLb.AutoSize = true;
            this.pathFileLb.Location = new System.Drawing.Point(29, 26);
            this.pathFileLb.Name = "pathFileLb";
            this.pathFileLb.Size = new System.Drawing.Size(117, 13);
            this.pathFileLb.TabIndex = 0;
            this.pathFileLb.Text = "Введите адрес файла";
            // 
            // pathFld
            // 
            this.pathFld.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pathFld.Location = new System.Drawing.Point(152, 23);
            this.pathFld.Name = "pathFld";
            this.pathFld.Size = new System.Drawing.Size(168, 20);
            this.pathFld.TabIndex = 1;
            // 
            // searchBtn
            // 
            this.searchBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.searchBtn.Location = new System.Drawing.Point(336, 21);
            this.searchBtn.Name = "searchBtn";
            this.searchBtn.Size = new System.Drawing.Size(54, 23);
            this.searchBtn.TabIndex = 2;
            this.searchBtn.Text = "Поиск";
            this.searchBtn.UseVisualStyleBackColor = true;
            // 
            // textFileFld
            // 
            this.textFileFld.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textFileFld.Location = new System.Drawing.Point(32, 64);
            this.textFileFld.Multiline = true;
            this.textFileFld.Name = "textFileFld";
            this.textFileFld.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textFileFld.Size = new System.Drawing.Size(358, 188);
            this.textFileFld.TabIndex = 3;
            // 
            // zipBtn
            // 
            this.zipBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.zipBtn.Location = new System.Drawing.Point(309, 261);
            this.zipBtn.Name = "zipBtn";
            this.zipBtn.Size = new System.Drawing.Size(81, 23);
            this.zipBtn.TabIndex = 4;
            this.zipBtn.Text = "Сжать файл";
            this.zipBtn.UseVisualStyleBackColor = true;
            // 
            // SearchFile
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(422, 302);
            this.Controls.Add(this.zipBtn);
            this.Controls.Add(this.textFileFld);
            this.Controls.Add(this.searchBtn);
            this.Controls.Add(this.pathFld);
            this.Controls.Add(this.pathFileLb);
            this.Name = "SearchFile";
            this.Text = "Search file";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label pathFileLb;
        private System.Windows.Forms.TextBox pathFld;
        private System.Windows.Forms.Button searchBtn;
        private System.Windows.Forms.TextBox textFileFld;
        private System.Windows.Forms.Button zipBtn;
    }
}

