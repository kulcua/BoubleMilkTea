using System;
using System.Collections.Generic;
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
        public List<KhuyenMaiDTO> select()
        {
            return khuyenMaiDAL.selectLoadCB();
        }
    }
}
