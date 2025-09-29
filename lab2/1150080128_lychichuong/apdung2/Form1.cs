using System;
using System.Collections.Generic;
using System.Media;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Window;

namespace apdung2
{
    public partial class Form1 : Form
    {
        // Map mật khẩu -> tên nhóm (bạn đổi theo đề yêu cầu)
        private readonly Dictionary<string, string> _groupByPass = new Dictionary<string, string>
{
        { "8884", "Thiết kế mô hình!" },
        { "1496", "Phát triển công nghệ" },
        { "7462", "Nghiên cứu viên" }
};


        public Form1()
        {
            InitializeComponent();

            // gán 1 handler cho tất cả phím số
            btn1.Click += (s, e) => AppendDigit("1");
            btn2.Click += (s, e) => AppendDigit("2");
            btn3.Click += (s, e) => AppendDigit("3");
            btn4.Click += (s, e) => AppendDigit("4");
            btn5.Click += (s, e) => AppendDigit("5");
            btn6.Click += (s, e) => AppendDigit("6");
            btn7.Click += (s, e) => AppendDigit("7");
            btn8.Click += (s, e) => AppendDigit("8");
            btn9.Click += (s, e) => AppendDigit("9");

            btnClear.Click += (s, e) => txtPassword.Clear();
            btnEnter.Click += btnEnter_Click;
            btnRing.Click += (s, e) => SystemSounds.Exclamation.Play();

            // cho phép gõ bàn phím vật lý
            this.KeyPreview = true;
            this.KeyPress += Form1_KeyPress;
        }

        private void AppendDigit(string d)
        {
            txtPassword.Text += d;
            txtPassword.SelectionStart = txtPassword.TextLength;
            txtPassword.Focus();
        }

        private void btnEnter_Click(object sender, EventArgs e)
        {
            var pwd = txtPassword.Text.Trim();
            string group, result;

            if (string.IsNullOrEmpty(pwd))
            {
                group = "Không có";
                result = "Từ chối!";
            }
            else if (_groupByPass.TryGetValue(pwd, out var g))
            {
                group = g;
                result = "Chấp nhận!";
            }
            else
            {
                group = "Không có";
                result = "Từ chối!";
            }

            dgvLog.Rows.Insert(0, DateTime.Now.ToString("G"), group, result);
            txtPassword.Clear();
            txtPassword.Focus();
        }

        // Hỗ trợ gõ số từ bàn phím
        private void Form1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar) && e.KeyChar != '0')
            {
                AppendDigit(e.KeyChar.ToString());
                e.Handled = true;
            }
            else if (e.KeyChar == (char)Keys.Enter)
            {
                btnEnter.PerformClick();
                e.Handled = true;
            }
        }
    }
}
