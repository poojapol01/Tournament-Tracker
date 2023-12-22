namespace TrackerUI
{
    partial class tournamentViewerForm
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
            tournamentLabel = new Label();
            tournamentLabelName = new Label();
            roundLabel = new Label();
            roundDropDown = new ComboBox();
            unplayedOnlyCheckBox = new CheckBox();
            matchUpListBox = new ListBox();
            teamOneName = new Label();
            scoreTeamOneLabel = new Label();
            scoreTeamOneTextBox = new TextBox();
            scoreTeamTwoTextBox = new TextBox();
            scoreTeamTwoLabel = new Label();
            teamTwoNameLabel = new Label();
            versusLabel = new Label();
            scoreButton = new Button();
            SuspendLayout();
            // 
            // tournamentLabel
            // 
            tournamentLabel.AutoSize = true;
            tournamentLabel.Font = new Font("Segoe UI", 21.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tournamentLabel.ForeColor = Color.Turquoise;
            tournamentLabel.Location = new Point(24, 24);
            tournamentLabel.Name = "tournamentLabel";
            tournamentLabel.Size = new Size(175, 40);
            tournamentLabel.TabIndex = 0;
            tournamentLabel.Text = "Tournament:";
            // 
            // tournamentLabelName
            // 
            tournamentLabelName.AutoSize = true;
            tournamentLabelName.Font = new Font("Segoe UI", 21.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tournamentLabelName.ForeColor = Color.Turquoise;
            tournamentLabelName.Location = new Point(189, 24);
            tournamentLabelName.Name = "tournamentLabelName";
            tournamentLabelName.Size = new Size(127, 40);
            tournamentLabelName.TabIndex = 1;
            tournamentLabelName.Text = "<None>";
            // 
            // roundLabel
            // 
            roundLabel.AutoSize = true;
            roundLabel.Font = new Font("Segoe UI Light", 15.75F);
            roundLabel.ForeColor = Color.Turquoise;
            roundLabel.Location = new Point(24, 73);
            roundLabel.Name = "roundLabel";
            roundLabel.Size = new Size(71, 30);
            roundLabel.TabIndex = 2;
            roundLabel.Text = "Round";
            roundLabel.Click += label1_Click;
            // 
            // roundDropDown
            // 
            roundDropDown.FormattingEnabled = true;
            roundDropDown.Location = new Point(107, 80);
            roundDropDown.Name = "roundDropDown";
            roundDropDown.Size = new Size(179, 23);
            roundDropDown.TabIndex = 3;
            // 
            // unplayedOnlyCheckBox
            // 
            unplayedOnlyCheckBox.AutoSize = true;
            unplayedOnlyCheckBox.Font = new Font("Segoe UI Light", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            unplayedOnlyCheckBox.ForeColor = Color.Turquoise;
            unplayedOnlyCheckBox.Location = new Point(130, 116);
            unplayedOnlyCheckBox.Name = "unplayedOnlyCheckBox";
            unplayedOnlyCheckBox.Size = new Size(127, 25);
            unplayedOnlyCheckBox.TabIndex = 4;
            unplayedOnlyCheckBox.Text = "Unplayed Only";
            unplayedOnlyCheckBox.UseVisualStyleBackColor = true;
            // 
            // matchUpListBox
            // 
            matchUpListBox.FormattingEnabled = true;
            matchUpListBox.ItemHeight = 15;
            matchUpListBox.Location = new Point(24, 153);
            matchUpListBox.Name = "matchUpListBox";
            matchUpListBox.Size = new Size(262, 199);
            matchUpListBox.TabIndex = 5;
            // 
            // teamOneName
            // 
            teamOneName.AutoSize = true;
            teamOneName.Font = new Font("Segoe UI Light", 15.75F);
            teamOneName.ForeColor = Color.Turquoise;
            teamOneName.Location = new Point(313, 164);
            teamOneName.Name = "teamOneName";
            teamOneName.Size = new Size(131, 30);
            teamOneName.TabIndex = 6;
            teamOneName.Text = "<Team One>";
            // 
            // scoreTeamOneLabel
            // 
            scoreTeamOneLabel.AutoSize = true;
            scoreTeamOneLabel.Font = new Font("Segoe UI Light", 15.75F);
            scoreTeamOneLabel.ForeColor = Color.Turquoise;
            scoreTeamOneLabel.Location = new Point(313, 201);
            scoreTeamOneLabel.Name = "scoreTeamOneLabel";
            scoreTeamOneLabel.Size = new Size(62, 30);
            scoreTeamOneLabel.TabIndex = 7;
            scoreTeamOneLabel.Text = "Score";
            scoreTeamOneLabel.Click += label1_Click_1;
            // 
            // scoreTeamOneTextBox
            // 
            scoreTeamOneTextBox.Location = new Point(381, 208);
            scoreTeamOneTextBox.Name = "scoreTeamOneTextBox";
            scoreTeamOneTextBox.Size = new Size(72, 23);
            scoreTeamOneTextBox.TabIndex = 8;
            scoreTeamOneTextBox.TextChanged += scoreTeamOneTextBox_TextChanged;
            // 
            // scoreTeamTwoTextBox
            // 
            scoreTeamTwoTextBox.Location = new Point(381, 324);
            scoreTeamTwoTextBox.Name = "scoreTeamTwoTextBox";
            scoreTeamTwoTextBox.Size = new Size(72, 23);
            scoreTeamTwoTextBox.TabIndex = 11;
            // 
            // scoreTeamTwoLabel
            // 
            scoreTeamTwoLabel.AutoSize = true;
            scoreTeamTwoLabel.Font = new Font("Segoe UI Light", 15.75F);
            scoreTeamTwoLabel.ForeColor = Color.Turquoise;
            scoreTeamTwoLabel.Location = new Point(313, 315);
            scoreTeamTwoLabel.Name = "scoreTeamTwoLabel";
            scoreTeamTwoLabel.Size = new Size(62, 30);
            scoreTeamTwoLabel.TabIndex = 10;
            scoreTeamTwoLabel.Text = "Score";
            // 
            // teamTwoNameLabel
            // 
            teamTwoNameLabel.AutoSize = true;
            teamTwoNameLabel.Font = new Font("Segoe UI Light", 15.75F);
            teamTwoNameLabel.ForeColor = Color.Turquoise;
            teamTwoNameLabel.Location = new Point(313, 278);
            teamTwoNameLabel.Name = "teamTwoNameLabel";
            teamTwoNameLabel.Size = new Size(128, 30);
            teamTwoNameLabel.TabIndex = 9;
            teamTwoNameLabel.Text = "<Team Two>";
            // 
            // versusLabel
            // 
            versusLabel.AutoSize = true;
            versusLabel.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            versusLabel.ForeColor = Color.Turquoise;
            versusLabel.Location = new Point(367, 248);
            versusLabel.Name = "versusLabel";
            versusLabel.Size = new Size(55, 30);
            versusLabel.TabIndex = 12;
            versusLabel.Text = "-VS-";
            // 
            // scoreButton
            // 
            scoreButton.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            scoreButton.AutoSize = true;
            scoreButton.FlatAppearance.BorderColor = Color.FromArgb(224, 224, 224);
            scoreButton.FlatAppearance.BorderSize = 2;
            scoreButton.FlatAppearance.MouseDownBackColor = Color.FromArgb(102, 102, 102);
            scoreButton.FlatAppearance.MouseOverBackColor = Color.FromArgb(242, 242, 242);
            scoreButton.FlatStyle = FlatStyle.Flat;
            scoreButton.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            scoreButton.ForeColor = Color.Turquoise;
            scoreButton.Location = new Point(479, 234);
            scoreButton.Name = "scoreButton";
            scoreButton.Size = new Size(93, 53);
            scoreButton.TabIndex = 13;
            scoreButton.Text = "Score";
            scoreButton.UseVisualStyleBackColor = true;
            // 
            // tournamentViewerForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(620, 382);
            Controls.Add(scoreButton);
            Controls.Add(versusLabel);
            Controls.Add(scoreTeamTwoTextBox);
            Controls.Add(scoreTeamTwoLabel);
            Controls.Add(teamTwoNameLabel);
            Controls.Add(scoreTeamOneTextBox);
            Controls.Add(scoreTeamOneLabel);
            Controls.Add(teamOneName);
            Controls.Add(matchUpListBox);
            Controls.Add(unplayedOnlyCheckBox);
            Controls.Add(roundDropDown);
            Controls.Add(roundLabel);
            Controls.Add(tournamentLabelName);
            Controls.Add(tournamentLabel);
            Name = "tournamentViewerForm";
            Text = "Tournament Viewer";
            Load += TournamentViewerForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label tournamentLabel;
        private Label tournamentLabelName;
        private Label roundLabel;
        private ComboBox roundDropDown;
        private CheckBox unplayedOnlyCheckBox;
        private ListBox matchUpListBox;
        private Label teamOneName;
        private Label scoreTeamOneLabel;
        private TextBox scoreTeamOneTextBox;
        private TextBox scoreTeamTwoTextBox;
        private Label scoreTeamTwoLabel;
        private Label teamTwoNameLabel;
        private Label versusLabel;
        private Button scoreButton;
    }
}