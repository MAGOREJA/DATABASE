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
    public partial class AttendenceForm : Form
    {
        private string constr = "Data Source=GREY\\SQLEXPRESS;Initial Catalog=ProjectB;Integrated Security=True";

        public AttendenceForm()
        {
            InitializeComponent();
            fillComboRegistration();

        }

        private void fillComboRegistration()
        {

            string query = "SELECT * FROM Student";

            using (SqlConnection connection = new SqlConnection(constr))
            {
                SqlCommand command = new SqlCommand(query, connection);
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    string reg = reader.GetString(5);
                    RegCombo.Items.Add(reg);

                }


                reader.Close();
                connection.Close();
            }
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            if (RegCombo.SelectedItem == null)
            {
                errorProvider1.SetError(attendanceGrid, "It cannot be empty.");
                return;
            }
            else
            {
                errorProvider1.SetError(attendanceGrid, string.Empty);

            }


            if (statusAtt.SelectedItem == null)
            {
                errorProvider2.SetError(statusAtt, "It cannot be empty.");
                return;
            }
            else
            {
                errorProvider2.SetError(statusAtt, string.Empty);

            }
            saveAttendanceDate();


        }

        private void printAttendance()
        {


            using (SqlConnection connection = new SqlConnection(constr))
            {
                SqlCommand command = new SqlCommand("SELECT CONCAT(Student.firstName, ' ', Student.LastName) AS Name, (ClassAttendance.AttendanceDate) AS AttendanceDate ,  lookup.name as Status FROM Student JOIN StudentAttendance ON Student.id = StudentAttendance.StudentId JOIN ClassAttendance ON ClassAttendance.Id = StudentAttendance.AttendanceId join lookup on lookup.lookupid = StudentAttendance.attendancestatus WHERE (ClassAttendance.AttendanceDate) = @date;", connection);
                connection.Open();
                command.Parameters.AddWithValue("@date", dateTimePicker.Value.Date);
                SqlDataReader reader = command.ExecuteReader();
                DataTable dataTable = new DataTable();
                dataTable.Load(reader);
                attendanceGrid.DataSource = dataTable;
                reader.Close();
                connection.Close();
            }
        }

        private void saveAttendanceDate()
        {
            ADDDate();
            int dateId = FindDateID();
            int studenId = FindStudentId();

            using (SqlConnection con = new SqlConnection(constr))
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("INSERT INTO StudentAttendance (AttendanceId, StudentId, AttendanceStatus) VALUES (@attendanceId, @studentId, @status)", con);
                if (studenId != -1)
                {
                    cmd.Parameters.AddWithValue("@studentId", studenId);
                }
                else
                {
                    return;
                }
                if (dateId != -1)
                {
                    cmd.Parameters.AddWithValue("@attendanceId", dateId);
                }
                else
                {
                    return;
                }
                if (!CheckStudentExist(studenId))
                {
                    int number = giveNumber();
                    cmd.Parameters.AddWithValue("@status", number);
                    cmd.ExecuteNonQuery();
                    con.Close();
                    MessageBox.Show("Attendance added successfully", "Saved", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    printAttendance();
                }
                else
                {
                    MessageBox.Show("Student Already Exist In the Context", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    
                }

            }






        }
        


        private int giveNumber()
        {
            if (statusAtt.Text == "Present")
            {
                return 1;
            }
            else if (statusAtt.Text == "Absent")
            {
                return 2;
            }
            else if (statusAtt.Text == "Leave")
            {
                return 3;
            }
            else { return 4; }
        }




        private void ADDDate()
        {

            SqlConnection con = new SqlConnection(constr);
            con.Open();
            if (!CheckDateExist())
            {
                SqlCommand cmd = new SqlCommand("INSERT INTO ClassAttendance (AttendanceDate) VALUES (@date)", con);
                cmd.Parameters.AddWithValue("@date", dateTimePicker.Value.Date);
                cmd.ExecuteNonQuery();
                con.Close();

            }

        }

        private int FindDateID()
        {
            int dateId = -1;

            SqlConnection con = new SqlConnection(constr);
            con.Open();
            SqlCommand cmd = new SqlCommand("Select id from ClassAttendance where AttendanceDate = @date", con);
            cmd.Parameters.AddWithValue("@date", Convert.ToDateTime(dateTimePicker.Value.Date));

            SqlDataReader reader = cmd.ExecuteReader();
            if (reader.Read())
            {
                dateId = Convert.ToInt32(reader["id"]);
            }

            con.Close();

            return dateId;

        }

        private bool CheckStudentExist(int studentId)
        {

            SqlConnection con = new SqlConnection(constr);
            con.Open();
            SqlCommand cmd = new SqlCommand("SELECT COUNT(*) FROM ClassAttendance join StudentAttendance on ClassAttendance.id = StudentAttendance.AttendanceId WHERE AttendanceDate = @date AND StudentAttendance.StudentId = @StudentId", con);
            cmd.Parameters.AddWithValue("@date", Convert.ToDateTime(dateTimePicker.Value.Date));
            cmd.Parameters.AddWithValue("@StudentId", studentId);
            int count = (int)(cmd.ExecuteScalar());

            con.Close();

            // If count is greater than 0, it means the date exists
            return count > 0;
        }

        private bool CheckDateExist()
        {

            SqlConnection con = new SqlConnection(constr);
            con.Open();
            SqlCommand cmd = new SqlCommand("Select count(*)from ClassAttendance where AttendanceDate = @date", con);
            cmd.Parameters.AddWithValue("@date", Convert.ToDateTime(dateTimePicker.Value.Date));
            int count = (int)(cmd.ExecuteScalar());

            con.Close();

            // If count is greater than 0, it means the date exists
            return count > 0;



        }

        private int FindStudentId()
        {
            int studentId = -1;

            SqlConnection con = new SqlConnection(constr);
            con.Open();
            SqlCommand cmd = new SqlCommand("Select id from Student where RegistrationNumber = @reg", con);
            cmd.Parameters.AddWithValue("@reg", attendanceGrid.Text);
            SqlDataReader reader = cmd.ExecuteReader();
            if (reader.Read())
            {
                studentId = Convert.ToInt32(reader["id"]);
            }

            con.Close();

            return studentId;
        }


        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {

            MainForm mainForm = new MainForm();
            mainForm.ShowDialog();
        }

        private void RegCombo_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            printAttendance();
        }

        private void attendanceGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
