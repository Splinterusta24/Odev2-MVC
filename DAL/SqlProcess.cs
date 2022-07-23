using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace Odev2_MVC.DAL
{
    public class SqlProcess
    {
        SqlConnection _con;
        SqlCommand _cmd;
        readonly SqlConnect _connectionString = new SqlConnect();

        private SqlConnection SqlConnect()
        {
            _con = new SqlConnection(_connectionString.SqlConnection);
            if (_con.State != ConnectionState.Open)
            {
                _con.Open();

            }
            return _con;
        }
        private void SqlClosed()
        {
            if (_con.State == ConnectionState.Closed)
            {
                _con.Close();
            }
        }

        public bool SetExecuteNonQuery(string cmdSql, params SqlParameter[] sqlParameters)
        {
            try
            {
                _cmd = new SqlCommand(cmdSql, SqlConnect());
                _cmd.Parameters.AddRange(sqlParameters);
                _cmd.ExecuteNonQuery();
                _cmd.Dispose();
                SqlClosed();
                return true;
            }
            catch (Exception)
            {

                return false;
            }
        }
        public DataTable SetExecuteReader(string cmdSql, params SqlParameter[] sqlParameters)
        {
            _cmd = new SqlCommand(cmdSql, SqlConnect());
            _cmd.Parameters.AddRange(sqlParameters);
            DataTable dt = new DataTable();
            dt.Load(_cmd.ExecuteReader());
            _cmd.Dispose();
            SqlClosed();
            return dt;

        }
    }
}