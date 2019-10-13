/*Ruben Castillo
   Ariel Fernandez
   Erica Gonzalez-Herrera
   Joshua Joers
   Seth Schuster
   Asa Thompson
   
   Advanced Agile Software Development (CISS 311)
   Course Project*/


using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
using System.Data.SqlClient;


namespace TinyCollege
{
    

    public partial class frmMain : Form
    {
        SqlConnection connection;
        string connectionString;
        
        //Form load
        public frmMain()
        {
            InitializeComponent();

            connectionString = ConfigurationManager.ConnectionStrings["TinyCollege.Properties.Settings.StudentDBConnectionString"].ConnectionString;
        }

        //Form has no load.
        private void frmMain_Load(object sender, EventArgs e)
        {

        }

        //Opens the form to add student.
        private void BtnAddStudent_Click(object sender, EventArgs e)
        {
            new frmStudentAdd().Show();
            this.Hide();
        }

        //Exits the application.
        private void BtnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        //Opens the form to enroll a student into a course.
        private void BtnEnroll_Click(object sender, EventArgs e)
        {
            new frmEnrollment().Show();
            this.Hide();
        }

        //Opens the form to add a course.
        private void BtnAddCourses_Click(object sender, EventArgs e)
        {
            new frmAddCourse().Show();
            this.Hide();
        }

        //Opens the form to see who is enrolled in a course.
        private void BtnWho_Click(object sender, EventArgs e)
        {
            new frmWhoIsInACourse().Show();
            this.Hide();
        }

        //Opens the form to see what courses a student is enrolled in.
        private void BtnWhatCourses_Click(object sender, EventArgs e)
        {
            new frmWhatCoursesAStudentisEnrolledIn().Show();
            this.Hide();
        }
    }
}
