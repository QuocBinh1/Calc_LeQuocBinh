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
            this.PnlTitle = new System.Windows.Forms.Panel();
            this.btnHistory = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.TxtDisplay2 = new System.Windows.Forms.TextBox();
            this.TxtDisplay1 = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.PnlHistory = new System.Windows.Forms.Panel();
            this.RtBoxDisplayHistory = new System.Windows.Forms.RichTextBox();
            this.BtnClearHistory = new System.Windows.Forms.Button();
            this.BtnDivision = new Calc_LeQuocBinh.CircularButton();
            this.BtnPercent = new Calc_LeQuocBinh.CircularButton();
            this.btnParen = new Calc_LeQuocBinh.CircularButton();
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
            this.PnlTitle.SuspendLayout();
            this.PnlHistory.SuspendLayout();
            this.SuspendLayout();
            // 
            // PnlTitle
            // 
            this.PnlTitle.Controls.Add(this.btnHistory);
            this.PnlTitle.Controls.Add(this.button1);
            this.PnlTitle.Location = new System.Drawing.Point(12, 13);
            this.PnlTitle.Name = "PnlTitle";
            this.PnlTitle.Size = new System.Drawing.Size(317, 37);
            this.PnlTitle.TabIndex = 23;
            // 
            // btnHistory
            // 
            this.btnHistory.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnHistory.FlatAppearance.BorderSize = 0;
            this.btnHistory.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.btnHistory.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHistory.Image = ((System.Drawing.Image)(resources.GetObject("btnHistory.Image")));
            this.btnHistory.Location = new System.Drawing.Point(277, 0);
            this.btnHistory.Margin = new System.Windows.Forms.Padding(0);
            this.btnHistory.Name = "btnHistory";
            this.btnHistory.Size = new System.Drawing.Size(40, 37);
            this.btnHistory.TabIndex = 2;
            this.btnHistory.UseVisualStyleBackColor = true;
            this.btnHistory.Click += new System.EventHandler(this.btnHistory_Click);
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
            // TxtDisplay2
            // 
            this.TxtDisplay2.Font = new System.Drawing.Font("Microsoft Tai Le", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtDisplay2.Location = new System.Drawing.Point(3, 69);
            this.TxtDisplay2.Margin = new System.Windows.Forms.Padding(0);
            this.TxtDisplay2.Multiline = true;
            this.TxtDisplay2.Name = "TxtDisplay2";
            this.TxtDisplay2.Size = new System.Drawing.Size(326, 43);
            this.TxtDisplay2.TabIndex = 24;
            this.TxtDisplay2.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // TxtDisplay1
            // 
            this.TxtDisplay1.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtDisplay1.Location = new System.Drawing.Point(0, 127);
            this.TxtDisplay1.Margin = new System.Windows.Forms.Padding(0);
            this.TxtDisplay1.Multiline = true;
            this.TxtDisplay1.Name = "TxtDisplay1";
            this.TxtDisplay1.Size = new System.Drawing.Size(329, 61);
            this.TxtDisplay1.TabIndex = 25;
            this.TxtDisplay1.Text = "0";
            this.TxtDisplay1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // button2
            // 
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Image = global::Calc_LeQuocBinh.Properties.Resources._8665278_delete_left_icon;
            this.button2.Location = new System.Drawing.Point(275, 191);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(42, 34);
            this.button2.TabIndex = 26;
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.btn_del_Click);
            // 
            // PnlHistory
            // 
            this.PnlHistory.Controls.Add(this.BtnClearHistory);
            this.PnlHistory.Controls.Add(this.RtBoxDisplayHistory);
            this.PnlHistory.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.PnlHistory.Location = new System.Drawing.Point(0, 636);
            this.PnlHistory.Margin = new System.Windows.Forms.Padding(0);
            this.PnlHistory.Name = "PnlHistory";
            this.PnlHistory.Size = new System.Drawing.Size(338, 5);
            this.PnlHistory.TabIndex = 27;
            // 
            // RtBoxDisplayHistory
            // 
            this.RtBoxDisplayHistory.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.RtBoxDisplayHistory.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.RtBoxDisplayHistory.Dock = System.Windows.Forms.DockStyle.Fill;
            this.RtBoxDisplayHistory.ForeColor = System.Drawing.Color.Black;
            this.RtBoxDisplayHistory.Location = new System.Drawing.Point(0, 0);
            this.RtBoxDisplayHistory.Name = "RtBoxDisplayHistory";
            this.RtBoxDisplayHistory.Size = new System.Drawing.Size(338, 5);
            this.RtBoxDisplayHistory.TabIndex = 28;
            this.RtBoxDisplayHistory.Text = "";
            // 
            // BtnClearHistory
            // 
            this.BtnClearHistory.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.BtnClearHistory.FlatAppearance.BorderSize = 0;
            this.BtnClearHistory.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.BtnClearHistory.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnClearHistory.Image = ((System.Drawing.Image)(resources.GetObject("BtnClearHistory.Image")));
            this.BtnClearHistory.Location = new System.Drawing.Point(0, -32);
            this.BtnClearHistory.Margin = new System.Windows.Forms.Padding(0);
            this.BtnClearHistory.Name = "BtnClearHistory";
            this.BtnClearHistory.Size = new System.Drawing.Size(338, 37);
            this.BtnClearHistory.TabIndex = 29;
            this.BtnClearHistory.UseVisualStyleBackColor = true;
            this.BtnClearHistory.Click += new System.EventHandler(this.BtnClearHistory_Click);
            // 
            // BtnDivision
            // 
            this.BtnDivision.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.BtnDivision.ButtonImage = null;
            this.BtnDivision.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnDivision.Location = new System.Drawing.Point(258, 237);
            this.BtnDivision.Margin = new System.Windows.Forms.Padding(4);
            this.BtnDivision.Name = "BtnDivision";
            this.BtnDivision.Size = new System.Drawing.Size(70, 70);
            this.BtnDivision.TabIndex = 20;
            this.BtnDivision.Text = "/";
            this.BtnDivision.UseVisualStyleBackColor = false;
            this.BtnDivision.Click += new System.EventHandler(this.BtnMthOperation_Click);
            // 
            // BtnPercent
            // 
            this.BtnPercent.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.BtnPercent.ButtonImage = null;
            this.BtnPercent.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.BtnPercent.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnPercent.Location = new System.Drawing.Point(176, 237);
            this.BtnPercent.Margin = new System.Windows.Forms.Padding(4);
            this.BtnPercent.Name = "BtnPercent";
            this.BtnPercent.Size = new System.Drawing.Size(70, 70);
            this.BtnPercent.TabIndex = 19;
            this.BtnPercent.Text = "%";
            this.BtnPercent.UseVisualStyleBackColor = false;
            this.BtnPercent.Click += new System.EventHandler(this.BtnOperations_Click);
            // 
            // btnParen
            // 
            this.btnParen.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnParen.ButtonImage = null;
            this.btnParen.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnParen.Location = new System.Drawing.Point(92, 237);
            this.btnParen.Margin = new System.Windows.Forms.Padding(4);
            this.btnParen.Name = "btnParen";
            this.btnParen.Size = new System.Drawing.Size(70, 70);
            this.btnParen.TabIndex = 18;
            this.btnParen.Text = "1/x";
            this.btnParen.UseVisualStyleBackColor = false;
            this.btnParen.Click += new System.EventHandler(this.btnParen_Click);
            // 
            // BtnC
            // 
            this.BtnC.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.BtnC.ButtonImage = null;
            this.BtnC.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnC.ForeColor = System.Drawing.Color.Red;
            this.BtnC.Location = new System.Drawing.Point(8, 237);
            this.BtnC.Margin = new System.Windows.Forms.Padding(4);
            this.BtnC.Name = "BtnC";
            this.BtnC.Size = new System.Drawing.Size(70, 70);
            this.BtnC.TabIndex = 17;
            this.BtnC.Text = "C";
            this.BtnC.UseVisualStyleBackColor = false;
            this.BtnC.Click += new System.EventHandler(this.btn_c_Click);
            // 
            // BtnMultiply
            // 
            this.BtnMultiply.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.BtnMultiply.ButtonImage = null;
            this.BtnMultiply.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnMultiply.Location = new System.Drawing.Point(258, 313);
            this.BtnMultiply.Margin = new System.Windows.Forms.Padding(4);
            this.BtnMultiply.Name = "BtnMultiply";
            this.BtnMultiply.Size = new System.Drawing.Size(70, 70);
            this.BtnMultiply.TabIndex = 16;
            this.BtnMultiply.Text = "x";
            this.BtnMultiply.UseVisualStyleBackColor = false;
            this.BtnMultiply.Click += new System.EventHandler(this.BtnMthOperation_Click);
            // 
            // Btn9
            // 
            this.Btn9.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.Btn9.ButtonImage = null;
            this.Btn9.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn9.Location = new System.Drawing.Point(176, 313);
            this.Btn9.Margin = new System.Windows.Forms.Padding(4);
            this.Btn9.Name = "Btn9";
            this.Btn9.Size = new System.Drawing.Size(70, 70);
            this.Btn9.TabIndex = 15;
            this.Btn9.Text = "9";
            this.Btn9.UseVisualStyleBackColor = false;
            this.Btn9.Click += new System.EventHandler(this.Btn1_Click);
            // 
            // Btn8
            // 
            this.Btn8.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.Btn8.ButtonImage = null;
            this.Btn8.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn8.Location = new System.Drawing.Point(92, 313);
            this.Btn8.Margin = new System.Windows.Forms.Padding(4);
            this.Btn8.Name = "Btn8";
            this.Btn8.Size = new System.Drawing.Size(70, 70);
            this.Btn8.TabIndex = 14;
            this.Btn8.Text = "8";
            this.Btn8.UseVisualStyleBackColor = false;
            this.Btn8.Click += new System.EventHandler(this.Btn1_Click);
            // 
            // Btn7
            // 
            this.Btn7.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.Btn7.ButtonImage = null;
            this.Btn7.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn7.Location = new System.Drawing.Point(8, 313);
            this.Btn7.Margin = new System.Windows.Forms.Padding(4);
            this.Btn7.Name = "Btn7";
            this.Btn7.Size = new System.Drawing.Size(70, 70);
            this.Btn7.TabIndex = 13;
            this.Btn7.Text = "7";
            this.Btn7.UseVisualStyleBackColor = false;
            this.Btn7.Click += new System.EventHandler(this.Btn1_Click);
            // 
            // BtnSubtraction
            // 
            this.BtnSubtraction.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.BtnSubtraction.ButtonImage = null;
            this.BtnSubtraction.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnSubtraction.Location = new System.Drawing.Point(258, 391);
            this.BtnSubtraction.Margin = new System.Windows.Forms.Padding(4);
            this.BtnSubtraction.Name = "BtnSubtraction";
            this.BtnSubtraction.Size = new System.Drawing.Size(70, 70);
            this.BtnSubtraction.TabIndex = 12;
            this.BtnSubtraction.Text = "-";
            this.BtnSubtraction.UseVisualStyleBackColor = false;
            this.BtnSubtraction.Click += new System.EventHandler(this.BtnMthOperation_Click);
            // 
            // Btn6
            // 
            this.Btn6.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.Btn6.ButtonImage = null;
            this.Btn6.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn6.Location = new System.Drawing.Point(176, 391);
            this.Btn6.Margin = new System.Windows.Forms.Padding(4);
            this.Btn6.Name = "Btn6";
            this.Btn6.Size = new System.Drawing.Size(70, 70);
            this.Btn6.TabIndex = 11;
            this.Btn6.Text = "6";
            this.Btn6.UseVisualStyleBackColor = false;
            this.Btn6.Click += new System.EventHandler(this.Btn1_Click);
            // 
            // Btn5
            // 
            this.Btn5.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.Btn5.ButtonImage = null;
            this.Btn5.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn5.Location = new System.Drawing.Point(92, 391);
            this.Btn5.Margin = new System.Windows.Forms.Padding(4);
            this.Btn5.Name = "Btn5";
            this.Btn5.Size = new System.Drawing.Size(70, 70);
            this.Btn5.TabIndex = 10;
            this.Btn5.Text = "5";
            this.Btn5.UseVisualStyleBackColor = false;
            this.Btn5.Click += new System.EventHandler(this.Btn1_Click);
            // 
            // Btn4
            // 
            this.Btn4.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.Btn4.ButtonImage = null;
            this.Btn4.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn4.Location = new System.Drawing.Point(8, 391);
            this.Btn4.Margin = new System.Windows.Forms.Padding(4);
            this.Btn4.Name = "Btn4";
            this.Btn4.Size = new System.Drawing.Size(70, 70);
            this.Btn4.TabIndex = 9;
            this.Btn4.Text = "4";
            this.Btn4.UseVisualStyleBackColor = false;
            this.Btn4.Click += new System.EventHandler(this.Btn1_Click);
            // 
            // BtnAdd
            // 
            this.BtnAdd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.BtnAdd.ButtonImage = null;
            this.BtnAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnAdd.Location = new System.Drawing.Point(258, 469);
            this.BtnAdd.Margin = new System.Windows.Forms.Padding(4);
            this.BtnAdd.Name = "BtnAdd";
            this.BtnAdd.Size = new System.Drawing.Size(70, 70);
            this.BtnAdd.TabIndex = 8;
            this.BtnAdd.Text = "+";
            this.BtnAdd.UseVisualStyleBackColor = false;
            this.BtnAdd.Click += new System.EventHandler(this.BtnMthOperation_Click);
            // 
            // Btn3
            // 
            this.Btn3.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.Btn3.ButtonImage = null;
            this.Btn3.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn3.Location = new System.Drawing.Point(176, 469);
            this.Btn3.Margin = new System.Windows.Forms.Padding(4);
            this.Btn3.Name = "Btn3";
            this.Btn3.Size = new System.Drawing.Size(70, 70);
            this.Btn3.TabIndex = 7;
            this.Btn3.Text = "3";
            this.Btn3.UseVisualStyleBackColor = false;
            this.Btn3.Click += new System.EventHandler(this.Btn1_Click);
            // 
            // Btn2
            // 
            this.Btn2.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.Btn2.ButtonImage = null;
            this.Btn2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn2.Location = new System.Drawing.Point(92, 469);
            this.Btn2.Margin = new System.Windows.Forms.Padding(4);
            this.Btn2.Name = "Btn2";
            this.Btn2.Size = new System.Drawing.Size(70, 70);
            this.Btn2.TabIndex = 6;
            this.Btn2.Text = "2";
            this.Btn2.UseVisualStyleBackColor = false;
            this.Btn2.Click += new System.EventHandler(this.Btn1_Click);
            // 
            // Btn1
            // 
            this.Btn1.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.Btn1.ButtonImage = null;
            this.Btn1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn1.Location = new System.Drawing.Point(8, 469);
            this.Btn1.Margin = new System.Windows.Forms.Padding(4);
            this.Btn1.Name = "Btn1";
            this.Btn1.Size = new System.Drawing.Size(70, 70);
            this.Btn1.TabIndex = 5;
            this.Btn1.Text = "1";
            this.Btn1.UseVisualStyleBackColor = false;
            this.Btn1.Click += new System.EventHandler(this.Btn1_Click);
            // 
            // BtnEquals
            // 
            this.BtnEquals.BackColor = System.Drawing.Color.Crimson;
            this.BtnEquals.ButtonImage = null;
            this.BtnEquals.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnEquals.Location = new System.Drawing.Point(258, 546);
            this.BtnEquals.Margin = new System.Windows.Forms.Padding(4);
            this.BtnEquals.Name = "BtnEquals";
            this.BtnEquals.Size = new System.Drawing.Size(70, 70);
            this.BtnEquals.TabIndex = 4;
            this.BtnEquals.Text = "=";
            this.BtnEquals.UseVisualStyleBackColor = false;
            this.BtnEquals.Click += new System.EventHandler(this.BtnEquals_Click);
            // 
            // BtnDesimal
            // 
            this.BtnDesimal.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.BtnDesimal.ButtonImage = null;
            this.BtnDesimal.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnDesimal.Location = new System.Drawing.Point(176, 546);
            this.BtnDesimal.Margin = new System.Windows.Forms.Padding(4);
            this.BtnDesimal.Name = "BtnDesimal";
            this.BtnDesimal.Size = new System.Drawing.Size(70, 70);
            this.BtnDesimal.TabIndex = 3;
            this.BtnDesimal.Text = ".";
            this.BtnDesimal.UseVisualStyleBackColor = false;
            this.BtnDesimal.Click += new System.EventHandler(this.Btn1_Click);
            // 
            // Btn0
            // 
            this.Btn0.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.Btn0.ButtonImage = null;
            this.Btn0.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn0.Location = new System.Drawing.Point(92, 546);
            this.Btn0.Margin = new System.Windows.Forms.Padding(4);
            this.Btn0.Name = "Btn0";
            this.Btn0.Size = new System.Drawing.Size(70, 70);
            this.Btn0.TabIndex = 2;
            this.Btn0.Text = "0";
            this.Btn0.UseVisualStyleBackColor = false;
            this.Btn0.Click += new System.EventHandler(this.Btn1_Click);
            // 
            // BtnPM
            // 
            this.BtnPM.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.BtnPM.ButtonImage = null;
            this.BtnPM.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnPM.Location = new System.Drawing.Point(8, 546);
            this.BtnPM.Margin = new System.Windows.Forms.Padding(4);
            this.BtnPM.Name = "BtnPM";
            this.BtnPM.Size = new System.Drawing.Size(70, 70);
            this.BtnPM.TabIndex = 1;
            this.BtnPM.Text = "+/-";
            this.BtnPM.UseVisualStyleBackColor = false;
            this.BtnPM.Click += new System.EventHandler(this.ButtonPM_Click);
            // 
            // frmBinh
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(338, 641);
            this.Controls.Add(this.PnlHistory);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.TxtDisplay1);
            this.Controls.Add(this.TxtDisplay2);
            this.Controls.Add(this.PnlTitle);
            this.Controls.Add(this.BtnDivision);
            this.Controls.Add(this.BtnPercent);
            this.Controls.Add(this.btnParen);
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
            this.PnlTitle.ResumeLayout(false);
            this.PnlHistory.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Panel PnlTitle;
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
        private CircularButton btnParen;
        private CircularButton BtnPercent;
        private CircularButton BtnDivision;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Panel PnlHistory;
        private System.Windows.Forms.RichTextBox RtBoxDisplayHistory;
        private System.Windows.Forms.Button BtnClearHistory;
    }
}
