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
    public partial class ServicesForm : Form
    {
        public ServicesForm()
        {
            InitializeComponent();
        }
        
        private void ServicesForm_Load(object sender, EventArgs e)
        {
            load_Package();
            load_Category();
        }

        private void btnAddService_Click(object sender, EventArgs e)
        {
            CString.cmd = new SqlCommand("Sp_Insert_tblService", CString.con);
            CString.cmd.CommandType = CommandType.StoredProcedure;
            CString.cmd.Parameters.AddWithValue("@Name", txtServiceName.Text);
            CString.cmd.Parameters.AddWithValue("@Price", Convert.ToDouble(txtServicePrice.Text));

            CString.con.Open();
            CString.cmd.ExecuteNonQuery();
            MessageBox.Show("Inserted Data Successfully!");
            CString.con.Close();
        }

        void load_Package()
        {
            CString.cmd = new SqlCommand("Sp_View_PackageService", CString.con);
            CString.cmd.CommandType = CommandType.StoredProcedure;

            CString.con.Open();
            CString.cmd.ExecuteNonQuery();
            CString.con.Close();

            SqlDataAdapter adp = new SqlDataAdapter(CString.cmd);
            DataTable dt = new DataTable();
            adp.Fill(dt);
            dgvPackages.DataSource = dt;
        }

        void load_Category()
        {
            CString.cmd = new SqlCommand("Sp_View_CategoryService", CString.con);
            CString.cmd.CommandType = CommandType.StoredProcedure;

            CString.con.Open();
            CString.cmd.ExecuteNonQuery();
            CString.con.Close();

            SqlDataAdapter adp = new SqlDataAdapter(CString.cmd);
            DataTable dt = new DataTable();
            adp.Fill(dt);
            dgvCategory.DataSource = dt;
        }
    }
}
