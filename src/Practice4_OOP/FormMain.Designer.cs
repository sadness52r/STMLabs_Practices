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
            buttonChangePhone = new Button();
            labelClientPassport = new Label();
            labelClientPhone = new Label();
            labelClientPatronymic = new Label();
            labelClientName = new Label();
            labelClientSurname = new Label();
            labelPassportTitle = new Label();
            labelPhoneTitle = new Label();
            labelClientPatronymicTitle = new Label();
            labelClientSurnameTitle = new Label();
            labelClientNameTitle = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBoxJobTitle).BeginInit();
            panelClientInfo.SuspendLayout();
            SuspendLayout();
            // 
            // pictureBoxJobTitle
            // 
            pictureBoxJobTitle.Location = new Point(30, 16);
            pictureBoxJobTitle.Margin = new Padding(3, 2, 3, 2);
            pictureBoxJobTitle.Name = "pictureBoxJobTitle";
            pictureBoxJobTitle.Size = new Size(150, 88);
            pictureBoxJobTitle.TabIndex = 0;
            pictureBoxJobTitle.TabStop = false;
            // 
            // labelJobTitle
            // 
            labelJobTitle.AutoSize = true;
            labelJobTitle.Location = new Point(76, 114);
            labelJobTitle.Name = "labelJobTitle";
            labelJobTitle.Size = new Size(38, 15);
            labelJobTitle.TabIndex = 1;
            labelJobTitle.Text = "label1";
            // 
            // comboBoxClients
            // 
            comboBoxClients.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxClients.FormattingEnabled = true;
            comboBoxClients.ImeMode = ImeMode.NoControl;
            comboBoxClients.Location = new Point(1434, 46);
            comboBoxClients.Name = "comboBoxClients";
            comboBoxClients.Size = new Size(239, 23);
            comboBoxClients.TabIndex = 4;
            comboBoxClients.SelectedIndexChanged += comboBoxClients_SelectedIndexChanged;
            // 
            // panelClientInfo
            // 
            panelClientInfo.Controls.Add(buttonChangePhone);
            panelClientInfo.Controls.Add(labelClientPassport);
            panelClientInfo.Controls.Add(labelClientPhone);
            panelClientInfo.Controls.Add(labelClientPatronymic);
            panelClientInfo.Controls.Add(labelClientName);
            panelClientInfo.Controls.Add(labelClientSurname);
            panelClientInfo.Controls.Add(labelPassportTitle);
            panelClientInfo.Controls.Add(labelPhoneTitle);
            panelClientInfo.Controls.Add(labelClientPatronymicTitle);
            panelClientInfo.Controls.Add(labelClientSurnameTitle);
            panelClientInfo.Controls.Add(labelClientNameTitle);
            panelClientInfo.Location = new Point(4, 489);
            panelClientInfo.Margin = new Padding(3, 2, 3, 2);
            panelClientInfo.Name = "panelClientInfo";
            panelClientInfo.Size = new Size(1676, 304);
            panelClientInfo.TabIndex = 5;
            // 
            // buttonChangePhone
            // 
            buttonChangePhone.Enabled = false;
            buttonChangePhone.Location = new Point(7, 124);
            buttonChangePhone.Name = "buttonChangePhone";
            buttonChangePhone.Size = new Size(102, 48);
            buttonChangePhone.TabIndex = 10;
            buttonChangePhone.Text = "Change Phone";
            buttonChangePhone.UseVisualStyleBackColor = true;
            buttonChangePhone.Click += buttonChangePhone_Click;
            // 
            // labelClientPassport
            // 
            labelClientPassport.AutoSize = true;
            labelClientPassport.Location = new Point(102, 106);
            labelClientPassport.Name = "labelClientPassport";
            labelClientPassport.Size = new Size(0, 15);
            labelClientPassport.TabIndex = 9;
            // 
            // labelClientPhone
            // 
            labelClientPhone.AutoSize = true;
            labelClientPhone.Location = new Point(102, 82);
            labelClientPhone.Name = "labelClientPhone";
            labelClientPhone.Size = new Size(0, 15);
            labelClientPhone.TabIndex = 8;
            // 
            // labelClientPatronymic
            // 
            labelClientPatronymic.AutoSize = true;
            labelClientPatronymic.Location = new Point(102, 59);
            labelClientPatronymic.Name = "labelClientPatronymic";
            labelClientPatronymic.Size = new Size(0, 15);
            labelClientPatronymic.TabIndex = 7;
            // 
            // labelClientName
            // 
            labelClientName.AutoSize = true;
            labelClientName.Location = new Point(102, 36);
            labelClientName.Name = "labelClientName";
            labelClientName.Size = new Size(0, 15);
            labelClientName.TabIndex = 6;
            // 
            // labelClientSurname
            // 
            labelClientSurname.AutoSize = true;
            labelClientSurname.Location = new Point(102, 13);
            labelClientSurname.Name = "labelClientSurname";
            labelClientSurname.Size = new Size(0, 15);
            labelClientSurname.TabIndex = 5;
            // 
            // labelPassportTitle
            // 
            labelPassportTitle.AutoSize = true;
            labelPassportTitle.Location = new Point(7, 106);
            labelPassportTitle.Name = "labelPassportTitle";
            labelPassportTitle.Size = new Size(55, 15);
            labelPassportTitle.TabIndex = 4;
            labelPassportTitle.Text = "Passport:";
            // 
            // labelPhoneTitle
            // 
            labelPhoneTitle.AutoSize = true;
            labelPhoneTitle.Location = new Point(7, 82);
            labelPhoneTitle.Name = "labelPhoneTitle";
            labelPhoneTitle.Size = new Size(44, 15);
            labelPhoneTitle.TabIndex = 3;
            labelPhoneTitle.Text = "Phone:";
            // 
            // labelClientPatronymicTitle
            // 
            labelClientPatronymicTitle.AutoSize = true;
            labelClientPatronymicTitle.Location = new Point(7, 59);
            labelClientPatronymicTitle.Name = "labelClientPatronymicTitle";
            labelClientPatronymicTitle.Size = new Size(71, 15);
            labelClientPatronymicTitle.TabIndex = 2;
            labelClientPatronymicTitle.Text = "Patronymic:";
            // 
            // labelClientSurnameTitle
            // 
            labelClientSurnameTitle.AutoSize = true;
            labelClientSurnameTitle.Location = new Point(7, 13);
            labelClientSurnameTitle.Name = "labelClientSurnameTitle";
            labelClientSurnameTitle.Size = new Size(57, 15);
            labelClientSurnameTitle.TabIndex = 1;
            labelClientSurnameTitle.Text = "Surname:";
            // 
            // labelClientNameTitle
            // 
            labelClientNameTitle.AutoSize = true;
            labelClientNameTitle.Location = new Point(7, 36);
            labelClientNameTitle.Name = "labelClientNameTitle";
            labelClientNameTitle.Size = new Size(42, 15);
            labelClientNameTitle.TabIndex = 0;
            labelClientNameTitle.Text = "Name:";
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1684, 931);
            Controls.Add(panelClientInfo);
            Controls.Add(comboBoxClients);
            Controls.Add(labelJobTitle);
            Controls.Add(pictureBoxJobTitle);
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
        private Label labelClientPassport;
        private Label labelClientPhone;
        private Label labelClientPatronymic;
        private Label labelClientName;
        private Label labelClientSurname;
        private Button buttonChangePhone;
    }
}