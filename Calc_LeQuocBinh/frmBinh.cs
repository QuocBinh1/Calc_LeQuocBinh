using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
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
        string fstNum,secNum;
        bool enterValue = false;
        public frmBinh()
        {
            InitializeComponent();
        }

        private void frmBinh_Load(object sender, EventArgs e)
        {
            
        }
        private void BtnRound_Click(object sender, EventArgs e)
        {
           
        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void circularButton1_Load(object sender, EventArgs e)
        {

        }

        private void circularButton18_Load(object sender, EventArgs e)
        {

        }

        private void circularButton19_Load(object sender, EventArgs e)
        {

        }

        private void circularButton13_Load(object sender, EventArgs e)
        {

        }

        private void circularButton14_Load(object sender, EventArgs e)
        {

        }

        private void circularButton15_Load(object sender, EventArgs e)
        {

        }

        private void circularButton9_Load(object sender, EventArgs e)
        {

        }

        private void circularButton10_Load(object sender, EventArgs e)
        {

        }

        private void circularButton11_Load(object sender, EventArgs e)
        {

        }

        private void circularButton5_Load(object sender, EventArgs e)
        {

        }

        private void circularButton6_Load(object sender, EventArgs e)
        {

        }

        private void circularButton7_Load(object sender, EventArgs e)
        {

        }

        private void circularButton4_Load(object sender, EventArgs e)
        {

        }

        private void circularButton3_Load(object sender, EventArgs e)
        {

        }

        private void circularButton2_Load(object sender, EventArgs e)
        {

        }

        private void circularButton17_Load(object sender, EventArgs e)
        {

        }

        private void circularButton16_Load(object sender, EventArgs e)
        {

        }

        private void circularButton12_Load(object sender, EventArgs e)
        {

        }

        private void circularButton8_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void circularButton21_Load(object sender, EventArgs e)
        {

        }

        private void Btn(object sender, EventArgs e)
        {

        }

        //number
        private void BtnNum_Click(object sender, EventArgs e)
        {
            if(TxtDisplay1.Text == "0" || enterValue)TxtDisplay1.Text = string.Empty;
            enterValue = false;
            Artanbutton button = new ArtanButton();
            if(button.text == ".")
            {
                if(TxtDisplay1.Text.Contains("."))
                    TxtDisplay1.Text = TxtDisplay1.Text + button.text;
            }
             else   
                TxtDisplay1.Text = TxtDisplay1 + button.text;
        }
    }
}
 