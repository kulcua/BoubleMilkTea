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
            query += "insert into CTHD(MAHOADON,DUONG,DA) values('" + orderDTO.maHoaDon + "','" + orderDTO.duong + "','" + orderDTO.da + "')";
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
    }
}
