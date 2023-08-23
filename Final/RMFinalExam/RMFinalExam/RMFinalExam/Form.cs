
using System.IO;
using System.Xml.Linq;
using Parts;

namespace RMFinalExam
{
    public partial class Form1 : Form
    {
        // List to store parts
        private List<string> parts = new List<string>();

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        // Event handler for "Pre-Fill" button click(Question-1)
        private void btnPreFill_Click(object sender, EventArgs e)
        {
            // Pre-fill text box with sample data
            txtPrefill.Text = "12, 23.00, Handdrill, $hardware$$, Quantity?";
        }

        // Event handler for "Question 1" button click
        private void btnQuestion1_Click(object sender, EventArgs e)
        {
            // Validate and clean input text and Remove punctuation and dollar signs from input
            string txtPartValue = txtNewpart.Text.Trim();
            if (string.IsNullOrEmpty(txtPartValue))
            {
                txtMessage.Text = "Error: Input text should not be empty or null.";
            }
            else if (txtPartValue.Length <= 4)
            {
                txtMessage.Text = "Error: Input text must be longer than 4 characters.";
            }
            else
            {
                string cleanedInput = new string(txtPartValue.Where(c => !char.IsPunctuation(c) && c != '$').ToArray());
                txtNewpart.Text = cleanedInput;
            }
        }

        // Event handler for "Question 2" button click
        private void btnQuestion2_Click(object sender, EventArgs e)
        {
            // Split and display parts from input text
            string newPart = txtNewpart.Text;
            string[] partArray = newPart.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

            txtMessage.Clear();

            for (int i = 0; i < partArray.Length; i++)
            {
                int displayIndex = i + 1;
                txtMessage.AppendText($"{displayIndex}: {partArray[i]}\n");
            }

        }

        // Event handler for "Add to List" button click
        private void btnAddToList_Click(object sender, EventArgs e)
        {
            parts.Add(txtQuestion3.Text);
        }

        // Event handler for "Question 3" button click
        private void btnQuestion3_Click(object sender, EventArgs e)
        {
            if (parts.Count >= 2)
            {
                string[] shortPart = new string[2];
                shortPart[0] = parts.First();
                shortPart[1] = parts.Last();

                txtMessage.Clear();
                txtMessage.AppendText($"First Part: {shortPart[0]}\n");
                txtMessage.AppendText($"Last Part: {shortPart[1]}\n");
            }
            else
            {
                txtMessage.Text = "There are not enough parts in the list to display.";
            }
            if (parts.Count >= 2)
            {
                string[] shortPart = new string[2];
                shortPart[0] = parts.First();
                shortPart[1] = parts.Last();
            }

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        // Event handler for "Question 4" button click
        private void btnQuestion4_Click(object sender, EventArgs e)
        {

            txtMessage.Text = "";

            if (!Part.IsNumeric(txtID.Text))
                txtMessage.AppendText("Error: Part ID must be a number.\n");

            if (!Part.IsNumeric(txtPrice.Text))
                txtMessage.AppendText("Error: Sale Price must be a number.\n");

            if (!Part.IsNumeric(txtQuantity.Text))
                txtMessage.AppendText("Error: Quantity must be a number.\n");

            if (string.IsNullOrEmpty(txtName.Text))
                txtMessage.AppendText("Error: Name cannot be empty.\n");

            if (string.IsNullOrEmpty(txtMessage.Text))
            {
                int partId = int.Parse(txtID.Text);
                double salePrice = double.Parse(txtPrice.Text);
                int quantity = int.Parse(txtQuantity.Text);
                string name = txtName.Text;
                string description = txtDescription.Text;

                Part part = new Part(partId, salePrice, name, description, quantity);
                double totalPrice = part.CalculateTotalPrice();

                txtMessage.AppendText($"Part ID: {partId}\n");
                txtMessage.AppendText($"Sale Price: {salePrice:C2}\n");
                txtMessage.AppendText($"Name: {name}\n");
                txtMessage.AppendText($"Description: {description}\n");
                txtMessage.AppendText($"Quantity: {quantity}\n");
                txtMessage.AppendText($"Total Price: {totalPrice:C2}\n");
            }

        }

        // Event handler for "Question 5" button click
        private void btnQuestion5_Click(object sender, EventArgs e)
        {
            txtMessage.Text = "";

            try
            {
                string initials = "RM"; 
                string fileName = $"{initials}Exam.txt";
                using (StreamWriter writer = File.AppendText(fileName))
                {
                    Part part = new Part(int.Parse(txtID.Text), double.Parse(txtPrice.Text), txtName.Text, txtDescription.Text, int.Parse(txtQuantity.Text));
                    writer.WriteLine(part.ToString());
                }

                txtMessage.AppendText("Part written to file successfully.\n");
            }
            catch (Exception ex)
            {
                txtMessage.AppendText($"Error writing to file: {ex.Message}\n");
            }
        }
    }
}