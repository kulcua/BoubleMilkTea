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
    public partial class QuanLyKho : Form
    {
        public QuanLyKho()
        {
            InitializeComponent();
        }
        ThucUongDTO thucUongDTO = new ThucUongDTO();
        ThucUongBUS thucUongBUS = new ThucUongBUS();

        ToppingDTO toppingDTO = new ToppingDTO();
        ToppingBUS toppingBUS = new ToppingBUS();

        private void QuanLyKho_Load(object sender, EventArgs e)
        {
            LoadThucUong();
            tbGiaThucUong.Enabled = true;
            tbTenThucUong.Enabled = true;
            LoadTopping();
        }

        // thưc hiện chức năng cho bảng thức uống
        private void LoadThucUong()
        {
            List<ThucUongDTO> listSanh = thucUongBUS.select();
            if (listSanh == null)
            {
                DialogResult kq = MessageBox.Show("Loi", "Vui long kiem tra lai internet truoc khi load data", MessageBoxButtons.YesNo);
                if (kq == DialogResult.Yes)
                    Application.Restart();
            }
            gridThucUong.Columns.Clear(); //xóa sạch cột trên datagridview
            gridThucUong.DataSource = null;

            gridThucUong.AutoGenerateColumns = false; //không cho phép tự động tạo cột
            gridThucUong.AllowUserToAddRows = false;  //không cho phép người dụng tự động thêm cột
            gridThucUong.DataSource = listSanh;

            DataGridViewTextBoxColumn clMa = new DataGridViewTextBoxColumn();
            clMa.Name = "Ma";
            clMa.HeaderText = "Mã Thức uống";
            clMa.DataPropertyName = "maThucUong"; //kiểu dữ liệu nằm ở lớp DTO
            gridThucUong.Columns.Add(clMa);

            DataGridViewTextBoxColumn clTen = new DataGridViewTextBoxColumn();
            clTen.Name = "Ten";
            clTen.HeaderText = "Tên Thức Uống";
            clTen.DataPropertyName = "tenThucUong";
            gridThucUong.Columns.Add(clTen);

            DataGridViewTextBoxColumn clGia = new DataGridViewTextBoxColumn();
            clGia.Name = "Gia";
            clGia.HeaderText = "Giá Tiền";
            clGia.DataPropertyName = "gia";
            gridThucUong.Columns.Add(clGia);

            DataGridViewButtonColumn clSua = new DataGridViewButtonColumn();
            clSua.Name = "btSua";
            clSua.HeaderText = "Sửa";
            clSua.DataPropertyName = "sua";
            gridThucUong.Columns.Add(clSua);

            DataGridViewButtonColumn clXoa = new DataGridViewButtonColumn();
            clXoa.Name = "btXoa";
            clXoa.HeaderText = "Xóa";
            clXoa.DataPropertyName = "xoa";
            gridThucUong.Columns.Add(clXoa);

            /// ep app cập nhật dữ liệu ngay lập tức lên datagridview  bằng cách binding datasource
            CurrencyManager myCurrencyManager = (CurrencyManager)this.BindingContext[gridThucUong.DataSource];
            myCurrencyManager.Refresh();
        }
        private void btn_ThemThucUong_Click(object sender, EventArgs e)
        {
            tbGiaThucUong.Enabled = true;
            tbTenThucUong.Enabled = true;
            thucUongDTO.tenThucUong = tbTenThucUong.Text;
            thucUongDTO.gia = float.Parse(tbGiaThucUong.Text);
            bool kq = thucUongBUS.Add(thucUongDTO);
            if (kq == true)
            {
                MessageBox.Show("Thêm dữ liệu thành công ");
            }
            else
                MessageBox.Show("Thêm dữ liệu thất bại", "Vui lòng kiểm tra lại thông tin");
            LoadThucUong();
        }

        private void gridThucUong_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int indexRow;
            indexRow = e.RowIndex;
            DataGridViewRow row = gridThucUong.Rows[indexRow];
            tbMaThucUong.Text = row.Cells[0].Value.ToString();
            tbTenThucUong.Text = row.Cells[1].Value.ToString();
            tbGiaThucUong.Text = row.Cells[2].Value.ToString();
        }

        private void gridThucUong_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 3)
            {
                if (thucUongDTO != null)
                {
                    thucUongDTO.maThucUong = tbMaThucUong.Text;
                    thucUongDTO.tenThucUong = tbTenThucUong.Text;
                    thucUongDTO.gia = float.Parse(tbGiaThucUong.Text);
                    bool kq = thucUongBUS.Update(thucUongDTO);
                    if (kq == false)
                        MessageBox.Show("Sửa nội dung thất bại. Vui lòng kiểm tra lại dữ liệu");
                    else
                    {
                        MessageBox.Show("Sửa nội dung thành công");
                        LoadThucUong();
                    }
                }
            }
            else if (e.ColumnIndex == 4)
            {
                int currentRowIndex = gridThucUong.CurrentCellAddress.Y;
                if (-1 < currentRowIndex && currentRowIndex < gridThucUong.RowCount)
                {
                    thucUongDTO = (ThucUongDTO)gridThucUong.Rows[currentRowIndex].DataBoundItem;
                    if (thucUongDTO != null)
                    {
                        bool kq = thucUongBUS.delete(thucUongDTO);
                        if (kq == false)
                            MessageBox.Show("Xóa nội dung thất bại. Vui lòng kiểm tra lại dũ liệu");
                        else
                        {
                            MessageBox.Show("Xóa nội dung thành công");
                            LoadThucUong();
                        }
                    }
                }
            }
        }


        // thực hiện chức năng cho bảng Topiing 

        private void LoadTopping()
        {
            List<ToppingDTO> listSanh = toppingBUS.select();
            if (listSanh == null)
            {
                DialogResult kq = MessageBox.Show("Loi", "Vui long kiem tra lai internet truoc khi load data", MessageBoxButtons.YesNo);
                if (kq == DialogResult.Yes)
                    Application.Restart();
            }
            gridTopping.Columns.Clear(); //xóa sạch cột trên datagridview
            gridTopping.DataSource = null;

            gridTopping.AutoGenerateColumns = false; //không cho phép tự động tạo cột
            gridTopping.AllowUserToAddRows = false;  //không cho phép người dụng tự động thêm cột
            gridTopping.DataSource = listSanh;

            DataGridViewTextBoxColumn clMa = new DataGridViewTextBoxColumn();
            clMa.Name = "Ma";
            clMa.HeaderText = "Mã Topping";
            clMa.DataPropertyName = "maTopping"; //kiểu dữ liệu nằm ở lớp DTO
            gridTopping.Columns.Add(clMa);

            DataGridViewTextBoxColumn clTen = new DataGridViewTextBoxColumn();
            clTen.Name = "Ten";
            clTen.HeaderText = "Tên Topping";
            clTen.DataPropertyName = "tenTopping";
            gridTopping.Columns.Add(clTen);

            DataGridViewTextBoxColumn clGia = new DataGridViewTextBoxColumn();
            clGia.Name = "Gia";
            clGia.HeaderText = "Giá Tiền";
            clGia.DataPropertyName = "giaTopping";
            gridTopping.Columns.Add(clGia);

            DataGridViewButtonColumn clSua = new DataGridViewButtonColumn();
            clSua.Name = "btSua";
            clSua.HeaderText = "Sửa";
            clSua.DataPropertyName = "sua";
            gridTopping.Columns.Add(clSua);

            DataGridViewButtonColumn clXoa = new DataGridViewButtonColumn();
            clXoa.Name = "btXoa";
            clXoa.HeaderText = "Xóa";
            clXoa.DataPropertyName = "xoa";
            gridTopping.Columns.Add(clXoa);

            /// ep app cập nhật dữ liệu ngay lập tức lên datagridview  bằng cách binding datasource
            CurrencyManager myCurrencyManager = (CurrencyManager)this.BindingContext[gridTopping.DataSource];
            myCurrencyManager.Refresh();
        }

        private void btn_ThemTopping_Click(object sender, EventArgs e)
        {
            tbGiaTopping.Enabled = true;
            tbTenTopping.Enabled = true;
            toppingDTO.tenTopping = tbTenTopping.Text;
            toppingDTO.giaTopping = float.Parse(tbGiaTopping.Text);
            bool kq = toppingBUS.Add(toppingDTO);
            if (kq == true)
            {
                MessageBox.Show("Thêm dữ liệu thành công ");
            }
            else
                MessageBox.Show("Thêm dữ liệu thất bại", "Vui lòng kiểm tra lại thông tin");
            LoadTopping();
        }

        private void gridTopping_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 3)
            {
                if (toppingDTO != null)
                {
                    toppingDTO.maTopping = int.Parse(tbMaTopping.Text);
                    toppingDTO.tenTopping = tbTenTopping.Text;
                    toppingDTO.giaTopping = float.Parse(tbGiaTopping.Text);
                    bool kq = toppingBUS.Update(toppingDTO);
                    if (kq == false)
                        MessageBox.Show("Sửa nội dung thất bại. Vui lòng kiểm tra lại dữ liệu");
                    else
                    {
                        MessageBox.Show("Sửa nội dung thành công");
                        LoadTopping();
                    }
                }
            }
            else if (e.ColumnIndex == 4)
            {
                int currentRowIndex = gridTopping.CurrentCellAddress.Y;
                if (-1 < currentRowIndex && currentRowIndex < gridTopping.RowCount)
                {
                    toppingDTO = (ToppingDTO)gridTopping.Rows[currentRowIndex].DataBoundItem;
                    if (toppingDTO != null)
                    {
                        bool kq = toppingBUS.delete(toppingDTO);
                        if (kq == false)
                            MessageBox.Show("Xóa nội dung thất bại. Vui lòng kiểm tra lại dũ liệu");
                        else
                        {
                            MessageBox.Show("Xóa nội dung thành công");
                            LoadTopping();
                        }
                    }
                }
            }
        }

        private void gridTopping_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int indexRow;
            indexRow = e.RowIndex;
            DataGridViewRow row = gridTopping.Rows[indexRow];
            tbMaTopping.Text = row.Cells[0].Value.ToString();
            tbTenTopping.Text = row.Cells[1].Value.ToString();
            tbGiaTopping.Text = row.Cells[2].Value.ToString();
        }

    }
}
