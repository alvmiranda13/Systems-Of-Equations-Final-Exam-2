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
            inputTypeComboBox = new ComboBox();
            solveButton = new Button();
            browseButton = new Button();
            line1CoeffTextBox1 = new TextBox();
            line1CoeffTextBox2 = new TextBox();
            line1CoeffTextBox3 = new TextBox();
            label1 = new Label();
            line2CoeffTextBox3 = new TextBox();
            line2CoeffTextBox2 = new TextBox();
            line2CoeffTextBox1 = new TextBox();
            label2 = new Label();
            resultLabel = new Label();
            fileTextBox = new TextBox();
            coefficientsGroupBox = new GroupBox();
            fileGroupBox = new GroupBox();
            SuspendLayout();
            // 
            // inputTypeComboBox
            // 
            inputTypeComboBox.FormattingEnabled = true;
            inputTypeComboBox.Items.AddRange(new object[] { "Input Coefficients", "File Input" });
            inputTypeComboBox.Location = new Point(30, 116);
            inputTypeComboBox.Name = "inputTypeComboBox";
            inputTypeComboBox.Size = new Size(121, 23);
            inputTypeComboBox.TabIndex = 0;
            inputTypeComboBox.SelectedIndexChanged += inputTypeComboBox_SelectedIndexChanged;
            // 
            // solveButton
            // 
            solveButton.Location = new Point(638, 183);
            solveButton.Name = "solveButton";
            solveButton.Size = new Size(75, 23);
            solveButton.TabIndex = 1;
            solveButton.Text = "Solve";
            solveButton.UseVisualStyleBackColor = true;
            solveButton.Click += solveButton_Click;
            // 
            // browseButton
            // 
            browseButton.Location = new Point(638, 212);
            browseButton.Name = "browseButton";
            browseButton.Size = new Size(75, 23);
            browseButton.TabIndex = 2;
            browseButton.Text = "Browse";
            browseButton.UseVisualStyleBackColor = true;
            browseButton.Click += browseButton_Click;
            // 
            // line1CoeffTextBox1
            // 
            line1CoeffTextBox1.Location = new Point(231, 152);
            line1CoeffTextBox1.Name = "line1CoeffTextBox1";
            line1CoeffTextBox1.Size = new Size(100, 23);
            line1CoeffTextBox1.TabIndex = 3;
            // 
            // line1CoeffTextBox2
            // 
            line1CoeffTextBox2.Location = new Point(367, 152);
            line1CoeffTextBox2.Name = "line1CoeffTextBox2";
            line1CoeffTextBox2.Size = new Size(100, 23);
            line1CoeffTextBox2.TabIndex = 4;
            // 
            // line1CoeffTextBox3
            // 
            line1CoeffTextBox3.Location = new Point(487, 152);
            line1CoeffTextBox3.Name = "line1CoeffTextBox3";
            line1CoeffTextBox3.Size = new Size(100, 23);
            line1CoeffTextBox3.TabIndex = 5;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(148, 155);
            label1.Name = "label1";
            label1.Size = new Size(38, 15);
            label1.TabIndex = 6;
            label1.Text = "Line 1";
            // 
            // line2CoeffTextBox3
            // 
            line2CoeffTextBox3.Location = new Point(487, 194);
            line2CoeffTextBox3.Name = "line2CoeffTextBox3";
            line2CoeffTextBox3.Size = new Size(100, 23);
            line2CoeffTextBox3.TabIndex = 7;
            // 
            // line2CoeffTextBox2
            // 
            line2CoeffTextBox2.Location = new Point(367, 194);
            line2CoeffTextBox2.Name = "line2CoeffTextBox2";
            line2CoeffTextBox2.Size = new Size(100, 23);
            line2CoeffTextBox2.TabIndex = 8;
            // 
            // line2CoeffTextBox1
            // 
            line2CoeffTextBox1.Location = new Point(231, 194);
            line2CoeffTextBox1.Name = "line2CoeffTextBox1";
            line2CoeffTextBox1.Size = new Size(100, 23);
            line2CoeffTextBox1.TabIndex = 9;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(148, 202);
            label2.Name = "label2";
            label2.Size = new Size(38, 15);
            label2.TabIndex = 10;
            label2.Text = "Line 2";
            // 
            // resultLabel
            // 
            resultLabel.AutoSize = true;
            resultLabel.Location = new Point(367, 240);
            resultLabel.Name = "resultLabel";
            resultLabel.Size = new Size(82, 15);
            resultLabel.TabIndex = 11;
            resultLabel.Text = "Result is here. ";
            // 
            // fileTextBox
            // 
            fileTextBox.Location = new Point(30, 309);
            fileTextBox.Name = "fileTextBox";
            fileTextBox.Size = new Size(457, 23);
            fileTextBox.TabIndex = 12;
            // 
            // coefficientsGroupBox
            // 
            coefficientsGroupBox.Location = new Point(30, 338);
            coefficientsGroupBox.Name = "coefficientsGroupBox";
            coefficientsGroupBox.Size = new Size(200, 100);
            coefficientsGroupBox.TabIndex = 13;
            coefficientsGroupBox.TabStop = false;
            coefficientsGroupBox.Text = "Coefficients";
            // 
            // fileGroupBox
            // 
            fileGroupBox.Location = new Point(287, 338);
            fileGroupBox.Name = "fileGroupBox";
            fileGroupBox.Size = new Size(200, 100);
            fileGroupBox.TabIndex = 14;
            fileGroupBox.TabStop = false;
            fileGroupBox.Text = "Files";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(fileGroupBox);
            Controls.Add(coefficientsGroupBox);
            Controls.Add(fileTextBox);
            Controls.Add(resultLabel);
            Controls.Add(label2);
            Controls.Add(line2CoeffTextBox1);
            Controls.Add(line2CoeffTextBox2);
            Controls.Add(line2CoeffTextBox3);
            Controls.Add(label1);
            Controls.Add(line1CoeffTextBox3);
            Controls.Add(line1CoeffTextBox2);
            Controls.Add(line1CoeffTextBox1);
            Controls.Add(browseButton);
            Controls.Add(solveButton);
            Controls.Add(inputTypeComboBox);
            Name = "Form1";
            Text = "Systems Of Equations";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox inputTypeComboBox;
        private Button solveButton;
        private Button browseButton;
        private TextBox line1CoeffTextBox1;
        private TextBox line1CoeffTextBox2;
        private TextBox line1CoeffTextBox3;
        private Label label1;
        private TextBox line2CoeffTextBox3;
        private TextBox line2CoeffTextBox2;
        private TextBox line2CoeffTextBox1;
        private Label label2;
        private Label resultLabel;
        private TextBox fileTextBox;
        private GroupBox coefficientsGroupBox;
        private GroupBox fileGroupBox;
    }
}