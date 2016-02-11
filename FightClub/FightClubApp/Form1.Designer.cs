namespace FightClubApp
{
    partial class Form1
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
            this.PlayerName = new System.Windows.Forms.Label();
            this.groupAttack = new System.Windows.Forms.GroupBox();
            this.attLegs = new System.Windows.Forms.RadioButton();
            this.attTors = new System.Windows.Forms.RadioButton();
            this.attHead = new System.Windows.Forms.RadioButton();
            this.groupProtect = new System.Windows.Forms.GroupBox();
            this.protLegs = new System.Windows.Forms.RadioButton();
            this.protTors = new System.Windows.Forms.RadioButton();
            this.protHead = new System.Windows.Forms.RadioButton();
            this.progrPlayer = new System.Windows.Forms.ProgressBar();
            this.progrPC = new System.Windows.Forms.ProgressBar();
            this.PCName = new System.Windows.Forms.Label();
            this.Log = new System.Windows.Forms.TextBox();
            this.buttFight = new System.Windows.Forms.Button();
            this.buttEndFight = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.groupAttack.SuspendLayout();
            this.groupProtect.SuspendLayout();
            this.SuspendLayout();
            // 
            // PlayerName
            // 
            this.PlayerName.AutoSize = true;
            this.PlayerName.BackColor = System.Drawing.Color.Transparent;
            this.PlayerName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.PlayerName.Location = new System.Drawing.Point(301, 42);
            this.PlayerName.Name = "PlayerName";
            this.PlayerName.Size = new System.Drawing.Size(95, 20);
            this.PlayerName.TabIndex = 1;
            this.PlayerName.Text = "Имя игрока";
            this.PlayerName.Click += new System.EventHandler(this.label1_Click);
            // 
            // groupAttack
            // 
            this.groupAttack.BackColor = System.Drawing.Color.Silver;
            this.groupAttack.Controls.Add(this.attLegs);
            this.groupAttack.Controls.Add(this.attTors);
            this.groupAttack.Controls.Add(this.attHead);
            this.groupAttack.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupAttack.Location = new System.Drawing.Point(30, 65);
            this.groupAttack.Name = "groupAttack";
            this.groupAttack.Size = new System.Drawing.Size(126, 153);
            this.groupAttack.TabIndex = 2;
            this.groupAttack.TabStop = false;
            this.groupAttack.Text = "Атака";
            // 
            // attLegs
            // 
            this.attLegs.AutoSize = true;
            this.attLegs.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.attLegs.Location = new System.Drawing.Point(21, 114);
            this.attLegs.Name = "attLegs";
            this.attLegs.Size = new System.Drawing.Size(64, 24);
            this.attLegs.TabIndex = 6;
            this.attLegs.TabStop = true;
            this.attLegs.Text = "Ноги";
            this.attLegs.UseVisualStyleBackColor = true;
            // 
            // attTors
            // 
            this.attTors.AutoSize = true;
            this.attTors.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.attTors.Location = new System.Drawing.Point(21, 75);
            this.attTors.Name = "attTors";
            this.attTors.Size = new System.Drawing.Size(79, 24);
            this.attTors.TabIndex = 5;
            this.attTors.TabStop = true;
            this.attTors.Text = "Корпус";
            this.attTors.UseVisualStyleBackColor = true;
            // 
            // attHead
            // 
            this.attHead.AutoSize = true;
            this.attHead.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.attHead.Location = new System.Drawing.Point(21, 34);
            this.attHead.Name = "attHead";
            this.attHead.Size = new System.Drawing.Size(82, 24);
            this.attHead.TabIndex = 4;
            this.attHead.TabStop = true;
            this.attHead.Text = "Голова";
            this.attHead.UseVisualStyleBackColor = true;
            // 
            // groupProtect
            // 
            this.groupProtect.BackColor = System.Drawing.Color.Silver;
            this.groupProtect.Controls.Add(this.protLegs);
            this.groupProtect.Controls.Add(this.protTors);
            this.groupProtect.Controls.Add(this.protHead);
            this.groupProtect.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupProtect.Location = new System.Drawing.Point(30, 239);
            this.groupProtect.Name = "groupProtect";
            this.groupProtect.Size = new System.Drawing.Size(126, 153);
            this.groupProtect.TabIndex = 7;
            this.groupProtect.TabStop = false;
            this.groupProtect.Text = "Защита";
            // 
            // protLegs
            // 
            this.protLegs.AutoSize = true;
            this.protLegs.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.protLegs.Location = new System.Drawing.Point(21, 114);
            this.protLegs.Name = "protLegs";
            this.protLegs.Size = new System.Drawing.Size(64, 24);
            this.protLegs.TabIndex = 6;
            this.protLegs.TabStop = true;
            this.protLegs.Text = "Ноги";
            this.protLegs.UseVisualStyleBackColor = true;
            // 
            // protTors
            // 
            this.protTors.AutoSize = true;
            this.protTors.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.protTors.Location = new System.Drawing.Point(21, 75);
            this.protTors.Name = "protTors";
            this.protTors.Size = new System.Drawing.Size(79, 24);
            this.protTors.TabIndex = 5;
            this.protTors.TabStop = true;
            this.protTors.Text = "Корпус";
            this.protTors.UseVisualStyleBackColor = true;
            // 
            // protHead
            // 
            this.protHead.AutoSize = true;
            this.protHead.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.protHead.Location = new System.Drawing.Point(21, 34);
            this.protHead.Name = "protHead";
            this.protHead.Size = new System.Drawing.Size(82, 24);
            this.protHead.TabIndex = 4;
            this.protHead.TabStop = true;
            this.protHead.Text = "Голова";
            this.protHead.UseVisualStyleBackColor = true;
            // 
            // progrPlayer
            // 
            this.progrPlayer.Location = new System.Drawing.Point(211, 65);
            this.progrPlayer.Name = "progrPlayer";
            this.progrPlayer.Size = new System.Drawing.Size(274, 40);
            this.progrPlayer.TabIndex = 8;
            // 
            // progrPC
            // 
            this.progrPC.Location = new System.Drawing.Point(211, 163);
            this.progrPC.Name = "progrPC";
            this.progrPC.Size = new System.Drawing.Size(274, 40);
            this.progrPC.TabIndex = 10;
            // 
            // PCName
            // 
            this.PCName.AutoSize = true;
            this.PCName.BackColor = System.Drawing.Color.Transparent;
            this.PCName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.PCName.Location = new System.Drawing.Point(304, 140);
            this.PCName.Name = "PCName";
            this.PCName.Size = new System.Drawing.Size(87, 20);
            this.PCName.TabIndex = 9;
            this.PCName.Text = "Имя врага";
            // 
            // Log
            // 
            this.Log.Location = new System.Drawing.Point(211, 255);
            this.Log.Multiline = true;
            this.Log.Name = "Log";
            this.Log.Size = new System.Drawing.Size(274, 93);
            this.Log.TabIndex = 11;
            // 
            // buttFight
            // 
            this.buttFight.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttFight.Location = new System.Drawing.Point(282, 365);
            this.buttFight.Name = "buttFight";
            this.buttFight.Size = new System.Drawing.Size(114, 36);
            this.buttFight.TabIndex = 12;
            this.buttFight.Text = "Бой";
            this.buttFight.UseVisualStyleBackColor = true;
            this.buttFight.Click += new System.EventHandler(this.buttFight_Click);
            // 
            // buttEndFight
            // 
            this.buttEndFight.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttEndFight.Location = new System.Drawing.Point(616, 353);
            this.buttEndFight.Name = "buttEndFight";
            this.buttEndFight.Size = new System.Drawing.Size(114, 48);
            this.buttEndFight.TabIndex = 13;
            this.buttEndFight.Text = "Закончить схватку";
            this.buttEndFight.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(304, 230);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 20);
            this.label3.TabIndex = 14;
            this.label3.Text = "Ход боя";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Arial Narrow", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(45, 20);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(95, 31);
            this.label4.TabIndex = 15;
            this.label4.Text = "Раунд 1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = global::FightClubApp.Properties.Resources.tumblr_inline_nlma5dDlRQ1s811jo_1280;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(742, 410);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.buttEndFight);
            this.Controls.Add(this.buttFight);
            this.Controls.Add(this.Log);
            this.Controls.Add(this.progrPC);
            this.Controls.Add(this.PCName);
            this.Controls.Add(this.progrPlayer);
            this.Controls.Add(this.groupProtect);
            this.Controls.Add(this.groupAttack);
            this.Controls.Add(this.PlayerName);
            this.Name = "Form1";
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
        private System.Windows.Forms.Label PlayerName;
        private System.Windows.Forms.GroupBox groupAttack;
        private System.Windows.Forms.RadioButton attLegs;
        private System.Windows.Forms.RadioButton attTors;
        private System.Windows.Forms.RadioButton attHead;
        private System.Windows.Forms.GroupBox groupProtect;
        private System.Windows.Forms.RadioButton protLegs;
        private System.Windows.Forms.RadioButton protTors;
        private System.Windows.Forms.RadioButton protHead;
        private System.Windows.Forms.ProgressBar progrPlayer;
        private System.Windows.Forms.ProgressBar progrPC;
        private System.Windows.Forms.Label PCName;
        private System.Windows.Forms.TextBox Log;
        private System.Windows.Forms.Button buttFight;
        private System.Windows.Forms.Button buttEndFight;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}

