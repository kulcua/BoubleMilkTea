namespace BoubleMilkTea
{
    partial class Order
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.cbKM = new System.Windows.Forms.ComboBox();
            this.tbTenKH = new System.Windows.Forms.TextBox();
            this.btTopping = new System.Windows.Forms.Button();
            this.btThucUong = new System.Windows.Forms.Button();
            this.gridThucAn = new System.Windows.Forms.DataGridView();
            this.label4 = new System.Windows.Forms.Label();
            this.lbMaHD = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lb_TenKH = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.btn_InHoaDon = new System.Windows.Forms.Button();
            this.lb_TongTien = new System.Windows.Forms.Label();
            this.lb_ThoiGian = new System.Windows.Forms.Label();
            this.label = new System.Windows.Forms.Label();
            this.tbMaNhanVien = new System.Windows.Forms.Label();
            this.gridTopping = new System.Windows.Forms.DataGridView();
            this.lbTongTien = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lbTienThoi = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.tbTienNhan = new System.Windows.Forms.TextBox();
            this.btn_ThemThucUong = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.cbMucDuong = new System.Windows.Forms.ComboBox();
            this.cbMucDa = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.gridAnHD = new System.Windows.Forms.DataGridView();
            this.gridAnCTHD = new System.Windows.Forms.DataGridView();
            this.lbMaCTHD = new System.Windows.Forms.Label();
            this.gridLoadThucUong = new System.Windows.Forms.DataGridView();
            this.gridLoadTopping = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.gridThucAn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridTopping)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridAnHD)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridAnCTHD)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridLoadThucUong)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridLoadTopping)).BeginInit();
            this.SuspendLayout();
            // 
            // cbKM
            // 
            this.cbKM.FormattingEnabled = true;
            this.cbKM.Items.AddRange(new object[] {
            "70%",
            "30%"});
            this.cbKM.Location = new System.Drawing.Point(201, 225);
            this.cbKM.Name = "cbKM";
            this.cbKM.Size = new System.Drawing.Size(223, 24);
            this.cbKM.TabIndex = 57;
            // 
            // tbTenKH
            // 
            this.tbTenKH.Location = new System.Drawing.Point(197, 185);
            this.tbTenKH.Name = "tbTenKH";
            this.tbTenKH.Size = new System.Drawing.Size(228, 22);
            this.tbTenKH.TabIndex = 53;
            // 
            // btTopping
            // 
            this.btTopping.ForeColor = System.Drawing.Color.Black;
            this.btTopping.Location = new System.Drawing.Point(197, 261);
            this.btTopping.Name = "btTopping";
            this.btTopping.Size = new System.Drawing.Size(167, 37);
            this.btTopping.TabIndex = 52;
            this.btTopping.Text = "Topping";
            this.btTopping.UseVisualStyleBackColor = true;
            this.btTopping.Click += new System.EventHandler(this.btTopping_Click);
            // 
            // btThucUong
            // 
            this.btThucUong.ForeColor = System.Drawing.Color.Black;
            this.btThucUong.Location = new System.Drawing.Point(23, 261);
            this.btThucUong.Name = "btThucUong";
            this.btThucUong.Size = new System.Drawing.Size(167, 37);
            this.btThucUong.TabIndex = 51;
            this.btThucUong.Text = "Thức uống";
            this.btThucUong.UseVisualStyleBackColor = true;
            this.btThucUong.Click += new System.EventHandler(this.btThucUong_Click);
            // 
            // gridThucAn
            // 
            this.gridThucAn.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gridThucAn.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.gridThucAn.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridThucAn.Location = new System.Drawing.Point(12, 308);
            this.gridThucAn.Name = "gridThucAn";
            this.gridThucAn.RowHeadersWidth = 51;
            this.gridThucAn.RowTemplate.Height = 27;
            this.gridThucAn.Size = new System.Drawing.Size(616, 285);
            this.gridThucAn.TabIndex = 50;
            this.gridThucAn.Visible = false;
            this.gridThucAn.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gridOrder_CellContentClick);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.WindowText;
            this.label4.Location = new System.Drawing.Point(23, 224);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(147, 24);
            this.label4.TabIndex = 49;
            this.label4.Text = "Mã KM (nếu có):";
            // 
            // lbMaHD
            // 
            this.lbMaHD.AutoSize = true;
            this.lbMaHD.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbMaHD.ForeColor = System.Drawing.SystemColors.WindowText;
            this.lbMaHD.Location = new System.Drawing.Point(23, 112);
            this.lbMaHD.Name = "lbMaHD";
            this.lbMaHD.Size = new System.Drawing.Size(0, 24);
            this.lbMaHD.TabIndex = 48;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.WindowText;
            this.label3.Location = new System.Drawing.Point(20, 81);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(115, 24);
            this.label3.TabIndex = 47;
            this.label3.Text = "Mã Hóa Đơn";
            // 
            // lb_TenKH
            // 
            this.lb_TenKH.AutoSize = true;
            this.lb_TenKH.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_TenKH.ForeColor = System.Drawing.SystemColors.WindowText;
            this.lb_TenKH.Location = new System.Drawing.Point(19, 183);
            this.lb_TenKH.Name = "lb_TenKH";
            this.lb_TenKH.Size = new System.Drawing.Size(103, 24);
            this.lb_TenKH.TabIndex = 36;
            this.lb_TenKH.Text = "Tên khách: ";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(197, 141);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(228, 22);
            this.dateTimePicker1.TabIndex = 55;
            // 
            // btn_InHoaDon
            // 
            this.btn_InHoaDon.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btn_InHoaDon.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btn_InHoaDon.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_InHoaDon.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_InHoaDon.Location = new System.Drawing.Point(1206, 486);
            this.btn_InHoaDon.Name = "btn_InHoaDon";
            this.btn_InHoaDon.Size = new System.Drawing.Size(206, 65);
            this.btn_InHoaDon.TabIndex = 43;
            this.btn_InHoaDon.Text = "In Hoá Đơn";
            this.btn_InHoaDon.UseVisualStyleBackColor = false;
            this.btn_InHoaDon.Visible = false;
            this.btn_InHoaDon.Click += new System.EventHandler(this.btn_InHoaDon_Click);
            // 
            // lb_TongTien
            // 
            this.lb_TongTien.AutoSize = true;
            this.lb_TongTien.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lb_TongTien.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_TongTien.ForeColor = System.Drawing.SystemColors.WindowText;
            this.lb_TongTien.Location = new System.Drawing.Point(936, 465);
            this.lb_TongTien.Name = "lb_TongTien";
            this.lb_TongTien.Size = new System.Drawing.Size(2, 31);
            this.lb_TongTien.TabIndex = 41;
            // 
            // lb_ThoiGian
            // 
            this.lb_ThoiGian.AutoSize = true;
            this.lb_ThoiGian.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_ThoiGian.ForeColor = System.Drawing.SystemColors.WindowText;
            this.lb_ThoiGian.Location = new System.Drawing.Point(23, 141);
            this.lb_ThoiGian.Name = "lb_ThoiGian";
            this.lb_ThoiGian.Size = new System.Drawing.Size(93, 24);
            this.lb_ThoiGian.TabIndex = 38;
            this.lb_ThoiGian.Text = "Thời gian:";
            // 
            // label
            // 
            this.label.AutoSize = true;
            this.label.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label.ForeColor = System.Drawing.SystemColors.WindowText;
            this.label.Location = new System.Drawing.Point(168, 81);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(135, 24);
            this.label.TabIndex = 37;
            this.label.Text = "Mã nhân viên: ";
            // 
            // tbMaNhanVien
            // 
            this.tbMaNhanVien.AutoSize = true;
            this.tbMaNhanVien.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbMaNhanVien.ForeColor = System.Drawing.SystemColors.WindowText;
            this.tbMaNhanVien.Location = new System.Drawing.Point(329, 81);
            this.tbMaNhanVien.Name = "tbMaNhanVien";
            this.tbMaNhanVien.Size = new System.Drawing.Size(20, 24);
            this.tbMaNhanVien.TabIndex = 58;
            this.tbMaNhanVien.Text = "1";
            // 
            // gridTopping
            // 
            this.gridTopping.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gridTopping.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.gridTopping.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridTopping.Location = new System.Drawing.Point(12, 308);
            this.gridTopping.Name = "gridTopping";
            this.gridTopping.RowHeadersWidth = 51;
            this.gridTopping.RowTemplate.Height = 27;
            this.gridTopping.Size = new System.Drawing.Size(616, 285);
            this.gridTopping.TabIndex = 59;
            this.gridTopping.Visible = false;
            this.gridTopping.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gridTopping_CellContentClick);
            // 
            // lbTongTien
            // 
            this.lbTongTien.AutoSize = true;
            this.lbTongTien.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTongTien.ForeColor = System.Drawing.SystemColors.WindowText;
            this.lbTongTien.Location = new System.Drawing.Point(945, 465);
            this.lbTongTien.Name = "lbTongTien";
            this.lbTongTien.Size = new System.Drawing.Size(76, 29);
            this.lbTongTien.TabIndex = 60;
            this.lbTongTien.Text = "TỔNG";
            this.lbTongTien.Visible = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label2.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.WindowText;
            this.label2.Location = new System.Drawing.Point(940, 402);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(2, 31);
            this.label2.TabIndex = 62;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.WindowText;
            this.label5.Location = new System.Drawing.Point(732, 403);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(135, 29);
            this.label5.TabIndex = 61;
            this.label5.Text = "TIỀN NHẬN";
            // 
            // lbTienThoi
            // 
            this.lbTienThoi.AutoSize = true;
            this.lbTienThoi.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTienThoi.ForeColor = System.Drawing.SystemColors.WindowText;
            this.lbTienThoi.Location = new System.Drawing.Point(945, 525);
            this.lbTienThoi.Name = "lbTienThoi";
            this.lbTienThoi.Size = new System.Drawing.Size(183, 29);
            this.lbTienThoi.TabIndex = 66;
            this.lbTienThoi.Text = "TỔNG THỐI LẠI";
            this.lbTienThoi.Visible = false;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label7.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.WindowText;
            this.label7.Location = new System.Drawing.Point(936, 524);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(2, 31);
            this.label7.TabIndex = 65;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.SystemColors.WindowText;
            this.label8.Location = new System.Drawing.Point(728, 524);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(172, 29);
            this.label8.TabIndex = 64;
            this.label8.Text = "TIỀN THỐI LẠI";
            // 
            // tbTienNhan
            // 
            this.tbTienNhan.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbTienNhan.Location = new System.Drawing.Point(955, 402);
            this.tbTienNhan.Name = "tbTienNhan";
            this.tbTienNhan.Size = new System.Drawing.Size(199, 38);
            this.tbTienNhan.TabIndex = 67;
            // 
            // btn_ThemThucUong
            // 
            this.btn_ThemThucUong.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btn_ThemThucUong.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_ThemThucUong.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_ThemThucUong.ForeColor = System.Drawing.SystemColors.Control;
            this.btn_ThemThucUong.Location = new System.Drawing.Point(385, 258);
            this.btn_ThemThucUong.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_ThemThucUong.Name = "btn_ThemThucUong";
            this.btn_ThemThucUong.Size = new System.Drawing.Size(40, 37);
            this.btn_ThemThucUong.TabIndex = 68;
            this.btn_ThemThucUong.Text = "+";
            this.btn_ThemThucUong.UseVisualStyleBackColor = false;
            this.btn_ThemThucUong.Click += new System.EventHandler(this.btn_ThemThucUong_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.WindowText;
            this.label1.Location = new System.Drawing.Point(446, 186);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(112, 24);
            this.label1.TabIndex = 69;
            this.label1.Text = "Mức đường:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.WindowText;
            this.label6.Location = new System.Drawing.Point(446, 226);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(78, 24);
            this.label6.TabIndex = 70;
            this.label6.Text = "Mức đá:";
            // 
            // cbMucDuong
            // 
            this.cbMucDuong.FormattingEnabled = true;
            this.cbMucDuong.Items.AddRange(new object[] {
            "70",
            "30"});
            this.cbMucDuong.Location = new System.Drawing.Point(581, 188);
            this.cbMucDuong.Name = "cbMucDuong";
            this.cbMucDuong.Size = new System.Drawing.Size(89, 24);
            this.cbMucDuong.TabIndex = 71;
            // 
            // cbMucDa
            // 
            this.cbMucDa.FormattingEnabled = true;
            this.cbMucDa.Items.AddRange(new object[] {
            "70",
            "30"});
            this.cbMucDa.Location = new System.Drawing.Point(581, 228);
            this.cbMucDa.Name = "cbMucDa";
            this.cbMucDa.Size = new System.Drawing.Size(89, 24);
            this.cbMucDa.TabIndex = 72;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(677, 191);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(20, 17);
            this.label9.TabIndex = 73;
            this.label9.Text = "%";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(679, 228);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(20, 17);
            this.label10.TabIndex = 74;
            this.label10.Text = "%";
            // 
            // gridAnHD
            // 
            this.gridAnHD.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gridAnHD.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.gridAnHD.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridAnHD.Location = new System.Drawing.Point(709, 209);
            this.gridAnHD.Name = "gridAnHD";
            this.gridAnHD.RowHeadersWidth = 51;
            this.gridAnHD.RowTemplate.Height = 27;
            this.gridAnHD.Size = new System.Drawing.Size(167, 107);
            this.gridAnHD.TabIndex = 75;
            // 
            // gridAnCTHD
            // 
            this.gridAnCTHD.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gridAnCTHD.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.gridAnCTHD.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridAnCTHD.Location = new System.Drawing.Point(1206, 168);
            this.gridAnCTHD.Name = "gridAnCTHD";
            this.gridAnCTHD.RowHeadersWidth = 51;
            this.gridAnCTHD.RowTemplate.Height = 27;
            this.gridAnCTHD.Size = new System.Drawing.Size(185, 107);
            this.gridAnCTHD.TabIndex = 76;
            // 
            // lbMaCTHD
            // 
            this.lbMaCTHD.AutoSize = true;
            this.lbMaCTHD.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbMaCTHD.ForeColor = System.Drawing.SystemColors.WindowText;
            this.lbMaCTHD.Location = new System.Drawing.Point(381, 81);
            this.lbMaCTHD.Name = "lbMaCTHD";
            this.lbMaCTHD.Size = new System.Drawing.Size(179, 24);
            this.lbMaCTHD.TabIndex = 77;
            this.lbMaCTHD.Text = "Mã chi Tiết hóa đơn";
            this.lbMaCTHD.Visible = false;
            // 
            // gridLoadThucUong
            // 
            this.gridLoadThucUong.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gridLoadThucUong.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.gridLoadThucUong.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridLoadThucUong.Location = new System.Drawing.Point(709, 81);
            this.gridLoadThucUong.Name = "gridLoadThucUong";
            this.gridLoadThucUong.RowHeadersWidth = 51;
            this.gridLoadThucUong.RowTemplate.Height = 27;
            this.gridLoadThucUong.Size = new System.Drawing.Size(752, 152);
            this.gridLoadThucUong.TabIndex = 78;
            this.gridLoadThucUong.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gridLoadThucUong_CellContentClick);
            // 
            // gridLoadTopping
            // 
            this.gridLoadTopping.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gridLoadTopping.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.gridLoadTopping.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridLoadTopping.Location = new System.Drawing.Point(709, 228);
            this.gridLoadTopping.Name = "gridLoadTopping";
            this.gridLoadTopping.RowHeadersWidth = 51;
            this.gridLoadTopping.RowTemplate.Height = 27;
            this.gridLoadTopping.Size = new System.Drawing.Size(752, 155);
            this.gridLoadTopping.TabIndex = 79;
            this.gridLoadTopping.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gridLoadTopping_CellContentClick);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(734, 448);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(162, 65);
            this.button1.TabIndex = 80;
            this.button1.Text = "Tổng tiền";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(13, 13);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(127, 50);
            this.button2.TabIndex = 81;
            this.button2.Text = "btn_back";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Order
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1510, 614);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.gridLoadTopping);
            this.Controls.Add(this.gridLoadThucUong);
            this.Controls.Add(this.lbMaCTHD);
            this.Controls.Add(this.gridAnCTHD);
            this.Controls.Add(this.gridAnHD);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.cbMucDa);
            this.Controls.Add(this.cbMucDuong);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_ThemThucUong);
            this.Controls.Add(this.tbTienNhan);
            this.Controls.Add(this.lbTienThoi);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lbTongTien);
            this.Controls.Add(this.gridTopping);
            this.Controls.Add(this.tbMaNhanVien);
            this.Controls.Add(this.cbKM);
            this.Controls.Add(this.tbTenKH);
            this.Controls.Add(this.btTopping);
            this.Controls.Add(this.btThucUong);
            this.Controls.Add(this.gridThucAn);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lbMaHD);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lb_TenKH);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.btn_InHoaDon);
            this.Controls.Add(this.lb_TongTien);
            this.Controls.Add(this.lb_ThoiGian);
            this.Controls.Add(this.label);
            this.Name = "Order";
            this.Text = "Order";
            this.Load += new System.EventHandler(this.Order_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridThucAn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridTopping)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridAnHD)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridAnCTHD)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridLoadThucUong)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridLoadTopping)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbKM;
        private System.Windows.Forms.TextBox tbTenKH;
        private System.Windows.Forms.Button btTopping;
        private System.Windows.Forms.Button btThucUong;
        private System.Windows.Forms.DataGridView gridThucAn;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lbMaHD;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lb_TenKH;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Button btn_InHoaDon;
        private System.Windows.Forms.Label lb_TongTien;
        private System.Windows.Forms.Label lb_ThoiGian;
        private System.Windows.Forms.Label label;
        private System.Windows.Forms.Label tbMaNhanVien;
        private System.Windows.Forms.DataGridView gridTopping;
        private System.Windows.Forms.Label lbTongTien;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lbTienThoi;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox tbTienNhan;
        private System.Windows.Forms.Button btn_ThemThucUong;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cbMucDuong;
        private System.Windows.Forms.ComboBox cbMucDa;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.DataGridView gridAnHD;
        private System.Windows.Forms.DataGridView gridAnCTHD;
        private System.Windows.Forms.Label lbMaCTHD;
        private System.Windows.Forms.DataGridView gridLoadThucUong;
        private System.Windows.Forms.DataGridView gridLoadTopping;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}