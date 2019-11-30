using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TraSuaDTO
{
    public class ToppingDTO
    {
        public string choosce = "Chọn";
        public string edit = "Sửa";
        public string remove = "Xóa";

        public int maTopping { get; set; }
        public string tenTopping { get; set; }
        public float giaTopping { get; set; }

        public string chon { get => choosce; set => choosce = value; }
        public string sua { get => edit; set => edit = value; }
        public string xoa { get => remove; set => remove = value; }
    }
}
