using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TraSuaDTO
{
    public class OrderDTO
    {
        public string choosce = "Chọn";
        public string edit = "Sửa";
        public string remove = "Xóa";

        public int maCTHD { get; set; }
        public int maThucUong { get; set; }
        public int maTopping { get; set; }
        //public DateTime Thoigian { get; set; }
        public int da { get; set; }
        public int duong { get; set; }
        public int maHoaDon { get; set; }
        public string tenThucUong { get; set; }
        public int giaThucUong { get; set; }

        public string tenTopping { get; set; }
        public int giaTopping { get; set; }


        public int maKM { get; set; }

        public string chon { get => choosce; set => choosce = value; }
        public string sua { get => edit; set => edit = value; }
        public string xoa { get => remove; set => remove = value; }
    }
}
