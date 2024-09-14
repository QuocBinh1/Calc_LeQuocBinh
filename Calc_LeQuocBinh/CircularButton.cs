using System;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace Calc_LeQuocBinh
{
    public partial class CircularButton : Button
    {
        private string buttonText;
        private Image buttonImage;  // Thêm thuộc tính hình ảnh

        public CircularButton()
        {
            this.Resize += CircularButton_Resize;  // Đảm bảo nút luôn là hình tròn khi thay đổi kích thước
            this.buttonText = "Button";
            this.DoubleBuffered = true;  // Bật DoubleBuffering để giảm flicker
        }

        // Đảm bảo nút có hình dạng vuông khi thay đổi kích thước
        private void CircularButton_Resize(object sender, EventArgs e)
        {
            if (this.Width != this.Height)
            {
                this.Width = this.Height;  // Đảm bảo nút là hình vuông
            }
        }

        // Ghi đè phương thức OnPaint để vẽ nút tròn và hình ảnh
        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            Graphics g = e.Graphics;
            g.SmoothingMode = SmoothingMode.AntiAlias;  // Làm mịn các cạnh

            // Xóa nền trước khi vẽ lại, kiểm tra nếu Parent không phải null
            if (this.Parent != null)
            {
                g.Clear(this.Parent.BackColor);
            }
            else
            {
                g.Clear(Color.Transparent);
            }

            // Vẽ hình tròn
            using (Brush brush = new SolidBrush(this.BackColor))
            {
                g.FillEllipse(brush, 0, 0, this.Width - 1, this.Height - 1);
            }

            // Vẽ viền nút
            using (Pen pen = new Pen(Color.Gray, 2))
            {
                g.DrawEllipse(pen, 0, 0, this.Width - 1, this.Height - 1);
            }

            // Vẽ hình ảnh nếu có
            if (buttonImage != null)
            {
                int imgWidth = Math.Min(this.Width, this.Height) / 2;  // Điều chỉnh kích thước ảnh
                Rectangle imgRect = new Rectangle((this.Width - imgWidth) / 2, (this.Height - imgWidth) / 2, imgWidth, imgWidth);
                g.DrawImage(buttonImage, imgRect);
            }

            // Vẽ văn bản của nút
            if (!string.IsNullOrEmpty(this.buttonText))
            {
                using (StringFormat sf = new StringFormat()
                {
                    Alignment = StringAlignment.Center,
                    LineAlignment = StringAlignment.Center
                })
                {
                    g.DrawString(this.buttonText, this.Font, new SolidBrush(this.ForeColor), this.ClientRectangle, sf);
                }
            }
        }

        // Thuộc tính văn bản tùy chỉnh để hiển thị chữ trên nút
        [Browsable(true)]  // Cho phép hiển thị trong Properties
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]  // Cho phép lưu trữ trong mã thiết kế
        [DefaultValue("Button")]  // Giá trị mặc định cho Text
        public override string Text
        {
            get { return buttonText; }
            set
            {
                buttonText = value;
                this.Invalidate();  // Buộc vẽ lại để cập nhật văn bản
            }
        }

        // Thuộc tính hình ảnh tùy chỉnh để hiển thị ảnh trên nút
        [Browsable(true)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
        public Image ButtonImage
        {
            get { return buttonImage; }
            set
            {
                buttonImage = value;
                this.Invalidate();  // Buộc vẽ lại để cập nhật ảnh
            }
        }

        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // CircularButton
            // 
            this.Name = "CircularButton";
            this.Size = new System.Drawing.Size(77, 65);
            this.ResumeLayout(false);

        }
    }
}
