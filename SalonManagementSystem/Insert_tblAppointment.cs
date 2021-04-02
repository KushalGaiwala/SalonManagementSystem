using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SalonManagementSystem
{
    public class Insert_tblAppointment
    {
        private SqlConnection con = new SqlConnection(@"Data Source=KUSHAL\MSSQLSERVER01;Initial Catalog=DB_SalonManagementSystem;Integrated Security=True");
        private SqlCommand cmd;

        public void insertCustomer(string CustName, string CustArea, string CustPincode, string CustContactNo, char Gender)
        {
            try
            {
                // If city is added
                /*cmd = new SqlCommand("Sp_VerifyCity", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@CityName", txtCustCity.Text);
                con.Open();
                int i = Convert.ToInt32(cmd.ExecuteScalar());
                con.Close();
                cmd = new SqlCommand("Sp_Insert_tblCity", con);
                if (i == 0)
                {
                    SqlCommand cmd1 = new SqlCommand("Sp_Insert_tblCity", con);
                    cmd1.CommandType = CommandType.StoredProcedure;
                    cmd1.Parameters.AddWithValue("@CityName", txtCustCity.Text);
                    cmd1.Parameters.AddWithValue("@PinCode", txtCustCityPincode.Text);
                    con.Open();
                    cmd1.ExecuteNonQuery();
                    con.Close();
                }*/

                cmd = new SqlCommand("Sp_Insert_tblCustomer", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@CustName", CustName);
                cmd.Parameters.AddWithValue("@Area", CustArea);
                cmd.Parameters.AddWithValue("@Pincode", Convert.ToInt32(CustPincode));
                cmd.Parameters.AddWithValue("@ContactNo", Convert.ToDouble(CustContactNo));
                cmd.Parameters.AddWithValue("@Gender", Gender);

                con.Open();
                cmd.ExecuteNonQuery();
                MessageBox.Show("Data successfully Inserted!");
                con.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show("No Gender Detail!");
            }
        }

    }
}
