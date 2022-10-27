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
    public partial class TaxRateEditForm : Form
    {
        string inputTax = "0";
        string initiaTax = "";

        public TaxRateEditForm(decimal taxRate)
        {
            InitializeComponent();
            initiaTax = (taxRate * 100).ToString("0");
            txtTaxRate.Text = initiaTax;
        }

        /// <summary>
        /// キーボードからの入力
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void TaxRateEditForm_KeyPress(object sender, KeyPressEventArgs e)
        {
            switch (e.KeyChar)
            {
                case '0':
                case '1':
                case '2':
                case '3':
                case '4':
                case '5':
                case '6':
                case '7':
                case '8':
                case '9':
                    AddText(e.KeyChar.ToString());
                    break;
                default:
                    break;
            }
        }

        /// <summary>
        /// BackSpaceキー、Deleteキーを押したときの処理
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void TaxRateEditForm_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.Back:
                    Delete();
                    break;
                case Keys.Delete:
                    Clear();
                    break;
                default:
                    break;
            }
        }

        /// <summary>
        /// テキスト追加・表示のメソッド
        /// </summary>
        /// <param name="text"></param>
        private void AddText(string text)
        {
            if (inputTax.Length < 6)  //入力は6桁まで
            {
                if (inputTax == "0")
                {
                    inputTax = text;
                }
                else
                {
                    inputTax += text;
                }
            }

            txtTaxRate.Text = inputTax;
        }

        /// <summary>
        /// 一文字削除のメソッド
        /// </summary>
        private void Delete()
        {
            //"x"を"0"にする
            if (inputTax.Length == 1)
            {
                inputTax = "0";
            }
            else  //上記以外の時、後ろの1文字削除
            {
                inputTax = inputTax.Substring(0, inputTax.Length - 1);
            }

            txtTaxRate.Text = inputTax;
        }

        /// <summary>
        /// 入力を初期化するメソッド
        /// </summary>
        private void Clear()
        {
            inputTax = "0";
            txtTaxRate.Text = initiaTax;
        }

        /// <summary>
        ///テキストボックスのプロパティにアクセス
        /// </summary>
        public string TextBoxText
        {
            get
            {
                return txtTaxRate.Text;
            }
            set
            {
                txtTaxRate.Text = value;
            }
        }

    }
}
