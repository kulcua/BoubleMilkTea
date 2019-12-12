using System;
using System.Collections.Generic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using TraSuaDTO;

namespace TraSuaDAL
{
    public class KhuyenMaiDAL
    {
        Fxuly xuLy = new Fxuly();

        public List<KhuyenMaiDTO> select()
        {
            List<KhuyenMaiDTO> listKM = new List<KhuyenMaiDTO>();
            string query = String.Empty;
            query += "select [MAKM], [TENKM], [TGBD], [TGKT], [MUCGIAMGIA] from [KHUYENMAI]";
            using (SqlConnection con = new SqlConnection(xuLy.ConnectionString))
            {
                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.Connection = con;
                    cmd.CommandType = CommandType.Text;
                    cmd.CommandText = query;
                    try
                    {
                        con.Open();
                        SqlDataReader reader = null;
                        reader = cmd.ExecuteReader();
                        if (reader.HasRows == true)
                        {
                            while (reader.Read())
                            {
                                KhuyenMaiDTO db = new KhuyenMaiDTO();
                                db.Makm = int.Parse(reader["MAKM"].ToString());
                                db.Tenkm = reader["TENKM"].ToString();
                                db.TgBD = DateTime.Parse(reader["CHUCVU"].ToString());
                                db.TgKT = DateTime.Parse(reader["MATKHAU"].ToString());
                                db.Mucgiamgia = int.Parse(reader["MUCGIAMGIA"].ToString());
                                listKM.Add(db);
                            }
                        }
                        con.Close();
                        con.Dispose();
                    }
                    catch (Exception ex)
                    {
                        con.Close();
                        con.Dispose();
                    }
                }
                return listKM;
            }
        }
    }
}
