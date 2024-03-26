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

namespace EvaluationSystem
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Forms.CLOsForm addStfrm = new Forms.CLOsForm();
            addStfrm.ShowDialog();
        }

        private void student_Click(object sender, EventArgs e)
        {
            Folder.AddStudentForm addStfrm = new Folder.AddStudentForm();
            addStfrm.ShowDialog();

        }


        private void attendencebutton_Click(object sender, EventArgs e)
        {
            Folder.AttendenceForm addStfrm = new Folder.AttendenceForm();
            addStfrm.ShowDialog();


        }

        private void components1_Click(object sender, EventArgs e)
        {

            Folder.AddAssessmentForm addStfrm = new Folder.AddAssessmentForm();
            addStfrm.ShowDialog();

        }

        private void assessments_Click(object sender, EventArgs e)
        {
            Folder.AddAssessmentForm addStfrm = new Folder.AddAssessmentForm();
            addStfrm.ShowDialog();

        }

        private void rubric_Click(object sender, EventArgs e)
        {

            Folder.ViewRubricsForm addStfrm = new Folder.ViewRubricsForm();
            addStfrm.ShowDialog();
        }
        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }
        private void pictureBox5_Click(object sender, EventArgs e)
        {

        }

        private void studentlogo_Click(object sender, EventArgs e)
        {

        }

        private void header_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
