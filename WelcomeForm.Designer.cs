namespace MemoryGame
{
    partial class WelcomeForm
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
            this.PlayButton = new System.Windows.Forms.Button();
            this.HighScoresButton = new System.Windows.Forms.Button();
            this.ExitButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // PlayButton
            // 
            this.PlayButton.Font = new System.Drawing.Font("Georgia", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PlayButton.Location = new System.Drawing.Point(307, 110);
            this.PlayButton.Name = "PlayButton";
            this.PlayButton.Size = new System.Drawing.Size(162, 43);
            this.PlayButton.TabIndex = 0;
            this.PlayButton.Text = "Play Game";
            this.PlayButton.UseVisualStyleBackColor = true;
            this.PlayButton.Click += new System.EventHandler(this.PlayButton_Click);
            // 
            // HighScoresButton
            // 
            this.HighScoresButton.Font = new System.Drawing.Font("Georgia", 18F);
            this.HighScoresButton.Location = new System.Drawing.Point(307, 183);
            this.HighScoresButton.Name = "HighScoresButton";
            this.HighScoresButton.Size = new System.Drawing.Size(162, 43);
            this.HighScoresButton.TabIndex = 1;
            this.HighScoresButton.Text = "High Scores";
            this.HighScoresButton.UseVisualStyleBackColor = true;
            this.HighScoresButton.Click += new System.EventHandler(this.HighScoresButton_Click);
            // 
            // ExitButton
            // 
            this.ExitButton.Font = new System.Drawing.Font("Georgia", 18F);
            this.ExitButton.Location = new System.Drawing.Point(307, 247);
            this.ExitButton.Name = "ExitButton";
            this.ExitButton.Size = new System.Drawing.Size(162, 43);
            this.ExitButton.TabIndex = 2;
            this.ExitButton.Text = "Exit";
            this.ExitButton.UseVisualStyleBackColor = true;
            this.ExitButton.Click += new System.EventHandler(this.ExitButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Modern No. 20", 27.75F);
            this.label1.Location = new System.Drawing.Point(285, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(237, 38);
            this.label1.TabIndex = 4;
            this.label1.Text = "Memory Game";
            // 
            // WelcomeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Green;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ExitButton);
            this.Controls.Add(this.HighScoresButton);
            this.Controls.Add(this.PlayButton);
            this.Name = "WelcomeForm";
            this.Text = "WelcomeForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button PlayButton;
        private System.Windows.Forms.Button HighScoresButton;
        private System.Windows.Forms.Button ExitButton;
        private System.Windows.Forms.Label label1;
    }
}