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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.playersOk = new System.Windows.Forms.Button();
            this.loginForCombatsLb = new System.Windows.Forms.Label();
            this.infoControl = new System.Windows.Forms.TabControl();
            this.playersPage = new System.Windows.Forms.TabPage();
            this.save = new System.Windows.Forms.Button();
            this.emailEditTb = new System.Windows.Forms.TextBox();
            this.emailEditLb = new System.Windows.Forms.Label();
            this.passwordEditTb = new System.Windows.Forms.TextBox();
            this.passwordEditLb = new System.Windows.Forms.Label();
            this.loginEditTb = new System.Windows.Forms.TextBox();
            this.loginEditLb = new System.Windows.Forms.Label();
            this.playersByLogin = new System.Windows.Forms.RadioButton();
            this.loginForPlayers = new System.Windows.Forms.TextBox();
            this.playersByNumberOfCombats = new System.Windows.Forms.RadioButton();
            this.playersByAlphabet = new System.Windows.Forms.RadioButton();
            this.playersByDate = new System.Windows.Forms.RadioButton();
            this.playersByValidEmail = new System.Windows.Forms.RadioButton();
            this.topPlayers = new System.Windows.Forms.RadioButton();
            this.playersTable = new System.Windows.Forms.DataGridView();
            this.transactionsPage = new System.Windows.Forms.TabPage();
            this.sumLb = new System.Windows.Forms.Label();
            this.transactionsTable = new System.Windows.Forms.DataGridView();
            this.transactionsOk = new System.Windows.Forms.Button();
            this.transactionsByLogin = new System.Windows.Forms.RadioButton();
            this.transactionsByDate = new System.Windows.Forms.RadioButton();
            this.transactionsBySum = new System.Windows.Forms.RadioButton();
            this.loginForTransactions = new System.Windows.Forms.TextBox();
            this.loginForTransactionsLb = new System.Windows.Forms.Label();
            this.combatsPage = new System.Windows.Forms.TabPage();
            this.loginForCombats = new System.Windows.Forms.TextBox();
            this.combatsTable = new System.Windows.Forms.DataGridView();
            this.combatsOk = new System.Windows.Forms.Button();
            this.combatsByLogin = new System.Windows.Forms.RadioButton();
            this.combatsByDate = new System.Windows.Forms.RadioButton();
            this.combatsByType = new System.Windows.Forms.RadioButton();
            this.infoControl.SuspendLayout();
            this.playersPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.playersTable)).BeginInit();
            this.transactionsPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.transactionsTable)).BeginInit();
            this.combatsPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.combatsTable)).BeginInit();
            this.SuspendLayout();
            // 
            // playersOk
            // 
            this.playersOk.Location = new System.Drawing.Point(709, 8);
            this.playersOk.Name = "playersOk";
            this.playersOk.Size = new System.Drawing.Size(33, 21);
            this.playersOk.TabIndex = 16;
            this.playersOk.Text = "OK";
            this.playersOk.UseVisualStyleBackColor = true;
            this.playersOk.Visible = false;
            this.playersOk.Click += new System.EventHandler(this.playersOk_Click);
            // 
            // loginForCombatsLb
            // 
            this.loginForCombatsLb.AutoSize = true;
            this.loginForCombatsLb.Location = new System.Drawing.Point(379, 5);
            this.loginForCombatsLb.Name = "loginForCombatsLb";
            this.loginForCombatsLb.Size = new System.Drawing.Size(110, 13);
            this.loginForCombatsLb.TabIndex = 17;
            this.loginForCombatsLb.Text = "Введите логин ниже";
            this.loginForCombatsLb.Visible = false;
            // 
            // infoControl
            // 
            this.infoControl.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.infoControl.Controls.Add(this.playersPage);
            this.infoControl.Controls.Add(this.transactionsPage);
            this.infoControl.Controls.Add(this.combatsPage);
            this.infoControl.Location = new System.Drawing.Point(27, 12);
            this.infoControl.Name = "infoControl";
            this.infoControl.SelectedIndex = 0;
            this.infoControl.Size = new System.Drawing.Size(756, 355);
            this.infoControl.TabIndex = 21;
            // 
            // playersPage
            // 
            this.playersPage.Controls.Add(this.save);
            this.playersPage.Controls.Add(this.emailEditTb);
            this.playersPage.Controls.Add(this.emailEditLb);
            this.playersPage.Controls.Add(this.passwordEditTb);
            this.playersPage.Controls.Add(this.passwordEditLb);
            this.playersPage.Controls.Add(this.loginEditTb);
            this.playersPage.Controls.Add(this.loginEditLb);
            this.playersPage.Controls.Add(this.playersByLogin);
            this.playersPage.Controls.Add(this.playersOk);
            this.playersPage.Controls.Add(this.loginForPlayers);
            this.playersPage.Controls.Add(this.playersByNumberOfCombats);
            this.playersPage.Controls.Add(this.playersByAlphabet);
            this.playersPage.Controls.Add(this.playersByDate);
            this.playersPage.Controls.Add(this.playersByValidEmail);
            this.playersPage.Controls.Add(this.topPlayers);
            this.playersPage.Controls.Add(this.playersTable);
            this.playersPage.Location = new System.Drawing.Point(4, 22);
            this.playersPage.Name = "playersPage";
            this.playersPage.Padding = new System.Windows.Forms.Padding(3);
            this.playersPage.Size = new System.Drawing.Size(748, 329);
            this.playersPage.TabIndex = 0;
            this.playersPage.Text = "Пользователи";
            this.playersPage.UseVisualStyleBackColor = true;
            // 
            // save
            // 
            this.save.Location = new System.Drawing.Point(554, 266);
            this.save.Name = "save";
            this.save.Size = new System.Drawing.Size(135, 21);
            this.save.TabIndex = 32;
            this.save.Text = "Сохранить изменения";
            this.save.UseVisualStyleBackColor = true;
            this.save.Click += new System.EventHandler(this.save_Click);
            // 
            // emailEditTb
            // 
            this.emailEditTb.Location = new System.Drawing.Point(384, 266);
            this.emailEditTb.Name = "emailEditTb";
            this.emailEditTb.Size = new System.Drawing.Size(118, 20);
            this.emailEditTb.TabIndex = 31;
            // 
            // emailEditLb
            // 
            this.emailEditLb.AutoSize = true;
            this.emailEditLb.Location = new System.Drawing.Point(346, 269);
            this.emailEditLb.Name = "emailEditLb";
            this.emailEditLb.Size = new System.Drawing.Size(32, 13);
            this.emailEditLb.TabIndex = 30;
            this.emailEditLb.Text = "Email";
            // 
            // passwordEditTb
            // 
            this.passwordEditTb.Location = new System.Drawing.Point(222, 266);
            this.passwordEditTb.Name = "passwordEditTb";
            this.passwordEditTb.Size = new System.Drawing.Size(118, 20);
            this.passwordEditTb.TabIndex = 29;
            // 
            // passwordEditLb
            // 
            this.passwordEditLb.AutoSize = true;
            this.passwordEditLb.Location = new System.Drawing.Point(171, 269);
            this.passwordEditLb.Name = "passwordEditLb";
            this.passwordEditLb.Size = new System.Drawing.Size(45, 13);
            this.passwordEditLb.TabIndex = 28;
            this.passwordEditLb.Text = "Пароль";
            // 
            // loginEditTb
            // 
            this.loginEditTb.Location = new System.Drawing.Point(47, 266);
            this.loginEditTb.Name = "loginEditTb";
            this.loginEditTb.Size = new System.Drawing.Size(118, 20);
            this.loginEditTb.TabIndex = 27;
            // 
            // loginEditLb
            // 
            this.loginEditLb.AutoSize = true;
            this.loginEditLb.Location = new System.Drawing.Point(3, 270);
            this.loginEditLb.Name = "loginEditLb";
            this.loginEditLb.Size = new System.Drawing.Size(38, 13);
            this.loginEditLb.TabIndex = 22;
            this.loginEditLb.Text = "Логин";
            // 
            // playersByLogin
            // 
            this.playersByLogin.AutoSize = true;
            this.playersByLogin.Location = new System.Drawing.Point(529, 11);
            this.playersByLogin.Name = "playersByLogin";
            this.playersByLogin.Size = new System.Drawing.Size(76, 17);
            this.playersByLogin.TabIndex = 26;
            this.playersByLogin.Text = "По логину";
            this.playersByLogin.UseVisualStyleBackColor = true;
            this.playersByLogin.CheckedChanged += new System.EventHandler(this.playersByLogin_CheckedChanged);
            // 
            // loginForPlayers
            // 
            this.loginForPlayers.Location = new System.Drawing.Point(605, 9);
            this.loginForPlayers.Name = "loginForPlayers";
            this.loginForPlayers.Size = new System.Drawing.Size(98, 20);
            this.loginForPlayers.TabIndex = 25;
            this.loginForPlayers.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.loginForPlayers.Visible = false;
            // 
            // playersByNumberOfCombats
            // 
            this.playersByNumberOfCombats.AutoSize = true;
            this.playersByNumberOfCombats.Location = new System.Drawing.Point(194, 10);
            this.playersByNumberOfCombats.Name = "playersByNumberOfCombats";
            this.playersByNumberOfCombats.Size = new System.Drawing.Size(125, 17);
            this.playersByNumberOfCombats.TabIndex = 23;
            this.playersByNumberOfCombats.Text = "По колличеству игр";
            this.playersByNumberOfCombats.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.playersByNumberOfCombats.UseVisualStyleBackColor = true;
            this.playersByNumberOfCombats.CheckedChanged += new System.EventHandler(this.playersByNumberOfCombats_CheckedChanged);
            // 
            // playersByAlphabet
            // 
            this.playersByAlphabet.AutoSize = true;
            this.playersByAlphabet.Location = new System.Drawing.Point(325, 10);
            this.playersByAlphabet.Name = "playersByAlphabet";
            this.playersByAlphabet.Size = new System.Drawing.Size(90, 17);
            this.playersByAlphabet.TabIndex = 22;
            this.playersByAlphabet.Text = "По алфавиту";
            this.playersByAlphabet.UseVisualStyleBackColor = true;
            this.playersByAlphabet.CheckedChanged += new System.EventHandler(this.playersByAlphabet_CheckedChanged);
            // 
            // playersByDate
            // 
            this.playersByDate.AutoSize = true;
            this.playersByDate.Location = new System.Drawing.Point(417, 10);
            this.playersByDate.Name = "playersByDate";
            this.playersByDate.Size = new System.Drawing.Size(106, 17);
            this.playersByDate.TabIndex = 21;
            this.playersByDate.Text = "По регистрации";
            this.playersByDate.UseVisualStyleBackColor = true;
            this.playersByDate.CheckedChanged += new System.EventHandler(this.playersByDate_CheckedChanged);
            // 
            // playersByValidEmail
            // 
            this.playersByValidEmail.AutoSize = true;
            this.playersByValidEmail.Location = new System.Drawing.Point(91, 11);
            this.playersByValidEmail.Name = "playersByValidEmail";
            this.playersByValidEmail.Size = new System.Drawing.Size(97, 17);
            this.playersByValidEmail.TabIndex = 20;
            this.playersByValidEmail.Text = "Email валидны";
            this.playersByValidEmail.UseVisualStyleBackColor = true;
            this.playersByValidEmail.CheckedChanged += new System.EventHandler(this.playersByValidEmail_CheckedChanged);
            // 
            // topPlayers
            // 
            this.topPlayers.AutoSize = true;
            this.topPlayers.Checked = true;
            this.topPlayers.Location = new System.Drawing.Point(6, 10);
            this.topPlayers.Name = "topPlayers";
            this.topPlayers.Size = new System.Drawing.Size(82, 17);
            this.topPlayers.TabIndex = 19;
            this.topPlayers.TabStop = true;
            this.topPlayers.Text = "Топ лучших";
            this.topPlayers.UseVisualStyleBackColor = true;
            this.topPlayers.CheckedChanged += new System.EventHandler(this.topPlayers_CheckedChanged);
            // 
            // playersTable
            // 
            this.playersTable.AllowUserToAddRows = false;
            this.playersTable.AllowUserToDeleteRows = false;
            this.playersTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.playersTable.Location = new System.Drawing.Point(0, 34);
            this.playersTable.Name = "playersTable";
            this.playersTable.ReadOnly = true;
            this.playersTable.Size = new System.Drawing.Size(748, 225);
            this.playersTable.TabIndex = 18;
            // 
            // transactionsPage
            // 
            this.transactionsPage.Controls.Add(this.sumLb);
            this.transactionsPage.Controls.Add(this.transactionsTable);
            this.transactionsPage.Controls.Add(this.transactionsOk);
            this.transactionsPage.Controls.Add(this.transactionsByLogin);
            this.transactionsPage.Controls.Add(this.transactionsByDate);
            this.transactionsPage.Controls.Add(this.transactionsBySum);
            this.transactionsPage.Controls.Add(this.loginForTransactions);
            this.transactionsPage.Controls.Add(this.loginForTransactionsLb);
            this.transactionsPage.Location = new System.Drawing.Point(4, 22);
            this.transactionsPage.Name = "transactionsPage";
            this.transactionsPage.Padding = new System.Windows.Forms.Padding(3);
            this.transactionsPage.Size = new System.Drawing.Size(748, 329);
            this.transactionsPage.TabIndex = 1;
            this.transactionsPage.Text = "Транзакции";
            this.transactionsPage.UseVisualStyleBackColor = true;
            // 
            // sumLb
            // 
            this.sumLb.AutoSize = true;
            this.sumLb.Location = new System.Drawing.Point(173, 266);
            this.sumLb.Name = "sumLb";
            this.sumLb.Size = new System.Drawing.Size(41, 13);
            this.sumLb.TabIndex = 29;
            this.sumLb.Text = "Сумма";
            // 
            // transactionsTable
            // 
            this.transactionsTable.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.transactionsTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.transactionsTable.Location = new System.Drawing.Point(162, 58);
            this.transactionsTable.Name = "transactionsTable";
            this.transactionsTable.Size = new System.Drawing.Size(414, 205);
            this.transactionsTable.TabIndex = 26;
            // 
            // transactionsOk
            // 
            this.transactionsOk.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.transactionsOk.Location = new System.Drawing.Point(519, 19);
            this.transactionsOk.Name = "transactionsOk";
            this.transactionsOk.Size = new System.Drawing.Size(75, 23);
            this.transactionsOk.TabIndex = 25;
            this.transactionsOk.Text = "ОК";
            this.transactionsOk.UseVisualStyleBackColor = true;
            this.transactionsOk.Click += new System.EventHandler(this.transactionsOk_Click);
            // 
            // transactionsByLogin
            // 
            this.transactionsByLogin.AutoSize = true;
            this.transactionsByLogin.Location = new System.Drawing.Point(325, 21);
            this.transactionsByLogin.Name = "transactionsByLogin";
            this.transactionsByLogin.Size = new System.Drawing.Size(76, 17);
            this.transactionsByLogin.TabIndex = 24;
            this.transactionsByLogin.Text = "По логину";
            this.transactionsByLogin.UseVisualStyleBackColor = true;
            this.transactionsByLogin.CheckedChanged += new System.EventHandler(this.transactionsByLogin_CheckedChanged);
            // 
            // transactionsByDate
            // 
            this.transactionsByDate.AutoSize = true;
            this.transactionsByDate.Location = new System.Drawing.Point(242, 21);
            this.transactionsByDate.Name = "transactionsByDate";
            this.transactionsByDate.Size = new System.Drawing.Size(65, 17);
            this.transactionsByDate.TabIndex = 23;
            this.transactionsByDate.Text = "По дате";
            this.transactionsByDate.UseVisualStyleBackColor = true;
            // 
            // transactionsBySum
            // 
            this.transactionsBySum.AutoSize = true;
            this.transactionsBySum.Checked = true;
            this.transactionsBySum.Location = new System.Drawing.Point(151, 21);
            this.transactionsBySum.Name = "transactionsBySum";
            this.transactionsBySum.Size = new System.Drawing.Size(75, 17);
            this.transactionsBySum.TabIndex = 22;
            this.transactionsBySum.TabStop = true;
            this.transactionsBySum.Text = "По сумме";
            this.transactionsBySum.UseVisualStyleBackColor = true;
            // 
            // loginForTransactions
            // 
            this.loginForTransactions.Location = new System.Drawing.Point(407, 21);
            this.loginForTransactions.Name = "loginForTransactions";
            this.loginForTransactions.Size = new System.Drawing.Size(125, 20);
            this.loginForTransactions.TabIndex = 20;
            this.loginForTransactions.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.loginForTransactions.Visible = false;
            // 
            // loginForTransactionsLb
            // 
            this.loginForTransactionsLb.AutoSize = true;
            this.loginForTransactionsLb.Location = new System.Drawing.Point(414, 6);
            this.loginForTransactionsLb.Name = "loginForTransactionsLb";
            this.loginForTransactionsLb.Size = new System.Drawing.Size(110, 13);
            this.loginForTransactionsLb.TabIndex = 21;
            this.loginForTransactionsLb.Text = "Введите логин ниже";
            this.loginForTransactionsLb.Visible = false;
            // 
            // combatsPage
            // 
            this.combatsPage.Controls.Add(this.loginForCombats);
            this.combatsPage.Controls.Add(this.combatsTable);
            this.combatsPage.Controls.Add(this.combatsOk);
            this.combatsPage.Controls.Add(this.combatsByLogin);
            this.combatsPage.Controls.Add(this.combatsByDate);
            this.combatsPage.Controls.Add(this.combatsByType);
            this.combatsPage.Controls.Add(this.loginForCombatsLb);
            this.combatsPage.Location = new System.Drawing.Point(4, 22);
            this.combatsPage.Name = "combatsPage";
            this.combatsPage.Size = new System.Drawing.Size(748, 329);
            this.combatsPage.TabIndex = 2;
            this.combatsPage.Text = "Бои";
            this.combatsPage.UseVisualStyleBackColor = true;
            // 
            // loginForCombats
            // 
            this.loginForCombats.Location = new System.Drawing.Point(372, 20);
            this.loginForCombats.Name = "loginForCombats";
            this.loginForCombats.Size = new System.Drawing.Size(125, 20);
            this.loginForCombats.TabIndex = 34;
            this.loginForCombats.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.loginForCombats.Visible = false;
            // 
            // combatsTable
            // 
            this.combatsTable.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.combatsTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.combatsTable.Location = new System.Drawing.Point(2, 54);
            this.combatsTable.Name = "combatsTable";
            this.combatsTable.Size = new System.Drawing.Size(743, 253);
            this.combatsTable.TabIndex = 33;
            // 
            // combatsOk
            // 
            this.combatsOk.Location = new System.Drawing.Point(513, 18);
            this.combatsOk.Name = "combatsOk";
            this.combatsOk.Size = new System.Drawing.Size(75, 23);
            this.combatsOk.TabIndex = 32;
            this.combatsOk.Text = "ОК";
            this.combatsOk.UseVisualStyleBackColor = true;
            this.combatsOk.Click += new System.EventHandler(this.combatsOk_Click);
            // 
            // combatsByLogin
            // 
            this.combatsByLogin.AutoSize = true;
            this.combatsByLogin.Location = new System.Drawing.Point(290, 20);
            this.combatsByLogin.Name = "combatsByLogin";
            this.combatsByLogin.Size = new System.Drawing.Size(76, 17);
            this.combatsByLogin.TabIndex = 31;
            this.combatsByLogin.Text = "По логину";
            this.combatsByLogin.UseVisualStyleBackColor = true;
            this.combatsByLogin.CheckedChanged += new System.EventHandler(this.combatsByLogin_CheckedChanged);
            // 
            // combatsByDate
            // 
            this.combatsByDate.AutoSize = true;
            this.combatsByDate.Location = new System.Drawing.Point(207, 20);
            this.combatsByDate.Name = "combatsByDate";
            this.combatsByDate.Size = new System.Drawing.Size(65, 17);
            this.combatsByDate.TabIndex = 30;
            this.combatsByDate.Text = "По дате";
            this.combatsByDate.UseVisualStyleBackColor = true;
            // 
            // combatsByType
            // 
            this.combatsByType.AutoSize = true;
            this.combatsByType.Checked = true;
            this.combatsByType.Location = new System.Drawing.Point(116, 20);
            this.combatsByType.Name = "combatsByType";
            this.combatsByType.Size = new System.Drawing.Size(64, 17);
            this.combatsByType.TabIndex = 29;
            this.combatsByType.TabStop = true;
            this.combatsByType.Text = "По типу";
            this.combatsByType.UseVisualStyleBackColor = true;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(867, 478);
            this.Controls.Add(this.infoControl);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(2000, 1200);
            this.MinimumSize = new System.Drawing.Size(870, 480);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Fight Club Analitycs";
            this.infoControl.ResumeLayout(false);
            this.playersPage.ResumeLayout(false);
            this.playersPage.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.playersTable)).EndInit();
            this.transactionsPage.ResumeLayout(false);
            this.transactionsPage.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.transactionsTable)).EndInit();
            this.combatsPage.ResumeLayout(false);
            this.combatsPage.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.combatsTable)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button playersOk;
        private System.Windows.Forms.Label loginForCombatsLb;
        private System.Windows.Forms.TabControl infoControl;
        private System.Windows.Forms.TabPage playersPage;
        private System.Windows.Forms.TabPage transactionsPage;
        private System.Windows.Forms.TabPage combatsPage;
        private System.Windows.Forms.RadioButton playersByNumberOfCombats;
        private System.Windows.Forms.RadioButton playersByAlphabet;
        private System.Windows.Forms.RadioButton playersByDate;
        private System.Windows.Forms.RadioButton playersByValidEmail;
        private System.Windows.Forms.RadioButton topPlayers;
        private System.Windows.Forms.TextBox loginForPlayers;
        private System.Windows.Forms.DataGridView playersTable;
        private System.Windows.Forms.DataGridView transactionsTable;
        private System.Windows.Forms.Button transactionsOk;
        private System.Windows.Forms.RadioButton transactionsByLogin;
        private System.Windows.Forms.RadioButton transactionsByDate;
        private System.Windows.Forms.RadioButton transactionsBySum;
        private System.Windows.Forms.TextBox loginForTransactions;
        private System.Windows.Forms.Label loginForTransactionsLb;
        private System.Windows.Forms.TextBox loginForCombats;
        private System.Windows.Forms.DataGridView combatsTable;
        private System.Windows.Forms.Button combatsOk;
        private System.Windows.Forms.RadioButton combatsByLogin;
        private System.Windows.Forms.RadioButton combatsByDate;
        private System.Windows.Forms.RadioButton combatsByType;
        private System.Windows.Forms.RadioButton playersByLogin;
        private System.Windows.Forms.Label loginEditLb;
        private System.Windows.Forms.TextBox loginEditTb;
        private System.Windows.Forms.TextBox emailEditTb;
        private System.Windows.Forms.Label emailEditLb;
        private System.Windows.Forms.TextBox passwordEditTb;
        private System.Windows.Forms.Label passwordEditLb;
        private System.Windows.Forms.Button save;
        private System.Windows.Forms.Label sumLb;
    }
}

