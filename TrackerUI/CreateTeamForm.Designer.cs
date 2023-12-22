namespace TrackerUI
{
    partial class createTeamForm
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
            teamNameTextBox = new TextBox();
            teamNameLabel = new Label();
            createTeamLabel = new Label();
            selectTeamMemberLabel = new Label();
            addMemberButton = new Button();
            selectTeamMemberDropDown = new ComboBox();
            addNewMemberGroupBox = new GroupBox();
            createMemberButton = new Button();
            cellPhoneTextBox = new TextBox();
            celPhoneLabel = new Label();
            emailTextBox = new TextBox();
            emailLabel = new Label();
            lastNameTextBox = new TextBox();
            lastNameLabel = new Label();
            firstNameTextBox = new TextBox();
            firstNameLabel = new Label();
            addMemberBtn = new Button();
            createTeamButton = new Button();
            teamMembersListBox = new ListBox();
            deleteSelectedButton1 = new Button();
            addNewMemberGroupBox.SuspendLayout();
            SuspendLayout();
            // 
            // teamNameTextBox
            // 
            teamNameTextBox.Location = new Point(41, 98);
            teamNameTextBox.Name = "teamNameTextBox";
            teamNameTextBox.Size = new Size(213, 23);
            teamNameTextBox.TabIndex = 12;
            // 
            // teamNameLabel
            // 
            teamNameLabel.AutoSize = true;
            teamNameLabel.Font = new Font("Segoe UI Light", 15.75F);
            teamNameLabel.ForeColor = Color.Turquoise;
            teamNameLabel.Location = new Point(29, 58);
            teamNameLabel.Name = "teamNameLabel";
            teamNameLabel.Size = new Size(118, 30);
            teamNameLabel.TabIndex = 11;
            teamNameLabel.Text = "Team Name";
            // 
            // createTeamLabel
            // 
            createTeamLabel.AutoSize = true;
            createTeamLabel.Font = new Font("Segoe UI", 21.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            createTeamLabel.ForeColor = Color.Turquoise;
            createTeamLabel.Location = new Point(29, 9);
            createTeamLabel.Name = "createTeamLabel";
            createTeamLabel.Size = new Size(175, 40);
            createTeamLabel.TabIndex = 13;
            createTeamLabel.Text = "Create Team";
            createTeamLabel.Click += createTournamentLabel_Click;
            // 
            // selectTeamMemberLabel
            // 
            selectTeamMemberLabel.AutoSize = true;
            selectTeamMemberLabel.Font = new Font("Segoe UI Light", 15.75F);
            selectTeamMemberLabel.ForeColor = Color.Turquoise;
            selectTeamMemberLabel.Location = new Point(29, 133);
            selectTeamMemberLabel.Name = "selectTeamMemberLabel";
            selectTeamMemberLabel.Size = new Size(197, 30);
            selectTeamMemberLabel.TabIndex = 14;
            selectTeamMemberLabel.Text = "Select Team Member";
            selectTeamMemberLabel.Click += selectTeamMemberLabel_Click;
            // 
            // addMemberButton
            // 
            addMemberButton.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            addMemberButton.FlatAppearance.BorderColor = Color.FromArgb(224, 224, 224);
            addMemberButton.FlatAppearance.BorderSize = 2;
            addMemberButton.FlatAppearance.MouseDownBackColor = Color.FromArgb(102, 102, 102);
            addMemberButton.FlatAppearance.MouseOverBackColor = Color.FromArgb(242, 242, 242);
            addMemberButton.FlatStyle = FlatStyle.Flat;
            addMemberButton.Font = new Font("Segoe UI Light", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            addMemberButton.ForeColor = Color.Turquoise;
            addMemberButton.Location = new Point(78, 304);
            addMemberButton.Name = "addMemberButton";
            addMemberButton.Size = new Size(0, 10);
            addMemberButton.TabIndex = 19;
            addMemberButton.Text = "Add Member";
            addMemberButton.UseVisualStyleBackColor = true;
            // 
            // selectTeamMemberDropDown
            // 
            selectTeamMemberDropDown.FormattingEnabled = true;
            selectTeamMemberDropDown.Location = new Point(40, 175);
            selectTeamMemberDropDown.Name = "selectTeamMemberDropDown";
            selectTeamMemberDropDown.Size = new Size(214, 23);
            selectTeamMemberDropDown.TabIndex = 20;
            // 
            // addNewMemberGroupBox
            // 
            addNewMemberGroupBox.Controls.Add(createMemberButton);
            addNewMemberGroupBox.Controls.Add(cellPhoneTextBox);
            addNewMemberGroupBox.Controls.Add(celPhoneLabel);
            addNewMemberGroupBox.Controls.Add(emailTextBox);
            addNewMemberGroupBox.Controls.Add(emailLabel);
            addNewMemberGroupBox.Controls.Add(lastNameTextBox);
            addNewMemberGroupBox.Controls.Add(lastNameLabel);
            addNewMemberGroupBox.Controls.Add(firstNameTextBox);
            addNewMemberGroupBox.Controls.Add(firstNameLabel);
            addNewMemberGroupBox.Location = new Point(41, 258);
            addNewMemberGroupBox.Name = "addNewMemberGroupBox";
            addNewMemberGroupBox.Size = new Size(213, 218);
            addNewMemberGroupBox.TabIndex = 21;
            addNewMemberGroupBox.TabStop = false;
            addNewMemberGroupBox.Text = "Add New Member";
            // 
            // createMemberButton
            // 
            createMemberButton.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            createMemberButton.FlatAppearance.BorderColor = Color.FromArgb(224, 224, 224);
            createMemberButton.FlatAppearance.BorderSize = 2;
            createMemberButton.FlatAppearance.MouseDownBackColor = Color.FromArgb(102, 102, 102);
            createMemberButton.FlatAppearance.MouseOverBackColor = Color.FromArgb(242, 242, 242);
            createMemberButton.FlatStyle = FlatStyle.Flat;
            createMemberButton.Font = new Font("Segoe UI Light", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            createMemberButton.ForeColor = Color.Turquoise;
            createMemberButton.Location = new Point(37, 172);
            createMemberButton.Name = "createMemberButton";
            createMemberButton.Size = new Size(144, 35);
            createMemberButton.TabIndex = 23;
            createMemberButton.Text = "Create Member";
            createMemberButton.UseVisualStyleBackColor = true;
            // 
            // cellPhoneTextBox
            // 
            cellPhoneTextBox.Location = new Point(92, 134);
            cellPhoneTextBox.Name = "cellPhoneTextBox";
            cellPhoneTextBox.Size = new Size(103, 23);
            cellPhoneTextBox.TabIndex = 29;
            // 
            // celPhoneLabel
            // 
            celPhoneLabel.AutoSize = true;
            celPhoneLabel.Font = new Font("Segoe UI Light", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            celPhoneLabel.ForeColor = Color.Turquoise;
            celPhoneLabel.Location = new Point(6, 132);
            celPhoneLabel.Name = "celPhoneLabel";
            celPhoneLabel.Size = new Size(82, 21);
            celPhoneLabel.TabIndex = 28;
            celPhoneLabel.Text = "Cell Phone";
            // 
            // emailTextBox
            // 
            emailTextBox.Location = new Point(92, 100);
            emailTextBox.Name = "emailTextBox";
            emailTextBox.Size = new Size(103, 23);
            emailTextBox.TabIndex = 27;
            // 
            // emailLabel
            // 
            emailLabel.AutoSize = true;
            emailLabel.Font = new Font("Segoe UI Light", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            emailLabel.ForeColor = Color.Turquoise;
            emailLabel.Location = new Point(6, 98);
            emailLabel.Name = "emailLabel";
            emailLabel.Size = new Size(45, 21);
            emailLabel.TabIndex = 26;
            emailLabel.Text = "Email";
            // 
            // lastNameTextBox
            // 
            lastNameTextBox.Location = new Point(92, 66);
            lastNameTextBox.Name = "lastNameTextBox";
            lastNameTextBox.Size = new Size(103, 23);
            lastNameTextBox.TabIndex = 25;
            // 
            // lastNameLabel
            // 
            lastNameLabel.AutoSize = true;
            lastNameLabel.Font = new Font("Segoe UI Light", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lastNameLabel.ForeColor = Color.Turquoise;
            lastNameLabel.Location = new Point(6, 64);
            lastNameLabel.Name = "lastNameLabel";
            lastNameLabel.Size = new Size(80, 21);
            lastNameLabel.TabIndex = 24;
            lastNameLabel.Text = "Last Name";
            // 
            // firstNameTextBox
            // 
            firstNameTextBox.Location = new Point(92, 31);
            firstNameTextBox.Name = "firstNameTextBox";
            firstNameTextBox.Size = new Size(103, 23);
            firstNameTextBox.TabIndex = 23;
            // 
            // firstNameLabel
            // 
            firstNameLabel.AutoSize = true;
            firstNameLabel.Font = new Font("Segoe UI Light", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            firstNameLabel.ForeColor = Color.Turquoise;
            firstNameLabel.Location = new Point(6, 29);
            firstNameLabel.Name = "firstNameLabel";
            firstNameLabel.Size = new Size(80, 21);
            firstNameLabel.TabIndex = 22;
            firstNameLabel.Text = "First Name";
            // 
            // addMemberBtn
            // 
            addMemberBtn.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            addMemberBtn.FlatAppearance.BorderColor = Color.FromArgb(224, 224, 224);
            addMemberBtn.FlatAppearance.BorderSize = 2;
            addMemberBtn.FlatAppearance.MouseDownBackColor = Color.FromArgb(102, 102, 102);
            addMemberBtn.FlatAppearance.MouseOverBackColor = Color.FromArgb(242, 242, 242);
            addMemberBtn.FlatStyle = FlatStyle.Flat;
            addMemberBtn.Font = new Font("Segoe UI Light", 14.25F);
            addMemberBtn.ForeColor = Color.Turquoise;
            addMemberBtn.Location = new Point(78, 204);
            addMemberBtn.Name = "addMemberBtn";
            addMemberBtn.Size = new Size(144, 35);
            addMemberBtn.TabIndex = 22;
            addMemberBtn.Text = "Add Member";
            addMemberBtn.UseVisualStyleBackColor = true;
            addMemberBtn.Click += addTeamButton_Click;
            // 
            // createTeamButton
            // 
            createTeamButton.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            createTeamButton.FlatAppearance.BorderColor = Color.FromArgb(224, 224, 224);
            createTeamButton.FlatAppearance.BorderSize = 2;
            createTeamButton.FlatAppearance.MouseDownBackColor = Color.FromArgb(102, 102, 102);
            createTeamButton.FlatAppearance.MouseOverBackColor = Color.FromArgb(242, 242, 242);
            createTeamButton.FlatStyle = FlatStyle.Flat;
            createTeamButton.Font = new Font("Segoe UI Light", 14.25F);
            createTeamButton.ForeColor = Color.Turquoise;
            createTeamButton.Location = new Point(333, 441);
            createTeamButton.Name = "createTeamButton";
            createTeamButton.Size = new Size(217, 35);
            createTeamButton.TabIndex = 23;
            createTeamButton.Text = "Create Team";
            createTeamButton.UseVisualStyleBackColor = true;
            createTeamButton.Click += createTeamButton_Click;
            // 
            // teamMembersListBox
            // 
            teamMembersListBox.FormattingEnabled = true;
            teamMembersListBox.ItemHeight = 15;
            teamMembersListBox.Location = new Point(304, 102);
            teamMembersListBox.Name = "teamMembersListBox";
            teamMembersListBox.Size = new Size(190, 289);
            teamMembersListBox.TabIndex = 24;
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
            deleteSelectedButton1.Location = new Point(510, 217);
            deleteSelectedButton1.Name = "deleteSelectedButton1";
            deleteSelectedButton1.Size = new Size(94, 77);
            deleteSelectedButton1.TabIndex = 25;
            deleteSelectedButton1.Text = "Delete Selected";
            deleteSelectedButton1.UseVisualStyleBackColor = true;
            // 
            // createTeamForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(616, 510);
            Controls.Add(deleteSelectedButton1);
            Controls.Add(teamMembersListBox);
            Controls.Add(createTeamButton);
            Controls.Add(addMemberBtn);
            Controls.Add(addNewMemberGroupBox);
            Controls.Add(selectTeamMemberDropDown);
            Controls.Add(addMemberButton);
            Controls.Add(selectTeamMemberLabel);
            Controls.Add(createTeamLabel);
            Controls.Add(teamNameTextBox);
            Controls.Add(teamNameLabel);
            Name = "createTeamForm";
            Text = "Create Team";
            Load += CreateTeamForm_Load;
            addNewMemberGroupBox.ResumeLayout(false);
            addNewMemberGroupBox.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox teamNameTextBox;
        private Label teamNameLabel;
        private Label createTeamLabel;
        private Label selectTeamMemberLabel;
        private Button addMemberButton;
        private ComboBox selectTeamMemberDropDown;
        private GroupBox addNewMemberGroupBox;
        private TextBox firstNameTextBox;
        private Label firstNameLabel;
        private TextBox emailTextBox;
        private Label emailLabel;
        private TextBox lastNameTextBox;
        private Label lastNameLabel;
        private TextBox cellPhoneTextBox;
        private Label celPhoneLabel;
        private Button addMemberBtn;
        private Button createMemberButton;
        private Button createTeamButton;
        private ListBox teamMembersListBox;
        private Button deleteSelectedButton1;
    }
}