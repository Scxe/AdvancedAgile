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

        private void BtnClose_Click(object sender, EventArgs e)
        {
            new frmMain().Show();
            this.Close();
        }

        private void fillCoursesTextBox()
        {
            string query = "SELECT * FROM coursesDB WHERE Id='"+ txtCourseId.Text +"'";
            using (connection = new SqlConnection(connectionString))
            using (SqlCommand command = new SqlCommand(query, connection))

                try
                {
                    connection.Open();
                    SqlDataReader myreader = command.ExecuteReader();
                    while (myreader.Read())
                    {
                        string cTitle = myreader.GetString(1);
                        txtCourseTitle.Text = cTitle;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
        }

        private void PopulateCourseListBox()
        {
            string cTitle = txtCourseTitle.Text;
            using (connection = new SqlConnection(connectionString))

            {
                SqlDataAdapter adapter = new SqlDataAdapter("SELECT studentName FROM enrollmentDB WHERE coursesTitle='"+cTitle+"'" , connection);
                DataTable courseFind = new DataTable();
                adapter.Fill(courseFind);

                lstStudentsEnrolled.Items.Clear();
                foreach(DataRow dr in courseFind.Rows)
                {
                    lstStudentsEnrolled.Items.Add(dr["studentName"].ToString());
                }

            }
        }

        private void BtnFind_Click(object sender, EventArgs e)
        {

            fillCoursesTextBox();
            PopulateCourseListBox();
        }
    }
}
