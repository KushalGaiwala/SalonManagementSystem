using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SalonManagementSystem
{
    public partial class Insert_Employee : Form
    {
        public Insert_Employee()
        {
            InitializeComponent();
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            insert_Employee();
        }

        void insert_Employee()
        {
            string gender = "";
            if (rbMale.Checked)
            {
                gender = "M";
            }
            else if (rbFemale.Checked)
            {
                gender = "F";
            }
            else
            {
                gender = null;
            }

            CString.cmd = new SqlCommand("Sp_Insert_tblEmployee", CString.con);
            CString.cmd.CommandType = CommandType.StoredProcedure;
            CString.cmd.Parameters.AddWithValue("@Fname", txtEmpFName.Text);
            CString.cmd.Parameters.AddWithValue("@Lname", txtEmpLName.Text);
            CString.cmd.Parameters.AddWithValue("@DOB", Convert.ToDateTime(dtpEmpDOB.Text));
            CString.cmd.Parameters.AddWithValue("@Gender", Convert.ToChar(gender));
            CString.cmd.Parameters.AddWithValue("@ContactNo", Convert.ToInt64(txtEmpContactNo.Text));
            CString.cmd.Parameters.AddWithValue("@HouseNo", Convert.ToInt32(txtHouseNo.Text));
            CString.cmd.Parameters.AddWithValue("@Street", txtStreet.Text);
            CString.cmd.Parameters.AddWithValue("@Area", txtArea.Text);
            CString.cmd.Parameters.AddWithValue("@City", txtCity.Text);
            CString.cmd.Parameters.AddWithValue("@Pincode", Convert.ToInt32(txtPincode.Text));
            CString.cmd.Parameters.AddWithValue("@DOJ", Convert.ToDateTime(dtpDOJ.Text));
            CString.cmd.Parameters.AddWithValue("@Experience", Convert.ToInt32(txtEmpExp.Text));
            CString.cmd.Parameters.AddWithValue("@Salary", Convert.ToDouble(txtEmpSalary.Text));
            CString.cmd.Parameters.AddWithValue("@Proof", txtEmpProof.Text);

            CString.con.Open();
            CString.cmd.ExecuteNonQuery();
            MessageBox.Show("Data Successfully Inserted!");
            CString.con.Close();

        }
    }
}
