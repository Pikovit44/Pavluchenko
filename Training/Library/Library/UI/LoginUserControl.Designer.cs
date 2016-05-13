namespace Library.UI
{
    partial class LoginUserControl
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
            this.helloLb = new System.Windows.Forms.Label();
            this.enterLoginLb = new System.Windows.Forms.Label();
            this.loginTb = new System.Windows.Forms.TextBox();
            this.adminCb = new System.Windows.Forms.CheckBox();
            this.regLoginTb = new System.Windows.Forms.TextBox();
            this.regLoginLb = new System.Windows.Forms.Label();
            this.regPasswordTb = new System.Windows.Forms.TextBox();
            this.regEmailLb = new System.Windows.Forms.Label();
            this.okBtn = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.signUpCb = new System.Windows.Forms.CheckBox();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // helloLb
            // 
            this.helloLb.AutoSize = true;
            this.helloLb.BackColor = System.Drawing.Color.Transparent;
            this.helloLb.Font = new System.Drawing.Font("Modern No. 20", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.helloLb.ForeColor = System.Drawing.Color.Snow;
            this.helloLb.Location = new System.Drawing.Point(81, 8);
            this.helloLb.Name = "helloLb";
            this.helloLb.Size = new System.Drawing.Size(95, 36);
            this.helloLb.TabIndex = 0;
            this.helloLb.Text = "Hello";
            // 
            // enterLoginLb
            // 
            this.enterLoginLb.AutoSize = true;
            this.enterLoginLb.BackColor = System.Drawing.Color.Transparent;
            this.enterLoginLb.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.enterLoginLb.ForeColor = System.Drawing.SystemColors.Control;
            this.enterLoginLb.Location = new System.Drawing.Point(66, 44);
            this.enterLoginLb.Name = "enterLoginLb";
            this.enterLoginLb.Size = new System.Drawing.Size(119, 20);
            this.enterLoginLb.TabIndex = 1;
            this.enterLoginLb.Text = "Enter your login";
            // 
            // loginTb
            // 
            this.loginTb.Location = new System.Drawing.Point(51, 71);
            this.loginTb.Name = "loginTb";
            this.loginTb.Size = new System.Drawing.Size(161, 20);
            this.loginTb.TabIndex = 2;
            // 
            // adminCb
            // 
            this.adminCb.AutoSize = true;
            this.adminCb.BackColor = System.Drawing.Color.Transparent;
            this.adminCb.ForeColor = System.Drawing.SystemColors.Control;
            this.adminCb.Location = new System.Drawing.Point(51, 97);
            this.adminCb.Name = "adminCb";
            this.adminCb.Size = new System.Drawing.Size(86, 17);
            this.adminCb.TabIndex = 3;
            this.adminCb.Text = "Administrator";
            this.adminCb.UseVisualStyleBackColor = false;
            this.adminCb.CheckedChanged += new System.EventHandler(this.adminCb_CheckedChanged);
            // 
            // regLoginTb
            // 
            this.regLoginTb.Location = new System.Drawing.Point(87, 131);
            this.regLoginTb.Name = "regLoginTb";
            this.regLoginTb.Size = new System.Drawing.Size(143, 20);
            this.regLoginTb.TabIndex = 6;
            this.regLoginTb.Visible = false;
            // 
            // regLoginLb
            // 
            this.regLoginLb.AutoSize = true;
            this.regLoginLb.BackColor = System.Drawing.Color.Transparent;
            this.regLoginLb.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.regLoginLb.ForeColor = System.Drawing.SystemColors.Control;
            this.regLoginLb.Location = new System.Drawing.Point(33, 129);
            this.regLoginLb.Name = "regLoginLb";
            this.regLoginLb.Size = new System.Drawing.Size(48, 20);
            this.regLoginLb.TabIndex = 5;
            this.regLoginLb.Text = "Login";
            this.regLoginLb.Visible = false;
            // 
            // regPasswordTb
            // 
            this.regPasswordTb.Location = new System.Drawing.Point(87, 154);
            this.regPasswordTb.Name = "regPasswordTb";
            this.regPasswordTb.Size = new System.Drawing.Size(143, 20);
            this.regPasswordTb.TabIndex = 8;
            this.regPasswordTb.Visible = false;
            // 
            // regEmailLb
            // 
            this.regEmailLb.AutoSize = true;
            this.regEmailLb.BackColor = System.Drawing.Color.Transparent;
            this.regEmailLb.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.regEmailLb.ForeColor = System.Drawing.SystemColors.Control;
            this.regEmailLb.Location = new System.Drawing.Point(33, 154);
            this.regEmailLb.Name = "regEmailLb";
            this.regEmailLb.Size = new System.Drawing.Size(48, 20);
            this.regEmailLb.TabIndex = 7;
            this.regEmailLb.Text = "Email";
            this.regEmailLb.Visible = false;
            // 
            // okBtn
            // 
            this.okBtn.Location = new System.Drawing.Point(180, 193);
            this.okBtn.Name = "okBtn";
            this.okBtn.Size = new System.Drawing.Size(50, 23);
            this.okBtn.TabIndex = 9;
            this.okBtn.Text = "OK";
            this.okBtn.UseVisualStyleBackColor = true;
            this.okBtn.Click += new System.EventHandler(this.okBtn_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DimGray;
            this.panel1.Controls.Add(this.okBtn);
            this.panel1.Controls.Add(this.regPasswordTb);
            this.panel1.Controls.Add(this.regEmailLb);
            this.panel1.Controls.Add(this.regLoginTb);
            this.panel1.Controls.Add(this.regLoginLb);
            this.panel1.Controls.Add(this.signUpCb);
            this.panel1.Controls.Add(this.adminCb);
            this.panel1.Controls.Add(this.loginTb);
            this.panel1.Controls.Add(this.enterLoginLb);
            this.panel1.Controls.Add(this.helloLb);
            this.panel1.Location = new System.Drawing.Point(247, 86);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(252, 231);
            this.panel1.TabIndex = 10;
            // 
            // signUpCb
            // 
            this.signUpCb.AutoSize = true;
            this.signUpCb.BackColor = System.Drawing.Color.Transparent;
            this.signUpCb.ForeColor = System.Drawing.SystemColors.Control;
            this.signUpCb.Location = new System.Drawing.Point(159, 97);
            this.signUpCb.Name = "signUpCb";
            this.signUpCb.Size = new System.Drawing.Size(62, 17);
            this.signUpCb.TabIndex = 4;
            this.signUpCb.Text = "Sign up";
            this.signUpCb.UseVisualStyleBackColor = false;
            this.signUpCb.CheckedChanged += new System.EventHandler(this.signUpLb_CheckedChanged);
            // 
            // LoginUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Library.Properties.Resources.LibraryBackground;
            this.Controls.Add(this.panel1);
            this.Name = "LoginUserControl";
            this.Size = new System.Drawing.Size(760, 420);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label helloLb;
        private System.Windows.Forms.Label enterLoginLb;
        private System.Windows.Forms.TextBox loginTb;
        private System.Windows.Forms.CheckBox adminCb;
        private System.Windows.Forms.TextBox regLoginTb;
        private System.Windows.Forms.Label regLoginLb;
        private System.Windows.Forms.TextBox regPasswordTb;
        private System.Windows.Forms.Label regEmailLb;
        private System.Windows.Forms.Button okBtn;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.CheckBox signUpCb;
    }
}
