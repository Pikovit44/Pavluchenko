namespace FightClubApp
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
            this.lbPlayerName = new System.Windows.Forms.Label();
            this.groupAttack = new System.Windows.Forms.GroupBox();
            this.attLegsRb = new System.Windows.Forms.RadioButton();
            this.attTorsRb = new System.Windows.Forms.RadioButton();
            this.attHeadRb = new System.Windows.Forms.RadioButton();
            this.groupProtect = new System.Windows.Forms.GroupBox();
            this.protLegsRb = new System.Windows.Forms.RadioButton();
            this.protTorsRb = new System.Windows.Forms.RadioButton();
            this.protHeadRb = new System.Windows.Forms.RadioButton();
            this.playerHpPrgrBar = new System.Windows.Forms.ProgressBar();
            this.botHpPrgrBar = new System.Windows.Forms.ProgressBar();
            this.nameBotLb = new System.Windows.Forms.Label();
            this.logFld = new System.Windows.Forms.TextBox();
            this.fightButton = new System.Windows.Forms.Button();
            this.endFightButt = new System.Windows.Forms.Button();
            this.logLb = new System.Windows.Forms.Label();
            this.roundLb = new System.Windows.Forms.Label();
            this.namePlayerLb = new System.Windows.Forms.Label();
            this.statistButton = new System.Windows.Forms.Button();
            this.nextFightButton = new System.Windows.Forms.Button();
            this.groupAttack.SuspendLayout();
            this.groupProtect.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbPlayerName
            // 
            this.lbPlayerName.AutoSize = true;
            this.lbPlayerName.BackColor = System.Drawing.Color.Transparent;
            this.lbPlayerName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbPlayerName.Location = new System.Drawing.Point(301, 55);
            this.lbPlayerName.Name = "lbPlayerName";
            this.lbPlayerName.Size = new System.Drawing.Size(0, 20);
            this.lbPlayerName.TabIndex = 1;
            this.lbPlayerName.Click += new System.EventHandler(this.label1_Click);
            // 
            // groupAttack
            // 
            this.groupAttack.BackColor = System.Drawing.Color.Silver;
            this.groupAttack.Controls.Add(this.attLegsRb);
            this.groupAttack.Controls.Add(this.attTorsRb);
            this.groupAttack.Controls.Add(this.attHeadRb);
            this.groupAttack.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupAttack.Location = new System.Drawing.Point(30, 78);
            this.groupAttack.Name = "groupAttack";
            this.groupAttack.Size = new System.Drawing.Size(126, 153);
            this.groupAttack.TabIndex = 2;
            this.groupAttack.TabStop = false;
            this.groupAttack.Text = "Атака";
            // 
            // attLegsRb
            // 
            this.attLegsRb.AutoSize = true;
            this.attLegsRb.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.attLegsRb.Location = new System.Drawing.Point(21, 114);
            this.attLegsRb.Name = "attLegsRb";
            this.attLegsRb.Size = new System.Drawing.Size(64, 24);
            this.attLegsRb.TabIndex = 6;
            this.attLegsRb.Text = "Ноги";
            this.attLegsRb.UseVisualStyleBackColor = true;
            // 
            // attTorsRb
            // 
            this.attTorsRb.AutoSize = true;
            this.attTorsRb.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.attTorsRb.Location = new System.Drawing.Point(21, 75);
            this.attTorsRb.Name = "attTorsRb";
            this.attTorsRb.Size = new System.Drawing.Size(79, 24);
            this.attTorsRb.TabIndex = 5;
            this.attTorsRb.Text = "Корпус";
            this.attTorsRb.UseVisualStyleBackColor = true;
            // 
            // attHeadRb
            // 
            this.attHeadRb.AutoSize = true;
            this.attHeadRb.Checked = true;
            this.attHeadRb.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.attHeadRb.Location = new System.Drawing.Point(21, 34);
            this.attHeadRb.Name = "attHeadRb";
            this.attHeadRb.Size = new System.Drawing.Size(82, 24);
            this.attHeadRb.TabIndex = 4;
            this.attHeadRb.TabStop = true;
            this.attHeadRb.Text = "Голова";
            this.attHeadRb.UseVisualStyleBackColor = true;
            // 
            // groupProtect
            // 
            this.groupProtect.BackColor = System.Drawing.Color.Silver;
            this.groupProtect.Controls.Add(this.protLegsRb);
            this.groupProtect.Controls.Add(this.protTorsRb);
            this.groupProtect.Controls.Add(this.protHeadRb);
            this.groupProtect.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupProtect.Location = new System.Drawing.Point(30, 262);
            this.groupProtect.Name = "groupProtect";
            this.groupProtect.Size = new System.Drawing.Size(126, 153);
            this.groupProtect.TabIndex = 7;
            this.groupProtect.TabStop = false;
            this.groupProtect.Text = "Защита";
            // 
            // protLegsRb
            // 
            this.protLegsRb.AutoSize = true;
            this.protLegsRb.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.protLegsRb.Location = new System.Drawing.Point(21, 114);
            this.protLegsRb.Name = "protLegsRb";
            this.protLegsRb.Size = new System.Drawing.Size(64, 24);
            this.protLegsRb.TabIndex = 6;
            this.protLegsRb.Text = "Ноги";
            this.protLegsRb.UseVisualStyleBackColor = true;
            // 
            // protTorsRb
            // 
            this.protTorsRb.AutoSize = true;
            this.protTorsRb.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.protTorsRb.Location = new System.Drawing.Point(21, 75);
            this.protTorsRb.Name = "protTorsRb";
            this.protTorsRb.Size = new System.Drawing.Size(79, 24);
            this.protTorsRb.TabIndex = 5;
            this.protTorsRb.Text = "Корпус";
            this.protTorsRb.UseVisualStyleBackColor = true;
            // 
            // protHeadRb
            // 
            this.protHeadRb.AutoEllipsis = true;
            this.protHeadRb.AutoSize = true;
            this.protHeadRb.Checked = true;
            this.protHeadRb.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.protHeadRb.Location = new System.Drawing.Point(21, 34);
            this.protHeadRb.Name = "protHeadRb";
            this.protHeadRb.Size = new System.Drawing.Size(82, 24);
            this.protHeadRb.TabIndex = 4;
            this.protHeadRb.TabStop = true;
            this.protHeadRb.Text = "Голова";
            this.protHeadRb.UseVisualStyleBackColor = true;
            // 
            // playerHpPrgrBar
            // 
            this.playerHpPrgrBar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.playerHpPrgrBar.Location = new System.Drawing.Point(211, 78);
            this.playerHpPrgrBar.Name = "playerHpPrgrBar";
            this.playerHpPrgrBar.Size = new System.Drawing.Size(274, 22);
            this.playerHpPrgrBar.TabIndex = 8;
            this.playerHpPrgrBar.Value = 100;
            // 
            // botHpPrgrBar
            // 
            this.botHpPrgrBar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.botHpPrgrBar.Location = new System.Drawing.Point(211, 142);
            this.botHpPrgrBar.Name = "botHpPrgrBar";
            this.botHpPrgrBar.Size = new System.Drawing.Size(274, 22);
            this.botHpPrgrBar.TabIndex = 10;
            this.botHpPrgrBar.Value = 100;
            // 
            // nameBotLb
            // 
            this.nameBotLb.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.nameBotLb.AutoSize = true;
            this.nameBotLb.BackColor = System.Drawing.Color.Transparent;
            this.nameBotLb.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.nameBotLb.Location = new System.Drawing.Point(323, 119);
            this.nameBotLb.Name = "nameBotLb";
            this.nameBotLb.Size = new System.Drawing.Size(38, 20);
            this.nameBotLb.TabIndex = 9;
            this.nameBotLb.Text = "Бот";
            // 
            // logFld
            // 
            this.logFld.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.logFld.Location = new System.Drawing.Point(211, 208);
            this.logFld.Multiline = true;
            this.logFld.Name = "logFld";
            this.logFld.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.logFld.Size = new System.Drawing.Size(274, 153);
            this.logFld.TabIndex = 11;
            // 
            // fightButton
            // 
            this.fightButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.fightButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.fightButton.Location = new System.Drawing.Point(308, 376);
            this.fightButton.Name = "fightButton";
            this.fightButton.Size = new System.Drawing.Size(81, 39);
            this.fightButton.TabIndex = 12;
            this.fightButton.Text = "Бой";
            this.fightButton.UseVisualStyleBackColor = true;
            this.fightButton.Click += new System.EventHandler(this.butFight_Click);
            // 
            // endFightButt
            // 
            this.endFightButt.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.endFightButt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.endFightButt.Location = new System.Drawing.Point(616, 367);
            this.endFightButt.Name = "endFightButt";
            this.endFightButt.Size = new System.Drawing.Size(114, 48);
            this.endFightButt.TabIndex = 13;
            this.endFightButt.Text = "Закончить схватку";
            this.endFightButt.UseVisualStyleBackColor = true;
            this.endFightButt.Click += new System.EventHandler(this.endFightButt_Click);
            // 
            // logLb
            // 
            this.logLb.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.logLb.AutoSize = true;
            this.logLb.BackColor = System.Drawing.Color.Transparent;
            this.logLb.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.logLb.Location = new System.Drawing.Point(305, 185);
            this.logLb.Name = "logLb";
            this.logLb.Size = new System.Drawing.Size(71, 20);
            this.logLb.TabIndex = 14;
            this.logLb.Text = "Ход боя";
            // 
            // roundLb
            // 
            this.roundLb.AutoSize = true;
            this.roundLb.BackColor = System.Drawing.Color.Transparent;
            this.roundLb.Font = new System.Drawing.Font("Arial Narrow", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.roundLb.Location = new System.Drawing.Point(45, 25);
            this.roundLb.Name = "roundLb";
            this.roundLb.Size = new System.Drawing.Size(95, 31);
            this.roundLb.TabIndex = 15;
            this.roundLb.Text = "Раунд 1";
            // 
            // namePlayerLb
            // 
            this.namePlayerLb.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.namePlayerLb.AutoSize = true;
            this.namePlayerLb.BackColor = System.Drawing.Color.Transparent;
            this.namePlayerLb.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.namePlayerLb.Location = new System.Drawing.Point(323, 55);
            this.namePlayerLb.Name = "namePlayerLb";
            this.namePlayerLb.Size = new System.Drawing.Size(53, 20);
            this.namePlayerLb.TabIndex = 16;
            this.namePlayerLb.Text = "Игрок";
            // 
            // statistButton
            // 
            this.statistButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.statistButton.Enabled = false;
            this.statistButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.statistButton.Location = new System.Drawing.Point(211, 376);
            this.statistButton.Name = "statistButton";
            this.statistButton.Size = new System.Drawing.Size(90, 39);
            this.statistButton.TabIndex = 17;
            this.statistButton.Text = "Статистика боя";
            this.statistButton.UseVisualStyleBackColor = true;
            // 
            // nextFightButton
            // 
            this.nextFightButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.nextFightButton.Enabled = false;
            this.nextFightButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.nextFightButton.Location = new System.Drawing.Point(395, 376);
            this.nextFightButton.Name = "nextFightButton";
            this.nextFightButton.Size = new System.Drawing.Size(90, 39);
            this.nextFightButton.TabIndex = 18;
            this.nextFightButton.Text = "Слелующий бой";
            this.nextFightButton.UseVisualStyleBackColor = true;
            this.nextFightButton.Click += new System.EventHandler(this.nextFightButton_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = global::FightClubApp.Properties.Resources.tumblr_inline_nlma5dDlRQ1s811jo_1280;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(742, 427);
            this.Controls.Add(this.nextFightButton);
            this.Controls.Add(this.statistButton);
            this.Controls.Add(this.namePlayerLb);
            this.Controls.Add(this.roundLb);
            this.Controls.Add(this.logLb);
            this.Controls.Add(this.endFightButt);
            this.Controls.Add(this.fightButton);
            this.Controls.Add(this.logFld);
            this.Controls.Add(this.botHpPrgrBar);
            this.Controls.Add(this.nameBotLb);
            this.Controls.Add(this.playerHpPrgrBar);
            this.Controls.Add(this.groupProtect);
            this.Controls.Add(this.groupAttack);
            this.Controls.Add(this.lbPlayerName);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Fight club";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupAttack.ResumeLayout(false);
            this.groupAttack.PerformLayout();
            this.groupProtect.ResumeLayout(false);
            this.groupProtect.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lbPlayerName;
        private System.Windows.Forms.GroupBox groupAttack;
        private System.Windows.Forms.RadioButton attLegsRb;
        private System.Windows.Forms.RadioButton attTorsRb;
        private System.Windows.Forms.RadioButton attHeadRb;
        private System.Windows.Forms.GroupBox groupProtect;
        private System.Windows.Forms.RadioButton protLegsRb;
        private System.Windows.Forms.RadioButton protTorsRb;
        private System.Windows.Forms.RadioButton protHeadRb;
        private System.Windows.Forms.ProgressBar playerHpPrgrBar;
        private System.Windows.Forms.ProgressBar botHpPrgrBar;
        private System.Windows.Forms.Label nameBotLb;
        private System.Windows.Forms.TextBox logFld;
        private System.Windows.Forms.Button fightButton;
        private System.Windows.Forms.Button endFightButt;
        private System.Windows.Forms.Label logLb;
        private System.Windows.Forms.Label roundLb;
        private System.Windows.Forms.Label namePlayerLb;
        private System.Windows.Forms.Button statistButton;
        private System.Windows.Forms.Button nextFightButton;
    }
}

