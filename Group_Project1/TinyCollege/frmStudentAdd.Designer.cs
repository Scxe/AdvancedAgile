namespace TinyCollege
{
    partial class frmStudentAdd
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
            this.label1 = new System.Windows.Forms.Label();
            this.btnAddStudent = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.lblNewStudentName = new System.Windows.Forms.Label();
            this.txtStudentName = new System.Windows.Forms.TextBox();
            this.lstTestBox = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(37, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Enter Student Data";
            // 
            // btnAddStudent
            // 
            this.btnAddStudent.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddStudent.Location = new System.Drawing.Point(71, 229);
            this.btnAddStudent.Name = "btnAddStudent";
            this.btnAddStudent.Size = new System.Drawing.Size(127, 64);
            this.btnAddStudent.TabIndex = 1;
            this.btnAddStudent.Text = "Add Student";
            this.btnAddStudent.UseVisualStyleBackColor = true;
            this.btnAddStudent.Click += new System.EventHandler(this.BtnAddStudent_Click);
            // 
            // btnClose
            // 
            this.btnClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.Location = new System.Drawing.Point(286, 229);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(127, 64);
            this.btnClose.TabIndex = 2;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.BtnClose_Click);
            // 
            // lblNewStudentName
            // 
            this.lblNewStudentName.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblNewStudentName.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNewStudentName.Location = new System.Drawing.Point(66, 93);
            this.lblNewStudentName.Name = "lblNewStudentName";
            this.lblNewStudentName.Size = new System.Drawing.Size(94, 88);
            this.lblNewStudentName.TabIndex = 3;
            this.lblNewStudentName.Text = "New Student Name:";
            this.lblNewStudentName.Click += new System.EventHandler(this.LblNewStudentName_Click);
            // 
            // txtStudentName
            // 
            this.txtStudentName.Location = new System.Drawing.Point(261, 150);
            this.txtStudentName.Name = "txtStudentName";
            this.txtStudentName.Size = new System.Drawing.Size(152, 20);
            this.txtStudentName.TabIndex = 4;
            // 
            // lstTestBox
            // 
            this.lstTestBox.FormattingEnabled = true;
            this.lstTestBox.Location = new System.Drawing.Point(261, 35);
            this.lstTestBox.Name = "lstTestBox";
            this.lstTestBox.Size = new System.Drawing.Size(152, 95);
            this.lstTestBox.TabIndex = 5;
            this.lstTestBox.SelectedIndexChanged += new System.EventHandler(this.LstTestBox_SelectedIndexChanged);
            // 
            // frmStudentAdd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(454, 330);
            this.Controls.Add(this.lstTestBox);
            this.Controls.Add(this.txtStudentName);
            this.Controls.Add(this.lblNewStudentName);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnAddStudent);
            this.Controls.Add(this.label1);
            this.Name = "frmStudentAdd";
            this.Text = "Add a Student";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnAddStudent;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Label lblNewStudentName;
        private System.Windows.Forms.TextBox txtStudentName;
        private System.Windows.Forms.ListBox lstTestBox;
    }
}