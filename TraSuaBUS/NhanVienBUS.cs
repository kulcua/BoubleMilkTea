using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TraSuaDAL;
using TraSuaDTO;

namespace TraSuaBUS
{
    public class NhanVienBUS
    {
        private NhanVienDAL NhanvienDal;
        public NhanVienBUS()
        {
            NhanvienDal = new NhanVienDAL();
        }

        public bool them(NhanVienDTO nv)
        {
            bool re = NhanvienDal.them(nv);
            return re;
        }

        public bool xoa(NhanVienDTO nv)
        {
            bool re = NhanvienDal.xoa(nv);
            return re;
        }


        public bool sua(NhanVienDTO nv)
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
