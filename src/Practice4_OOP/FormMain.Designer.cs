namespace Practice4_OOP
{
    partial class FormMain
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
            pictureBoxJobTitle = new PictureBox();
            labelJobTitle = new Label();
            comboBoxClients = new ComboBox();
            panelClientInfo = new Panel();
            labelClientNameTitle = new Label();
            labelClientSurnameTitle = new Label();
            labelClientPatronymicTitle = new Label();
            labelPhoneTitle = new Label();
            labelPassportTitle = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBoxJobTitle).BeginInit();
            panelClientInfo.SuspendLayout();
            SuspendLayout();
            // 
            // pictureBoxJobTitle
            // 
            pictureBoxJobTitle.Location = new Point(34, 22);
            pictureBoxJobTitle.Name = "pictureBoxJobTitle";
            pictureBoxJobTitle.Size = new Size(171, 118);
            pictureBoxJobTitle.TabIndex = 0;
            pictureBoxJobTitle.TabStop = false;
            // 
            // labelJobTitle
            // 
            labelJobTitle.AutoSize = true;
            labelJobTitle.Location = new Point(87, 152);
            labelJobTitle.Name = "labelJobTitle";
            labelJobTitle.Size = new Size(50, 20);
            labelJobTitle.TabIndex = 1;
            labelJobTitle.Text = "label1";
            // 
            // comboBoxClients
            // 
            comboBoxClients.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxClients.FormattingEnabled = true;
            comboBoxClients.ImeMode = ImeMode.NoControl;
            comboBoxClients.Location = new Point(1639, 62);
            comboBoxClients.Margin = new Padding(3, 4, 3, 4);
            comboBoxClients.Name = "comboBoxClients";
            comboBoxClients.Size = new Size(273, 28);
            comboBoxClients.TabIndex = 4;
            comboBoxClients.SelectedIndexChanged += comboBoxClients_SelectedIndexChanged;
            // 
            // panelClientInfo
            // 
            panelClientInfo.Controls.Add(labelPassportTitle);
            panelClientInfo.Controls.Add(labelPhoneTitle);
            panelClientInfo.Controls.Add(labelClientPatronymicTitle);
            panelClientInfo.Controls.Add(labelClientSurnameTitle);
            panelClientInfo.Controls.Add(labelClientNameTitle);
            panelClientInfo.Location = new Point(4, 652);
            panelClientInfo.Name = "panelClientInfo";
            panelClientInfo.Size = new Size(1916, 405);
            panelClientInfo.TabIndex = 5;
            // 
            // labelClientNameTitle
            // 
            labelClientNameTitle.AutoSize = true;
            labelClientNameTitle.Location = new Point(8, 48);
            labelClientNameTitle.Name = "labelClientNameTitle";
            labelClientNameTitle.Size = new Size(52, 20);
            labelClientNameTitle.TabIndex = 0;
            labelClientNameTitle.Text = "Name:";
            // 
            // labelClientSurnameTitle
            // 
            labelClientSurnameTitle.AutoSize = true;
            labelClientSurnameTitle.Location = new Point(8, 17);
            labelClientSurnameTitle.Name = "labelClientSurnameTitle";
            labelClientSurnameTitle.Size = new Size(70, 20);
            labelClientSurnameTitle.TabIndex = 1;
            labelClientSurnameTitle.Text = "Surname:";
            // 
            // labelClientPatronymicTitle
            // 
            labelClientPatronymicTitle.AutoSize = true;
            labelClientPatronymicTitle.Location = new Point(8, 79);
            labelClientPatronymicTitle.Name = "labelClientPatronymicTitle";
            labelClientPatronymicTitle.Size = new Size(85, 20);
            labelClientPatronymicTitle.TabIndex = 2;
            labelClientPatronymicTitle.Text = "Patronymic:";
            // 
            // labelPhoneTitle
            // 
            labelPhoneTitle.AutoSize = true;
            labelPhoneTitle.Location = new Point(8, 110);
            labelPhoneTitle.Name = "labelPhoneTitle";
            labelPhoneTitle.Size = new Size(53, 20);
            labelPhoneTitle.TabIndex = 3;
            labelPhoneTitle.Text = "Phone:";
            // 
            // labelPassportTitle
            // 
            labelPassportTitle.AutoSize = true;
            labelPassportTitle.Location = new Point(8, 141);
            labelPassportTitle.Name = "labelPassportTitle";
            labelPassportTitle.Size = new Size(67, 20);
            labelPassportTitle.TabIndex = 4;
            labelPassportTitle.Text = "Passport:";
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1924, 1055);
            Controls.Add(panelClientInfo);
            Controls.Add(comboBoxClients);
            Controls.Add(labelJobTitle);
            Controls.Add(pictureBoxJobTitle);
            Margin = new Padding(3, 4, 3, 4);
            Name = "FormMain";
            Text = "FormMain";
            WindowState = FormWindowState.Maximized;
            Load += FormMain_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBoxJobTitle).EndInit();
            panelClientInfo.ResumeLayout(false);
            panelClientInfo.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBoxJobTitle;
        private Label labelJobTitle;
        private ComboBox comboBoxClients;
        private Panel panelClientInfo;
        private Label label1;
        private Label labelPassportTitle;
        private Label labelPhoneTitle;
        private Label labelClientPatronymicTitle;
        private Label labelClientSurnameTitle;
        private Label labelClientNameTitle;
    }
}