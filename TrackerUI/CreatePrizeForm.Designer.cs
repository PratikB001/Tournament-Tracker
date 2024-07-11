namespace TrackerUI
{
    partial class CreatePrizeForm
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
            firstNameValue = new TextBox();
            placeNumberLabel = new Label();
            placeNameValue = new TextBox();
            placeNameLabel = new Label();
            prizeAmountValue = new TextBox();
            prizeAmountLabel = new Label();
            prizePercentageValue = new TextBox();
            prizePercentageLabel = new Label();
            orLabel = new Label();
            createPrizeButton = new Button();
            SuspendLayout();
            // 
            // createPrizeLabel
            // 
            createPrizeLabel.AutoSize = true;
            createPrizeLabel.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            createPrizeLabel.Location = new Point(30, 26);
            createPrizeLabel.Name = "createPrizeLabel";
            createPrizeLabel.Size = new Size(166, 38);
            createPrizeLabel.TabIndex = 1;
            createPrizeLabel.Text = "Create Prize";
            // 
            // firstNameValue
            // 
            firstNameValue.Location = new Point(273, 93);
            firstNameValue.Name = "firstNameValue";
            firstNameValue.Size = new Size(187, 27);
            firstNameValue.TabIndex = 26;
            firstNameValue.TextChanged += firstNameValue_TextChanged;
            // 
            // placeNumberLabel
            // 
            placeNumberLabel.AutoSize = true;
            placeNumberLabel.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            placeNumberLabel.Location = new Point(89, 89);
            placeNumberLabel.Name = "placeNumberLabel";
            placeNumberLabel.Size = new Size(140, 28);
            placeNumberLabel.TabIndex = 25;
            placeNumberLabel.Text = "Place Number";
            // 
            // placeNameValue
            // 
            placeNameValue.Location = new Point(273, 141);
            placeNameValue.Name = "placeNameValue";
            placeNameValue.Size = new Size(187, 27);
            placeNameValue.TabIndex = 30;
            // 
            // placeNameLabel
            // 
            placeNameLabel.AutoSize = true;
            placeNameLabel.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            placeNameLabel.Location = new Point(89, 140);
            placeNameLabel.Name = "placeNameLabel";
            placeNameLabel.Size = new Size(119, 28);
            placeNameLabel.TabIndex = 29;
            placeNameLabel.Text = "Place Name";
            // 
            // prizeAmountValue
            // 
            prizeAmountValue.Location = new Point(273, 198);
            prizeAmountValue.Name = "prizeAmountValue";
            prizeAmountValue.Size = new Size(187, 27);
            prizeAmountValue.TabIndex = 32;
            // 
            // prizeAmountLabel
            // 
            prizeAmountLabel.AutoSize = true;
            prizeAmountLabel.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            prizeAmountLabel.Location = new Point(89, 194);
            prizeAmountLabel.Name = "prizeAmountLabel";
            prizeAmountLabel.Size = new Size(136, 28);
            prizeAmountLabel.TabIndex = 31;
            prizeAmountLabel.Text = "Prize Amount";
            // 
            // prizePercentageValue
            // 
            prizePercentageValue.Location = new Point(273, 296);
            prizePercentageValue.Name = "prizePercentageValue";
            prizePercentageValue.Size = new Size(187, 27);
            prizePercentageValue.TabIndex = 34;
            // 
            // prizePercentageLabel
            // 
            prizePercentageLabel.AutoSize = true;
            prizePercentageLabel.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            prizePercentageLabel.Location = new Point(89, 292);
            prizePercentageLabel.Name = "prizePercentageLabel";
            prizePercentageLabel.Size = new Size(163, 28);
            prizePercentageLabel.TabIndex = 33;
            prizePercentageLabel.Text = "Prize Percentage";
            prizePercentageLabel.Click += label1_Click;
            // 
            // orLabel
            // 
            orLabel.AutoSize = true;
            orLabel.Location = new Point(236, 252);
            orLabel.Name = "orLabel";
            orLabel.Size = new Size(43, 20);
            orLabel.TabIndex = 35;
            orLabel.Text = "- or -";
            // 
            // createPrizeButton
            // 
            createPrizeButton.Location = new Point(181, 373);
            createPrizeButton.Name = "createPrizeButton";
            createPrizeButton.Size = new Size(209, 38);
            createPrizeButton.TabIndex = 36;
            createPrizeButton.Text = "Create Prize";
            createPrizeButton.UseVisualStyleBackColor = true;
            // 
            // CreatePrizeForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(562, 450);
            Controls.Add(createPrizeButton);
            Controls.Add(orLabel);
            Controls.Add(prizePercentageValue);
            Controls.Add(prizePercentageLabel);
            Controls.Add(prizeAmountValue);
            Controls.Add(prizeAmountLabel);
            Controls.Add(placeNameValue);
            Controls.Add(placeNameLabel);
            Controls.Add(firstNameValue);
            Controls.Add(placeNumberLabel);
            Controls.Add(createPrizeLabel);
            Name = "CreatePrizeForm";
            Text = "Create Prize";
            Load += CreatePrizeForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label createPrizeLabel;
        private TextBox firstNameValue;
        private Label placeNumberLabel;
        private TextBox placeNameValue;
        private Label placeNameLabel;
        private TextBox prizeAmountValue;
        private Label prizeAmountLabel;
        private TextBox prizePercentageValue;
        private Label prizePercentageLabel;
        private Label orLabel;
        private Button createPrizeButton;
    }
}