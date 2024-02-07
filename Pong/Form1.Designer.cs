namespace Pong
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
            this.components = new System.ComponentModel.Container();
            this.gameUpdateLoop = new System.Windows.Forms.Timer(this.components);
            this.startLabel = new System.Windows.Forms.Label();
            this.player1ScoreLabel = new System.Windows.Forms.Label();
            this.plaery2ScoreLabel = new System.Windows.Forms.Label();
            this.powerUpA1Label = new System.Windows.Forms.Label();
            this.powerUpA2Label = new System.Windows.Forms.Label();
            this.powerUpB1Label = new System.Windows.Forms.Label();
            this.powerUpB2Label = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // gameUpdateLoop
            // 
            this.gameUpdateLoop.Interval = 16;
            this.gameUpdateLoop.Tick += new System.EventHandler(this.gameUpdateLoop_Tick);
            // 
            // startLabel
            // 
            this.startLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.startLabel.Font = new System.Drawing.Font("Courier New", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.startLabel.ForeColor = System.Drawing.Color.White;
            this.startLabel.Location = new System.Drawing.Point(212, 200);
            this.startLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.startLabel.Name = "startLabel";
            this.startLabel.Size = new System.Drawing.Size(494, 246);
            this.startLabel.TabIndex = 0;
            this.startLabel.Text = "Press Space To Start or Esc to Exit";
            this.startLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // player1ScoreLabel
            // 
            this.player1ScoreLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.player1ScoreLabel.BackColor = System.Drawing.Color.Transparent;
            this.player1ScoreLabel.Font = new System.Drawing.Font("Courier New", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.player1ScoreLabel.ForeColor = System.Drawing.Color.White;
            this.player1ScoreLabel.Location = new System.Drawing.Point(333, 14);
            this.player1ScoreLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.player1ScoreLabel.Name = "player1ScoreLabel";
            this.player1ScoreLabel.Size = new System.Drawing.Size(96, 105);
            this.player1ScoreLabel.TabIndex = 1;
            this.player1ScoreLabel.Text = "0";
            this.player1ScoreLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // plaery2ScoreLabel
            // 
            this.plaery2ScoreLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.plaery2ScoreLabel.BackColor = System.Drawing.Color.Transparent;
            this.plaery2ScoreLabel.Font = new System.Drawing.Font("Courier New", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.plaery2ScoreLabel.ForeColor = System.Drawing.Color.White;
            this.plaery2ScoreLabel.Location = new System.Drawing.Point(483, 14);
            this.plaery2ScoreLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.plaery2ScoreLabel.Name = "plaery2ScoreLabel";
            this.plaery2ScoreLabel.Size = new System.Drawing.Size(96, 105);
            this.plaery2ScoreLabel.TabIndex = 2;
            this.plaery2ScoreLabel.Text = "0";
            this.plaery2ScoreLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // powerUpA1Label
            // 
            this.powerUpA1Label.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.powerUpA1Label.BackColor = System.Drawing.Color.Red;
            this.powerUpA1Label.Font = new System.Drawing.Font("Courier New", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.powerUpA1Label.ForeColor = System.Drawing.Color.White;
            this.powerUpA1Label.Location = new System.Drawing.Point(13, 14);
            this.powerUpA1Label.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.powerUpA1Label.Name = "powerUpA1Label";
            this.powerUpA1Label.Size = new System.Drawing.Size(53, 57);
            this.powerUpA1Label.TabIndex = 3;
            this.powerUpA1Label.Text = "A";
            this.powerUpA1Label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // powerUpA2Label
            // 
            this.powerUpA2Label.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.powerUpA2Label.BackColor = System.Drawing.Color.Red;
            this.powerUpA2Label.Font = new System.Drawing.Font("Courier New", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.powerUpA2Label.ForeColor = System.Drawing.Color.White;
            this.powerUpA2Label.Location = new System.Drawing.Point(771, 14);
            this.powerUpA2Label.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.powerUpA2Label.Name = "powerUpA2Label";
            this.powerUpA2Label.Size = new System.Drawing.Size(53, 57);
            this.powerUpA2Label.TabIndex = 4;
            this.powerUpA2Label.Text = "<";
            this.powerUpA2Label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // powerUpB1Label
            // 
            this.powerUpB1Label.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.powerUpB1Label.BackColor = System.Drawing.Color.Red;
            this.powerUpB1Label.Font = new System.Drawing.Font("Courier New", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.powerUpB1Label.ForeColor = System.Drawing.Color.White;
            this.powerUpB1Label.Location = new System.Drawing.Point(84, 14);
            this.powerUpB1Label.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.powerUpB1Label.Name = "powerUpB1Label";
            this.powerUpB1Label.Size = new System.Drawing.Size(53, 57);
            this.powerUpB1Label.TabIndex = 5;
            this.powerUpB1Label.Text = "D";
            this.powerUpB1Label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // powerUpB2Label
            // 
            this.powerUpB2Label.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.powerUpB2Label.BackColor = System.Drawing.Color.Red;
            this.powerUpB2Label.Font = new System.Drawing.Font("Courier New", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.powerUpB2Label.ForeColor = System.Drawing.Color.White;
            this.powerUpB2Label.Location = new System.Drawing.Point(844, 14);
            this.powerUpB2Label.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.powerUpB2Label.Name = "powerUpB2Label";
            this.powerUpB2Label.Size = new System.Drawing.Size(53, 57);
            this.powerUpB2Label.TabIndex = 6;
            this.powerUpB2Label.Text = ">";
            this.powerUpB2Label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(924, 692);
            this.Controls.Add(this.powerUpB2Label);
            this.Controls.Add(this.powerUpB1Label);
            this.Controls.Add(this.powerUpA2Label);
            this.Controls.Add(this.powerUpA1Label);
            this.Controls.Add(this.plaery2ScoreLabel);
            this.Controls.Add(this.player1ScoreLabel);
            this.Controls.Add(this.startLabel);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Pong";
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.Form1_Paint);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyUp);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Timer gameUpdateLoop;
        private System.Windows.Forms.Label startLabel;
        private System.Windows.Forms.Label player1ScoreLabel;
        private System.Windows.Forms.Label plaery2ScoreLabel;
        private System.Windows.Forms.Timer powerUpTimer;
        private System.Windows.Forms.Label powerUpA1Label;
        private System.Windows.Forms.Label powerUpA2Label;
        private System.Windows.Forms.Label powerUpB1Label;
        private System.Windows.Forms.Label powerUpB2Label;
    }
}

