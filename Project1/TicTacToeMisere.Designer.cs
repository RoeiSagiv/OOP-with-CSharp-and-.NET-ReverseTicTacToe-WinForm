namespace TicTacToeGame
{
    public partial class TicTacToeMisere
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
            if(disposing && (components != null))
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
            this.labelPlayerOne = new System.Windows.Forms.Label();
            this.labelPlayerTwo = new System.Windows.Forms.Label();
            this.scoreOfPlayerOneLabel = new System.Windows.Forms.Label();
            this.scoreOfPlayerTwoLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // labelPlayerOne
            // 
            this.labelPlayerOne.AutoSize = true;
            this.labelPlayerOne.Location = new System.Drawing.Point(136, 304);
            this.labelPlayerOne.Name = "labelPlayerOne";
            this.labelPlayerOne.Size = new System.Drawing.Size(64, 17);
            this.labelPlayerOne.TabIndex = 0;
            this.labelPlayerOne.Text = "Player 1:";
            this.labelPlayerOne.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // labelPlayerTwo
            // 
            this.labelPlayerTwo.AutoSize = true;
            this.labelPlayerTwo.Enabled = false;
            this.labelPlayerTwo.Location = new System.Drawing.Point(243, 304);
            this.labelPlayerTwo.Name = "labelPlayerTwo";
            this.labelPlayerTwo.Size = new System.Drawing.Size(71, 20);
            this.labelPlayerTwo.TabIndex = 1;
            this.labelPlayerTwo.Text = "Computer: ";
            this.labelPlayerTwo.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.labelPlayerTwo.UseCompatibleTextRendering = true;
            this.labelPlayerTwo.Click += new System.EventHandler(this.labelPlayerTwo_Click);
            // 
            // scoreOfPlayerOneLabel
            // 
            this.scoreOfPlayerOneLabel.AutoSize = true;
            this.scoreOfPlayerOneLabel.Location = new System.Drawing.Point(206, 304);
            this.scoreOfPlayerOneLabel.Name = "scoreOfPlayerOneLabel";
            this.scoreOfPlayerOneLabel.Size = new System.Drawing.Size(0, 17);
            this.scoreOfPlayerOneLabel.TabIndex = 2;
            this.scoreOfPlayerOneLabel.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // scoreOfPlayerTwoLabel
            // 
            this.scoreOfPlayerTwoLabel.AutoSize = true;
            this.scoreOfPlayerTwoLabel.Location = new System.Drawing.Point(316, 304);
            this.scoreOfPlayerTwoLabel.Name = "scoreOfPlayerTwoLabel";
            this.scoreOfPlayerTwoLabel.Size = new System.Drawing.Size(0, 17);
            this.scoreOfPlayerTwoLabel.TabIndex = 3;
            this.scoreOfPlayerTwoLabel.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // TicTacToeMisere
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(415, 342);
            this.Controls.Add(this.scoreOfPlayerTwoLabel);
            this.Controls.Add(this.scoreOfPlayerOneLabel);
            this.Controls.Add(this.labelPlayerTwo);
            this.Controls.Add(this.labelPlayerOne);
            this.Name = "TicTacToeMisere";
            this.Text = "TicTacToeMisere";
            this.Load += new System.EventHandler(this.TicTacToeMisere_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        #endregion
    }
}