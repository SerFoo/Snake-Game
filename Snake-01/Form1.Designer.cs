
namespace Snake_01
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.Player1 = new System.Windows.Forms.PictureBox();
            this.fileSystemWatcher1 = new System.IO.FileSystemWatcher();
            this.Player2 = new System.Windows.Forms.PictureBox();
            this.Ball = new System.Windows.Forms.PictureBox();
            this.GameTimer = new System.Windows.Forms.Timer(this.components);
            this.Player1Score = new System.Windows.Forms.Label();
            this.Player2Score = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.Player1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Player2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Ball)).BeginInit();
            this.SuspendLayout();
            // 
            // Player1
            // 
            this.Player1.AccessibleName = "Player1";
            this.Player1.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.Player1.Location = new System.Drawing.Point(12, 212);
            this.Player1.Name = "Player1";
            this.Player1.Size = new System.Drawing.Size(27, 127);
            this.Player1.TabIndex = 0;
            this.Player1.TabStop = false;
            this.Player1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // fileSystemWatcher1
            // 
            this.fileSystemWatcher1.EnableRaisingEvents = true;
            this.fileSystemWatcher1.SynchronizingObject = this;
            this.fileSystemWatcher1.Changed += new System.IO.FileSystemEventHandler(this.fileSystemWatcher1_Changed);
            // 
            // Player2
            // 
            this.Player2.AccessibleName = "Player2";
            this.Player2.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.Player2.Location = new System.Drawing.Point(889, 212);
            this.Player2.Name = "Player2";
            this.Player2.Size = new System.Drawing.Size(27, 127);
            this.Player2.TabIndex = 1;
            this.Player2.TabStop = false;
            // 
            // Ball
            // 
            this.Ball.BackColor = System.Drawing.SystemColors.Window;
            this.Ball.Location = new System.Drawing.Point(458, 261);
            this.Ball.Name = "Ball";
            this.Ball.Size = new System.Drawing.Size(20, 20);
            this.Ball.TabIndex = 2;
            this.Ball.TabStop = false;
            // 
            // GameTimer
            // 
            this.GameTimer.Enabled = true;
            this.GameTimer.Interval = 20;
            this.GameTimer.Tick += new System.EventHandler(this.timerTick);
            // 
            // Player1Score
            // 
            this.Player1Score.AutoSize = true;
            this.Player1Score.Font = new System.Drawing.Font("Symbol", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Player1Score.ForeColor = System.Drawing.SystemColors.Window;
            this.Player1Score.Location = new System.Drawing.Point(12, 9);
            this.Player1Score.Name = "Player1Score";
            this.Player1Score.Size = new System.Drawing.Size(39, 30);
            this.Player1Score.TabIndex = 3;
            this.Player1Score.Text = "00";
            // 
            // Player2Score
            // 
            this.Player2Score.AutoSize = true;
            this.Player2Score.Font = new System.Drawing.Font("Symbol", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Player2Score.ForeColor = System.Drawing.SystemColors.Window;
            this.Player2Score.Location = new System.Drawing.Point(877, 9);
            this.Player2Score.Name = "Player2Score";
            this.Player2Score.Size = new System.Drawing.Size(39, 30);
            this.Player2Score.TabIndex = 4;
            this.Player2Score.Text = "00";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(928, 574);
            this.Controls.Add(this.Player2Score);
            this.Controls.Add(this.Player1Score);
            this.Controls.Add(this.Ball);
            this.Controls.Add(this.Player2);
            this.Controls.Add(this.Player1);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(944, 613);
            this.MinimumSize = new System.Drawing.Size(944, 613);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.keydown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.keyup);
            ((System.ComponentModel.ISupportInitialize)(this.Player1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Player2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Ball)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox Player1;
        private System.IO.FileSystemWatcher fileSystemWatcher1;
        private System.Windows.Forms.Label Player2Score;
        private System.Windows.Forms.Label Player1Score;
        private System.Windows.Forms.PictureBox Ball;
        private System.Windows.Forms.PictureBox Player2;
        private System.Windows.Forms.Timer GameTimer;
    }
}

