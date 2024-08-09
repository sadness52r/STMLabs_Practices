namespace Practice4_OOP
{
    partial class FormAddClient
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
            components = new System.ComponentModel.Container();
            labelAddClientTitle = new Label();
            labelPhoneTitle = new Label();
            labelPatronymicTitle = new Label();
            labelSurnameTitle = new Label();
            labelNameTitle = new Label();
            maskedTextBoxNewClientSurname = new MaskedTextBox();
            maskedTextBoxNewClientName = new MaskedTextBox();
            maskedTextBoxNewClientPatronymic = new MaskedTextBox();
            maskedTextBoxNewClientPhone = new MaskedTextBox();
            labelPassportNumberTitle = new Label();
            maskedTextBoxNewClientPassportNumber = new MaskedTextBox();
            labelPassportSeriesTitle = new Label();
            maskedTextBoxNewClientPassportSeries = new MaskedTextBox();
            buttonAddClient = new Button();
            timerAcceptClientToAdd = new System.Windows.Forms.Timer(components);
            SuspendLayout();
            // 
            // labelAddClientTitle
            // 
            labelAddClientTitle.AutoSize = true;
            labelAddClientTitle.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 204);
            labelAddClientTitle.Location = new Point(324, 42);
            labelAddClientTitle.Name = "labelAddClientTitle";
            labelAddClientTitle.Size = new Size(134, 32);
            labelAddClientTitle.TabIndex = 0;
            labelAddClientTitle.Text = "Add Client";
            // 
            // labelPhoneTitle
            // 
            labelPhoneTitle.AutoSize = true;
            labelPhoneTitle.Font = new Font("Segoe UI", 12F);
            labelPhoneTitle.Location = new Point(151, 224);
            labelPhoneTitle.Name = "labelPhoneTitle";
            labelPhoneTitle.Size = new Size(57, 21);
            labelPhoneTitle.TabIndex = 8;
            labelPhoneTitle.Text = "Phone:";
            // 
            // labelPatronymicTitle
            // 
            labelPatronymicTitle.AutoSize = true;
            labelPatronymicTitle.Font = new Font("Segoe UI", 12F);
            labelPatronymicTitle.Location = new Point(151, 185);
            labelPatronymicTitle.Name = "labelPatronymicTitle";
            labelPatronymicTitle.Size = new Size(91, 21);
            labelPatronymicTitle.TabIndex = 7;
            labelPatronymicTitle.Text = "Patronymic:";
            // 
            // labelSurnameTitle
            // 
            labelSurnameTitle.AutoSize = true;
            labelSurnameTitle.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            labelSurnameTitle.Location = new Point(151, 116);
            labelSurnameTitle.Name = "labelSurnameTitle";
            labelSurnameTitle.Size = new Size(76, 21);
            labelSurnameTitle.TabIndex = 6;
            labelSurnameTitle.Text = "Surname:";
            // 
            // labelNameTitle
            // 
            labelNameTitle.AutoSize = true;
            labelNameTitle.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            labelNameTitle.Location = new Point(151, 150);
            labelNameTitle.Name = "labelNameTitle";
            labelNameTitle.Size = new Size(55, 21);
            labelNameTitle.TabIndex = 5;
            labelNameTitle.Text = "Name:";
            // 
            // maskedTextBoxNewClientSurname
            // 
            maskedTextBoxNewClientSurname.CutCopyMaskFormat = MaskFormat.ExcludePromptAndLiterals;
            maskedTextBoxNewClientSurname.Location = new Point(301, 118);
            maskedTextBoxNewClientSurname.Mask = "LLLLLLLLLLLLLLLLLLLLLLLLLLLLL";
            maskedTextBoxNewClientSurname.Name = "maskedTextBoxNewClientSurname";
            maskedTextBoxNewClientSurname.Size = new Size(171, 23);
            maskedTextBoxNewClientSurname.TabIndex = 10;
            maskedTextBoxNewClientSurname.TextAlign = HorizontalAlignment.Center;
            // 
            // maskedTextBoxNewClientName
            // 
            maskedTextBoxNewClientName.CutCopyMaskFormat = MaskFormat.ExcludePromptAndLiterals;
            maskedTextBoxNewClientName.Location = new Point(301, 152);
            maskedTextBoxNewClientName.Mask = "LLLLLLLLLLLLLLLLLLLLLLLLLLLLL";
            maskedTextBoxNewClientName.Name = "maskedTextBoxNewClientName";
            maskedTextBoxNewClientName.Size = new Size(171, 23);
            maskedTextBoxNewClientName.TabIndex = 11;
            maskedTextBoxNewClientName.TextAlign = HorizontalAlignment.Center;
            // 
            // maskedTextBoxNewClientPatronymic
            // 
            maskedTextBoxNewClientPatronymic.CutCopyMaskFormat = MaskFormat.ExcludePromptAndLiterals;
            maskedTextBoxNewClientPatronymic.Location = new Point(301, 185);
            maskedTextBoxNewClientPatronymic.Mask = "LLLLLLLLLLLLLLLLLLLLLLLLLLLLL";
            maskedTextBoxNewClientPatronymic.Name = "maskedTextBoxNewClientPatronymic";
            maskedTextBoxNewClientPatronymic.Size = new Size(171, 23);
            maskedTextBoxNewClientPatronymic.TabIndex = 12;
            maskedTextBoxNewClientPatronymic.TextAlign = HorizontalAlignment.Center;
            // 
            // maskedTextBoxNewClientPhone
            // 
            maskedTextBoxNewClientPhone.CutCopyMaskFormat = MaskFormat.ExcludePromptAndLiterals;
            maskedTextBoxNewClientPhone.Location = new Point(338, 222);
            maskedTextBoxNewClientPhone.Mask = "00000000000";
            maskedTextBoxNewClientPhone.Name = "maskedTextBoxNewClientPhone";
            maskedTextBoxNewClientPhone.Size = new Size(101, 23);
            maskedTextBoxNewClientPhone.TabIndex = 13;
            maskedTextBoxNewClientPhone.TextAlign = HorizontalAlignment.Center;
            maskedTextBoxNewClientPhone.TextMaskFormat = MaskFormat.ExcludePromptAndLiterals;
            // 
            // labelPassportNumberTitle
            // 
            labelPassportNumberTitle.AutoSize = true;
            labelPassportNumberTitle.Font = new Font("Arial", 10.8F, FontStyle.Italic, GraphicsUnit.Point, 204);
            labelPassportNumberTitle.Location = new Point(465, 268);
            labelPassportNumberTitle.Name = "labelPassportNumberTitle";
            labelPassportNumberTitle.Size = new Size(124, 17);
            labelPassportNumberTitle.TabIndex = 17;
            labelPassportNumberTitle.Text = "Passport Number";
            labelPassportNumberTitle.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // maskedTextBoxNewClientPassportNumber
            // 
            maskedTextBoxNewClientPassportNumber.CutCopyMaskFormat = MaskFormat.ExcludePromptAndLiterals;
            maskedTextBoxNewClientPassportNumber.Location = new Point(500, 288);
            maskedTextBoxNewClientPassportNumber.Mask = "000000";
            maskedTextBoxNewClientPassportNumber.Name = "maskedTextBoxNewClientPassportNumber";
            maskedTextBoxNewClientPassportNumber.Size = new Size(52, 23);
            maskedTextBoxNewClientPassportNumber.TabIndex = 16;
            maskedTextBoxNewClientPassportNumber.TextAlign = HorizontalAlignment.Center;
            maskedTextBoxNewClientPassportNumber.TextMaskFormat = MaskFormat.ExcludePromptAndLiterals;
            // 
            // labelPassportSeriesTitle
            // 
            labelPassportSeriesTitle.AutoSize = true;
            labelPassportSeriesTitle.Font = new Font("Arial", 10.8F, FontStyle.Italic, GraphicsUnit.Point, 204);
            labelPassportSeriesTitle.Location = new Point(220, 268);
            labelPassportSeriesTitle.Name = "labelPassportSeriesTitle";
            labelPassportSeriesTitle.Size = new Size(113, 17);
            labelPassportSeriesTitle.TabIndex = 15;
            labelPassportSeriesTitle.Text = "Passport Series";
            labelPassportSeriesTitle.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // maskedTextBoxNewClientPassportSeries
            // 
            maskedTextBoxNewClientPassportSeries.CutCopyMaskFormat = MaskFormat.ExcludePromptAndLiterals;
            maskedTextBoxNewClientPassportSeries.Location = new Point(256, 288);
            maskedTextBoxNewClientPassportSeries.Mask = "0000";
            maskedTextBoxNewClientPassportSeries.Name = "maskedTextBoxNewClientPassportSeries";
            maskedTextBoxNewClientPassportSeries.Size = new Size(39, 23);
            maskedTextBoxNewClientPassportSeries.TabIndex = 14;
            maskedTextBoxNewClientPassportSeries.TextAlign = HorizontalAlignment.Center;
            maskedTextBoxNewClientPassportSeries.TextMaskFormat = MaskFormat.ExcludePromptAndLiterals;
            // 
            // buttonAddClient
            // 
            buttonAddClient.Enabled = false;
            buttonAddClient.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 204);
            buttonAddClient.Location = new Point(324, 351);
            buttonAddClient.Name = "buttonAddClient";
            buttonAddClient.Size = new Size(134, 71);
            buttonAddClient.TabIndex = 18;
            buttonAddClient.Text = "ADD";
            buttonAddClient.UseVisualStyleBackColor = true;
            buttonAddClient.Click += buttonAddClient_Click;
            // 
            // timerAcceptClientToAdd
            // 
            timerAcceptClientToAdd.Enabled = true;
            timerAcceptClientToAdd.Tick += timerAcceptClientToAdd_Tick;
            // 
            // FormAddClient
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(buttonAddClient);
            Controls.Add(labelPassportNumberTitle);
            Controls.Add(maskedTextBoxNewClientPassportNumber);
            Controls.Add(labelPassportSeriesTitle);
            Controls.Add(maskedTextBoxNewClientPassportSeries);
            Controls.Add(maskedTextBoxNewClientPhone);
            Controls.Add(maskedTextBoxNewClientPatronymic);
            Controls.Add(maskedTextBoxNewClientName);
            Controls.Add(maskedTextBoxNewClientSurname);
            Controls.Add(labelPhoneTitle);
            Controls.Add(labelPatronymicTitle);
            Controls.Add(labelSurnameTitle);
            Controls.Add(labelNameTitle);
            Controls.Add(labelAddClientTitle);
            Name = "FormAddClient";
            Text = "Add Client";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labelAddClientTitle;
        private Label labelPhoneTitle;
        private Label labelPatronymicTitle;
        private Label labelSurnameTitle;
        private Label labelNameTitle;
        private MaskedTextBox maskedTextBoxNewClientSurname;
        private MaskedTextBox maskedTextBoxNewClientName;
        private MaskedTextBox maskedTextBoxNewClientPatronymic;
        private MaskedTextBox maskedTextBoxNewClientPhone;
        private Label labelPassportNumberTitle;
        private MaskedTextBox maskedTextBoxNewClientPassportNumber;
        private Label labelPassportSeriesTitle;
        private MaskedTextBox maskedTextBoxNewClientPassportSeries;
        private Button buttonAddClient;
        private System.Windows.Forms.Timer timerAcceptClientToAdd;
    }
}