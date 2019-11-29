using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TraSuaDAL;
using TraSuaDTO;

namespace TraSuaDAL
{
    public class ToppingDAL
    {
        Fxuly xuLy = new Fxuly();
        //tạo danh sách và đưa dữ liệu vào danh sách

        public List<ToppingDTO> select()
        {
            List<ToppingDTO> listSanh = new List<ToppingDTO>();
            string query = string.Empty;
            // câu lệnh thực hiện truy vấn 
            query += "select [MATOPPING],[TENTOPPING],[GIATOPPING]";
            query += " from [TOPPING]";
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
                                ToppingDTO db = new ToppingDTO();
                                db.maTopping = int.Parse(reader["MATOPPING"].ToString());
                                db.tenTopping = reader["TENTOPPING"].ToString();
                                db.giaTopping = float.Parse(reader["GIATOPPING"].ToString());
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

        public bool sua(ToppingDTO toppingDTO)
        {
            string query = String.Empty;
            query += "update TOPPING set [TENTOPPING]=@tenTopping, [GIATOPPING]=@gia where [MATOPPING]=@maTopping ";
            using (SqlConnection con = new SqlConnection(xuLy.ConnectionString))
            {
                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.Connection = con;
                    cmd.CommandType = System.Data.CommandType.Text;
                    cmd.CommandText = query;
                    cmd.Parameters.AddWithValue("@maTopping", toppingDTO.maTopping);
                    cmd.Parameters.AddWithValue("@tenTopping", toppingDTO.tenTopping);
                    cmd.Parameters.AddWithValue("@gia", toppingDTO.giaTopping);
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
