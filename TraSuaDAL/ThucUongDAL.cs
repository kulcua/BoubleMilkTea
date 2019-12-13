using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TraSuaDTO;

namespace TraSuaDAL
{
    public class ThucUongDAL
    {
        Fxuly xuLy = new Fxuly();
        //tạo danh sách và đưa dữ liệu vào danh sách


        // trả về list tên
        public List<string> selectTen()
        {
            List<string> listTen = new List<string>();
            string query = string.Empty;

            query += "select [TENTHUCUONG]";
            query += " from [THUCUONG]";
            using (SqlConnection conn = new SqlConnection(xuLy.ConnectionString))
            {
                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.Connection = conn;
                    cmd.CommandType = System.Data.CommandType.Text;
                    cmd.CommandText = query;
                    try
                    {
                        conn.Open();
                        SqlDataReader reader = null;
                        reader = cmd.ExecuteReader();
                        if (reader.HasRows == true)
                        {
                            while (reader.Read())
                            {
                                string db = "";
                                db = reader["TENTHUCUONG"].ToString();
                                listTen.Add(db);
                            }
                        }
                        conn.Close();
                        conn.Dispose(); // tra lai tat ca tai nguyen da su dung de giai phong bo nho
                    }
                    catch (Exception ex)
                    {
                        conn.Close();
                        return null;
                    }
                }
            }

            return listTen;
        }

        public List<ThucUongDTO> select()
        {
            List<ThucUongDTO> listSanh = new List<ThucUongDTO>();
            string query = string.Empty;
            // câu lệnh thực hiện truy vấn 
            query += "select [MATHUCUONG],[TENTHUCUONG],[GIATHUCUONG]";
            query += " from [THUCUONG]";
            using (SqlConnection conn = new SqlConnection(xuLy.ConnectionString))
            {
                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.Connection = conn;
                    cmd.CommandType = System.Data.CommandType.Text;
                    cmd.CommandText = query;
                    try
                    {
                        conn.Open();
                        SqlDataReader reader = null;
                        reader = cmd.ExecuteReader();
                        if (reader.HasRows == true)
                        {
                            while (reader.Read())
                            {
                                ThucUongDTO db = new ThucUongDTO();
                                db.maThucUong = reader["MATHUCUONG"].ToString();
                                db.tenThucUong = reader["TENTHUCUONG"].ToString();
                                db.gia = int.Parse(reader["GIATHUCUONG"].ToString());
                                listSanh.Add(db);
                            }
                        }
                        conn.Close();
                        conn.Dispose(); // tra lai tat ca tai nguyen da su dung de giai phong bo nho
                    }
                    catch (Exception ex)
                    {
                        conn.Close();
                        return null;
                    }
                }
            }
            return listSanh;
        }

        public bool sua(ThucUongDTO thucUongDTO)
        {
            string query = String.Empty;
            query += "update THUCUONG set [TENTHUCUONG]=@tenThucUong, [GIATHUCUONG]=@gia where [MATHUCUONG]=@maThucUong ";
            using (SqlConnection con = new SqlConnection(xuLy.ConnectionString))
            {
                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.Connection = con;
                    cmd.CommandType = System.Data.CommandType.Text;
                    cmd.CommandText = query;
                    cmd.Parameters.AddWithValue("@maThucUong", thucUongDTO.maThucUong);
                    cmd.Parameters.AddWithValue("@tenThucUong", thucUongDTO.tenThucUong);
                    cmd.Parameters.AddWithValue("@gia", thucUongDTO.gia);
                    try
                    {
                        con.Open();
                        cmd.ExecuteNonQuery();
                        con.Close();
                        con.Dispose();
                    }
                    catch (Exception ex)
                    {
                        con.Close();
                        return false;
                    }
                }
            }
            return true;
        }
    }
}
