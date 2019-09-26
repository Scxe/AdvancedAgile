namespace TinyCollege
{
    partial class frmWhoIsInACourse
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
            this.label2 = new System.Windows.Forms.Label();
            this.lblEnrolled = new System.Windows.Forms.Label();
            this.btnFind = new System.Windows.Forms.Button();
            this.txtCourseId = new System.Windows.Forms.TextBox();
            this.txtCourseTitle = new System.Windows.Forms.TextBox();
            this.lblCourseId = new System.Windows.Forms.Label();
            this.lstStudentsEnrolled = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // btnClose
            // 
            this.btnClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.Location = new System.Drawing.Point(165, 327);
            this.btnClose.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnClose.Name = "btnClose";
            this.btnClose.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnClose.Size = new System.Drawing.Size(102, 41);
            this.btnClose.TabIndex = 0;
            this.btnClose.Text = "Cl&ose";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.BtnClose_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(22, 81);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(101, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "Course Title:";
            // 
            // lblEnrolled
            // 
            this.lblEnrolled.AutoSize = true;
            this.lblEnrolled.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEnrolled.Location = new System.Drawing.Point(22, 128);
            this.lblEnrolled.Name = "lblEnrolled";
            this.lblEnrolled.Size = new System.Drawing.Size(275, 17);
            this.lblEnrolled.TabIndex = 4;
            this.lblEnrolled.Text = "All Students Enrolled in This Course:";
            // 
            // btnFind
            // 
            this.btnFind.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFind.Location = new System.Drawing.Point(415, 19);
            this.btnFind.Name = "btnFind";
            this.btnFind.Size = new System.Drawing.Size(75, 22);
            this.btnFind.TabIndex = 5;
            this.btnFind.Text = "Find";
            this.btnFind.UseVisualStyleBackColor = true;
            this.btnFind.Click += new System.EventHandler(this.BtnFind_Click);
            // 
            // txtCourseId
            // 
            this.txtCourseId.Location = new System.Drawing.Point(112, 21);
            this.txtCourseId.Name = "txtCourseId";
            this.txtCourseId.Size = new System.Drawing.Size(263, 20);
            this.txtCourseId.TabIndex = 6;
            // 
            // txtCourseTitle
            // 
            this.txtCourseTitle.Location = new System.Drawing.Point(165, 81);
            this.txtCourseTitle.Name = "txtCourseTitle";
            this.txtCourseTitle.ReadOnly = true;
            this.txtCourseTitle.Size = new System.Drawing.Size(210, 20);
            this.txtCourseTitle.TabIndex = 10;
            // 
            // lblCourseId
            // 
            this.lblCourseId.AutoSize = true;
            this.lblCourseId.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCourseId.Location = new System.Drawing.Point(22, 22);
            this.lblCourseId.Name = "lblCourseId";
            this.lblCourseId.Size = new System.Drawing.Size(84, 17);
            this.lblCourseId.TabIndex = 11;
            this.lblCourseId.Text = "Course ID:";
            // 
            // lstStudentsEnrolled
            // 
            this.lstStudentsEnrolled.FormattingEnabled = true;
            this.lstStudentsEnrolled.Location = new System.Drawing.Point(25, 166);
            this.lstStudentsEnrolled.Name = "lstStudentsEnrolled";
            this.lstStudentsEnrolled.Size = new System.Drawing.Size(350, 147);
            this.lstStudentsEnrolled.TabIndex = 12;
            // 
            // frmWhoIsInACourse
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(533, 396);
            this.Controls.Add(this.lstStudentsEnrolled);
            this.Controls.Add(this.lblCourseId);
            this.Controls.Add(this.txtCourseTitle);
            this.Controls.Add(this.txtCourseId);
            this.Controls.Add(this.btnFind);
            this.Controls.Add(this.lblEnrolled);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnClose);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "frmWhoIsInACourse";
            this.Text = "Who is in a Course";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblEnrolled;
        private System.Windows.Forms.Button btnFind;
        private System.Windows.Forms.TextBox txtCourseId;
        private System.Windows.Forms.TextBox txtCourseTitle;
        private System.Windows.Forms.Label lblCourseId;
        private System.Windows.Forms.ListBox lstStudentsEnrolled;
    }
}