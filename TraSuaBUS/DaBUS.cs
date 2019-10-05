using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TraSuaDAL;
using TraSuaDTO;

namespace TraSuaBUS
{
    class DaBUS
    {
        private DaBUS daDal;
        public DaBUS()
        {
            daDal = new DaDAL();
        }

        public bool them(DaDTO da)
        {
            bool re = daDal.them(da);
            return re;
        }

        public bool xoa(DaDTO da)
        {
            bool re = DaDTO.xoa(da);
            return re;
        }


        public bool sua(DaDTO da)
        {
            bool re = daDal.sua(da);
            return re;
        }

        //public List<HieuXeDTO> select()
        //{
        //    return hxDal.select();
        //}
    }
}
