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
            labelChangerOfData = new Label();
            labelChangerOfDataTitle = new Label();
            labelTypeOfChanges = new Label();
            labelTypeOfChangesTitle = new Label();
            labelChangedProperty = new Label();
            labelChangedPropertyTitle = new Label();
            labelLastChanges = new Label();
            labelLastChangesTitle = new Label();
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
            panelClientButtons = new Panel();
            buttonAddClient = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBoxJobTitle).BeginInit();
            panelClientInfo.SuspendLayout();
            panelAllMain.SuspendLayout();
            panelClientButtons.SuspendLayout();
            SuspendLayout();
            // 
            // pictureBoxJobTitle
            // 
            pictureBoxJobTitle.Location = new Point(35, 16);
            pictureBoxJobTitle.Margin = new Padding(3, 2, 3, 2);
            pictureBoxJobTitle.Name = "pictureBoxJobTitle";
            pictureBoxJobTitle.Size = new Size(113, 107);
            pictureBoxJobTitle.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBoxJobTitle.TabIndex = 0;
            pictureBoxJobTitle.TabStop = false;
            // 
            // labelJobTitle
            // 
            labelJobTitle.AutoSize = true;
            labelJobTitle.Location = new Point(64, 136);
            labelJobTitle.Name = "labelJobTitle";
            labelJobTitle.Size = new Size(38, 15);
            labelJobTitle.TabIndex = 1;
            labelJobTitle.Text = "label1";
            // 
            // comboBoxClients
            // 
            comboBoxClients.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            comboBoxClients.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxClients.FormattingEnabled = true;
            comboBoxClients.ImeMode = ImeMode.NoControl;
            comboBoxClients.Location = new Point(118, 13);
            comboBoxClients.Name = "comboBoxClients";
            comboBoxClients.Size = new Size(239, 23);
            comboBoxClients.TabIndex = 4;
            comboBoxClients.SelectedIndexChanged += comboBoxClients_SelectedIndexChanged;
            // 
            // panelClientInfo
            // 
            panelClientInfo.Controls.Add(labelChangerOfData);
            panelClientInfo.Controls.Add(labelChangerOfDataTitle);
            panelClientInfo.Controls.Add(labelTypeOfChanges);
            panelClientInfo.Controls.Add(labelTypeOfChangesTitle);
            panelClientInfo.Controls.Add(labelChangedProperty);
            panelClientInfo.Controls.Add(labelChangedPropertyTitle);
            panelClientInfo.Controls.Add(labelLastChanges);
            panelClientInfo.Controls.Add(labelLastChangesTitle);
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
            panelClientInfo.Location = new Point(0, 487);
            panelClientInfo.Margin = new Padding(3, 2, 3, 2);
            panelClientInfo.Name = "panelClientInfo";
            panelClientInfo.Size = new Size(1684, 304);
            panelClientInfo.TabIndex = 5;
            // 
            // labelChangerOfData
            // 
            labelChangerOfData.AutoSize = true;
            labelChangerOfData.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 204);
            labelChangerOfData.Location = new Point(148, 214);
            labelChangerOfData.Name = "labelChangerOfData";
            labelChangerOfData.Size = new Size(0, 17);
            labelChangerOfData.TabIndex = 22;
            // 
            // labelChangerOfDataTitle
            // 
            labelChangerOfDataTitle.AutoSize = true;
            labelChangerOfDataTitle.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 204);
            labelChangerOfDataTitle.Location = new Point(8, 210);
            labelChangerOfDataTitle.Name = "labelChangerOfDataTitle";
            labelChangerOfDataTitle.Size = new Size(132, 21);
            labelChangerOfDataTitle.TabIndex = 21;
            labelChangerOfDataTitle.Text = "Changer of Data:";
            // 
            // labelTypeOfChanges
            // 
            labelTypeOfChanges.AutoSize = true;
            labelTypeOfChanges.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 204);
            labelTypeOfChanges.Location = new Point(148, 193);
            labelTypeOfChanges.Name = "labelTypeOfChanges";
            labelTypeOfChanges.Size = new Size(0, 17);
            labelTypeOfChanges.TabIndex = 20;
            // 
            // labelTypeOfChangesTitle
            // 
            labelTypeOfChangesTitle.AutoSize = true;
            labelTypeOfChangesTitle.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 204);
            labelTypeOfChangesTitle.Location = new Point(8, 189);
            labelTypeOfChangesTitle.Name = "labelTypeOfChangesTitle";
            labelTypeOfChangesTitle.Size = new Size(131, 21);
            labelTypeOfChangesTitle.TabIndex = 19;
            labelTypeOfChangesTitle.Text = "Type of Changes:";
            // 
            // labelChangedProperty
            // 
            labelChangedProperty.AutoSize = true;
            labelChangedProperty.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 204);
            labelChangedProperty.Location = new Point(148, 171);
            labelChangedProperty.Name = "labelChangedProperty";
            labelChangedProperty.Size = new Size(0, 17);
            labelChangedProperty.TabIndex = 18;
            // 
            // labelChangedPropertyTitle
            // 
            labelChangedPropertyTitle.AutoSize = true;
            labelChangedPropertyTitle.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 204);
            labelChangedPropertyTitle.Location = new Point(8, 168);
            labelChangedPropertyTitle.Name = "labelChangedPropertyTitle";
            labelChangedPropertyTitle.Size = new Size(76, 21);
            labelChangedPropertyTitle.TabIndex = 17;
            labelChangedPropertyTitle.Text = "Property:";
            // 
            // labelLastChanges
            // 
            labelLastChanges.AutoSize = true;
            labelLastChanges.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 204);
            labelLastChanges.Location = new Point(148, 151);
            labelLastChanges.Name = "labelLastChanges";
            labelLastChanges.Size = new Size(0, 17);
            labelLastChanges.TabIndex = 16;
            // 
            // labelLastChangesTitle
            // 
            labelLastChangesTitle.AutoSize = true;
            labelLastChangesTitle.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 204);
            labelLastChangesTitle.Location = new Point(8, 147);
            labelLastChangesTitle.Name = "labelLastChangesTitle";
            labelLastChangesTitle.Size = new Size(109, 21);
            labelLastChangesTitle.TabIndex = 15;
            labelLastChangesTitle.Text = "Last Changes:";
            // 
            // buttonChangePassport
            // 
            buttonChangePassport.Enabled = false;
            buttonChangePassport.Location = new Point(394, 251);
            buttonChangePassport.Name = "buttonChangePassport";
            buttonChangePassport.Size = new Size(90, 43);
            buttonChangePassport.TabIndex = 14;
            buttonChangePassport.Text = "Change Passport";
            buttonChangePassport.UseVisualStyleBackColor = true;
            buttonChangePassport.Click += buttonChangePassport_Click;
            // 
            // buttonChangePatronymic
            // 
            buttonChangePatronymic.Enabled = false;
            buttonChangePatronymic.Location = new Point(208, 251);
            buttonChangePatronymic.Name = "buttonChangePatronymic";
            buttonChangePatronymic.Size = new Size(85, 43);
            buttonChangePatronymic.TabIndex = 13;
            buttonChangePatronymic.Text = "Change Patronymic";
            buttonChangePatronymic.UseVisualStyleBackColor = true;
            buttonChangePatronymic.Click += buttonChangePatronymic_Click;
            // 
            // buttonChangeName
            // 
            buttonChangeName.Enabled = false;
            buttonChangeName.Location = new Point(113, 251);
            buttonChangeName.Name = "buttonChangeName";
            buttonChangeName.Size = new Size(90, 43);
            buttonChangeName.TabIndex = 12;
            buttonChangeName.Text = "Change Name";
            buttonChangeName.UseVisualStyleBackColor = true;
            buttonChangeName.Click += buttonChangeName_Click;
            // 
            // buttonChangeSurname
            // 
            buttonChangeSurname.Enabled = false;
            buttonChangeSurname.Location = new Point(12, 251);
            buttonChangeSurname.Name = "buttonChangeSurname";
            buttonChangeSurname.Size = new Size(95, 43);
            buttonChangeSurname.TabIndex = 11;
            buttonChangeSurname.Text = "Change Surname";
            buttonChangeSurname.UseVisualStyleBackColor = true;
            buttonChangeSurname.Click += buttonChangeSurname_Click;
            // 
            // buttonChangePhone
            // 
            buttonChangePhone.Enabled = false;
            buttonChangePhone.Location = new Point(298, 251);
            buttonChangePhone.Name = "buttonChangePhone";
            buttonChangePhone.Size = new Size(90, 43);
            buttonChangePhone.TabIndex = 10;
            buttonChangePhone.Text = "Change Phone";
            buttonChangePhone.UseVisualStyleBackColor = true;
            buttonChangePhone.Click += buttonChangePhone_Click;
            // 
            // labelClientPassport
            // 
            labelClientPassport.AutoSize = true;
            labelClientPassport.Location = new Point(88, 109);
            labelClientPassport.Name = "labelClientPassport";
            labelClientPassport.Size = new Size(0, 15);
            labelClientPassport.TabIndex = 9;
            // 
            // labelClientPhone
            // 
            labelClientPhone.AutoSize = true;
            labelClientPhone.Location = new Point(88, 85);
            labelClientPhone.Name = "labelClientPhone";
            labelClientPhone.Size = new Size(0, 15);
            labelClientPhone.TabIndex = 8;
            // 
            // labelClientPatronymic
            // 
            labelClientPatronymic.AutoSize = true;
            labelClientPatronymic.Location = new Point(88, 62);
            labelClientPatronymic.Name = "labelClientPatronymic";
            labelClientPatronymic.Size = new Size(0, 15);
            labelClientPatronymic.TabIndex = 7;
            // 
            // labelClientName
            // 
            labelClientName.AutoSize = true;
            labelClientName.Location = new Point(88, 39);
            labelClientName.Name = "labelClientName";
            labelClientName.Size = new Size(0, 15);
            labelClientName.TabIndex = 6;
            // 
            // labelClientSurname
            // 
            labelClientSurname.AutoSize = true;
            labelClientSurname.Location = new Point(88, 16);
            labelClientSurname.Name = "labelClientSurname";
            labelClientSurname.Size = new Size(0, 15);
            labelClientSurname.TabIndex = 5;
            // 
            // labelPassportTitle
            // 
            labelPassportTitle.AutoSize = true;
            labelPassportTitle.Location = new Point(8, 109);
            labelPassportTitle.Name = "labelPassportTitle";
            labelPassportTitle.Size = new Size(55, 15);
            labelPassportTitle.TabIndex = 4;
            labelPassportTitle.Text = "Passport:";
            // 
            // labelPhoneTitle
            // 
            labelPhoneTitle.AutoSize = true;
            labelPhoneTitle.Location = new Point(8, 85);
            labelPhoneTitle.Name = "labelPhoneTitle";
            labelPhoneTitle.Size = new Size(44, 15);
            labelPhoneTitle.TabIndex = 3;
            labelPhoneTitle.Text = "Phone:";
            // 
            // labelClientPatronymicTitle
            // 
            labelClientPatronymicTitle.AutoSize = true;
            labelClientPatronymicTitle.Location = new Point(8, 62);
            labelClientPatronymicTitle.Name = "labelClientPatronymicTitle";
            labelClientPatronymicTitle.Size = new Size(71, 15);
            labelClientPatronymicTitle.TabIndex = 2;
            labelClientPatronymicTitle.Text = "Patronymic:";
            // 
            // labelClientSurnameTitle
            // 
            labelClientSurnameTitle.AutoSize = true;
            labelClientSurnameTitle.Location = new Point(8, 16);
            labelClientSurnameTitle.Name = "labelClientSurnameTitle";
            labelClientSurnameTitle.Size = new Size(57, 15);
            labelClientSurnameTitle.TabIndex = 1;
            labelClientSurnameTitle.Text = "Surname:";
            // 
            // labelClientNameTitle
            // 
            labelClientNameTitle.AutoSize = true;
            labelClientNameTitle.Location = new Point(8, 39);
            labelClientNameTitle.Name = "labelClientNameTitle";
            labelClientNameTitle.Size = new Size(42, 15);
            labelClientNameTitle.TabIndex = 0;
            labelClientNameTitle.Text = "Name:";
            // 
            // panelAllMain
            // 
            panelAllMain.BackColor = Color.Transparent;
            panelAllMain.Controls.Add(panelClientButtons);
            panelAllMain.Controls.Add(pictureBoxJobTitle);
            panelAllMain.Controls.Add(labelJobTitle);
            panelAllMain.Controls.Add(panelClientInfo);
            panelAllMain.Dock = DockStyle.Fill;
            panelAllMain.Location = new Point(0, 0);
            panelAllMain.Name = "panelAllMain";
            panelAllMain.Size = new Size(1684, 791);
            panelAllMain.TabIndex = 6;
            // 
            // panelClientButtons
            // 
            panelClientButtons.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            panelClientButtons.Controls.Add(buttonAddClient);
            panelClientButtons.Controls.Add(comboBoxClients);
            panelClientButtons.Location = new Point(1324, 3);
            panelClientButtons.Name = "panelClientButtons";
            panelClientButtons.Size = new Size(357, 57);
            panelClientButtons.TabIndex = 7;
            // 
            // buttonAddClient
            // 
            buttonAddClient.Enabled = false;
            buttonAddClient.Location = new Point(28, 3);
            buttonAddClient.Name = "buttonAddClient";
            buttonAddClient.Size = new Size(81, 41);
            buttonAddClient.TabIndex = 6;
            buttonAddClient.Text = "Add Client";
            buttonAddClient.UseVisualStyleBackColor = true;
            buttonAddClient.Click += buttonAddClient_Click;
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1684, 791);
            Controls.Add(panelAllMain);
            Name = "FormMain";
            Text = "FormMain";
            WindowState = FormWindowState.Maximized;
            Load += FormMain_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBoxJobTitle).EndInit();
            panelClientInfo.ResumeLayout(false);
            panelClientInfo.PerformLayout();
            panelAllMain.ResumeLayout(false);
            panelAllMain.PerformLayout();
            panelClientButtons.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private PictureBox pictureBoxJobTitle;
        private Label labelJobTitle;
        private ComboBox comboBoxClients;
        private Panel panelClientInfo;
        private Label labelTypeOfChanges;
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
        private Label labelChangedProperty;
        private Label labelChangedPropertyTitle;
        private Label labelLastChanges;
        private Label labelLastChangesTitle;
        private Label labelTypeOfChangesTitle;
        private Label labelChangerOfData;
        private Label labelChangerOfDataTitle;
        private Button buttonAddClient;
        private Panel panelClientButtons;
    }
}