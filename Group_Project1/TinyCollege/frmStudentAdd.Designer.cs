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
            this.label1.Location = new System.Drawing.Point(56, 75);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(148, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Enter Student Data";
            // 
            // btnAddStudent
            // 
            this.btnAddStudent.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddStudent.Location = new System.Drawing.Point(106, 352);
            this.btnAddStudent.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnAddStudent.Name = "btnAddStudent";
            this.btnAddStudent.Size = new System.Drawing.Size(190, 98);
            this.btnAddStudent.TabIndex = 1;
            this.btnAddStudent.Text = "Add Student";
            this.btnAddStudent.UseVisualStyleBackColor = true;
            this.btnAddStudent.Click += new System.EventHandler(this.BtnAddStudent_Click);
            // 
            // btnClose
            // 
            this.btnClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.Location = new System.Drawing.Point(429, 352);
            this.btnClose.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(190, 98);
            this.btnClose.TabIndex = 2;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.BtnClose_Click);
            // 
            // lblNewStudentName
            // 
            this.lblNewStudentName.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblNewStudentName.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNewStudentName.Location = new System.Drawing.Point(99, 143);
            this.lblNewStudentName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNewStudentName.Name = "lblNewStudentName";
            this.lblNewStudentName.Size = new System.Drawing.Size(141, 135);
            this.lblNewStudentName.TabIndex = 3;
            this.lblNewStudentName.Text = "New Student Name:";
            this.lblNewStudentName.Click += new System.EventHandler(this.LblNewStudentName_Click);
            // 
            // txtStudentName
            // 
            this.txtStudentName.Location = new System.Drawing.Point(392, 231);
            this.txtStudentName.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtStudentName.Name = "txtStudentName";
            this.txtStudentName.Size = new System.Drawing.Size(226, 26);
            this.txtStudentName.TabIndex = 4;
            // 
            // lstTestBox
            // 
            this.lstTestBox.FormattingEnabled = true;
            this.lstTestBox.ItemHeight = 20;
            this.lstTestBox.Location = new System.Drawing.Point(392, 54);
            this.lstTestBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.lstTestBox.Name = "lstTestBox";
            this.lstTestBox.Size = new System.Drawing.Size(226, 144);
            this.lstTestBox.TabIndex = 5;
            this.lstTestBox.SelectedIndexChanged += new System.EventHandler(this.LstTestBox_SelectedIndexChanged);
            // 
            // frmStudentAdd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(681, 508);
            this.Controls.Add(this.lstTestBox);
            this.Controls.Add(this.txtStudentName);
            this.Controls.Add(this.lblNewStudentName);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnAddStudent);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "frmStudentAdd";
            this.Text = "Add a Student";
            this.Load += new System.EventHandler(this.FrmStudentAdd_Load_1);
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