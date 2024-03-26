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


namespace EvaluationSystem.Forms
{
    public partial class CLOsForm : Form
    {
        private string constr = "Data Source=GREY\\SQLEXPRESS;Initial Catalog=ProjectB;Integrated Security=True";

        public CLOsForm()
        {
            InitializeComponent();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            MainForm mainForm = new MainForm();
            mainForm.ShowDialog();

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void cloAdd_Click(object sender, EventArgs e)
        {

            addCLO(sender, e);
            resetCLO();

        }


        private void addCLO(object sender, EventArgs e)
        {

            SqlConnection con = new SqlConnection(constr);
            con.Open();
            SqlCommand cmd = new SqlCommand("insert into CLo values(@CLOName, GetDate(), GetDate())", con);
            cmd.Parameters.AddWithValue("@CLOName", clotextBox.Text);
            if (!CheckClo())
            {
                cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("CLO inserted successfully", "Inserted", MessageBoxButtons.OK, MessageBoxIcon.Information);
                printCLO();
            }
            else
            {
                con.Close();
                MessageBox.Show("CLO name already exist", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void CLOsForm_Load(object sender, EventArgs e)
        {
            printCLO();
        }

        private void resetCLO()
        {
            clotextBox.Clear();
        }

        private void printCLO()
        {

            string query = "SELECT * FROM CLo";

            using (SqlConnection connection = new SqlConnection(constr))
            {
                SqlCommand command = new SqlCommand(query, connection);
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                DataTable dataTable = new DataTable();
                dataTable.Load(reader);
                CLOGrid.DataSource = dataTable;
                reader.Close();
                connection.Close();
            }
        }

        private bool CheckClo()
        {
            SqlConnection con = new SqlConnection(constr);
            con.Open();
            SqlCommand cmd = new SqlCommand("SELECT COUNT(*) FROM clo where name = @name", con);
            cmd.Parameters.AddWithValue("@name", clotextBox.Text);
            int count = (int)(cmd.ExecuteScalar());

            con.Close();

            // If count is greater than 0, it means the date exists
            return count > 0;
        }

        private void UpdateButton_Click(object sender, EventArgs e)
        {

            modifyCLO(sender, e);
            resetCLO();

        }
        private void modifyCLO(object sender, EventArgs e)
        {
            int CLoID = Convert.ToInt32(CLOGrid.SelectedRows[0].Cells[0].Value); // gets the id of selected row
            DateTime Date = Convert.ToDateTime(CLOGrid.SelectedRows[0].Cells[2].Value); // gets the date from selected row


            SqlConnection con = new SqlConnection(constr);
            con.Open();
            SqlCommand cmd = new SqlCommand("Update CLo SET Name=@Name,DateCreated = @dateCreated ,DateUpdated = GetDate() Where ID=@ID", con);
            cmd.Parameters.AddWithValue("@Name", clotextBox.Text);
            cmd.Parameters.AddWithValue("@dateCreated", Date);
            cmd.Parameters.AddWithValue("@ID", CLoID);
            if (!CheckClo())
            {
                cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("CLO updated successfully", "Updated", MessageBoxButtons.OK, MessageBoxIcon.Information);
                printCLO();
            }
            else
            {
                con.Close();
                MessageBox.Show("CLO name already exist", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {

            int rowIndex = Convert.ToInt32(CLOGrid.SelectedRows[0].Cells[0].Value);
            string deleteQuery = "DELETE FROM CLo WHERE id = @CLoId";
            using (SqlConnection connection = new SqlConnection(constr))
            {
                using (SqlCommand command = new SqlCommand(deleteQuery, connection))
                {
                    command.Parameters.AddWithValue("@CloId", rowIndex);

                    try
                    {
                        connection.Open();
                        command.ExecuteNonQuery();
                        connection.Close();
                        MessageBox.Show("Successfully Deleted!");
                        printCLO();

                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine("Error: " + ex.Message);
                    }
                }
            }

        }


    }
}
