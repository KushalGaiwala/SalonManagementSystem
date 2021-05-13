﻿using System;
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
        public static char type = ' ';
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
            SqlDataReader reader = CString.cmd.ExecuteReader();
            reader.Read();
            if (i == 0)
            {
                CString.con.Close();
                reset_LoginForm();
                MessageBox.Show("Login failed!");
            }
            else
            {
                type = Convert.ToChar(reader.GetValue(1));
                MessageBox.Show("Successfully logged in!");
                Form1 form = new Form1();
                CString.con.Close();
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
            else
            {
                epAllError.Clear();
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
