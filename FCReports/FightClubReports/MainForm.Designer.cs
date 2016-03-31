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
            this.title = new System.Windows.Forms.Label();
            this.usersLb = new System.Windows.Forms.Label();
            this.combats = new System.Windows.Forms.Label();
            this.transactions = new System.Windows.Forms.Label();
            this.usersCb = new System.Windows.Forms.ComboBox();
            this.transactionsCb = new System.Windows.Forms.ComboBox();
            this.loginForTransactions = new System.Windows.Forms.TextBox();
            this.combatsCb = new System.Windows.Forms.ComboBox();
            this.loginForCombats = new System.Windows.Forms.TextBox();
            this.loginForTransactionsLb = new System.Windows.Forms.Label();
            this.ok = new System.Windows.Forms.Button();
            this.loginForCombatsLb = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // title
            // 
            this.title.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.title.AutoSize = true;
            this.title.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.title.Location = new System.Drawing.Point(101, 9);
            this.title.Name = "title";
            this.title.Size = new System.Drawing.Size(419, 24);
            this.title.TabIndex = 0;
            this.title.Text = "Выберете тип информации для отображения";
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
            this.combats.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.combats.AutoSize = true;
            this.combats.Location = new System.Drawing.Point(526, 57);
            this.combats.Name = "combats";
            this.combats.Size = new System.Drawing.Size(26, 13);
            this.combats.TabIndex = 2;
            this.combats.Text = "Бои";
            // 
            // transactions
            // 
            this.transactions.Anchor = System.Windows.Forms.AnchorStyles.Top;
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
            this.usersCb.Location = new System.Drawing.Point(10, 73);
            this.usersCb.Name = "usersCb";
            this.usersCb.Size = new System.Drawing.Size(159, 21);
            this.usersCb.TabIndex = 9;
            this.usersCb.SelectedIndexChanged += new System.EventHandler(this.usersCb_SelectedIndexChanged);
            // 
            // transactionsCb
            // 
            this.transactionsCb.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.transactionsCb.FormattingEnabled = true;
            this.transactionsCb.Items.AddRange(new object[] {
            "По сумме",
            "По дате ",
            "По логину игрока"});
            this.transactionsCb.Location = new System.Drawing.Point(235, 73);
            this.transactionsCb.Name = "transactionsCb";
            this.transactionsCb.Size = new System.Drawing.Size(159, 21);
            this.transactionsCb.TabIndex = 11;
            this.transactionsCb.SelectedIndexChanged += new System.EventHandler(this.transactionsCb_SelectedIndexChanged);
            // 
            // loginForTransactions
            // 
            this.loginForTransactions.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.loginForTransactions.Location = new System.Drawing.Point(235, 120);
            this.loginForTransactions.Name = "loginForTransactions";
            this.loginForTransactions.Size = new System.Drawing.Size(159, 20);
            this.loginForTransactions.TabIndex = 12;
            this.loginForTransactions.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.loginForTransactions.Visible = false;
            // 
            // combatsCb
            // 
            this.combatsCb.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.combatsCb.FormattingEnabled = true;
            this.combatsCb.Items.AddRange(new object[] {
            "По типу",
            "По логину игрока"});
            this.combatsCb.Location = new System.Drawing.Point(460, 73);
            this.combatsCb.Name = "combatsCb";
            this.combatsCb.Size = new System.Drawing.Size(159, 21);
            this.combatsCb.TabIndex = 13;
            this.combatsCb.SelectedIndexChanged += new System.EventHandler(this.CombatsCb_SelectedIndexChanged);
            // 
            // loginForCombats
            // 
            this.loginForCombats.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.loginForCombats.Location = new System.Drawing.Point(460, 120);
            this.loginForCombats.Name = "loginForCombats";
            this.loginForCombats.Size = new System.Drawing.Size(159, 20);
            this.loginForCombats.TabIndex = 14;
            this.loginForCombats.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.loginForCombats.Visible = false;
            // 
            // loginForTransactionsLb
            // 
            this.loginForTransactionsLb.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.loginForTransactionsLb.AutoSize = true;
            this.loginForTransactionsLb.Location = new System.Drawing.Point(261, 103);
            this.loginForTransactionsLb.Name = "loginForTransactionsLb";
            this.loginForTransactionsLb.Size = new System.Drawing.Size(110, 13);
            this.loginForTransactionsLb.TabIndex = 15;
            this.loginForTransactionsLb.Text = "Введите логин ниже";
            this.loginForTransactionsLb.Visible = false;
            // 
            // ok
            // 
            this.ok.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.ok.Location = new System.Drawing.Point(530, 406);
            this.ok.Name = "ok";
            this.ok.Size = new System.Drawing.Size(75, 23);
            this.ok.TabIndex = 16;
            this.ok.Text = "OK";
            this.ok.UseVisualStyleBackColor = true;
            this.ok.Click += new System.EventHandler(this.ok_Click);
            // 
            // loginForCombatsLb
            // 
            this.loginForCombatsLb.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.loginForCombatsLb.AutoSize = true;
            this.loginForCombatsLb.Location = new System.Drawing.Point(495, 103);
            this.loginForCombatsLb.Name = "loginForCombatsLb";
            this.loginForCombatsLb.Size = new System.Drawing.Size(110, 13);
            this.loginForCombatsLb.TabIndex = 17;
            this.loginForCombatsLb.Text = "Введите логин ниже";
            this.loginForCombatsLb.Visible = false;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(633, 441);
            this.Controls.Add(this.loginForCombatsLb);
            this.Controls.Add(this.ok);
            this.Controls.Add(this.loginForTransactionsLb);
            this.Controls.Add(this.loginForCombats);
            this.Controls.Add(this.combatsCb);
            this.Controls.Add(this.loginForTransactions);
            this.Controls.Add(this.transactionsCb);
            this.Controls.Add(this.usersCb);
            this.Controls.Add(this.transactions);
            this.Controls.Add(this.combats);
            this.Controls.Add(this.usersLb);
            this.Controls.Add(this.title);
            this.MinimumSize = new System.Drawing.Size(480, 480);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label title;
        private System.Windows.Forms.Label usersLb;
        private System.Windows.Forms.Label combats;
        private System.Windows.Forms.Label transactions;
        private System.Windows.Forms.ComboBox usersCb;
        private System.Windows.Forms.ComboBox transactionsCb;
        private System.Windows.Forms.TextBox loginForTransactions;
        private System.Windows.Forms.ComboBox combatsCb;
        private System.Windows.Forms.TextBox loginForCombats;
        private System.Windows.Forms.Label loginForTransactionsLb;
        private System.Windows.Forms.Button ok;
        private System.Windows.Forms.Label loginForCombatsLb;
    }
}

