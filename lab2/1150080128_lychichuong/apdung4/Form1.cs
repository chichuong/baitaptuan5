using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace apdung4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            // Nạp mẫu danh sách bên trái
            string[] items = new string[]
            {
                "CPU", "MainBoard", "RAM", "Keyboard", "Mouse", "NIC", "FAN"
            };
            lsbNguon.Items.AddRange(items);

            // Gán sự kiện cho nút
            btnRight.Click += delegate { MoveSelected(lsbNguon, lsbChon); };
            btnRightAll.Click += delegate { MoveAll(lsbNguon, lsbChon); };
            btnLeft.Click += delegate { MoveSelected(lsbChon, lsbNguon); };
            btnLeftAll.Click += delegate { MoveAll(lsbChon, lsbNguon); };

            // Double-click để chuyển nhanh 1 mục
            lsbNguon.DoubleClick += delegate { MoveSelected(lsbNguon, lsbChon); };
            lsbChon.DoubleClick += delegate { MoveSelected(lsbChon, lsbNguon); };
        }

        private void MoveSelected(ListBox src, ListBox dst)
        {
            if (src.SelectedItems.Count == 0) return;

            // Sao chép sang list tạm để tránh thay đổi khi lặp
            List<object> pick = new List<object>();
            foreach (object it in src.SelectedItems) pick.Add(it);

            foreach (object it in pick)
            {
                if (!dst.Items.Contains(it)) dst.Items.Add(it);
                src.Items.Remove(it);
            }
        }

        private void MoveAll(ListBox src, ListBox dst)
        {
            if (src.Items.Count == 0) return;

            foreach (object it in src.Items)
                if (!dst.Items.Contains(it)) dst.Items.Add(it);

            src.Items.Clear();
        }
    }
}
