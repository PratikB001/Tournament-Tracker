namespace TrackerUI
{
    partial class TournamentDashboardForm
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
            loadExistingTournamentLabel = new Label();
            loadExistingTournamentDropdown = new ComboBox();
            loadTournamentButton = new Button();
            createTournamentButton = new Button();
            SuspendLayout();
            // 
            // tournamentDashboardLabel
            // 
            tournamentDashboardLabel.AutoSize = true;
            tournamentDashboardLabel.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tournamentDashboardLabel.Location = new Point(102, 21);
            tournamentDashboardLabel.Name = "tournamentDashboardLabel";
            tournamentDashboardLabel.Size = new Size(307, 38);
            tournamentDashboardLabel.TabIndex = 2;
            tournamentDashboardLabel.Text = "Tournament Dashboard";
            // 
            // loadExistingTournamentLabel
            // 
            loadExistingTournamentLabel.AutoSize = true;
            loadExistingTournamentLabel.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            loadExistingTournamentLabel.Location = new Point(131, 77);
            loadExistingTournamentLabel.Name = "loadExistingTournamentLabel";
            loadExistingTournamentLabel.Size = new Size(248, 28);
            loadExistingTournamentLabel.TabIndex = 26;
            loadExistingTournamentLabel.Text = "Load Existing Tournament";
            // 
            // loadExistingTournamentDropdown
            // 
            loadExistingTournamentDropdown.FormattingEnabled = true;
            loadExistingTournamentDropdown.Location = new Point(91, 108);
            loadExistingTournamentDropdown.Name = "loadExistingTournamentDropdown";
            loadExistingTournamentDropdown.Size = new Size(328, 28);
            loadExistingTournamentDropdown.TabIndex = 27;
            // 
            // loadTournamentButton
            // 
            loadTournamentButton.Location = new Point(151, 161);
            loadTournamentButton.Name = "loadTournamentButton";
            loadTournamentButton.Size = new Size(209, 38);
            loadTournamentButton.TabIndex = 37;
            loadTournamentButton.Text = "Load Tournament";
            loadTournamentButton.UseVisualStyleBackColor = true;
            // 
            // createTournamentButton
            // 
            createTournamentButton.Location = new Point(121, 217);
            createTournamentButton.Name = "createTournamentButton";
            createTournamentButton.Size = new Size(268, 62);
            createTournamentButton.TabIndex = 38;
            createTournamentButton.Text = "Create Tournament";
            createTournamentButton.UseVisualStyleBackColor = true;
            // 
            // TournamentDashboardForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(489, 321);
            Controls.Add(createTournamentButton);
            Controls.Add(loadTournamentButton);
            Controls.Add(loadExistingTournamentDropdown);
            Controls.Add(loadExistingTournamentLabel);
            Controls.Add(tournamentDashboardLabel);
            Name = "TournamentDashboardForm";
            Text = "Tournament Dashboard";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label tournamentDashboardLabel;
        private Label loadExistingTournamentLabel;
        private ComboBox loadExistingTournamentDropdown;
        private Button loadTournamentButton;
        private Button createTournamentButton;
    }
}