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

        SqlConnection connection;
        string connectionString;

        public frmAddCourse()
        {
            InitializeComponent();
            connectionString = ConfigurationManager.ConnectionStrings["TinyCollege.Properties.Settings.StudentDBConnectionString"].ConnectionString;
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            this.Close();
            new frmMain().Show();
        }

        private void BtnAddCourse_Click(object sender, EventArgs e)
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
        private void frmAddCourse_Load(object sender, EventArgs e)
        {
           
        }

        private void TxtCourseTitle_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
