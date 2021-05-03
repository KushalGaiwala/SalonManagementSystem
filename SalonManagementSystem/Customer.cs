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
            CString.cmd = new SqlCommand("Sp_Get_AllCustomer", CString.con);
            CString.cmd.CommandType = CommandType.StoredProcedure;
            SqlDataAdapter adp = new SqlDataAdapter(CString.cmd);

            CString.con.Open();
            CString.cmd.ExecuteNonQuery();
            CString.con.Close();

            DataTable dt = new DataTable();
            adp.Fill(dt);
            dgvCustomerDetails.DataSource = dt;
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            CString.cmd = new SqlCommand("Sp_Insert_Customer", CString.con);
            CString.cmd.CommandType = CommandType.StoredProcedure;
            CString.cmd.Parameters.AddWithValue("@FirstName", txtCustFName.Text);
            CString.cmd.Parameters.AddWithValue("@LastName", txtCustLName.Text);
            CString.cmd.Parameters.AddWithValue("@Area", txtCustArea.Text);
            CString.cmd.Parameters.AddWithValue("@ContactNo", txtCustContactNo.Text);
            if (rbFemale.Checked)
            {
                CString.cmd.Parameters.AddWithValue("@Gender", 'f');
            }
            else if(rbMale.Checked)
            {
                CString.cmd.Parameters.AddWithValue("@Gender", 'm');
            }

            CString.con.Open();
            CString.cmd.ExecuteNonQuery();
            MessageBox.Show("Customer Details Inserted!");
            CString.con.Close();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            CString.cmd = new SqlCommand("Sp_Update_tblCustomer", CString.con);
            CString.cmd.CommandType = CommandType.StoredProcedure;
            CString.cmd.Parameters.AddWithValue("@Fname", txtCustFName.Text);
            CString.cmd.Parameters.AddWithValue("@Lname", txtCustLName.Text);
            CString.cmd.Parameters.AddWithValue("@Area", txtCustArea.Text);
            if (txtCustNewContactNo.Text != "" || txtCustNewContactNo.Text != null)
            {
                CString.cmd.Parameters.AddWithValue("@ContactNo", txtCustNewContactNo.Text);
            }
            else
            {
                CString.cmd.Parameters.AddWithValue("@ContactNo", txtCustContactNo.Text);
            }
            if (rbFemale.Checked)
            {
                CString.cmd.Parameters.AddWithValue("@Gender", 'f');
            }
            else if (rbMale.Checked)
            {
                CString.cmd.Parameters.AddWithValue("@Gender", 'm');
            }
            DialogResult result = MessageBox.Show("Do you really want to Update?", "Update Custoemr Details", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if(DialogResult.Yes == result)
            {
                CString.con.Open();
                CString.cmd.ExecuteNonQuery();
                MessageBox.Show("Customer Details Updated!");
                CString.con.Close();
            }
        }

        Boolean customerExists()
        {
            CString.cmd = new SqlCommand("Sp_Verify_Customer", CString.con);
            CString.cmd.CommandType = CommandType.StoredProcedure;
            CString.cmd.Parameters.AddWithValue("@ContactNo", Convert.ToInt64(txtCustContactNo.Text));

            CString.con.Open();
            int i = Convert.ToInt32(CString.cmd.ExecuteScalar());
            CString.con.Close();

            if (i == 0)
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        private void txtCustContactNo_Leave(object sender, EventArgs e)
        {
            if (txtCustContactNo.Text != "")
            {
                if (customerExists())
                {
                    if (lblAlertExists.Visible == false)
                    {
                        txtCustContactNo.Focus();
                    }
                    lblAlertExists.Visible = true;
                    lblNewContactNo.Visible = true;
                    txtCustNewContactNo.Visible = true;
                    get_CustomerDetail();
                }
                else
                {
                    lblAlertExists.Visible = false;
                    lblNewContactNo.Visible = false;
                    txtCustNewContactNo.Visible = false;
                    reset_AllControls();
                }
            }
        }

        void reset_AllControls()
        {
            txtCustFName.Text = null;
            txtCustLName.Text = null;
            txtCustContactNo.Text = null;
            txtCustNewContactNo.Text = null;
            txtCustArea.Text = null;
        }

        void get_CustomerDetail()
        {
            CString.cmd = new SqlCommand("Sp_Get_Customer", CString.con);
            CString.cmd.CommandType = CommandType.StoredProcedure;
            CString.cmd.Parameters.AddWithValue("@ContactNo", Convert.ToInt64(txtCustContactNo.Text));

            CString.con.Open();
            SqlDataReader reader = CString.cmd.ExecuteReader();
            while (reader.Read())
            {
                txtCustFName.Text = reader.GetValue(0).ToString();
                txtCustLName.Text = reader.GetValue(1).ToString();
                txtCustArea.Text = reader.GetValue(2).ToString();
                txtCustContactNo.Text = reader.GetValue(3).ToString();
                if (reader.GetValue(4).ToString().ToLower() == "m")
                {
                    rbMale.Checked = true;
                }
                else if (reader.GetValue(4).ToString().ToLower() == "f")
                {
                    rbFemale.Checked = true;
                }
            }
            CString.con.Close();
        }
    }
}
