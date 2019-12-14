using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TraSuaBUS;
using TraSuaDTO;

namespace BoubleMilkTea
{
    public partial class SetKhuyenMai : Form
    {
        public SetKhuyenMai()
        {
            InitializeComponent();
            loadListTS();
        }

        private ThucUongBUS TUbus = new ThucUongBUS();
        private ThucUongDTO TUdto = new ThucUongDTO();
        private KhuyenMaiBUS kmBUS = new KhuyenMaiBUS();
        private KhuyenMaiDTO kmDTO = new KhuyenMaiDTO();


        private void loadListTS()
        {
            List<string> thucUongs = TUbus.selectTenTU();


            for(int i = 0; i<thucUongs.Count; i++ )
            {
                checkbox_ThucUong.Items.Add(thucUongs[i]);

            }

            checkbox_ThucUong.Refresh();
        }

        private void btn_Them_Click(object sender, EventArgs e)
        {
            kmDTO.Tenkm = tb_MaKM.Text;
            kmDTO.TgBD = dt_batdau.Value;
            kmDTO.TgKT = dt_KetThuc.Value;
            kmDTO.Mucgiamgia = int.Parse(tb_MucGiamGia.Text.ToString());
            if  (kmDTO!=null)
            {
                bool kq = kmBUS.Them(kmDTO);
                if ( kq == true )
                {
                    loadKM();
                    MessageBox.Show("Thêm khuyến mãi thành công");
                }
                else
                    MessageBox.Show("Thêm khuyến mãi thất bại!");
            }
        }

        private void loadKM()
        {
            SetKhuyenMai km = new SetKhuyenMai();
            List<KhuyenMaiDTO> listKM = kmBUS.select();
            if (listKM == null)
            {
                DialogResult kq = MessageBox.Show("Lỗi", "Kiểm tra lại kết nối  mạng", MessageBoxButtons.YesNo);
                if (kq == DialogResult.Yes)
                    km.Refresh();
            }

            dgv_KM.Columns.Clear();
            dgv_KM.Columns.Clear();
            dgv_KM.DataSource = null;

            dgv_KM.AutoGenerateColumns = false;
            dgv_KM.AllowUserToAddRows = false;
            dgv_KM.DataSource = listKM;

            DataGridViewTextBoxColumn clMaKM = new DataGridViewTextBoxColumn();
            clMaKM.Name = "MaKM";
            clMaKM.HeaderText = "Mã khuyến mãi";
            clMaKM.DataPropertyName = "Makm";
            dgv_KM.Columns.Add(clMaKM);

            DataGridViewTextBoxColumn clTenKM = new DataGridViewTextBoxColumn();
            clTenKM.Name = "TenKM";
            clTenKM.HeaderText = "Tên khuyến mãi";
            clTenKM.DataPropertyName = "Tenkm";
            dgv_KM.Columns.Add(clTenKM);

            DataGridViewTextBoxColumn clTgBD = new DataGridViewTextBoxColumn();
            clTgBD.Name = "TgBD";
            clTgBD.HeaderText = "Thời gian bắt đầu";
            clTgBD.DataPropertyName = "TgBD";
            dgv_KM.Columns.Add(clTgBD);

            DataGridViewTextBoxColumn clTgKT = new DataGridViewTextBoxColumn();
            clTgKT.Name = "TgKT";
            clTgKT.HeaderText = "Thời gian kết thúc";
            clTgKT.DataPropertyName = "TgKT";
            dgv_KM.Columns.Add(clTgKT);

            DataGridViewTextBoxColumn clMuc = new DataGridViewTextBoxColumn();
            clMuc.Name = "Muc";
            clMuc.HeaderText = "Mức giảm giá";
            clMuc.DataPropertyName = "Mucgiamgia";
            dgv_KM.Columns.Add(clMuc);


            CurrencyManager myCurrencyManager = (CurrencyManager)this.BindingContext[dgv_KM.DataSource];
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
            int currentRowIndex = dgv_KM.CurrentCellAddress.Y;
            if (-1 < currentRowIndex && currentRowIndex < dgv_KM.RowCount)
            {
                kmDTO = (KhuyenMaiDTO)dgv_KM.Rows[currentRowIndex].DataBoundItem;
                if (kmDTO != null)
                {
                    bool kq = kmBUS.Xoa(kmDTO);
                    if (kq == true)
                    {
                        loadKM();
                        MessageBox.Show("Xóa khuyến mãi thành công");
                    }
                    else
                        MessageBox.Show("Xóa khuyến mãi thất bại");
                }
            }
        }
    }
}
