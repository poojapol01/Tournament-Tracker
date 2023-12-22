namespace TrackerUI
{
    partial class createTournamentForm
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
            createTournamentLabel = new Label();
            tournamentNameTextBox = new TextBox();
            tournamentNameLabel = new Label();
            entryFeeTextBox = new TextBox();
            entryFeeLabel = new Label();
            selectTeamTextBox = new TextBox();
            selectTeamLabel = new Label();
            createNewLinkLabel = new LinkLabel();
            addTeamButton = new Button();
            createPrizeButton = new Button();
            teamsPlayersLabel = new Label();
            tournamentPlayersListBox = new ListBox();
            deleteSelectedButton1 = new Button();
            prizeListBox = new ListBox();
            label1 = new Label();
            createTournamentButton = new Button();
            deleteSelectedButton2 = new Button();
            SuspendLayout();
            // 
            // createTournamentLabel
            // 
            createTournamentLabel.AutoSize = true;
            createTournamentLabel.Font = new Font("Segoe UI", 21.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            createTournamentLabel.ForeColor = Color.Turquoise;
            createTournamentLabel.Location = new Point(25, 24);
            createTournamentLabel.Name = "createTournamentLabel";
            createTournamentLabel.Size = new Size(260, 40);
            createTournamentLabel.TabIndex = 1;
            createTournamentLabel.Text = "Create Tournament";
            // 
            // tournamentNameTextBox
            // 
            tournamentNameTextBox.Location = new Point(37, 121);
            tournamentNameTextBox.Name = "tournamentNameTextBox";
            tournamentNameTextBox.Size = new Size(213, 23);
            tournamentNameTextBox.TabIndex = 10;
            // 
            // tournamentNameLabel
            // 
            tournamentNameLabel.AutoSize = true;
            tournamentNameLabel.Font = new Font("Segoe UI Light", 15.75F);
            tournamentNameLabel.ForeColor = Color.Turquoise;
            tournamentNameLabel.Location = new Point(25, 81);
            tournamentNameLabel.Name = "tournamentNameLabel";
            tournamentNameLabel.Size = new Size(176, 30);
            tournamentNameLabel.TabIndex = 9;
            tournamentNameLabel.Text = "Tournament Name";
            // 
            // entryFeeTextBox
            // 
            entryFeeTextBox.Location = new Point(128, 170);
            entryFeeTextBox.Name = "entryFeeTextBox";
            entryFeeTextBox.Size = new Size(122, 23);
            entryFeeTextBox.TabIndex = 14;
            entryFeeTextBox.TextChanged += entryFeeTextBox_TextChanged;
            // 
            // entryFeeLabel
            // 
            entryFeeLabel.AutoSize = true;
            entryFeeLabel.Font = new Font("Segoe UI Light", 15.75F);
            entryFeeLabel.ForeColor = Color.Turquoise;
            entryFeeLabel.Location = new Point(25, 161);
            entryFeeLabel.Name = "entryFeeLabel";
            entryFeeLabel.Size = new Size(97, 30);
            entryFeeLabel.TabIndex = 13;
            entryFeeLabel.Text = "Entry Fee";
            // 
            // selectTeamTextBox
            // 
            selectTeamTextBox.Location = new Point(37, 251);
            selectTeamTextBox.Name = "selectTeamTextBox";
            selectTeamTextBox.Size = new Size(213, 23);
            selectTeamTextBox.TabIndex = 16;
            // 
            // selectTeamLabel
            // 
            selectTeamLabel.AutoSize = true;
            selectTeamLabel.Font = new Font("Segoe UI Light", 15.75F);
            selectTeamLabel.ForeColor = Color.Turquoise;
            selectTeamLabel.Location = new Point(25, 211);
            selectTeamLabel.Name = "selectTeamLabel";
            selectTeamLabel.Size = new Size(116, 30);
            selectTeamLabel.TabIndex = 15;
            selectTeamLabel.Text = "Select Team";
            // 
            // createNewLinkLabel
            // 
            createNewLinkLabel.AutoSize = true;
            createNewLinkLabel.Location = new Point(182, 229);
            createNewLinkLabel.Name = "createNewLinkLabel";
            createNewLinkLabel.Size = new Size(68, 15);
            createNewLinkLabel.TabIndex = 17;
            createNewLinkLabel.TabStop = true;
            createNewLinkLabel.Text = "Create New";
            // 
            // addTeamButton
            // 
            addTeamButton.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            addTeamButton.FlatAppearance.BorderColor = Color.FromArgb(224, 224, 224);
            addTeamButton.FlatAppearance.BorderSize = 2;
            addTeamButton.FlatAppearance.MouseDownBackColor = Color.FromArgb(102, 102, 102);
            addTeamButton.FlatAppearance.MouseOverBackColor = Color.FromArgb(242, 242, 242);
            addTeamButton.FlatStyle = FlatStyle.Flat;
            addTeamButton.Font = new Font("Segoe UI Light", 14.25F);
            addTeamButton.ForeColor = Color.Turquoise;
            addTeamButton.Location = new Point(77, 294);
            addTeamButton.Name = "addTeamButton";
            addTeamButton.Size = new Size(144, 35);
            addTeamButton.TabIndex = 18;
            addTeamButton.Text = "Add Team";
            addTeamButton.UseVisualStyleBackColor = true;
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
            createPrizeButton.Location = new Point(77, 343);
            createPrizeButton.Name = "createPrizeButton";
            createPrizeButton.Size = new Size(144, 35);
            createPrizeButton.TabIndex = 19;
            createPrizeButton.Text = "Create Prize";
            createPrizeButton.UseVisualStyleBackColor = true;
            // 
            // teamsPlayersLabel
            // 
            teamsPlayersLabel.AutoSize = true;
            teamsPlayersLabel.Font = new Font("Segoe UI Light", 15.75F);
            teamsPlayersLabel.ForeColor = Color.Turquoise;
            teamsPlayersLabel.Location = new Point(291, 82);
            teamsPlayersLabel.Name = "teamsPlayersLabel";
            teamsPlayersLabel.Size = new Size(148, 30);
            teamsPlayersLabel.TabIndex = 20;
            teamsPlayersLabel.Text = "Teams / Players";
            // 
            // tournamentPlayersListBox
            // 
            tournamentPlayersListBox.FormattingEnabled = true;
            tournamentPlayersListBox.ItemHeight = 15;
            tournamentPlayersListBox.Location = new Point(305, 122);
            tournamentPlayersListBox.Name = "tournamentPlayersListBox";
            tournamentPlayersListBox.Size = new Size(184, 94);
            tournamentPlayersListBox.TabIndex = 21;
            // 
            // deleteSelectedButton1
            // 
            deleteSelectedButton1.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            deleteSelectedButton1.FlatAppearance.BorderColor = Color.FromArgb(224, 224, 224);
            deleteSelectedButton1.FlatAppearance.BorderSize = 2;
            deleteSelectedButton1.FlatAppearance.MouseDownBackColor = Color.FromArgb(102, 102, 102);
            deleteSelectedButton1.FlatAppearance.MouseOverBackColor = Color.FromArgb(242, 242, 242);
            deleteSelectedButton1.FlatStyle = FlatStyle.Flat;
            deleteSelectedButton1.Font = new Font("Segoe UI Light", 12F);
            deleteSelectedButton1.ForeColor = Color.Turquoise;
            deleteSelectedButton1.Location = new Point(506, 130);
            deleteSelectedButton1.Name = "deleteSelectedButton1";
            deleteSelectedButton1.Size = new Size(94, 77);
            deleteSelectedButton1.TabIndex = 22;
            deleteSelectedButton1.Text = "Delete Selected";
            deleteSelectedButton1.UseVisualStyleBackColor = true;
            // 
            // prizeListBox
            // 
            prizeListBox.FormattingEnabled = true;
            prizeListBox.ItemHeight = 15;
            prizeListBox.Location = new Point(305, 284);
            prizeListBox.Name = "prizeListBox";
            prizeListBox.Size = new Size(184, 94);
            prizeListBox.TabIndex = 24;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Light", 15.75F);
            label1.ForeColor = Color.Turquoise;
            label1.Location = new Point(291, 244);
            label1.Name = "label1";
            label1.Size = new Size(148, 30);
            label1.TabIndex = 23;
            label1.Text = "Teams / Players";
            // 
            // createTournamentButton
            // 
            createTournamentButton.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            createTournamentButton.FlatAppearance.BorderColor = Color.FromArgb(224, 224, 224);
            createTournamentButton.FlatAppearance.BorderSize = 2;
            createTournamentButton.FlatAppearance.MouseDownBackColor = Color.FromArgb(102, 102, 102);
            createTournamentButton.FlatAppearance.MouseOverBackColor = Color.FromArgb(242, 242, 242);
            createTournamentButton.FlatStyle = FlatStyle.Flat;
            createTournamentButton.Font = new Font("Segoe UI Light", 14.25F);
            createTournamentButton.ForeColor = Color.Turquoise;
            createTournamentButton.Location = new Point(223, 398);
            createTournamentButton.Name = "createTournamentButton";
            createTournamentButton.Size = new Size(195, 35);
            createTournamentButton.TabIndex = 26;
            createTournamentButton.Text = "Create Tournament";
            createTournamentButton.UseVisualStyleBackColor = true;
            // 
            // deleteSelectedButton2
            // 
            deleteSelectedButton2.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            deleteSelectedButton2.FlatAppearance.BorderColor = Color.FromArgb(224, 224, 224);
            deleteSelectedButton2.FlatAppearance.BorderSize = 2;
            deleteSelectedButton2.FlatAppearance.MouseDownBackColor = Color.FromArgb(102, 102, 102);
            deleteSelectedButton2.FlatAppearance.MouseOverBackColor = Color.FromArgb(242, 242, 242);
            deleteSelectedButton2.FlatStyle = FlatStyle.Flat;
            deleteSelectedButton2.Font = new Font("Segoe UI Light", 12F);
            deleteSelectedButton2.ForeColor = Color.Turquoise;
            deleteSelectedButton2.Location = new Point(506, 294);
            deleteSelectedButton2.Name = "deleteSelectedButton2";
            deleteSelectedButton2.Size = new Size(94, 77);
            deleteSelectedButton2.TabIndex = 27;
            deleteSelectedButton2.Text = "Delete Selected";
            deleteSelectedButton2.UseVisualStyleBackColor = true;
            // 
            // createTournamentForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(628, 467);
            Controls.Add(deleteSelectedButton2);
            Controls.Add(createTournamentButton);
            Controls.Add(prizeListBox);
            Controls.Add(label1);
            Controls.Add(deleteSelectedButton1);
            Controls.Add(tournamentPlayersListBox);
            Controls.Add(teamsPlayersLabel);
            Controls.Add(createPrizeButton);
            Controls.Add(addTeamButton);
            Controls.Add(createNewLinkLabel);
            Controls.Add(selectTeamTextBox);
            Controls.Add(selectTeamLabel);
            Controls.Add(entryFeeTextBox);
            Controls.Add(entryFeeLabel);
            Controls.Add(tournamentNameTextBox);
            Controls.Add(tournamentNameLabel);
            Controls.Add(createTournamentLabel);
            Name = "createTournamentForm";
            Text = "Create Tournament Form";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label createTournamentLabel;
        private TextBox tournamentNameTextBox;
        private Label tournamentNameLabel;
        private TextBox entryFeeTextBox;
        private Label entryFeeLabel;
        private TextBox selectTeamTextBox;
        private Label selectTeamLabel;
        private LinkLabel createNewLinkLabel;
        private Button addTeamButton;
        private Button createPrizeButton;
        private Label teamsPlayersLabel;
        private ListBox tournamentPlayersListBox;
        private Button deleteSelectedButton1;
        private ListBox prizeListBox;
        private Label label1;
        private Button createTournamentButton;
        private Button deleteSelectedButton2;
    }
}