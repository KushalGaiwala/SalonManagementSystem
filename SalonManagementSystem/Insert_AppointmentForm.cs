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
    public partial class Insert_AppointmentForm : Form
    {
        public Insert_AppointmentForm()
        {
            InitializeComponent();
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

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                if(!customerExists())
                {
                    insert_tblCustomer();
                }
                insert_tblAppointment();
            }
            catch (Exception ex)
            {
                MessageBox.Show(" Enter Details Properly! "+ex.Message);
            }
        }

        void insert_tblCustomer()
        {
            string Gender = null;
            if (rbMale.Checked)
            {
                Gender = "M";
            }
            else if (rbFemale.Checked)
            {
                Gender = "F";
            }
            else
            {
                Gender = null;
            }

            CString.cmd = new SqlCommand("Sp_Insert_tblCustomer", CString.con);
            CString.cmd.CommandType = CommandType.StoredProcedure;
            CString.cmd.Parameters.AddWithValue("@FirstName", txtCustFName.Text.ToLower()); // Used Lowercase in Customer FirstName
            CString.cmd.Parameters.AddWithValue("@LastName", txtCustLName.Text.ToLower()); // Used Lowercase in LastName
            CString.cmd.Parameters.AddWithValue("@Area", txtCustArea.Text.ToLower()); // Used Lowercase in Customer Area
            CString.cmd.Parameters.AddWithValue("@ContactNo", Convert.ToDouble(txtCustContactNo.Text));
            CString.cmd.Parameters.AddWithValue("@Gender", Gender);

            CString.con.Open();
            CString.cmd.ExecuteNonQuery();
            CString.con.Close();
        }

        void insert_tblAppointment()
        {
            CString.cmd = new SqlCommand("Sp_Insert_tblAppointment", CString.con);
            CString.cmd.CommandType = CommandType.StoredProcedure;
            CString.cmd.Parameters.AddWithValue("@ContactNo", Convert.ToInt64(txtCustContactNo.Text));
            CString.cmd.Parameters.AddWithValue("@PName", cbPackages.Text);
            CString.cmd.Parameters.AddWithValue("@Time", Convert.ToDateTime(dtpAppointmentTime.Text));
            CString.cmd.Parameters.AddWithValue("@Date", Convert.ToDateTime(dtpAppointmentDate.Text));

            CString.con.Open();
            CString.cmd.ExecuteNonQuery();
            reset_AllFields();
            MessageBox.Show("Appointment successfully Generated!");
            CString.con.Close();
        }

        void reset_AllFields()
        {
            txtCustArea.Text = null;
            txtCustContactNo.Text = null;
            txtCustFName.Text = null;
            txtCustLName.Text = null;
            rbFemale.Checked = false;
            rbMale.Checked = false;
            cbPackages.Text = " ";
            txtTotalPrice.Text = null;
            lblAlertExists.Visible = false;
        }

        private void Insert_AppointmentForm_Load(object sender, EventArgs e)
        {
            CString.cmd = new SqlCommand("Sp_Get_Packages", CString.con);
            CString.cmd.CommandType = CommandType.StoredProcedure;

            CString.con.Open();
            SqlDataReader reader = CString.cmd.ExecuteReader();
            while (reader.Read())
            {
                cbPackages.Items.Add(reader.GetValue(0).ToString());
            }
            reader.Close();
            CString.con.Close();
        }

        private void selectedValueChanged_cbPackages(object sender, EventArgs e)
        {
            CString.cmd = new SqlCommand("Sp_View_AllPackages", CString.con);
            CString.cmd.CommandType = CommandType.StoredProcedure;
            CString.cmd.Parameters.AddWithValue("@pckName", cbPackages.Text);

            CString.con.Open();
            CString.cmd.ExecuteNonQuery();
            CString.con.Close();
            
            SqlDataAdapter adp = new SqlDataAdapter(CString.cmd);
            DataTable dt = new DataTable();
            adp.Fill(dt);
            dgvPackages.DataSource = dt;

            CString.cmd = new SqlCommand("Sp_View_TotalPackageAmount", CString.con);
            CString.cmd.CommandType = CommandType.StoredProcedure;
            CString.cmd.Parameters.AddWithValue("@pckName", cbPackages.Text);
            
            CString.con.Open();
            SqlDataReader reader = CString.cmd.ExecuteReader();
            while (reader.Read())
            {
                txtTotalPrice.Text = reader.GetValue(0).ToString();
            }
            reader.Close();
            CString.con.Close();
        }

        private void txtCustContactNo_Leave(object sender, EventArgs e)
        {
            if(txtCustContactNo.Text != "")
            {
                if (customerExists())
                {
                    if (lblAlertExists.Visible == false)
                    {
                        txtCustContactNo.Focus();
                    }
                    lblAlertExists.Visible = true;
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
            txtCustArea.Enabled = false;
            txtCustFName.Enabled = false;
            txtCustLName.Enabled = false;
            gbGender.Enabled = false;
        }

        void enableAllOptions()
        {
            txtCustArea.Enabled = true;
            txtCustFName.Enabled = true;
            txtCustLName.Enabled = true;
            gbGender.Enabled = true;
        }

        private void txtCustContactNo_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if(!(ch >= '0' && ch <= '9' || ch == 8))
            {
                e.Handled = true;
            }
        }
    }
}
