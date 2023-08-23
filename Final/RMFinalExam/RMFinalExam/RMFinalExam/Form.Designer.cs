namespace RMFinalExam
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
            label1 = new Label();
            label2 = new Label();
            txtPrefill = new TextBox();
            txtNewpart = new TextBox();
            btnPreFill = new Button();
            btnQuestion1 = new Button();
            txtMessage = new RichTextBox();
            btnQuestion2 = new Button();
            btnQuestion3 = new Button();
            btnAddToList = new Button();
            txtQuestion3 = new TextBox();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            txtID = new TextBox();
            txtPrice = new TextBox();
            txtName = new TextBox();
            txtDescription = new TextBox();
            txtQuantity = new TextBox();
            btnQuestion4 = new Button();
            btnQuestion5 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(45, 36);
            label1.Name = "label1";
            label1.Size = new Size(116, 32);
            label1.TabIndex = 0;
            label1.Text = "Enter Part";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(45, 78);
            label2.Name = "label2";
            label2.Size = new Size(109, 32);
            label2.TabIndex = 1;
            label2.Text = "New Part";
            // 
            // txtPrefill
            // 
            txtPrefill.Location = new Point(182, 33);
            txtPrefill.Name = "txtPrefill";
            txtPrefill.Size = new Size(870, 39);
            txtPrefill.TabIndex = 2;
            // 
            // txtNewpart
            // 
            txtNewpart.Location = new Point(182, 81);
            txtNewpart.Name = "txtNewpart";
            txtNewpart.Size = new Size(870, 39);
            txtNewpart.TabIndex = 3;
            // 
            // btnPreFill
            // 
            btnPreFill.BackColor = SystemColors.ActiveCaption;
            btnPreFill.Location = new Point(1209, 30);
            btnPreFill.Name = "btnPreFill";
            btnPreFill.Size = new Size(228, 45);
            btnPreFill.TabIndex = 4;
            btnPreFill.Text = "Pre-fill";
            btnPreFill.UseVisualStyleBackColor = false;
            btnPreFill.Click += btnPreFill_Click;
            // 
            // btnQuestion1
            // 
            btnQuestion1.BackColor = SystemColors.ActiveCaption;
            btnQuestion1.Location = new Point(1209, 85);
            btnQuestion1.Name = "btnQuestion1";
            btnQuestion1.Size = new Size(228, 45);
            btnQuestion1.TabIndex = 5;
            btnQuestion1.Text = "Question-1";
            btnQuestion1.UseVisualStyleBackColor = false;
            btnQuestion1.Click += btnQuestion1_Click;
            // 
            // txtMessage
            // 
            txtMessage.Location = new Point(52, 522);
            txtMessage.Name = "txtMessage";
            txtMessage.Size = new Size(1385, 386);
            txtMessage.TabIndex = 6;
            txtMessage.Text = "";
            // 
            // btnQuestion2
            // 
            btnQuestion2.BackColor = SystemColors.ActiveCaption;
            btnQuestion2.Location = new Point(1209, 145);
            btnQuestion2.Name = "btnQuestion2";
            btnQuestion2.Size = new Size(228, 45);
            btnQuestion2.TabIndex = 7;
            btnQuestion2.Text = "Question-2";
            btnQuestion2.UseVisualStyleBackColor = false;
            btnQuestion2.Click += btnQuestion2_Click;
            // 
            // btnQuestion3
            // 
            btnQuestion3.BackColor = SystemColors.ActiveCaption;
            btnQuestion3.Location = new Point(1209, 207);
            btnQuestion3.Name = "btnQuestion3";
            btnQuestion3.Size = new Size(228, 45);
            btnQuestion3.TabIndex = 8;
            btnQuestion3.Text = "Question-3";
            btnQuestion3.UseVisualStyleBackColor = false;
            btnQuestion3.Click += btnQuestion3_Click;
            // 
            // btnAddToList
            // 
            btnAddToList.BackColor = SystemColors.ActiveCaption;
            btnAddToList.Location = new Point(946, 207);
            btnAddToList.Name = "btnAddToList";
            btnAddToList.Size = new Size(228, 45);
            btnAddToList.TabIndex = 9;
            btnAddToList.Text = "Add to List";
            btnAddToList.UseVisualStyleBackColor = false;
            btnAddToList.Click += btnAddToList_Click;
            // 
            // txtQuestion3
            // 
            txtQuestion3.Location = new Point(547, 213);
            txtQuestion3.Name = "txtQuestion3";
            txtQuestion3.Size = new Size(334, 39);
            txtQuestion3.TabIndex = 10;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(45, 284);
            label3.Name = "label3";
            label3.Size = new Size(37, 32);
            label3.TabIndex = 11;
            label3.Text = "ID";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(232, 284);
            label4.Name = "label4";
            label4.Size = new Size(65, 32);
            label4.TabIndex = 12;
            label4.Text = "Price";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(436, 284);
            label5.Name = "label5";
            label5.Size = new Size(78, 32);
            label5.TabIndex = 13;
            label5.Text = "Name";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(669, 284);
            label6.Name = "label6";
            label6.Size = new Size(135, 32);
            label6.TabIndex = 14;
            label6.Text = "Description";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(999, 284);
            label7.Name = "label7";
            label7.Size = new Size(106, 32);
            label7.TabIndex = 15;
            label7.Text = "Quantity";
            // 
            // txtID
            // 
            txtID.Location = new Point(45, 331);
            txtID.Name = "txtID";
            txtID.Size = new Size(142, 39);
            txtID.TabIndex = 16;
            // 
            // txtPrice
            // 
            txtPrice.Location = new Point(232, 331);
            txtPrice.Name = "txtPrice";
            txtPrice.Size = new Size(142, 39);
            txtPrice.TabIndex = 17;
            txtPrice.TextChanged += textBox2_TextChanged;
            // 
            // txtName
            // 
            txtName.Location = new Point(416, 331);
            txtName.Name = "txtName";
            txtName.Size = new Size(206, 39);
            txtName.TabIndex = 18;
            // 
            // txtDescription
            // 
            txtDescription.Location = new Point(669, 331);
            txtDescription.Name = "txtDescription";
            txtDescription.Size = new Size(293, 39);
            txtDescription.TabIndex = 19;
            // 
            // txtQuantity
            // 
            txtQuantity.Location = new Point(999, 331);
            txtQuantity.Name = "txtQuantity";
            txtQuantity.Size = new Size(142, 39);
            txtQuantity.TabIndex = 20;
            txtQuantity.TextChanged += textBox5_TextChanged;
            // 
            // btnQuestion4
            // 
            btnQuestion4.BackColor = SystemColors.ActiveCaption;
            btnQuestion4.Location = new Point(1209, 325);
            btnQuestion4.Name = "btnQuestion4";
            btnQuestion4.Size = new Size(228, 45);
            btnQuestion4.TabIndex = 21;
            btnQuestion4.Text = "Question-4";
            btnQuestion4.UseVisualStyleBackColor = false;
            btnQuestion4.Click += btnQuestion4_Click;
            // 
            // btnQuestion5
            // 
            btnQuestion5.BackColor = SystemColors.ActiveCaption;
            btnQuestion5.Location = new Point(1209, 404);
            btnQuestion5.Name = "btnQuestion5";
            btnQuestion5.Size = new Size(228, 45);
            btnQuestion5.TabIndex = 22;
            btnQuestion5.Text = "Question-5";
            btnQuestion5.UseVisualStyleBackColor = false;
            btnQuestion5.Click += btnQuestion5_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1503, 944);
            Controls.Add(btnQuestion5);
            Controls.Add(btnQuestion4);
            Controls.Add(txtQuantity);
            Controls.Add(txtDescription);
            Controls.Add(txtName);
            Controls.Add(txtPrice);
            Controls.Add(txtID);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(txtQuestion3);
            Controls.Add(btnAddToList);
            Controls.Add(btnQuestion3);
            Controls.Add(btnQuestion2);
            Controls.Add(txtMessage);
            Controls.Add(btnQuestion1);
            Controls.Add(btnPreFill);
            Controls.Add(txtNewpart);
            Controls.Add(txtPrefill);
            Controls.Add(label2);
            Controls.Add(label1);
            Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            Margin = new Padding(4);
            Name = "Form1";
            Text = "Final Exam - Rutvi Mistry";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox txtPrefill;
        private TextBox txtNewpart;
        private Button btnPreFill;
        private Button btnQuestion1;
        private RichTextBox txtMessage;
        private Button btnQuestion2;
        private Button btnQuestion3;
        private Button btnAddToList;
        private TextBox txtQuestion3;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private TextBox txtID;
        private TextBox txtPrice;
        private TextBox txtName;
        private TextBox txtDescription;
        private TextBox txtQuantity;
        private Button btnQuestion4;
        private Button btnQuestion5;
    }
}