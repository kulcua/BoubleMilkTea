using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TraSuaDAL;
using TraSuaDTO;
namespace TraSuaBUS
{
    public class DuongBUS
    {
        private DuongDAL duongDal;
        public DuongBUS()
        {
            duongDal = new DuongDAL();
        }

        public bool them(DuongDTO duong)
        {
            bool re = duongDal.them(duong);
            return re;
        }

        public bool xoa(DuongDTO duong)
        {
            bool re = DuongDTO.xoa(duong);
            return re;
        }


        public bool sua(DuongDTO duong)
        {
            bool re = duongDal.sua(duong);
            return re;
        }

        //public List<HieuXeDTO> select()
        //{
        //    return hxDal.select();
        //}
    }
}
