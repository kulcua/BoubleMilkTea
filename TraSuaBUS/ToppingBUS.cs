using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TraSuaDAL;
using TraSuaDTO;

namespace TraSuaBUS
{
    public class ToppingBUS
    {
        ToppingDAL db = new ToppingDAL();
        Fxuly xl = new Fxuly();
        public List<ToppingDTO> select()
        {
            return db.select();
        }

        public bool Add(ToppingDTO topping)
        {
            String query = String.Empty;
            query += "insert into TOPPING(TENTOPPING,GIATOPPING) values('" + topping.tenTopping + "','" + topping.giaTopping + "')";
            bool kq = xl.Command(query);
            return kq;
        }

        public bool Update(ToppingDTO toppingDTO)
        {
            bool kq = db.sua(toppingDTO);
            return kq;
        }

        public bool delete(ToppingDTO toppingDTO)
        {
            String query = String.Empty;
            query += "delete from TOPPING where MATOPPING='" + toppingDTO.maTopping + "'";
            bool kq = xl.Command(query);
            return kq;
        }
    }
}
