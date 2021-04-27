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
            CString.cmd.Parameters.AddWithValue("@DOB", dtpEmpDOB.Value);
            CString.cmd.Parameters.AddWithValue("@Gender", Convert.ToChar(gender));
            CString.cmd.Parameters.AddWithValue("@ContactNo", Convert.ToInt64(txtEmpContactNo.Text));
            CString.cmd.Parameters.AddWithValue("@HouseNo", Convert.ToInt32(txtHouseNo.Text));
            CString.cmd.Parameters.AddWithValue("@Street", txtStreet.Text);
            CString.cmd.Parameters.AddWithValue("@Area", txtArea.Text);
            CString.cmd.Parameters.AddWithValue("@City", txtCity.Text);
            CString.cmd.Parameters.AddWithValue("@Pincode", Convert.ToInt32(txtPincode.Text));
            CString.cmd.Parameters.AddWithValue("@DOJ", dtpDOJ.Value);
            CString.cmd.Parameters.AddWithValue("@Experience", Convert.ToInt32(txtEmpExp.Text));
            CString.cmd.Parameters.AddWithValue("@Salary", Convert.ToDouble(txtEmpSalary.Text));
            CString.cmd.Parameters.AddWithValue("@Proof", txtEmpProof.Text);

            CString.con.Open();
            CString.cmd.ExecuteNonQuery();
            MessageBox.Show("Data Successfully Inserted!");
            CString.con.Close();

        }

        private void txtEmpContactNo_Leave(object sender, EventArgs e)
        {
            if (txtEmpContactNo.Text != "")
            {
                if (employeeExists())
                {
                    if (lblAlertExists.Visible == false)
                    {
                        txtEmpContactNo.Focus();
                    }
                    lblAlertExists.Visible = true;
                    btnUpdate.Visible = true;
                    btnDelete.Visible = true;
                    disableAllOptions();
                }
                else
                {
                    lblAlertExists.Visible = false;
                    enableAllOptions();
                }
            }
        }

        void disableAllOptions()
        {
            txtEmpProof.Enabled = false;
            txtEmpExp.Enabled = false;
            dtpDOJ.Enabled = false;
            gbGender.Enabled = false;
            dtpEmpDOB.Enabled = false;
        }

        void enableAllOptions()
        {
            txtEmpProof.Enabled = true;
            txtEmpExp.Enabled = true;
            dtpDOJ.Enabled = true;
            gbGender.Enabled = true;
            dtpEmpDOB.Enabled = true;
        }

        Boolean employeeExists()
        {
            int exists = 0;
            CString.cmd = new SqlCommand("Sp_Verify_Employee", CString.con);
            CString.cmd.CommandType = CommandType.StoredProcedure;
            CString.cmd.Parameters.AddWithValue("@ContactNo", Convert.ToInt64(txtEmpContactNo.Text));

            CString.con.Open();
            exists = Convert.ToInt32(CString.cmd.ExecuteScalar());
            CString.con.Close();

            if (Convert.ToBoolean(exists))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            CString.cmd = new SqlCommand("Sp_Update_tblEmployee", CString.con);

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {

        }

        private void Insert_Employee_Load(object sender, EventArgs e)
        {

        }
    }
}
