namespace TrackerUI
{
    partial class createPrizeForm
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
            createPrizeLabel = new Label();
            prizePercentageTextBox = new TextBox();
            prizePercentageLabel = new Label();
            prizeAmountTextBox = new TextBox();
            prizeAmountLabel = new Label();
            placeNameTextBox = new TextBox();
            placeNameLabel = new Label();
            placeNumberTextBox = new TextBox();
            placeNumberLabel = new Label();
            orLabel = new Label();
            createPrizeButton = new Button();
            folderBrowserDialog1 = new FolderBrowserDialog();
            SuspendLayout();
            // 
            // createPrizeLabel
            // 
            createPrizeLabel.AutoSize = true;
            createPrizeLabel.Font = new Font("Segoe UI", 21.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            createPrizeLabel.ForeColor = Color.Turquoise;
            createPrizeLabel.Location = new Point(12, 9);
            createPrizeLabel.Name = "createPrizeLabel";
            createPrizeLabel.Size = new Size(169, 40);
            createPrizeLabel.TabIndex = 14;
            createPrizeLabel.Text = "Create Prize";
            // 
            // prizePercentageTextBox
            // 
            prizePercentageTextBox.Location = new Point(165, 197);
            prizePercentageTextBox.Name = "prizePercentageTextBox";
            prizePercentageTextBox.Size = new Size(103, 23);
            prizePercentageTextBox.TabIndex = 37;
            prizePercentageTextBox.Text = "0";
            // 
            // prizePercentageLabel
            // 
            prizePercentageLabel.AutoSize = true;
            prizePercentageLabel.Font = new Font("Segoe UI Light", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            prizePercentageLabel.ForeColor = Color.Turquoise;
            prizePercentageLabel.Location = new Point(35, 195);
            prizePercentageLabel.Name = "prizePercentageLabel";
            prizePercentageLabel.Size = new Size(121, 21);
            prizePercentageLabel.TabIndex = 36;
            prizePercentageLabel.Text = "Prize Percentage";
            // 
            // prizeAmountTextBox
            // 
            prizeAmountTextBox.Location = new Point(165, 132);
            prizeAmountTextBox.Name = "prizeAmountTextBox";
            prizeAmountTextBox.Size = new Size(103, 23);
            prizeAmountTextBox.TabIndex = 35;
            prizeAmountTextBox.Text = "0";
            // 
            // prizeAmountLabel
            // 
            prizeAmountLabel.AutoSize = true;
            prizeAmountLabel.Font = new Font("Segoe UI Light", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            prizeAmountLabel.ForeColor = Color.Turquoise;
            prizeAmountLabel.Location = new Point(35, 130);
            prizeAmountLabel.Name = "prizeAmountLabel";
            prizeAmountLabel.Size = new Size(101, 21);
            prizeAmountLabel.TabIndex = 34;
            prizeAmountLabel.Text = "Prize Amount";
            // 
            // placeNameTextBox
            // 
            placeNameTextBox.Location = new Point(165, 98);
            placeNameTextBox.Name = "placeNameTextBox";
            placeNameTextBox.Size = new Size(103, 23);
            placeNameTextBox.TabIndex = 33;
            // 
            // placeNameLabel
            // 
            placeNameLabel.AutoSize = true;
            placeNameLabel.Font = new Font("Segoe UI Light", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            placeNameLabel.ForeColor = Color.Turquoise;
            placeNameLabel.Location = new Point(35, 96);
            placeNameLabel.Name = "placeNameLabel";
            placeNameLabel.Size = new Size(89, 21);
            placeNameLabel.TabIndex = 32;
            placeNameLabel.Text = "Place Name";
            // 
            // placeNumberTextBox
            // 
            placeNumberTextBox.Location = new Point(165, 63);
            placeNumberTextBox.Name = "placeNumberTextBox";
            placeNumberTextBox.Size = new Size(103, 23);
            placeNumberTextBox.TabIndex = 31;
            // 
            // placeNumberLabel
            // 
            placeNumberLabel.AutoSize = true;
            placeNumberLabel.Font = new Font("Segoe UI Light", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            placeNumberLabel.ForeColor = Color.Turquoise;
            placeNumberLabel.Location = new Point(35, 61);
            placeNumberLabel.Name = "placeNumberLabel";
            placeNumberLabel.Size = new Size(104, 21);
            placeNumberLabel.TabIndex = 30;
            placeNumberLabel.Text = "Place Number";
            // 
            // orLabel
            // 
            orLabel.AutoSize = true;
            orLabel.Font = new Font("Segoe UI Light", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            orLabel.ForeColor = Color.Turquoise;
            orLabel.Location = new Point(113, 163);
            orLabel.Name = "orLabel";
            orLabel.Size = new Size(43, 21);
            orLabel.TabIndex = 38;
            orLabel.Text = "-OR-";
            // 
            // createPrizeButton
            // 
            createPrizeButton.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            createPrizeButton.FlatAppearance.BorderColor = Color.FromArgb(224, 224, 224);
            createPrizeButton.FlatAppearance.BorderSize = 2;
            createPrizeButton.FlatAppearance.MouseDownBackColor = Color.FromArgb(102, 102, 102);
            createPrizeButton.FlatAppearance.MouseOverBackColor = Color.FromArgb(242, 242, 242);
            createPrizeButton.FlatStyle = FlatStyle.Flat;
            createPrizeButton.Font = new Font("Segoe UI Light", 14.25F);
            createPrizeButton.ForeColor = Color.Turquoise;
            createPrizeButton.Location = new Point(86, 237);
            createPrizeButton.Name = "createPrizeButton";
            createPrizeButton.Size = new Size(144, 35);
            createPrizeButton.TabIndex = 39;
            createPrizeButton.Text = "Create Prize";
            createPrizeButton.UseVisualStyleBackColor = true;
            createPrizeButton.Click += createPrizeButton_Click;
            // 
            // createPrizeForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(319, 301);
            Controls.Add(createPrizeButton);
            Controls.Add(orLabel);
            Controls.Add(prizePercentageTextBox);
            Controls.Add(prizePercentageLabel);
            Controls.Add(prizeAmountTextBox);
            Controls.Add(prizeAmountLabel);
            Controls.Add(placeNameTextBox);
            Controls.Add(placeNameLabel);
            Controls.Add(placeNumberTextBox);
            Controls.Add(placeNumberLabel);
            Controls.Add(createPrizeLabel);
            Name = "createPrizeForm";
            Text = "Create Prize Form";
            Load += CreatePrizeForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label createPrizeLabel;
        private TextBox prizePercentageTextBox;
        private Label prizePercentageLabel;
        private TextBox prizeAmountTextBox;
        private Label prizeAmountLabel;
        private TextBox placeNameTextBox;
        private Label placeNameLabel;
        private TextBox placeNumberTextBox;
        private Label placeNumberLabel;
        private Label orLabel;
        private Button createPrizeButton;
        private FolderBrowserDialog folderBrowserDialog1;
    }
}