namespace TinyCollege
{
    partial class frmMain
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
            this.btnAddStudent = new System.Windows.Forms.Button();
            this.btnEnroll = new System.Windows.Forms.Button();
            this.btnWhatCourses = new System.Windows.Forms.Button();
            this.btnAddCourses = new System.Windows.Forms.Button();
            this.btnWho = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnAddStudent
            // 
            this.btnAddStudent.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddStudent.Location = new System.Drawing.Point(114, 172);
            this.btnAddStudent.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnAddStudent.Name = "btnAddStudent";
            this.btnAddStudent.Size = new System.Drawing.Size(198, 94);
            this.btnAddStudent.TabIndex = 0;
            this.btnAddStudent.Text = "Add a Student";
            this.btnAddStudent.UseVisualStyleBackColor = true;
            this.btnAddStudent.Click += new System.EventHandler(this.BtnAddStudent_Click);
            // 
            // btnEnroll
            // 
            this.btnEnroll.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEnroll.Location = new System.Drawing.Point(114, 325);
            this.btnEnroll.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnEnroll.Name = "btnEnroll";
            this.btnEnroll.Size = new System.Drawing.Size(198, 94);
            this.btnEnroll.TabIndex = 1;
            this.btnEnroll.Text = "Enroll a Student in a Course";
            this.btnEnroll.UseVisualStyleBackColor = true;
            this.btnEnroll.Click += new System.EventHandler(this.BtnEnroll_Click);
            // 
            // btnWhatCourses
            // 
            this.btnWhatCourses.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnWhatCourses.Location = new System.Drawing.Point(114, 469);
            this.btnWhatCourses.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnWhatCourses.Name = "btnWhatCourses";
            this.btnWhatCourses.Size = new System.Drawing.Size(198, 94);
            this.btnWhatCourses.TabIndex = 2;
            this.btnWhatCourses.Text = "What Courses a Student is Enrolled In";
            this.btnWhatCourses.UseVisualStyleBackColor = true;
            this.btnWhatCourses.Click += new System.EventHandler(this.BtnWhatCourses_Click);
            // 
            // btnAddCourses
            // 
            this.btnAddCourses.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddCourses.Location = new System.Drawing.Point(474, 172);
            this.btnAddCourses.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnAddCourses.Name = "btnAddCourses";
            this.btnAddCourses.Size = new System.Drawing.Size(198, 94);
            this.btnAddCourses.TabIndex = 3;
            this.btnAddCourses.Text = "Add a Course";
            this.btnAddCourses.UseVisualStyleBackColor = true;
            this.btnAddCourses.Click += new System.EventHandler(this.BtnAddCourses_Click);
            // 
            // btnWho
            // 
            this.btnWho.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnWho.Location = new System.Drawing.Point(474, 325);
            this.btnWho.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnWho.Name = "btnWho";
            this.btnWho.Size = new System.Drawing.Size(198, 94);
            this.btnWho.TabIndex = 4;
            this.btnWho.Text = "Who is in a Course";
            this.btnWho.UseVisualStyleBackColor = true;
            this.btnWho.Click += new System.EventHandler(this.BtnWho_Click);
            // 
            // btnExit
            // 
            this.btnExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.Location = new System.Drawing.Point(474, 469);
            this.btnExit.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(198, 94);
            this.btnExit.TabIndex = 5;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.BtnExit_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(117, 88);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(552, 37);
            this.label1.TabIndex = 6;
            this.label1.Text = "Tiny College Course Tracking System";
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(786, 692);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnWho);
            this.Controls.Add(this.btnAddCourses);
            this.Controls.Add(this.btnWhatCourses);
            this.Controls.Add(this.btnEnroll);
            this.Controls.Add(this.btnAddStudent);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "frmMain";
            this.Text = "Welcome";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAddStudent;
        private System.Windows.Forms.Button btnEnroll;
        private System.Windows.Forms.Button btnWhatCourses;
        private System.Windows.Forms.Button btnAddCourses;
        private System.Windows.Forms.Button btnWho;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Label label1;
    }
}

