using FightClubReports.Properties;
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
            this.table = new System.Windows.Forms.DataGridView();
            this.saveChanges = new System.Windows.Forms.Button();
            this.сancelСhanges = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.textBox1 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.table)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.SuspendLayout();
            // 
            // title
            // 
            this.title.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.title.AutoSize = true;
            this.title.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.title.Location = new System.Drawing.Point(169, 9);
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
            this.combats.AutoSize = true;
            this.combats.Location = new System.Drawing.Point(408, 57);
            this.combats.Name = "combats";
            this.combats.Size = new System.Drawing.Size(26, 13);
            this.combats.TabIndex = 2;
            this.combats.Text = "Бои";
            // 
            // transactions
            // 
            this.transactions.AutoSize = true;
            this.transactions.Location = new System.Drawing.Point(223, 57);
            this.transactions.Name = "transactions";
            this.transactions.Size = new System.Drawing.Size(68, 13);
            this.transactions.TabIndex = 3;
            this.transactions.Text = "Транзакции";
            // 
            // usersCb
            // 
            this.usersCb.FormattingEnabled = true;
            this.usersCb.Items.AddRange(new object[] {
            global::FightClubReports.Properties.Resources.topPlayers,
            global::FightClubReports.Properties.Resources.playersByValidEmail,
            global::FightClubReports.Properties.Resources.playersByDate,
            global::FightClubReports.Properties.Resources.playersByAlphabet,
            global::FightClubReports.Properties.Resources.playersByNumberOfCombats,
            global::FightClubReports.Properties.Resources.playersByNumberOfTransactions});
            this.usersCb.Location = new System.Drawing.Point(10, 73);
            this.usersCb.Name = "usersCb";
            this.usersCb.Size = new System.Drawing.Size(159, 21);
            this.usersCb.TabIndex = 9;
            this.usersCb.SelectedIndexChanged += new System.EventHandler(this.usersCb_SelectedIndexChanged);
            // 
            // transactionsCb
            // 
            this.transactionsCb.FormattingEnabled = true;
            this.transactionsCb.Items.AddRange(new object[] {
            global::FightClubReports.Properties.Resources.transactionsBySum,
            global::FightClubReports.Properties.Resources.transactionsByDate,
            global::FightClubReports.Properties.Resources.transactionsByLogin});
            this.transactionsCb.Location = new System.Drawing.Point(177, 73);
            this.transactionsCb.Name = "transactionsCb";
            this.transactionsCb.Size = new System.Drawing.Size(159, 21);
            this.transactionsCb.TabIndex = 11;
            this.transactionsCb.SelectedIndexChanged += new System.EventHandler(this.transactionsCb_SelectedIndexChanged);
            // 
            // loginForTransactions
            // 
            this.loginForTransactions.Location = new System.Drawing.Point(177, 120);
            this.loginForTransactions.Name = "loginForTransactions";
            this.loginForTransactions.Size = new System.Drawing.Size(159, 20);
            this.loginForTransactions.TabIndex = 12;
            this.loginForTransactions.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.loginForTransactions.Visible = false;
            // 
            // combatsCb
            // 
            this.combatsCb.FormattingEnabled = true;
            this.combatsCb.Items.AddRange(new object[] {
            global::FightClubReports.Properties.Resources.combatsByType,
            global::FightClubReports.Properties.Resources.combatsByLogin});
            this.combatsCb.Location = new System.Drawing.Point(342, 73);
            this.combatsCb.Name = "combatsCb";
            this.combatsCb.Size = new System.Drawing.Size(159, 21);
            this.combatsCb.TabIndex = 13;
            this.combatsCb.SelectedIndexChanged += new System.EventHandler(this.CombatsCb_SelectedIndexChanged);
            // 
            // loginForCombats
            // 
            this.loginForCombats.Location = new System.Drawing.Point(342, 120);
            this.loginForCombats.Name = "loginForCombats";
            this.loginForCombats.Size = new System.Drawing.Size(159, 20);
            this.loginForCombats.TabIndex = 14;
            this.loginForCombats.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.loginForCombats.Visible = false;
            // 
            // loginForTransactionsLb
            // 
            this.loginForTransactionsLb.AutoSize = true;
            this.loginForTransactionsLb.Location = new System.Drawing.Point(203, 103);
            this.loginForTransactionsLb.Name = "loginForTransactionsLb";
            this.loginForTransactionsLb.Size = new System.Drawing.Size(110, 13);
            this.loginForTransactionsLb.TabIndex = 15;
            this.loginForTransactionsLb.Text = "Введите логин ниже";
            this.loginForTransactionsLb.Visible = false;
            // 
            // ok
            // 
            this.ok.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.ok.Location = new System.Drawing.Point(666, 406);
            this.ok.Name = "ok";
            this.ok.Size = new System.Drawing.Size(75, 23);
            this.ok.TabIndex = 16;
            this.ok.Text = global::FightClubReports.Properties.Resources.ok;
            this.ok.UseVisualStyleBackColor = true;
            this.ok.Click += new System.EventHandler(this.ok_Click);
            // 
            // loginForCombatsLb
            // 
            this.loginForCombatsLb.AutoSize = true;
            this.loginForCombatsLb.Location = new System.Drawing.Point(377, 103);
            this.loginForCombatsLb.Name = "loginForCombatsLb";
            this.loginForCombatsLb.Size = new System.Drawing.Size(110, 13);
            this.loginForCombatsLb.TabIndex = 17;
            this.loginForCombatsLb.Text = "Введите логин ниже";
            this.loginForCombatsLb.Visible = false;
            // 
            // table
            // 
            this.table.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.table.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.table.Location = new System.Drawing.Point(12, 146);
            this.table.Name = "table";
            this.table.Size = new System.Drawing.Size(743, 254);
            this.table.TabIndex = 18;
            // 
            // saveChanges
            // 
            this.saveChanges.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.saveChanges.Location = new System.Drawing.Point(12, 406);
            this.saveChanges.Name = "saveChanges";
            this.saveChanges.Size = new System.Drawing.Size(175, 23);
            this.saveChanges.TabIndex = 19;
            this.saveChanges.Text = global::FightClubReports.Properties.Resources.saveChanges;
            this.saveChanges.UseVisualStyleBackColor = true;
            this.saveChanges.Click += new System.EventHandler(this.saveChanges_Click);
            // 
            // сancelСhanges
            // 
            this.сancelСhanges.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.сancelСhanges.Location = new System.Drawing.Point(193, 406);
            this.сancelСhanges.Name = "сancelСhanges";
            this.сancelСhanges.Size = new System.Drawing.Size(175, 23);
            this.сancelСhanges.TabIndex = 20;
            this.сancelСhanges.Text = global::FightClubReports.Properties.Resources.cancelChanges;
            this.сancelСhanges.UseVisualStyleBackColor = true;
            this.сancelСhanges.Click += new System.EventHandler(this.сancelСhanges_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(530, 36);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(200, 100);
            this.tabControl1.TabIndex = 21;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.textBox1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(192, 74);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "tabPage1";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(192, 74);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "tabPage2";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(35, 16);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 0;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(769, 441);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.сancelСhanges);
            this.Controls.Add(this.saveChanges);
            this.Controls.Add(this.table);
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
            this.MinimumSize = new System.Drawing.Size(530, 480);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            ((System.ComponentModel.ISupportInitialize)(this.table)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
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
        private System.Windows.Forms.DataGridView table;
        private System.Windows.Forms.Button saveChanges;
        private System.Windows.Forms.Button сancelСhanges;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TextBox textBox1;
    }
}

