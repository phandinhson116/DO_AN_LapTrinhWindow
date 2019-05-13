using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.Sql;
using System.Data.SqlClient;
using App_QLBanHangSieuThiMini.ValueObject;

namespace App_QLBanHangSieuThiMini.DAL
{
    class DBConnect
    {
        SqlConnection _connection;

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

        /*
        private bool Them(string strTable, string strValues)
        {
            string strSql = string.Format("insert into {0} values({1})", strTable, strValues);
            ExecuteQuery(strSql);
            return true;
            /*
            bool result = true;
            try
            {
                ExecuteQuery(strSql);
            }
            catch (SqlException ex)
            {
                result = false;
            }
            return result;
            

        }*/
    }
}

