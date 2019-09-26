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

        private void BtnAddStudent_Click(object sender, EventArgs e)
        {
            string query = "INSERT INTO studentDB VALUES (@studentDBName)";

            using (connection = new SqlConnection(connectionString))
            using (SqlCommand command = new SqlCommand(query, connection))
            {
                connection.Open();
                command.Parameters.AddWithValue("@studentDBName", txtStudentName.Text);
                command.ExecuteScalar();
            }
            txtStudentName.Clear();
            PopulatestudentDB();
        }
        private void frmStudentAdd_Load(object sender, EventArgs e)
        {
            PopulatestudentDB();
        }
        private void PopulatestudentDB()
        {
            using (connection = new SqlConnection(connectionString))
            using (SqlDataAdapter adapter = new SqlDataAdapter("SELECT * FROM studentDB", connection))
            {
                DataTable studentdbTable = new DataTable();
                adapter.Fill(studentdbTable);

                lstTestBox.DisplayMember = "Name";
                lstTestBox.ValueMember = "Id";
                lstTestBox.DataSource = studentdbTable;
            }
        }

        private void LstTestBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void BtnClose_Click(object sender, EventArgs e)
        {
            new frmMain().Show();
            this.Close();
        }
    }
}
