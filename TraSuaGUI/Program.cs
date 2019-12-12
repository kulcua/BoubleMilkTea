using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BoubleMilkTea
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            QuanLyKho kho = new QuanLyKho();
            DangNhap dangNhap = new DangNhap();
            TuyChon tuyChon = new TuyChon();
            SetKhuyenMai km = new SetKhuyenMai();
            ThongKeDoanhSo thongke = new ThongKeDoanhSo();
            Application.Run(dangNhap);
        }
    }
}
