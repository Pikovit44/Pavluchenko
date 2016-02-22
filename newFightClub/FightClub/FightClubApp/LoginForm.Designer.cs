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
            this.recordsButton = new System.Windows.Forms.Button();
            this.choosePlayerCombBox = new System.Windows.Forms.ComboBox();
            this.fightButton = new System.Windows.Forms.Button();
            this.ruleButton = new System.Windows.Forms.Button();
            this.signInLb = new System.Windows.Forms.Label();
            this.newPlayerFld = new System.Windows.Forms.TextBox();
            this.newPlayerСhB = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // recordsButton
            // 
            this.recordsButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.recordsButton.Location = new System.Drawing.Point(284, 22);
            this.recordsButton.Name = "recordsButton";
            this.recordsButton.Size = new System.Drawing.Size(110, 31);
            this.recordsButton.TabIndex = 2;
            this.recordsButton.Text = "Рекорды";
            this.recordsButton.UseVisualStyleBackColor = true;
            // 
            // choosePlayerCombBox
            // 
            this.choosePlayerCombBox.FormattingEnabled = true;
            this.choosePlayerCombBox.Location = new System.Drawing.Point(500, 96);
            this.choosePlayerCombBox.Name = "choosePlayerCombBox";
            this.choosePlayerCombBox.Size = new System.Drawing.Size(153, 21);
            this.choosePlayerCombBox.TabIndex = 3;
            // 
            // fightButton
            // 
            this.fightButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.fightButton.Location = new System.Drawing.Point(500, 360);
            this.fightButton.Name = "fightButton";
            this.fightButton.Size = new System.Drawing.Size(153, 31);
            this.fightButton.TabIndex = 5;
            this.fightButton.Text = "Начать схватку";
            this.fightButton.UseVisualStyleBackColor = true;
            this.fightButton.Click += new System.EventHandler(this.FightButton_Click);
            // 
            // ruleButton
            // 
            this.ruleButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ruleButton.Location = new System.Drawing.Point(128, 360);
            this.ruleButton.Name = "ruleButton";
            this.ruleButton.Size = new System.Drawing.Size(110, 31);
            this.ruleButton.TabIndex = 6;
            this.ruleButton.Text = "Правила";
            this.ruleButton.UseVisualStyleBackColor = true;
            // 
            // signInLb
            // 
            this.signInLb.AutoSize = true;
            this.signInLb.BackColor = System.Drawing.Color.Transparent;
            this.signInLb.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.signInLb.ForeColor = System.Drawing.Color.White;
            this.signInLb.Location = new System.Drawing.Point(471, 49);
            this.signInLb.Name = "signInLb";
            this.signInLb.Size = new System.Drawing.Size(221, 32);
            this.signInLb.TabIndex = 7;
            this.signInLb.Text = "Авторизируйтесь \r\nили создайте нового персонажа\r\n";
            this.signInLb.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // newPlayerFld
            // 
            this.newPlayerFld.Location = new System.Drawing.Point(500, 160);
            this.newPlayerFld.Name = "newPlayerFld";
            this.newPlayerFld.Size = new System.Drawing.Size(153, 20);
            this.newPlayerFld.TabIndex = 8;
            this.newPlayerFld.Visible = false;
            // 
            // newPlayerСhB
            // 
            this.newPlayerСhB.AutoSize = true;
            this.newPlayerСhB.BackColor = System.Drawing.Color.Transparent;
            this.newPlayerСhB.ForeColor = System.Drawing.Color.White;
            this.newPlayerСhB.Location = new System.Drawing.Point(509, 137);
            this.newPlayerСhB.Name = "newPlayerСhB";
            this.newPlayerСhB.Size = new System.Drawing.Size(144, 17);
            this.newPlayerСhB.TabIndex = 9;
            this.newPlayerСhB.Text = "Создать нового игрока";
            this.newPlayerСhB.UseVisualStyleBackColor = false;
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::FightClubApp.Properties.Resources.fight_club_rule_you_do_not_talk_about_fight_club_336_1920x1080;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(744, 431);
            this.Controls.Add(this.newPlayerСhB);
            this.Controls.Add(this.newPlayerFld);
            this.Controls.Add(this.signInLb);
            this.Controls.Add(this.ruleButton);
            this.Controls.Add(this.fightButton);
            this.Controls.Add(this.choosePlayerCombBox);
            this.Controls.Add(this.recordsButton);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "LoginForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Fight Club. Sing in";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button recordsButton;
        private System.Windows.Forms.ComboBox choosePlayerCombBox;
        private System.Windows.Forms.Button fightButton;
        private System.Windows.Forms.Button ruleButton;
        private System.Windows.Forms.Label signInLb;
        private System.Windows.Forms.TextBox newPlayerFld;
        private System.Windows.Forms.CheckBox newPlayerСhB;
    }
}