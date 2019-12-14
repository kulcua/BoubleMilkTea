using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TraSuaDAL;
using TraSuaDTO;

namespace TraSuaBUS
{
    public class OrderBUS
    {
        OrderDAL order = new OrderDAL();
        Fxuly xuLy = new Fxuly();
        public List<OrderDTO> select()
        {
            return order.select();
        }

        public void Add(OrderDTO orderDTO)
        {
            string query = String.Empty;
            query += "set dateformat DMY ";
            query += "insert into CTHD(MAHOADON,DUONG,DA, MAKM) values('" + orderDTO.maHoaDon + "','" + orderDTO.duong + "','" + orderDTO.da + "','"+orderDTO.maKM+"')";
            xuLy.Command(query);
        }

        public List<OrderDTO> SelectTop1()
        {
            return order.SelectTop1();
        }

        public void insertThuocUong(OrderDTO orderDTO)
        {
            string query = String.Empty;
            query += "insert into CTHD(MATHUCUONG,MAHOADON) VALUES('" + orderDTO.maThucUong + "','" + orderDTO.maHoaDon + "')";
            xuLy.Command(query);
        }
        public void insertTopping(OrderDTO orderDTO)
        {
            string query = String.Empty;
            query += "insert into CTHD(MATOPPING,MAHOADON) VALUES('" + orderDTO.maTopping + "','" + orderDTO.maHoaDon + "')";
            xuLy.Command(query);
        }

        public List<OrderDTO> selectThucUongOrder(int maHoaDon)
        {
            return order.selectThucUongOrder(maHoaDon);
        }

        public List<OrderDTO> selectToppingOrder(int maHoaDon)
        {
            return order.selectToppingOrder(maHoaDon);
        }

        public void AddNote(OrderDTO orderDTO)
        {
            string query = String.Empty;
            query += "update CTHD set GHICHU='" + orderDTO.ghiChu + "' where MAHOADON='" + orderDTO.maHoaDon + "'";
             xuLy.Command(query);
        }

        public void Delete(OrderDTO orderDTO)
        {
            string query = String.Empty;
            query += "delete CTHD where MATHUCUONG=(SELECT MATHUCUONG FROM THUCUONG WHERE TENTHUCUONG='" + orderDTO.tenThucUong + "')";
            xuLy.Command(query);
        }

        public void DeleteTopping(OrderDTO orderDTO)
        {
            string query = String.Empty;
            query += "delete CTHD where MATOPPING=(SELECT MATOPPING FROM TOPPING WHERE TENTOPPING ='" + orderDTO.tenTopping+ "')";
            xuLy.Command(query);
        }
    }
}
