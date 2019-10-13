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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnClose
            // 
            this.btnClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.Location = new System.Drawing.Point(324, 503);
            this.btnClose.Name = "btnClose";
            this.btnClose.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnClose.Size = new System.Drawing.Size(153, 63);
            this.btnClose.TabIndex = 0;
            this.btnClose.Text = "Cl&ose";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.BtnClose_Click);
            this.btnClose.MouseLeave += new System.EventHandler(this.BtnClose_MouseLeave);
            this.btnClose.MouseHover += new System.EventHandler(this.BtnClose_MouseHover);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(47, 124);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(137, 25);
            this.label2.TabIndex = 3;
            this.label2.Text = "Course Title:";
            this.label2.Click += new System.EventHandler(this.Label2_Click);
            // 
            // lblEnrolled
            // 
            this.lblEnrolled.AutoSize = true;
            this.lblEnrolled.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEnrolled.Location = new System.Drawing.Point(47, 225);
            this.lblEnrolled.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblEnrolled.Name = "lblEnrolled";
            this.lblEnrolled.Size = new System.Drawing.Size(368, 25);
            this.lblEnrolled.TabIndex = 4;
            this.lblEnrolled.Text = "All Students Enrolled in This Course:";
            // 
            // btnFind
            // 
            this.btnFind.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFind.Location = new System.Drawing.Point(636, 49);
            this.btnFind.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnFind.Name = "btnFind";
            this.btnFind.Size = new System.Drawing.Size(112, 100);
            this.btnFind.TabIndex = 5;
            this.btnFind.Text = "Find";
            this.btnFind.UseVisualStyleBackColor = true;
            this.btnFind.Click += new System.EventHandler(this.BtnFind_Click);
            this.btnFind.MouseLeave += new System.EventHandler(this.BtnFind_MouseLeave);
            this.btnFind.MouseHover += new System.EventHandler(this.BtnFind_MouseHover);
            // 
            // txtCourseId
            // 
            this.txtCourseId.Location = new System.Drawing.Point(199, 48);
            this.txtCourseId.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtCourseId.Name = "txtCourseId";
            this.txtCourseId.Size = new System.Drawing.Size(392, 26);
            this.txtCourseId.TabIndex = 6;
            this.txtCourseId.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtCourseId_KeyPress);
            this.txtCourseId.MouseLeave += new System.EventHandler(this.TxtCourseId_MouseLeave);
            this.txtCourseId.MouseHover += new System.EventHandler(this.TxtCourseId_MouseHover);
            // 
            // txtCourseTitle
            // 
            this.txtCourseTitle.Location = new System.Drawing.Point(199, 123);
            this.txtCourseTitle.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtCourseTitle.Name = "txtCourseTitle";
            this.txtCourseTitle.ReadOnly = true;
            this.txtCourseTitle.Size = new System.Drawing.Size(392, 26);
            this.txtCourseTitle.TabIndex = 10;
            // 
            // lblCourseId
            // 
            this.lblCourseId.AutoSize = true;
            this.lblCourseId.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCourseId.Location = new System.Drawing.Point(47, 49);
            this.lblCourseId.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCourseId.Name = "lblCourseId";
            this.lblCourseId.Size = new System.Drawing.Size(116, 25);
            this.lblCourseId.TabIndex = 11;
            this.lblCourseId.Text = "Course ID:";
            // 
            // lstStudentsEnrolled
            // 
            this.lstStudentsEnrolled.FormattingEnabled = true;
            this.lstStudentsEnrolled.ItemHeight = 20;
            this.lstStudentsEnrolled.Location = new System.Drawing.Point(52, 255);
            this.lstStudentsEnrolled.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.lstStudentsEnrolled.Name = "lstStudentsEnrolled";
            this.lstStudentsEnrolled.Size = new System.Drawing.Size(696, 224);
            this.lstStudentsEnrolled.TabIndex = 12;
            // 
            // groupBox1
            // 
            this.groupBox1.Location = new System.Drawing.Point(35, 21);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(731, 174);
            this.groupBox1.TabIndex = 13;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Student Data";
            // 
            // statusStrip1
            // 
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1});
            this.statusStrip1.Location = new System.Drawing.Point(0, 587);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(800, 22);
            this.statusStrip1.TabIndex = 14;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(0, 15);
            // 
            // frmWhoIsInACourse
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 609);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.lstStudentsEnrolled);
            this.Controls.Add(this.lblCourseId);
            this.Controls.Add(this.txtCourseTitle);
            this.Controls.Add(this.txtCourseId);
            this.Controls.Add(this.btnFind);
            this.Controls.Add(this.lblEnrolled);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.groupBox1);
            this.Name = "frmWhoIsInACourse";
            this.Text = "Who is in a Course";
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
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
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
    }
}