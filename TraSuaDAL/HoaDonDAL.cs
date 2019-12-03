using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TraSuaDTO;

namespace TraSuaDAL
{
    public class HoaDonDAL
    {
        Fxuly xuLy = new Fxuly();
        public List<HoaDonDTO> SelectTop1()
        {
            string query = String.Empty;
            query += "select top 1 [MAHOADON] FROM [HOADON] ORDER BY [MAHOADON] DESC";
            List<HoaDonDTO> list = new List<HoaDonDTO>();

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
                                HoaDonDTO kn = new HoaDonDTO();
                                kn.maHoaDon = int.Parse(reader["MAHOADON"].ToString());
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
