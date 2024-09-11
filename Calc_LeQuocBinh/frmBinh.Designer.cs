using System.Drawing.Drawing2D;
using System.Drawing;
using System;

namespace Calc_LeQuocBinh
{
    partial class frmBinh
    {
        private System.ComponentModel.IContainer components = null;

       
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }
        

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmBinh));
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnHistory = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.TxtDisplay2 = new System.Windows.Forms.TextBox();
            this.TxtDisplay1 = new System.Windows.Forms.TextBox();
            this.BtnDivision = new Calc_LeQuocBinh.CircularButton();
            this.BtnPercent = new Calc_LeQuocBinh.CircularButton();
            this.circularButton19 = new Calc_LeQuocBinh.CircularButton();
            this.BtnC = new Calc_LeQuocBinh.CircularButton();
            this.BtnMultiply = new Calc_LeQuocBinh.CircularButton();
            this.Btn9 = new Calc_LeQuocBinh.CircularButton();
            this.Btn8 = new Calc_LeQuocBinh.CircularButton();
            this.Btn7 = new Calc_LeQuocBinh.CircularButton();
            this.BtnSubtraction = new Calc_LeQuocBinh.CircularButton();
            this.Btn6 = new Calc_LeQuocBinh.CircularButton();
            this.Btn5 = new Calc_LeQuocBinh.CircularButton();
            this.Btn4 = new Calc_LeQuocBinh.CircularButton();
            this.BtnAdd = new Calc_LeQuocBinh.CircularButton();
            this.Btn3 = new Calc_LeQuocBinh.CircularButton();
            this.Btn2 = new Calc_LeQuocBinh.CircularButton();
            this.Btn1 = new Calc_LeQuocBinh.CircularButton();
            this.BtnEquals = new Calc_LeQuocBinh.CircularButton();
            this.BtnDesimal = new Calc_LeQuocBinh.CircularButton();
            this.Btn0 = new Calc_LeQuocBinh.CircularButton();
            this.BtnPM = new Calc_LeQuocBinh.CircularButton();
            this.BtnBackSpace = new Calc_LeQuocBinh.CircularButton();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // backgroundWorker1
            // 
            this.backgroundWorker1.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker1_DoWork);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnHistory);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.btnExit);
            this.panel1.Location = new System.Drawing.Point(12, 13);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(339, 37);
            this.panel1.TabIndex = 23;
            // 
            // btnHistory
            // 
            this.btnHistory.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnHistory.FlatAppearance.BorderSize = 0;
            this.btnHistory.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.btnHistory.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHistory.Image = ((System.Drawing.Image)(resources.GetObject("btnHistory.Image")));
            this.btnHistory.Location = new System.Drawing.Point(40, 0);
            this.btnHistory.Margin = new System.Windows.Forms.Padding(0);
            this.btnHistory.Name = "btnHistory";
            this.btnHistory.Size = new System.Drawing.Size(40, 37);
            this.btnHistory.TabIndex = 2;
            this.btnHistory.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Dock = System.Windows.Forms.DockStyle.Left;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.Location = new System.Drawing.Point(0, 0);
            this.button1.Margin = new System.Windows.Forms.Padding(0);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(40, 37);
            this.button1.TabIndex = 1;
            this.button1.UseVisualStyleBackColor = true;
            // 
            // btnExit
            // 
            this.btnExit.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnExit.FlatAppearance.BorderSize = 0;
            this.btnExit.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExit.Image = ((System.Drawing.Image)(resources.GetObject("btnExit.Image")));
            this.btnExit.Location = new System.Drawing.Point(299, 0);
            this.btnExit.Margin = new System.Windows.Forms.Padding(0);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(40, 37);
            this.btnExit.TabIndex = 0;
            this.btnExit.UseVisualStyleBackColor = true;
            // 
            // TxtDisplay2
            // 
            this.TxtDisplay2.Font = new System.Drawing.Font("Microsoft Tai Le", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtDisplay2.Location = new System.Drawing.Point(3, 69);
            this.TxtDisplay2.Margin = new System.Windows.Forms.Padding(0);
            this.TxtDisplay2.Multiline = true;
            this.TxtDisplay2.Name = "TxtDisplay2";
            this.TxtDisplay2.Size = new System.Drawing.Size(348, 33);
            this.TxtDisplay2.TabIndex = 24;
            this.TxtDisplay2.Text = "12345";
            this.TxtDisplay2.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.TxtDisplay2.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // TxtDisplay1
            // 
            this.TxtDisplay1.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtDisplay1.Location = new System.Drawing.Point(3, 115);
            this.TxtDisplay1.Margin = new System.Windows.Forms.Padding(0);
            this.TxtDisplay1.Multiline = true;
            this.TxtDisplay1.Name = "TxtDisplay1";
            this.TxtDisplay1.Size = new System.Drawing.Size(348, 40);
            this.TxtDisplay1.TabIndex = 25;
            this.TxtDisplay1.Text = "12345";
            this.TxtDisplay1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // BtnDivision
            // 
            this.BtnDivision.ButtonImage = null;
            this.BtnDivision.Font = new System.Drawing.Font("Microsoft Sans Serif", 17F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnDivision.Location = new System.Drawing.Point(259, 246);
            this.BtnDivision.Margin = new System.Windows.Forms.Padding(4);
            this.BtnDivision.Name = "BtnDivision";
            this.BtnDivision.Size = new System.Drawing.Size(70, 70);
            this.BtnDivision.TabIndex = 20;
            this.BtnDivision.Text = "/";
            this.BtnDivision.Load += new System.EventHandler(this.circularButton17_Load);
            // 
            // BtnPercent
            // 
            this.BtnPercent.ButtonImage = null;
            this.BtnPercent.Font = new System.Drawing.Font("Microsoft Sans Serif", 17F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnPercent.Location = new System.Drawing.Point(177, 246);
            this.BtnPercent.Margin = new System.Windows.Forms.Padding(4);
            this.BtnPercent.Name = "BtnPercent";
            this.BtnPercent.Size = new System.Drawing.Size(70, 70);
            this.BtnPercent.TabIndex = 19;
            this.BtnPercent.Text = "%";
            this.BtnPercent.Load += new System.EventHandler(this.circularButton18_Load);
            // 
            // circularButton19
            // 
            this.circularButton19.ButtonImage = null;
            this.circularButton19.Font = new System.Drawing.Font("Microsoft Sans Serif", 17F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.circularButton19.Location = new System.Drawing.Point(93, 246);
            this.circularButton19.Margin = new System.Windows.Forms.Padding(4);
            this.circularButton19.Name = "circularButton19";
            this.circularButton19.Size = new System.Drawing.Size(70, 70);
            this.circularButton19.TabIndex = 18;
            this.circularButton19.Text = "()";
            this.circularButton19.Load += new System.EventHandler(this.circularButton19_Load);
            // 
            // BtnC
            // 
            this.BtnC.ButtonImage = null;
            this.BtnC.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnC.ForeColor = System.Drawing.Color.Red;
            this.BtnC.Location = new System.Drawing.Point(9, 246);
            this.BtnC.Margin = new System.Windows.Forms.Padding(4);
            this.BtnC.Name = "BtnC";
            this.BtnC.Size = new System.Drawing.Size(70, 70);
            this.BtnC.TabIndex = 17;
            this.BtnC.Text = "C";
            // 
            // BtnMultiply
            // 
            this.BtnMultiply.ButtonImage = null;
            this.BtnMultiply.Font = new System.Drawing.Font("Microsoft Sans Serif", 17F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnMultiply.Location = new System.Drawing.Point(259, 322);
            this.BtnMultiply.Margin = new System.Windows.Forms.Padding(4);
            this.BtnMultiply.Name = "BtnMultiply";
            this.BtnMultiply.Size = new System.Drawing.Size(70, 70);
            this.BtnMultiply.TabIndex = 16;
            this.BtnMultiply.Text = "x";
            this.BtnMultiply.Load += new System.EventHandler(this.circularButton13_Load);
            // 
            // Btn9
            // 
            this.Btn9.ButtonImage = null;
            this.Btn9.Font = new System.Drawing.Font("Microsoft Sans Serif", 17F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn9.Location = new System.Drawing.Point(177, 322);
            this.Btn9.Margin = new System.Windows.Forms.Padding(4);
            this.Btn9.Name = "Btn9";
            this.Btn9.Size = new System.Drawing.Size(70, 70);
            this.Btn9.TabIndex = 15;
            this.Btn9.Text = "9";
            this.Btn9.Load += new System.EventHandler(this.circularButton14_Load);
            this.Btn9.Click += new System.EventHandler(this.Btn);
            // 
            // Btn8
            // 
            this.Btn8.ButtonImage = null;
            this.Btn8.Font = new System.Drawing.Font("Microsoft Sans Serif", 17F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn8.Location = new System.Drawing.Point(93, 322);
            this.Btn8.Margin = new System.Windows.Forms.Padding(4);
            this.Btn8.Name = "Btn8";
            this.Btn8.Size = new System.Drawing.Size(70, 70);
            this.Btn8.TabIndex = 14;
            this.Btn8.Text = "8";
            this.Btn8.Load += new System.EventHandler(this.circularButton15_Load);
            this.Btn8.Click += new System.EventHandler(this.Btn);
            // 
            // Btn7
            // 
            this.Btn7.ButtonImage = null;
            this.Btn7.Font = new System.Drawing.Font("Microsoft Sans Serif", 17F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn7.Location = new System.Drawing.Point(9, 322);
            this.Btn7.Margin = new System.Windows.Forms.Padding(4);
            this.Btn7.Name = "Btn7";
            this.Btn7.Size = new System.Drawing.Size(70, 70);
            this.Btn7.TabIndex = 13;
            this.Btn7.Text = "7";
            this.Btn7.Load += new System.EventHandler(this.circularButton16_Load);
            this.Btn7.Click += new System.EventHandler(this.Btn);
            // 
            // BtnSubtraction
            // 
            this.BtnSubtraction.ButtonImage = null;
            this.BtnSubtraction.Font = new System.Drawing.Font("Microsoft Sans Serif", 17F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnSubtraction.Location = new System.Drawing.Point(259, 400);
            this.BtnSubtraction.Margin = new System.Windows.Forms.Padding(4);
            this.BtnSubtraction.Name = "BtnSubtraction";
            this.BtnSubtraction.Size = new System.Drawing.Size(70, 70);
            this.BtnSubtraction.TabIndex = 12;
            this.BtnSubtraction.Text = "-";
            this.BtnSubtraction.Load += new System.EventHandler(this.circularButton9_Load);
            // 
            // Btn6
            // 
            this.Btn6.ButtonImage = null;
            this.Btn6.Font = new System.Drawing.Font("Microsoft Sans Serif", 17F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn6.Location = new System.Drawing.Point(177, 400);
            this.Btn6.Margin = new System.Windows.Forms.Padding(4);
            this.Btn6.Name = "Btn6";
            this.Btn6.Size = new System.Drawing.Size(70, 70);
            this.Btn6.TabIndex = 11;
            this.Btn6.Text = "6";
            this.Btn6.Load += new System.EventHandler(this.circularButton10_Load);
            this.Btn6.Click += new System.EventHandler(this.Btn);
            // 
            // Btn5
            // 
            this.Btn5.ButtonImage = null;
            this.Btn5.Font = new System.Drawing.Font("Microsoft Sans Serif", 17F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn5.Location = new System.Drawing.Point(93, 400);
            this.Btn5.Margin = new System.Windows.Forms.Padding(4);
            this.Btn5.Name = "Btn5";
            this.Btn5.Size = new System.Drawing.Size(70, 70);
            this.Btn5.TabIndex = 10;
            this.Btn5.Text = "5";
            this.Btn5.Load += new System.EventHandler(this.circularButton11_Load);
            this.Btn5.Click += new System.EventHandler(this.Btn);
            // 
            // Btn4
            // 
            this.Btn4.ButtonImage = null;
            this.Btn4.Font = new System.Drawing.Font("Microsoft Sans Serif", 17F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn4.Location = new System.Drawing.Point(9, 400);
            this.Btn4.Margin = new System.Windows.Forms.Padding(4);
            this.Btn4.Name = "Btn4";
            this.Btn4.Size = new System.Drawing.Size(70, 70);
            this.Btn4.TabIndex = 9;
            this.Btn4.Text = "4";
            this.Btn4.Load += new System.EventHandler(this.circularButton12_Load);
            this.Btn4.Click += new System.EventHandler(this.Btn);
            // 
            // BtnAdd
            // 
            this.BtnAdd.ButtonImage = null;
            this.BtnAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 17F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnAdd.Location = new System.Drawing.Point(259, 478);
            this.BtnAdd.Margin = new System.Windows.Forms.Padding(4);
            this.BtnAdd.Name = "BtnAdd";
            this.BtnAdd.Size = new System.Drawing.Size(70, 70);
            this.BtnAdd.TabIndex = 8;
            this.BtnAdd.Text = "+";
            this.BtnAdd.Load += new System.EventHandler(this.circularButton5_Load);
            // 
            // Btn3
            // 
            this.Btn3.ButtonImage = null;
            this.Btn3.Font = new System.Drawing.Font("Microsoft Sans Serif", 17F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn3.Location = new System.Drawing.Point(177, 478);
            this.Btn3.Margin = new System.Windows.Forms.Padding(4);
            this.Btn3.Name = "Btn3";
            this.Btn3.Size = new System.Drawing.Size(70, 70);
            this.Btn3.TabIndex = 7;
            this.Btn3.Text = "3";
            this.Btn3.Load += new System.EventHandler(this.circularButton6_Load);
            this.Btn3.Click += new System.EventHandler(this.Btn);
            // 
            // Btn2
            // 
            this.Btn2.ButtonImage = null;
            this.Btn2.Font = new System.Drawing.Font("Microsoft Sans Serif", 17F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn2.Location = new System.Drawing.Point(93, 478);
            this.Btn2.Margin = new System.Windows.Forms.Padding(4);
            this.Btn2.Name = "Btn2";
            this.Btn2.Size = new System.Drawing.Size(70, 70);
            this.Btn2.TabIndex = 6;
            this.Btn2.Text = "2";
            this.Btn2.Load += new System.EventHandler(this.circularButton7_Load);
            this.Btn2.Click += new System.EventHandler(this.Btn);
            // 
            // Btn1
            // 
            this.Btn1.ButtonImage = null;
            this.Btn1.Font = new System.Drawing.Font("Microsoft Sans Serif", 17F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn1.Location = new System.Drawing.Point(9, 478);
            this.Btn1.Margin = new System.Windows.Forms.Padding(4);
            this.Btn1.Name = "Btn1";
            this.Btn1.Size = new System.Drawing.Size(70, 70);
            this.Btn1.TabIndex = 5;
            this.Btn1.Text = "1";
            this.Btn1.Load += new System.EventHandler(this.circularButton8_Load);
            this.Btn1.Click += new System.EventHandler(this.Btn);
            // 
            // BtnEquals
            // 
            this.BtnEquals.BackColor = System.Drawing.Color.Gold;
            this.BtnEquals.ButtonImage = null;
            this.BtnEquals.Font = new System.Drawing.Font("Microsoft Sans Serif", 17F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnEquals.Location = new System.Drawing.Point(259, 555);
            this.BtnEquals.Margin = new System.Windows.Forms.Padding(4);
            this.BtnEquals.Name = "BtnEquals";
            this.BtnEquals.Size = new System.Drawing.Size(70, 70);
            this.BtnEquals.TabIndex = 4;
            this.BtnEquals.Text = "=";
            this.BtnEquals.Load += new System.EventHandler(this.circularButton4_Load);
            // 
            // BtnDesimal
            // 
            this.BtnDesimal.ButtonImage = null;
            this.BtnDesimal.Font = new System.Drawing.Font("Microsoft Sans Serif", 17F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnDesimal.Location = new System.Drawing.Point(177, 555);
            this.BtnDesimal.Margin = new System.Windows.Forms.Padding(4);
            this.BtnDesimal.Name = "BtnDesimal";
            this.BtnDesimal.Size = new System.Drawing.Size(70, 70);
            this.BtnDesimal.TabIndex = 3;
            this.BtnDesimal.Text = ",";
            this.BtnDesimal.Load += new System.EventHandler(this.circularButton3_Load);
            this.BtnDesimal.Click += new System.EventHandler(this.Btn);
            // 
            // Btn0
            // 
            this.Btn0.ButtonImage = null;
            this.Btn0.Font = new System.Drawing.Font("Microsoft Sans Serif", 17F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn0.Location = new System.Drawing.Point(93, 555);
            this.Btn0.Margin = new System.Windows.Forms.Padding(4);
            this.Btn0.Name = "Btn0";
            this.Btn0.Size = new System.Drawing.Size(70, 70);
            this.Btn0.TabIndex = 2;
            this.Btn0.Text = "0";
            this.Btn0.Load += new System.EventHandler(this.circularButton2_Load);
            this.Btn0.Click += new System.EventHandler(this.Btn);
            // 
            // BtnPM
            // 
            this.BtnPM.ButtonImage = null;
            this.BtnPM.Font = new System.Drawing.Font("Microsoft Sans Serif", 17F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnPM.Location = new System.Drawing.Point(9, 555);
            this.BtnPM.Margin = new System.Windows.Forms.Padding(4);
            this.BtnPM.Name = "BtnPM";
            this.BtnPM.Size = new System.Drawing.Size(70, 70);
            this.BtnPM.TabIndex = 1;
            this.BtnPM.Text = "+/-";
            this.BtnPM.Load += new System.EventHandler(this.circularButton1_Load);
            // 
            // BtnBackSpace
            // 
            this.BtnBackSpace.ButtonImage = null;
            this.BtnBackSpace.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnBackSpace.ForeColor = System.Drawing.Color.Red;
            this.BtnBackSpace.Location = new System.Drawing.Point(259, 168);
            this.BtnBackSpace.Margin = new System.Windows.Forms.Padding(4);
            this.BtnBackSpace.Name = "BtnBackSpace";
            this.BtnBackSpace.Size = new System.Drawing.Size(70, 70);
            this.BtnBackSpace.TabIndex = 26;
            this.BtnBackSpace.Text = "C";
            // 
            // frmBinh
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(376, 638);
            this.Controls.Add(this.BtnBackSpace);
            this.Controls.Add(this.TxtDisplay1);
            this.Controls.Add(this.TxtDisplay2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.BtnDivision);
            this.Controls.Add(this.BtnPercent);
            this.Controls.Add(this.circularButton19);
            this.Controls.Add(this.BtnC);
            this.Controls.Add(this.BtnMultiply);
            this.Controls.Add(this.Btn9);
            this.Controls.Add(this.Btn8);
            this.Controls.Add(this.Btn7);
            this.Controls.Add(this.BtnSubtraction);
            this.Controls.Add(this.Btn6);
            this.Controls.Add(this.Btn5);
            this.Controls.Add(this.Btn4);
            this.Controls.Add(this.BtnAdd);
            this.Controls.Add(this.Btn3);
            this.Controls.Add(this.Btn2);
            this.Controls.Add(this.Btn1);
            this.Controls.Add(this.BtnEquals);
            this.Controls.Add(this.BtnDesimal);
            this.Controls.Add(this.Btn0);
            this.Controls.Add(this.BtnPM);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmBinh";
            this.Text = "frmBinh";
            this.Load += new System.EventHandler(this.frmBinh_Load);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnHistory;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox TxtDisplay2;
        private System.Windows.Forms.TextBox TxtDisplay1;
        private CircularButton BtnPM;
        private CircularButton Btn0;
        private CircularButton BtnDesimal;
        private CircularButton BtnEquals;
        private CircularButton Btn1;
        private CircularButton Btn2;
        private CircularButton Btn3;
        private CircularButton BtnAdd;
        private CircularButton Btn4;
        private CircularButton Btn5;
        private CircularButton Btn6;
        private CircularButton BtnSubtraction;
        private CircularButton Btn7;
        private CircularButton Btn8;
        private CircularButton Btn9;
        private CircularButton BtnMultiply;
        private CircularButton BtnC;
        private CircularButton circularButton19;
        private CircularButton BtnPercent;
        private CircularButton BtnDivision;
        private CircularButton BtnBackSpace;
    }
}
