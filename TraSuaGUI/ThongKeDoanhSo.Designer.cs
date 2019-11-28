namespace BoubleMilkTea
{
    partial class ThongKeDoanhSo
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
            this.label1 = new System.Windows.Forms.Label();
            this.tb_Day = new System.Windows.Forms.TextBox();
            this.btn_Them = new System.Windows.Forms.Button();
            this.checkBox_Ngay = new System.Windows.Forms.CheckBox();
            this.checkBox_Thang = new System.Windows.Forms.CheckBox();
            this.checkBox_Nam = new System.Windows.Forms.CheckBox();
            this.tb_Year = new System.Windows.Forms.TextBox();
            this.tb_Month = new System.Windows.Forms.TextBox();
            this.dgv_ThongKe = new System.Windows.Forms.DataGridView();
            this.lb_TongTien = new System.Windows.Forms.Label();
            this.lb2 = new System.Windows.Forms.Label();
            this.MaHoaDon = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ThoiGian = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TongTien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_ThongKe)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(45, 58);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 19);
            this.label1.TabIndex = 33;
            this.label1.Text = "Lọc theo:";
            // 
            // tb_Day
            // 
            this.tb_Day.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Day.Location = new System.Drawing.Point(369, 105);
            this.tb_Day.Name = "tb_Day";
            this.tb_Day.Size = new System.Drawing.Size(64, 27);
            this.tb_Day.TabIndex = 34;
            this.tb_Day.Text = "13";
            // 
            // btn_Them
            // 
            this.btn_Them.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btn_Them.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Them.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Them.ForeColor = System.Drawing.SystemColors.Control;
            this.btn_Them.Location = new System.Drawing.Point(486, 104);
            this.btn_Them.Name = "btn_Them";
            this.btn_Them.Size = new System.Drawing.Size(66, 27);
            this.btn_Them.TabIndex = 39;
            this.btn_Them.Text = "Xuất";
            this.btn_Them.UseVisualStyleBackColor = false;
            // 
            // checkBox_Ngay
            // 
            this.checkBox_Ngay.AutoSize = true;
            this.checkBox_Ngay.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox_Ngay.Location = new System.Drawing.Point(369, 61);
            this.checkBox_Ngay.Name = "checkBox_Ngay";
            this.checkBox_Ngay.Size = new System.Drawing.Size(61, 23);
            this.checkBox_Ngay.TabIndex = 40;
            this.checkBox_Ngay.Text = "Ngày";
            this.checkBox_Ngay.UseVisualStyleBackColor = true;
            // 
            // checkBox_Thang
            // 
            this.checkBox_Thang.AutoSize = true;
            this.checkBox_Thang.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox_Thang.Location = new System.Drawing.Point(260, 61);
            this.checkBox_Thang.Name = "checkBox_Thang";
            this.checkBox_Thang.Size = new System.Drawing.Size(68, 23);
            this.checkBox_Thang.TabIndex = 41;
            this.checkBox_Thang.Text = "Tháng";
            this.checkBox_Thang.UseVisualStyleBackColor = true;
            // 
            // checkBox_Nam
            // 
            this.checkBox_Nam.AutoSize = true;
            this.checkBox_Nam.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox_Nam.Location = new System.Drawing.Point(149, 61);
            this.checkBox_Nam.Name = "checkBox_Nam";
            this.checkBox_Nam.Size = new System.Drawing.Size(58, 23);
            this.checkBox_Nam.TabIndex = 42;
            this.checkBox_Nam.Text = "Năm";
            this.checkBox_Nam.UseVisualStyleBackColor = true;
            // 
            // tb_Year
            // 
            this.tb_Year.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Year.Location = new System.Drawing.Point(149, 104);
            this.tb_Year.Name = "tb_Year";
            this.tb_Year.Size = new System.Drawing.Size(64, 27);
            this.tb_Year.TabIndex = 43;
            this.tb_Year.Text = "2019";
            // 
            // tb_Month
            // 
            this.tb_Month.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Month.Location = new System.Drawing.Point(260, 104);
            this.tb_Month.Name = "tb_Month";
            this.tb_Month.Size = new System.Drawing.Size(64, 27);
            this.tb_Month.TabIndex = 44;
            this.tb_Month.Text = "11";
            // 
            // dgv_ThongKe
            // 
            this.dgv_ThongKe.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_ThongKe.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaHoaDon,
            this.ThoiGian,
            this.TongTien});
            this.dgv_ThongKe.Location = new System.Drawing.Point(49, 168);
            this.dgv_ThongKe.Name = "dgv_ThongKe";
            this.dgv_ThongKe.Size = new System.Drawing.Size(338, 150);
            this.dgv_ThongKe.TabIndex = 45;
            // 
            // lb_TongTien
            // 
            this.lb_TongTien.AutoSize = true;
            this.lb_TongTien.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lb_TongTien.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_TongTien.ForeColor = System.Drawing.SystemColors.WindowText;
            this.lb_TongTien.Location = new System.Drawing.Point(469, 219);
            this.lb_TongTien.Name = "lb_TongTien";
            this.lb_TongTien.Size = new System.Drawing.Size(104, 25);
            this.lb_TongTien.TabIndex = 47;
            this.lb_TongTien.Text = "13.000.000";
            // 
            // lb2
            // 
            this.lb2.AutoSize = true;
            this.lb2.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb2.ForeColor = System.Drawing.SystemColors.WindowText;
            this.lb2.Location = new System.Drawing.Point(403, 221);
            this.lb2.Name = "lb2";
            this.lb2.Size = new System.Drawing.Size(60, 23);
            this.lb2.TabIndex = 46;
            this.lb2.Text = "TỔNG";
            // 
            // MaHoaDon
            // 
            this.MaHoaDon.HeaderText = "Mã hoá đơn";
            this.MaHoaDon.Name = "MaHoaDon";
            // 
            // ThoiGian
            // 
            this.ThoiGian.HeaderText = "Thời gian";
            this.ThoiGian.Name = "ThoiGian";
            // 
            // TongTien
            // 
            this.TongTien.HeaderText = "Tổng tiền";
            this.TongTien.Name = "TongTien";
            // 
            // ThongKeDoanhSo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(249)))), ((int)(((byte)(251)))));
            this.ClientSize = new System.Drawing.Size(613, 376);
            this.Controls.Add(this.lb_TongTien);
            this.Controls.Add(this.lb2);
            this.Controls.Add(this.dgv_ThongKe);
            this.Controls.Add(this.tb_Month);
            this.Controls.Add(this.tb_Year);
            this.Controls.Add(this.checkBox_Nam);
            this.Controls.Add(this.checkBox_Thang);
            this.Controls.Add(this.checkBox_Ngay);
            this.Controls.Add(this.btn_Them);
            this.Controls.Add(this.tb_Day);
            this.Controls.Add(this.label1);
            this.Name = "ThongKeDoanhSo";
            this.Text = "Thống kê doanh số";
            ((System.ComponentModel.ISupportInitialize)(this.dgv_ThongKe)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tb_Day;
        private System.Windows.Forms.Button btn_Them;
        private System.Windows.Forms.CheckBox checkBox_Ngay;
        private System.Windows.Forms.CheckBox checkBox_Thang;
        private System.Windows.Forms.CheckBox checkBox_Nam;
        private System.Windows.Forms.TextBox tb_Year;
        private System.Windows.Forms.TextBox tb_Month;
        private System.Windows.Forms.DataGridView dgv_ThongKe;
        private System.Windows.Forms.Label lb_TongTien;
        private System.Windows.Forms.Label lb2;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaHoaDon;
        private System.Windows.Forms.DataGridViewTextBoxColumn ThoiGian;
        private System.Windows.Forms.DataGridViewTextBoxColumn TongTien;
    }
}