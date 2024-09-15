using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calc_LeQuocBinh
{
    public partial class frmBinh : Form
    {
        //fields
        double result = 0;
        string operation = string.Empty;
        string fstNum, secNum;
        bool enterValue = false;
        public frmBinh()
        {
            InitializeComponent();
        }
        private void BtnMthOperation_Click(object sender, EventArgs e)
        {
            if (result != 0) BtnEquals.PerformClick();
            else
            {
                string cleanedInput = TxtDisplay1.Text.Replace(".", "").Replace(",", ".");
                result = Convert.ToDouble(cleanedInput);
            }
            CircularButton button = (CircularButton)sender;
            if (operation == "+/-")
            {

                if (TxtDisplay1.Text.StartsWith("-"))
                {
                    operation = "-";

                }
                else
                {
                    operation = "+";
                }
            }
            else
            {
                operation = button.Text;
            }
            enterValue = true;
            if (TxtDisplay1.Text != "0")
            {
                TxtDisplay2.Text = $"{result.ToString("#,##0.##", new System.Globalization.CultureInfo("vi-VN"))} {operation}";
                fstNum = $"{result}";
                TxtDisplay1.Text = string.Empty;
            }
        }

        private void BtnEquals_Click(object sender, EventArgs e)
        {
            // Loại bỏ dấu phân cách hàng nghìn và thay dấu phẩy bằng dấu chấm để xử lý phép toán
            string cleanedInput = TxtDisplay1.Text.Replace(".", "").Replace(",", ".");
            secNum = cleanedInput;
            // Kiểm tra toán tử
            if (string.IsNullOrEmpty(operation))
            {
                TxtDisplay1.Text = "Chưa chọn phép toán.";
                return;
            }
            // Cập nhật TxtDisplay2 với biểu thức toán học chỉ một lần
            if (TxtDisplay2.Text.EndsWith(" ="))
            {
                TxtDisplay2.Text = $"{fstNum} {operation} {secNum} =";
            }
            // Kiểm tra nếu có giá trị trong TxtDisplay1
            if (TxtDisplay1.Text != string.Empty)
            {
                if (TxtDisplay1.Text == "0" && operation == "/")
                {
                    TxtDisplay1.Text = "Không thể chia cho 0.";
                    return;
                }

                double secNumDouble;
                if (!double.TryParse(cleanedInput, out secNumDouble))
                {
                    TxtDisplay1.Text = "Lỗi định dạng số.";
                    return;
                }

                // Thực hiện phép toán
                switch (operation)
                {
                    case "+":
                        result = result + secNumDouble;
                        RtBoxDisplayHistory.AppendText($"{fstNum} + {secNum} = {result} \n");
                        break;
                    case "-":
                        
                        result = result - secNumDouble;
                        RtBoxDisplayHistory.AppendText($"{fstNum} - {secNum} = {result} \n");
                        break;
                    case "x":
                        
                        result = result * secNumDouble;
                        RtBoxDisplayHistory.AppendText($"{fstNum} x {secNum} = {result} \n");
                        break;
                    case "/":
                        
                        result = result / secNumDouble;
                        RtBoxDisplayHistory.AppendText($"{fstNum} /  {secNum}  = {result} \n");
                        break;
                    default: TxtDisplay2.Text = $"{TxtDisplay1.Text} =";
                        break;
                }

                // Hiển thị kết quả với định dạng hàng nghìn và dấu thập phân đúng
                TxtDisplay1.Text = result.ToString("#,##0.##", new System.Globalization.CultureInfo("vi-VN"));

                // Cập nhật lại TxtDisplay2 với biểu thức và định dạng số đúng
                string formattedFstNum = double.Parse(fstNum.Replace(".", "").Replace(",", ".")).ToString("#,##0.##", new System.Globalization.CultureInfo("vi-VN"));
                string formattedSecNum = secNumDouble.ToString("#,##0.##", new System.Globalization.CultureInfo("vi-VN"));
                string formattedResult = result.ToString("#,##0.##", new System.Globalization.CultureInfo("vi-VN"));

                TxtDisplay2.Text = $"{formattedFstNum} {operation} {formattedSecNum} = {formattedResult}";

                // Đặt lại toán tử và số đầu vào
                operation = string.Empty;
                fstNum = string.Empty;
            }
        }

        //+/-        
        private void ButtonPM_Click(object sender, EventArgs e)
        {
            if (TxtDisplay1.Text.StartsWith("-"))
            {
                // Loại bỏ dấu "-" để biến số thành dương
                TxtDisplay1.Text = TxtDisplay1.Text.TrimStart('-');
            }
            else
            {
                // Thêm dấu "-" vào đầu để biến số thành âm
                TxtDisplay1.Text = "-" + TxtDisplay1.Text;
            }
        }
        // %        
        private void BtnOperations_Click(object sender, EventArgs e)
        {
            try
            {
                // Kiểm tra nếu không có phép toán nào đang thực hiện
                if (string.IsNullOrEmpty(operation))
                {
                    // Lấy giá trị hiện tại từ TxtDisplay1
                    double value = Convert.ToDouble(TxtDisplay1.Text.Replace(",", ""));

                    // Chia giá trị cho 100 để ra phần trăm
                    value = value / 100;

                    // Hiển thị kết quả với định dạng hàng nghìn
                    TxtDisplay1.Text = value.ToString("#,##0.##", new System.Globalization.CultureInfo("vi-VN"));
                }
                else
                {
                    // Trường hợp có phép tính thì xử lý phần trăm theo phép tính hiện tại
                    double secNumDouble = Convert.ToDouble(TxtDisplay1.Text.Replace(",", ""));
                    secNumDouble = secNumDouble / 100;

                    TxtDisplay1.Text = secNumDouble.ToString("#,##0.##", new System.Globalization.CultureInfo("vi-VN"));
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }
            //RtBoxDisplayHistort.AppendText($"{TxtDisplay2.Text} = {TxtDisplay1.Text} \n");
        }
        private void btn_c_Click(object sender, EventArgs e)
        {

            TxtDisplay1.Text = "0";
            TxtDisplay2.Text = string.Empty;
            result = 0;
        }
        private void btn_del_Click(object sender, EventArgs e)
        {
            if (TxtDisplay1.Text.Length > 0)
            {
                TxtDisplay1.Text = TxtDisplay1.Text.Remove(TxtDisplay1.Text.Length - 1, 1);
            }
            if (TxtDisplay1.Text == string.Empty)
            {
                TxtDisplay1.Text = "0";
            }
        }

        private void btnParen_Click(object sender, EventArgs e)
        {
            CircularButton button = (CircularButton)sender;
            operation = button.Text;
            switch (operation)
            {
                case "1/x":
                    TxtDisplay2.Text = $"1/({TxtDisplay1.Text})";
                    TxtDisplay1.Text = Convert.ToString(1.0 / Convert.ToDouble(TxtDisplay1.Text));

                    break;
            }
        }

        private void frmBinh_Load(object sender, EventArgs e)
        {

        }

        private void btnHistory_Click(object sender, EventArgs e)
        {
            PnlHistory.Height = (PnlHistory.Height == 5) ? PnlHistory.Height = 590 : 5;
        }

        private void BtnClearHistory_Click(object sender, EventArgs e)
        {
            RtBoxDisplayHistory.Clear();
            if(RtBoxDisplayHistory.Text == string.Empty)
            {
                RtBoxDisplayHistory.Text = "Không có lịch sử";
            }
        }

        private void Btn1_Click(object sender, EventArgs e)
        {
            if (TxtDisplay1.Text == "0" || enterValue) TxtDisplay1.Text = string.Empty;
            enterValue = false;
            CircularButton button = (CircularButton)sender;

            if (button.Text == ".")
            {
                // Kiểm tra nếu dấu chấm chưa tồn tại trong chuỗi
                if (!TxtDisplay1.Text.Contains(","))
                    TxtDisplay1.Text = TxtDisplay1.Text + ",";
            }
            else
            {
                TxtDisplay1.Text = TxtDisplay1.Text + button.Text;

                // Chỉ định dạng lại nếu không phải là dấu chấm
                if (double.TryParse(TxtDisplay1.Text.Replace(".", "").Replace(",", "."), out double number))
                {
                    // Hiển thị lại với định dạng hàng nghìn và dấu thập phân
                    TxtDisplay1.Text = number.ToString("#,##0.##", new System.Globalization.CultureInfo("vi-VN"));
                }
            }

        }
    }

}
