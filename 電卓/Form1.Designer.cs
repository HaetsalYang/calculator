namespace 電卓
{
    partial class Form1
    {
        /// <summary>
        /// 必要なデザイナー変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージド リソースを破棄する場合は true を指定し、その他の場合は false を指定します。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows フォーム デザイナーで生成されたコード

        /// <summary>
        /// デザイナー サポートに必要なメソッドです。このメソッドの内容を
        /// コード エディターで変更しないでください。
        /// </summary>
        private void InitializeComponent()
        {
            this.txtResultBottom = new System.Windows.Forms.TextBox();
            this.btn1 = new System.Windows.Forms.Button();
            this.btn2 = new System.Windows.Forms.Button();
            this.btn3 = new System.Windows.Forms.Button();
            this.btn4 = new System.Windows.Forms.Button();
            this.btn5 = new System.Windows.Forms.Button();
            this.btn6 = new System.Windows.Forms.Button();
            this.btn7 = new System.Windows.Forms.Button();
            this.btn8 = new System.Windows.Forms.Button();
            this.btn9 = new System.Windows.Forms.Button();
            this.btn0 = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnDel = new System.Windows.Forms.Button();
            this.btnDot = new System.Windows.Forms.Button();
            this.btnCE = new System.Windows.Forms.Button();
            this.btnPlus = new System.Windows.Forms.Button();
            this.btnMns = new System.Windows.Forms.Button();
            this.btnMul = new System.Windows.Forms.Button();
            this.btnDiv = new System.Windows.Forms.Button();
            this.btnPM = new System.Windows.Forms.Button();
            this.btnEqual = new System.Windows.Forms.Button();
            this.txtResultTop = new System.Windows.Forms.TextBox();
            this.btnOnOff = new System.Windows.Forms.Button();
            this.txtMessage = new System.Windows.Forms.TextBox();
            this.btnMC = new System.Windows.Forms.Button();
            this.btnMR = new System.Windows.Forms.Button();
            this.btnMS = new System.Windows.Forms.Button();
            this.btnMPlus = new System.Windows.Forms.Button();
            this.btnMMinus = new System.Windows.Forms.Button();
            this.txtMemory = new System.Windows.Forms.TextBox();
            this.btnAllClear = new System.Windows.Forms.Button();
            this.btnGrandTotal = new System.Windows.Forms.Button();
            this.btnTaxIn = new System.Windows.Forms.Button();
            this.btnTaxEx = new System.Windows.Forms.Button();
            this.btnPercent = new System.Windows.Forms.Button();
            this.txtGT = new System.Windows.Forms.TextBox();
            this.panelDisplay = new System.Windows.Forms.Panel();
            this.txtTax = new System.Windows.Forms.TextBox();
            this.roundSelecter = new System.Windows.Forms.GroupBox();
            this.roundRound = new System.Windows.Forms.RadioButton();
            this.roundCut = new System.Windows.Forms.RadioButton();
            this.roundF = new System.Windows.Forms.RadioButton();
            this.decimalPointSelecter = new System.Windows.Forms.GroupBox();
            this.pointAdd2 = new System.Windows.Forms.RadioButton();
            this.point0 = new System.Windows.Forms.RadioButton();
            this.point1 = new System.Windows.Forms.RadioButton();
            this.point2 = new System.Windows.Forms.RadioButton();
            this.point3 = new System.Windows.Forms.RadioButton();
            this.point4 = new System.Windows.Forms.RadioButton();
            this.btnTaxRate = new System.Windows.Forms.Button();
            this.panelDisplay.SuspendLayout();
            this.roundSelecter.SuspendLayout();
            this.decimalPointSelecter.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtResultBottom
            // 
            this.txtResultBottom.BackColor = System.Drawing.SystemColors.Window;
            this.txtResultBottom.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtResultBottom.Cursor = System.Windows.Forms.Cursors.Default;
            this.txtResultBottom.Enabled = false;
            this.txtResultBottom.Font = new System.Drawing.Font("MS UI Gothic", 14F);
            this.txtResultBottom.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtResultBottom.Location = new System.Drawing.Point(41, 47);
            this.txtResultBottom.Name = "txtResultBottom";
            this.txtResultBottom.ReadOnly = true;
            this.txtResultBottom.Size = new System.Drawing.Size(219, 19);
            this.txtResultBottom.TabIndex = 0;
            this.txtResultBottom.Text = "0";
            this.txtResultBottom.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtResultBottom.WordWrap = false;
            // 
            // btn1
            // 
            this.btn1.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btn1.Location = new System.Drawing.Point(12, 330);
            this.btn1.Name = "btn1";
            this.btn1.Size = new System.Drawing.Size(40, 30);
            this.btn1.TabIndex = 1;
            this.btn1.Text = "1";
            this.btn1.UseVisualStyleBackColor = false;
            this.btn1.Click += new System.EventHandler(this.btn_Click);
            // 
            // btn2
            // 
            this.btn2.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btn2.Location = new System.Drawing.Point(58, 330);
            this.btn2.Name = "btn2";
            this.btn2.Size = new System.Drawing.Size(40, 30);
            this.btn2.TabIndex = 2;
            this.btn2.Text = "2";
            this.btn2.UseVisualStyleBackColor = false;
            this.btn2.Click += new System.EventHandler(this.btn_Click);
            // 
            // btn3
            // 
            this.btn3.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btn3.Location = new System.Drawing.Point(104, 330);
            this.btn3.Name = "btn3";
            this.btn3.Size = new System.Drawing.Size(40, 30);
            this.btn3.TabIndex = 3;
            this.btn3.Text = "3";
            this.btn3.UseVisualStyleBackColor = false;
            this.btn3.Click += new System.EventHandler(this.btn_Click);
            // 
            // btn4
            // 
            this.btn4.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btn4.Location = new System.Drawing.Point(12, 294);
            this.btn4.Name = "btn4";
            this.btn4.Size = new System.Drawing.Size(40, 30);
            this.btn4.TabIndex = 4;
            this.btn4.Text = "4";
            this.btn4.UseVisualStyleBackColor = false;
            this.btn4.Click += new System.EventHandler(this.btn_Click);
            // 
            // btn5
            // 
            this.btn5.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btn5.Location = new System.Drawing.Point(58, 294);
            this.btn5.Name = "btn5";
            this.btn5.Size = new System.Drawing.Size(40, 30);
            this.btn5.TabIndex = 5;
            this.btn5.Text = "5";
            this.btn5.UseVisualStyleBackColor = false;
            this.btn5.Click += new System.EventHandler(this.btn_Click);
            // 
            // btn6
            // 
            this.btn6.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btn6.Location = new System.Drawing.Point(104, 294);
            this.btn6.Name = "btn6";
            this.btn6.Size = new System.Drawing.Size(40, 30);
            this.btn6.TabIndex = 6;
            this.btn6.Text = "6";
            this.btn6.UseVisualStyleBackColor = false;
            this.btn6.Click += new System.EventHandler(this.btn_Click);
            // 
            // btn7
            // 
            this.btn7.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btn7.Location = new System.Drawing.Point(12, 258);
            this.btn7.Name = "btn7";
            this.btn7.Size = new System.Drawing.Size(40, 30);
            this.btn7.TabIndex = 7;
            this.btn7.Text = "7";
            this.btn7.UseVisualStyleBackColor = false;
            this.btn7.Click += new System.EventHandler(this.btn_Click);
            // 
            // btn8
            // 
            this.btn8.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btn8.Location = new System.Drawing.Point(58, 258);
            this.btn8.Name = "btn8";
            this.btn8.Size = new System.Drawing.Size(40, 30);
            this.btn8.TabIndex = 8;
            this.btn8.Text = "8";
            this.btn8.UseVisualStyleBackColor = false;
            this.btn8.Click += new System.EventHandler(this.btn_Click);
            // 
            // btn9
            // 
            this.btn9.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btn9.Location = new System.Drawing.Point(104, 258);
            this.btn9.Name = "btn9";
            this.btn9.Size = new System.Drawing.Size(40, 30);
            this.btn9.TabIndex = 9;
            this.btn9.Text = "9";
            this.btn9.UseVisualStyleBackColor = false;
            this.btn9.Click += new System.EventHandler(this.btn_Click);
            // 
            // btn0
            // 
            this.btn0.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btn0.Location = new System.Drawing.Point(12, 366);
            this.btn0.Name = "btn0";
            this.btn0.Size = new System.Drawing.Size(86, 30);
            this.btn0.TabIndex = 10;
            this.btn0.Text = "0";
            this.btn0.UseVisualStyleBackColor = false;
            this.btn0.Click += new System.EventHandler(this.btn_Click);
            // 
            // btnClear
            // 
            this.btnClear.BackColor = System.Drawing.Color.Beige;
            this.btnClear.Location = new System.Drawing.Point(104, 222);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(40, 30);
            this.btnClear.TabIndex = 11;
            this.btnClear.Text = "C";
            this.btnClear.UseVisualStyleBackColor = false;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnDel
            // 
            this.btnDel.BackColor = System.Drawing.Color.Beige;
            this.btnDel.Location = new System.Drawing.Point(12, 222);
            this.btnDel.Name = "btnDel";
            this.btnDel.Size = new System.Drawing.Size(40, 30);
            this.btnDel.TabIndex = 12;
            this.btnDel.Text = "←";
            this.btnDel.UseVisualStyleBackColor = false;
            this.btnDel.Click += new System.EventHandler(this.btnDel_Click);
            // 
            // btnDot
            // 
            this.btnDot.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnDot.Font = new System.Drawing.Font("MS UI Gothic", 13F);
            this.btnDot.Location = new System.Drawing.Point(104, 366);
            this.btnDot.Name = "btnDot";
            this.btnDot.Size = new System.Drawing.Size(40, 30);
            this.btnDot.TabIndex = 13;
            this.btnDot.Text = ".";
            this.btnDot.UseVisualStyleBackColor = false;
            this.btnDot.Click += new System.EventHandler(this.btnDot_Click);
            // 
            // btnCE
            // 
            this.btnCE.BackColor = System.Drawing.Color.Beige;
            this.btnCE.Location = new System.Drawing.Point(58, 222);
            this.btnCE.Name = "btnCE";
            this.btnCE.Size = new System.Drawing.Size(40, 30);
            this.btnCE.TabIndex = 14;
            this.btnCE.Text = "CE";
            this.btnCE.UseVisualStyleBackColor = false;
            this.btnCE.Click += new System.EventHandler(this.btnCE_Click);
            // 
            // btnPlus
            // 
            this.btnPlus.BackColor = System.Drawing.Color.Silver;
            this.btnPlus.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnPlus.Location = new System.Drawing.Point(150, 366);
            this.btnPlus.Name = "btnPlus";
            this.btnPlus.Size = new System.Drawing.Size(40, 30);
            this.btnPlus.TabIndex = 15;
            this.btnPlus.Text = "+";
            this.btnPlus.UseVisualStyleBackColor = false;
            this.btnPlus.Click += new System.EventHandler(this.btnCalc_Click);
            // 
            // btnMns
            // 
            this.btnMns.BackColor = System.Drawing.Color.Silver;
            this.btnMns.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnMns.Location = new System.Drawing.Point(150, 330);
            this.btnMns.Name = "btnMns";
            this.btnMns.Size = new System.Drawing.Size(40, 30);
            this.btnMns.TabIndex = 16;
            this.btnMns.Text = "-";
            this.btnMns.UseVisualStyleBackColor = false;
            this.btnMns.Click += new System.EventHandler(this.btnCalc_Click);
            // 
            // btnMul
            // 
            this.btnMul.BackColor = System.Drawing.Color.Silver;
            this.btnMul.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnMul.Location = new System.Drawing.Point(150, 294);
            this.btnMul.Name = "btnMul";
            this.btnMul.Size = new System.Drawing.Size(40, 30);
            this.btnMul.TabIndex = 17;
            this.btnMul.Text = "*";
            this.btnMul.UseVisualStyleBackColor = false;
            this.btnMul.Click += new System.EventHandler(this.btnCalc_Click);
            // 
            // btnDiv
            // 
            this.btnDiv.BackColor = System.Drawing.Color.Silver;
            this.btnDiv.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnDiv.Location = new System.Drawing.Point(150, 258);
            this.btnDiv.Name = "btnDiv";
            this.btnDiv.Size = new System.Drawing.Size(40, 30);
            this.btnDiv.TabIndex = 18;
            this.btnDiv.Text = "/";
            this.btnDiv.UseVisualStyleBackColor = false;
            this.btnDiv.Click += new System.EventHandler(this.btnCalc_Click);
            // 
            // btnPM
            // 
            this.btnPM.BackColor = System.Drawing.Color.Silver;
            this.btnPM.Location = new System.Drawing.Point(150, 222);
            this.btnPM.Name = "btnPM";
            this.btnPM.Size = new System.Drawing.Size(40, 30);
            this.btnPM.TabIndex = 19;
            this.btnPM.Text = "±";
            this.btnPM.UseVisualStyleBackColor = false;
            this.btnPM.Click += new System.EventHandler(this.btnPM_Click);
            // 
            // btnEqual
            // 
            this.btnEqual.BackColor = System.Drawing.Color.Silver;
            this.btnEqual.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnEqual.Location = new System.Drawing.Point(196, 330);
            this.btnEqual.Name = "btnEqual";
            this.btnEqual.Size = new System.Drawing.Size(40, 66);
            this.btnEqual.TabIndex = 20;
            this.btnEqual.Text = "=";
            this.btnEqual.UseVisualStyleBackColor = false;
            this.btnEqual.Click += new System.EventHandler(this.btnEqual_Click);
            // 
            // txtResultTop
            // 
            this.txtResultTop.BackColor = System.Drawing.SystemColors.Window;
            this.txtResultTop.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtResultTop.Cursor = System.Windows.Forms.Cursors.Default;
            this.txtResultTop.Enabled = false;
            this.txtResultTop.Font = new System.Drawing.Font("MS UI Gothic", 12F);
            this.txtResultTop.Location = new System.Drawing.Point(4, 6);
            this.txtResultTop.Name = "txtResultTop";
            this.txtResultTop.ReadOnly = true;
            this.txtResultTop.Size = new System.Drawing.Size(257, 16);
            this.txtResultTop.TabIndex = 22;
            this.txtResultTop.Text = "\r\n";
            this.txtResultTop.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // btnOnOff
            // 
            this.btnOnOff.BackColor = System.Drawing.Color.LightCoral;
            this.btnOnOff.Font = new System.Drawing.Font("MS UI Gothic", 7F);
            this.btnOnOff.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnOnOff.Location = new System.Drawing.Point(242, 10);
            this.btnOnOff.Name = "btnOnOff";
            this.btnOnOff.Size = new System.Drawing.Size(40, 30);
            this.btnOnOff.TabIndex = 23;
            this.btnOnOff.Text = "ON/\r\nOFF";
            this.btnOnOff.UseVisualStyleBackColor = false;
            this.btnOnOff.Click += new System.EventHandler(this.btnOnOff_Click);
            // 
            // txtMessage
            // 
            this.txtMessage.BackColor = System.Drawing.SystemColors.Window;
            this.txtMessage.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtMessage.Enabled = false;
            this.txtMessage.Font = new System.Drawing.Font("MS UI Gothic", 12F);
            this.txtMessage.Location = new System.Drawing.Point(66, 28);
            this.txtMessage.Name = "txtMessage";
            this.txtMessage.ReadOnly = true;
            this.txtMessage.Size = new System.Drawing.Size(195, 16);
            this.txtMessage.TabIndex = 24;
            this.txtMessage.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // btnMC
            // 
            this.btnMC.BackColor = System.Drawing.Color.LightSteelBlue;
            this.btnMC.Location = new System.Drawing.Point(242, 222);
            this.btnMC.Name = "btnMC";
            this.btnMC.Size = new System.Drawing.Size(40, 30);
            this.btnMC.TabIndex = 25;
            this.btnMC.Text = "MC";
            this.btnMC.UseVisualStyleBackColor = false;
            this.btnMC.Click += new System.EventHandler(this.btnMC_Click);
            // 
            // btnMR
            // 
            this.btnMR.BackColor = System.Drawing.Color.LightSteelBlue;
            this.btnMR.Location = new System.Drawing.Point(242, 258);
            this.btnMR.Name = "btnMR";
            this.btnMR.Size = new System.Drawing.Size(40, 30);
            this.btnMR.TabIndex = 26;
            this.btnMR.Text = "MR";
            this.btnMR.UseVisualStyleBackColor = false;
            this.btnMR.Click += new System.EventHandler(this.btnMR_Click);
            // 
            // btnMS
            // 
            this.btnMS.BackColor = System.Drawing.Color.LightSteelBlue;
            this.btnMS.Location = new System.Drawing.Point(242, 294);
            this.btnMS.Name = "btnMS";
            this.btnMS.Size = new System.Drawing.Size(40, 30);
            this.btnMS.TabIndex = 27;
            this.btnMS.Text = "MS";
            this.btnMS.UseVisualStyleBackColor = false;
            this.btnMS.Click += new System.EventHandler(this.btnMS_Click);
            // 
            // btnMPlus
            // 
            this.btnMPlus.BackColor = System.Drawing.Color.LightSteelBlue;
            this.btnMPlus.Location = new System.Drawing.Point(242, 330);
            this.btnMPlus.Name = "btnMPlus";
            this.btnMPlus.Size = new System.Drawing.Size(40, 30);
            this.btnMPlus.TabIndex = 28;
            this.btnMPlus.Text = "M+";
            this.btnMPlus.UseVisualStyleBackColor = false;
            this.btnMPlus.Click += new System.EventHandler(this.btnMPlus_Click);
            // 
            // btnMMinus
            // 
            this.btnMMinus.BackColor = System.Drawing.Color.LightSteelBlue;
            this.btnMMinus.Location = new System.Drawing.Point(242, 366);
            this.btnMMinus.Name = "btnMMinus";
            this.btnMMinus.Size = new System.Drawing.Size(40, 30);
            this.btnMMinus.TabIndex = 29;
            this.btnMMinus.Text = "M-";
            this.btnMMinus.UseVisualStyleBackColor = false;
            this.btnMMinus.Click += new System.EventHandler(this.btnMMinus_Click);
            // 
            // txtMemory
            // 
            this.txtMemory.BackColor = System.Drawing.SystemColors.Window;
            this.txtMemory.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtMemory.Cursor = System.Windows.Forms.Cursors.Default;
            this.txtMemory.Enabled = false;
            this.txtMemory.Font = new System.Drawing.Font("MS UI Gothic", 11F);
            this.txtMemory.Location = new System.Drawing.Point(3, 28);
            this.txtMemory.Name = "txtMemory";
            this.txtMemory.ReadOnly = true;
            this.txtMemory.Size = new System.Drawing.Size(25, 15);
            this.txtMemory.TabIndex = 30;
            this.txtMemory.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnAllClear
            // 
            this.btnAllClear.BackColor = System.Drawing.Color.LightCoral;
            this.btnAllClear.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnAllClear.Location = new System.Drawing.Point(242, 186);
            this.btnAllClear.Name = "btnAllClear";
            this.btnAllClear.Size = new System.Drawing.Size(40, 30);
            this.btnAllClear.TabIndex = 31;
            this.btnAllClear.Text = "AC";
            this.btnAllClear.UseVisualStyleBackColor = false;
            this.btnAllClear.Click += new System.EventHandler(this.btnAllClear_Click);
            // 
            // btnGrandTotal
            // 
            this.btnGrandTotal.BackColor = System.Drawing.Color.LightSlateGray;
            this.btnGrandTotal.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnGrandTotal.Location = new System.Drawing.Point(196, 258);
            this.btnGrandTotal.Name = "btnGrandTotal";
            this.btnGrandTotal.Size = new System.Drawing.Size(40, 66);
            this.btnGrandTotal.TabIndex = 32;
            this.btnGrandTotal.Text = "GT";
            this.btnGrandTotal.UseVisualStyleBackColor = false;
            this.btnGrandTotal.Click += new System.EventHandler(this.btnGrandTotal_Click);
            // 
            // btnTaxIn
            // 
            this.btnTaxIn.BackColor = System.Drawing.Color.MediumAquamarine;
            this.btnTaxIn.Font = new System.Drawing.Font("MS UI Gothic", 9F);
            this.btnTaxIn.Location = new System.Drawing.Point(12, 186);
            this.btnTaxIn.Name = "btnTaxIn";
            this.btnTaxIn.Size = new System.Drawing.Size(40, 30);
            this.btnTaxIn.TabIndex = 33;
            this.btnTaxIn.Text = "税込";
            this.btnTaxIn.UseVisualStyleBackColor = false;
            this.btnTaxIn.Click += new System.EventHandler(this.btnTax_Click);
            // 
            // btnTaxEx
            // 
            this.btnTaxEx.BackColor = System.Drawing.Color.MediumAquamarine;
            this.btnTaxEx.Location = new System.Drawing.Point(58, 186);
            this.btnTaxEx.Name = "btnTaxEx";
            this.btnTaxEx.Size = new System.Drawing.Size(40, 30);
            this.btnTaxEx.TabIndex = 34;
            this.btnTaxEx.Text = "税抜";
            this.btnTaxEx.UseVisualStyleBackColor = false;
            this.btnTaxEx.Click += new System.EventHandler(this.btnTax_Click);
            // 
            // btnPercent
            // 
            this.btnPercent.BackColor = System.Drawing.Color.Silver;
            this.btnPercent.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnPercent.Location = new System.Drawing.Point(196, 222);
            this.btnPercent.Name = "btnPercent";
            this.btnPercent.Size = new System.Drawing.Size(40, 30);
            this.btnPercent.TabIndex = 35;
            this.btnPercent.Text = "％";
            this.btnPercent.UseVisualStyleBackColor = false;
            this.btnPercent.Click += new System.EventHandler(this.btnPercent_Click);
            // 
            // txtGT
            // 
            this.txtGT.BackColor = System.Drawing.SystemColors.Window;
            this.txtGT.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtGT.Cursor = System.Windows.Forms.Cursors.Default;
            this.txtGT.Enabled = false;
            this.txtGT.Font = new System.Drawing.Font("MS UI Gothic", 11F);
            this.txtGT.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtGT.Location = new System.Drawing.Point(29, 28);
            this.txtGT.Name = "txtGT";
            this.txtGT.ReadOnly = true;
            this.txtGT.Size = new System.Drawing.Size(32, 15);
            this.txtGT.TabIndex = 36;
            this.txtGT.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // panelDisplay
            // 
            this.panelDisplay.BackColor = System.Drawing.SystemColors.Window;
            this.panelDisplay.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panelDisplay.Controls.Add(this.txtTax);
            this.panelDisplay.Controls.Add(this.txtGT);
            this.panelDisplay.Controls.Add(this.txtResultTop);
            this.panelDisplay.Controls.Add(this.txtMessage);
            this.panelDisplay.Controls.Add(this.txtResultBottom);
            this.panelDisplay.Controls.Add(this.txtMemory);
            this.panelDisplay.Enabled = false;
            this.panelDisplay.Location = new System.Drawing.Point(12, 46);
            this.panelDisplay.Name = "panelDisplay";
            this.panelDisplay.Size = new System.Drawing.Size(270, 75);
            this.panelDisplay.TabIndex = 37;
            // 
            // txtTax
            // 
            this.txtTax.BackColor = System.Drawing.SystemColors.Window;
            this.txtTax.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtTax.Cursor = System.Windows.Forms.Cursors.Default;
            this.txtTax.Enabled = false;
            this.txtTax.Font = new System.Drawing.Font("MS UI Gothic", 11F);
            this.txtTax.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtTax.Location = new System.Drawing.Point(3, 51);
            this.txtTax.Name = "txtTax";
            this.txtTax.ReadOnly = true;
            this.txtTax.Size = new System.Drawing.Size(32, 15);
            this.txtTax.TabIndex = 37;
            // 
            // roundSelecter
            // 
            this.roundSelecter.Controls.Add(this.roundRound);
            this.roundSelecter.Controls.Add(this.roundCut);
            this.roundSelecter.Controls.Add(this.roundF);
            this.roundSelecter.Location = new System.Drawing.Point(12, 127);
            this.roundSelecter.Name = "roundSelecter";
            this.roundSelecter.Size = new System.Drawing.Size(95, 53);
            this.roundSelecter.TabIndex = 38;
            this.roundSelecter.TabStop = false;
            this.roundSelecter.Text = "ラウンド";
            // 
            // roundRound
            // 
            this.roundRound.AutoSize = true;
            this.roundRound.CheckAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.roundRound.Location = new System.Drawing.Point(64, 17);
            this.roundRound.Name = "roundRound";
            this.roundRound.Size = new System.Drawing.Size(27, 29);
            this.roundRound.TabIndex = 2;
            this.roundRound.Text = "5/4";
            this.roundRound.UseVisualStyleBackColor = true;
            this.roundRound.CheckedChanged += new System.EventHandler(this.round_CheckedChanged);
            // 
            // roundCut
            // 
            this.roundCut.AutoSize = true;
            this.roundCut.CheckAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.roundCut.Location = new System.Drawing.Point(31, 17);
            this.roundCut.Name = "roundCut";
            this.roundCut.Size = new System.Drawing.Size(32, 29);
            this.roundCut.TabIndex = 1;
            this.roundCut.Text = "CUT";
            this.roundCut.UseVisualStyleBackColor = true;
            this.roundCut.CheckedChanged += new System.EventHandler(this.round_CheckedChanged);
            // 
            // roundF
            // 
            this.roundF.AutoSize = true;
            this.roundF.CheckAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.roundF.Checked = true;
            this.roundF.Location = new System.Drawing.Point(9, 17);
            this.roundF.Name = "roundF";
            this.roundF.Size = new System.Drawing.Size(16, 29);
            this.roundF.TabIndex = 0;
            this.roundF.TabStop = true;
            this.roundF.Text = "F";
            this.roundF.UseVisualStyleBackColor = true;
            this.roundF.CheckedChanged += new System.EventHandler(this.round_CheckedChanged);
            // 
            // decimalPointSelecter
            // 
            this.decimalPointSelecter.Controls.Add(this.pointAdd2);
            this.decimalPointSelecter.Controls.Add(this.point0);
            this.decimalPointSelecter.Controls.Add(this.point1);
            this.decimalPointSelecter.Controls.Add(this.point2);
            this.decimalPointSelecter.Controls.Add(this.point3);
            this.decimalPointSelecter.Controls.Add(this.point4);
            this.decimalPointSelecter.Enabled = false;
            this.decimalPointSelecter.Location = new System.Drawing.Point(114, 127);
            this.decimalPointSelecter.Name = "decimalPointSelecter";
            this.decimalPointSelecter.Size = new System.Drawing.Size(167, 53);
            this.decimalPointSelecter.TabIndex = 39;
            this.decimalPointSelecter.TabStop = false;
            this.decimalPointSelecter.Text = "小数点";
            // 
            // pointAdd2
            // 
            this.pointAdd2.AutoSize = true;
            this.pointAdd2.CheckAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.pointAdd2.Font = new System.Drawing.Font("MS UI Gothic", 9F);
            this.pointAdd2.Location = new System.Drawing.Point(125, 17);
            this.pointAdd2.Margin = new System.Windows.Forms.Padding(0);
            this.pointAdd2.Name = "pointAdd2";
            this.pointAdd2.Size = new System.Drawing.Size(39, 29);
            this.pointAdd2.TabIndex = 5;
            this.pointAdd2.Text = "ADD2";
            this.pointAdd2.UseVisualStyleBackColor = true;
            // 
            // point0
            // 
            this.point0.AutoSize = true;
            this.point0.CheckAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.point0.Location = new System.Drawing.Point(106, 17);
            this.point0.Margin = new System.Windows.Forms.Padding(5, 3, 0, 3);
            this.point0.Name = "point0";
            this.point0.Size = new System.Drawing.Size(15, 29);
            this.point0.TabIndex = 4;
            this.point0.Text = "0";
            this.point0.UseVisualStyleBackColor = true;
            // 
            // point1
            // 
            this.point1.AutoSize = true;
            this.point1.CheckAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.point1.Location = new System.Drawing.Point(81, 17);
            this.point1.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.point1.Name = "point1";
            this.point1.Size = new System.Drawing.Size(15, 29);
            this.point1.TabIndex = 3;
            this.point1.Text = "1";
            this.point1.UseVisualStyleBackColor = true;
            // 
            // point2
            // 
            this.point2.AutoSize = true;
            this.point2.CheckAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.point2.Location = new System.Drawing.Point(56, 17);
            this.point2.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.point2.Name = "point2";
            this.point2.Size = new System.Drawing.Size(15, 29);
            this.point2.TabIndex = 2;
            this.point2.Text = "2";
            this.point2.UseVisualStyleBackColor = true;
            // 
            // point3
            // 
            this.point3.AutoSize = true;
            this.point3.CheckAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.point3.Location = new System.Drawing.Point(31, 17);
            this.point3.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.point3.Name = "point3";
            this.point3.Size = new System.Drawing.Size(15, 29);
            this.point3.TabIndex = 1;
            this.point3.Text = "3";
            this.point3.UseVisualStyleBackColor = true;
            // 
            // point4
            // 
            this.point4.AutoSize = true;
            this.point4.CheckAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.point4.Location = new System.Drawing.Point(6, 17);
            this.point4.Margin = new System.Windows.Forms.Padding(3, 3, 5, 3);
            this.point4.Name = "point4";
            this.point4.Size = new System.Drawing.Size(15, 29);
            this.point4.TabIndex = 0;
            this.point4.Text = "4";
            this.point4.UseVisualStyleBackColor = true;
            // 
            // btnTaxRate
            // 
            this.btnTaxRate.BackColor = System.Drawing.Color.MediumAquamarine;
            this.btnTaxRate.Location = new System.Drawing.Point(104, 186);
            this.btnTaxRate.Name = "btnTaxRate";
            this.btnTaxRate.Size = new System.Drawing.Size(40, 30);
            this.btnTaxRate.TabIndex = 40;
            this.btnTaxRate.Text = "税率";
            this.btnTaxRate.UseVisualStyleBackColor = false;
            this.btnTaxRate.Click += new System.EventHandler(this.btnTaxRate_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(296, 409);
            this.Controls.Add(this.btnTaxRate);
            this.Controls.Add(this.decimalPointSelecter);
            this.Controls.Add(this.roundSelecter);
            this.Controls.Add(this.btnPercent);
            this.Controls.Add(this.btnTaxEx);
            this.Controls.Add(this.btnTaxIn);
            this.Controls.Add(this.btnGrandTotal);
            this.Controls.Add(this.btnAllClear);
            this.Controls.Add(this.btnMMinus);
            this.Controls.Add(this.btnMPlus);
            this.Controls.Add(this.btnMS);
            this.Controls.Add(this.btnMR);
            this.Controls.Add(this.btnMC);
            this.Controls.Add(this.btnOnOff);
            this.Controls.Add(this.btnEqual);
            this.Controls.Add(this.btnPM);
            this.Controls.Add(this.btnDiv);
            this.Controls.Add(this.btnMul);
            this.Controls.Add(this.btnMns);
            this.Controls.Add(this.btnPlus);
            this.Controls.Add(this.btnCE);
            this.Controls.Add(this.btnDot);
            this.Controls.Add(this.btnDel);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btn0);
            this.Controls.Add(this.btn9);
            this.Controls.Add(this.btn8);
            this.Controls.Add(this.btn7);
            this.Controls.Add(this.btn6);
            this.Controls.Add(this.btn5);
            this.Controls.Add(this.btn4);
            this.Controls.Add(this.btn3);
            this.Controls.Add(this.btn2);
            this.Controls.Add(this.btn1);
            this.Controls.Add(this.panelDisplay);
            this.KeyPreview = true;
            this.Name = "Form1";
            this.Text = "電卓";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Form1_KeyPress);
            this.panelDisplay.ResumeLayout(false);
            this.panelDisplay.PerformLayout();
            this.roundSelecter.ResumeLayout(false);
            this.roundSelecter.PerformLayout();
            this.decimalPointSelecter.ResumeLayout(false);
            this.decimalPointSelecter.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox txtResultBottom;
        private System.Windows.Forms.Button btn1;
        private System.Windows.Forms.Button btn2;
        private System.Windows.Forms.Button btn3;
        private System.Windows.Forms.Button btn4;
        private System.Windows.Forms.Button btn5;
        private System.Windows.Forms.Button btn6;
        private System.Windows.Forms.Button btn7;
        private System.Windows.Forms.Button btn8;
        private System.Windows.Forms.Button btn9;
        private System.Windows.Forms.Button btn0;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnDel;
        private System.Windows.Forms.Button btnDot;
        private System.Windows.Forms.Button btnCE;
        private System.Windows.Forms.Button btnPlus;
        private System.Windows.Forms.Button btnMns;
        private System.Windows.Forms.Button btnMul;
        private System.Windows.Forms.Button btnDiv;
        private System.Windows.Forms.Button btnPM;
        private System.Windows.Forms.Button btnEqual;
        private System.Windows.Forms.TextBox txtResultTop;
        private System.Windows.Forms.Button btnOnOff;
        private System.Windows.Forms.TextBox txtMessage;
        private System.Windows.Forms.Button btnMC;
        private System.Windows.Forms.Button btnMR;
        private System.Windows.Forms.Button btnMS;
        private System.Windows.Forms.Button btnMPlus;
        private System.Windows.Forms.Button btnMMinus;
        private System.Windows.Forms.TextBox txtMemory;
        private System.Windows.Forms.Button btnAllClear;
        private System.Windows.Forms.Button btnGrandTotal;
        private System.Windows.Forms.Button btnTaxIn;
        private System.Windows.Forms.Button btnTaxEx;
        private System.Windows.Forms.Button btnPercent;
        private System.Windows.Forms.TextBox txtGT;
        private System.Windows.Forms.Panel panelDisplay;
        private System.Windows.Forms.GroupBox roundSelecter;
        private System.Windows.Forms.RadioButton roundRound;
        private System.Windows.Forms.RadioButton roundCut;
        private System.Windows.Forms.RadioButton roundF;
        private System.Windows.Forms.GroupBox decimalPointSelecter;
        private System.Windows.Forms.RadioButton point4;
        private System.Windows.Forms.RadioButton pointAdd2;
        private System.Windows.Forms.RadioButton point0;
        private System.Windows.Forms.RadioButton point1;
        private System.Windows.Forms.RadioButton point2;
        private System.Windows.Forms.RadioButton point3;
        private System.Windows.Forms.TextBox txtTax;
        private System.Windows.Forms.Button btnTaxRate;
    }
}

