using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TraSuaDTO
{
    public class ThucUongDTO
    {
        public string choosce = "Chọn";
        public string edit = "Sửa";
        public string remove = "Xóa";

        public string maThucUong { get; set; }
        public string tenThucUong { get; set; }
        public float gia { get; set; }

        public string chon { get => choosce; set => choosce = value; }
        public string sua { get => edit; set => edit = value; }
        public string xoa { get => remove; set => remove = value; }

    }
}
