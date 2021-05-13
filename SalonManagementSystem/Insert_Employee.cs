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
            CString.cmd.Parameters.AddWithValue("@ProofId", Convert.ToInt64(txtEmpProofId.Text));

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
                    btnEmpStatus.Visible = true;
                    gbWorkingStatus.Visible = true;
                    get_EmployeeDetail();
                    disableAllOptions();
                }
                else
                {
                    lblAlertExists.Visible = false;
                    enableAllOptions();
                    reset_AllControls();
                }
            }
        }

        void reset_AllControls()
        {
            rbWorkingYes.Checked = true;
            txtEmpFName.Text = null;
            txtEmpLName.Text = null;
            txtHouseNo.Text = null;
            txtStreet.Text = null;
            txtArea.Text = null;
            txtCity.Text = null;
            txtPincode.Text = null;
            txtEmpExp.Text = null;
            txtEmpSalary.Text = null;
            txtEmpProof.Text = null;
            txtEmpProofId.Text = null;
        }

        void get_EmployeeDetail()
        {
            CString.cmd = new SqlCommand("Sp_Get_Employee", CString.con);
            CString.cmd.CommandType = CommandType.StoredProcedure;
            CString.cmd.Parameters.AddWithValue("@ContactNo", Convert.ToInt64(txtEmpContactNo.Text));

            CString.con.Open();
            SqlDataReader reader = CString.cmd.ExecuteReader();
            while (reader.Read())
            {
                txtEmpFName.Text = reader.GetValue(1).ToString();
                txtEmpLName.Text = reader.GetValue(2).ToString();
                dtpEmpDOB.Value = Convert.ToDateTime(reader.GetValue(3));
                if (reader.GetValue(4).ToString().ToLower() == "m")
                {
                    rbMale.Checked = true;
                }
                else if (reader.GetValue(4).ToString().ToLower() == "f")
                {
                    rbFemale.Checked = true;
                }
                txtEmpContactNo.Text = reader.GetValue(5).ToString();
                txtHouseNo.Text = reader.GetValue(6).ToString();
                txtStreet.Text = reader.GetValue(7).ToString();
                txtArea.Text = reader.GetValue(8).ToString();
                txtCity.Text = reader.GetValue(9).ToString();
                txtPincode.Text = reader.GetValue(10).ToString();
                dtpDOJ.MinDate = Convert.ToDateTime(reader.GetValue(11));
                dtpDOJ.Value = Convert.ToDateTime(reader.GetValue(11));
                txtEmpExp.Text = reader.GetValue(12).ToString();
                txtEmpSalary.Text = reader.GetValue(13).ToString();
                txtEmpProof.Text = reader.GetValue(14).ToString();
                txtEmpProofId.Text = reader.GetValue(15).ToString();
                if (reader.GetValue(16).ToString().ToLower() == "y")
                {
                    rbWorkingYes.Checked = true;
                }
                else if (reader.GetValue(16).ToString().ToLower() == "n")
                {
                    rbWorkingNo.Checked = true;
                }
            }
            CString.con.Close();
        }

        void disableAllOptions()
        {
            txtEmpProofId.Enabled = false;
            txtEmpProof.Enabled = false;
            txtEmpExp.Enabled = false;
            dtpDOJ.Enabled = false;
            gbGender.Enabled = false;
            dtpEmpDOB.Enabled = false;
        }

        void enableAllOptions()
        {
            txtEmpProofId.Enabled = true;
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
            CString.cmd.CommandType = CommandType.StoredProcedure;
            CString.cmd.Parameters.AddWithValue("@Fname", txtEmpFName.Text.ToLower());
            CString.cmd.Parameters.AddWithValue("@Lname", txtEmpLName.Text.ToLower());
            CString.cmd.Parameters.AddWithValue("@ContactNo", Convert.ToInt64(txtEmpContactNo.Text));
            CString.cmd.Parameters.AddWithValue("@HouseNo", txtHouseNo.Text);
            CString.cmd.Parameters.AddWithValue("@Street", txtStreet.Text);
            CString.cmd.Parameters.AddWithValue("@Area", txtArea.Text);
            CString.cmd.Parameters.AddWithValue("@City", txtCity.Text);
            CString.cmd.Parameters.AddWithValue("@Pincode", Convert.ToInt32(txtPincode.Text));
            CString.cmd.Parameters.AddWithValue("@Salary", Convert.ToInt32(txtEmpSalary.Text));

            DialogResult dialogresult = MessageBox.Show("Do you really want to Update?", "Update Employee Detail", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if(dialogresult == DialogResult.Yes)
            {
                CString.con.Open();
                CString.cmd.ExecuteNonQuery();
                MessageBox.Show("Details Updated!");
                CString.con.Close();
            }
            dgvEmpDisplay();
        }

        private void btnEmpStatus_Click(object sender, EventArgs e)
        {
            CString.cmd = new SqlCommand("Sp_Delete_tblEmployee", CString.con);
            CString.cmd.CommandType = CommandType.StoredProcedure;
            CString.cmd.Parameters.AddWithValue("@ContactNo", Convert.ToInt64(txtEmpContactNo.Text));
            if(rbWorkingYes.Checked == true)
            {
                CString.cmd.Parameters.AddWithValue("@Status", 'n');
            }
            else if(rbWorkingNo.Checked == true)
            {
                CString.cmd.Parameters.AddWithValue("@Status", 'y');
            }

            DialogResult dialogresult = MessageBox.Show("Do you really want to Change Status?", "Change Status", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (dialogresult == DialogResult.Yes)
            {
                CString.con.Open();
                CString.cmd.ExecuteNonQuery();
                MessageBox.Show("Employee Status has been changed!");
                CString.con.Close();
                get_EmployeeDetail();
            }
            dgvEmpDisplay();
        }

        void dgvEmpDisplay()
        {
            CString.cmd = new SqlCommand("Sp_Get_AllEmployee", CString.con);
            CString.cmd.CommandType = CommandType.StoredProcedure;
            SqlDataAdapter adp = new SqlDataAdapter(CString.cmd);

            CString.con.Open();
            CString.cmd.ExecuteNonQuery();
            CString.con.Close();

            DataTable dt = new DataTable();
            adp.Fill(dt);
            dgvEmployeeDetail.DataSource = dt;
        }

        private void Insert_Employee_Load(object sender, EventArgs e)
        {
            dgvEmpDisplay();
            dtpDOJ.MinDate = DateTime.Now;
            dtpEmpDOB.MaxDate = DateTime.Now.AddYears(-18);
        }
    }
}
