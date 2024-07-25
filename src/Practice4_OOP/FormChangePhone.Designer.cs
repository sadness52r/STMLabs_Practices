namespace Practice4_OOP
{
    partial class FormChangePhone
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
            labelChangePhoneTitle = new Label();
            buttonAcceptPhone = new Button();
            maskedTextBoxNewPhone = new MaskedTextBox();
            SuspendLayout();
            // 
            // labelChangePhoneTitle
            // 
            labelChangePhoneTitle.AutoSize = true;
            labelChangePhoneTitle.Font = new Font("Segoe UI Semibold", 15.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 204);
            labelChangePhoneTitle.Location = new Point(321, 98);
            labelChangePhoneTitle.Name = "labelChangePhoneTitle";
            labelChangePhoneTitle.Size = new Size(150, 30);
            labelChangePhoneTitle.TabIndex = 1;
            labelChangePhoneTitle.Text = "Change phone";
            labelChangePhoneTitle.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // buttonAcceptPhone
            // 
            buttonAcceptPhone.Enabled = false;
            buttonAcceptPhone.Location = new Point(360, 200);
            buttonAcceptPhone.Name = "buttonAcceptPhone";
            buttonAcceptPhone.Size = new Size(65, 33);
            buttonAcceptPhone.TabIndex = 2;
            buttonAcceptPhone.Text = "Accept";
            buttonAcceptPhone.UseVisualStyleBackColor = true;
            buttonAcceptPhone.Click += buttonAcceptPhone_Click;
            // 
            // maskedTextBoxNewPhone
            // 
            maskedTextBoxNewPhone.CutCopyMaskFormat = MaskFormat.ExcludePromptAndLiterals;
            maskedTextBoxNewPhone.Location = new Point(342, 159);
            maskedTextBoxNewPhone.Mask = "00000000000";
            maskedTextBoxNewPhone.Name = "maskedTextBoxNewPhone";
            maskedTextBoxNewPhone.Size = new Size(101, 23);
            maskedTextBoxNewPhone.TabIndex = 3;
            maskedTextBoxNewPhone.TextAlign = HorizontalAlignment.Center;
            maskedTextBoxNewPhone.TextMaskFormat = MaskFormat.ExcludePromptAndLiterals;
            maskedTextBoxNewPhone.TextChanged += maskedTextBoxNewPhone_TextChanged;
            // 
            // FormChangePhone
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(maskedTextBoxNewPhone);
            Controls.Add(buttonAcceptPhone);
            Controls.Add(labelChangePhoneTitle);
            Name = "FormChangePhone";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Change Phone";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBoxNewPhone;
        private Label labelChangePhoneTitle;
        private Button buttonAcceptPhone;
        private MaskedTextBox maskedTextBoxNewPhone;
    }
}