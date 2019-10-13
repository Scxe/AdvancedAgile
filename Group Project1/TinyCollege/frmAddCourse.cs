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
using System.Web;

namespace TinyCollege
{
   
    public partial class frmAddCourse : Form
    {
        //SQL connection and string variable used for form.
        SqlConnection connection;
        string connectionString;
        
        public frmAddCourse()
        {
            InitializeComponent();
            connectionString = ConfigurationManager.ConnectionStrings["TinyCollege.Properties.Settings.StudentDBConnectionString"].ConnectionString;
        }
        
        //Closes add course form and reopens main form.
        private void Button1_Click(object sender, EventArgs e)
        {
            this.Close();
            new frmMain().Show();
        }

        //Adds course title and semester information to DB
        private void BtnAddCourse_Click(object sender, EventArgs e)
        {
        
            //Prevents adding empty data to the DB
            if (txtCourseTitle.Text == string.Empty)
            {
                toolStripStatusLabel1.Text = "Enter a course name in the field before clicking 'Add Course'";
            }
            else
            {
                 // SQL command to check database for both courseTitle AND Semester. This is used below to fill DataSet
                string exists = "SELECT * FROM TinyCollege.coursesDB WHERE Title='" + txtCourseTitle.Text + "' AND Semester='"+ txtSemOffered.Text + "'"; 

                using (connection = new SqlConnection(connectionString))
                using (SqlDataAdapter adapter = new SqlDataAdapter(exists, connection))
                {
                    DataSet courseTitleSem = new DataSet(); //DataTable doesn't work here, must be DataSet.
                    adapter.Fill(courseTitleSem);
                    int rowCount = courseTitleSem.Tables[0].Rows.Count;
                    
                    /* Basically, the adapter fills the data from the SQL query into DataSet, and only populates it if there's information 
                    that matches whats in the textboxes (supplied by user). This would make a row index of 1, 2, etc.*/
                    if (rowCount > 0) 
                    {
                        toolStripStatusLabel1.Text = "This Course Title/Semester combination is already being offered. Enter something else.";
                        courseTitleSem.Clear();
                    }
                    
                    //Enters data into DB once verified it is not duplicate data.
                    else
                    {
                        string query = "INSERT INTO TinyCollege.coursesDB VALUES('" + txtCourseTitle.Text + "','" + txtSemOffered.Text + "')";

                        using (connection = new SqlConnection(connectionString))
                        using (SqlCommand command = new SqlCommand(query, connection))
                        {
                            connection.Open();
                            command.ExecuteNonQuery();
                        }
                        txtCourseTitle.Clear();
                        txtSemOffered.Clear();
                    }
                }
            }
        }
        
        //Form has no initial load
        private void frmAddCourse_Load(object sender, EventArgs e)
        {
           
        }

        //-----------------------------------------------------------------------
        //Instructions for when the mouse is on and off of "Course Title" text box.
        private void TxtCourseTitle_MouseHover(object sender, EventArgs e)
        {
            toolStripStatusLabel1.Text = "Enter the course title";
        }

        private void TxtCourseTitle_MouseLeave(object sender, EventArgs e)
        {
            toolStripStatusLabel1.Text = "";
        }
        //------------------------------------------------------------------------

        //------------------------------------------------------------------------
        //Instructions for when the mouse is on or off of the "Semester Offered" text box.
        private void TxtSemOffered_MouseHover(object sender, EventArgs e)
        {
            toolStripStatusLabel1.Text = "Enter the semester the course is offered in";
        }

        private void TxtSemOffered_MouseLeave(object sender, EventArgs e)
        {
            toolStripStatusLabel1.Text = "";
        }
        //------------------------------------------------------------------------

        //------------------------------------------------------------------------
        //Instructions for when the mouse is on or off of the "Add Course" button.
        private void BtnAddCourse_MouseHover(object sender, EventArgs e)
        {
            toolStripStatusLabel1.Text = "Saves changes to the database";
        }

        private void BtnAddCourse_MouseLeave(object sender, EventArgs e)
        {
            toolStripStatusLabel1.Text = "";
        }
        //------------------------------------------------------------------------

        //------------------------------------------------------------------------
        ////Instructions for when the mouse is on or off of the "Close" button.
        private void BtnClose_MouseHover(object sender, EventArgs e)
        {
            toolStripStatusLabel1.Text = "Return to previous form";
        }

        private void BtnClose_MouseLeave(object sender, EventArgs e)
        {
            toolStripStatusLabel1.Text = "";
        }
        //------------------------------------------------------------------------

        //------------------------------------------------------------------------
        //Prevents keys that are not letters from populating in the text boxes when pressed.
        private void TxtCourseTitle_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsLetterOrDigit(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar))
            {
                e.Handled = true; //this method activates on keypress. If KeyChar is the key user presses. If not letter, digit, or whitespace, or a control/special
                // character, user can enter it. Otherwise, it's "handled" by the system and not entered.
            }
        }

        private void TxtSemOffered_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsLetterOrDigit(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar))
            {
                e.Handled = true; //this method activates on keypress. If KeyChar is the key user presses. If not letter, digit, or whitespace, or a control/special
                // character, user can enter it. Otherwise, it's "handled" by the system and not entered.
            }
        }
    }
}
