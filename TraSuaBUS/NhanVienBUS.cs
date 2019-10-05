using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TraSuaBUS
{
    public class NhanVienBUS
    {
        private NhanVienBUS NhanvienDal;
        public NhanVienBUS()
        {
            NhanvienDal = new NhanvienDAL();
        }

        public bool them(NhanvienDTO nv)
        {
            bool re = NhanvienDal.them(nv);
            return re;
        }

        public bool xoa(NhanvienDTO nv)
        {
            bool re = NhanvienDal.xoa(nv);
            return re;
        }


        public bool sua(NhanvienDTO nv)
        {
            bool re = NhanvienDal.sua(nv);
            return re;
        }

        //public List<HieuXeDTO> select()
        //{
        //    return hxDal.select();
        //}
    }
}
