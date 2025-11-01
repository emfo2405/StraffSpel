namespace StraffSpel
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
            buttonLeft = new Button();
            buttonCenter = new Button();
            buttonRight = new Button();
            pictureBox1 = new PictureBox();
            label2 = new Label();
            restart = new Button();
            nameInsert = new TextBox();
            startButton = new Button();
            introductionLabel = new Label();
            topScoreBox = new ListBox();
            writeName = new Label();
            nameWarning = new Label();
            endMessage = new Label();
            newNameGameBtn = new Button();
            clearButton = new Button();
            gameDescription = new Label();
            topListTitle = new Label();
            exitGame = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // buttonLeft
            // 
            buttonLeft.BackColor = SystemColors.GradientInactiveCaption;
            buttonLeft.Cursor = Cursors.Hand;
            buttonLeft.FlatStyle = FlatStyle.Flat;
            buttonLeft.Font = new Font("Rockwell", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            buttonLeft.Location = new Point(399, 663);
            buttonLeft.Name = "buttonLeft";
            buttonLeft.Padding = new Padding(0, 6, 0, 6);
            buttonLeft.Size = new Size(112, 45);
            buttonLeft.TabIndex = 0;
            buttonLeft.Text = "Vänster";
            buttonLeft.UseVisualStyleBackColor = false;
            buttonLeft.Click += buttonLeft_Click;
            // 
            // buttonCenter
            // 
            buttonCenter.BackColor = SystemColors.GradientInactiveCaption;
            buttonCenter.Cursor = Cursors.Hand;
            buttonCenter.FlatStyle = FlatStyle.Flat;
            buttonCenter.Font = new Font("Rockwell", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            buttonCenter.Location = new Point(646, 663);
            buttonCenter.Name = "buttonCenter";
            buttonCenter.Padding = new Padding(0, 6, 0, 6);
            buttonCenter.Size = new Size(112, 45);
            buttonCenter.TabIndex = 1;
            buttonCenter.Text = "Mitten";
            buttonCenter.UseVisualStyleBackColor = false;
            buttonCenter.Click += buttonCenter_Click;
            // 
            // buttonRight
            // 
            buttonRight.BackColor = SystemColors.GradientInactiveCaption;
            buttonRight.Cursor = Cursors.Hand;
            buttonRight.FlatStyle = FlatStyle.Flat;
            buttonRight.Font = new Font("Rockwell", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            buttonRight.Location = new Point(892, 663);
            buttonRight.Name = "buttonRight";
            buttonRight.Padding = new Padding(0, 6, 0, 6);
            buttonRight.Size = new Size(112, 45);
            buttonRight.TabIndex = 2;
            buttonRight.Text = "Höger";
            buttonRight.UseVisualStyleBackColor = false;
            buttonRight.Click += buttonRight_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(269, 49);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(863, 566);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 3;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click_1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = SystemColors.ActiveCaptionText;
            label2.Font = new Font("Rockwell", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = SystemColors.HighlightText;
            label2.Location = new Point(33, 107);
            label2.Name = "label2";
            label2.Size = new Size(82, 27);
            label2.TabIndex = 5;
            label2.Text = "label2";
            // 
            // restart
            // 
            restart.BackColor = SystemColors.GradientInactiveCaption;
            restart.Cursor = Cursors.Hand;
            restart.FlatStyle = FlatStyle.Flat;
            restart.Font = new Font("Rockwell", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            restart.Location = new Point(92, 740);
            restart.Name = "restart";
            restart.Padding = new Padding(0, 6, 0, 6);
            restart.Size = new Size(167, 45);
            restart.TabIndex = 6;
            restart.Text = "Starta om spelet";
            restart.UseVisualStyleBackColor = false;
            restart.Click += restart_Click;
            // 
            // nameInsert
            // 
            nameInsert.Location = new Point(556, 386);
            nameInsert.Name = "nameInsert";
            nameInsert.Size = new Size(286, 31);
            nameInsert.TabIndex = 7;
            // 
            // startButton
            // 
            startButton.BackColor = SystemColors.GradientInactiveCaption;
            startButton.Cursor = Cursors.Hand;
            startButton.FlatStyle = FlatStyle.Flat;
            startButton.Font = new Font("Rockwell", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            startButton.Location = new Point(623, 463);
            startButton.Name = "startButton";
            startButton.Padding = new Padding(0, 6, 0, 6);
            startButton.Size = new Size(156, 53);
            startButton.TabIndex = 8;
            startButton.Text = "Starta spelet";
            startButton.UseVisualStyleBackColor = false;
            startButton.Click += startButton_Click;
            // 
            // introductionLabel
            // 
            introductionLabel.AutoSize = true;
            introductionLabel.Font = new Font("Rockwell", 16F, FontStyle.Regular, GraphicsUnit.Point, 0);
            introductionLabel.Location = new Point(275, 228);
            introductionLabel.MinimumSize = new Size(850, 0);
            introductionLabel.Name = "introductionLabel";
            introductionLabel.Size = new Size(850, 36);
            introductionLabel.TabIndex = 9;
            introductionLabel.Text = "Välkommen till straffspelet!";
            introductionLabel.TextAlign = ContentAlignment.TopCenter;
            // 
            // topScoreBox
            // 
            topScoreBox.BackColor = SystemColors.GradientInactiveCaption;
            topScoreBox.BorderStyle = BorderStyle.None;
            topScoreBox.Font = new Font("Rockwell", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            topScoreBox.FormattingEnabled = true;
            topScoreBox.ItemHeight = 20;
            topScoreBox.Location = new Point(25, 352);
            topScoreBox.Name = "topScoreBox";
            topScoreBox.Size = new Size(208, 120);
            topScoreBox.TabIndex = 10;
            // 
            // writeName
            // 
            writeName.AutoSize = true;
            writeName.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            writeName.Location = new Point(276, 347);
            writeName.MinimumSize = new Size(850, 0);
            writeName.Name = "writeName";
            writeName.Size = new Size(850, 25);
            writeName.TabIndex = 11;
            writeName.Text = "Skriv in ditt namn nedan";
            writeName.TextAlign = ContentAlignment.TopCenter;
            // 
            // nameWarning
            // 
            nameWarning.AutoSize = true;
            nameWarning.Font = new Font("Segoe UI", 8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            nameWarning.Location = new Point(277, 430);
            nameWarning.MinimumSize = new Size(850, 0);
            nameWarning.Name = "nameWarning";
            nameWarning.Size = new Size(850, 21);
            nameWarning.TabIndex = 12;
            nameWarning.Text = ".";
            nameWarning.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // endMessage
            // 
            endMessage.AutoSize = true;
            endMessage.BackColor = SystemColors.ActiveCaptionText;
            endMessage.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            endMessage.ForeColor = SystemColors.HighlightText;
            endMessage.Location = new Point(276, 572);
            endMessage.MinimumSize = new Size(850, 0);
            endMessage.Name = "endMessage";
            endMessage.Size = new Size(850, 38);
            endMessage.TabIndex = 13;
            endMessage.Text = "label3";
            endMessage.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // newNameGameBtn
            // 
            newNameGameBtn.BackColor = SystemColors.GradientInactiveCaption;
            newNameGameBtn.Cursor = Cursors.Hand;
            newNameGameBtn.FlatStyle = FlatStyle.Flat;
            newNameGameBtn.Font = new Font("Rockwell", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            newNameGameBtn.Location = new Point(55, 806);
            newNameGameBtn.Name = "newNameGameBtn";
            newNameGameBtn.Padding = new Padding(0, 6, 0, 6);
            newNameGameBtn.Size = new Size(227, 45);
            newNameGameBtn.TabIndex = 14;
            newNameGameBtn.Text = "Starta med ny spelare";
            newNameGameBtn.UseVisualStyleBackColor = false;
            newNameGameBtn.Click += newNameGameBtn_Click;
            // 
            // clearButton
            // 
            clearButton.BackColor = SystemColors.GradientInactiveCaption;
            clearButton.Cursor = Cursors.Hand;
            clearButton.FlatStyle = FlatStyle.Flat;
            clearButton.Font = new Font("Rockwell", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            clearButton.Location = new Point(40, 484);
            clearButton.Name = "clearButton";
            clearButton.Padding = new Padding(0, 6, 0, 6);
            clearButton.Size = new Size(179, 43);
            clearButton.TabIndex = 15;
            clearButton.Text = "Rensa topplista";
            clearButton.UseVisualStyleBackColor = false;
            clearButton.Click += clearButton_Click;
            // 
            // gameDescription
            // 
            gameDescription.AutoSize = true;
            gameDescription.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            gameDescription.Location = new Point(275, 271);
            gameDescription.MinimumSize = new Size(850, 0);
            gameDescription.Name = "gameDescription";
            gameDescription.Size = new Size(850, 25);
            gameDescription.TabIndex = 16;
            gameDescription.Text = ".";
            gameDescription.TextAlign = ContentAlignment.MiddleCenter;
            gameDescription.Click += gameDescription_Click;
            // 
            // topListTitle
            // 
            topListTitle.AutoSize = true;
            topListTitle.Font = new Font("Rockwell", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            topListTitle.Location = new Point(39, 306);
            topListTitle.MinimumSize = new Size(180, 0);
            topListTitle.Name = "topListTitle";
            topListTitle.Size = new Size(180, 31);
            topListTitle.TabIndex = 17;
            topListTitle.Text = "label3";
            topListTitle.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // exitGame
            // 
            exitGame.BackColor = Color.Crimson;
            exitGame.Cursor = Cursors.Hand;
            exitGame.FlatStyle = FlatStyle.Flat;
            exitGame.Font = new Font("Rockwell", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            exitGame.Location = new Point(1141, 13);
            exitGame.Name = "exitGame";
            exitGame.Size = new Size(64, 34);
            exitGame.TabIndex = 18;
            exitGame.Text = "Exit";
            exitGame.UseVisualStyleBackColor = false;
            exitGame.Click += exitGame_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightSlateGray;
            ClientSize = new Size(1225, 903);
            Controls.Add(exitGame);
            Controls.Add(topListTitle);
            Controls.Add(gameDescription);
            Controls.Add(clearButton);
            Controls.Add(newNameGameBtn);
            Controls.Add(endMessage);
            Controls.Add(nameWarning);
            Controls.Add(writeName);
            Controls.Add(topScoreBox);
            Controls.Add(introductionLabel);
            Controls.Add(startButton);
            Controls.Add(nameInsert);
            Controls.Add(restart);
            Controls.Add(label2);
            Controls.Add(pictureBox1);
            Controls.Add(buttonRight);
            Controls.Add(buttonCenter);
            Controls.Add(buttonLeft);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button buttonLeft;
        private Button buttonCenter;
        private Button buttonRight;
        private PictureBox pictureBox1;
        private Label label1;
        private Label label2;
        private Button restart;
        private TextBox nameInsert;
        private Button startButton;
        private Label introductionLabel;
        private ListBox topScoreBox;
        private Label writeName;
        private Label nameWarning;
        private Label endMessage;
        private Button newNameGameBtn;
        private Button clearButton;
        private Label gameDescription;
        private Label topListTitle;
        private Button exitGame;
    }
}
