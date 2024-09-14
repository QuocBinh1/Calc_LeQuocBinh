using System;
using System.Globalization;
using System.Windows.Forms;

namespace Calc_LeQuocBinh
{
    public partial class frmBinh : Form
    {
        // Fields
        private double result = 0;
        private string operation = string.Empty;
        private string fstNum, secNum;
        private bool enterValue = false;

        public frmBinh()
        {
            InitializeComponent();
        }

        private void BtnMthOperation_Click(object sender, EventArgs e)
        {
            if (result != 0) BtnEquals.PerformClick();
            else
            {
                result = GetCurrentInput();
            }

            var button = (CircularButton)sender;
            operation = button.Text == "+/-" ? ToggleSign() : button.Text;
            enterValue = true;

            if (TxtDisplay1.Text != "0")
            {
                UpdateDisplay();
            }
        }

        private double GetCurrentInput()
        {
            string cleanedInput = TxtDisplay1.Text.Replace(".", "").Replace(",", ".");
            return Convert.ToDouble(cleanedInput);
        }

        private string ToggleSign()
        {
            return TxtDisplay1.Text.StartsWith("-") ? "-" : "+";
        }

        private void UpdateDisplay()
        {
            TxtDisplay2.Text = $"{FormatNumber(result)} {operation}";
            fstNum = $"{result}";
            TxtDisplay1.Text = string.Empty;
        }

        private void BtnEquals_Click(object sender, EventArgs e)
        {
            secNum = TxtDisplay1.Text.Replace(".", "").Replace(",", ".");

            // Kiểm tra nếu có phép toán
            if (string.IsNullOrEmpty(operation) && result == 0)
            {
                TxtDisplay1.Text = "Chưa chọn phép toán.";
                return;
            }

            // Kiểm tra nếu có giá trị trong TxtDisplay1
            if (TxtDisplay1.Text != string.Empty)
            {
                if (operation == "/" && TxtDisplay1.Text == "0")
                {
                    TxtDisplay1.Text = "Không thể chia cho 0.";
                    return;
                }

                double secNumDouble;
                if (!double.TryParse(secNum, out secNumDouble))
                {
                    TxtDisplay1.Text = "Lỗi định dạng số.";
                    return;
                }

                // Nếu không có phép toán, sử dụng kết quả trước
                // Nếu chưa có kết quả (trong lần nhấn "=" đầu tiên)
                if (result == 0)
                {
                    result = double.Parse(TxtDisplay1.Text); // Lưu số đầu tiên
                }
                PerformCalculation(secNumDouble);
                // Hiển thị kết quả
                TxtDisplay1.Text = FormatNumber(result);
                UpdateHistory(secNumDouble);

                // Reset phép toán và số đầu
                //operation = string.Empty;
                //fstNum = string.Empty;
                fstNum = result.ToString();
            }
        }

        private void PerformCalculation(double secNumDouble)
        {
            switch (operation)
            {
                case "+":
                    result += secNumDouble;
                    break;
                case "-":
                    result -= secNumDouble;
                    break;
                case "x":
                    result *= secNumDouble;
                    break;
                case "/":
                    result /= secNumDouble;
                    break;
            }

            TxtDisplay1.Text = FormatNumber(result);
            UpdateHistory(secNumDouble);
            operation = string.Empty;
            fstNum = string.Empty;
        }

        private string FormatNumber(double number)
        {
            return number.ToString("#,##0.##", new CultureInfo("vi-VN"));
        }

        private void UpdateHistory(double secNumDouble)
        {
            //string formattedFstNum = FormatNumber(double.Parse(fstNum.Replace(".", "").Replace(",", ".")));
            // TxtDisplay2.Text = $"{formattedFstNum} {operation} {FormatNumber(secNumDouble)} = {FormatNumber(result)}";
            double parsedFstNum;

            if (!string.IsNullOrEmpty(fstNum) && double.TryParse(fstNum.Replace(".", "").Replace(",", "."), out parsedFstNum))
            {
                string formattedFstNum = FormatNumber(parsedFstNum);
                TxtDisplay2.Text = $"{formattedFstNum} {operation} {FormatNumber(secNumDouble)} = {FormatNumber(result)}";
            }
            else
            {
                TxtDisplay2.Text = $"0 {operation} {FormatNumber(secNumDouble)} = {FormatNumber(result)}";
            }
        }


        private void ButtonPM_Click(object sender, EventArgs e)
        {
            TxtDisplay1.Text = TxtDisplay1.Text.StartsWith("-")
                ? TxtDisplay1.Text.TrimStart('-')
                : "-" + TxtDisplay1.Text;
        }

        private void BtnOperations_Click(object sender, EventArgs e)
        {
            try
            {
                double value = Convert.ToDouble(TxtDisplay1.Text.Replace(",", "")) / 100;
                TxtDisplay1.Text = FormatNumber(value);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }
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
            if (string.IsNullOrEmpty(TxtDisplay1.Text))
            {
                TxtDisplay1.Text = "0";
            }
        }

        private void Btn1_Click(object sender, EventArgs e)
        {
            if (TxtDisplay1.Text == "0" || enterValue) TxtDisplay1.Text = string.Empty;
            enterValue = false;

            var button = (CircularButton)sender;
            if (button.Text == ".")
            {
                if (!TxtDisplay1.Text.Contains(",")) TxtDisplay1.Text += ",";
            }
            else
            {
                TxtDisplay1.Text += button.Text;
                UpdateFormattedDisplay();
            }
        }

        private void UpdateFormattedDisplay()
        {
            if (double.TryParse(TxtDisplay1.Text.Replace(".", "").Replace(",", "."), out double number))
            {
                TxtDisplay1.Text = FormatNumber(number);
            }
        }
    }
}