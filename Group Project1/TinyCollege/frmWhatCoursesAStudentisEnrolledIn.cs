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
            fillStudentTextBox();
        }

        private void fillStudentTextBox()
        {
            string query = "SELECT * FROM TinyCollege.studentDB WHERE studentId='" + txtStudentId.Text + "'";
            using (connection = new SqlConnection(connectionString))
            using (SqlCommand command = new SqlCommand(query, connection))

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
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
        }

        private void PopulateStudentListBox()
        {
            string sName = txtStudentName.Text;
            using (connection = new SqlConnection(connectionString))

            {
                SqlDataAdapter adapter = new SqlDataAdapter("SELECT coursesTitle FROM TinyCollege.enrollmentDB WHERE studentName='" + sName + "'", connection);
                DataTable studentFind = new DataTable();
                adapter.Fill(studentFind);
                try
                {
                    lstCoursesByStudents.Items.Clear();
                    foreach (DataRow dr in studentFind.Rows)
                    {
                        lstCoursesByStudents.Items.Add(dr["coursesTitle"].ToString());
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }
        private void BtnClose_Click(object sender, EventArgs e)
        {
            new frmMain().Show();
            this.Close();
        }

        private void BtnFind_Click(object sender, EventArgs e)
        {
            if (txtStudentId.Text == string.Empty)
            {
                toolStripStatusLabel1.Text = "Enter a student ID in the field before clicking 'Find'.";
            }
            else
            {
                string exists = "SELECT * FROM TinyCollege.studentDB WHERE Name='" + txtStudentName.Text + "'";

                using (connection = new SqlConnection(connectionString))
                using (SqlDataAdapter adapter = new SqlDataAdapter(exists, connection))
                {
                    DataSet stuId = new DataSet(); //DataTable doesn't work here, must be DataSet.
                    adapter.Fill(stuId);
                    int rowCount = stuId.Tables[0].Rows.Count;
                    if (rowCount > 0)
                    {
                        toolStripStatusLabel1.Text = "Student ID does not exist in database.";
                        stuId.Clear();
                        txtStudentName.Clear(); // clears the derived information in the read-only box.
                    }
                    else
                    {
                        fillStudentTextBox();
                        PopulateStudentListBox();
                    }
                }
            }
        }

        private void BtnClose_MouseHover(object sender, EventArgs e)
        {
            toolStripStatusLabel1.Text = "Return to previous form";
        }

        private void BtnClose_MouseLeave(object sender, EventArgs e)
        {
            toolStripStatusLabel1.Text = "";
        }

        private void TxtStudentId_MouseHover(object sender, EventArgs e)
        {
            toolStripStatusLabel1.Text = "Enter the student id, then click 'Find'";
        }

        private void TxtStudentId_MouseLeave(object sender, EventArgs e)
        {
            toolStripStatusLabel1.Text = "";
        }

        private void BtnFind_MouseHover(object sender, EventArgs e)
        {
            toolStripStatusLabel1.Text = "Searches the database for courses enrolled in by the student";
        }

        private void BtnFind_MouseLeave(object sender, EventArgs e)
        {
            toolStripStatusLabel1.Text = "";
        }

        private void TxtStudentId_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsLetterOrDigit(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar))
            {
                e.Handled = true; //this method activates on keypress. If KeyChar is the key user presses. If not letter, or whitespace, or a control/special
                // character, user can enter it. Otherwise, it's "handled" by the system and not entered.
            }
        }
    }
}
