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
            buttonChangePassport = new Button();
            buttonChangePatronymic = new Button();
            buttonChangeName = new Button();
            buttonChangeSurname = new Button();
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
            panelAllMain = new Panel();
            ((System.ComponentModel.ISupportInitialize)pictureBoxJobTitle).BeginInit();
            panelClientInfo.SuspendLayout();
            panelAllMain.SuspendLayout();
            SuspendLayout();
            // 
            // pictureBoxJobTitle
            // 
            pictureBoxJobTitle.Location = new Point(40, 21);
            pictureBoxJobTitle.Name = "pictureBoxJobTitle";
            pictureBoxJobTitle.Size = new Size(129, 143);
            pictureBoxJobTitle.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBoxJobTitle.TabIndex = 0;
            pictureBoxJobTitle.TabStop = false;
            // 
            // labelJobTitle
            // 
            labelJobTitle.AutoSize = true;
            labelJobTitle.Location = new Point(73, 181);
            labelJobTitle.Name = "labelJobTitle";
            labelJobTitle.Size = new Size(50, 20);
            labelJobTitle.TabIndex = 1;
            labelJobTitle.Text = "label1";
            // 
            // comboBoxClients
            // 
            comboBoxClients.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            comboBoxClients.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxClients.FormattingEnabled = true;
            comboBoxClients.ImeMode = ImeMode.NoControl;
            comboBoxClients.Location = new Point(1637, 21);
            comboBoxClients.Margin = new Padding(3, 4, 3, 4);
            comboBoxClients.Name = "comboBoxClients";
            comboBoxClients.Size = new Size(273, 28);
            comboBoxClients.TabIndex = 4;
            comboBoxClients.SelectedIndexChanged += comboBoxClients_SelectedIndexChanged;
            // 
            // panelClientInfo
            // 
            panelClientInfo.Controls.Add(buttonChangePassport);
            panelClientInfo.Controls.Add(buttonChangePatronymic);
            panelClientInfo.Controls.Add(buttonChangeName);
            panelClientInfo.Controls.Add(buttonChangeSurname);
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
            panelClientInfo.Dock = DockStyle.Bottom;
            panelClientInfo.Location = new Point(0, 650);
            panelClientInfo.Name = "panelClientInfo";
            panelClientInfo.Size = new Size(1924, 405);
            panelClientInfo.TabIndex = 5;
            // 
            // buttonChangePassport
            // 
            buttonChangePassport.Enabled = false;
            buttonChangePassport.Location = new Point(450, 335);
            buttonChangePassport.Margin = new Padding(3, 4, 3, 4);
            buttonChangePassport.Name = "buttonChangePassport";
            buttonChangePassport.Size = new Size(103, 57);
            buttonChangePassport.TabIndex = 14;
            buttonChangePassport.Text = "Change Passport";
            buttonChangePassport.UseVisualStyleBackColor = true;
            buttonChangePassport.Click += buttonChangePassport_Click;
            // 
            // buttonChangePatronymic
            // 
            buttonChangePatronymic.Enabled = false;
            buttonChangePatronymic.Location = new Point(238, 335);
            buttonChangePatronymic.Margin = new Padding(3, 4, 3, 4);
            buttonChangePatronymic.Name = "buttonChangePatronymic";
            buttonChangePatronymic.Size = new Size(97, 57);
            buttonChangePatronymic.TabIndex = 13;
            buttonChangePatronymic.Text = "Change Patronymic";
            buttonChangePatronymic.UseVisualStyleBackColor = true;
            buttonChangePatronymic.Click += buttonChangePatronymic_Click;
            // 
            // buttonChangeName
            // 
            buttonChangeName.Enabled = false;
            buttonChangeName.Location = new Point(129, 335);
            buttonChangeName.Margin = new Padding(3, 4, 3, 4);
            buttonChangeName.Name = "buttonChangeName";
            buttonChangeName.Size = new Size(103, 57);
            buttonChangeName.TabIndex = 12;
            buttonChangeName.Text = "Change Name";
            buttonChangeName.UseVisualStyleBackColor = true;
            buttonChangeName.Click += buttonChangeName_Click;
            // 
            // buttonChangeSurname
            // 
            buttonChangeSurname.Enabled = false;
            buttonChangeSurname.Location = new Point(14, 335);
            buttonChangeSurname.Margin = new Padding(3, 4, 3, 4);
            buttonChangeSurname.Name = "buttonChangeSurname";
            buttonChangeSurname.Size = new Size(109, 57);
            buttonChangeSurname.TabIndex = 11;
            buttonChangeSurname.Text = "Change Surname";
            buttonChangeSurname.UseVisualStyleBackColor = true;
            buttonChangeSurname.Click += buttonChangeSurname_Click;
            // 
            // buttonChangePhone
            // 
            buttonChangePhone.Enabled = false;
            buttonChangePhone.Location = new Point(341, 335);
            buttonChangePhone.Margin = new Padding(3, 4, 3, 4);
            buttonChangePhone.Name = "buttonChangePhone";
            buttonChangePhone.Size = new Size(103, 57);
            buttonChangePhone.TabIndex = 10;
            buttonChangePhone.Text = "Change Phone";
            buttonChangePhone.UseVisualStyleBackColor = true;
            buttonChangePhone.Click += buttonChangePhone_Click;
            // 
            // labelClientPassport
            // 
            labelClientPassport.AutoSize = true;
            labelClientPassport.Location = new Point(105, 301);
            labelClientPassport.Name = "labelClientPassport";
            labelClientPassport.Size = new Size(0, 20);
            labelClientPassport.TabIndex = 9;
            // 
            // labelClientPhone
            // 
            labelClientPhone.AutoSize = true;
            labelClientPhone.Location = new Point(105, 269);
            labelClientPhone.Name = "labelClientPhone";
            labelClientPhone.Size = new Size(0, 20);
            labelClientPhone.TabIndex = 8;
            // 
            // labelClientPatronymic
            // 
            labelClientPatronymic.AutoSize = true;
            labelClientPatronymic.Location = new Point(105, 239);
            labelClientPatronymic.Name = "labelClientPatronymic";
            labelClientPatronymic.Size = new Size(0, 20);
            labelClientPatronymic.TabIndex = 7;
            // 
            // labelClientName
            // 
            labelClientName.AutoSize = true;
            labelClientName.Location = new Point(105, 208);
            labelClientName.Name = "labelClientName";
            labelClientName.Size = new Size(0, 20);
            labelClientName.TabIndex = 6;
            // 
            // labelClientSurname
            // 
            labelClientSurname.AutoSize = true;
            labelClientSurname.Location = new Point(105, 177);
            labelClientSurname.Name = "labelClientSurname";
            labelClientSurname.Size = new Size(0, 20);
            labelClientSurname.TabIndex = 5;
            // 
            // labelPassportTitle
            // 
            labelPassportTitle.AutoSize = true;
            labelPassportTitle.Location = new Point(14, 301);
            labelPassportTitle.Name = "labelPassportTitle";
            labelPassportTitle.Size = new Size(67, 20);
            labelPassportTitle.TabIndex = 4;
            labelPassportTitle.Text = "Passport:";
            // 
            // labelPhoneTitle
            // 
            labelPhoneTitle.AutoSize = true;
            labelPhoneTitle.Location = new Point(14, 269);
            labelPhoneTitle.Name = "labelPhoneTitle";
            labelPhoneTitle.Size = new Size(53, 20);
            labelPhoneTitle.TabIndex = 3;
            labelPhoneTitle.Text = "Phone:";
            // 
            // labelClientPatronymicTitle
            // 
            labelClientPatronymicTitle.AutoSize = true;
            labelClientPatronymicTitle.Location = new Point(14, 239);
            labelClientPatronymicTitle.Name = "labelClientPatronymicTitle";
            labelClientPatronymicTitle.Size = new Size(85, 20);
            labelClientPatronymicTitle.TabIndex = 2;
            labelClientPatronymicTitle.Text = "Patronymic:";
            // 
            // labelClientSurnameTitle
            // 
            labelClientSurnameTitle.AutoSize = true;
            labelClientSurnameTitle.Location = new Point(14, 177);
            labelClientSurnameTitle.Name = "labelClientSurnameTitle";
            labelClientSurnameTitle.Size = new Size(70, 20);
            labelClientSurnameTitle.TabIndex = 1;
            labelClientSurnameTitle.Text = "Surname:";
            // 
            // labelClientNameTitle
            // 
            labelClientNameTitle.AutoSize = true;
            labelClientNameTitle.Location = new Point(14, 208);
            labelClientNameTitle.Name = "labelClientNameTitle";
            labelClientNameTitle.Size = new Size(52, 20);
            labelClientNameTitle.TabIndex = 0;
            labelClientNameTitle.Text = "Name:";
            // 
            // panelAllMain
            // 
            panelAllMain.BackColor = Color.Transparent;
            panelAllMain.Controls.Add(pictureBoxJobTitle);
            panelAllMain.Controls.Add(labelJobTitle);
            panelAllMain.Controls.Add(comboBoxClients);
            panelAllMain.Controls.Add(panelClientInfo);
            panelAllMain.Dock = DockStyle.Fill;
            panelAllMain.Location = new Point(0, 0);
            panelAllMain.Margin = new Padding(3, 4, 3, 4);
            panelAllMain.Name = "panelAllMain";
            panelAllMain.Size = new Size(1924, 1055);
            panelAllMain.TabIndex = 6;
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1924, 1055);
            Controls.Add(panelAllMain);
            Margin = new Padding(3, 4, 3, 4);
            Name = "FormMain";
            Text = "FormMain";
            WindowState = FormWindowState.Maximized;
            Load += FormMain_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBoxJobTitle).EndInit();
            panelClientInfo.ResumeLayout(false);
            panelClientInfo.PerformLayout();
            panelAllMain.ResumeLayout(false);
            panelAllMain.PerformLayout();
            ResumeLayout(false);
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
        private Panel panelAllMain;
        private Button buttonChangeSurname;
        private Button buttonChangeName;
        private Button buttonChangePassport;
        private Button buttonChangePatronymic;
    }
}