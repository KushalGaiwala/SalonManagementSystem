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
        public void insertDetail(long contactno, string package, DateTime appTime, DateTime appDate, char status)
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

        public void updateDetail(int id, string package, DateTime date, DateTime time, char status)
        {
            CString.cmd = new SqlCommand("Sp_Update_tblAppointment", CString.con);
            CString.cmd.CommandType = CommandType.StoredProcedure;
            CString.cmd.Parameters.AddWithValue("@Appid", id);
            CString.cmd.Parameters.AddWithValue("@Pname", package);
            CString.cmd.Parameters.AddWithValue("@Time", time);
            CString.cmd.Parameters.AddWithValue("@Date", date);
            CString.cmd.Parameters.AddWithValue("@Status", status);

            DialogResult result = MessageBox.Show("Do you really want to Update?", "Appointment Updation", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (DialogResult.Yes == result)
            {
                CString.con.Open();
                CString.cmd.ExecuteNonQuery();
                MessageBox.Show("Appointment Updated!");
                CString.con.Close();
            }
        }

        public DataTable getAllDetail(long contactno)
        {
            CString.cmd = new SqlCommand("Sp_Get_AllAppointment", CString.con);
            CString.cmd.CommandType = CommandType.StoredProcedure;
            CString.cmd.Parameters.AddWithValue("@ContactNo", contactno);
            // Passed "DateTime.Now" in "@Date" as per parameters to be Mandatory passed
            CString.cmd.Parameters.AddWithValue("@Date", DateTime.Now);
            CString.cmd.Parameters.AddWithValue("@type", 1);

            SqlDataAdapter adp = new SqlDataAdapter(CString.cmd);

            CString.con.Open();
            CString.cmd.ExecuteNonQuery();
            CString.con.Close();

            DataTable dt = new DataTable();
            adp.Fill(dt);
            return dt;
        }

        public DataTable getAllDetail(DateTime date)
        {
            CString.cmd = new SqlCommand("Sp_Get_AllAppointment", CString.con);
            CString.cmd.CommandType = CommandType.StoredProcedure;
            // Passed "1" in "@ContactNo" as per parameter to be Mandatory passed
            CString.cmd.Parameters.AddWithValue("@ContactNo", 1);
            CString.cmd.Parameters.AddWithValue("@Date", date);
            CString.cmd.Parameters.AddWithValue("@type", 2);

            SqlDataAdapter adp = new SqlDataAdapter(CString.cmd);

            CString.con.Open();
            CString.cmd.ExecuteNonQuery();
            CString.con.Close();

            DataTable dt = new DataTable();
            adp.Fill(dt);
            return dt;
        }

        public DataTable getAllDetail()
        {
            CString.cmd = new SqlCommand("Sp_Get_AllAppointment", CString.con);
            CString.cmd.CommandType = CommandType.StoredProcedure;
            // Passed "1" in "@ContactNo" as per parameter to be Mandatory passed
            CString.cmd.Parameters.AddWithValue("@ContactNo", 1);
            // Passed "DateTime.Now" in "@Date" as per parameters to be Mandatory passed
            CString.cmd.Parameters.AddWithValue("@Date", DateTime.Now);
            CString.cmd.Parameters.AddWithValue("@type", 0);

            SqlDataAdapter adp = new SqlDataAdapter(CString.cmd);

            CString.con.Open();
            CString.cmd.ExecuteNonQuery();
            CString.con.Close();

            DataTable dt = new DataTable();
            adp.Fill(dt);
            return dt;
        }

        public DataTable getUpcommingAppointment()
        {
            CString.cmd = new SqlCommand("Sp_Get_UpcommingAppointment", CString.con);
            CString.cmd.CommandType = CommandType.StoredProcedure;
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
            if (max < count)
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        public int count(DateTime date, DateTime time, char status)
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
