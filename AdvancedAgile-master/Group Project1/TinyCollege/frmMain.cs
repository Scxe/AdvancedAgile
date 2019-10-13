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
        public frmMain()
        {
            InitializeComponent();

            connectionString = ConfigurationManager.ConnectionStrings["TinyCollege.Properties.Settings.StudentDBConnectionString"].ConnectionString;
        }

        private void frmMain_Load(object sender, EventArgs e)
        {

        }

        private void BtnAddStudent_Click(object sender, EventArgs e)
        {
            new frmStudentAdd().Show();
            this.Hide();
        }

        private void BtnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void BtnEnroll_Click(object sender, EventArgs e)
        {
            new frmEnrollment().Show();
            this.Hide();
        }

        private void BtnAddCourses_Click(object sender, EventArgs e)
        {
            new frmAddCourse().Show();
            this.Hide();
        }

        private void BtnWho_Click(object sender, EventArgs e)
        {
            new frmWhoIsInACourse().Show();
            this.Hide();
        }

        private void BtnWhatCourses_Click(object sender, EventArgs e)
        {
            new frmWhatCoursesAStudentisEnrolledIn().Show();
            this.Hide();
        }
    }
}
