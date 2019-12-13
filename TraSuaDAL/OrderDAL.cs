using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TraSuaDTO;

namespace TraSuaDAL
{
    public class OrderDAL
    {
        Fxuly xuLy = new Fxuly();
        public List<OrderDTO> select()
        {
            List<OrderDTO> list = new List<OrderDTO>();
            string query = string.Empty;
            // câu lệnh thực hiện truy vấn 
            query += "select [MACTHD],[MATHUCUONG],[MATOPPING],[MAKM],[MAHOADON],[DUONG],[DA]";
            query += " from [CTHD] where [MAHOADON] =@maHoaDon";
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
                                OrderDTO db = new OrderDTO();
                                db.maCTHD = int.Parse(reader["MACTHD"].ToString());
                                db.maThucUong = int.Parse(reader["MATHUCUONG"].ToString());
                                db.maTopping = int.Parse(reader["MATOPPING"].ToString());
                                db.maKM = int.Parse(reader["MAKM"].ToString());
                                db.maHoaDon = int.Parse(reader["MAHOADON"].ToString());
                                db.duong = int.Parse(reader["DUONG"].ToString());
                                db.da = int.Parse(reader["DA"].ToString());
                                list.Add(db);
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
            return list;
        }

        public List<OrderDTO> selectToppingOrder(int maHoaDon)
        {
            List<OrderDTO> list = new List<OrderDTO>();
            string query = String.Empty;
            query += "select [TENTOPPING],[GIATOPPING]from [TOPPING], [CTHD] ";
            query += " where (TOPPING.[MATOPPING] = CTHD.[MATOPPING]) AND";
            query += " ( [MAHOADON] LIKE CONCAT ('%',@maHoaDon,'%'))";
            using (SqlConnection con = new SqlConnection(xuLy.ConnectionString))
            {
                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.Connection = con;
                    cmd.CommandType = System.Data.CommandType.Text;
                    cmd.CommandText = query;
                    cmd.Parameters.AddWithValue("@maHoaDon", maHoaDon);
                    try
                    {
                        con.Open();
                        SqlDataReader reader = null;
                        reader = cmd.ExecuteReader();
                        if (reader.HasRows == true)
                        {
                            while (reader.Read())
                            {
                                OrderDTO db = new OrderDTO();
                                db.tenTopping = reader["TENTOPPING"].ToString();
                                db.giaTopping = int.Parse(reader["GIATOPPING"].ToString());
                                list.Add(db);
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
                return list;
            }
        }

        public List<OrderDTO> selectThucUongOrder(int maHoaDon)
        {
            List<OrderDTO> list = new List<OrderDTO>();
            string query = String.Empty;
            query += "select [TENTHUCUONG],[GIATHUCUONG],[GHICHU] from [THUCUONG], [CTHD] ";
            query += " where (THUCUONG.[MATHUCUONG] = CTHD.[MATHUCUONG]) AND";
            query += " ( [MAHOADON] LIKE CONCAT ('%',@maHoaDon,'%'))";
            using (SqlConnection con = new SqlConnection(xuLy.ConnectionString))
            {
                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.Connection = con;
                    cmd.CommandType = System.Data.CommandType.Text;
                    cmd.CommandText = query;
                    cmd.Parameters.AddWithValue("@maHoaDon", maHoaDon);
                    try
                    {
                        con.Open();
                        SqlDataReader reader = null;
                        reader = cmd.ExecuteReader();
                        if (reader.HasRows == true)
                        {
                            while (reader.Read())
                            {
                                OrderDTO db = new OrderDTO();
                                db.tenThucUong = reader["TENTHUCUONG"].ToString();
                                db.giaThucUong = float.Parse(reader["GIATHUCUONG"].ToString());
                                db.ghiChu = reader["GHICHU"].ToString();
                                list.Add(db);
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
                return list;
            }
        }

        public List<OrderDTO> SelectTop1()
        {
            string query = String.Empty;
            query += "select top 1 [MACTHD] FROM [CTHD] ORDER BY [MACTHD] DESC";
            List<OrderDTO> list = new List<OrderDTO>();

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
                                OrderDTO kn = new OrderDTO();
                                kn.maCTHD = int.Parse(reader["MACTHD"].ToString());
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