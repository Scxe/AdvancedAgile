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
using ContainsAny;

namespace TinyCollege
{
    public partial class frmStudentAdd : Form
    {
        SqlConnection connection;
        string connectionString;
        public frmStudentAdd()
        {
            InitializeComponent();

            connectionString = ConfigurationManager.ConnectionStrings["TinyCollege.Properties.Settings.StudentDBConnectionString"].ConnectionString;
        }

        private void LblNewStudentName_Click(object sender, EventArgs e)
        {

        }

        private void BtnAddStudent_Click(object sender, EventArgs e)
        {
            if (txtStudentName.Text == string.Empty)
            {
                toolStripStatusLabel1.Text = "Enter a student name in the field before clicking 'Add Student'";
            }
            else if (txtStudentName.Text.ListContainsAny("1", "2", "3", "4", "5", "6", "7", "8", "9", "0"))
            {
                toolStripStatusLabel1.Text = "Student Name cannot contain a number";
            }
           //**************************************************************************************************
            else if (txtStudentName.Text.Any(char.IsPunctuation))
            {
                // work here to make code to handle symbols. idea: use ! and a-z and A-Z to replace previous numbers only
                // validation so that it will sort through all correct characters, if not that, throw error
                toolStripStatusLabel1.Text = "Student Name cannot contain any special characters (ex. !@#).";
            }
            else if (txtStudentName.Text.Any(char.IsSymbol))
            {
                toolStripStatusLabel1.Text = "Student Name cannot contain any special characters (ex. !@#).";
            }
            //***************************************************************************************************
            else
            {
                string query = "INSERT INTO TinyCollege.studentDB VALUES (@studentDBName)";

                using (connection = new SqlConnection(connectionString))
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    connection.Open();
                    command.Parameters.AddWithValue("@studentDBName", txtStudentName.Text);
                    command.ExecuteScalar();
                }
                txtStudentName.Clear();
            }
            
        }
        private void frmStudentAdd_Load(object sender, EventArgs e)
        {

        }
    
        private void LstTestBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void BtnClose_Click(object sender, EventArgs e)
        {
            new frmMain().Show();
            this.Close();
        }

        private void TxtStudentName_MouseHover(object sender, EventArgs e)
        {
            toolStripStatusLabel1.Text = "Enter Student Name";
        }

        private void TxtStudentName_MouseLeave(object sender, EventArgs e)
        {
            toolStripStatusLabel1.Text = "";
        }

        private void BtnAddStudent_MouseHover(object sender, EventArgs e)
        {
            toolStripStatusLabel1.Text = "Saves changes to the database";
        }

        private void BtnAddStudent_MouseLeave(object sender, EventArgs e)
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
    }
}
