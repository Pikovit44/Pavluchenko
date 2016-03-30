namespace FightClubReports
{
    partial class MainForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.usersLb = new System.Windows.Forms.Label();
            this.combats = new System.Windows.Forms.Label();
            this.transactions = new System.Windows.Forms.Label();
            this.usersCb = new System.Windows.Forms.ComboBox();
            this.transactionsCb = new System.Windows.Forms.ComboBox();
            this.loginForTransactions = new System.Windows.Forms.TextBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.loginForCombats = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(44, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(561, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Выберете какого типа информацию необходимо отобразить";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // usersLb
            // 
            this.usersLb.AutoSize = true;
            this.usersLb.Location = new System.Drawing.Point(45, 57);
            this.usersLb.Name = "usersLb";
            this.usersLb.Size = new System.Drawing.Size(80, 13);
            this.usersLb.TabIndex = 1;
            this.usersLb.Text = "Пользователи";
            // 
            // combats
            // 
            this.combats.AutoSize = true;
            this.combats.Location = new System.Drawing.Point(526, 57);
            this.combats.Name = "combats";
            this.combats.Size = new System.Drawing.Size(26, 13);
            this.combats.TabIndex = 2;
            this.combats.Text = "Бои";
            // 
            // transactions
            // 
            this.transactions.AutoSize = true;
            this.transactions.Location = new System.Drawing.Point(281, 57);
            this.transactions.Name = "transactions";
            this.transactions.Size = new System.Drawing.Size(68, 13);
            this.transactions.TabIndex = 3;
            this.transactions.Text = "Транзакции";
            // 
            // usersCb
            // 
            this.usersCb.FormattingEnabled = true;
            this.usersCb.Items.AddRange(new object[] {
            "Топ лучших",
            "По дате регистрации",
            "По алфавиту",
            "По количеству боев",
            "По количеству транзакций"});
            this.usersCb.Location = new System.Drawing.Point(12, 73);
            this.usersCb.Name = "usersCb";
            this.usersCb.Size = new System.Drawing.Size(159, 21);
            this.usersCb.TabIndex = 9;
            // 
            // transactionsCb
            // 
            this.transactionsCb.FormattingEnabled = true;
            this.transactionsCb.Items.AddRange(new object[] {
            "По сумме",
            "По дате ",
            "По логину игрока"});
            this.transactionsCb.Location = new System.Drawing.Point(235, 73);
            this.transactionsCb.Name = "transactionsCb";
            this.transactionsCb.Size = new System.Drawing.Size(159, 21);
            this.transactionsCb.TabIndex = 11;
            // 
            // loginForTransactions
            // 
            this.loginForTransactions.Location = new System.Drawing.Point(251, 100);
            this.loginForTransactions.Name = "loginForTransactions";
            this.loginForTransactions.Size = new System.Drawing.Size(122, 20);
            this.loginForTransactions.TabIndex = 12;
            this.loginForTransactions.Text = "Введите логин";
            this.loginForTransactions.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.loginForTransactions.Visible = false;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "По сумме",
            "По дате ",
            "По логину игрока"});
            this.comboBox1.Location = new System.Drawing.Point(463, 73);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(159, 21);
            this.comboBox1.TabIndex = 13;
            // 
            // loginForCombats
            // 
            this.loginForCombats.Location = new System.Drawing.Point(483, 100);
            this.loginForCombats.Name = "loginForCombats";
            this.loginForCombats.Size = new System.Drawing.Size(122, 20);
            this.loginForCombats.TabIndex = 14;
            this.loginForCombats.Text = "Введите логин";
            this.loginForCombats.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.loginForCombats.Visible = false;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(633, 391);
            this.Controls.Add(this.loginForCombats);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.loginForTransactions);
            this.Controls.Add(this.transactionsCb);
            this.Controls.Add(this.usersCb);
            this.Controls.Add(this.transactions);
            this.Controls.Add(this.combats);
            this.Controls.Add(this.usersLb);
            this.Controls.Add(this.label1);
            this.Name = "MainForm";
            this.Text = "title";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label usersLb;
        private System.Windows.Forms.Label combats;
        private System.Windows.Forms.Label transactions;
        private System.Windows.Forms.ComboBox usersCb;
        private System.Windows.Forms.ComboBox transactionsCb;
        private System.Windows.Forms.TextBox loginForTransactions;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.TextBox loginForCombats;
    }
}

