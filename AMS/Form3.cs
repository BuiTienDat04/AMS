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
using Microsoft.VisualBasic.ApplicationServices;
using System.Security.Principal;

namespace AMS
{
    public partial class Form3 : Form
    {
        private string loggedInAccount;
        private string loggedInPassW;
        private string loggedInID;
        SqlConnection sqlcon = new SqlConnection("Server=LAPTOP-OF-TDAT\\TDAT; Database=AMS; Initial Catalog=AMS;Integrated Security=True;Encrypt=False");
        public Form3(string account, string passW, string ID1)
        {
            InitializeComponent();
            sqlcon.Open();
            loggedInAccount = account;
            loggedInPassW = passW;
            loggedInID = ID1;
            tbUSERINS.Text = loggedInAccount;
        }
        private void tbUSERINS_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form3_Load(object sender, EventArgs e)
        {
            dgvINS.DataBindingComplete += dgvINS_DataBindingComplete;
            dgvINS.CellValueChanged += dgvINS_CellValueChanged;
            btnSave.Visible = false;
        }

        private void btnclass2_Click(object sender, EventArgs e)
        {
            String query = "SELECT Classes.* " +
                   "FROM Classes " +
                   "JOIN Instructors ON Classes.InstructorID = Instructors.InstructorID " +
                   "WHERE Classes.InstructorID = @InstructorID";

            using (SqlCommand sqlCommand = new SqlCommand(query, sqlcon))
            {
                sqlCommand.Parameters.AddWithValue("@InstructorID", loggedInID);
                SqlDataAdapter adapter = new SqlDataAdapter(sqlCommand);
                DataTable instructorDataTable = new DataTable();
                adapter.Fill(instructorDataTable);
                dgvINS.DataSource = instructorDataTable;
            }
            sqlcon.Close();
        }

        private void btnAtten2_Click(object sender, EventArgs e)
        {
            string classQuery = $"SELECT ClassID FROM Classes WHERE InstructorID = N'{loggedInID}'";
            SqlDataAdapter classAdapter = new SqlDataAdapter(classQuery, sqlcon);
            DataTable classTable = new DataTable();
            classAdapter.Fill(classTable);
            List<string> classIDs = new List<string>();
            foreach (DataRow row in classTable.Rows)
            {
                classIDs.Add(row["ClassID"].ToString());
            }
            string attendanceQuery = $"SELECT * FROM Attendance WHERE ClassID IN ({string.Join(",", classIDs.Select(id => $"N'{id}'"))})";
            SqlDataAdapter attendanceAdapter = new SqlDataAdapter(attendanceQuery, sqlcon);
            DataTable attendanceTable = new DataTable();
            attendanceAdapter.Fill(attendanceTable);
            dgvINS.DataSource = attendanceTable;
            sqlcon.Close();
        }

        private void dgvINS_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            foreach (DataGridViewColumn column in dgvINS.Columns)
            {
                if (column.Name == "IsPresent" || column.Name == "Reason")
                {
                    column.ReadOnly = false;
                }
                else
                {
                    column.ReadOnly = true;
                }
            }
        }

        private bool dataChanged = false;
        private void dgvINS_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == dgvINS.Columns["IsPresent"].Index || e.ColumnIndex == dgvINS.Columns["Reason"].Index)
            {
                dataChanged = true;
                btnSave.Visible = true;
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            sqlcon.Open();
            foreach (DataGridViewRow row in dgvINS.Rows)
            {
                if (row.Cells["Reason"].Value != null)
                {
                    string reasonValue = row.Cells["Reason"].Value.ToString();
                    string studentID = row.Cells["StudentID"].Value.ToString();
                    bool isPresentValue = Convert.ToBoolean(row.Cells["IsPresent"].Value);
                    string sqlCommandText = "UPDATE Attendance SET IsPresent = @IsPresent, Reason = @Reason WHERE StudentID = @StudentID";
                    using (SqlCommand command = new SqlCommand(sqlCommandText, sqlcon))
                    {
                        command.Parameters.AddWithValue("@IsPresent", isPresentValue);
                        command.Parameters.AddWithValue("@Reason", reasonValue);
                        command.Parameters.AddWithValue("@StudentID", studentID);

                        command.ExecuteNonQuery();
                    }
                }
            }
            MessageBox.Show("Information saved successfully!", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Information);
            btnSave.Visible = false;
            sqlcon.Close();
        }

        private bool isProcessingCellContentClick = false;

        private void dgvINS_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (!isProcessingCellContentClick)
            {
                isProcessingCellContentClick = true;
                sqlcon.Open();
                if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
                {
                    DataGridViewColumn clickedColumn = dgvINS.Columns[e.ColumnIndex];
                    object cellValue = dgvINS.Rows[e.RowIndex].Cells[e.ColumnIndex].Value;
                    switch (clickedColumn.Name)
                    {
                        case "ClassID":
                            string selectedClassID = cellValue.ToString();
                            string studentQuery = $"SELECT * FROM Students WHERE ClassID = N'{selectedClassID}'";
                            SqlDataAdapter studentAdapter = new SqlDataAdapter(studentQuery, sqlcon);
                            DataTable studentTable = new DataTable();
                            studentAdapter.Fill(studentTable);
                            dgvINS.DataSource = studentTable;
                            break;

                        case "InstructorID":
                            string selectedInstructorID = cellValue.ToString();
                            string instructorQuery = $"SELECT * FROM Instructors WHERE InstructorID = N'{selectedInstructorID}'";
                            SqlDataAdapter instructorAdapter = new SqlDataAdapter(instructorQuery, sqlcon);
                            DataTable instructorTable = new DataTable();
                            instructorAdapter.Fill(instructorTable);
                            dgvINS.DataSource = instructorTable;
                            break;

                        case "StudentID":
                            string selectedStudentID = cellValue.ToString();
                            string studentInfoQuery = $"SELECT * FROM Students WHERE StudentID = N'{selectedStudentID}'";
                            SqlDataAdapter studentInfoAdapter = new SqlDataAdapter(studentInfoQuery, sqlcon);
                            DataTable studentInfoTable = new DataTable();
                            studentInfoAdapter.Fill(studentInfoTable);
                            dgvINS.DataSource = studentInfoTable;
                            break;

                        default:
                            break;
                    }
                }
            }
            sqlcon.Close();
            isProcessingCellContentClick = false;
        }

        private void btnExitINS_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
