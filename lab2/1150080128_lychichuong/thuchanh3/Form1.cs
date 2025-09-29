using System;
using System.Windows.Forms;

namespace thuchanh3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            // Gán sự kiện
            btnNhapSo.Click += btnNhapSo_Click;
            btnTang2.Click += btnTang2_Click;
            btnChonChanDau.Click += btnChonChanDau_Click;
            btnChonLeCuoi.Click += btnChonLeCuoi_Click;
            btnXoaChon.Click += btnXoaChon_Click;
            btnXoaDau.Click += btnXoaDau_Click;
            btnXoaCuoi.Click += btnXoaCuoi_Click;
            btnXoaDaySo.Click += delegate { lsbDaySo.Items.Clear(); };
            btnKetThuc.Click += delegate { Close(); };

            // Enter trong textbox = Nhập số
            txtSo.KeyDown += (s, e) => { if (e.KeyCode == Keys.Enter) { btnNhapSo.PerformClick(); e.SuppressKeyPress = true; } };
        }

        private void btnNhapSo_Click(object sender, EventArgs e)
        {
            int v;
            if (!int.TryParse(txtSo.Text.Trim(), out v))
            {
                MessageBox.Show("Vui lòng nhập số nguyên!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtSo.Focus();
                txtSo.SelectAll();
                return;
            }
            lsbDaySo.Items.Add(v);
            txtSo.Clear();
            txtSo.Focus();
        }

        private bool DanhSachRong()
        {
            if (lsbDaySo.Items.Count == 0)
            {
                MessageBox.Show("Dãy số đang trống. Vui lòng nhập dữ liệu!", "Thông báo",
                                MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtSo.Focus();
                return true;
            }
            return false;
        }

        private void btnTang2_Click(object sender, EventArgs e)
        {
            if (DanhSachRong()) return;
            for (int i = 0; i < lsbDaySo.Items.Count; i++)
            {
                int val = (int)lsbDaySo.Items[i];
                lsbDaySo.Items[i] = val + 2;
            }
        }

        private void btnChonChanDau_Click(object sender, EventArgs e)
        {
            if (DanhSachRong()) return;
            for (int i = 0; i < lsbDaySo.Items.Count; i++)
            {
                if (((int)lsbDaySo.Items[i]) % 2 == 0)
                {
                    lsbDaySo.SelectedIndex = i;
                    return;
                }
            }
            MessageBox.Show("Không có số chẵn nào trong dãy.", "Thông báo",
                            MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnChonLeCuoi_Click(object sender, EventArgs e)
        {
            if (DanhSachRong()) return;
            for (int i = lsbDaySo.Items.Count - 1; i >= 0; i--)
            {
                if (((int)lsbDaySo.Items[i]) % 2 != 0)
                {
                    lsbDaySo.SelectedIndex = i;
                    return;
                }
            }
            MessageBox.Show("Không có số lẻ nào trong dãy.", "Thông báo",
                            MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnXoaChon_Click(object sender, EventArgs e)
        {
            if (DanhSachRong()) return;
            if (lsbDaySo.SelectedIndex == -1)
            {
                MessageBox.Show("Hãy chọn phần tử cần xóa!", "Thông báo",
                                MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            while (lsbDaySo.SelectedIndex != -1)
                lsbDaySo.Items.RemoveAt(lsbDaySo.SelectedIndex);
        }

        private void btnXoaDau_Click(object sender, EventArgs e)
        {
            if (DanhSachRong()) return;
            while (lsbDaySo.Items.Count > 0)
                lsbDaySo.Items.RemoveAt(0);
        }

        private void btnXoaCuoi_Click(object sender, EventArgs e)
        {
            if (DanhSachRong()) return;
            while (lsbDaySo.Items.Count > 0)
                lsbDaySo.Items.RemoveAt(lsbDaySo.Items.Count - 1);
        }
    }
}
