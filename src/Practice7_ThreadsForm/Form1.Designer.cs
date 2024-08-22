namespace Practice7_ThreadsForm
{
    partial class Form1
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
            buttonStart = new Button();
            numericUpDownNThreads = new NumericUpDown();
            listBoxFileText = new ListBox();
            comboBoxTasks = new ComboBox();
            buttonStop = new Button();
            listBox1 = new ListBox();
            ((System.ComponentModel.ISupportInitialize)numericUpDownNThreads).BeginInit();
            SuspendLayout();
            // 
            // buttonStart
            // 
            buttonStart.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 204);
            buttonStart.Location = new Point(12, 358);
            buttonStart.Name = "buttonStart";
            buttonStart.Size = new Size(187, 80);
            buttonStart.TabIndex = 0;
            buttonStart.Text = "START";
            buttonStart.UseVisualStyleBackColor = true;
            buttonStart.Click += buttonStart_Click;
            // 
            // numericUpDownNThreads
            // 
            numericUpDownNThreads.Enabled = false;
            numericUpDownNThreads.Location = new Point(12, 12);
            numericUpDownNThreads.Name = "numericUpDownNThreads";
            numericUpDownNThreads.Size = new Size(120, 23);
            numericUpDownNThreads.TabIndex = 1;
            // 
            // listBoxFileText
            // 
            listBoxFileText.FormattingEnabled = true;
            listBoxFileText.ItemHeight = 15;
            listBoxFileText.Location = new Point(428, 12);
            listBoxFileText.Name = "listBoxFileText";
            listBoxFileText.Size = new Size(360, 319);
            listBoxFileText.TabIndex = 2;
            // 
            // comboBoxTasks
            // 
            comboBoxTasks.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxTasks.FormattingEnabled = true;
            comboBoxTasks.Location = new Point(234, 12);
            comboBoxTasks.Name = "comboBoxTasks";
            comboBoxTasks.Size = new Size(188, 23);
            comboBoxTasks.TabIndex = 3;
            // 
            // buttonStop
            // 
            buttonStop.Enabled = false;
            buttonStop.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 204);
            buttonStop.Location = new Point(205, 358);
            buttonStop.Name = "buttonStop";
            buttonStop.Size = new Size(187, 80);
            buttonStop.TabIndex = 4;
            buttonStop.Text = "STOP";
            buttonStop.UseVisualStyleBackColor = true;
            buttonStop.Click += buttonStop_Click;
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 15;
            listBox1.Location = new Point(12, 80);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(234, 214);
            listBox1.TabIndex = 5;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(listBox1);
            Controls.Add(buttonStop);
            Controls.Add(comboBoxTasks);
            Controls.Add(listBoxFileText);
            Controls.Add(numericUpDownNThreads);
            Controls.Add(buttonStart);
            Name = "Form1";
            Text = "Form1";
            FormClosing += Form1_FormClosing;
            ((System.ComponentModel.ISupportInitialize)numericUpDownNThreads).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button buttonStart;
        private NumericUpDown numericUpDownNThreads;
        public ListBox listBoxFileText;
        private ComboBox comboBoxTasks;
        public ListBox listBox1;
        public Button buttonStop;
    }
}
