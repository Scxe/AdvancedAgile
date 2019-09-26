namespace TinyCollege
{
    partial class frmAddCourse
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
            this.btnClose = new System.Windows.Forms.Button();
            this.btnAddCourse = new System.Windows.Forms.Button();
            this.lblCourseTitle = new System.Windows.Forms.Label();
            this.lblSemesterOffered = new System.Windows.Forms.Label();
            this.txtSemOffered = new System.Windows.Forms.TextBox();
            this.txtCourseTitle = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnClose
            // 
            this.btnClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.Location = new System.Drawing.Point(314, 205);
            this.btnClose.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(152, 53);
            this.btnClose.TabIndex = 0;
            this.btnClose.Text = "Cl&ose";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.Button1_Click);
            // 
            // btnAddCourse
            // 
            this.btnAddCourse.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddCourse.Location = new System.Drawing.Point(72, 206);
            this.btnAddCourse.Name = "btnAddCourse";
            this.btnAddCourse.Size = new System.Drawing.Size(158, 53);
            this.btnAddCourse.TabIndex = 1;
            this.btnAddCourse.Text = "Add Course";
            this.btnAddCourse.UseVisualStyleBackColor = true;
            this.btnAddCourse.Click += new System.EventHandler(this.BtnAddCourse_Click);
            // 
            // lblCourseTitle
            // 
            this.lblCourseTitle.AutoSize = true;
            this.lblCourseTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCourseTitle.Location = new System.Drawing.Point(69, 58);
            this.lblCourseTitle.Name = "lblCourseTitle";
            this.lblCourseTitle.Size = new System.Drawing.Size(157, 29);
            this.lblCourseTitle.TabIndex = 2;
            this.lblCourseTitle.Text = "Course Title: ";
            // 
            // lblSemesterOffered
            // 
            this.lblSemesterOffered.AutoSize = true;
            this.lblSemesterOffered.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSemesterOffered.Location = new System.Drawing.Point(69, 125);
            this.lblSemesterOffered.Name = "lblSemesterOffered";
            this.lblSemesterOffered.Size = new System.Drawing.Size(216, 29);
            this.lblSemesterOffered.TabIndex = 3;
            this.lblSemesterOffered.Text = "Semester Offered: ";
            // 
            // txtSemOffered
            // 
            this.txtSemOffered.Location = new System.Drawing.Point(314, 125);
            this.txtSemOffered.Multiline = true;
            this.txtSemOffered.Name = "txtSemOffered";
            this.txtSemOffered.Size = new System.Drawing.Size(177, 29);
            this.txtSemOffered.TabIndex = 4;
            // 
            // txtCourseTitle
            // 
            this.txtCourseTitle.Location = new System.Drawing.Point(314, 56);
            this.txtCourseTitle.Multiline = true;
            this.txtCourseTitle.Name = "txtCourseTitle";
            this.txtCourseTitle.Size = new System.Drawing.Size(177, 31);
            this.txtCourseTitle.TabIndex = 5;
            // 
            // frmAddCourse
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(533, 292);
            this.Controls.Add(this.txtCourseTitle);
            this.Controls.Add(this.txtSemOffered);
            this.Controls.Add(this.lblSemesterOffered);
            this.Controls.Add(this.lblCourseTitle);
            this.Controls.Add(this.btnAddCourse);
            this.Controls.Add(this.btnClose);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "frmAddCourse";
            this.Text = "Add a Course";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnAddCourse;
        private System.Windows.Forms.Label lblCourseTitle;
        private System.Windows.Forms.Label lblSemesterOffered;
        private System.Windows.Forms.TextBox txtSemOffered;
        private System.Windows.Forms.TextBox txtCourseTitle;
    }
}