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
        SqlConnection connection;
        string connectionString;
        public frmEnrollment()
        {
            InitializeComponent();
            connectionString = ConfigurationManager.ConnectionStrings["TinyCollege.Properties.Settings.StudentDBConnectionString"].ConnectionString;
            fillStudentComboBox();
            fillCoursesComboBox();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            new frmMain().Show();
            this.Close();
        }

        private void fillStudentComboBox()
        {
            string query = "SELECT * FROM studentDB";
            using (connection = new SqlConnection(connectionString))
            using (SqlCommand command = new SqlCommand(query, connection))

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
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
        }

        private void fillCoursesComboBox()
        {
            string query = "SELECT * FROM coursesDB";
            using (connection = new SqlConnection(connectionString))
            using (SqlCommand command = new SqlCommand(query, connection))

                try
                {
                    connection.Open();
                    SqlDataReader myreader = command.ExecuteReader();
                    while (myreader.Read())
                    {
                        string sname = myreader.GetString(1);
                        cmbCourse.Items.Add(sname);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
        }

        private void StudentComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }



        private void EnrollButton_Click(object sender, EventArgs e)
        {

            Object cTitle = cmbCourse.SelectedItem;
            Object sName = cmbStudent.SelectedItem;
            string query = "INSERT INTO enrollmentDB (studentName, coursesTitle) VALUES ('" + sName + "','" + cTitle + "')";
            using (connection = new SqlConnection(connectionString))
            using (SqlCommand command = new SqlCommand(query, connection))

            {
                connection.Open();
                command.ExecuteNonQuery();
            }
        }
    }
}

