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

namespace AMS
{
    public partial class Form2 : Form
    {
        private string loggedInAccount;
        private string loggedInPassW;
        private string loggedInID;
        SqlConnection sqlcon = new SqlConnection("Server=LAPTOP-OF-TDAT\\TDAT; Database=AMS; Initial Catalog=AMS;Integrated Security=True;Encrypt=False");
        public Form2(string account, string passW, string ID)
        {
            InitializeComponent();
            loggedInAccount = account;
            loggedInPassW = passW;
            loggedInID = ID;
            tbUSER.Text = loggedInAccount;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void tbUSER_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnclass1_Click(object sender, EventArgs e)
        {
            string studentQuery = "SELECT ClassID FROM Students WHERE StudentID = @StudentID";
            using (SqlCommand studentCommand = new SqlCommand(studentQuery, sqlcon))
            {
                sqlcon.Open();
                string classID = null;
                studentCommand.Parameters.AddWithValue("@StudentID", loggedInID);
                string classQuery = "SELECT * FROM Classes WHERE ClassID = @ClassID";
                object result = studentCommand.ExecuteScalar();
                if (result != null && result != DBNull.Value)
                {
                    classID = result.ToString();
                }
                using (SqlCommand classCommand = new SqlCommand(classQuery, sqlcon))
                {
                    classCommand.Parameters.AddWithValue("@ClassID", classID);
                    SqlDataAdapter adapter = new SqlDataAdapter(classCommand);
                    DataTable classDataTable = new DataTable();
                    adapter.Fill(classDataTable);
                    dgvSTU.DataSource = classDataTable;
                }
                sqlcon.Close();
            }
        }

        private void btnatten1_Click(object sender, EventArgs e)
        {
            string studentID = loggedInID;
            sqlcon.Open();
            string attendanceQuery = $"SELECT * FROM Attendance WHERE StudentID = N'{studentID}'";
            SqlDataAdapter attendanceAdapter = new SqlDataAdapter(attendanceQuery, sqlcon);
            DataTable attendanceTable = new DataTable();
            attendanceAdapter.Fill(attendanceTable);
            dgvSTU.DataSource = attendanceTable;
            sqlcon.Close();
        }

        private void btnExitSTU_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private bool isProcessingCellContentClick = false;
        private void dgvSTU_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (!isProcessingCellContentClick)
            {
                isProcessingCellContentClick = true;
                sqlcon.Open();
                if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
                {
                    DataGridViewColumn clickedColumn = dgvSTU.Columns[e.ColumnIndex];
                    object cellValue = dgvSTU.Rows[e.RowIndex].Cells[e.ColumnIndex].Value;
                    switch (clickedColumn.Name)
                    {
                        case "ClassID":
                            string selectedClassID = cellValue.ToString();
                            string studentQuery = $"SELECT * FROM Students WHERE ClassID = N'{selectedClassID}'";
                            SqlDataAdapter studentAdapter = new SqlDataAdapter(studentQuery, sqlcon);
                            DataTable studentTable = new DataTable();
                            studentAdapter.Fill(studentTable);
                            dgvSTU.DataSource = studentTable;
                            break;

                        case "InstructorID":
                            string selectedInstructorID = cellValue.ToString();
                            string instructorQuery = $"SELECT * FROM Instructors WHERE InstructorID = N'{selectedInstructorID}'";
                            SqlDataAdapter instructorAdapter = new SqlDataAdapter(instructorQuery, sqlcon);
                            DataTable instructorTable = new DataTable();
                            instructorAdapter.Fill(instructorTable);
                            dgvSTU.DataSource = instructorTable;
                            break;

                        case "StudentID":
                            string selectedStudentID = cellValue.ToString();
                            string studentInfoQuery = $"SELECT * FROM Students WHERE StudentID = N'{selectedStudentID}'";
                            SqlDataAdapter studentInfoAdapter = new SqlDataAdapter(studentInfoQuery, sqlcon);
                            DataTable studentInfoTable = new DataTable();
                            studentInfoAdapter.Fill(studentInfoTable);
                            dgvSTU.DataSource = studentInfoTable;
                            break;

                        default:
                            break;
                    }
                }
            }
            sqlcon.Close();
            isProcessingCellContentClick = false;
        }
    }
}
