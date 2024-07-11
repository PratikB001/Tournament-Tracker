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
            tournamentNameLabel = new Label();
            tournamentNameValue = new TextBox();
            entryFeeLabel = new Label();
            entryFeeValue = new TextBox();
            selectTeamLabel = new Label();
            selectTeamDropDown = new ComboBox();
            addTeamButton = new Button();
            createPrizeButton = new Button();
            teamPlayersLabel = new Label();
            tournamentPlayersListBox = new ListBox();
            prizesListBox = new ListBox();
            prizesLabel = new Label();
            createTournamentButton = new Button();
            deleteSelectedButton = new Button();
            deleteSelectedButton2 = new Button();
            createNewLinklabel = new LinkLabel();
            SuspendLayout();
            // 
            // createTournamentLabel
            // 
            createTournamentLabel.AutoSize = true;
            createTournamentLabel.ForeColor = Color.DodgerBlue;
            createTournamentLabel.Location = new Point(36, 29);
            createTournamentLabel.Name = "createTournamentLabel";
            createTournamentLabel.Size = new Size(253, 38);
            createTournamentLabel.TabIndex = 0;
            createTournamentLabel.Text = "Create Tournament";
            // 
            // tournamentNameLabel
            // 
            tournamentNameLabel.AutoSize = true;
            tournamentNameLabel.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            tournamentNameLabel.Location = new Point(36, 120);
            tournamentNameLabel.Name = "tournamentNameLabel";
            tournamentNameLabel.Size = new Size(182, 28);
            tournamentNameLabel.TabIndex = 1;
            tournamentNameLabel.Text = "Tournament Name";
            // 
            // tournamentNameValue
            // 
            tournamentNameValue.Location = new Point(36, 151);
            tournamentNameValue.Name = "tournamentNameValue";
            tournamentNameValue.Size = new Size(308, 43);
            tournamentNameValue.TabIndex = 2;
            // 
            // entryFeeLabel
            // 
            entryFeeLabel.AutoSize = true;
            entryFeeLabel.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            entryFeeLabel.Location = new Point(36, 223);
            entryFeeLabel.Name = "entryFeeLabel";
            entryFeeLabel.Size = new Size(97, 28);
            entryFeeLabel.TabIndex = 3;
            entryFeeLabel.Text = "Entry Fee";
            // 
            // entryFeeValue
            // 
            entryFeeValue.Location = new Point(156, 213);
            entryFeeValue.Name = "entryFeeValue";
            entryFeeValue.PlaceholderText = "0";
            entryFeeValue.Size = new Size(188, 43);
            entryFeeValue.TabIndex = 4;
            // 
            // selectTeamLabel
            // 
            selectTeamLabel.AutoSize = true;
            selectTeamLabel.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            selectTeamLabel.Location = new Point(36, 292);
            selectTeamLabel.Name = "selectTeamLabel";
            selectTeamLabel.Size = new Size(120, 28);
            selectTeamLabel.TabIndex = 5;
            selectTeamLabel.Text = "Select Team";
            selectTeamLabel.Click += label1_Click;
            // 
            // selectTeamDropDown
            // 
            selectTeamDropDown.FormattingEnabled = true;
            selectTeamDropDown.Location = new Point(36, 336);
            selectTeamDropDown.Name = "selectTeamDropDown";
            selectTeamDropDown.Size = new Size(308, 45);
            selectTeamDropDown.TabIndex = 6;
            // 
            // addTeamButton
            // 
            addTeamButton.Location = new Point(80, 397);
            addTeamButton.Name = "addTeamButton";
            addTeamButton.Size = new Size(209, 49);
            addTeamButton.TabIndex = 7;
            addTeamButton.Text = "Add Team";
            addTeamButton.UseVisualStyleBackColor = true;
            addTeamButton.Click += button1_Click;
            // 
            // createPrizeButton
            // 
            createPrizeButton.Location = new Point(80, 480);
            createPrizeButton.Name = "createPrizeButton";
            createPrizeButton.Size = new Size(209, 49);
            createPrizeButton.TabIndex = 8;
            createPrizeButton.Text = "Create Prize";
            createPrizeButton.UseVisualStyleBackColor = true;
            // 
            // teamPlayersLabel
            // 
            teamPlayersLabel.AutoSize = true;
            teamPlayersLabel.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            teamPlayersLabel.Location = new Point(419, 120);
            teamPlayersLabel.Name = "teamPlayersLabel";
            teamPlayersLabel.Size = new Size(144, 28);
            teamPlayersLabel.TabIndex = 9;
            teamPlayersLabel.Text = "Team / Players";
            // 
            // tournamentPlayersListBox
            // 
            tournamentPlayersListBox.FormattingEnabled = true;
            tournamentPlayersListBox.ItemHeight = 37;
            tournamentPlayersListBox.Location = new Point(419, 151);
            tournamentPlayersListBox.Name = "tournamentPlayersListBox";
            tournamentPlayersListBox.Size = new Size(316, 189);
            tournamentPlayersListBox.TabIndex = 10;
            // 
            // prizesListBox
            // 
            prizesListBox.FormattingEnabled = true;
            prizesListBox.ItemHeight = 37;
            prizesListBox.Location = new Point(419, 400);
            prizesListBox.Name = "prizesListBox";
            prizesListBox.Size = new Size(316, 189);
            prizesListBox.TabIndex = 12;
            // 
            // prizesLabel
            // 
            prizesLabel.AutoSize = true;
            prizesLabel.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            prizesLabel.Location = new Point(419, 369);
            prizesLabel.Name = "prizesLabel";
            prizesLabel.Size = new Size(65, 28);
            prizesLabel.TabIndex = 11;
            prizesLabel.Text = "Prizes";
            // 
            // createTournamentButton
            // 
            createTournamentButton.Location = new Point(284, 619);
            createTournamentButton.Name = "createTournamentButton";
            createTournamentButton.Size = new Size(346, 49);
            createTournamentButton.TabIndex = 13;
            createTournamentButton.Text = "Create Tournament";
            createTournamentButton.UseVisualStyleBackColor = true;
            // 
            // deleteSelectedButton
            // 
            deleteSelectedButton.Location = new Point(757, 151);
            deleteSelectedButton.Name = "deleteSelectedButton";
            deleteSelectedButton.Size = new Size(154, 96);
            deleteSelectedButton.TabIndex = 14;
            deleteSelectedButton.Text = "Delete Selected";
            deleteSelectedButton.UseVisualStyleBackColor = true;
            // 
            // deleteSelectedButton2
            // 
            deleteSelectedButton2.Location = new Point(757, 400);
            deleteSelectedButton2.Name = "deleteSelectedButton2";
            deleteSelectedButton2.Size = new Size(154, 96);
            deleteSelectedButton2.TabIndex = 15;
            deleteSelectedButton2.Text = "Delete Selected";
            deleteSelectedButton2.UseVisualStyleBackColor = true;
            // 
            // createNewLinklabel
            // 
            createNewLinklabel.AutoSize = true;
            createNewLinklabel.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            createNewLinklabel.Location = new Point(236, 295);
            createNewLinklabel.Name = "createNewLinklabel";
            createNewLinklabel.Size = new Size(96, 25);
            createNewLinklabel.TabIndex = 16;
            createNewLinklabel.TabStop = true;
            createNewLinklabel.Text = "create new";
            // 
            // createTournamentForm
            // 
            AutoScaleMode = AutoScaleMode.None;
            ClientSize = new Size(933, 681);
            Controls.Add(createNewLinklabel);
            Controls.Add(deleteSelectedButton2);
            Controls.Add(deleteSelectedButton);
            Controls.Add(createTournamentButton);
            Controls.Add(prizesListBox);
            Controls.Add(prizesLabel);
            Controls.Add(tournamentPlayersListBox);
            Controls.Add(teamPlayersLabel);
            Controls.Add(createPrizeButton);
            Controls.Add(addTeamButton);
            Controls.Add(selectTeamDropDown);
            Controls.Add(selectTeamLabel);
            Controls.Add(entryFeeValue);
            Controls.Add(entryFeeLabel);
            Controls.Add(tournamentNameValue);
            Controls.Add(tournamentNameLabel);
            Controls.Add(createTournamentLabel);
            Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Margin = new Padding(6, 6, 6, 6);
            Name = "createTournamentForm";
            Text = "Create Tournament";
            Load += CreateTournamentForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label createTournamentLabel;
        private Label tournamentNameLabel;
        private TextBox tournamentNameValue;
        private Label entryFeeLabel;
        private TextBox entryFeeValue;
        private Label selectTeamLabel;
        private ComboBox selectTeamDropDown;
        private Button addTeamButton;
        private Button createPrizeButton;
        private Label teamPlayersLabel;
        private ListBox tournamentPlayersListBox;
        private ListBox prizesListBox;
        private Label prizesLabel;
        private Button createTournamentButton;
        private Button deleteSelectedButton;
        private Button deleteSelectedButton2;
        private LinkLabel createNewLinklabel;
    }
}