using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TraSuaDTO;
using TraSuaDAL;

namespace TraSuaBUS
{
    public class KhuyenMaiBUS
    {
        KhuyenMaiDAL khuyenMaiDAL = new KhuyenMaiDAL();
        public List<KhuyenMaiDTO> selectKM()
        {
            return khuyenMaiDAL.selectLoadCB();
        }
        private KhuyenMaiDAL kmDAL = new KhuyenMaiDAL();

        private Fxuly xl = new Fxuly();

        public List<KhuyenMaiDTO> select()
        {
            return kmDAL.select();
        }

        public bool Them(KhuyenMaiDTO kmDTO)
        {
            String query = String.Empty;
            query += "insert into KHUYENMAI(TENKM, TGBD, TGKT, MUCGIAMGIA)";
            query += "values('"  + kmDTO.Tenkm + "', '" + kmDTO.TgBD + "', '" + kmDTO.TgKT + "', '" + kmDTO.Mucgiamgia + "')";
            bool kq = xl.Command(query);
            return kq;
        }

        public bool Xoa(KhuyenMaiDTO kmDTO)
        {
            string query = "  delete from KHUYENMAI where MAKM='" + kmDTO.Makm + "'";
            bool kq=xl.Command(query);
            return kq;
        }
    }
}
