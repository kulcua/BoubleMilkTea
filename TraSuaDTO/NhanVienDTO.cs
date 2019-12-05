using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TraSuaDTO
{
    public class NhanVienDTO
    {
        private int manv;
        private string tennv;
        private string chucvu;
        private string tendn;
        private int matkhau;

        public int Manv { get => manv; set => manv = value; }
        public string Tennv { get => tennv; set => tennv = value; }
        public string Chucvu { get => chucvu; set => chucvu = value; }
        public int Matkhau { get => matkhau; set => matkhau = value; }
    }
}
