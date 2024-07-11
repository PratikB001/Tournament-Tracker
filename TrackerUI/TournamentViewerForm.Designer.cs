namespace TrackerUI
{
    partial class tournamentViewerForm
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
            headerLabel = new Label();
            tournamentName = new Label();
            roundLabel = new Label();
            roundDropdown = new ComboBox();
            unplayedOnlyCheckBox = new CheckBox();
            matchupListBox = new ListBox();
            team1Label = new Label();
            score1Label = new Label();
            scorebox1Label = new TextBox();
            team2Label = new Label();
            score2Label = new Label();
            scorebox2Label = new TextBox();
            vsLabel = new Label();
            scoreButton = new Button();
            SuspendLayout();
            // 
            // headerLabel
            // 
            headerLabel.AutoSize = true;
            headerLabel.Font = new Font("Segoe UI Light", 28.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            headerLabel.ForeColor = SystemColors.MenuHighlight;
            headerLabel.Location = new Point(12, 22);
            headerLabel.Name = "headerLabel";
            headerLabel.Size = new Size(271, 62);
            headerLabel.TabIndex = 0;
            headerLabel.Text = "Tournament:";
            headerLabel.Click += label1_Click;
            // 
            // tournamentName
            // 
            tournamentName.AutoSize = true;
            tournamentName.Font = new Font("Segoe UI Light", 28.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tournamentName.ForeColor = SystemColors.MenuHighlight;
            tournamentName.Location = new Point(267, 22);
            tournamentName.Name = "tournamentName";
            tournamentName.Size = new Size(189, 62);
            tournamentName.TabIndex = 1;
            tournamentName.Text = "<none>";
            // 
            // roundLabel
            // 
            roundLabel.AutoSize = true;
            roundLabel.Location = new Point(33, 118);
            roundLabel.Name = "roundLabel";
            roundLabel.Size = new Size(97, 38);
            roundLabel.TabIndex = 2;
            roundLabel.Text = "Round";
            roundLabel.Click += label1_Click_1;
            // 
            // roundDropdown
            // 
            roundDropdown.FormattingEnabled = true;
            roundDropdown.Location = new Point(148, 111);
            roundDropdown.Name = "roundDropdown";
            roundDropdown.Size = new Size(217, 45);
            roundDropdown.TabIndex = 3;
            roundDropdown.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // unplayedOnlyCheckBox
            // 
            unplayedOnlyCheckBox.AutoSize = true;
            unplayedOnlyCheckBox.Location = new Point(148, 179);
            unplayedOnlyCheckBox.Name = "unplayedOnlyCheckBox";
            unplayedOnlyCheckBox.Size = new Size(217, 42);
            unplayedOnlyCheckBox.TabIndex = 4;
            unplayedOnlyCheckBox.Text = "Unplayed only";
            unplayedOnlyCheckBox.UseVisualStyleBackColor = true;
            // 
            // matchupListBox
            // 
            matchupListBox.FormattingEnabled = true;
            matchupListBox.ItemHeight = 37;
            matchupListBox.Location = new Point(33, 267);
            matchupListBox.Name = "matchupListBox";
            matchupListBox.Size = new Size(345, 337);
            matchupListBox.TabIndex = 5;
            // 
            // team1Label
            // 
            team1Label.AutoSize = true;
            team1Label.Location = new Point(567, 267);
            team1Label.Name = "team1Label";
            team1Label.Size = new Size(172, 38);
            team1Label.TabIndex = 6;
            team1Label.Text = "<team one>";
            // 
            // score1Label
            // 
            score1Label.AutoSize = true;
            score1Label.Location = new Point(567, 324);
            score1Label.Name = "score1Label";
            score1Label.Size = new Size(86, 38);
            score1Label.TabIndex = 7;
            score1Label.Text = "Score";
            // 
            // scorebox1Label
            // 
            scorebox1Label.Location = new Point(676, 319);
            scorebox1Label.Name = "scorebox1Label";
            scorebox1Label.Size = new Size(125, 43);
            scorebox1Label.TabIndex = 8;
            // 
            // team2Label
            // 
            team2Label.AutoSize = true;
            team2Label.Location = new Point(567, 453);
            team2Label.Name = "team2Label";
            team2Label.Size = new Size(170, 38);
            team2Label.TabIndex = 9;
            team2Label.Text = "<team two>";
            // 
            // score2Label
            // 
            score2Label.AutoSize = true;
            score2Label.Location = new Point(567, 513);
            score2Label.Name = "score2Label";
            score2Label.Size = new Size(86, 38);
            score2Label.TabIndex = 10;
            score2Label.Text = "Score";
            score2Label.Click += label1_Click_2;
            // 
            // scorebox2Label
            // 
            scorebox2Label.Location = new Point(676, 508);
            scorebox2Label.Name = "scorebox2Label";
            scorebox2Label.Size = new Size(125, 43);
            scorebox2Label.TabIndex = 11;
            // 
            // vsLabel
            // 
            vsLabel.AutoSize = true;
            vsLabel.Location = new Point(653, 397);
            vsLabel.Name = "vsLabel";
            vsLabel.Size = new Size(71, 38);
            vsLabel.TabIndex = 12;
            vsLabel.Text = "-VS-";
            // 
            // scoreButton
            // 
            scoreButton.Location = new Point(865, 397);
            scoreButton.Name = "scoreButton";
            scoreButton.Size = new Size(116, 55);
            scoreButton.TabIndex = 13;
            scoreButton.Text = "Score";
            scoreButton.UseVisualStyleBackColor = true;
            // 
            // tournamentViewerForm
            // 
            AutoScaleDimensions = new SizeF(15F, 37F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1015, 716);
            Controls.Add(scoreButton);
            Controls.Add(vsLabel);
            Controls.Add(scorebox2Label);
            Controls.Add(score2Label);
            Controls.Add(team2Label);
            Controls.Add(scorebox1Label);
            Controls.Add(score1Label);
            Controls.Add(team1Label);
            Controls.Add(matchupListBox);
            Controls.Add(unplayedOnlyCheckBox);
            Controls.Add(roundDropdown);
            Controls.Add(roundLabel);
            Controls.Add(tournamentName);
            Controls.Add(headerLabel);
            Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Margin = new Padding(6);
            Name = "tournamentViewerForm";
            Text = "Tournament Viewer";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label headerLabel;
        private Label tournamentName;
        private Label roundLabel;
        private ComboBox roundDropdown;
        private CheckBox unplayedOnlyCheckBox;
        private ListBox matchupListBox;
        private Label team1Label;
        private Label score1Label;
        private TextBox scorebox1Label;
        private Label team2Label;
        private Label score2Label;
        private TextBox scorebox2Label;
        private Label vsLabel;
        private Button scoreButton;
    }
}
