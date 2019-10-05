using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TraSuaDTO
{
    class VatLieuDTO
    {
        private int mavatlieu;
        private int tenvatlieu;

        public int Tenvatlieu { get => tenvatlieu; set => tenvatlieu = value; }
        public int Mavatlieu { get => mavatlieu; set => mavatlieu = value; }
    }
}
