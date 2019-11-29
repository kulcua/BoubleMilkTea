using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TraSuaDAL;
using TraSuaDTO;

namespace TraSuaBUS
{
    public class ThucUongBUS
    {
        ThucUongDAL db = new ThucUongDAL();
        Fxuly xl = new Fxuly();
        public List<ThucUongDTO> select()
        {
            return db.select();
        }
        public bool Add(ThucUongDTO thucuong)
        {
            String query = String.Empty;
            query += "insert into THUCUONG(TENTHUCUONG,GIATHUCUONG) values('" + thucuong.tenThucUong + "','" + thucuong.gia + "')";
            bool kq = xl.Command(query);
            return kq;
        }

        public bool Update(ThucUongDTO thucUongDTO)
        {
            bool kq = db.sua(thucUongDTO);
            return kq;
        }

        public bool delete(ThucUongDTO thucUongDTO)
        {
            String query = String.Empty;
            query += "delete from THUCUONG where MATHUCUONG='" + thucUongDTO.maThucUong + "'";
            bool kq = xl.Command(query);
            return kq;
        }
    }
}
