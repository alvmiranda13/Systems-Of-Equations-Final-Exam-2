namespace fin1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void solveButton_Click(object sender, EventArgs e)
        {
            double[] line1 = new double[3];
            double[] line2 = new double[3];

            if (inputTypeComboBox.SelectedIndex == 0) // Coefficients input
            {
                line1[0] = double.Parse(line1CoeffTextBox1.Text);
                line1[1] = double.Parse(line1CoeffTextBox2.Text);
                line1[2] = double.Parse(line1CoeffTextBox3.Text);

                line2[0] = double.Parse(line2CoeffTextBox1.Text);
                line2[1] = double.Parse(line2CoeffTextBox2.Text);
                line2[2] = double.Parse(line2CoeffTextBox3.Text);
            }
            else if (inputTypeComboBox.SelectedIndex == 1) // File input
            {
                string filePath = fileTextBox.Text;

                if (!File.Exists(filePath))
                {
                    MessageBox.Show("File not found!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                try
                {
                    string[] lines = File.ReadAllLines(filePath);

                    if (lines.Length >= 2)
                    {
                        string[] line1Coeffs = lines[0].Split(',');
                        string[] line2Coeffs = lines[1].Split(',');

                        line1[0] = double.Parse(line1Coeffs[0]);
                        line1[1] = double.Parse(line1Coeffs[1]);
                        line1[2] = double.Parse(line1Coeffs[2]);

                        line2[0] = double.Parse(line2Coeffs[0]);
                        line2[1] = double.Parse(line2Coeffs[1]);
                        line2[2] = double.Parse(line2Coeffs[2]);
                    }
                    else
                    {
                        MessageBox.Show("Invalid file format!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error reading file: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }

            // Solve the system of equations
            double determinant = line1[0] * line2[1] - line1[1] * line2[0];

            if (determinant == 0)
            {
                if (line1[2] == line2[2])
                {
                    resultLabel.Text = "The two lines are the same line.";
                }
                else
                {
                    resultLabel.Text = "The two lines are parallel and do not intersect.";
                }
            }
            else
            {
                double x = (line2[1] * line1[2] - line1[1] * line2[2]) / determinant;
                double y = (line1[0] * line2[2] - line2[0] * line1[2]) / determinant;
                resultLabel.Text = $"Intersection point: ({x}, {y})";
            }
        }

        private void inputTypeComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (inputTypeComboBox.SelectedIndex == 0) // Coefficients input
            {
                coefficientsGroupBox.Enabled = true;
                fileGroupBox.Enabled = false;
            }
            else if (inputTypeComboBox.SelectedIndex == 1) // File input
            {
                coefficientsGroupBox.Enabled = false;
                fileGroupBox.Enabled = true;
            }
        }

        private void browseButton_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Text Files (*.txt)|*.txt";
            openFileDialog.Title = "Select Coefficients File";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                fileTextBox.Text = openFileDialog.FileName;
            }
        }
    }
}