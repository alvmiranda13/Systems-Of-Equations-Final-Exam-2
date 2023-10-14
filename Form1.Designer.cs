namespace fin1
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
            inputBox = new ComboBox();
            solveBtn = new Button();
            browseBtn = new Button();
            lineAtextBox1 = new TextBox();
            lineAtextBox2 = new TextBox();
            lineAtextBox3 = new TextBox();
            label1 = new Label();
            lineBtextBox3 = new TextBox();
            lineBtextBox2 = new TextBox();
            lineBtextBox1 = new TextBox();
            label2 = new Label();
            resultLabel = new Label();
            fileTextBox = new TextBox();
            coeffBox = new GroupBox();
            fileBox = new GroupBox();
            fileBox.SuspendLayout();
            SuspendLayout();
            // 
            // inputBox
            // 
            inputBox.FormattingEnabled = true;
            inputBox.Items.AddRange(new object[] { "Input Coefficients", "File Input" });
            inputBox.Location = new Point(37, 38);
            inputBox.Name = "inputBox";
            inputBox.Size = new Size(121, 23);
            inputBox.TabIndex = 0;
            inputBox.Text = "Select Mode";
            inputBox.SelectedIndexChanged += inputTypeComboBox_SelectedIndexChanged;
            // 
            // solveBtn
            // 
            solveBtn.Location = new Point(305, 376);
            solveBtn.Name = "solveBtn";
            solveBtn.Size = new Size(75, 23);
            solveBtn.TabIndex = 1;
            solveBtn.Text = "Solve";
            solveBtn.UseVisualStyleBackColor = true;
            solveBtn.Click += solveBtn_Click;
            // 
            // browseBtn
            // 
            browseBtn.Location = new Point(194, 51);
            browseBtn.Name = "browseBtn";
            browseBtn.Size = new Size(75, 23);
            browseBtn.TabIndex = 2;
            browseBtn.Text = "Browse";
            browseBtn.UseVisualStyleBackColor = true;
            browseBtn.Click += browseBtn_Click;
            // 
            // lineAtextBox1
            // 
            lineAtextBox1.Location = new Point(164, 86);
            lineAtextBox1.Name = "lineAtextBox1";
            lineAtextBox1.Size = new Size(132, 23);
            lineAtextBox1.TabIndex = 3;
            // 
            // lineAtextBox2
            // 
            lineAtextBox2.Location = new Point(164, 116);
            lineAtextBox2.Name = "lineAtextBox2";
            lineAtextBox2.Size = new Size(132, 23);
            lineAtextBox2.TabIndex = 4;
            // 
            // lineAtextBox3
            // 
            lineAtextBox3.Location = new Point(164, 145);
            lineAtextBox3.Name = "lineAtextBox3";
            lineAtextBox3.Size = new Size(132, 23);
            lineAtextBox3.TabIndex = 5;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(120, 89);
            label1.Name = "label1";
            label1.Size = new Size(38, 15);
            label1.TabIndex = 6;
            label1.Text = "Line 1";
            // 
            // lineBtextBox3
            // 
            lineBtextBox3.Location = new Point(403, 145);
            lineBtextBox3.Name = "lineBtextBox3";
            lineBtextBox3.Size = new Size(132, 23);
            lineBtextBox3.TabIndex = 7;
            // 
            // lineBtextBox2
            // 
            lineBtextBox2.Location = new Point(403, 116);
            lineBtextBox2.Name = "lineBtextBox2";
            lineBtextBox2.Size = new Size(132, 23);
            lineBtextBox2.TabIndex = 8;
            // 
            // lineBtextBox1
            // 
            lineBtextBox1.Location = new Point(403, 83);
            lineBtextBox1.Name = "lineBtextBox1";
            lineBtextBox1.Size = new Size(132, 23);
            lineBtextBox1.TabIndex = 9;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(349, 86);
            label2.Name = "label2";
            label2.Size = new Size(38, 15);
            label2.TabIndex = 10;
            label2.Text = "Line 2";
            // 
            // resultLabel
            // 
            resultLabel.AutoSize = true;
            resultLabel.Location = new Point(120, 221);
            resultLabel.Name = "resultLabel";
            resultLabel.Size = new Size(82, 15);
            resultLabel.TabIndex = 11;
            resultLabel.Text = "Result is here. ";
            // 
            // fileTextBox
            // 
            fileTextBox.Enabled = false;
            fileTextBox.Location = new Point(53, 22);
            fileTextBox.Name = "fileTextBox";
            fileTextBox.ReadOnly = true;
            fileTextBox.Size = new Size(398, 23);
            fileTextBox.TabIndex = 12;
            // 
            // coeffBox
            // 
            coeffBox.Location = new Point(111, 67);
            coeffBox.Name = "coeffBox";
            coeffBox.Size = new Size(478, 116);
            coeffBox.TabIndex = 13;
            coeffBox.TabStop = false;
            coeffBox.Text = "Coefficients";
            // 
            // fileBox
            // 
            fileBox.Controls.Add(fileTextBox);
            fileBox.Controls.Add(browseBtn);
            fileBox.Location = new Point(111, 269);
            fileBox.Name = "fileBox";
            fileBox.Size = new Size(478, 86);
            fileBox.TabIndex = 14;
            fileBox.TabStop = false;
            fileBox.Text = "Files";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(617, 414);
            Controls.Add(resultLabel);
            Controls.Add(label2);
            Controls.Add(lineBtextBox1);
            Controls.Add(lineBtextBox2);
            Controls.Add(lineBtextBox3);
            Controls.Add(label1);
            Controls.Add(lineAtextBox3);
            Controls.Add(lineAtextBox2);
            Controls.Add(lineAtextBox1);
            Controls.Add(solveBtn);
            Controls.Add(inputBox);
            Controls.Add(fileBox);
            Controls.Add(coeffBox);
            Name = "Form1";
            Text = "Systems Of Equations";
            Load += Form1_Load;
            fileBox.ResumeLayout(false);
            fileBox.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox inputBox;
        private Button solveBtn;
        private Button browseBtn;
        private TextBox lineAtextBox1;
        private TextBox lineAtextBox2;
        private TextBox lineAtextBox3;
        private Label label1;
        private TextBox lineBtextBox3;
        private TextBox lineBtextBox2;
        private TextBox lineBtextBox1;
        private Label label2;
        private Label resultLabel;
        private TextBox fileTextBox;
        private GroupBox coeffBox;
        private GroupBox fileBox;
    }
}