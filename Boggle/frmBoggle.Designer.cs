namespace Boggle
{
    partial class frmBoggle
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmBoggle));
            this.btnPlay = new System.Windows.Forms.Button();
            this.btnQuit = new System.Windows.Forms.Button();
            this.txtName = new System.Windows.Forms.TextBox();
            this.lblName = new System.Windows.Forms.Label();
            this.pcbxBoggleTitle = new System.Windows.Forms.PictureBox();
            this.pcbxBoggleSet = new System.Windows.Forms.PictureBox();
            this.lblInstructions = new System.Windows.Forms.Label();
            this.pnlInstructions = new System.Windows.Forms.Panel();
            this.btnStartGame = new System.Windows.Forms.Button();
            this.pnlGameDisplay = new System.Windows.Forms.Panel();
            this.lblWordsEntered = new System.Windows.Forms.Label();
            this.dgvWordsEntered = new System.Windows.Forms.DataGridView();
            this.lblTimer = new System.Windows.Forms.Label();
            this.lblTimeLeft = new System.Windows.Forms.Label();
            this.lblEnterWords = new System.Windows.Forms.Label();
            this.txtEnterWords = new System.Windows.Forms.TextBox();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.pnlBoard = new System.Windows.Forms.Panel();
            this.btnResetBoard = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pcbxBoggleTitle)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbxBoggleSet)).BeginInit();
            this.pnlInstructions.SuspendLayout();
            this.pnlGameDisplay.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvWordsEntered)).BeginInit();
            this.SuspendLayout();
            // 
            // btnPlay
            // 
            this.btnPlay.BackColor = System.Drawing.SystemColors.Window;
            this.btnPlay.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnPlay.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPlay.Location = new System.Drawing.Point(458, 111);
            this.btnPlay.Name = "btnPlay";
            this.btnPlay.Size = new System.Drawing.Size(71, 47);
            this.btnPlay.TabIndex = 1;
            this.btnPlay.Text = "PLAY";
            this.btnPlay.UseVisualStyleBackColor = false;
            this.btnPlay.Click += new System.EventHandler(this.btnPlay_Click);
            // 
            // btnQuit
            // 
            this.btnQuit.BackColor = System.Drawing.SystemColors.Window;
            this.btnQuit.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnQuit.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnQuit.Location = new System.Drawing.Point(549, 111);
            this.btnQuit.Name = "btnQuit";
            this.btnQuit.Size = new System.Drawing.Size(71, 47);
            this.btnQuit.TabIndex = 2;
            this.btnQuit.Text = "QUIT";
            this.btnQuit.UseVisualStyleBackColor = false;
            this.btnQuit.Click += new System.EventHandler(this.btnQuit_Click);
            // 
            // txtName
            // 
            this.txtName.BackColor = System.Drawing.SystemColors.Window;
            this.txtName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtName.Location = new System.Drawing.Point(220, 120);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(206, 26);
            this.txtName.TabIndex = 3;
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.ForeColor = System.Drawing.SystemColors.Window;
            this.lblName.Location = new System.Drawing.Point(74, 117);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(140, 29);
            this.lblName.TabIndex = 4;
            this.lblName.Text = "Your Name:";
            // 
            // pcbxBoggleTitle
            // 
            this.pcbxBoggleTitle.Image = global::Boggle.Properties.Resources.boggle_title;
            this.pcbxBoggleTitle.Location = new System.Drawing.Point(127, 12);
            this.pcbxBoggleTitle.Name = "pcbxBoggleTitle";
            this.pcbxBoggleTitle.Size = new System.Drawing.Size(493, 90);
            this.pcbxBoggleTitle.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pcbxBoggleTitle.TabIndex = 6;
            this.pcbxBoggleTitle.TabStop = false;
            // 
            // pcbxBoggleSet
            // 
            this.pcbxBoggleSet.Image = global::Boggle.Properties.Resources.Boggle_set;
            this.pcbxBoggleSet.Location = new System.Drawing.Point(169, 198);
            this.pcbxBoggleSet.Name = "pcbxBoggleSet";
            this.pcbxBoggleSet.Size = new System.Drawing.Size(393, 256);
            this.pcbxBoggleSet.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pcbxBoggleSet.TabIndex = 5;
            this.pcbxBoggleSet.TabStop = false;
            // 
            // lblInstructions
            // 
            this.lblInstructions.AutoSize = true;
            this.lblInstructions.Font = new System.Drawing.Font("Mongolian Baiti", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInstructions.ForeColor = System.Drawing.SystemColors.Window;
            this.lblInstructions.Location = new System.Drawing.Point(9, 10);
            this.lblInstructions.Name = "lblInstructions";
            this.lblInstructions.Size = new System.Drawing.Size(683, 115);
            this.lblInstructions.TabIndex = 5;
            this.lblInstructions.Text = resources.GetString("lblInstructions.Text");
            // 
            // pnlInstructions
            // 
            this.pnlInstructions.Controls.Add(this.btnStartGame);
            this.pnlInstructions.Controls.Add(this.lblInstructions);
            this.pnlInstructions.Location = new System.Drawing.Point(4, 164);
            this.pnlInstructions.Name = "pnlInstructions";
            this.pnlInstructions.Size = new System.Drawing.Size(700, 188);
            this.pnlInstructions.TabIndex = 7;
            this.pnlInstructions.Visible = false;
            // 
            // btnStartGame
            // 
            this.btnStartGame.BackColor = System.Drawing.SystemColors.Window;
            this.btnStartGame.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnStartGame.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStartGame.Location = new System.Drawing.Point(287, 128);
            this.btnStartGame.Name = "btnStartGame";
            this.btnStartGame.Size = new System.Drawing.Size(125, 50);
            this.btnStartGame.TabIndex = 6;
            this.btnStartGame.Text = "START GAME";
            this.btnStartGame.UseVisualStyleBackColor = false;
            this.btnStartGame.Click += new System.EventHandler(this.btnStartGame_Click);
            // 
            // pnlGameDisplay
            // 
            this.pnlGameDisplay.Controls.Add(this.label1);
            this.pnlGameDisplay.Controls.Add(this.btnResetBoard);
            this.pnlGameDisplay.Controls.Add(this.pnlBoard);
            this.pnlGameDisplay.Controls.Add(this.btnSubmit);
            this.pnlGameDisplay.Controls.Add(this.lblWordsEntered);
            this.pnlGameDisplay.Controls.Add(this.dgvWordsEntered);
            this.pnlGameDisplay.Controls.Add(this.lblTimer);
            this.pnlGameDisplay.Controls.Add(this.lblTimeLeft);
            this.pnlGameDisplay.Controls.Add(this.lblEnterWords);
            this.pnlGameDisplay.Controls.Add(this.txtEnterWords);
            this.pnlGameDisplay.Location = new System.Drawing.Point(1, 348);
            this.pnlGameDisplay.Name = "pnlGameDisplay";
            this.pnlGameDisplay.Size = new System.Drawing.Size(700, 484);
            this.pnlGameDisplay.TabIndex = 8;
            this.pnlGameDisplay.Visible = false;
            // 
            // lblWordsEntered
            // 
            this.lblWordsEntered.AutoSize = true;
            this.lblWordsEntered.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWordsEntered.ForeColor = System.Drawing.SystemColors.Window;
            this.lblWordsEntered.Location = new System.Drawing.Point(509, 81);
            this.lblWordsEntered.Name = "lblWordsEntered";
            this.lblWordsEntered.Size = new System.Drawing.Size(151, 23);
            this.lblWordsEntered.TabIndex = 9;
            this.lblWordsEntered.Text = "Billy Bob\'s Words";
            // 
            // dgvWordsEntered
            // 
            this.dgvWordsEntered.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvWordsEntered.Location = new System.Drawing.Point(514, 112);
            this.dgvWordsEntered.Name = "dgvWordsEntered";
            this.dgvWordsEntered.ReadOnly = true;
            this.dgvWordsEntered.Size = new System.Drawing.Size(181, 369);
            this.dgvWordsEntered.TabIndex = 8;
            // 
            // lblTimer
            // 
            this.lblTimer.AutoSize = true;
            this.lblTimer.BackColor = System.Drawing.SystemColors.MenuText;
            this.lblTimer.Font = new System.Drawing.Font("Tw Cen MT Condensed Extra Bold", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTimer.ForeColor = System.Drawing.SystemColors.Window;
            this.lblTimer.Location = new System.Drawing.Point(381, 428);
            this.lblTimer.Name = "lblTimer";
            this.lblTimer.Size = new System.Drawing.Size(36, 28);
            this.lblTimer.TabIndex = 7;
            this.lblTimer.Text = "60";
            // 
            // lblTimeLeft
            // 
            this.lblTimeLeft.AutoSize = true;
            this.lblTimeLeft.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTimeLeft.ForeColor = System.Drawing.SystemColors.Window;
            this.lblTimeLeft.Location = new System.Drawing.Point(267, 430);
            this.lblTimeLeft.Name = "lblTimeLeft";
            this.lblTimeLeft.Size = new System.Drawing.Size(107, 25);
            this.lblTimeLeft.TabIndex = 6;
            this.lblTimeLeft.Text = "Time Left:";
            // 
            // lblEnterWords
            // 
            this.lblEnterWords.AutoSize = true;
            this.lblEnterWords.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEnterWords.ForeColor = System.Drawing.SystemColors.Window;
            this.lblEnterWords.Location = new System.Drawing.Point(95, 22);
            this.lblEnterWords.Name = "lblEnterWords";
            this.lblEnterWords.Size = new System.Drawing.Size(186, 25);
            this.lblEnterWords.TabIndex = 5;
            this.lblEnterWords.Text = "Enter Words Here:";
            // 
            // txtEnterWords
            // 
            this.txtEnterWords.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEnterWords.Location = new System.Drawing.Point(287, 19);
            this.txtEnterWords.Name = "txtEnterWords";
            this.txtEnterWords.Size = new System.Drawing.Size(150, 29);
            this.txtEnterWords.TabIndex = 0;
            // 
            // btnSubmit
            // 
            this.btnSubmit.BackColor = System.Drawing.SystemColors.Window;
            this.btnSubmit.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnSubmit.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSubmit.Location = new System.Drawing.Point(457, 16);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(125, 41);
            this.btnSubmit.TabIndex = 10;
            this.btnSubmit.Text = "ADD WORD";
            this.btnSubmit.UseVisualStyleBackColor = false;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // pnlBoard
            // 
            this.pnlBoard.Location = new System.Drawing.Point(16, 63);
            this.pnlBoard.Name = "pnlBoard";
            this.pnlBoard.Size = new System.Drawing.Size(476, 353);
            this.pnlBoard.TabIndex = 11;
            this.pnlBoard.Visible = false;
            // 
            // btnResetBoard
            // 
            this.btnResetBoard.BackColor = System.Drawing.SystemColors.Window;
            this.btnResetBoard.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnResetBoard.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnResetBoard.Location = new System.Drawing.Point(126, 420);
            this.btnResetBoard.Name = "btnResetBoard";
            this.btnResetBoard.Size = new System.Drawing.Size(125, 41);
            this.btnResetBoard.TabIndex = 12;
            this.btnResetBoard.Text = "RESET BOARD";
            this.btnResetBoard.UseVisualStyleBackColor = false;
            this.btnResetBoard.Click += new System.EventHandler(this.btnResetBoard_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Window;
            this.label1.Location = new System.Drawing.Point(151, 463);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 16);
            this.label1.TabIndex = 6;
            this.label1.Text = "(Start Over)";
            // 
            // frmBoggle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.HotTrack;
            this.ClientSize = new System.Drawing.Size(708, 844);
            this.Controls.Add(this.pnlGameDisplay);
            this.Controls.Add(this.pnlInstructions);
            this.Controls.Add(this.pcbxBoggleTitle);
            this.Controls.Add(this.pcbxBoggleSet);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.btnQuit);
            this.Controls.Add(this.btnPlay);
            this.Name = "frmBoggle";
            this.Text = "Play Boggle NOW!";
            ((System.ComponentModel.ISupportInitialize)(this.pcbxBoggleTitle)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbxBoggleSet)).EndInit();
            this.pnlInstructions.ResumeLayout(false);
            this.pnlInstructions.PerformLayout();
            this.pnlGameDisplay.ResumeLayout(false);
            this.pnlGameDisplay.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvWordsEntered)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnPlay;
        private System.Windows.Forms.Button btnQuit;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.PictureBox pcbxBoggleSet;
        private System.Windows.Forms.PictureBox pcbxBoggleTitle;
        private System.Windows.Forms.Label lblInstructions;
        private System.Windows.Forms.Panel pnlInstructions;
        private System.Windows.Forms.Button btnStartGame;
        private System.Windows.Forms.Panel pnlGameDisplay;
        private System.Windows.Forms.Label lblEnterWords;
        private System.Windows.Forms.TextBox txtEnterWords;
        private System.Windows.Forms.Label lblTimer;
        private System.Windows.Forms.Label lblTimeLeft;
        private System.Windows.Forms.Label lblWordsEntered;
        private System.Windows.Forms.DataGridView dgvWordsEntered;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.Panel pnlBoard;
        private System.Windows.Forms.Button btnResetBoard;
        private System.Windows.Forms.Label label1;
    }
}

