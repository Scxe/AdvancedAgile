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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnClose
            // 
            this.btnClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.Location = new System.Drawing.Point(471, 315);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(228, 82);
            this.btnClose.TabIndex = 0;
            this.btnClose.Text = "Cl&ose";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.Button1_Click);
            this.btnClose.MouseLeave += new System.EventHandler(this.BtnClose_MouseLeave);
            this.btnClose.MouseHover += new System.EventHandler(this.BtnClose_MouseHover);
            // 
            // btnAddCourse
            // 
            this.btnAddCourse.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddCourse.Location = new System.Drawing.Point(108, 317);
            this.btnAddCourse.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnAddCourse.Name = "btnAddCourse";
            this.btnAddCourse.Size = new System.Drawing.Size(237, 82);
            this.btnAddCourse.TabIndex = 1;
            this.btnAddCourse.Text = "Add Course";
            this.btnAddCourse.UseVisualStyleBackColor = true;
            this.btnAddCourse.Click += new System.EventHandler(this.BtnAddCourse_Click);
            this.btnAddCourse.MouseLeave += new System.EventHandler(this.BtnAddCourse_MouseLeave);
            this.btnAddCourse.MouseHover += new System.EventHandler(this.BtnAddCourse_MouseHover);
            // 
            // lblCourseTitle
            // 
            this.lblCourseTitle.AutoSize = true;
            this.lblCourseTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCourseTitle.Location = new System.Drawing.Point(104, 89);
            this.lblCourseTitle.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCourseTitle.Name = "lblCourseTitle";
            this.lblCourseTitle.Size = new System.Drawing.Size(231, 40);
            this.lblCourseTitle.TabIndex = 2;
            this.lblCourseTitle.Text = "Course Title: ";
            // 
            // lblSemesterOffered
            // 
            this.lblSemesterOffered.AutoSize = true;
            this.lblSemesterOffered.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSemesterOffered.Location = new System.Drawing.Point(104, 192);
            this.lblSemesterOffered.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSemesterOffered.Name = "lblSemesterOffered";
            this.lblSemesterOffered.Size = new System.Drawing.Size(321, 40);
            this.lblSemesterOffered.TabIndex = 3;
            this.lblSemesterOffered.Text = "Semester Offered: ";
            // 
            // txtSemOffered
            // 
            this.txtSemOffered.Location = new System.Drawing.Point(471, 192);
            this.txtSemOffered.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtSemOffered.Multiline = true;
            this.txtSemOffered.Name = "txtSemOffered";
            this.txtSemOffered.Size = new System.Drawing.Size(264, 42);
            this.txtSemOffered.TabIndex = 4;
            this.txtSemOffered.MouseLeave += new System.EventHandler(this.TxtSemOffered_MouseLeave);
            this.txtSemOffered.MouseHover += new System.EventHandler(this.TxtSemOffered_MouseHover);
            // 
            // txtCourseTitle
            // 
            this.txtCourseTitle.Location = new System.Drawing.Point(471, 86);
            this.txtCourseTitle.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtCourseTitle.Multiline = true;
            this.txtCourseTitle.Name = "txtCourseTitle";
            this.txtCourseTitle.Size = new System.Drawing.Size(264, 46);
            this.txtCourseTitle.TabIndex = 5;
            this.txtCourseTitle.MouseLeave += new System.EventHandler(this.TxtCourseTitle_MouseLeave);
            this.txtCourseTitle.MouseHover += new System.EventHandler(this.TxtCourseTitle_MouseHover);
            // 
            // groupBox1
            // 
            this.groupBox1.Location = new System.Drawing.Point(41, 26);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(718, 396);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Enter Course Data";
            // 
            // statusStrip1
            // 
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1});
            this.statusStrip1.Location = new System.Drawing.Point(0, 427);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(800, 22);
            this.statusStrip1.TabIndex = 7;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(0, 15);
            // 
            // frmAddCourse
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 449);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.txtCourseTitle);
            this.Controls.Add(this.txtSemOffered);
            this.Controls.Add(this.lblSemesterOffered);
            this.Controls.Add(this.lblCourseTitle);
            this.Controls.Add(this.btnAddCourse);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.groupBox1);
            this.Name = "frmAddCourse";
            this.Text = "Add a Course";
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
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
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
    }
}