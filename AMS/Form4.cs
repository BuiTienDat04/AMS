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
    public partial class Form4 : Form
    {
        SqlConnection sqlcon = new SqlConnection("Server=LAPTOP-OF-TDAT\\TDAT; Database=AMS; Initial Catalog=AMS;Integrated Security=True;Encrypt=False");
        SqlCommand cmd = new SqlCommand();
        public Form4()
        {
            InitializeComponent();
        }

        private void btnexit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void cbpass_CheckedChanged(object sender, EventArgs e)
        {
            if (cbpass.Checked == true)
            {
                tbpass.PasswordChar = '\0';
            }
            else
            {
                tbpass.PasswordChar = '*';
            }
        }

        private void Form4_Load(object sender, EventArgs e)
        {

        }

        private void btnin_Click(object sender, EventArgs e)
        {
            sqlcon.Open();
            cmd = sqlcon.CreateCommand();
            cmd.CommandText = "select* from Accounts";
            SqlDataReader r = cmd.ExecuteReader();
            int n = 0;
            while (r.Read())
            {
                string account = r["Account"].ToString();
                string passW = r["PassW"].ToString();
                string ID = r["StudentID"].ToString();
                if ((account == tbacc.Text) && (passW == tbpass.Text))
                {
                    n = 1;
                    MessageBox.Show("Logged in successfully", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Hide();
                    if (ID.Length == 0)
                    {
                        string ID1 = r["InstructorID"].ToString();
                        Form3 form3 = new Form3(account, passW, ID1);
                        form3.ShowDialog();
                    }
                    else
                    {
                        Form2 form2 = new Form2(account, passW, ID);
                        form2.ShowDialog();
                    }
                    this.Close();
                    return;
                }
            }
            if (n == 0)
            {
                MessageBox.Show("Login information is incorrect. Try again!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            sqlcon.Close();
        }

        private void tbacc_TextChanged(object sender, EventArgs e)
        {

        }

        private void tbpass_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
