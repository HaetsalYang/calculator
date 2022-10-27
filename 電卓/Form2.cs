using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 電卓
{
    public partial class TaxRateViewForm : Form
    {
        decimal taxRate;

        public TaxRateViewForm(decimal taxRate)
        {
            InitializeComponent();
            this.taxRate = taxRate;
        }

        private void TaxRateViewForm_Load(object sender, EventArgs e)
        {
            txtTaxView.Text = "現在の税率は\r\n" + (taxRate * 100).ToString("0") + "％です。";
        }
    }

}
