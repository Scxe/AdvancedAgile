﻿/*Ruben Castillo
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

        //Add Student to DB
        private void BtnAddStudent_Click(object sender, EventArgs e)
        {
            //Text box cannot be empty.
            if (txtStudentName.Text == string.Empty)
            {
                toolStripStatusLabel1.Text = "Enter a student name in the field before clicking 'Add Student'";
            }
            
            // has cleared possible issues of empty string or invalid input
            else 
            {
                string exists = "SELECT * FROM TinyCollege.studentDB WHERE Name='" + txtStudentName.Text + "'";

                //Checks and writes name to DB.
                using (connection = new SqlConnection(connectionString))
                using (SqlDataAdapter adapter = new SqlDataAdapter(exists, connection))
                {
                    DataSet stuName = new DataSet(); //DataTable doesn't work here, must be DataSet.
                    adapter.Fill(stuName);
                    int rowCount = stuName.Tables[0].Rows.Count;
                    
                    //If student name is already in DB, prevents from duplicating data.
                    if (rowCount > 0) // if there is a duplicate, this would return 1, because 0 is expected for 1 instance
                    {
                        toolStripStatusLabel1.Text = "Student name already exists. Enter a unique name.";
                        stuName.Clear();
                    }
                    
                    //Writes name to the DB.
                    else
                    {
                        string query = "INSERT INTO TinyCollege.studentDB VALUES (@studentDBName)";

                        using (connection = new SqlConnection(connectionString))
                        using (SqlCommand command2 = new SqlCommand(query, connection))
                        {
                            connection.Open();
                            command2.Parameters.AddWithValue("@studentDBName", txtStudentName.Text);
                            command2.ExecuteScalar();
                        }
                        txtStudentName.Clear();
                    }
                }
            }
            
        }
        
        //No load for form.
        private void frmStudentAdd_Load(object sender, EventArgs e)
        {

        }
    
        private void LstTestBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        //Closes the form and reopens main form.
        private void BtnClose_Click(object sender, EventArgs e)
        {
            new frmMain().Show();
            this.Close();
        }

        //----------------------------------------------------------------
        //Instructions displayed when mouse moves over and off of "New Student Name" text box.
        private void TxtStudentName_MouseHover(object sender, EventArgs e)
        {
            toolStripStatusLabel1.Text = "Enter Student Name";
        }

        private void TxtStudentName_MouseLeave(object sender, EventArgs e)
        {
            toolStripStatusLabel1.Text = "";
        }
        //------------------------------------------------------------------

        //------------------------------------------------------------------
        //Instructions displayed when the mouse moves over and off of "Add Student" button.
        private void BtnAddStudent_MouseHover(object sender, EventArgs e)
        {
            toolStripStatusLabel1.Text = "Saves changes to the database";
        }

        private void BtnAddStudent_MouseLeave(object sender, EventArgs e)
        {
            toolStripStatusLabel1.Text = "";
        }
        //-------------------------------------------------------------------

        //-------------------------------------------------------------------
        //Instructions displayed when the mouse moves over and off of "Close" button.
        private void BtnClose_MouseHover(object sender, EventArgs e)
        {
            toolStripStatusLabel1.Text = "Return to previous form";
        }

        private void BtnClose_MouseLeave(object sender, EventArgs e)
        {
            toolStripStatusLabel1.Text = "";
        }
        //---------------------------------------------------------------------

        //Prevents users from typing characters other than letters.
        private void TxtStudentName_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar))
            {
                e.Handled = true; //this method activates on keypress. If KeyChar is the key user presses. If not letter, or whitespace, or a control/special
                // character, user can enter it. Otherwise, it's "handled" by the system and not entered.
            }
        }
    }
}
