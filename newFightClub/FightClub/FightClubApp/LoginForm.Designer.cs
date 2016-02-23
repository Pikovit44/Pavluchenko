namespace FightClubApp
{
    partial class LoginForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginForm));
            this.records = new System.Windows.Forms.Button();
            this.choosePlayer = new System.Windows.Forms.ComboBox();
            this.toFightMenu = new System.Windows.Forms.Button();
            this.rules = new System.Windows.Forms.Button();
            this.signIn = new System.Windows.Forms.Label();
            this.newPlayerName = new System.Windows.Forms.TextBox();
            this.newPlayer = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // records
            // 
            this.records.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.records.Location = new System.Drawing.Point(284, 22);
            this.records.Name = "records";
            this.records.Size = new System.Drawing.Size(110, 31);
            this.records.TabIndex = 2;
            this.records.Text = "Рекорды";
            this.records.UseVisualStyleBackColor = true;
            // 
            // choosePlayer
            // 
            this.choosePlayer.FormattingEnabled = true;
            this.choosePlayer.Location = new System.Drawing.Point(500, 96);
            this.choosePlayer.Name = "choosePlayer";
            this.choosePlayer.Size = new System.Drawing.Size(153, 21);
            this.choosePlayer.TabIndex = 3;
            // 
            // toFightMenu
            // 
            this.toFightMenu.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.toFightMenu.Location = new System.Drawing.Point(500, 360);
            this.toFightMenu.Name = "toFightMenu";
            this.toFightMenu.Size = new System.Drawing.Size(153, 31);
            this.toFightMenu.TabIndex = 5;
            this.toFightMenu.Text = "Начать схватку";
            this.toFightMenu.UseVisualStyleBackColor = true;
            this.toFightMenu.Click += new System.EventHandler(this.FightButton_Click);
            // 
            // rules
            // 
            this.rules.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.rules.Location = new System.Drawing.Point(128, 360);
            this.rules.Name = "rules";
            this.rules.Size = new System.Drawing.Size(110, 31);
            this.rules.TabIndex = 6;
            this.rules.Text = "Правила";
            this.rules.UseVisualStyleBackColor = true;
            // 
            // signIn
            // 
            this.signIn.AutoSize = true;
            this.signIn.BackColor = System.Drawing.Color.Transparent;
            this.signIn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.signIn.ForeColor = System.Drawing.Color.White;
            this.signIn.Location = new System.Drawing.Point(471, 49);
            this.signIn.Name = "signIn";
            this.signIn.Size = new System.Drawing.Size(221, 32);
            this.signIn.TabIndex = 7;
            this.signIn.Text = "Авторизируйтесь \r\nили создайте нового персонажа\r\n";
            this.signIn.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // newPlayerName
            // 
            this.newPlayerName.Location = new System.Drawing.Point(500, 160);
            this.newPlayerName.Name = "newPlayerName";
            this.newPlayerName.Size = new System.Drawing.Size(153, 20);
            this.newPlayerName.TabIndex = 8;
            this.newPlayerName.Visible = false;
            // 
            // newPlayer
            // 
            this.newPlayer.AutoSize = true;
            this.newPlayer.BackColor = System.Drawing.Color.Transparent;
            this.newPlayer.ForeColor = System.Drawing.Color.White;
            this.newPlayer.Location = new System.Drawing.Point(509, 137);
            this.newPlayer.Name = "newPlayer";
            this.newPlayer.Size = new System.Drawing.Size(144, 17);
            this.newPlayer.TabIndex = 9;
            this.newPlayer.Text = "Создать нового игрока";
            this.newPlayer.UseVisualStyleBackColor = false;
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::FightClubApp.Properties.Resources.fight_club_rule_you_do_not_talk_about_fight_club_336_1920x1080;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(744, 431);
            this.Controls.Add(this.newPlayer);
            this.Controls.Add(this.newPlayerName);
            this.Controls.Add(this.signIn);
            this.Controls.Add(this.rules);
            this.Controls.Add(this.toFightMenu);
            this.Controls.Add(this.choosePlayer);
            this.Controls.Add(this.records);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "LoginForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Fight Club. Sing in";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button records;
        private System.Windows.Forms.ComboBox choosePlayer;
        private System.Windows.Forms.Button toFightMenu;
        private System.Windows.Forms.Button rules;
        private System.Windows.Forms.Label signIn;
        private System.Windows.Forms.TextBox newPlayerName;
        private System.Windows.Forms.CheckBox newPlayer;
    }
}