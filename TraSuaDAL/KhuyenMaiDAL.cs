using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TraSuaDTO;

namespace TraSuaDAL
{
    public class KhuyenMaiDAL
    {
        public List<KhuyenMaiDTO> selectLoadCB()
        {
            string query = String.Empty;
            Fxuly xuLy = new Fxuly();
            query += "select [MAKM], [TENKM], [MUCGIAMGIA] FROM [KHUYENMAI] ";
            List<KhuyenMaiDTO> list = new List<KhuyenMaiDTO>();

            using (SqlConnection con = new SqlConnection(xuLy.ConnectionString))
            {

                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.Connection = con;
                    cmd.CommandType = System.Data.CommandType.Text;
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
                                KhuyenMaiDTO kn = new KhuyenMaiDTO();
                                kn.maKhuyenMai = int.Parse(reader["MAKM"].ToString());
                                kn.tenKhuyenMai = reader["TENKM"].ToString();
                                kn.mucKhuyenMai = int.Parse(reader["MUCGIAMGIA"].ToString());
                                list.Add(kn);
                            }
                        }

                        con.Close();
                        con.Dispose();
                    }
                    catch (Exception ex)
                    {
                        con.Close();
                        return null;
                    }
                }
                return list;
            }
        }
    }
}
