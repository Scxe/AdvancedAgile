using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TinyCollege
{
    public partial class frmWhatCoursesAStudentisEnrolledIn : Form
    {
        public frmWhatCoursesAStudentisEnrolledIn()
        {
            InitializeComponent();
        }

        private void BtnClose_Click(object sender, EventArgs e)
        {
            new frmMain().Show();
            this.Close();
        }
    }
}
