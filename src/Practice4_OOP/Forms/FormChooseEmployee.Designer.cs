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
            pictureBoxJobTitle = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBoxJobTitle).BeginInit();
            SuspendLayout();
            // 
            // comboBoxChooseEmployee
            // 
            comboBoxChooseEmployee.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxChooseEmployee.FormattingEnabled = true;
            comboBoxChooseEmployee.ImeMode = ImeMode.NoControl;
            comboBoxChooseEmployee.Items.AddRange(new object[] { "Consultant", "Manager" });
            comboBoxChooseEmployee.Location = new Point(320, 380);
            comboBoxChooseEmployee.Margin = new Padding(3, 4, 3, 4);
            comboBoxChooseEmployee.Name = "comboBoxChooseEmployee";
            comboBoxChooseEmployee.Size = new Size(273, 28);
            comboBoxChooseEmployee.TabIndex = 0;
            comboBoxChooseEmployee.SelectedIndexChanged += comboBoxChooseEmployee_SelectedIndexChanged;
            // 
            // buttonOpenMain
            // 
            buttonOpenMain.Enabled = false;
            buttonOpenMain.Location = new Point(389, 496);
            buttonOpenMain.Margin = new Padding(3, 4, 3, 4);
            buttonOpenMain.Name = "buttonOpenMain";
            buttonOpenMain.Size = new Size(135, 56);
            buttonOpenMain.TabIndex = 1;
            buttonOpenMain.Text = "Open";
            buttonOpenMain.UseVisualStyleBackColor = true;
            buttonOpenMain.Click += buttonOpenMain_Click;
            // 
            // pictureBoxJobTitle
            // 
            pictureBoxJobTitle.Location = new Point(389, 199);
            pictureBoxJobTitle.Margin = new Padding(3, 4, 3, 4);
            pictureBoxJobTitle.Name = "pictureBoxJobTitle";
            pictureBoxJobTitle.Size = new Size(135, 153);
            pictureBoxJobTitle.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBoxJobTitle.TabIndex = 2;
            pictureBoxJobTitle.TabStop = false;
            // 
            // FormChooseEmployee
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(914, 600);
            Controls.Add(pictureBoxJobTitle);
            Controls.Add(buttonOpenMain);
            Controls.Add(comboBoxChooseEmployee);
            FormBorderStyle = FormBorderStyle.Fixed3D;
            Margin = new Padding(3, 4, 3, 4);
            MaximizeBox = false;
            Name = "FormChooseEmployee";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Choose Employee";
            ((System.ComponentModel.ISupportInitialize)pictureBoxJobTitle).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private ComboBox comboBoxChooseEmployee;
        private Button buttonOpenMain;
        private PictureBox pictureBoxJobTitle;
    }
}
