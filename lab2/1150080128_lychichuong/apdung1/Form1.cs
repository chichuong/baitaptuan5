using System;
using System.Windows.Forms;

namespace apdung1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            btnTim.Click += btnTim_Click;
            btnThoat.Click += (s, e) => Close();
        }

        private void btnTim_Click(object sender, EventArgs e)
        {
            try
            {
                int a = int.Parse(txtA.Text.Trim());
                int b = int.Parse(txtB.Text.Trim());

                if (rdoUSCLN.Checked)
                {
                    int u = Gcd(Math.Abs(a), Math.Abs(b));
                    txtKetQua.Text = u.ToString();
                }
                else if (rdoBSCNN.Checked)
                {
                    int u = Gcd(Math.Abs(a), Math.Abs(b));
                    long bcnn = (u == 0) ? 0 : (long)Math.Abs((long)a * b) / u;
                    txtKetQua.Text = bcnn.ToString();
                }
                else
                {
                    MessageBox.Show("Hãy chọn USCLN hoặc BSCNN.", "Thông báo",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Dữ liệu không hợp lệ! " + ex.Message, "Lỗi",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private int Gcd(int x, int y)
        {
            while (y != 0) { int r = x % y; x = y; y = r; }
            return x;
        }
    }
}
