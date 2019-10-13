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
    public partial class frmWhoIsInACourse : Form
    {
        SqlConnection connection;
        string connectionString;
        
        public frmWhoIsInACourse()
        {
            InitializeComponent();
            connectionString = ConfigurationManager.ConnectionStrings["TinyCollege.Properties.Settings.StudentDBConnectionString"].ConnectionString;
            fillCoursesTextBox();
        }

        //Closes form and opens main menu.
        private void BtnClose_Click(object sender, EventArgs e)
        {
            new frmMain().Show();
            this.Close();
        }

        //Gets courses from db for student selected.
        private void fillCoursesTextBox()
        {
            string query = "SELECT * FROM TinyCollege.coursesDB WHERE courseId='"+ txtCourseId.Text +"'";
            using (connection = new SqlConnection(connectionString))
            using (SqlCommand command = new SqlCommand(query, connection))

                //Checks for courses
                try
                {
                    connection.Open();
                    SqlDataReader myreader = command.ExecuteReader();
                    while (myreader.Read())
                    {
                        string cTitle = myreader.GetString(1);
                        txtCourseTitle.Text = cTitle;
                    }
                    myreader.Close();
                }
                
                //Catches exceptions thrown.
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
        }

        //Populates the course listbox.
        private void PopulateCourseListBox()
        {
            string cTitle = txtCourseTitle.Text;
            
            //Adds all courses for the student to the listbox.
            using (connection = new SqlConnection(connectionString))
            {
                SqlDataAdapter adapter = new SqlDataAdapter("SELECT studentName FROM TinyCollege.enrollmentDB WHERE coursesTitle='" + cTitle+"'" , connection);
                DataTable courseFind = new DataTable();
                adapter.Fill(courseFind);

                lstStudentsEnrolled.Items.Clear();
                foreach(DataRow dr in courseFind.Rows)
                {
                    lstStudentsEnrolled.Items.Add(dr["studentName"].ToString());
                }

            }
        }

        //Displays courses for student after "Find" button is clicked.
        private void BtnFind_Click(object sender, EventArgs e)
        {

            lstStudentsEnrolled.Items.Clear();
            txtCourseTitle.Text = "";

            fillCoursesTextBox();
            PopulateCourseListBox();

            string cTitle = txtCourseTitle.Text;
            
            using (connection = new SqlConnection(connectionString))
            {
                SqlDataAdapter adapter = new SqlDataAdapter("SELECT studentName FROM TinyCollege.enrollmentDB WHERE coursesTitle='" + cTitle + "'", connection);
                DataTable studentFind = new DataTable();
                adapter.Fill(studentFind);


                lstStudentsEnrolled.Items.Clear();

                //Checks to see if course exists in DB
                while (studentFind.Rows.Count == 0)
                {
                    if (studentFind.Rows.Count == 0)
                    {
                        toolStripStatusLabel1.Text = "Course ID does not exist in database.";
                    }
                    break;
                }
                
                //Populates the listbox with students in selected course.
                while (studentFind.Rows.Count != 0)
                {
                    foreach (DataRow dr in studentFind.Rows)
                    {

                        lstStudentsEnrolled.Items.Add(dr["studentName"].ToString());

                    }
                    studentFind.Reset();
                    break;
                }
            }
        }

        private void Label2_Click(object sender, EventArgs e)
        {

        }

        //----------------------------------------------------------
        //Instructions when mouse is moved over and off of the "Close" button.
        private void BtnClose_MouseHover(object sender, EventArgs e)
        {
            toolStripStatusLabel1.Text = "Return to previous form";
        }

        private void BtnClose_MouseLeave(object sender, EventArgs e)
        {
            toolStripStatusLabel1.Text = "";
        }
        //-----------------------------------------------------------
        
        //-----------------------------------------------------------
        //Instructions when mouse is moved over and off of the "Course ID" text box.
        private void TxtCourseId_MouseHover(object sender, EventArgs e)
        {
            toolStripStatusLabel1.Text = "Enter the course id, then click 'Find'";
        }

        private void TxtCourseId_MouseLeave(object sender, EventArgs e)
        {
            toolStripStatusLabel1.Text = "";
        }
        //------------------------------------------------------------
        
        //------------------------------------------------------------
        //Instructions when mouse is moved over and off of the "Find" button.
        private void BtnFind_MouseHover(object sender, EventArgs e)
        {
            toolStripStatusLabel1.Text = "Searches the database for students enrolled in the course";
        }

        private void BtnFind_MouseLeave(object sender, EventArgs e)
        {
            toolStripStatusLabel1.Text = "";
        }
        //------------------------------------------------------------
        
        //Prevents from typing charcters other than numbers and letters in the "Course ID" textbox.
        private void TxtCourseId_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsLetterOrDigit(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar))
            {
                e.Handled = true; //this method activates on keypress. If KeyChar is the key user presses. If not letter, or whitespace, or a control/special
                // character, user can enter it. Otherwise, it's "handled" by the system and not entered.
            }
        }
    }
}
