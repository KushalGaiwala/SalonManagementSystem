using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Net.Mail;
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

        CustomerDetail customer = new CustomerDetail();
        AppointmentDetail appointment = new AppointmentDetail();

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if(txtCustContactNo.Text != "" || txtCustContactNo.Text != null)
            {
                if (txtCustContactNo.TextLength == 10)
                {
                    if (!customer.isCustomer(Convert.ToInt64(txtCustContactNo.Text)))
                    {
                        if (txtCustFName.Text != null && txtCustFName.Text != "" && txtCustLName.Text != null && txtCustLName.Text != "" && txtCustArea.Text != null && txtCustArea.Text != "")
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
                            customer.insertDetail(txtCustFName.Text, txtCustLName.Text, txtCustArea.Text, Convert.ToInt64(txtCustContactNo.Text), gender);
                        }
                        else
                        {
                            epAllError.SetError(gbCustomerDetail, "Empty Customer Details!");
                        }
                    }
                }
                else
                {
                    epAllError.SetError(txtCustContactNo, "Must be excatly 10 digits");
                }
            }
            else
            {
                epAllError.SetError(txtCustContactNo, "Enter Contact No");
            }

            if(cbAppointmentTime.Text != "" && cbAppointmentTime.Text != null)
            {
                if (cbPackages.Text != "" && cbPackages.Text != null)
                {
                    int count = appointment.count(dtpAppointmentDate.Value, Convert.ToDateTime(cbAppointmentTime.Text), 'r');
                    if (appointment.limitExceeded(Convert.ToInt32(cbMaxAppointment.Text), count))
                    {
                        appointment.insertDetail(Convert.ToInt64(txtCustContactNo.Text), cbPackages.Text, Convert.ToDateTime(cbAppointmentTime.Text), dtpAppointmentDate.Value, 'r');
                        dgvAppointmentDetail.DataSource = appointment.getUpcommingAppointment();
                        reset_AllFields();
                    }
                    else
                    {
                        epAllError.SetError(cbAppointmentTime, "Timing Not Available");
                    }
                }
                else
                {
                    epAllError.SetError(cbPackages, "Package not selected!");
                }
            }
            else
            {
                epAllError.SetError(gbAppointmentDetail, "Enter Appointment Details Properly!");
            }
        }

        void reset_AllFields()
        {
            txtCustArea.Text = "";
            txtCustFName.Text = "";
            txtCustLName.Text = "";
            rbFemale.Checked = false;
            rbMale.Checked = true;
            cbPackages.Text = "";
            txtTotalPrice.Text = "";
            lblAlertExists.Visible = false;
        }

        private void Insert_AppointmentForm_Load(object sender, EventArgs e)
        {
            cbMaxAppointment.Text = "3";
            dtpAppointmentDate.MinDate = DateTime.Now;
            dtpAppointmentDate.Value = DateTime.Now;

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

            dgvAppointmentDetail.DataSource = appointment.getUpcommingAppointment();
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
            if (txtCustContactNo.Text != "")
            {
                if (txtCustContactNo.TextLength == 10)
                {
                    if (customer.isCustomer(Convert.ToInt64(txtCustContactNo.Text)))
                    {
                        if (lblAlertExists.Visible == false)
                        {
                            txtCustContactNo.Focus();
                        }
                        lblAlertExists.Visible = true;
                        get_CustomerDetail();
                        disableAllControls();
                    }
                    else
                    {
                        lblAlertExists.Visible = false;
                        reset_AllFields();
                        enableAllControls();
                    }
                }
                else
                {
                    epAllError.SetError(txtCustContactNo, "Must be excatly 10 digits");
                }
            }
        }

        void get_CustomerDetail()
        {
            SqlDataReader reader = customer.getDetail(Convert.ToInt64(txtCustContactNo.Text));
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


        void disableAllControls()
        {
            txtCustArea.ReadOnly = true;
            txtCustFName.ReadOnly = true;
            txtCustLName.ReadOnly = true;
            rbFemale.Enabled = false;
            rbMale.Enabled = false;
            epAllError.Clear();
        }

        void enableAllControls()
        {
            txtCustArea.ReadOnly = false;
            txtCustFName.ReadOnly = false;
            txtCustLName.ReadOnly = false;
            rbFemale.Enabled = true;
            rbMale.Enabled = true;
        }

        private void txtCustContactNo_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if(!(ch >= '0' && ch <= '9' || ch == 8))
            {
                e.Handled = true;
            }
        }

        private void cbAppointmentTime_SelectedValueChanged(object sender, EventArgs e)
        {
            int totalAppoint = appointment.count(dtpAppointmentDate.Value, Convert.ToDateTime(cbAppointmentTime.Text), 'r');
            if (!appointment.limitExceeded(Convert.ToInt32(cbMaxAppointment.Text), totalAppoint))
            {
                epAllError.SetError(cbAppointmentTime, "Time Not Available");
            }
            else
            {
                epAllError.Clear();
                cbAppointmentTime.Focus();
            }
        }

        void checkControls()
        {
            if(txtCustContactNo.Text == null || txtCustContactNo.Text == "")
            {
                epAllError.SetError(txtCustLName, "Field Empty!");
            }
            else if(txtCustFName.Text == null || txtCustFName.Text == "")
            {
                epAllError.SetError(txtCustFName, "Field Empty!");
            }
            else if(txtCustLName.Text == null || txtCustLName.Text == "")
            {
                epAllError.SetError(txtCustLName, "Field Empty!");
            }
            else if(txtCustArea.Text == null || txtCustArea.Text == "")
            {
                epAllError.SetError(txtCustArea, "Field Empty!");
            }
            else if(cbAppointmentTime.Text == null || cbAppointmentTime.Text == "")
            {
                epAllError.SetError(cbAppointmentTime, "Field Empty!");
            }
        }
    }
}
