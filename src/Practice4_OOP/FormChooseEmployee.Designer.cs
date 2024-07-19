namespace Practice4_OOP
{
    partial class FormChooseEmployee
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
            comboBoxChooseEmployee = new ComboBox();
            buttonOpenMain = new Button();
            SuspendLayout();
            // 
            // comboBoxChooseEmployee
            // 
            comboBoxChooseEmployee.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxChooseEmployee.FormattingEnabled = true;
            comboBoxChooseEmployee.ImeMode = ImeMode.NoControl;
            comboBoxChooseEmployee.Items.AddRange(new object[] { "Consultant" });
            comboBoxChooseEmployee.Location = new Point(280, 285);
            comboBoxChooseEmployee.Name = "comboBoxChooseEmployee";
            comboBoxChooseEmployee.Size = new Size(239, 23);
            comboBoxChooseEmployee.TabIndex = 0;
            // 
            // buttonOpenMain
            // 
            buttonOpenMain.Location = new Point(340, 372);
            buttonOpenMain.Name = "buttonOpenMain";
            buttonOpenMain.Size = new Size(118, 42);
            buttonOpenMain.TabIndex = 1;
            buttonOpenMain.Text = "Open";
            buttonOpenMain.UseVisualStyleBackColor = true;
            buttonOpenMain.Click += buttonOpenMain_Click;
            // 
            // FormChooseEmployee
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(buttonOpenMain);
            Controls.Add(comboBoxChooseEmployee);
            FormBorderStyle = FormBorderStyle.Fixed3D;
            Name = "FormChooseEmployee";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Choose Employee";
            Load += FormChooseEmployee_Load;
            ResumeLayout(false);
        }

        #endregion

        private ComboBox comboBoxChooseEmployee;
        private Button buttonOpenMain;
    }
}
