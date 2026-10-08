namespace bt_8_10_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            cboLoaiSuCo.Items.Add("Phần cứng");
            cboLoaiSuCo.Items.Add("Phần mềm");
            cboLoaiSuCo.Items.Add("Mạng");
            cboLoaiSuCo.Items.Add("Tài khoản");

            cboLoaiSuCo.SelectedIndex = 0;
        }

        private void btnTaiAnh_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog ofd = new OpenFileDialog())
            {
                ofd.Title = "Chọn ảnh chụp sự cố";
                ofd.Filter = "File ảnh (*.jpg; *.png)|*.jpg;*.png";

                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    picAnhLoi.Image = Image.FromFile(ofd.FileName);
                }
            }
        }
        private void btnGuiYeuCau_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtMaPhieu.Text) || string.IsNullOrWhiteSpace(txtNguoiYeuCau.Text))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ Mã phiếu và Người yêu cầu!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            string mucDo = "Thấp";
            if (rdoTrungBinh.Checked) mucDo = "Trung bình";
            else if (rdoKhanCap.Checked) mucDo = "Khẩn cấp";
            List<string> dsThietBi = new List<string>();
            if (chkMayTinhBan.Checked) dsThietBi.Add(chkMayTinhBan.Text);
            if (chkLaptop.Checked) dsThietBi.Add(chkLaptop.Text);
            if (chkMayIn.Checked) dsThietBi.Add(chkMayIn.Text);
            if (chkDienThoai.Checked) dsThietBi.Add(chkDienThoai.Text);

            string thietBiText = dsThietBi.Count > 0 ? string.Join(", ", dsThietBi) : "Không chọn";

            string trangThaiAnh = (picAnhLoi.Image != null) ? "Đã tải lên" : "Chưa có";

            string thongTin = $"--- TÓM TẮT PHIẾU YÊU CẦU ---\n\n" +
                      $"Mã phiếu: {txtMaPhieu.Text}\n" +
                      $"Người yêu cầu: {txtNguoiYeuCau.Text}\n" +
                      $"Ngày ghi nhận: {dtpNgayGhiNhan.Value.ToString("dd/MM/yyyy")}\n" +
                      $"Mức độ ưu tiên: {mucDo}\n" +
                      $"Loại sự cố: {cboLoaiSuCo.SelectedItem}\n" +
                      $"Thiết bị ảnh hưởng: {thietBiText}\n" +
                      $"Ảnh chụp lỗi: {trangThaiAnh}";

            MessageBox.Show(thongTin, "Xác nhận gửi phiếu thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnNhapLai_Click(object sender, EventArgs e)
        {
            txtMaPhieu.Clear();
            txtNguoiYeuCau.Clear();
            dtpNgayGhiNhan.Value = DateTime.Now;

            rdoThap.Checked = true;

            if (cboLoaiSuCo.Items.Count > 0)
                cboLoaiSuCo.SelectedIndex = 0;

            chkMayTinhBan.Checked = false;
            chkLaptop.Checked = false;
            chkMayIn.Checked = false;
            chkDienThoai.Checked = false;

            if (picAnhLoi.Image != null)
            {
                picAnhLoi.Image.Dispose();
                picAnhLoi.Image = null;
            }

            txtMaPhieu.Focus();
        }
    }
}
