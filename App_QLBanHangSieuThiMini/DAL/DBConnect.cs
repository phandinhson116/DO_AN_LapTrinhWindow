using System.Data;
using System.Data.SqlClient;

namespace App_QLBanHangSieuThiMini.DAL
{
    internal class DBConnect
    {
        private SqlConnection _connection;

        public DBConnect()
        {
            _connection = new SqlConnection("Data Source = (local); Initial Catalog = QL_BanHang; Integrated Security = True;");
        }

        public DataTable ExecuteQuery(string strSql)
        {
            DataTable dt = new DataTable();
            _connection.Open();
            try
            {
                SqlDataAdapter adapter = new SqlDataAdapter(strSql, _connection);
                adapter.Fill(dt);
            }
            catch (SqlException ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }
            _connection.Close();
            return dt;
        }

        public bool ExecuteNonQuery(string strSql)
        {
            bool result = true;
            _connection.Open();
            try
            {
                SqlCommand cmd = new SqlCommand(strSql, _connection);
                if (cmd.ExecuteNonQuery() > 0)
                    result = true;
            }
            catch (SqlException ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
                result = false;
            }
            _connection.Close();
            return result;
        }

        public object ExucuteScalar(string strSql)
        {
            object obj;
            _connection.Open();
            try
            {
                SqlCommand cmd = new SqlCommand(strSql, _connection);
                obj = cmd.ExecuteScalar();
            }
            catch (SqlException ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
                obj = new object();
            }
            _connection.Close();
            return obj;
        }
    }
}