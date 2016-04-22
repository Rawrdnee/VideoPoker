namespace VideoPoker
{
    partial class pokerpoker
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
            this.mnuPoker = new System.Windows.Forms.MenuStrip();
            this.newGameToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuNewGame = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuDraw = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuPurchase = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.mnuExit = new System.Windows.Forms.ToolStripMenuItem();
            this.lblHand = new System.Windows.Forms.Label();
            this.lblCredit = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblBet = new System.Windows.Forms.Label();
            this.btn25 = new System.Windows.Forms.Button();
            this.btn50 = new System.Windows.Forms.Button();
            this.btn75 = new System.Windows.Forms.Button();
            this.btn100 = new System.Windows.Forms.Button();
            this.lblPause = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblWin = new System.Windows.Forms.Label();
            this.mnuPoker.SuspendLayout();
            this.SuspendLayout();
            // 
            // mnuPoker
            // 
            this.mnuPoker.BackColor = System.Drawing.Color.DarkGray;
            this.mnuPoker.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.mnuPoker.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newGameToolStripMenuItem});
            this.mnuPoker.Location = new System.Drawing.Point(0, 0);
            this.mnuPoker.Name = "mnuPoker";
            this.mnuPoker.Padding = new System.Windows.Forms.Padding(4, 1, 0, 1);
            this.mnuPoker.Size = new System.Drawing.Size(571, 24);
            this.mnuPoker.TabIndex = 0;
            this.mnuPoker.Text = "menuStrip1";
            // 
            // newGameToolStripMenuItem
            // 
            this.newGameToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuNewGame,
            this.mnuDraw,
            this.mnuPurchase,
            this.toolStripSeparator1,
            this.mnuExit});
            this.newGameToolStripMenuItem.Name = "newGameToolStripMenuItem";
            this.newGameToolStripMenuItem.Size = new System.Drawing.Size(49, 22);
            this.newGameToolStripMenuItem.Text = "Poker";
            // 
            // mnuNewGame
            // 
            this.mnuNewGame.Name = "mnuNewGame";
            this.mnuNewGame.Size = new System.Drawing.Size(143, 22);
            this.mnuNewGame.Text = "(N)ew Game";
            this.mnuNewGame.Click += new System.EventHandler(this.mnuNewGame_Click);
            // 
            // mnuDraw
            // 
            this.mnuDraw.Enabled = false;
            this.mnuDraw.Name = "mnuDraw";
            this.mnuDraw.Size = new System.Drawing.Size(143, 22);
            this.mnuDraw.Text = "(D)raw";
            this.mnuDraw.Click += new System.EventHandler(this.mnuDraw_Click);
            // 
            // mnuPurchase
            // 
            this.mnuPurchase.Name = "mnuPurchase";
            this.mnuPurchase.Size = new System.Drawing.Size(143, 22);
            this.mnuPurchase.Text = "Purchase 100";
            this.mnuPurchase.Click += new System.EventHandler(this.mnuPurchase_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(140, 6);
            // 
            // mnuExit
            // 
            this.mnuExit.Name = "mnuExit";
            this.mnuExit.Size = new System.Drawing.Size(143, 22);
            this.mnuExit.Text = "Exit";
            this.mnuExit.Click += new System.EventHandler(this.mnuExit_Click);
            // 
            // lblHand
            // 
            this.lblHand.AutoSize = true;
            this.lblHand.BackColor = System.Drawing.Color.Transparent;
            this.lblHand.Font = new System.Drawing.Font("Georgia", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHand.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblHand.Location = new System.Drawing.Point(8, 112);
            this.lblHand.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblHand.Name = "lblHand";
            this.lblHand.Size = new System.Drawing.Size(260, 29);
            this.lblHand.TabIndex = 1;
            this.lblHand.Text = "Please Start New Game";
            // 
            // lblCredit
            // 
            this.lblCredit.AutoSize = true;
            this.lblCredit.BackColor = System.Drawing.Color.Transparent;
            this.lblCredit.Font = new System.Drawing.Font("Georgia", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCredit.Location = new System.Drawing.Point(111, 55);
            this.lblCredit.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCredit.Name = "lblCredit";
            this.lblCredit.Size = new System.Drawing.Size(30, 29);
            this.lblCredit.TabIndex = 2;
            this.lblCredit.Text = "0";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Georgia", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(8, 55);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 29);
            this.label1.TabIndex = 3;
            this.label1.Text = "Credit:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Georgia", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(8, 82);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 29);
            this.label2.TabIndex = 5;
            this.label2.Text = "Bet:";
            // 
            // lblBet
            // 
            this.lblBet.AutoSize = true;
            this.lblBet.BackColor = System.Drawing.Color.Transparent;
            this.lblBet.Font = new System.Drawing.Font("Georgia", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBet.Location = new System.Drawing.Point(111, 82);
            this.lblBet.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblBet.Name = "lblBet";
            this.lblBet.Size = new System.Drawing.Size(30, 29);
            this.lblBet.TabIndex = 4;
            this.lblBet.Text = "0";
            // 
            // btn25
            // 
            this.btn25.Location = new System.Drawing.Point(13, 149);
            this.btn25.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btn25.Name = "btn25";
            this.btn25.Size = new System.Drawing.Size(34, 31);
            this.btn25.TabIndex = 6;
            this.btn25.TabStop = false;
            this.btn25.Tag = "0.25";
            this.btn25.Text = "25¢";
            this.btn25.UseVisualStyleBackColor = true;
            this.btn25.Click += new System.EventHandler(this.btnBet_Click);
            // 
            // btn50
            // 
            this.btn50.Location = new System.Drawing.Point(57, 149);
            this.btn50.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btn50.Name = "btn50";
            this.btn50.Size = new System.Drawing.Size(34, 31);
            this.btn50.TabIndex = 7;
            this.btn50.TabStop = false;
            this.btn50.Tag = "0.50";
            this.btn50.Text = "50¢";
            this.btn50.UseVisualStyleBackColor = true;
            this.btn50.Click += new System.EventHandler(this.btnBet_Click);
            // 
            // btn75
            // 
            this.btn75.Location = new System.Drawing.Point(103, 149);
            this.btn75.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btn75.Name = "btn75";
            this.btn75.Size = new System.Drawing.Size(34, 31);
            this.btn75.TabIndex = 8;
            this.btn75.TabStop = false;
            this.btn75.Tag = "0.75";
            this.btn75.Text = "75¢";
            this.btn75.UseVisualStyleBackColor = true;
            this.btn75.Click += new System.EventHandler(this.btnBet_Click);
            // 
            // btn100
            // 
            this.btn100.Location = new System.Drawing.Point(147, 149);
            this.btn100.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btn100.Name = "btn100";
            this.btn100.Size = new System.Drawing.Size(39, 31);
            this.btn100.TabIndex = 9;
            this.btn100.TabStop = false;
            this.btn100.Tag = "1.0";
            this.btn100.Text = "100¢";
            this.btn100.UseVisualStyleBackColor = true;
            this.btn100.Click += new System.EventHandler(this.btnBet_Click);
            // 
            // lblPause
            // 
            this.lblPause.AutoSize = true;
            this.lblPause.BackColor = System.Drawing.Color.Transparent;
            this.lblPause.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPause.Location = new System.Drawing.Point(321, 41);
            this.lblPause.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblPause.Name = "lblPause";
            this.lblPause.Size = new System.Drawing.Size(155, 46);
            this.lblPause.TabIndex = 10;
            this.lblPause.Text = "Paused";
            this.lblPause.Visible = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Georgia", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(8, 29);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 29);
            this.label3.TabIndex = 13;
            this.label3.Text = "Win:";
            // 
            // lblWin
            // 
            this.lblWin.AutoSize = true;
            this.lblWin.BackColor = System.Drawing.Color.Transparent;
            this.lblWin.Font = new System.Drawing.Font("Georgia", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWin.Location = new System.Drawing.Point(111, 29);
            this.lblWin.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblWin.Name = "lblWin";
            this.lblWin.Size = new System.Drawing.Size(30, 29);
            this.lblWin.TabIndex = 12;
            this.lblWin.Text = "0";
            // 
            // pokerpoker
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkOliveGreen;
            this.ClientSize = new System.Drawing.Size(571, 382);
            this.ControlBox = false;
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblWin);
            this.Controls.Add(this.lblPause);
            this.Controls.Add(this.btn100);
            this.Controls.Add(this.btn75);
            this.Controls.Add(this.btn50);
            this.Controls.Add(this.btn25);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblBet);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblCredit);
            this.Controls.Add(this.lblHand);
            this.Controls.Add(this.mnuPoker);
            this.MainMenuStrip = this.mnuPoker;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "pokerpoker";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmTable_Load);
            this.mnuPoker.ResumeLayout(false);
            this.mnuPoker.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip mnuPoker;
        private System.Windows.Forms.ToolStripMenuItem newGameToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mnuNewGame;
        private System.Windows.Forms.ToolStripMenuItem mnuExit;
        private System.Windows.Forms.ToolStripMenuItem mnuDraw;
        private System.Windows.Forms.Label lblHand;
        private System.Windows.Forms.Label lblCredit;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblBet;
        private System.Windows.Forms.Button btn25;
        private System.Windows.Forms.Button btn50;
        private System.Windows.Forms.Button btn75;
        private System.Windows.Forms.Button btn100;
        private System.Windows.Forms.ToolStripMenuItem mnuPurchase;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.Label lblPause;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblWin;
    }
}

