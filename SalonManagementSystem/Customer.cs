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
    public partial class Customer : Form
    {
        public Customer()
        {
            InitializeComponent();
        }

        private void Customer_Enter(object sender, EventArgs e)
        {
            //CString.cmd = new SqlCommand("Sp_Get_AllCustomer", CString.con);
            //CString.cmd.CommandType = CommandType.StoredProcedure;
            //SqlDataAdapter adp = new SqlDataAdapter(CString.cmd);

            //CString.con.Open();
            //CString.cmd.ExecuteNonQuery();
            //CString.con.Close();

            //DataTable dt = new DataTable();
            //adp.Fill(dt);

            //dgvCustomerDetails.DataSource = dt;
        }

        private void Customer_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dB_SalonManagementSystemDataSet.tblCustomer' table. You can move, or remove it, as needed.
            this.tblCustomerTableAdapter.Fill(this.dB_SalonManagementSystemDataSet.tblCustomer);

        }
    }
}
