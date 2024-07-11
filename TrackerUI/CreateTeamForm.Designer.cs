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
            createTeamLabel = new Label();
            tournamentNameValue = new TextBox();
            teamNameLabel = new Label();
            selectTeamMemberLabel = new Label();
            comboBox1 = new ComboBox();
            addMemberButton = new Button();
            tournamentPlayersListBox = new ListBox();
            createTeamButton = new Button();
            newMemberGroupBox = new GroupBox();
            createMemberButton = new Button();
            firstNameLabel = new Label();
            lastNameLabel = new Label();
            emailLabel = new Label();
            cellPhoneLabel = new Label();
            firstNameValue = new TextBox();
            cellPhonevalue = new TextBox();
            emailValue = new TextBox();
            lastNameValue = new TextBox();
            deleteSelectedButton = new Button();
            newMemberGroupBox.SuspendLayout();
            SuspendLayout();
            // 
            // createTeamLabel
            // 
            createTeamLabel.AutoSize = true;
            createTeamLabel.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            createTeamLabel.Location = new Point(27, 26);
            createTeamLabel.Name = "createTeamLabel";
            createTeamLabel.Size = new Size(170, 38);
            createTeamLabel.TabIndex = 0;
            createTeamLabel.Text = "Create Team";
            // 
            // tournamentNameValue
            // 
            tournamentNameValue.Location = new Point(27, 110);
            tournamentNameValue.Name = "tournamentNameValue";
            tournamentNameValue.Size = new Size(328, 27);
            tournamentNameValue.TabIndex = 4;
            // 
            // teamNameLabel
            // 
            teamNameLabel.AutoSize = true;
            teamNameLabel.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            teamNameLabel.Location = new Point(27, 79);
            teamNameLabel.Name = "teamNameLabel";
            teamNameLabel.Size = new Size(120, 28);
            teamNameLabel.TabIndex = 3;
            teamNameLabel.Text = "Team Name";
            teamNameLabel.Click += teamNameLabel_Click;
            // 
            // selectTeamMemberLabel
            // 
            selectTeamMemberLabel.AutoSize = true;
            selectTeamMemberLabel.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            selectTeamMemberLabel.Location = new Point(27, 164);
            selectTeamMemberLabel.Name = "selectTeamMemberLabel";
            selectTeamMemberLabel.Size = new Size(203, 28);
            selectTeamMemberLabel.TabIndex = 5;
            selectTeamMemberLabel.Text = "Select Team Member";
            selectTeamMemberLabel.Click += label1_Click;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(27, 195);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(328, 28);
            comboBox1.TabIndex = 6;
            // 
            // addMemberButton
            // 
            addMemberButton.Location = new Point(81, 241);
            addMemberButton.Name = "addMemberButton";
            addMemberButton.Size = new Size(209, 38);
            addMemberButton.TabIndex = 8;
            addMemberButton.Text = "Add Member";
            addMemberButton.UseVisualStyleBackColor = true;
            // 
            // tournamentPlayersListBox
            // 
            tournamentPlayersListBox.FormattingEnabled = true;
            tournamentPlayersListBox.Location = new Point(416, 99);
            tournamentPlayersListBox.Name = "tournamentPlayersListBox";
            tournamentPlayersListBox.Size = new Size(368, 484);
            tournamentPlayersListBox.TabIndex = 19;
            tournamentPlayersListBox.SelectedIndexChanged += listBox1_SelectedIndexChanged;
            // 
            // createTeamButton
            // 
            createTeamButton.Location = new Point(307, 609);
            createTeamButton.Name = "createTeamButton";
            createTeamButton.Size = new Size(209, 38);
            createTeamButton.TabIndex = 20;
            createTeamButton.Text = "Create Team";
            createTeamButton.UseVisualStyleBackColor = true;
            // 
            // newMemberGroupBox
            // 
            newMemberGroupBox.Controls.Add(createMemberButton);
            newMemberGroupBox.Controls.Add(lastNameValue);
            newMemberGroupBox.Controls.Add(emailValue);
            newMemberGroupBox.Controls.Add(cellPhonevalue);
            newMemberGroupBox.Controls.Add(firstNameValue);
            newMemberGroupBox.Controls.Add(cellPhoneLabel);
            newMemberGroupBox.Controls.Add(emailLabel);
            newMemberGroupBox.Controls.Add(lastNameLabel);
            newMemberGroupBox.Controls.Add(firstNameLabel);
            newMemberGroupBox.Location = new Point(27, 306);
            newMemberGroupBox.Name = "newMemberGroupBox";
            newMemberGroupBox.Size = new Size(339, 277);
            newMemberGroupBox.TabIndex = 21;
            newMemberGroupBox.TabStop = false;
            newMemberGroupBox.Text = "Add New Member";
            // 
            // createMemberButton
            // 
            createMemberButton.Location = new Point(54, 227);
            createMemberButton.Name = "createMemberButton";
            createMemberButton.Size = new Size(209, 38);
            createMemberButton.TabIndex = 28;
            createMemberButton.Text = "Create Member";
            createMemberButton.UseVisualStyleBackColor = true;
            // 
            // firstNameLabel
            // 
            firstNameLabel.AutoSize = true;
            firstNameLabel.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            firstNameLabel.Location = new Point(0, 42);
            firstNameLabel.Name = "firstNameLabel";
            firstNameLabel.Size = new Size(110, 28);
            firstNameLabel.TabIndex = 20;
            firstNameLabel.Text = "First Name";
            firstNameLabel.Click += firstNameLabel_Click;
            // 
            // lastNameLabel
            // 
            lastNameLabel.AutoSize = true;
            lastNameLabel.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lastNameLabel.Location = new Point(0, 89);
            lastNameLabel.Name = "lastNameLabel";
            lastNameLabel.Size = new Size(108, 28);
            lastNameLabel.TabIndex = 21;
            lastNameLabel.Text = "Last Name";
            // 
            // emailLabel
            // 
            emailLabel.AutoSize = true;
            emailLabel.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            emailLabel.Location = new Point(0, 132);
            emailLabel.Name = "emailLabel";
            emailLabel.Size = new Size(60, 28);
            emailLabel.TabIndex = 22;
            emailLabel.Text = "Email";
            // 
            // cellPhoneLabel
            // 
            cellPhoneLabel.AutoSize = true;
            cellPhoneLabel.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            cellPhoneLabel.Location = new Point(0, 178);
            cellPhoneLabel.Name = "cellPhoneLabel";
            cellPhoneLabel.Size = new Size(104, 28);
            cellPhoneLabel.TabIndex = 23;
            cellPhoneLabel.Text = "CellPhone";
            // 
            // firstNameValue
            // 
            firstNameValue.Location = new Point(141, 46);
            firstNameValue.Name = "firstNameValue";
            firstNameValue.Size = new Size(187, 27);
            firstNameValue.TabIndex = 24;
            // 
            // cellPhonevalue
            // 
            cellPhonevalue.Location = new Point(141, 182);
            cellPhonevalue.Name = "cellPhonevalue";
            cellPhonevalue.Size = new Size(187, 27);
            cellPhonevalue.TabIndex = 25;
            // 
            // emailValue
            // 
            emailValue.Location = new Point(141, 136);
            emailValue.Name = "emailValue";
            emailValue.Size = new Size(187, 27);
            emailValue.TabIndex = 26;
            // 
            // lastNameValue
            // 
            lastNameValue.Location = new Point(141, 93);
            lastNameValue.Name = "lastNameValue";
            lastNameValue.Size = new Size(187, 27);
            lastNameValue.TabIndex = 27;
            // 
            // deleteSelectedButton
            // 
            deleteSelectedButton.Location = new Point(808, 283);
            deleteSelectedButton.Name = "deleteSelectedButton";
            deleteSelectedButton.Size = new Size(120, 82);
            deleteSelectedButton.TabIndex = 22;
            deleteSelectedButton.Text = "Delete Selected";
            deleteSelectedButton.UseVisualStyleBackColor = true;
            // 
            // createTeamForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(949, 659);
            Controls.Add(deleteSelectedButton);
            Controls.Add(newMemberGroupBox);
            Controls.Add(createTeamButton);
            Controls.Add(tournamentPlayersListBox);
            Controls.Add(addMemberButton);
            Controls.Add(comboBox1);
            Controls.Add(selectTeamMemberLabel);
            Controls.Add(tournamentNameValue);
            Controls.Add(teamNameLabel);
            Controls.Add(createTeamLabel);
            Name = "createTeamForm";
            Text = "Create Team";
            Load += CreateTeamForm_Load;
            newMemberGroupBox.ResumeLayout(false);
            newMemberGroupBox.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label createTeamLabel;
        private TextBox tournamentNameValue;
        private Label teamNameLabel;
        private Label selectTeamMemberLabel;
        private ComboBox comboBox1;
        private Button addMemberButton;
        private ListBox tournamentPlayersListBox;
        private Button createTeamButton;
        private GroupBox newMemberGroupBox;
        private Button createMemberButton;
        private TextBox lastNameValue;
        private TextBox emailValue;
        private TextBox cellPhonevalue;
        private TextBox firstNameValue;
        private Label cellPhoneLabel;
        private Label emailLabel;
        private Label lastNameLabel;
        private Label firstNameLabel;
        private Button deleteSelectedButton;
    }
}