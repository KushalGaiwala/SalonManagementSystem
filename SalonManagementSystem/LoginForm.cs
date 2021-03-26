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
        // Add your connection string
        private SqlConnection con = new SqlConnection(@"Data Source=KUSHAL\MSSQLSERVER01;Initial Catalog=system;Integrated Security=True");
        private SqlCommand cmd;
        private void btnLogin_Click(object sender, EventArgs e)
        {
            cmd = new SqlCommand("select LId from tblLoginDetail where UName='"+txtName.Text+"' and UPass='"+txtPassword.Text+"'",con);
            con.Open();
            int i = Convert.ToInt32(cmd.ExecuteScalar());
            con.Close();
            if (i == 0)
            {
                MessageBox.Show("Not Logged in!");
            }
            else
            {
                MessageBox.Show("Use is logged in!");
            }
        }
    }
}
