namespace Names
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
            btnAdd = new Button();
            lblNames = new Label();
            lstNames = new ListBox();
            txtName = new TextBox();
            SuspendLayout();
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(138, 92);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(100, 30);
            btnAdd.TabIndex = 0;
            btnAdd.Text = "Add Name";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // lblNames
            // 
            lblNames.AutoSize = true;
            lblNames.Location = new Point(12, 27);
            lblNames.Name = "lblNames";
            lblNames.Size = new Size(67, 25);
            lblNames.TabIndex = 1;
            lblNames.Text = "Names";
            lblNames.Click += label1_Click;
            // 
            // lstNames
            // 
            lstNames.FormattingEnabled = true;
            lstNames.ItemHeight = 25;
            lstNames.Location = new Point(12, 55);
            lstNames.Name = "lstNames";
            lstNames.Size = new Size(120, 79);
            lstNames.TabIndex = 2;
            // 
            // txtName
            // 
            txtName.Location = new Point(138, 55);
            txtName.Name = "txtName";
            txtName.Size = new Size(100, 31);
            txtName.TabIndex = 3;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(388, 221);
            Controls.Add(txtName);
            Controls.Add(lstNames);
            Controls.Add(lblNames);
            Controls.Add(btnAdd);
            Name = "Form1";
            Text = "Names";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnAdd;
        private Label lblNames;
        private ListBox lstNames;
        private TextBox txtName;
    }
}
