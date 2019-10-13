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
    public partial class frmWhatCoursesAStudentisEnrolledIn : Form
    {
        SqlConnection connection;
        string connectionString;
        public frmWhatCoursesAStudentisEnrolledIn()
        {
            InitializeComponent();
            connectionString = ConfigurationManager.ConnectionStrings["TinyCollege.Properties.Settings.StudentDBConnectionString"].ConnectionString;
        }

        //Displays student name in "Student Name" label.
        private void fillStudentTextBox()
        {
            //Finds correct student based on ID entered.
            string query = "SELECT * FROM TinyCollege.studentDB WHERE studentId='" + txtStudentId.Text + "'";
            using (connection = new SqlConnection(connectionString))
            using (SqlCommand command = new SqlCommand(query, connection))

                //Tries to find student name in DB and displays in "Student Name" label.
                try
                {
                    connection.Open();
                    SqlDataReader myreader = command.ExecuteReader();
                    while (myreader.Read())
                    {
                        string sName = myreader.GetString(1);
                        txtStudentName.Text = sName;
                    }
                    myreader.Close();
                } 
                
                //If exemption is thrown, displays error message.
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
        }

        //Displays courses that student is enrolled in.
        private void PopulateStudentListBox()
        {
            string sName = txtStudentName.Text;
            
            //Copies data for student into the "All Courses by This Student" list box.
            using (connection = new SqlConnection(connectionString))
            {
                SqlDataAdapter adapter = new SqlDataAdapter("SELECT coursesTitle FROM TinyCollege.enrollmentDB WHERE studentName='" + sName + "'", connection);
                DataTable studentFind = new DataTable();
                adapter.Fill(studentFind);
                
                //Clears the courses listbox and tries to repopulate the courses listbox
                try
                {
                    lstCoursesByStudents.Items.Clear();
                    foreach (DataRow dr in studentFind.Rows)
                    {
                        lstCoursesByStudents.Items.Add(dr["coursesTitle"].ToString());
                    }
                }
                
                //Catches exceptions
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }
        
        //Closes form and opens main form.
        private void BtnClose_Click(object sender, EventArgs e)
        {
            new frmMain().Show();
            this.Close();
        }

        //"Find" button code.
        private void BtnFind_Click(object sender, EventArgs e)
        {

            lstCoursesByStudents.Items.Clear();
            txtStudentName.Text = "";
            fillStudentTextBox();
            PopulateStudentListBox();

            string cTitle = txtStudentName.Text;
            
            using (connection = new SqlConnection(connectionString))
            {
                SqlDataAdapter adapter = new SqlDataAdapter("SELECT coursesTitle FROM TinyCollege.enrollmentDB WHERE studentName='" + cTitle + "'", connection);
                DataTable studentFind = new DataTable();
                adapter.Fill(studentFind);

                lstCoursesByStudents.Items.Clear();

                //Checks if user is enrolled in courses.
                while (studentFind.Rows.Count == 0)
                {
                    if (studentFind.Rows.Count == 0)
                    {
                        toolStripStatusLabel1.Text = "Student enrollment data not found.";
                    }
                    break;
                }
                
                //Lists courses in listbox.
                while (studentFind.Rows.Count != 0)
                {
                    foreach (DataRow dr in studentFind.Rows)
                    {

                        lstCoursesByStudents.Items.Add(dr["coursesTitle"].ToString());

                    }
                    studentFind.Reset();
                    break;
                }
            }
        }

        //------------------------------------------------------------
        //Instructions for when the mouse is on and off of "Close" button.
        private void BtnClose_MouseHover(object sender, EventArgs e)
        {
            toolStripStatusLabel1.Text = "Return to previous form";
        }

        private void BtnClose_MouseLeave(object sender, EventArgs e)
        {
            toolStripStatusLabel1.Text = "";
        }
        //--------------------------------------------------------------

        //--------------------------------------------------------------
        //Instructions for when the mouse is on and off of the "Student ID" text box.
        private void TxtStudentId_MouseHover(object sender, EventArgs e)
        {
            toolStripStatusLabel1.Text = "Enter the student id, then click 'Find'";
        }

        private void TxtStudentId_MouseLeave(object sender, EventArgs e)
        {
            toolStripStatusLabel1.Text = "";
        }
        //---------------------------------------------------------------
        
        //---------------------------------------------------------------
        //Instructions for when the mouse is on and off of the "Find" button.
        private void BtnFind_MouseHover(object sender, EventArgs e)
        {
            toolStripStatusLabel1.Text = "Searches the database for courses enrolled in by the student";
        }

        private void BtnFind_MouseLeave(object sender, EventArgs e)
        {
            toolStripStatusLabel1.Text = "";
        }
        //----------------------------------------------------------------
        
        //Prevents characters other than numbers from being typed in the "Student ID" text box.
        private void TxtStudentId_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar))
            {
                e.Handled = true; //this method activates on keypress. If KeyChar is the key user presses. If not digit, or whitespace, or a control/special
                // character, user can enter it. Otherwise, it's "handled" by the system and not entered.
            }
        }
    }
}
