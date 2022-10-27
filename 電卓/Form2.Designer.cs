namespace 電卓
{
    partial class TaxRateViewForm
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
            this.txtTaxView = new System.Windows.Forms.TextBox();
            this.btnTaxEdit = new System.Windows.Forms.Button();
            this.btnOK = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtTaxView
            // 
            this.txtTaxView.BackColor = System.Drawing.SystemColors.Window;
            this.txtTaxView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtTaxView.Enabled = false;
            this.txtTaxView.Font = new System.Drawing.Font("MS UI Gothic", 12F);
            this.txtTaxView.Location = new System.Drawing.Point(3, 21);
            this.txtTaxView.Multiline = true;
            this.txtTaxView.Name = "txtTaxView";
            this.txtTaxView.ReadOnly = true;
            this.txtTaxView.Size = new System.Drawing.Size(314, 42);
            this.txtTaxView.TabIndex = 0;
            this.txtTaxView.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnTaxEdit
            // 
            this.btnTaxEdit.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnTaxEdit.Location = new System.Drawing.Point(152, 81);
            this.btnTaxEdit.Name = "btnTaxEdit";
            this.btnTaxEdit.Size = new System.Drawing.Size(75, 23);
            this.btnTaxEdit.TabIndex = 1;
            this.btnTaxEdit.Text = "税率変更";
            this.btnTaxEdit.UseVisualStyleBackColor = true;
            // 
            // btnOK
            // 
            this.btnOK.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnOK.Location = new System.Drawing.Point(233, 81);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(75, 23);
            this.btnOK.TabIndex = 2;
            this.btnOK.Text = "OK";
            this.btnOK.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Window;
            this.panel1.Controls.Add(this.txtTaxView);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(320, 75);
            this.panel1.TabIndex = 3;
            // 
            // TaxRateViewForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(320, 114);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.btnTaxEdit);
            this.Controls.Add(this.panel1);
            this.Name = "TaxRateViewForm";
            this.Text = "税率確認";
            this.Load += new System.EventHandler(this.TaxRateViewForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox txtTaxView;
        private System.Windows.Forms.Button btnTaxEdit;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.Panel panel1;
    }
}