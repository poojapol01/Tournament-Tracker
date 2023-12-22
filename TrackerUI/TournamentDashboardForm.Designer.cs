namespace TrackerUI
{
    partial class tournamentDashboardForm
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
            tournamentDashboardLabel = new Label();
            loadExistingTournamentDropDown = new ComboBox();
            loadExistingTournamentLabel = new Label();
            loadTournamentButton = new Button();
            createTournamentButton = new Button();
            SuspendLayout();
            // 
            // tournamentDashboardLabel
            // 
            tournamentDashboardLabel.AutoSize = true;
            tournamentDashboardLabel.BackColor = Color.White;
            tournamentDashboardLabel.Font = new Font("Segoe UI", 21.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tournamentDashboardLabel.ForeColor = Color.Turquoise;
            tournamentDashboardLabel.Location = new Point(121, 29);
            tournamentDashboardLabel.Name = "tournamentDashboardLabel";
            tournamentDashboardLabel.Size = new Size(316, 40);
            tournamentDashboardLabel.TabIndex = 14;
            tournamentDashboardLabel.Text = "Tournament Dashboard";
            // 
            // loadExistingTournamentDropDown
            // 
            loadExistingTournamentDropDown.FormattingEnabled = true;
            loadExistingTournamentDropDown.Location = new Point(176, 137);
            loadExistingTournamentDropDown.Name = "loadExistingTournamentDropDown";
            loadExistingTournamentDropDown.Size = new Size(214, 23);
            loadExistingTournamentDropDown.TabIndex = 22;
            // 
            // loadExistingTournamentLabel
            // 
            loadExistingTournamentLabel.AutoSize = true;
            loadExistingTournamentLabel.Font = new Font("Segoe UI Light", 15.75F);
            loadExistingTournamentLabel.ForeColor = Color.Turquoise;
            loadExistingTournamentLabel.Location = new Point(165, 95);
            loadExistingTournamentLabel.Name = "loadExistingTournamentLabel";
            loadExistingTournamentLabel.Size = new Size(238, 30);
            loadExistingTournamentLabel.TabIndex = 21;
            loadExistingTournamentLabel.Text = "Load Existing Tournament";
            // 
            // loadTournamentButton
            // 
            loadTournamentButton.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            loadTournamentButton.FlatAppearance.BorderColor = Color.FromArgb(224, 224, 224);
            loadTournamentButton.FlatAppearance.BorderSize = 2;
            loadTournamentButton.FlatAppearance.MouseDownBackColor = Color.FromArgb(102, 102, 102);
            loadTournamentButton.FlatAppearance.MouseOverBackColor = Color.FromArgb(242, 242, 242);
            loadTournamentButton.FlatStyle = FlatStyle.Flat;
            loadTournamentButton.Font = new Font("Segoe UI Light", 14.25F);
            loadTournamentButton.ForeColor = Color.Turquoise;
            loadTournamentButton.Location = new Point(176, 184);
            loadTournamentButton.Name = "loadTournamentButton";
            loadTournamentButton.Size = new Size(217, 35);
            loadTournamentButton.TabIndex = 24;
            loadTournamentButton.Text = "Load Tournament";
            loadTournamentButton.UseVisualStyleBackColor = true;
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
            createTournamentButton.Location = new Point(176, 246);
            createTournamentButton.Name = "createTournamentButton";
            createTournamentButton.Size = new Size(217, 35);
            createTournamentButton.TabIndex = 25;
            createTournamentButton.Text = "Create Tournament";
            createTournamentButton.UseVisualStyleBackColor = true;
            // 
            // tournamentDashboardForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(563, 354);
            Controls.Add(createTournamentButton);
            Controls.Add(loadTournamentButton);
            Controls.Add(loadExistingTournamentDropDown);
            Controls.Add(loadExistingTournamentLabel);
            Controls.Add(tournamentDashboardLabel);
            Name = "tournamentDashboardForm";
            Text = "Tournament Dashboard Form";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label tournamentDashboardLabel;
        private ComboBox loadExistingTournamentDropDown;
        private Label loadExistingTournamentLabel;
        private Button loadTournamentButton;
        private Button createTournamentButton;
    }
}