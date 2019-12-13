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
    public class NhanVienDAL
    {
        Fxuly xuLy = new Fxuly();

        public List<NhanVienDTO> select()
        {
            List<NhanVienDTO> listNV = new List<NhanVienDTO>();
            string query = String.Empty;
            query += "select [MANV], [TENNV], [CHUCVU], [MATKHAU] from [NHANVIEN]";
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
                                NhanVienDTO db = new NhanVienDTO();
                                db.Manv = int.Parse(reader["MANV"].ToString());
                                db.Tennv = reader["TENNV"].ToString();
                                db.Chucvu = reader["CHUCVU"].ToString();
                                db.Matkhau = int.Parse(reader["MATKHAU"].ToString());
                                listNV.Add(db);
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
                return listNV;
            }
        }
    }
}
