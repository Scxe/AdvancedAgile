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
            string query = "SELECT * FROM studentDB WHERE Id='" + txtStudentId.Text + "'";
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
                SqlDataAdapter adapter = new SqlDataAdapter("SELECT coursesTitle FROM enrollmentDB WHERE studentName='" + cTitle + "'", connection);
                DataTable courseFind = new DataTable();
                adapter.Fill(courseFind);

                lstCoursesByStudents.Items.Clear();
                foreach (DataRow dr in courseFind.Rows)
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
    }
}
