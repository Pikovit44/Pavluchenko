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
            this.playersOk = new System.Windows.Forms.Button();
            this.loginForCombatsLb = new System.Windows.Forms.Label();
            this.infoControl = new System.Windows.Forms.TabControl();
            this.playersPage = new System.Windows.Forms.TabPage();
            this.playersByLogin = new System.Windows.Forms.RadioButton();
            this.loginForPlayers = new System.Windows.Forms.TextBox();
            this.playersByNumberOfTransactions = new System.Windows.Forms.RadioButton();
            this.playersByNumberOfCombats = new System.Windows.Forms.RadioButton();
            this.playersByAlphabet = new System.Windows.Forms.RadioButton();
            this.playersByDate = new System.Windows.Forms.RadioButton();
            this.playersByValidEmail = new System.Windows.Forms.RadioButton();
            this.topPlayers = new System.Windows.Forms.RadioButton();
            this.playersTable = new System.Windows.Forms.DataGridView();
            this.transactionsPage = new System.Windows.Forms.TabPage();
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
            // title
            // 
            this.title.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.title.AutoSize = true;
            this.title.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.title.Location = new System.Drawing.Point(207, 9);
            this.title.Name = "title";
            this.title.Size = new System.Drawing.Size(419, 24);
            this.title.TabIndex = 0;
            this.title.Text = "Выберете тип информации для отображения";
            // 
            // playersOk
            // 
            this.playersOk.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.playersOk.Location = new System.Drawing.Point(658, 35);
            this.playersOk.Name = "playersOk";
            this.playersOk.Size = new System.Drawing.Size(75, 23);
            this.playersOk.TabIndex = 16;
            this.playersOk.Text = global::FightClubReports.Properties.Resources.ok;
            this.playersOk.UseVisualStyleBackColor = true;
            this.playersOk.Click += new System.EventHandler(this.playersOk_Click);
            // 
            // loginForCombatsLb
            // 
            this.loginForCombatsLb.AutoSize = true;
            this.loginForCombatsLb.Location = new System.Drawing.Point(295, 6);
            this.loginForCombatsLb.Name = "loginForCombatsLb";
            this.loginForCombatsLb.Size = new System.Drawing.Size(110, 13);
            this.loginForCombatsLb.TabIndex = 17;
            this.loginForCombatsLb.Text = "Введите логин ниже";
            this.loginForCombatsLb.Visible = false;
            // 
            // infoControl
            // 
            this.infoControl.Controls.Add(this.playersPage);
            this.infoControl.Controls.Add(this.transactionsPage);
            this.infoControl.Controls.Add(this.combatsPage);
            this.infoControl.Location = new System.Drawing.Point(31, 36);
            this.infoControl.Name = "infoControl";
            this.infoControl.SelectedIndex = 0;
            this.infoControl.Size = new System.Drawing.Size(785, 334);
            this.infoControl.TabIndex = 21;
            // 
            // playersPage
            // 
            this.playersPage.Controls.Add(this.playersByLogin);
            this.playersPage.Controls.Add(this.playersOk);
            this.playersPage.Controls.Add(this.loginForPlayers);
            this.playersPage.Controls.Add(this.playersByNumberOfTransactions);
            this.playersPage.Controls.Add(this.playersByNumberOfCombats);
            this.playersPage.Controls.Add(this.playersByAlphabet);
            this.playersPage.Controls.Add(this.playersByDate);
            this.playersPage.Controls.Add(this.playersByValidEmail);
            this.playersPage.Controls.Add(this.topPlayers);
            this.playersPage.Controls.Add(this.playersTable);
            this.playersPage.Location = new System.Drawing.Point(4, 22);
            this.playersPage.Name = "playersPage";
            this.playersPage.Padding = new System.Windows.Forms.Padding(3);
            this.playersPage.Size = new System.Drawing.Size(777, 308);
            this.playersPage.TabIndex = 0;
            this.playersPage.Text = "Пользователи";
            this.playersPage.UseVisualStyleBackColor = true;
            // 
            // playersByLogin
            // 
            this.playersByLogin.AutoSize = true;
            this.playersByLogin.Location = new System.Drawing.Point(467, 15);
            this.playersByLogin.Name = "playersByLogin";
            this.playersByLogin.Size = new System.Drawing.Size(76, 17);
            this.playersByLogin.TabIndex = 26;
            this.playersByLogin.Text = "По логину";
            this.playersByLogin.UseVisualStyleBackColor = true;
            // 
            // loginForPlayers
            // 
            this.loginForPlayers.Location = new System.Drawing.Point(446, 37);
            this.loginForPlayers.Name = "loginForPlayers";
            this.loginForPlayers.Size = new System.Drawing.Size(124, 20);
            this.loginForPlayers.TabIndex = 25;
            this.loginForPlayers.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.loginForPlayers.Visible = false;
            // 
            // playersByNumberOfTransactions
            // 
            this.playersByNumberOfTransactions.AutoSize = true;
            this.playersByNumberOfTransactions.Location = new System.Drawing.Point(128, 38);
            this.playersByNumberOfTransactions.Name = "playersByNumberOfTransactions";
            this.playersByNumberOfTransactions.Size = new System.Drawing.Size(167, 17);
            this.playersByNumberOfTransactions.TabIndex = 24;
            this.playersByNumberOfTransactions.Text = "По колличеству транзакций";
            this.playersByNumberOfTransactions.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.playersByNumberOfTransactions.UseVisualStyleBackColor = true;
            // 
            // playersByNumberOfCombats
            // 
            this.playersByNumberOfCombats.AutoSize = true;
            this.playersByNumberOfCombats.Location = new System.Drawing.Point(128, 15);
            this.playersByNumberOfCombats.Name = "playersByNumberOfCombats";
            this.playersByNumberOfCombats.Size = new System.Drawing.Size(125, 17);
            this.playersByNumberOfCombats.TabIndex = 23;
            this.playersByNumberOfCombats.Text = "По колличеству игр";
            this.playersByNumberOfCombats.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.playersByNumberOfCombats.UseVisualStyleBackColor = true;
            // 
            // playersByAlphabet
            // 
            this.playersByAlphabet.AutoSize = true;
            this.playersByAlphabet.Location = new System.Drawing.Point(313, 38);
            this.playersByAlphabet.Name = "playersByAlphabet";
            this.playersByAlphabet.Size = new System.Drawing.Size(90, 17);
            this.playersByAlphabet.TabIndex = 22;
            this.playersByAlphabet.Text = "По алфавиту";
            this.playersByAlphabet.UseVisualStyleBackColor = true;
            // 
            // playersByDate
            // 
            this.playersByDate.AutoSize = true;
            this.playersByDate.Location = new System.Drawing.Point(313, 15);
            this.playersByDate.Name = "playersByDate";
            this.playersByDate.Size = new System.Drawing.Size(106, 17);
            this.playersByDate.TabIndex = 21;
            this.playersByDate.Text = "По регистрации";
            this.playersByDate.UseVisualStyleBackColor = true;
            // 
            // playersByValidEmail
            // 
            this.playersByValidEmail.AutoSize = true;
            this.playersByValidEmail.Location = new System.Drawing.Point(16, 38);
            this.playersByValidEmail.Name = "playersByValidEmail";
            this.playersByValidEmail.Size = new System.Drawing.Size(97, 17);
            this.playersByValidEmail.TabIndex = 20;
            this.playersByValidEmail.Text = "Email валидны";
            this.playersByValidEmail.UseVisualStyleBackColor = true;
            // 
            // topPlayers
            // 
            this.topPlayers.AutoSize = true;
            this.topPlayers.Checked = true;
            this.topPlayers.Location = new System.Drawing.Point(16, 15);
            this.topPlayers.Name = "topPlayers";
            this.topPlayers.Size = new System.Drawing.Size(82, 17);
            this.topPlayers.TabIndex = 19;
            this.topPlayers.TabStop = true;
            this.topPlayers.Text = "Топ лучших";
            this.topPlayers.UseVisualStyleBackColor = true;
            // 
            // playersTable
            // 
            this.playersTable.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.playersTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.playersTable.Location = new System.Drawing.Point(16, 67);
            this.playersTable.Name = "playersTable";
            this.playersTable.Size = new System.Drawing.Size(743, 219);
            this.playersTable.TabIndex = 18;
            // 
            // transactionsPage
            // 
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
            this.transactionsPage.Size = new System.Drawing.Size(777, 308);
            this.transactionsPage.TabIndex = 1;
            this.transactionsPage.Text = "Транзакции";
            this.transactionsPage.UseVisualStyleBackColor = true;
            // 
            // transactionsTable
            // 
            this.transactionsTable.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.transactionsTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.transactionsTable.Location = new System.Drawing.Point(16, 67);
            this.transactionsTable.Name = "transactionsTable";
            this.transactionsTable.Size = new System.Drawing.Size(687, 219);
            this.transactionsTable.TabIndex = 26;
            // 
            // transactionsOk
            // 
            this.transactionsOk.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.transactionsOk.Location = new System.Drawing.Point(436, 19);
            this.transactionsOk.Name = "transactionsOk";
            this.transactionsOk.Size = new System.Drawing.Size(75, 23);
            this.transactionsOk.TabIndex = 25;
            this.transactionsOk.Text = global::FightClubReports.Properties.Resources.ok;
            this.transactionsOk.UseVisualStyleBackColor = true;
            this.transactionsOk.Click += new System.EventHandler(this.transactionsOk_Click);
            // 
            // transactionsByLogin
            // 
            this.transactionsByLogin.AutoSize = true;
            this.transactionsByLogin.Location = new System.Drawing.Point(190, 21);
            this.transactionsByLogin.Name = "transactionsByLogin";
            this.transactionsByLogin.Size = new System.Drawing.Size(76, 17);
            this.transactionsByLogin.TabIndex = 24;
            this.transactionsByLogin.Text = "По логину";
            this.transactionsByLogin.UseVisualStyleBackColor = true;
            // 
            // transactionsByDate
            // 
            this.transactionsByDate.AutoSize = true;
            this.transactionsByDate.Location = new System.Drawing.Point(107, 21);
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
            this.transactionsBySum.Location = new System.Drawing.Point(16, 21);
            this.transactionsBySum.Name = "transactionsBySum";
            this.transactionsBySum.Size = new System.Drawing.Size(75, 17);
            this.transactionsBySum.TabIndex = 22;
            this.transactionsBySum.TabStop = true;
            this.transactionsBySum.Text = "По сумме";
            this.transactionsBySum.UseVisualStyleBackColor = true;
            // 
            // loginForTransactions
            // 
            this.loginForTransactions.Location = new System.Drawing.Point(288, 21);
            this.loginForTransactions.Name = "loginForTransactions";
            this.loginForTransactions.Size = new System.Drawing.Size(125, 20);
            this.loginForTransactions.TabIndex = 20;
            this.loginForTransactions.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.loginForTransactions.Visible = false;
            // 
            // loginForTransactionsLb
            // 
            this.loginForTransactionsLb.AutoSize = true;
            this.loginForTransactionsLb.Location = new System.Drawing.Point(295, 6);
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
            this.combatsPage.Size = new System.Drawing.Size(777, 308);
            this.combatsPage.TabIndex = 2;
            this.combatsPage.Text = "Бои";
            this.combatsPage.UseVisualStyleBackColor = true;
            // 
            // loginForCombats
            // 
            this.loginForCombats.Location = new System.Drawing.Point(288, 21);
            this.loginForCombats.Name = "loginForCombats";
            this.loginForCombats.Size = new System.Drawing.Size(125, 20);
            this.loginForCombats.TabIndex = 34;
            this.loginForCombats.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.loginForCombats.Visible = false;
            // 
            // combatsTable
            // 
            this.combatsTable.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.combatsTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.combatsTable.Location = new System.Drawing.Point(16, 67);
            this.combatsTable.Name = "combatsTable";
            this.combatsTable.Size = new System.Drawing.Size(743, 219);
            this.combatsTable.TabIndex = 33;
            // 
            // combatsOk
            // 
            this.combatsOk.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.combatsOk.Location = new System.Drawing.Point(492, 19);
            this.combatsOk.Name = "combatsOk";
            this.combatsOk.Size = new System.Drawing.Size(75, 23);
            this.combatsOk.TabIndex = 32;
            this.combatsOk.Text = global::FightClubReports.Properties.Resources.ok;
            this.combatsOk.UseVisualStyleBackColor = true;
            this.combatsOk.Click += new System.EventHandler(this.combatsOk_Click);
            // 
            // combatsByLogin
            // 
            this.combatsByLogin.AutoSize = true;
            this.combatsByLogin.Location = new System.Drawing.Point(190, 21);
            this.combatsByLogin.Name = "combatsByLogin";
            this.combatsByLogin.Size = new System.Drawing.Size(76, 17);
            this.combatsByLogin.TabIndex = 31;
            this.combatsByLogin.Text = "По логину";
            this.combatsByLogin.UseVisualStyleBackColor = true;
            // 
            // combatsByDate
            // 
            this.combatsByDate.AutoSize = true;
            this.combatsByDate.Location = new System.Drawing.Point(107, 21);
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
            this.combatsByType.Location = new System.Drawing.Point(16, 21);
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
            this.ClientSize = new System.Drawing.Size(875, 396);
            this.Controls.Add(this.infoControl);
            this.Controls.Add(this.title);
            this.MinimumSize = new System.Drawing.Size(530, 410);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
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
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label title;
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
        private System.Windows.Forms.RadioButton playersByNumberOfTransactions;
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
    }
}

