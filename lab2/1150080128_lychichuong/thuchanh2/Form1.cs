using System;
using System.ComponentModel;
using System.Windows.Forms;

namespace thuchanh2
{
    public partial class Form1 : Form
    {
        // Đơn giá
        private const int GIA_LAY_CAO = 50000;     // 2 hàm
        private const int GIA_TAY_TRANG = 100000;    // 2 hàm
        private const int GIA_HAN = 100000;    // /1 răng
        private const int GIA_BE = 10000;     // /1 răng
        private const int GIA_BOC = 1000000;   // /1 răng

        public Form1()
        {
            InitializeComponent();

            // Validate tên khách
            this.txtTenK.Validating += txtTenK_Validating;

            // Bật/tắt số lượng theo checkbox
            this.chkHan.CheckedChanged += delegate { nupHan.Enabled = chkHan.Checked; };
            this.chkBe.CheckedChanged += delegate { nupBe.Enabled = chkBe.Checked; };
            this.chkBoc.CheckedChanged += delegate { nupBoc.Enabled = chkBoc.Checked; };

            // Nút chức năng
            this.btnTinhTien.Click += btnTinhTien_Click;
            this.btnThoat.Click += delegate { Close(); };
        }

        private void txtTenK_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtTenK.Text))
            {
                e.Cancel = true;
                errTen.SetError(txtTenK, "Dữ liệu không được để trống!");
            }
            else
            {
                e.Cancel = false;
                errTen.SetError(txtTenK, null);
            }
        }

        private void btnTinhTien_Click(object sender, EventArgs e)
        {
            if (!ValidateChildren(ValidationConstraints.Enabled)) return;

            long thanhTien = 0;

            if (chkLayCao.Checked) thanhTien += GIA_LAY_CAO;
            if (chkTayTrang.Checked) thanhTien += GIA_TAY_TRANG;
            if (chkHan.Checked) thanhTien += (long)nupHan.Value * GIA_HAN;
            if (chkBe.Checked) thanhTien += (long)nupBe.Value * GIA_BE;
            if (chkBoc.Checked) thanhTien += (long)nupBoc.Value * GIA_BOC;

            txtThanhTien.Text = thanhTien.ToString("N0") + " đ";
        }
    }
}
