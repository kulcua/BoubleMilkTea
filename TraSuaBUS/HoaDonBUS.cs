using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TraSuaDAL;
using TraSuaDTO;

namespace TraSuaBUS
{
    public class HoaDonBUS
    {
        Fxuly xuLy = new Fxuly();
        HoaDonDAL hoaDonDAL = new HoaDonDAL();
        public void Add(HoaDonDTO hoaDonDTO)
        {
            string query = String.Empty;
            query += "set dateformat DMY ";
            query += "insert into HOADON(MANV,TENKH,TGBD) values('"+hoaDonDTO.maNV+"','" + hoaDonDTO.tenKH + "','"+hoaDonDTO.TGBD+"')";
            xuLy.Command(query);
        }

        public List<HoaDonDTO> selectTop1()
        {
            return hoaDonDAL.SelectTop1();
        }

        public void updateTongTien(HoaDonDTO hoaDonDTO)
        {
            string query = String.Empty;
            query += "set dateformat DMY ";
            query += "update HOADON set TONGTIEN='"+hoaDonDTO.tongTien+"' WHERE MAHOADON='"+hoaDonDTO.maHoaDon+"'";
            xuLy.Command(query);
        }
    }
}
