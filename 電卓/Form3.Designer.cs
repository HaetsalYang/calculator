namespace 電卓
{
    partial class TaxRateEditForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
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
            this.txtTaxRate = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnOK = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtTaxRate
            // 
            this.txtTaxRate.BackColor = System.Drawing.SystemColors.Window;
            this.txtTaxRate.Enabled = false;
            this.txtTaxRate.Font = new System.Drawing.Font("MS UI Gothic", 14F);
            this.txtTaxRate.Location = new System.Drawing.Point(40, 47);
            this.txtTaxRate.Name = "txtTaxRate";
            this.txtTaxRate.ReadOnly = true;
            this.txtTaxRate.Size = new System.Drawing.Size(211, 26);
            this.txtTaxRate.TabIndex = 1;
            this.txtTaxRate.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtTaxRate.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TaxRateEditForm_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("MS UI Gothic", 14F);
            this.label1.Location = new System.Drawing.Point(257, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(28, 19);
            this.label1.TabIndex = 2;
            this.label1.Text = "％";
            // 
            // btnOK
            // 
            this.btnOK.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnOK.Location = new System.Drawing.Point(124, 82);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(75, 23);
            this.btnOK.TabIndex = 3;
            this.btnOK.Text = "変更";
            this.btnOK.UseVisualStyleBackColor = true;
            // 
            // btnCancel
            // 
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(223, 82);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 4;
            this.btnCancel.Text = "キャンセル";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("MS UI Gothic", 10F);
            this.label2.Location = new System.Drawing.Point(12, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(291, 28);
            this.label2.TabIndex = 5;
            this.label2.Text = "変更後の税率を入力し、変更ボタンを押してください\r\n(0～999999の整数)";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // TaxRateEditForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(326, 117);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtTaxRate);
            this.KeyPreview = true;
            this.Name = "TaxRateEditForm";
            this.Text = "税率変更";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TaxRateEditForm_KeyDown);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TaxRateEditForm_KeyPress);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtTaxRate;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Label label2;
    }
}