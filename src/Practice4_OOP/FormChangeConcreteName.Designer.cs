namespace Practice4_OOP
{
    partial class FormChangeConcreteName
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
            maskedTextBoxNewConcreteName = new MaskedTextBox();
            buttonAcceptConcreteName = new Button();
            labelChangeConcreteNameTitle = new Label();
            labelConcreteName = new Label();
            SuspendLayout();
            // 
            // maskedTextBoxNewConcreteName
            // 
            maskedTextBoxNewConcreteName.CutCopyMaskFormat = MaskFormat.ExcludePromptAndLiterals;
            maskedTextBoxNewConcreteName.Location = new Point(299, 213);
            maskedTextBoxNewConcreteName.Margin = new Padding(3, 4, 3, 4);
            maskedTextBoxNewConcreteName.Mask = "LLLLLLLLLLLLLLLLLLLLLLLLLLLLL";
            maskedTextBoxNewConcreteName.Name = "maskedTextBoxNewConcreteName";
            maskedTextBoxNewConcreteName.Size = new Size(195, 27);
            maskedTextBoxNewConcreteName.TabIndex = 6;
            maskedTextBoxNewConcreteName.TextAlign = HorizontalAlignment.Center;
            maskedTextBoxNewConcreteName.TextChanged += maskedTextBoxNewConcreteName_TextChanged;
            // 
            // buttonAcceptConcreteName
            // 
            buttonAcceptConcreteName.Enabled = false;
            buttonAcceptConcreteName.Location = new Point(359, 273);
            buttonAcceptConcreteName.Margin = new Padding(3, 4, 3, 4);
            buttonAcceptConcreteName.Name = "buttonAcceptConcreteName";
            buttonAcceptConcreteName.Size = new Size(74, 44);
            buttonAcceptConcreteName.TabIndex = 5;
            buttonAcceptConcreteName.Text = "Accept";
            buttonAcceptConcreteName.UseVisualStyleBackColor = true;
            buttonAcceptConcreteName.Click += buttonAcceptConcreteName_Click;
            // 
            // labelChangeConcreteNameTitle
            // 
            labelChangeConcreteNameTitle.AutoSize = true;
            labelChangeConcreteNameTitle.Font = new Font("Segoe UI Semibold", 15.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 204);
            labelChangeConcreteNameTitle.Location = new Point(287, 131);
            labelChangeConcreteNameTitle.Name = "labelChangeConcreteNameTitle";
            labelChangeConcreteNameTitle.Size = new Size(110, 37);
            labelChangeConcreteNameTitle.TabIndex = 4;
            labelChangeConcreteNameTitle.Text = "Change";
            labelChangeConcreteNameTitle.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // labelConcreteName
            // 
            labelConcreteName.AutoSize = true;
            labelConcreteName.Font = new Font("Segoe UI Semibold", 15.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 204);
            labelConcreteName.Location = new Point(397, 131);
            labelConcreteName.Name = "labelConcreteName";
            labelConcreteName.Size = new Size(0, 37);
            labelConcreteName.TabIndex = 7;
            labelConcreteName.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // FormChangeConcreteName
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(labelConcreteName);
            Controls.Add(maskedTextBoxNewConcreteName);
            Controls.Add(buttonAcceptConcreteName);
            Controls.Add(labelChangeConcreteNameTitle);
            MaximizeBox = false;
            Name = "FormChangeConcreteName";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FormChangeFullname";
            Load += FormChangeFullname_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MaskedTextBox maskedTextBoxNewConcreteName;
        private Button buttonAcceptConcreteName;
        private Label labelChangeConcreteNameTitle;
        private Label labelConcreteName;
    }
}