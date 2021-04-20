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

        private SqlConnection con = new SqlConnection(@"Data Source=KUSHAL\MSSQLSERVER01;Initial Catalog=DB_SalonManagementSystem;Integrated Security=True");
        private SqlCommand cmd;
        
        private void btnLogin_Click(object sender, EventArgs e)
        {
            cmd = new SqlCommand("Sp_tblLogin",con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@Lname", txtName.Text);
            cmd.Parameters.AddWithValue("@Lpass",txtPassword.Text);
            con.Open();
            int i = Convert.ToInt32(cmd.ExecuteScalar());
            con.Close();
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
    }
}
