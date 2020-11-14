namespace MemoryGame
{
    partial class HighScores
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
            this.highScoreText1 = new System.Windows.Forms.TextBox();
            this.highScoreText2 = new System.Windows.Forms.TextBox();
            this.highScoreText3 = new System.Windows.Forms.TextBox();
            this.highScoreText4 = new System.Windows.Forms.TextBox();
            this.highScoreText10 = new System.Windows.Forms.TextBox();
            this.highScoreText5 = new System.Windows.Forms.TextBox();
            this.highScoreText6 = new System.Windows.Forms.TextBox();
            this.highScoreText7 = new System.Windows.Forms.TextBox();
            this.highScoreText8 = new System.Windows.Forms.TextBox();
            this.highScoreText9 = new System.Windows.Forms.TextBox();
            this.highScoreLabel = new System.Windows.Forms.Label();
            this.backButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // highScoreText1
            // 
            this.highScoreText1.Location = new System.Drawing.Point(361, 133);
            this.highScoreText1.Name = "highScoreText1";
            this.highScoreText1.Size = new System.Drawing.Size(98, 20);
            this.highScoreText1.TabIndex = 1;
            // 
            // highScoreText2
            // 
            this.highScoreText2.Location = new System.Drawing.Point(361, 159);
            this.highScoreText2.Name = "highScoreText2";
            this.highScoreText2.Size = new System.Drawing.Size(100, 20);
            this.highScoreText2.TabIndex = 2;
            // 
            // highScoreText3
            // 
            this.highScoreText3.Location = new System.Drawing.Point(361, 185);
            this.highScoreText3.Name = "highScoreText3";
            this.highScoreText3.Size = new System.Drawing.Size(100, 20);
            this.highScoreText3.TabIndex = 3;
            // 
            // highScoreText4
            // 
            this.highScoreText4.Location = new System.Drawing.Point(361, 213);
            this.highScoreText4.Name = "highScoreText4";
            this.highScoreText4.Size = new System.Drawing.Size(100, 20);
            this.highScoreText4.TabIndex = 4;
            // 
            // highScoreText10
            // 
            this.highScoreText10.Location = new System.Drawing.Point(361, 369);
            this.highScoreText10.Name = "highScoreText10";
            this.highScoreText10.Size = new System.Drawing.Size(100, 20);
            this.highScoreText10.TabIndex = 6;
            // 
            // highScoreText5
            // 
            this.highScoreText5.Location = new System.Drawing.Point(361, 239);
            this.highScoreText5.Name = "highScoreText5";
            this.highScoreText5.Size = new System.Drawing.Size(100, 20);
            this.highScoreText5.TabIndex = 7;
            // 
            // highScoreText6
            // 
            this.highScoreText6.Location = new System.Drawing.Point(361, 265);
            this.highScoreText6.Name = "highScoreText6";
            this.highScoreText6.Size = new System.Drawing.Size(100, 20);
            this.highScoreText6.TabIndex = 8;
            // 
            // highScoreText7
            // 
            this.highScoreText7.Location = new System.Drawing.Point(361, 291);
            this.highScoreText7.Name = "highScoreText7";
            this.highScoreText7.Size = new System.Drawing.Size(100, 20);
            this.highScoreText7.TabIndex = 9;
            // 
            // highScoreText8
            // 
            this.highScoreText8.Location = new System.Drawing.Point(361, 317);
            this.highScoreText8.Name = "highScoreText8";
            this.highScoreText8.Size = new System.Drawing.Size(100, 20);
            this.highScoreText8.TabIndex = 10;
            // 
            // highScoreText9
            // 
            this.highScoreText9.Location = new System.Drawing.Point(361, 343);
            this.highScoreText9.Name = "highScoreText9";
            this.highScoreText9.Size = new System.Drawing.Size(100, 20);
            this.highScoreText9.TabIndex = 11;
            // 
            // highScoreLabel
            // 
            this.highScoreLabel.AutoSize = true;
            this.highScoreLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F);
            this.highScoreLabel.Location = new System.Drawing.Point(318, 25);
            this.highScoreLabel.Name = "highScoreLabel";
            this.highScoreLabel.Size = new System.Drawing.Size(174, 33);
            this.highScoreLabel.TabIndex = 12;
            this.highScoreLabel.Text = "High Scores";
            // 
            // backButton
            // 
            this.backButton.Location = new System.Drawing.Point(27, 415);
            this.backButton.Name = "backButton";
            this.backButton.Size = new System.Drawing.Size(75, 23);
            this.backButton.TabIndex = 14;
            this.backButton.Text = "Back";
            this.backButton.UseVisualStyleBackColor = true;
            this.backButton.Click += new System.EventHandler(this.backButton_Click);
            // 
            // HighScores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Green;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.backButton);
            this.Controls.Add(this.highScoreLabel);
            this.Controls.Add(this.highScoreText9);
            this.Controls.Add(this.highScoreText8);
            this.Controls.Add(this.highScoreText7);
            this.Controls.Add(this.highScoreText6);
            this.Controls.Add(this.highScoreText5);
            this.Controls.Add(this.highScoreText10);
            this.Controls.Add(this.highScoreText4);
            this.Controls.Add(this.highScoreText3);
            this.Controls.Add(this.highScoreText2);
            this.Controls.Add(this.highScoreText1);
            this.Name = "HighScores";
            this.Text = "HighScores";
            this.Load += new System.EventHandler(this.HighScores_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox highScoreText1;
        private System.Windows.Forms.TextBox highScoreText2;
        private System.Windows.Forms.TextBox highScoreText3;
        private System.Windows.Forms.TextBox highScoreText4;
        private System.Windows.Forms.TextBox highScoreText10;
        private System.Windows.Forms.TextBox highScoreText5;
        private System.Windows.Forms.TextBox highScoreText6;
        private System.Windows.Forms.TextBox highScoreText7;
        private System.Windows.Forms.TextBox highScoreText8;
        private System.Windows.Forms.TextBox highScoreText9;
        private System.Windows.Forms.Label highScoreLabel;
        private System.Windows.Forms.Button backButton;
    }
}