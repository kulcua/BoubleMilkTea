using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TraSuaDAL;
using TraSuaDTO;

namespace TraSuaBUS
{
    public class NhanVienBUS
    {
        private NhanVienDAL nvDAL = new NhanVienDAL();
        private Fxuly xl = new Fxuly();

        public List<NhanVienDTO> select()
        {
            return nvDAL.select();
        }

        public bool Them(NhanVienDTO nvDTO)
        {
            String query = String.Empty;
            query += "insert into NHANVIEN(TENNV, CHUCVU, MATKHAU)";
            query += "values('" + nvDTO.Tennv + "', '" + nvDTO.Chucvu + "', '" + nvDTO.Matkhau + "')";
            bool kq = xl.Command(query);
            return kq;
        }

        public bool Xoa(NhanVienDTO nvDTO)
        {
            string query = "delete from NHANVIEN where MANV='" + nvDTO.Manv + "'";
            bool kq = xl.Command(query);
            return kq;
        }



        

        //public bool them(NhanVienDTO nv)
        //{
        //    bool re = NhanvienDal.them(nv);
        //    return re;
        //}

        //public bool xoa(NhanVienDTO nv)
        //{
        //    bool re = NhanvienDal.xoa(nv);
        //    return re;
        //}


        //public bool sua(NhanVienDTO nv)
        //{
        //    bool re = NhanvienDal.sua(nv);
        //    return re;
        //}

        //public List<HieuXeDTO> select()
        //{
        //    return hxDal.select();
        //}
    }
}
