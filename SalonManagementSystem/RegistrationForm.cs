using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SalonManagementSystem
{
    public partial class RegistrationForm : Form
    {
        public RegistrationForm()
        {
            InitializeComponent();
        }

        private void btnOtp_Click(object sender, EventArgs e)
        {

        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            if (passCheck())
            {
                
                CString.cmd = new SqlCommand("Sp_Insert_tblUser", CString.con);
                CString.cmd.CommandType = CommandType.StoredProcedure;
                CString.cmd.Parameters.AddWithValue("@Fname", txtFname.Text);
                CString.cmd.Parameters.AddWithValue("@Lname", txtLname.Text);
                CString.cmd.Parameters.AddWithValue("@Username", txtUsername.Text);
                CString.cmd.Parameters.AddWithValue("@Password", txtPass.Text);
                CString.cmd.Parameters.AddWithValue("@Email", txtEmail.Text);

                CString.con.Open();
                CString.cmd.ExecuteNonQuery();
                MessageBox.Show("The User is Entered!");
                CString.con.Close();
            }
            else
            {
                MessageBox.Show("The Password Does not match!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void txtRePass_Leave(object sender, EventArgs e)
        {
            if (passCheck())
            {
                MessageBox.Show("The Password Does not match!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        Boolean passCheck()
        {
            if (txtPass.Text != txtRePass.Text)
            {
                return false;
            }
            else
            {
                return true;
            }
        }
    }
}
