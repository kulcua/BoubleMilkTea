using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TraSuaBUS
{
    class OrderBUS
    {
        public OrderDAL OrderDal;
        public OrderBUS()
        {
            OrderDal = new OrderDAL();
        }
        public bool them(OrderDTO order)
        {
            bool re = OrderDal.them(order);
            return re;
        }

        public bool xoa(OrderDTO order)
        {
            bool re = OrderDal.xoa(order);
            return re;
        }


        public bool sua(OrderDTO order)
        {
            bool re = OrderDal.sua(order);
            return re;
        }

        //public List<ChiTietPhieuXuatDTO> select(string sKmahs)
        //{
        //    return ctpxDal.select(sKmahs);
        //}
    }
}
