namespace Practice4_OOP
{
    partial class FormChangePassport
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
            maskedTextBoxNewPassportSeries = new MaskedTextBox();
            buttonAcceptPassport = new Button();
            labelChangePassportTitle = new Label();
            labelPassportSeriesTitle = new Label();
            labelPassportNumberTitle = new Label();
            maskedTextBoxNewPassportNumber = new MaskedTextBox();
            timerCheckUpdateButton = new System.Windows.Forms.Timer(components);
            SuspendLayout();
            // 
            // maskedTextBoxNewPassportSeries
            // 
            maskedTextBoxNewPassportSeries.CutCopyMaskFormat = MaskFormat.ExcludePromptAndLiterals;
            maskedTextBoxNewPassportSeries.Location = new Point(244, 203);
            maskedTextBoxNewPassportSeries.Margin = new Padding(3, 4, 3, 4);
            maskedTextBoxNewPassportSeries.Mask = "0000";
            maskedTextBoxNewPassportSeries.Name = "maskedTextBoxNewPassportSeries";
            maskedTextBoxNewPassportSeries.Size = new Size(44, 27);
            maskedTextBoxNewPassportSeries.TabIndex = 6;
            maskedTextBoxNewPassportSeries.TextAlign = HorizontalAlignment.Center;
            maskedTextBoxNewPassportSeries.TextMaskFormat = MaskFormat.ExcludePromptAndLiterals;
            // 
            // buttonAcceptPassport
            // 
            buttonAcceptPassport.Enabled = false;
            buttonAcceptPassport.Location = new Point(364, 272);
            buttonAcceptPassport.Margin = new Padding(3, 4, 3, 4);
            buttonAcceptPassport.Name = "buttonAcceptPassport";
            buttonAcceptPassport.Size = new Size(74, 44);
            buttonAcceptPassport.TabIndex = 5;
            buttonAcceptPassport.Text = "Accept";
            buttonAcceptPassport.UseVisualStyleBackColor = true;
            buttonAcceptPassport.Click += buttonAcceptPassport_Click;
            // 
            // labelChangePassportTitle
            // 
            labelChangePassportTitle.AutoSize = true;
            labelChangePassportTitle.Font = new Font("Segoe UI Semibold", 15.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 204);
            labelChangePassportTitle.Location = new Point(295, 117);
            labelChangePassportTitle.Name = "labelChangePassportTitle";
            labelChangePassportTitle.Size = new Size(218, 37);
            labelChangePassportTitle.TabIndex = 4;
            labelChangePassportTitle.Text = "Change passport";
            labelChangePassportTitle.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // labelPassportSeriesTitle
            // 
            labelPassportSeriesTitle.AutoSize = true;
            labelPassportSeriesTitle.Font = new Font("Arial", 10.8F, FontStyle.Italic, GraphicsUnit.Point, 204);
            labelPassportSeriesTitle.Location = new Point(198, 177);
            labelPassportSeriesTitle.Name = "labelPassportSeriesTitle";
            labelPassportSeriesTitle.Size = new Size(138, 22);
            labelPassportSeriesTitle.TabIndex = 7;
            labelPassportSeriesTitle.Text = "Passport Series";
            labelPassportSeriesTitle.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // labelPassportNumberTitle
            // 
            labelPassportNumberTitle.AutoSize = true;
            labelPassportNumberTitle.Font = new Font("Arial", 10.8F, FontStyle.Italic, GraphicsUnit.Point, 204);
            labelPassportNumberTitle.Location = new Point(474, 177);
            labelPassportNumberTitle.Name = "labelPassportNumberTitle";
            labelPassportNumberTitle.Size = new Size(150, 22);
            labelPassportNumberTitle.TabIndex = 9;
            labelPassportNumberTitle.Text = "Passport Number";
            labelPassportNumberTitle.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // maskedTextBoxNewPassportNumber
            // 
            maskedTextBoxNewPassportNumber.CutCopyMaskFormat = MaskFormat.ExcludePromptAndLiterals;
            maskedTextBoxNewPassportNumber.Location = new Point(523, 203);
            maskedTextBoxNewPassportNumber.Margin = new Padding(3, 4, 3, 4);
            maskedTextBoxNewPassportNumber.Mask = "000000";
            maskedTextBoxNewPassportNumber.Name = "maskedTextBoxNewPassportNumber";
            maskedTextBoxNewPassportNumber.Size = new Size(59, 27);
            maskedTextBoxNewPassportNumber.TabIndex = 8;
            maskedTextBoxNewPassportNumber.TextAlign = HorizontalAlignment.Center;
            maskedTextBoxNewPassportNumber.TextMaskFormat = MaskFormat.ExcludePromptAndLiterals;
            // 
            // timerCheckUpdateButton
            // 
            timerCheckUpdateButton.Enabled = true;
            timerCheckUpdateButton.Tick += timerCheckUpdateButton_Tick;
            // 
            // FormChangePassport
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(labelPassportNumberTitle);
            Controls.Add(maskedTextBoxNewPassportNumber);
            Controls.Add(labelPassportSeriesTitle);
            Controls.Add(maskedTextBoxNewPassportSeries);
            Controls.Add(buttonAcceptPassport);
            Controls.Add(labelChangePassportTitle);
            MaximizeBox = false;
            Name = "FormChangePassport";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Change Passport";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MaskedTextBox maskedTextBoxNewPassportSeries;
        private Button buttonAcceptPassport;
        private Label labelChangePassportTitle;
        private Label labelPassportSeriesTitle;
        private Label labelPassportNumberTitle;
        private MaskedTextBox maskedTextBoxNewPassportNumber;
        private System.Windows.Forms.Timer timerCheckUpdateButton;
    }
}