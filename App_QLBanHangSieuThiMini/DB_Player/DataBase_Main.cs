using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App_QLBanHangSieuThiMini.DB_Player
{
    class DataBase_Main
    {
        string ConnStr = "Data Source=DESKTOP-LRIE6A1;Initial Catalog=QL_BanHang;Integrated Security=True ";
        SqlConnection conn = null;
        SqlCommand comn = null;
        SqlDataAdapter da = null;
        
        public DataBase_Main()
        {
            conn = new SqlConnection(ConnStr);
            comn = conn.CreateCommand();
        }
        public DataSet ExecuteQueryDataSet(string strSQL, CommandType ct)
        {
            if (conn.State == ConnectionState.Open)
            {
                conn.Close();
            }
            conn.Open();
            comn.CommandText = strSQL;
            comn.CommandType = ct;
            da = new SqlDataAdapter(comn);
            DataSet ds = new DataSet();
            da.Fill(ds);
            return ds;
        }
        public bool MyExecuteNonQuery(string strSQL, CommandType ct, ref string error)
        {
            bool f = false;
            if (conn.State == ConnectionState.Open)
            {
                conn.Close();
            }
            conn.Open();
            comn.CommandText = strSQL;
            comn.CommandType = ct;
            try
            {
                comn.ExecuteNonQuery();
                f = true;
            }
            catch (SqlException ex)
            {

                error = ex.Message;
            }
            finally
            {
                conn.Close();
            }
            return f;
        }

    }
}
