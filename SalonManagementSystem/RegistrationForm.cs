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
    public partial class RegistrationForm : Form
    {
        public RegistrationForm()
        {
            InitializeComponent();
        }
        private int session;
        private void btnOtp_Click(object sender, EventArgs e)
        {
            if (txtEmail.Text != "")
            {
                if (sendotp(txtEmail.Text))
                {
                    lblEmailVerify.Text = "Sent!";
                    lblEmailVerify.Visible = true;
                }
                else
                {
                    lblEmailVerify.Text = "Not Sent!";
                    lblEmailVerify.Visible = true;
                }
            }
            else
            {
                lblEmailVerify.Text = "Provide Email!";
                
                lblEmailVerify.Visible = true;
            }
        }

        Boolean sendotp(string tempemail)
        {
            try
            {
                SmtpClient client = new SmtpClient("smtp.gmail.com");
                MailMessage mail;
                string email, pass;
                email = "kushal8217@gmail.com";
                pass = "kushalkushal";
            
                Random rand = new Random();
                int otp = rand.Next(100000, 999999);
                session = otp;
                string body = "Your OTP for Email Verification is: " + otp;

                mail = new MailMessage(email, tempemail, "Salon Management System", body);
                mail.BodyEncoding = System.Text.Encoding.GetEncoding("utf-8");
            
                client.Port = 587;
                client.Credentials = new System.Net.NetworkCredential(email, pass);
                client.EnableSsl = true;

            
                client.Send(mail);
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            if (passCheck())
            {
                if (otpCheck())
                {
                    CString.cmd = new SqlCommand("Sp_Insert_tblUser", CString.con);
                    CString.cmd.CommandType = CommandType.StoredProcedure;
                    CString.cmd.Parameters.AddWithValue("@Fname", txtFname.Text);
                    CString.cmd.Parameters.AddWithValue("@Lname", txtLname.Text);
                    CString.cmd.Parameters.AddWithValue("@Username", txtUsername.Text);
                    CString.cmd.Parameters.AddWithValue("@Password", txtPass.Text);
                    CString.cmd.Parameters.AddWithValue("@Email", txtEmail.Text);

                    CString.con.Open();
                    CString.cmd.ExecuteNonQuery();
                    MessageBox.Show("The User is Entered!");
                    CString.con.Close();
                }
                else
                {
                    lblOtpVerify.Text = "OTP is Incorrect!";
                    lblOtpVerify.Visible = true;
                }
            }
            else
            {
                MessageBox.Show("The Passwords Does not match!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void txtRePass_Leave(object sender, EventArgs e)
        {
            if (!passCheck())
            {
                MessageBox.Show("The Password Does not match!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        Boolean passCheck()
        {
            if (txtPass.Text != txtRePass.Text)
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        Boolean otpCheck()
        {
            if (txtOtp.Text != session.ToString())
            {
                return false;
            }
            else
            {
                return true;
            }
        }
    }
}
