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
            try
            {
                int count = appointment.count(dtpAppointmentDate.Value, Convert.ToDateTime(cbAppointmentTime.Text), "");
                if (appointment.limitExceeded(Convert.ToInt32(cbMaxAppointment.Text), count))
                {
                    if (!customer.isCustomer(Convert.ToInt64(txtCustContactNo.Text)))
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
                        try
                        {
                            customer.insertDetail(txtCustFName.Text, txtCustLName.Text, txtCustArea.Text, Convert.ToInt64(txtCustContactNo.Text), gender);
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Enter Customer Details Properly!" + ex.Message);
                        }
                        finally
                        {
                            CString.con.Close();
                        }
                    }
                    try
                    {
                        appointment.insertDetail(Convert.ToInt64(txtCustContactNo.Text), cbPackages.Text, Convert.ToDateTime(cbAppointmentTime.Text), dtpAppointmentDate.Value, 'r');
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Enter Appointment Details Properly!" + ex.Message);
                    }
                    finally
                    {
                        CString.con.Close();
                    }

                    reset_AllFields();
                }
                else
                {
                    lblAppointmentAlert.Text = "Timing Not Available!";
                }
            }catch(Exception ex)
            {
                MessageBox.Show("Add Timing properly!"+ex.Message);
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
            gbGender.Enabled = false;
            lblAppointmentAlert.Visible = false;
        }

        void enableAllControls()
        {
            txtCustArea.ReadOnly = false;
            txtCustFName.ReadOnly = false;
            txtCustLName.ReadOnly = false;
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

        private void cbAppointmentTime_SelectedValueChanged(object sender, EventArgs e)
        {
            
            int totalAppoint = appointment.count(dtpAppointmentDate.Value, Convert.ToDateTime(cbAppointmentTime.Text), "remaining");
            if (!appointment.limitExceeded(Convert.ToInt32(cbMaxAppointment.Text), totalAppoint))
            {
                lblAppointmentAlert.Text = "Not Available!";
                lblAppointmentAlert.Visible = true;
            }
            else
            {
                lblAppointmentAlert.Visible = false;
                cbAppointmentTime.Focus();
            }
        }
    }
}
