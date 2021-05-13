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
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }
        
        private void btnLogin_Click(object sender, EventArgs e)
        {
            CString.cmd = new SqlCommand("Sp_tblLogin",CString.con);
            CString.cmd.CommandType = CommandType.StoredProcedure;
            CString.cmd.Parameters.AddWithValue("@Lname", txtName.Text);
            CString.cmd.Parameters.AddWithValue("@Lpass",txtPassword.Text);
            CString.con.Open();
            int i = Convert.ToInt32(CString.cmd.ExecuteScalar());
            CString.con.Close();
            if (i == 0)
            {
                reset_LoginForm();
                MessageBox.Show("Login failed!");
            }
            else
            {
                MessageBox.Show("Successfully logged in!");
                Form1 form = new Form1();
                form.Show();
                this.Hide();
            }
        }

        private void reset_LoginForm()
        {
            txtName.Text = null;
            txtPassword.Text = null;
        }

        private void Closed_LoginForm(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            RegistrationForm registration = new RegistrationForm();
            registration.Show();
        }

        void checkAllError()
        {
            if(txtName.Text == "" || txtName.Text == null)
            {
                epAllError.SetError(txtName, "Username Remaining!");
                txtName.Focus();
            }
            else if(txtPassword.Text == "" || txtPassword.Text == null)
            {
                epAllError.SetError(txtPassword, "Password Remaining!");
                txtPassword.Focus();
            }
        }

        private void txtName_Leave(object sender, EventArgs e)
        {
            checkAllError();
        }

        private void txtPassword_Leave(object sender, EventArgs e)
        {
            checkAllError();
        }
    }
}
