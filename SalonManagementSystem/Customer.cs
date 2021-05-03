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

        CustomerDetail customer = new CustomerDetail();
        private void btnInsert_Click(object sender, EventArgs e)
        {
            try
            {
                char gender = ' ';
                if (rbFemale.Checked)
                {
                    gender = 'f';
                }
                else if (rbMale.Checked)
                {
                    gender = 'm';
                }
                customer.insertDetail(txtCustFName.Text, txtCustLName.Text, txtCustArea.Text, txtCustContactNo.Text, gender);
                dgvDisplayData();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Enter Details Properly!"+ex.Message.ToString());
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            char gender = ' ';
            if (rbFemale.Checked)
            {
                gender = 'f';
            }else if (rbMale.Checked)
            {
                gender = 'm';
            }
            customer.updateDetail(txtCustFName.Text, txtCustLName.Text, txtCustArea.Text, txtCustContactNo.Text, txtCustNewContactNo.Text, gender);
            dgvDisplayData();
        }

        private void txtCustContactNo_Leave(object sender, EventArgs e)
        {
            if (txtCustContactNo.Text != "")
            {
                if (customer.isCustomer(txtCustContactNo.Text))
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
            txtCustNewContactNo.Text = null;
            txtCustArea.Text = null;
        }

        void get_CustomerDetail()
        {
            SqlDataReader reader = customer.getDetail(txtCustContactNo.Text);
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

        private void Customer_Load(object sender, EventArgs e)
        {
            dgvDisplayData();
        }

        void dgvDisplayData()
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

        private void txtCustContactNo_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (!(ch >= '0' && ch <= '9' || ch == 8))
            {
                e.Handled = true;
            }
        }
    }
}
