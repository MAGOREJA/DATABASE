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
    public partial class AddStudentForm : Form
    {
        private string constr = "Data Source=GREY\\SQLEXPRESS;Initial Catalog=ProjectB;Integrated Security=True";

        public AddStudentForm()
        {
            InitializeComponent();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            MainForm mainForm = new MainForm();
            mainForm.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void addButton_Click(object sender, EventArgs e)
        {

            addStudent(sender, e);
        }

        private void addStudent(object sender, EventArgs e)
        {

            using (SqlConnection con = new SqlConnection(constr))
            {
                con.Open();

                if (con.State == ConnectionState.Open) // Check if connection is established
                {
                    SqlCommand cmd = new SqlCommand("insert into Student (FirstName, LastName, Contact, Email, RegistrationNumber, Status) values (@FirstName, @LastName, @Contact, @Email, @RegistrationNumber, @Status) ", con);
                    cmd.Parameters.AddWithValue("@FirstName", firstNametextBox.Text);
                    cmd.Parameters.AddWithValue("@LastName", lastNametextBox.Text);
                    cmd.Parameters.AddWithValue("@Contact", textBox1.Text);
                    cmd.Parameters.AddWithValue("@Email", depttextBox.Text);
                    cmd.Parameters.AddWithValue("@RegistrationNumber", regdNotextBox.Text);

                    if (comboBox1.Text == "Active")
                    {
                        cmd.Parameters.AddWithValue("@Status", 5);
                    }
                    else
                    {
                        cmd.Parameters.AddWithValue("@Status", 6);
                    }

                    if (!CheckStudentExist())
                    {
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Student added successfully", "Added", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        printStudent();
                        ResetInput();
                    }
                    else
                    {
                        MessageBox.Show("Student already exists with the registration number", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        ResetInput();
                    }
                }
                else
                {
                    MessageBox.Show("Connection not established", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

        }

        private void modifyStudent(object sender, EventArgs e)
        {
            int StudentID = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells[0].Value); // gets the id of selected row

            using (SqlConnection con = new SqlConnection(constr))
            {
                con.Open();

                if (con.State == ConnectionState.Open) // Check if connection is established
                {
                    SqlCommand cmd = new SqlCommand("Update Student SET FirstName=@FirstName, LastName=@LastName, Contact=@Contact, Email=@Email, RegistrationNumber=@RegistrationNumber, Status=@Status Where ID=@ID", con);
                    cmd.Parameters.AddWithValue("@FirstName", firstNametextBox.Text);
                    cmd.Parameters.AddWithValue("@LastName", lastNametextBox.Text);
                    cmd.Parameters.AddWithValue("@Contact", textBox1.Text);
                    cmd.Parameters.AddWithValue("@Email", depttextBox.Text);
                    cmd.Parameters.AddWithValue("@RegistrationNumber", regdNotextBox.Text);

                    if (comboBox1.Text == "Active")
                    {
                        cmd.Parameters.AddWithValue("@Status", 5);
                    }
                    else
                    {
                        cmd.Parameters.AddWithValue("@Status", 6);
                    }

                    cmd.Parameters.AddWithValue("@ID", StudentID);

                    
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Student updated successfully", "Updated", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        printStudent();
                        ResetInput();
                    
                   
                }
                else
                {
                    MessageBox.Show("Connection not established", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }


        private void printStudent()
        {

            string query = "SELECT * FROM Student";

            using (SqlConnection connection = new SqlConnection(constr))
            {
                connection.Open();

                if (connection.State == ConnectionState.Open)
                {
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {

                        SqlDataReader reader = command.ExecuteReader();
                        DataTable dataTable = new DataTable();
                        dataTable.Load(reader);
                        dataGridView1.DataSource = dataTable;
                        reader.Close();


                    }
                }
                else
                {
                    MessageBox.Show("Connection not established", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

        }

        
        private void ResetInput()
        {
            firstNametextBox.Clear();
            lastNametextBox.Clear();
            textBox1.Clear();
            depttextBox.Clear();
            regdNotextBox.Clear();

        }

        private void button4_Click(object sender, EventArgs e)
        {
            modifyStudent(sender, e);
        }

        private void button3_Click(object sender, EventArgs e)
        {

            int rowIndex = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells[0].Value);

            string deleteQuery = "DELETE FROM student WHERE id = @StudentId";
            using (SqlConnection connection = new SqlConnection(constr))
            {
                using (SqlCommand command = new SqlCommand(deleteQuery, connection))
                {
                    command.Parameters.AddWithValue("@StudentId", rowIndex);


                    connection.Open();
                    command.ExecuteNonQuery();

                    MessageBox.Show("Successfully Deleted!");
                    printStudent();



                }
            }
        }


        private bool CheckStudentExist()
        {

            SqlConnection con = new SqlConnection(constr);
            con.Open();
            SqlCommand cmd = new SqlCommand("SELECT COUNT(*) FROM Student where RegistrationNumber = @number", con);
            cmd.Parameters.AddWithValue("@number", regdNotextBox.Text);
            int count = (int)(cmd.ExecuteScalar());

            con.Close();

            // If count is greater than 0, it means the date exists
            return count > 0;
        }

        private void validateString(object sender, EventArgs e)
        {

        }

        private bool containInt(string name)
        {
            foreach (char c in name)
            {
                if (char.IsDigit(c))
                {
                    return true;
                }
            }
            return false;
        }

        private void header_TextChanged(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            printStudent();
        }
    }


}
