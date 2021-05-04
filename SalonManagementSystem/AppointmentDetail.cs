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
    class AppointmentDetail
    {
        public void insertDetail(long contactno, string package, DateTime appTime, DateTime appDate, string status)
        {
            CString.cmd = new SqlCommand("Sp_Insert_tblAppointment", CString.con);
            CString.cmd.CommandType = CommandType.StoredProcedure;
            CString.cmd.Parameters.AddWithValue("@ContactNo", contactno);
            CString.cmd.Parameters.AddWithValue("@PName", package);
            CString.cmd.Parameters.AddWithValue("@Time", appTime);
            CString.cmd.Parameters.AddWithValue("@Date", appDate);
            CString.cmd.Parameters.AddWithValue("@Status", status);

            CString.con.Open();
            CString.cmd.ExecuteNonQuery();
            MessageBox.Show("Appointment successfully Generated!");
            CString.con.Close();
        }

        public DataTable getAllDetail(long contactno, DateTime date, string search)
        {
            CString.cmd = new SqlCommand("Sp_Get_AllAppointment", CString.con);
            CString.cmd.CommandType = CommandType.StoredProcedure;
            CString.cmd.Parameters.AddWithValue("@ContactNo", contactno);
            CString.cmd.Parameters.AddWithValue("@Date", date);

            if (search == "Customer")
            {
                CString.cmd.Parameters.AddWithValue("@type", 1);
            }
            else if (search == "Date")
            {
                CString.cmd.Parameters.AddWithValue("@type", 2);
            }
            else
            {
                CString.cmd.Parameters.AddWithValue("@type", 0);
            }

            SqlDataAdapter adp = new SqlDataAdapter(CString.cmd);

            CString.con.Open();
            CString.cmd.ExecuteNonQuery();
            CString.con.Close();

            DataTable dt = new DataTable();
            adp.Fill(dt);
            return dt;
        }

        public Boolean limitExceeded(int max, int count)
        {
            if (count < max)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public int count(DateTime date, DateTime time, string status)
        {
            int totalNum = 0;
            CString.cmd = new SqlCommand("Sp_Verify_Appointment", CString.con);
            CString.cmd.CommandType = CommandType.StoredProcedure;
            CString.cmd.Parameters.AddWithValue("@Date", date);
            CString.cmd.Parameters.AddWithValue("@Time", time);
            CString.cmd.Parameters.AddWithValue("@Status", status);

            CString.con.Open();
            SqlDataReader reader = CString.cmd.ExecuteReader();
            reader.Read();
            if (reader.GetValue(0) == null)
            {
                totalNum = 0;
            }
            else
            {
                totalNum = Convert.ToInt32(reader.GetValue(0));
            }
            CString.con.Close();
            return totalNum;
        }

        public void isAppointment()
        {

        }

    }
}
