namespace RussionRoulette
{
    partial class RouletteForm
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
            this.btnLoad = new System.Windows.Forms.Button();
            this.btnShoot = new System.Windows.Forms.Button();
            this.btnSpin = new System.Windows.Forms.Button();
            this.btnShotAway = new System.Windows.Forms.Button();
            this.btnNew = new System.Windows.Forms.Button();
            this.btnQuit = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblGame = new System.Windows.Forms.Label();
            this.lblLose = new System.Windows.Forms.Label();
            this.lblWin = new System.Windows.Forms.Label();
            this.imgBox = new System.Windows.Forms.PictureBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.lblCurrentID = new System.Windows.Forms.Label();
            this.lblBulletLocation = new System.Windows.Forms.Label();
            this.lblAwayCount = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.imgBox)).BeginInit();
            this.SuspendLayout();
            // 
            // btnLoad
            // 
            this.btnLoad.Font = new System.Drawing.Font("Tempus Sans ITC", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLoad.ForeColor = System.Drawing.Color.Red;
            this.btnLoad.Location = new System.Drawing.Point(38, 221);
            this.btnLoad.Name = "btnLoad";
            this.btnLoad.Size = new System.Drawing.Size(115, 46);
            this.btnLoad.TabIndex = 0;
            this.btnLoad.Text = "Load";
            this.btnLoad.UseVisualStyleBackColor = true;
            // 
            // btnShoot
            // 
            this.btnShoot.Font = new System.Drawing.Font("Tempus Sans ITC", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnShoot.ForeColor = System.Drawing.Color.Red;
            this.btnShoot.Location = new System.Drawing.Point(38, 331);
            this.btnShoot.Name = "btnShoot";
            this.btnShoot.Size = new System.Drawing.Size(115, 46);
            this.btnShoot.TabIndex = 1;
            this.btnShoot.Text = "Shoot";
            this.btnShoot.UseVisualStyleBackColor = true;
            // 
            // btnSpin
            // 
            this.btnSpin.Font = new System.Drawing.Font("Tempus Sans ITC", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSpin.ForeColor = System.Drawing.Color.Red;
            this.btnSpin.Location = new System.Drawing.Point(38, 273);
            this.btnSpin.Name = "btnSpin";
            this.btnSpin.Size = new System.Drawing.Size(115, 46);
            this.btnSpin.TabIndex = 2;
            this.btnSpin.Text = "Spin";
            this.btnSpin.UseVisualStyleBackColor = true;
            // 
            // btnShotAway
            // 
            this.btnShotAway.Font = new System.Drawing.Font("Tempus Sans ITC", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnShotAway.ForeColor = System.Drawing.Color.Red;
            this.btnShotAway.Location = new System.Drawing.Point(603, 331);
            this.btnShotAway.Name = "btnShotAway";
            this.btnShotAway.Size = new System.Drawing.Size(115, 46);
            this.btnShotAway.TabIndex = 3;
            this.btnShotAway.Text = "Shoot Away";
            this.btnShotAway.UseVisualStyleBackColor = true;
            // 
            // btnNew
            // 
            this.btnNew.Font = new System.Drawing.Font("Tempus Sans ITC", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNew.ForeColor = System.Drawing.Color.Red;
            this.btnNew.Location = new System.Drawing.Point(649, 35);
            this.btnNew.Name = "btnNew";
            this.btnNew.Size = new System.Drawing.Size(115, 46);
            this.btnNew.TabIndex = 4;
            this.btnNew.Text = "Play Again";
            this.btnNew.UseVisualStyleBackColor = true;
            // 
            // btnQuit
            // 
            this.btnQuit.Font = new System.Drawing.Font("Tempus Sans ITC", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnQuit.ForeColor = System.Drawing.Color.Red;
            this.btnQuit.Location = new System.Drawing.Point(649, 98);
            this.btnQuit.Name = "btnQuit";
            this.btnQuit.Size = new System.Drawing.Size(115, 46);
            this.btnQuit.TabIndex = 5;
            this.btnQuit.Text = "Quit";
            this.btnQuit.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tempus Sans ITC", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 20);
            this.label1.TabIndex = 7;
            this.label1.Text = "Game:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tempus Sans ITC", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 98);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 20);
            this.label2.TabIndex = 8;
            this.label2.Text = "Lose:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tempus Sans ITC", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 61);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 20);
            this.label3.TabIndex = 9;
            this.label3.Text = "Win:";
            // 
            // lblGame
            // 
            this.lblGame.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblGame.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblGame.Font = new System.Drawing.Font("Tempus Sans ITC", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGame.Location = new System.Drawing.Point(69, 24);
            this.lblGame.Name = "lblGame";
            this.lblGame.Size = new System.Drawing.Size(40, 20);
            this.lblGame.TabIndex = 10;
            this.lblGame.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblLose
            // 
            this.lblLose.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblLose.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblLose.Font = new System.Drawing.Font("Tempus Sans ITC", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLose.Location = new System.Drawing.Point(69, 98);
            this.lblLose.Name = "lblLose";
            this.lblLose.Size = new System.Drawing.Size(40, 20);
            this.lblLose.TabIndex = 11;
            this.lblLose.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblWin
            // 
            this.lblWin.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblWin.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblWin.Font = new System.Drawing.Font("Tempus Sans ITC", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWin.Location = new System.Drawing.Point(69, 61);
            this.lblWin.Name = "lblWin";
            this.lblWin.Size = new System.Drawing.Size(40, 20);
            this.lblWin.TabIndex = 12;
            this.lblWin.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // imgBox
            // 
            this.imgBox.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.imgBox.Location = new System.Drawing.Point(159, 66);
            this.imgBox.Name = "imgBox";
            this.imgBox.Size = new System.Drawing.Size(411, 253);
            this.imgBox.TabIndex = 13;
            this.imgBox.TabStop = false;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Tempus Sans ITC", 17F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Red;
            this.label7.Location = new System.Drawing.Point(268, 17);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(191, 30);
            this.label7.TabIndex = 14;
            this.label7.Text = "Russian Roulette";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Tempus Sans ITC", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(628, 175);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(113, 23);
            this.label8.TabIndex = 15;
            this.label8.Text = "Bullet is At:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Tempus Sans ITC", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(566, 221);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(175, 23);
            this.label9.TabIndex = 16;
            this.label9.Text = "CurrentChamberID:";
            // 
            // lblCurrentID
            // 
            this.lblCurrentID.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblCurrentID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblCurrentID.Font = new System.Drawing.Font("Tempus Sans ITC", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCurrentID.Location = new System.Drawing.Point(747, 221);
            this.lblCurrentID.Name = "lblCurrentID";
            this.lblCurrentID.Size = new System.Drawing.Size(41, 20);
            this.lblCurrentID.TabIndex = 17;
            this.lblCurrentID.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblBulletLocation
            // 
            this.lblBulletLocation.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblBulletLocation.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblBulletLocation.Font = new System.Drawing.Font("Tempus Sans ITC", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBulletLocation.Location = new System.Drawing.Point(747, 176);
            this.lblBulletLocation.Name = "lblBulletLocation";
            this.lblBulletLocation.Size = new System.Drawing.Size(41, 20);
            this.lblBulletLocation.TabIndex = 18;
            this.lblBulletLocation.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblAwayCount
            // 
            this.lblAwayCount.AutoSize = true;
            this.lblAwayCount.BackColor = System.Drawing.Color.Transparent;
            this.lblAwayCount.Font = new System.Drawing.Font("Tempus Sans ITC", 17F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAwayCount.ForeColor = System.Drawing.Color.Red;
            this.lblAwayCount.Location = new System.Drawing.Point(249, 337);
            this.lblAwayCount.Name = "lblAwayCount";
            this.lblAwayCount.Size = new System.Drawing.Size(348, 30);
            this.lblAwayCount.TabIndex = 19;
            this.lblAwayCount.Text = "You have ? shoot away available";
            this.lblAwayCount.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // RouletteForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 427);
            this.Controls.Add(this.lblAwayCount);
            this.Controls.Add(this.lblBulletLocation);
            this.Controls.Add(this.lblCurrentID);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.imgBox);
            this.Controls.Add(this.lblWin);
            this.Controls.Add(this.lblLose);
            this.Controls.Add(this.lblGame);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnQuit);
            this.Controls.Add(this.btnNew);
            this.Controls.Add(this.btnShotAway);
            this.Controls.Add(this.btnSpin);
            this.Controls.Add(this.btnShoot);
            this.Controls.Add(this.btnLoad);
            this.Controls.Add(this.label9);
            this.Name = "RouletteForm";
            this.Text = "RouletteForm";
            ((System.ComponentModel.ISupportInitialize)(this.imgBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnLoad;
        private System.Windows.Forms.Button btnShoot;
        private System.Windows.Forms.Button btnSpin;
        private System.Windows.Forms.Button btnShotAway;
        private System.Windows.Forms.Button btnNew;
        private System.Windows.Forms.Button btnQuit;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblGame;
        private System.Windows.Forms.Label lblLose;
        private System.Windows.Forms.Label lblWin;
        private System.Windows.Forms.PictureBox imgBox;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label lblCurrentID;
        private System.Windows.Forms.Label lblBulletLocation;
        private System.Windows.Forms.Label lblAwayCount;
    }
}

