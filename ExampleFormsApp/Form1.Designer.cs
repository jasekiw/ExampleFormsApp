
namespace ExampleFormsApp
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
            this.GetStudentsButton = new System.Windows.Forms.Button();
            this.AddStudentButton = new System.Windows.Forms.Button();
            this.ResultsLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // GetStudentsButton
            // 
            this.GetStudentsButton.Location = new System.Drawing.Point(33, 28);
            this.GetStudentsButton.Name = "GetStudentsButton";
            this.GetStudentsButton.Size = new System.Drawing.Size(117, 23);
            this.GetStudentsButton.TabIndex = 0;
            this.GetStudentsButton.Text = "Get Students";
            this.GetStudentsButton.UseVisualStyleBackColor = true;
            this.GetStudentsButton.Click += new System.EventHandler(this.GetStudentsButton_Click);
            // 
            // AddStudentButton
            // 
            this.AddStudentButton.Location = new System.Drawing.Point(178, 28);
            this.AddStudentButton.Name = "AddStudentButton";
            this.AddStudentButton.Size = new System.Drawing.Size(117, 23);
            this.AddStudentButton.TabIndex = 1;
            this.AddStudentButton.Text = "Add Student";
            this.AddStudentButton.UseVisualStyleBackColor = true;
            this.AddStudentButton.Click += new System.EventHandler(this.AddStudentButton_Click);
            // 
            // ResultsLabel
            // 
            this.ResultsLabel.Location = new System.Drawing.Point(33, 81);
            this.ResultsLabel.Name = "ResultsLabel";
            this.ResultsLabel.Size = new System.Drawing.Size(577, 52);
            this.ResultsLabel.TabIndex = 2;
            this.ResultsLabel.Text = "label1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(815, 446);
            this.Controls.Add(this.ResultsLabel);
            this.Controls.Add(this.AddStudentButton);
            this.Controls.Add(this.GetStudentsButton);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button GetStudentsButton;
        private System.Windows.Forms.Button AddStudentButton;
        private System.Windows.Forms.Label ResultsLabel;
    }
}

