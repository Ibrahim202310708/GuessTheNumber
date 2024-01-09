namespace GuessTheNumberGame
{
    partial class GuessTheGame
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
            this.label1 = new System.Windows.Forms.Label();
            this.GuessTextBox = new System.Windows.Forms.TextBox();
            this.HintLabel = new System.Windows.Forms.Label();
            this.GuessButton = new System.Windows.Forms.Button();
            this.NewGameButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(604, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "I have a number between 1 and 1000. Can you guess my number? Enter your Guess";
            // 
            // GuessTextBox
            // 
            this.GuessTextBox.Location = new System.Drawing.Point(16, 58);
            this.GuessTextBox.Name = "GuessTextBox";
            this.GuessTextBox.Size = new System.Drawing.Size(173, 26);
            this.GuessTextBox.TabIndex = 1;
            // 
            // HintLabel
            // 
            this.HintLabel.AutoSize = true;
            this.HintLabel.Location = new System.Drawing.Point(218, 64);
            this.HintLabel.Name = "HintLabel";
            this.HintLabel.Size = new System.Drawing.Size(9, 20);
            this.HintLabel.TabIndex = 2;
            this.HintLabel.Text = "\r\n";
            // 
            // GuessButton
            // 
            this.GuessButton.Location = new System.Drawing.Point(16, 113);
            this.GuessButton.Name = "GuessButton";
            this.GuessButton.Size = new System.Drawing.Size(102, 32);
            this.GuessButton.TabIndex = 3;
            this.GuessButton.Text = "Guess";
            this.GuessButton.UseVisualStyleBackColor = true;
            this.GuessButton.Click += new System.EventHandler(this.GuessButton_Click);
            // 
            // NewGameButton
            // 
            this.NewGameButton.Location = new System.Drawing.Point(135, 113);
            this.NewGameButton.Name = "NewGameButton";
            this.NewGameButton.Size = new System.Drawing.Size(102, 36);
            this.NewGameButton.TabIndex = 4;
            this.NewGameButton.Text = "New Game";
            this.NewGameButton.UseVisualStyleBackColor = true;
            this.NewGameButton.Click += new System.EventHandler(this.NewGameButton_Click);
            // 
            // GuessTheGame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 224);
            this.Controls.Add(this.NewGameButton);
            this.Controls.Add(this.GuessButton);
            this.Controls.Add(this.HintLabel);
            this.Controls.Add(this.GuessTextBox);
            this.Controls.Add(this.label1);
            this.Name = "GuessTheGame";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox GuessTextBox;
        private System.Windows.Forms.Label HintLabel;
        private System.Windows.Forms.Button GuessButton;
        private System.Windows.Forms.Button NewGameButton;
    }
}

