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


namespace EvaluationSystem.Folder
{
    public partial class ViewRubricsForm : Form
    {
        public ViewRubricsForm()
        {
            InitializeComponent();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {

            MainForm mainForm = new MainForm();
            mainForm.ShowDialog();

        }
    }
}
