namespace bt_8_10_2
{
    partial class Form1
    {
        
        private System.ComponentModel.IContainer components = null;

        
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        
        private void InitializeComponent()
        {
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            txtMaPhieu = new TextBox();
            txtNguoiYeuCau = new TextBox();
            dtpNgayGhiNhan = new DateTimePicker();
            gbMucDo = new GroupBox();
            rdoThap = new RadioButton();
            rdoTrungBinh = new RadioButton();
            rdoKhanCap = new RadioButton();
            cboLoaiSuCo = new ComboBox();
            label4 = new Label();
            gbThietBi = new GroupBox();
            chkMayTinhBan = new CheckBox();
            chkLaptop = new CheckBox();
            chkMayIn = new CheckBox();
            chkDienThoai = new CheckBox();
            picAnhLoi = new PictureBox();
            btnTaiAnh = new Button();
            btnGuiYeuCau = new Button();
            btnNhapLai = new Button();
            gbMucDo.SuspendLayout();
            gbThietBi.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picAnhLoi).BeginInit();
            SuspendLayout();
            
            label1.AutoSize = true;
            label1.Location = new Point(52, 61);
            label1.Name = "label1";
            label1.Size = new Size(71, 20);
            label1.TabIndex = 0;
            label1.Text = "Mã phiếu";
            
            label2.AutoSize = true;
            label2.Location = new Point(52, 113);
            label2.Name = "label2";
            label2.Size = new Size(105, 20);
            label2.TabIndex = 1;
            label2.Text = "Người yêu cầu";
            
            label3.AutoSize = true;
            label3.Location = new Point(52, 173);
            label3.Name = "label3";
            label3.Size = new Size(105, 20);
            label3.TabIndex = 2;
            label3.Text = "Ngày ghi nhận";
            
            txtMaPhieu.Location = new Point(189, 58);
            txtMaPhieu.Name = "txtMaPhieu";
            txtMaPhieu.Size = new Size(150, 27);
            txtMaPhieu.TabIndex = 4;
            
            txtNguoiYeuCau.Location = new Point(189, 110);
            txtNguoiYeuCau.Name = "txtNguoiYeuCau";
            txtNguoiYeuCau.Size = new Size(150, 27);
            txtNguoiYeuCau.TabIndex = 5;
            
            dtpNgayGhiNhan.Format = DateTimePickerFormat.Short;
            dtpNgayGhiNhan.Location = new Point(189, 168);
            dtpNgayGhiNhan.Name = "dtpNgayGhiNhan";
            dtpNgayGhiNhan.Size = new Size(150, 27);
            dtpNgayGhiNhan.TabIndex = 6;
            
            gbMucDo.Controls.Add(rdoThap);
            gbMucDo.Controls.Add(rdoTrungBinh);
            gbMucDo.Controls.Add(rdoKhanCap);
            gbMucDo.Location = new Point(52, 225);
            gbMucDo.Name = "gbMucDo";
            gbMucDo.Size = new Size(287, 125);
            gbMucDo.TabIndex = 7;
            gbMucDo.TabStop = false;
            gbMucDo.Text = "Mức độ ưu tiên";
            
            rdoThap.AutoSize = true;
            rdoThap.Checked = true;
            rdoThap.Location = new Point(20, 30);
            rdoThap.Name = "rdoThap";
            rdoThap.Size = new Size(63, 24);
            rdoThap.TabIndex = 0;
            rdoThap.TabStop = true;
            rdoThap.Text = "Thấp";
            rdoThap.UseVisualStyleBackColor = true;
             
            rdoTrungBinh.AutoSize = true;
            rdoTrungBinh.Location = new Point(20, 60);
            rdoTrungBinh.Name = "rdoTrungBinh";
            rdoTrungBinh.Size = new Size(100, 24);
            rdoTrungBinh.TabIndex = 1;
            rdoTrungBinh.Text = "Trung bình";
            rdoTrungBinh.UseVisualStyleBackColor = true;
            
            rdoKhanCap.AutoSize = true;
            rdoKhanCap.Location = new Point(20, 90);
            rdoKhanCap.Name = "rdoKhanCap";
            rdoKhanCap.Size = new Size(91, 24);
            rdoKhanCap.TabIndex = 2;
            rdoKhanCap.Text = "Khẩn cấp";
            rdoKhanCap.UseVisualStyleBackColor = true;
            
            cboLoaiSuCo.DropDownStyle = ComboBoxStyle.DropDownList;
            cboLoaiSuCo.FormattingEnabled = true;
            cboLoaiSuCo.Location = new Point(498, 53);
            cboLoaiSuCo.Name = "cboLoaiSuCo";
            cboLoaiSuCo.Size = new Size(185, 28);
            cboLoaiSuCo.TabIndex = 8;
             
            label4.AutoSize = true;
            label4.Location = new Point(403, 61);
            label4.Name = "label4";
            label4.Size = new Size(76, 20);
            label4.TabIndex = 9;
            label4.Text = "Loại sự cố";
             
            gbThietBi.Controls.Add(chkDienThoai);
            gbThietBi.Controls.Add(chkMayIn);
            gbThietBi.Controls.Add(chkLaptop);
            gbThietBi.Controls.Add(chkMayTinhBan);
            gbThietBi.Location = new Point(403, 110);
            gbThietBi.Name = "gbThietBi";
            gbThietBi.Size = new Size(250, 150);
            gbThietBi.TabIndex = 10;
            gbThietBi.TabStop = false;
            gbThietBi.Text = "Thiết bị ảnh hưởng";
            
            chkMayTinhBan.AutoSize = true;
            chkMayTinhBan.Location = new Point(15, 28);
            chkMayTinhBan.Name = "chkMayTinhBan";
            chkMayTinhBan.Size = new Size(117, 24);
            chkMayTinhBan.TabIndex = 0;
            chkMayTinhBan.Text = "Máy tính bàn";
            chkMayTinhBan.UseVisualStyleBackColor = true;
            
            chkLaptop.AutoSize = true;
            chkLaptop.Location = new Point(15, 58);
            chkLaptop.Name = "chkLaptop";
            chkLaptop.Size = new Size(78, 24);
            chkLaptop.TabIndex = 1;
            chkLaptop.Text = "Laptop";
            chkLaptop.UseVisualStyleBackColor = true;
            
            chkMayIn.AutoSize = true;
            chkMayIn.Location = new Point(15, 88);
            chkMayIn.Name = "chkMayIn";
            chkMayIn.Size = new Size(75, 24);
            chkMayIn.TabIndex = 2;
            chkMayIn.Text = "Máy in";
            chkMayIn.UseVisualStyleBackColor = true;
             
            chkDienThoai.AutoSize = true;
            chkDienThoai.Location = new Point(15, 118);
            chkDienThoai.Name = "chkDienThoai";
            chkDienThoai.Size = new Size(100, 24);
            chkDienThoai.TabIndex = 3;
            chkDienThoai.Text = "Điện thoại";
            chkDienThoai.UseVisualStyleBackColor = true;
            
            picAnhLoi.BorderStyle = BorderStyle.FixedSingle;
            picAnhLoi.Location = new Point(700, 110);
            picAnhLoi.Name = "picAnhLoi";
            picAnhLoi.Size = new Size(200, 150);
            picAnhLoi.SizeMode = PictureBoxSizeMode.StretchImage;
            picAnhLoi.TabIndex = 11;
            picAnhLoi.TabStop = false;
            
            btnTaiAnh.Location = new Point(740, 275);
            btnTaiAnh.Name = "btnTaiAnh";
            btnTaiAnh.Size = new Size(120, 35);
            btnTaiAnh.TabIndex = 12;
            btnTaiAnh.Text = "Tải ảnh lỗi";
            btnTaiAnh.UseVisualStyleBackColor = true;
            btnTaiAnh.Click += btnTaiAnh_Click;
            
            btnGuiYeuCau.Location = new Point(320, 375);
            btnGuiYeuCau.Name = "btnGuiYeuCau";
            btnGuiYeuCau.Size = new Size(130, 40);
            btnGuiYeuCau.TabIndex = 13;
            btnGuiYeuCau.Text = "Gửi yêu cầu";
            btnGuiYeuCau.UseVisualStyleBackColor = true;
            btnGuiYeuCau.Click += btnGuiYeuCau_Click;
            
            btnNhapLai.Location = new Point(500, 375);
            btnNhapLai.Name = "btnNhapLai";
            btnNhapLai.Size = new Size(130, 40);
            btnNhapLai.TabIndex = 14;
            btnNhapLai.Text = "Nhập lại";
            btnNhapLai.UseVisualStyleBackColor = true;
            btnNhapLai.Click += btnNhapLai_Click;
             
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(950, 450);
            Controls.Add(btnNhapLai);
            Controls.Add(btnGuiYeuCau);
            Controls.Add(btnTaiAnh);
            Controls.Add(picAnhLoi);
            Controls.Add(gbThietBi);
            Controls.Add(label4);
            Controls.Add(cboLoaiSuCo);
            Controls.Add(gbMucDo);
            Controls.Add(dtpNgayGhiNhan);
            Controls.Add(txtNguoiYeuCau);
            Controls.Add(txtMaPhieu);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Tiếp nhận & Phân loại sự cố IT";
            Load += Form1_Load;
            gbMucDo.ResumeLayout(false);
            gbMucDo.PerformLayout();
            gbThietBi.ResumeLayout(false);
            gbThietBi.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)picAnhLoi).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox txtMaPhieu;
        private TextBox txtNguoiYeuCau;
        private DateTimePicker dtpNgayGhiNhan;
        private GroupBox gbMucDo;
        private RadioButton rdoKhanCap;
        private RadioButton rdoTrungBinh;
        private RadioButton rdoThap;
        private ComboBox cboLoaiSuCo;
        private Label label4;
        private GroupBox gbThietBi;
        private CheckBox chkDienThoai;
        private CheckBox chkMayIn;
        private CheckBox chkLaptop;
        private CheckBox chkMayTinhBan;
        private PictureBox picAnhLoi;
        private Button btnTaiAnh;
        private Button btnGuiYeuCau;
        private Button btnNhapLai;
    }
}