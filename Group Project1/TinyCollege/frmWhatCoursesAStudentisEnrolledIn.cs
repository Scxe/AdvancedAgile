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
            string query = "SELECT * FROM TinyCollege.studentDB WHERE Id='" + txtStudentId.Text + "'";
            using (connection = new SqlConnection(connectionString))
            using (SqlCommand command = new SqlCommand(query, connection))

                try
                {
                    connection.Open();
                    SqlDataReader myreader = command.ExecuteReader();
                    while (myreader.Read())
                    {
                        string cTitle = myreader.GetString(1);
                        txtStudentName.Text = cTitle;
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
            string cTitle = txtStudentName.Text;
            using (connection = new SqlConnection(connectionString))

            {
                SqlDataAdapter adapter = new SqlDataAdapter("SELECT coursesTitle FROM TinyCollege.enrollmentDB WHERE studentName='" + cTitle + "'", connection);
                DataTable studentFind = new DataTable();
                adapter.Fill(studentFind);

                lstCoursesByStudents.Items.Clear();
                foreach (DataRow dr in studentFind.Rows)
                {
                    lstCoursesByStudents.Items.Add(dr["coursesTitle"].ToString());
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
            fillStudentTextBox();
            PopulateStudentListBox();
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
    }
}
