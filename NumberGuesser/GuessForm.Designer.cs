namespace NumberGuesser
{
    partial class GuessForm
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
            guessLabel = new Label();
            titleLabel = new Label();
            infoLabel = new Label();
            guessBox = new TextBox();
            guessBtn = new Button();
            replayBtn = new Button();
            outputLabel = new Label();
            SuspendLayout();
            // 
            // guessLabel
            // 
            guessLabel.AutoSize = true;
            guessLabel.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            guessLabel.Location = new Point(239, 149);
            guessLabel.Name = "guessLabel";
            guessLabel.Size = new Size(122, 28);
            guessLabel.TabIndex = 0;
            guessLabel.Text = "Enter Guess: ";
            // 
            // titleLabel
            // 
            titleLabel.AutoSize = true;
            titleLabel.Font = new Font("Segoe UI", 22F, FontStyle.Regular, GraphicsUnit.Point);
            titleLabel.Location = new Point(182, 40);
            titleLabel.Name = "titleLabel";
            titleLabel.Size = new Size(438, 50);
            titleLabel.TabIndex = 1;
            titleLabel.Text = "Guess The Number Game";
            // 
            // infoLabel
            // 
            infoLabel.AutoSize = true;
            infoLabel.Font = new Font("Segoe UI", 12F, FontStyle.Italic, GraphicsUnit.Point);
            infoLabel.Location = new Point(206, 90);
            infoLabel.Name = "infoLabel";
            infoLabel.Size = new Size(377, 28);
            infoLabel.TabIndex = 2;
            infoLabel.Text = "*Number Is Between 1 and 100 Inclusively";
            // 
            // guessBox
            // 
            guessBox.Location = new Point(401, 150);
            guessBox.Name = "guessBox";
            guessBox.Size = new Size(125, 27);
            guessBox.TabIndex = 3;
            // 
            // guessBtn
            // 
            guessBtn.BackColor = Color.Black;
            guessBtn.FlatAppearance.BorderSize = 0;
            guessBtn.FlatStyle = FlatStyle.Flat;
            guessBtn.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            guessBtn.ForeColor = Color.White;
            guessBtn.Location = new Point(318, 258);
            guessBtn.Name = "guessBtn";
            guessBtn.Size = new Size(148, 52);
            guessBtn.TabIndex = 4;
            guessBtn.Text = "Guess!";
            guessBtn.UseVisualStyleBackColor = true;
            guessBtn.Click += guessBtn_Click;
            // 
            // replayBtn
            // 
            replayBtn.BackColor = Color.Black;
            replayBtn.FlatAppearance.BorderSize = 0;
            replayBtn.FlatStyle = FlatStyle.Flat;
            replayBtn.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            replayBtn.ForeColor = Color.White;
            replayBtn.Location = new Point(318, 340);
            replayBtn.Name = "replayBtn";
            replayBtn.Size = new Size(148, 52);
            replayBtn.TabIndex = 5;
            replayBtn.Text = "Play Again!";
            replayBtn.UseVisualStyleBackColor = true;
            replayBtn.Click += replayBtn_Click;
            // 
            // outputLabel
            // 
            outputLabel.AutoSize = true;
            outputLabel.ForeColor = Color.White;
            outputLabel.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            outputLabel.Location = new Point(375, 205);
            outputLabel.Name = "outputLabel";
            outputLabel.Size = new Size(0, 28);
            outputLabel.TabIndex = 6;
            // 
            // GuessForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(outputLabel);
            Controls.Add(replayBtn);
            Controls.Add(guessBtn);
            Controls.Add(guessBox);
            Controls.Add(infoLabel);
            Controls.Add(titleLabel);
            Controls.Add(guessLabel);
            Name = "GuessForm";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label guessLabel;
        private Label titleLabel;
        private Label infoLabel;
        private TextBox guessBox;
        private Button guessBtn;
        private Button replayBtn;
        private Label outputLabel;
    }
}