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

        private void TxtCourseTitle_MouseHover(object sender, EventArgs e)
        {
            toolStripStatusLabel1.Text = "Enter the course title";
        }

        private void TxtCourseTitle_MouseLeave(object sender, EventArgs e)
        {
            toolStripStatusLabel1.Text = "";
        }

        private void TxtSemOffered_MouseHover(object sender, EventArgs e)
        {
            toolStripStatusLabel1.Text = "Enter the semester the course is offered in";
        }

        private void TxtSemOffered_MouseLeave(object sender, EventArgs e)
        {
            toolStripStatusLabel1.Text = "";
        }

        private void BtnAddCourse_MouseHover(object sender, EventArgs e)
        {
            toolStripStatusLabel1.Text = "Saves changes to the database";
        }

        private void BtnAddCourse_MouseLeave(object sender, EventArgs e)
        {
            toolStripStatusLabel1.Text = "";
        }

        private void BtnClose_MouseHover(object sender, EventArgs e)
        {
            toolStripStatusLabel1.Text = "Return to previous form";
        }

        private void BtnClose_MouseLeave(object sender, EventArgs e)
        {
            toolStripStatusLabel1.Text = "";
        }

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
