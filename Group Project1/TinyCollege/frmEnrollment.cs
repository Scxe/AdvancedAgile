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
using System.Data.SqlClient;
using System.Web;
using System.Configuration;

namespace TinyCollege
{
    public partial class frmEnrollment : Form
    {
        //SQL Connection and string variable used for form.
        SqlConnection connection;
        string connectionString;
        public frmEnrollment()
        {
            InitializeComponent();
            connectionString = ConfigurationManager.ConnectionStrings["TinyCollege.Properties.Settings.StudentDBConnectionString"].ConnectionString;
            fillStudentComboBox();
            fillCoursesComboBox();
        }

        //Closes form and reopens main form.
        private void btnClose_Click(object sender, EventArgs e)
        {
            new frmMain().Show();
            this.Close();
        }

        //Populates the "Select a Student" drobdown box from data from DB.
        private void fillStudentComboBox()
        {
            string query = "SELECT * FROM TinyCollege.studentDB";
            using (connection = new SqlConnection(connectionString))
            using (SqlCommand command = new SqlCommand(query, connection))

                //Tries to get data from the DB to populate the dropdown boxes.
                try
                {
                    connection.Open();
                    SqlDataReader myreader = command.ExecuteReader();
                    while (myreader.Read())
                    {
                        string sname = myreader.GetString(1);
                        cmbStudent.Items.Add(sname);
                    }
                }
                //Catches exemption if unable to open or read DB.
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
        }

        //Populates the "Select a Student" drobdown box from data from DB.
        private void fillCoursesComboBox()
        {
            string query = "SELECT * FROM TinyCollege.coursesDB";
            using (connection = new SqlConnection(connectionString))
            using (SqlCommand command = new SqlCommand(query, connection))

                //Tries to get data from the DB to populate the dropdown boxes.
                try
                {
                    connection.Open();
                    SqlDataReader myreader = command.ExecuteReader();
                    while (myreader.Read())
                    {
                        string courseTitle = myreader.GetString(1); // GetString number controls what column is selected from row.
                        string semester = myreader.GetString(2);
                        cmbCourse.Items.Add(courseTitle + $"- {semester}");
                    }
                }
                //Catches exemption if unable to open or read DB.
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
        }
        
        //Populates the semester label for the course selected.  
        private void fillSemesterTextBox()
        {
            Object cstring = cmbCourse.SelectedItem;
            string query = "SELECT Semester FROM TinyCollege.coursesDB WHERE Title='" + cstring + "'";
            using (connection = new SqlConnection(connectionString))
            using (SqlCommand command = new SqlCommand(query, connection))

                //Opens DB to get semester information from course selected from ddb.
                try
                {
                    connection.Open();
                    SqlDataReader myreader = command.ExecuteReader();
                    while (myreader.Read())
                    {
                        string cSem = myreader.GetString(0);
                        lblSemester.Text = cSem;
                    }
                    myreader.Close();
                }
                //If unable to open or read db, catches exemption.
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
        }

        private void StudentComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }


        //Enrolls student into class
        private void EnrollButton_Click(object sender, EventArgs e)
        {
            //Uses selected student and course and stores the data in the enrollment db.
            Object cTitle = cmbCourse.SelectedItem;
            Object sName = cmbStudent.SelectedItem;
            Object Sem = lblSemester.Text; // holds value for easy use in error message output.
            string query = "INSERT INTO TinyCollege.enrollmentDB(studentName, coursesTitle, studentId, courseId) " +
                "SELECT Name, Title, studentId, courseId FROM TinyCollege.studentDB, TinyCollege.coursesDB " +
                "WHERE studentDB.studentId = (SELECT studentId FROM TinyCollege.studentDB WHERE Name = '"+ sName + "') " +
                "AND coursesDB.courseId = (SELECT courseId FROM TinyCollege.coursesDB WHERE Title = '" + cTitle + "');"; // searches database for information in a specific order. Don't change. Nested queries end up returning data matching user input from combobox.
            using (connection = new SqlConnection(connectionString))
            using (SqlCommand command = new SqlCommand(query, connection))
            
                //Checks to make sure that the student is not already enrolled in the class selected.
                try
                {
                    connection.Open();
                    command.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    toolStripStatusLabel1.Text = $"{sName} is already enrolled in {cTitle} for {Sem} semester.";
                }
        }

        //----------------------------------------------------------
        //Instructions when the mouse is over the "Close" button.
        private void BtnClose_MouseHover(object sender, EventArgs e)
        {
            toolStripStatusLabel1.Text = "Return to previous form";
        }

        private void BtnClose_MouseLeave(object sender, EventArgs e)
        {
            toolStripStatusLabel1.Text = "";
        }
        //----------------------------------------------------------
        
        //----------------------------------------------------------
        //Instructions when the mouse is over the "Enroll" button.
        private void EnrollButton_MouseHover(object sender, EventArgs e)
        {
            toolStripStatusLabel1.Text = "Saves changes to the database";
        }

        private void EnrollButton_MouseLeave(object sender, EventArgs e)
        {
            toolStripStatusLabel1.Text = "";
        }
        //----------------------------------------------------------

        //----------------------------------------------------------
        //Instructions when the mouse is over the "Select a Student" drop-down box.
        private void CmbStudent_MouseHover(object sender, EventArgs e)
        {
            toolStripStatusLabel1.Text = "Use the drop-down menu to select a student from the database";
        }

        private void CmbStudent_MouseLeave(object sender, EventArgs e)
        {
            toolStripStatusLabel1.Text = "";
        }
        //-----------------------------------------------------------
        
        //----------------------------------------------------------
        //Instructions when the mouse is over the "Select a Course" drop-down box.
        private void CmbCourse_MouseHover(object sender, EventArgs e)
        {
            toolStripStatusLabel1.Text = "Use the drop-down menu to select a course from the database";
        }

        private void CmbCourse_MouseLeave(object sender, EventArgs e)
        {
            toolStripStatusLabel1.Text = "";
        }
        //-----------------------------------------------------------

        //-----------------------------------------------------------
        //Addresses the semester label.
        private void CmbCourse_SelectedIndexChanged(object sender, EventArgs e)
        {
            fillSemesterTextBox(); // calls method from above to fill label text
        }
        private void CmbCourse_AfterUpdate(object sender, EventArgs e)
        {
            fillSemesterTextBox(); // retains output?
        }
    }
}

