using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Delegates
{
    public partial class Form : System.Windows.Forms.Form
    {
        // Delegate để xử lý sự kiện click của nút
        public delegate void ButtonClickHandler(object sender, EventArgs e);
        public event ButtonClickHandler ButtonClicked;
        public Form()
        {
            InitializeComponent();
            // Đăng ký sự kiện ButtonClicked
            ButtonClicked += OnButtonClicked;
            // Xử lý sự kiện click của nút "Tạo nút"
            btnCreateButtons.Click += btnCreateButtons_Click;

        }

        private void btnCreateButtons_Click(object sender, EventArgs e)
        {
            panelButtons.Controls.Clear();

            // Kiểm tra số lượng nút hợp lệ
            if (int.TryParse(txtNumberOfButtons.Text, out int numberOfButtons))
            {
                int yOffset = 0; // Khoảng cách dọc giữa các nút

                for (int i = 1; i <= numberOfButtons; i++)
                {
                    Button newButton = new Button
                    {
                        Text = $"Nút {i}",
                        Width = 80,
                        Height = 30,
                        Tag = i // Sử dụng Tag để lưu thông tin nút
                    };

                    // Đăng ký sự kiện click cho từng nút
                    newButton.Click += (s, args) =>
                    {
                        ButtonClicked?.Invoke(s, args);
                    };

                    // Thiết lập vị trí của nút để không bị chồng lên nhau
                    newButton.Location = new Point(10, yOffset); // Xác định tọa độ của nút trong panel
                    yOffset += 40; // Tăng yOffset để các nút nằm cách nhau theo chiều dọc

                    // Thêm nút vào panel
                    panelButtons.Controls.Add(newButton);
                }
            }
            else
            {
                MessageBox.Show("Vui lòng nhập một số hợp lệ!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Phương thức xử lý sự kiện click cho các nút
        private void OnButtonClicked(object sender, EventArgs e)
        {
            if (sender is Button clickedButton)
            {
                MessageBox.Show($"Bạn đã nhấn {clickedButton.Text}", "Thông báo");
            }
        }
    }
}
