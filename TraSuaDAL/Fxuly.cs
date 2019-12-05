using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TraSuaDAL
{
    public class Fxuly
    {
        public string ConnectionString = @"Data Source=DESKTOP-BOSN45B\SQLEXPRESS;Initial Catalog=TraSua;Integrated Security=True";

        public bool Command(String sql)
        {
            using (SqlConnection con = new SqlConnection(ConnectionString))
            {
                con.Open();
                try
                {
                    SqlCommand cmd = new SqlCommand(sql, con);
                    cmd.ExecuteNonQuery();
                    con.Close();
                    cmd.Dispose();
                }
                catch (Exception ex)
                {
                    con.Close();
                    return false;
                }
                return true;
            }
        }

        public DataTable select(string sql)
        {
            using (SqlConnection con = new SqlConnection(ConnectionString))
            {
                SqlDataAdapter dap = new SqlDataAdapter(sql, con);
                DataTable dt = new DataTable();
                dap.Fill(dt);
                return dt;
            }
        }
    }
}
