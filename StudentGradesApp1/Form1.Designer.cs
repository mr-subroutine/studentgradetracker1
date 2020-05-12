namespace StudentGradesApp1
{
    partial class Studenr
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
            this.btn_addStudent = new System.Windows.Forms.Button();
            this.btn_average = new System.Windows.Forms.Button();
            this.btn_lowest = new System.Windows.Forms.Button();
            this.btn_highest = new System.Windows.Forms.Button();
            this.btn_exit = new System.Windows.Forms.Button();
            this.btn_writeToFile = new System.Windows.Forms.Button();
            this.listBoxStudent = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // btn_addStudent
            // 
            this.btn_addStudent.Location = new System.Drawing.Point(49, 44);
            this.btn_addStudent.Name = "btn_addStudent";
            this.btn_addStudent.Size = new System.Drawing.Size(134, 43);
            this.btn_addStudent.TabIndex = 3;
            this.btn_addStudent.Text = "Add Student / Grade";
            this.btn_addStudent.UseVisualStyleBackColor = true;
            this.btn_addStudent.Click += new System.EventHandler(this.btn_addStudent_Click);
            // 
            // btn_average
            // 
            this.btn_average.Location = new System.Drawing.Point(225, 44);
            this.btn_average.Name = "btn_average";
            this.btn_average.Size = new System.Drawing.Size(134, 43);
            this.btn_average.TabIndex = 5;
            this.btn_average.Text = "Average Grade";
            this.btn_average.UseVisualStyleBackColor = true;
            // 
            // btn_lowest
            // 
            this.btn_lowest.Location = new System.Drawing.Point(49, 105);
            this.btn_lowest.Name = "btn_lowest";
            this.btn_lowest.Size = new System.Drawing.Size(134, 43);
            this.btn_lowest.TabIndex = 6;
            this.btn_lowest.Text = "Lowest Grade";
            this.btn_lowest.UseVisualStyleBackColor = true;
            // 
            // btn_highest
            // 
            this.btn_highest.Location = new System.Drawing.Point(225, 105);
            this.btn_highest.Name = "btn_highest";
            this.btn_highest.Size = new System.Drawing.Size(134, 43);
            this.btn_highest.TabIndex = 7;
            this.btn_highest.Text = "Highest Grade";
            this.btn_highest.UseVisualStyleBackColor = true;
            // 
            // btn_exit
            // 
            this.btn_exit.Location = new System.Drawing.Point(49, 165);
            this.btn_exit.Name = "btn_exit";
            this.btn_exit.Size = new System.Drawing.Size(134, 43);
            this.btn_exit.TabIndex = 8;
            this.btn_exit.Text = "Exit";
            this.btn_exit.UseVisualStyleBackColor = true;
            // 
            // btn_writeToFile
            // 
            this.btn_writeToFile.Location = new System.Drawing.Point(225, 165);
            this.btn_writeToFile.Name = "btn_writeToFile";
            this.btn_writeToFile.Size = new System.Drawing.Size(134, 43);
            this.btn_writeToFile.TabIndex = 9;
            this.btn_writeToFile.Text = "Write to File";
            this.btn_writeToFile.UseVisualStyleBackColor = true;
            // 
            // listBoxStudent
            // 
            this.listBoxStudent.FormattingEnabled = true;
            this.listBoxStudent.Location = new System.Drawing.Point(434, 48);
            this.listBoxStudent.Name = "listBoxStudent";
            this.listBoxStudent.Size = new System.Drawing.Size(225, 160);
            this.listBoxStudent.TabIndex = 10;
            // 
            // Studenr
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(704, 260);
            this.Controls.Add(this.listBoxStudent);
            this.Controls.Add(this.btn_writeToFile);
            this.Controls.Add(this.btn_exit);
            this.Controls.Add(this.btn_highest);
            this.Controls.Add(this.btn_lowest);
            this.Controls.Add(this.btn_average);
            this.Controls.Add(this.btn_addStudent);
            this.Name = "Studenr";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Student Grades 1 v1.0";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btn_addStudent;
        private System.Windows.Forms.Button btn_average;
        private System.Windows.Forms.Button btn_lowest;
        private System.Windows.Forms.Button btn_highest;
        private System.Windows.Forms.Button btn_exit;
        private System.Windows.Forms.Button btn_writeToFile;
        private System.Windows.Forms.ListBox listBoxStudent;
    }
}

