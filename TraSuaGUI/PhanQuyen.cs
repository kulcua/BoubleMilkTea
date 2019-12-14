using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TraSuaDTO;
using TraSuaBUS;

namespace BoubleMilkTea
{
    public partial class PhanQuyen : Form
    {
        public PhanQuyen()
        {
            InitializeComponent();
        }

        private NhanVienDTO nvDTO = new NhanVienDTO();
        private NhanVienBUS nvBUS = new NhanVienBUS();
        Random r = new Random();

        private void btn_Them_Click(object sender, EventArgs e)
        {
            nvDTO.Tennv = tb_TenNV.Text;
            nvDTO.Chucvu = cb_NV.Text;
            nvDTO.Matkhau = r.Next(1001, 10000);
            if (nvDTO != null)
            {
                bool kq = nvBUS.Them(nvDTO);
                if (kq == true)
                {
                    LoadNV();
                    MessageBox.Show("Thêm nhân viên thành công");
                }
                else
                    MessageBox.Show("Thêm nhân viên thất bại!");
            }
        }

        private void LoadNV()
        {

            PhanQuyen phanQuyen = new PhanQuyen();
            List<NhanVienDTO> listNV = nvBUS.select();
            if (listNV == null)
            {
                DialogResult kq = MessageBox.Show("Lỗi", "Kiểm tra lại kết nối  mạng", MessageBoxButtons.YesNo);
                if (kq == DialogResult.Yes)
                    phanQuyen.Refresh();
            }

            dgv_DsachNhanVien.Columns.Clear();
            dgv_DsachNhanVien.Columns.Clear();
            dgv_DsachNhanVien.DataSource = null;

            dgv_DsachNhanVien.AutoGenerateColumns = false;
            dgv_DsachNhanVien.AllowUserToAddRows = false;
            dgv_DsachNhanVien.DataSource = listNV;
            

            DataGridViewTextBoxColumn clMaNV = new DataGridViewTextBoxColumn();
            clMaNV.Name = "MaNV";
            clMaNV.HeaderText = "Mã Nhân Viên";
            clMaNV.DataPropertyName = "Manv";
            dgv_DsachNhanVien.Columns.Add(clMaNV);

            DataGridViewTextBoxColumn clTenNV = new DataGridViewTextBoxColumn();
            clTenNV.Name = "TenNV";
            clTenNV.HeaderText = "Tên Nhân Viên";
            clTenNV.DataPropertyName = "Tennv";
            dgv_DsachNhanVien.Columns.Add(clTenNV);

            DataGridViewTextBoxColumn clChucVu = new DataGridViewTextBoxColumn();
            clChucVu.Name = "ChucVu";
            clChucVu.HeaderText = "Chức Vụ";
            clChucVu.DataPropertyName = "Chucvu";
            dgv_DsachNhanVien.Columns.Add(clChucVu);

            DataGridViewTextBoxColumn clMatKhau = new DataGridViewTextBoxColumn();
            clMatKhau.Name = "MatKhau";
            clMatKhau.HeaderText = "Mật Khẩu";
            clMatKhau.DataPropertyName = "Matkhau";
            dgv_DsachNhanVien.Columns.Add(clMatKhau);


            CurrencyManager myCurrencyManager = (CurrencyManager)this.BindingContext[dgv_DsachNhanVien.DataSource];
            myCurrencyManager.Refresh();

        }

        private void btn_Back_Click(object sender, EventArgs e)
        {
            TuyChon tuyChon = new TuyChon();
            this.Hide();
            this.Close();
            tuyChon.Show();
        }

        private void btn_Xoa_Click(object sender, EventArgs e)
        {
            int currentRowIndex = dgv_DsachNhanVien.CurrentCellAddress.Y;
            if (-1 < currentRowIndex && currentRowIndex < dgv_DsachNhanVien.RowCount)
            {
                nvDTO = (NhanVienDTO)dgv_DsachNhanVien.Rows[currentRowIndex].DataBoundItem;
                if (nvDTO != null)
                {
                    bool kq = nvBUS.Xoa(nvDTO);
                    if (kq == true)
                    {
                        LoadNV();
                        MessageBox.Show("Xóa nhân viên thành công");
                    }
                    else
                        MessageBox.Show("Xóa nhân viên thất bại");
                }
            }
        }
    }
}
