using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Data;
using System.Windows.Forms;
using System.Threading.Tasks;

namespace SalonManagementSystem
{
    class CustomerDetail
    {
        public void insertDetail(string fname, string lname, string area, long contactNo, char gender)
        {
            CString.cmd = new SqlCommand("Sp_Insert_tblCustomer", CString.con);
            CString.cmd.CommandType = CommandType.StoredProcedure;
            CString.cmd.Parameters.AddWithValue("@FirstName", fname);
            CString.cmd.Parameters.AddWithValue("@LastName", lname);
            CString.cmd.Parameters.AddWithValue("@Area", area);
            CString.cmd.Parameters.AddWithValue("@ContactNo", Convert.ToInt64(contactNo));
            CString.cmd.Parameters.AddWithValue("@Gender", gender);

            CString.con.Open();
            CString.cmd.ExecuteNonQuery();
            MessageBox.Show("Customer Details Inserted!");
            CString.con.Close();
        }

        public void updateDetail(string fname, string lname, string area, long oldContactNo, long newContactNo, char gender)
        {
            CString.cmd = new SqlCommand("Sp_Update_tblCustomer", CString.con);
            CString.cmd.CommandType = CommandType.StoredProcedure;
            CString.cmd.Parameters.AddWithValue("@Fname", fname);
            CString.cmd.Parameters.AddWithValue("@Lname", lname);
            CString.cmd.Parameters.AddWithValue("@Area", area);
            CString.cmd.Parameters.AddWithValue("@OldContactNo", oldContactNo);
            CString.cmd.Parameters.AddWithValue("@NewContactNo", newContactNo);
            
            CString.cmd.Parameters.AddWithValue("@Gender", gender);
            
            DialogResult result = MessageBox.Show("Do you really want to Update?", "Update Custoemr Details", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (DialogResult.Yes == result)
            {
                CString.con.Open();
                CString.cmd.ExecuteNonQuery();
                MessageBox.Show("Customer Details Updated!");
                CString.con.Close();
            }
        }

        public SqlDataReader getDetail(long contactNo)
        {
            CString.cmd = new SqlCommand("Sp_Get_Customer", CString.con);
            CString.cmd.CommandType = CommandType.StoredProcedure;
            CString.cmd.Parameters.AddWithValue("@ContactNo", contactNo);

            CString.con.Open();
            SqlDataReader reader = CString.cmd.ExecuteReader();
            return reader;
        }

        public Boolean isCustomer(long contactNo)
        {
            CString.cmd = new SqlCommand("Sp_Verify_Customer", CString.con);
            CString.cmd.CommandType = CommandType.StoredProcedure;
            CString.cmd.Parameters.AddWithValue("@ContactNo", contactNo);

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
    }
}
