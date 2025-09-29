using System;
using System.ComponentModel;
using System.Windows.Forms;

namespace apdung3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            // Bắt sự kiện
            this.btnLogin.Click += btnLogin_Click;
            this.btnThoat.Click += delegate { Close(); };

            this.chkShow.CheckedChanged += delegate
            {
                txtPassword.UseSystemPasswordChar = !chkShow.Checked;
            };

            // Validate không để trống
            this.txtUsername.Validating += Required_Validating;
            this.txtPassword.Validating += Required_Validating;
        }

        private void Required_Validating(object sender, CancelEventArgs e)
        {
            TextBox tb = (TextBox)sender;
            if (string.IsNullOrWhiteSpace(tb.Text))
            {
                e.Cancel = true;
                err.SetError(tb, "Không được để trống!");
            }
            else
            {
                e.Cancel = false;
                err.SetError(tb, null);
            }
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (!ValidateChildren(ValidationConstraints.Enabled)) return;

            // Demo: tài khoản mẫu (bạn thay theo đề)
            string user = txtUsername.Text.Trim();
            string pass = txtPassword.Text;

            if (user == "admin" && pass == "123")
            {
                MessageBox.Show("Đăng nhập thành công!", "Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                // TODO: mở form chính nếu cần
            }
            else
            {
                MessageBox.Show("Sai tài khoản hoặc mật khẩu!", "Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtPassword.SelectAll();
                txtPassword.Focus();
            }
        }
    }
}
