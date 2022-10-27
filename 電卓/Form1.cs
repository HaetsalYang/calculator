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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }

        #region 変数

        string inputNum = "0";  //新しく入力された数
        string outputBottom = "0";  //桁区切りを加味して画面下部に表示される数
        string outputTop = "";  //履歴など画面上に表示する用の数
        string calcSym = "";  //直前に押された計算ボタン
        string constant = "0";  //定数
        string decimalPoint = "";  //小数点セレクターで設定された値

        decimal result = 0;  //計算結果
        decimal resultTotal = 0;  //計算結果の合計
        decimal memory = 0;  //メモリーに記憶された数
        internal static decimal taxRate = (decimal)0.1;  //税率

        decimal[] taxArray = new decimal[2];  //[0]に税込みか税抜き、[1]に税の数値が入る

        List<decimal> resultList = new List<decimal>();  //計算結果を保存していくリスト

        bool isCalcBtnOn = false;  //計算ボタンを押しているかどうか
        bool isEqualBtnOn = false;  //イコールボタンを押した後かどうか
        bool isMemoryBtnOn = false;  //メモリーボタンが押された後かどうか
        bool isGTBtnOn = false;  //GTボタンが押された後かどうか
        bool isPMBtnOn = false;  //±ボタンが押された後かどうか
        bool isAdd2Used = false;  //ADD2モードで小数点が追加されたかどうか
        bool isPercentBtnOn = false;  //パーセントボタンが押されているかどうか
        bool isTaxInBtnOn = false;  //税込みボタンが押されているかどうか
        bool isTaxIn = false;  //税込表示かどうか
        bool isTaxExBtnOn = false;  //税抜きボタンが押されているかどうか
        bool isTaxEx = false;  //税込かどうか
        bool isError = false;  //エラーが表示されているかどうか
        bool isMemoryError = false;  //メモリー内でエラーが起きているかどうか
        bool isPowerOn = true;  //電源オンかどうか

        #endregion

        #region イベントハンドラ

        #region ボタン

        #region 入力ボタン

        /// <summary>
        /// 数字ボタンをクリックしたときの処理
        /// senderをButton型にして、Textメソッドで文字列に変換。AddTextメソッドに入れる。
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_Click(object sender, EventArgs e)
        {
            AddNum(((Button)sender).Text);
        }

        /// <summary>
        /// btnDotをクリックした時の処理
        /// AddDotメソッドを使用
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnDot_Click(object sender, EventArgs e)
        {
            AddDot();
        }

        #endregion

        #region 計算ボタン

        /// <summary>
        /// 演算記号を押したときCalcメソッドを呼び出す。
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnCalc_Click(object sender, EventArgs e)
        {
                CalcBtn(((Button)sender).Text);
        }

        /// <summary>
        /// イコールボタンを押したときにEqualメソッドを呼び出す
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnEqual_Click(object sender, EventArgs e)
        {
            Equal();
        }

        /// <summary>
        /// GTボタンを押したときの処理
        /// GrandTotalメソッドを呼び出す
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnGrandTotal_Click(object sender, EventArgs e)
        {
            GrandTotal();
        }

        #endregion

        #region メモリーボタン
        private void btnMC_Click(object sender, EventArgs e)
        {
            MemoryClear();
        }

        private void btnMR_Click(object sender, EventArgs e)
        {
            MemoryRecall();
        }

        private void btnMS_Click(object sender, EventArgs e)
        {
            MemoryStore();
        }

        private void btnMPlus_Click(object sender, EventArgs e)
        {
            MemoryPlus();
        }

        private void btnMMinus_Click(object sender, EventArgs e)
        {
            MemoryMinus();
        }

        #endregion

        #region 消費税系ボタン

        /// <summary>
        /// 税込みボタンを押した時の処理
        /// TaxIncludedメソッドを呼び出す
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnTax_Click(object sender, EventArgs e)
        {
            TaxBtn(((Button)sender).Text);
        }

        #endregion

        #region 削除系ボタン

        /// <summary>
        /// ACボタンをクリックした時の処理
        /// AllClearメソッドを呼び出す。
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAllClear_Click(object sender, EventArgs e)
        {
            AllClear();
        }

        /// <summary>
        /// Cボタンをクリックした時の処理
        /// Clearメソッドを呼び出す
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnClear_Click(object sender, EventArgs e)
        {
            Clear();
        }

        /// <summary>
        /// CEボタンを押したときの処理
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnCE_Click(object sender, EventArgs e)
        {
            ClearEntry();
        }

        /// <summary>
        /// 削除ボタンをクリックした場合の処理
        /// Deleteメソッド呼び出し
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnDel_Click(object sender, EventArgs e)
        {
            Delete();
        }

        #endregion

        /// <summary>
        /// ラジオボタンのメソッド
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void round_CheckedChanged(object sender, EventArgs e)
        {
            if (((RadioButton)sender).Text == "F")
            {
                decimalPointSelecter.Enabled = false;

                foreach (RadioButton item in decimalPointSelecter.Controls)
                {
                    item.Checked = false;
                }
            }
            else
            {
                decimalPointSelecter.Enabled = true;
                point0.Checked = true;
            }
        }

        /// <summary>
        /// 符号を入れ替えるボタンをクリックした時の処理
        /// SetPlusMinusメソッドを呼び出す
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnPM_Click(object sender, EventArgs e)
        {
            ChangePlusMinus();
        }

        /// <summary>
        /// %ボタンをクリックした時の処理
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnPercent_Click(object sender, EventArgs e)
        {
            Percent();
        }

        /// <summary>
        /// 電源ボタンをクリックした時の処理
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnOnOff_Click(object sender, EventArgs e)
        {
            PowerOnOff();
        }

        #endregion

        #region キーボード

        /// <summary>
        /// キーボードからの数字・計算記号の入力を受け付ける
        /// KeyCharで入力された文字を取得、ToStringで文字列にしてAddTextメソッドに入れる。
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Form1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!isPowerOn)  //電源オフ時は無効
            {
                return;
            }

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
                    AddNum(e.KeyChar.ToString());
                    break;
                case '+':
                case '-':
                case '/':
                case '*':
                    CalcBtn(e.KeyChar.ToString());
                    break;
                case '=':
                    Equal();
                    break;
                case '%':
                    Percent();
                    break;
                default:
                    break;
            }
        }

        /// <summary>
        /// キーボードでEsc、Delete、BackSpace、ピリオド、F9を入力した場合の処理をボタンクリック時の処理と対応させる
        /// キーボードでメモリー機能を呼び出せる。
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (!isPowerOn)  //電源オフ時は無効
            {
                return;
            }

            switch (e.KeyCode)
            {
                case Keys.Escape:
                    Clear();
                    break;
                case Keys.Delete:
                    ClearEntry();
                    break;
                case Keys.Back:
                    Delete();
                    break;
                case Keys.OemPeriod:
                case Keys.Decimal:
                    AddDot();
                    break;
                case Keys.F9:
                    ChangePlusMinus();
                    break;
                default:
                    break;
            }

            //メモリー機能に関する部分
            switch (e.KeyData)
            {
                case (Keys.Control | Keys.L):
                    MemoryClear();
                    break;
                case (Keys.Control | Keys.R):
                    MemoryRecall();
                    break;
                case (Keys.Control | Keys.M):
                    MemoryStore();
                    break;
                case (Keys.Control | Keys.P):
                    MemoryPlus();
                    break;
                case (Keys.Control | Keys.Q):
                    MemoryMinus();
                    break;
            }
        }

        /// <summary>
        /// 電源オフ時にSpaceキーを押すと電源オンにする
        /// Enterキーが押されたときにはEqualメソッドが呼び出されるようにしておく
        /// </summary>
        /// <param name="keyData"></param>
        /// <returns></returns>
        protected override bool ProcessDialogKey(Keys keyData)
        {
            switch ((keyData & Keys.KeyCode))
            {
                case Keys.Space:  //電源オフ時にSpaceキーを押すと電源が入る。
                    if (!isPowerOn)
                    {
                        PowerOnOff();
                        btn0.Focus();
                        return true;
                    }

                    return true;
                case Keys.Enter:  //電源オフ時は無効。電源オン時はEqualメソッドが呼び出される。
                    if (!isPowerOn)
                    {
                        return true;
                    }

                    Equal();

                    return true;
            }

            return base.ProcessDialogKey(keyData);
        }

        #endregion

        #endregion

        #region メソッド

        #region 表示

        /// <summary>
        /// stringを受け取りディスプレイへ表示するメソッド
        /// ※桁区切りをつけたものを入れると正しく表示できない
        /// inputの表示：下部に入力した数値を表示
        /// 計算式の表示：上部に計算式を表示
        /// 計算結果の表示：少数部分が有効桁数を超える場合、有効桁数を超えるところで切り捨て。
        /// 計算結果の表示：整数部分が有効桁数を超える場合、指数表示
        /// </summary>
        /// <param name="number"></param>
        private void PrtTxtRoundFull(string number)
        {
            if ((CountTxt(number)) > 10 && !number.Contains("e"))  //inputNumの数字が11桁以上場合の処理、指数表示したものが誤って入ってこないようにしておく
            {
                ShapeNum10Digit(ref number);
            }

            PrtCommaTxt(number);
        }

        /// <summary>
        /// stringを受け取りディスプレイへ表示するメソッド
        /// ※ラウンドセレクター・小数点セレクターを考慮
        /// </summary>
        /// <param name="number"></param>
        private void PrtTxtRound(string number)
        {
            Round(ref number);  //まず、端数処理を行う

            if (CountTxt(number) > 10 && !number.Contains("e"))  //10桁を超える場合、指数表示、既に指数表示されたものが誤って入ってこないようにしておく
            {
                Exponent(ref number);
            }

            PrtCommaTxt(number);
        }

        /// <summary>
        /// ラウンドセレクターがFかどうかを判定して、PrtTxtRoundFullとPrtTextRoundを使い分けるメソッド
        /// </summary>
        /// <param name="number"></param>
        private void PrtTxt(string number)
        {
            if (roundF.Checked)
            {
                PrtTxtRoundFull(number);
            }
            else if (roundCut.Checked || roundRound.Checked)
            {
                PrtTxtRound(number);
            }
        }

        /// <summary>
        /// 桁数を10桁にするメソッド
        /// </summary>
        /// <param name="number"></param>
        private void ShapeNum10Digit(ref string number)
        {
            string[] array = number.Split('.');

            if (array[0].StartsWith("-"))  //マイナス符号がある場合は除いておく。
            {
                array[0] = array[0].Substring(1);
            }

            if (array[0].Length <= 10 && Math.Abs(decimal.Parse(number)) >= (decimal)0.000000001)  //整数部分が10桁以内、かつ絶対値が10^(-9)以上の場合
            {
                //整数部分を合わせて11桁目の小数で切り捨て
                double d = Math.Pow(10, (10 - (double)array[0].Length));
                number = ((Math.Truncate(decimal.Parse(number) * (decimal)d)) / (decimal)d).ToString();
            }
            else  //整数部分が10桁の場合や、絶対値が10^(-9)よりも小さい場合、指数表示
            {
                Exponent(ref number);
            }
        }

        /// <summary>
        /// 引数に対して桁区切り処理して画面上部と下部に表示するメソッド
        /// </summary>
        private void PrtCommaTxt(string number)
        {
            SetNumComma(number);  //numberに桁区切り処理してoutputBottomに入れる。

            txtResultTop.Text = outputTop;
            txtResultBottom.Text = outputBottom;

            if (isError)  //エラーが出ている場合にメッセージを表示する。
            {
                txtMessage.Text = "E";
            }
            else
            {
                txtMessage.Text = "";
            }
        }

        /// <summary>
        /// 整数部分に桁数区切りを付け、outputBottomに入れるメソッド
        /// </summary>
        /// <param name="number"></param>
        private void SetNumComma(string number)
        {
            if (number.Contains("."))
            {
                string[] array = number.Split('.');

                if (array[0] == "-0")  //"0."の時点でマイナス符号をつけたとき"-0."と表示されるようにする
                {
                    outputBottom = number;
                }
                else  //小数点を打った時点で小数点が表示されるようにする。
                {
                    outputBottom = String.Format("{0:#,0}.{1}", decimal.Parse(array[0]), array[1]);
                }
            }
            else
            {
                outputBottom = (decimal.Parse(number)).ToString("#,0");
            }
        }

        /// <summary>
        /// 指数表示処理のメソッド
        /// </summary>
        /// <param name="number"></param>
        private void Exponent(ref string number)
        {
            number = (decimal.Parse(number).ToString("0.#########e+0"));

            //"1e+xx"、"-1e+xx"と表示されてしまうのを"1.e+xx"、"-1.e+xx"に直すため、eで分けて配列に入れる
            string[] array = number.Split('e');
            string array0;

            if (array[0].StartsWith("-"))  //eより前の部分に"-"が付いていれば除く
            {
                array0 = array[0].Substring(1);
            }
            else
            {
                array0 = array[0];
            }
            
            if (array0.Length == 1)  //1桁の時に"."を入れる。
            {
                number = array[0] + ".e" + array[1];
            }

            isError = true;  //エラーフラグを立てる
        }

        /// <summary>
        /// 端数処理のメソッド
        /// </summary>
        /// <param name="number"></param>
        /// <param name="decimalPoint"></param>
        private void Round(ref string number)
        {
            if (roundF.Checked)
            {
                return;
            }

            //decimalPointに小数点セレクターで選択されているラジオボタンのテキストプロパティを代入
            decimalPoint = (decimalPointSelecter.Controls.OfType<RadioButton>().SingleOrDefault(rb => rb.Checked).Text);

            if (decimalPoint == "ADD2")  //ADD2モードの場合
            {
                if (roundCut.Checked)  //切り捨て
                {
                    number = (Math.Truncate(decimal.Parse(number) * 100) / 100).ToString("0.00");
                }
                else if (roundRound.Checked)  //四捨五入
                {
                    number = (decimal.Parse(number)).ToString("0.00");
                }

                return;
            }

            //数値の書式設定をする文字列をdecimalPointに合わせて作る
            string customNumFormat = "0.";

            for (int i = 0; i < int.Parse(decimalPoint); i++)
            {
                customNumFormat += "0";
            }

            if (roundCut.Checked)  //ラウンドセレクターに合わせて切り捨てか四捨五入
            {
                double d = Math.Pow(10, double.Parse(decimalPoint));
                number = (Math.Truncate(decimal.Parse(number) * (decimal)d) / (decimal)d).ToString(customNumFormat);
            }
            else if (roundRound.Checked)
            {
                number = (Math.Round(decimal.Parse(number), int.Parse(decimalPoint), MidpointRounding.AwayFromZero)).ToString(customNumFormat);
            }
        }

        #endregion

        #region 入力

        /// <summary>
        /// AddNumメソッド
        /// 数字を入力する際に用いる
        /// 計算ボタンが押されている場合は新たなinputNumを作る
        /// 数字ボタン
        /// </summary>
        /// <param name="text"></param>
        private void AddNum(string text)
        {
            if (isError)  //エラーの際は無効
            {
                return;
            }

            JudgeFlag();  //フラグを判定し、場合によりinputNumを初期化

            if (!roundF.Checked)
            {
                //decimalPointに小数点セレクターで選択されているラジオボタンのテキストプロパティを代入
                decimalPoint = (decimalPointSelecter.Controls.OfType<RadioButton>().SingleOrDefault(rb => rb.Checked).Text);
            }
            else
            {
                decimalPoint = "";
            }

            if (decimalPoint == "" || decimalPoint == "0" || decimalPoint == "ADD2")  //ラウンドセレクターが"F"または、小数点セレクターが"0"、"ADD2"の場合
            {
                if (CountTxt(inputNum) < 10)
                {
                    AddTxt(text);

                    PrtCommaTxt(inputNum);
                }
                else  //10以上の場合
                {
                    PrtCommaTxt(inputNum);
                    txtMessage.Text = "10桁までしか表示できません";
                }
            }
            else  //小数点セレクターが"1"～"4"の場合
            {
                AddTxt(text);

                double d = Math.Pow(10, (10 - double.Parse(decimalPoint)));

                if (decimal.Parse(inputNum) >= (decimal)d)
                {
                    inputNum = inputNum.Substring(0, inputNum.Length - 1);
                    PrtCommaTxt(inputNum);
                    txtMessage.Text = "10^" + (10 - double.Parse(decimalPoint)).ToString() + "以上は入力できません";
                }
                else
                {
                    if (CountTxt(inputNum) >= 11)
                    {
                        inputNum = inputNum.Substring(0, inputNum.Length - 1);
                        PrtCommaTxt(inputNum);
                        txtMessage.Text = "10桁までしか表示できません";
                    }
                    else
                    {
                        PrtCommaTxt(inputNum);
                    }
                }
            }
        }

        /// <summary>
        /// AddDotメソッド
        /// 小数点を打つ時に使う
        /// inputnumに小数点がない場合は小数点を追加する。既に小数点がある場合はそのまま出力する
        /// </summary>
        private void AddDot()
        {
            if (isError)  //エラーの時は無効
            {
                return;
            }

            JudgeFlag("0.");  //フラグを判定し、場合によりinputNumに"0."を代入

            if (!inputNum.Contains("."))
            {
                inputNum += ".";  //小数点がない場合の処理
            }

            PrtCommaTxt(inputNum);

            if (CountTxt(inputNum) >= 10)
            {
                txtMessage.Text = "10桁までしか表示できません";
            }
        }

        /// <summary>
        /// inputNumに文字を1文字追加するメソッド
        /// </summary>
        /// <param name="text"></param>
        private void AddTxt(string text)
        {
            if (inputNum != "0")
            {
                inputNum += text;  //0以外の時の処理
            }
            else
            {
                inputNum = text;  //0の時の処理
            }
        }

        /// <summary>
        /// 入力の際に立っているフラグを判定してinputNumに0か0.を入れるメソッド
        /// </summary>
        private void JudgeFlag(string number = "0")
        {
            if (isPercentBtnOn)  //パーセントボタンが押された後、数字が入力された場合はoutputを編集する。
            {
                outputTop = outputTop.Substring(0, outputTop.Length - outputBottom.Length);
                inputNum = "0";
                isPercentBtnOn = false;
            }

            //計算ボタンか±ボタンが押された後、数字が入力される場合はinputNumにnumberをいれisCalcBtnOnをfalseにする
            if (isCalcBtnOn | isPMBtnOn)
            {
                inputNum = number;
                isCalcBtnOn = false;
                isPMBtnOn = false;
            }

            //メモリーボタン・GTボタンが押された後に数字が入力される場合はinputNumにnumberをいれisMemoryBtnOnをfalseにする
            if (isMemoryBtnOn || isGTBtnOn)
            {
                inputNum = number;
                isMemoryBtnOn = false;
                isGTBtnOn = false;
            }

            if (isTaxInBtnOn || isTaxExBtnOn)
            {
                inputNum = number;
                TaxClear();
            }
        }

        #endregion

        #region 計算

        /// <summary>
        /// 四則演算ボタンのイベント発生時の処理
        /// </summary>
        private void CalcBtn(string str)
        {
            if (isError)  //エラーが出ている場合は無効
            {
                return;
            }

            if (isCalcBtnOn)  //直前に計算ボタンが押されていた場合、演算記号のみ変更する
            {
                CalcAfterCalc(str);  //outputTopの編集
            }
            else
            {
                if (!isPercentBtnOn)
                {
                    SetDotAdd2(ref inputNum);
                }

                CalcAfterNumber(str);  //計算処理、outputTop、outputBottomの編集

                if (isError)  //前の処理で0除算エラーで戻ってきた際はここで止める。
                {
                    return;
                }
             }

            string numberFormat = null;  //resultの書式設定

            if (pointAdd2.Checked)
            {
                numberFormat = "0.00#######";
            }

            PrtTxtRoundFull(result.ToString(numberFormat));

            isCalcBtnOn = true;
            isEqualBtnOn = false;  //イコールボタンを押した時のフラグはオフにする。
            isPercentBtnOn = false;  //％ボタンを押したときのフラグはオフにする。
            TaxClear();
        }

        /// <summary>
        /// 計算ボタンの後、演算ボタンが押された際の処理。
        /// outputTopの演算部分を変更する
        /// </summary>
        /// <param name="str"></param>
        private void CalcAfterCalc(string str)
        {
            calcSym = " " + str + " ";

            if (isEqualBtnOn)  //Equalメソッドの後の場合
            {
                result = decimal.Parse(RemoveComma(outputBottom));
                outputTop = outputBottom + calcSym;
            }
            else
            {
                //計算履歴部分の編集。元の履歴の一番最後の演算記号を消して新しい演算記号を加える。
                outputTop = outputTop.Substring(0, outputTop.Length - 3) + calcSym;
            }
        }

        /// <summary>
        /// 数字ボタンの後、演算ボタンが押された際の処理
        /// 計算を行い、outputTop、outputBottomを編集する。
        /// </summary>
        /// <param name="str"></param>
        private void CalcAfterNumber(string str)
        {
            if (isEqualBtnOn)  //Equalメソッドを呼び出した後、数字を入力し、計算ボタンを押した場合。
            {
                result = decimal.Parse(inputNum);
            }
            else
            {
                Calculate();  //resultを計算させる
            }

            if (isError)  //前の行でエラーが出た際はここで処理を止める。
            {
                return;
            }

            calcSym = " " + str + " ";

            if (isPercentBtnOn)  //パーセントボタンを押した後は演算記号だけ追加する。
            {
                outputTop += calcSym;
                isPercentBtnOn = false;
            }
            else
            {
                if (pointAdd2.Checked)  //ADD2モードの場合はinputNumの書式を変更する
                {
                    inputNum = (decimal.Parse(inputNum)).ToString("0.00#######");
                }

                SetNumComma(inputNum);  //Convert()後のinputNumに桁区切り表示を行ってoutPutBottomに入れる
                outputTop += outputBottom + calcSym;  //計算履歴を表示する部分の編集
            }


            if (outputTop.Length > 34)  //計算履歴が長くなった場合の処理
            {
                outputTop = ">>" + outputTop.Substring(outputTop.Length - 34, 34);
            }
        }

        /// <summary>
        /// イコールボタンのメソッド
        /// </summary>
        private void Equal()
        {
            if (isError)  //既にエラーが出ている場合に処理を止める。
            {
                return;
            }

            if (isEqualBtnOn)  //イコールボタンの後、計算ボタンを押さずに再度イコールボタンを押した場合
            {
                result = decimal.Parse(RemoveComma(outputBottom));
                inputNum = constant;
            }
            else if (isCalcBtnOn)
            {
                inputNum = RemoveComma(outputBottom);  //計算ボタンの直後にイコールボタンを押す場合
            }

            //ADD2モードの時の処理
            SetDotAdd2(ref inputNum);

            Calculate();

            if (isError) //前の行で0除算エラーが出た場合はここで処理を止める。
            {
                return;
            }

            outputTop = "";
            PrtTxt(result.ToString());

            if (!isError)
            {
                //isEqualBtnフラグがオフの場合inputNumを定数に入れる。
                if (!isEqualBtnOn)
                {
                    constant = inputNum;  //constantに最初にEqualメソッドが呼び出されたときのinputNumを入れる。
                }

                resultList.Add(decimal.Parse(RemoveComma(outputBottom)));  //resultListに計算結果を追加

                //GT使用状況の表示
                Shape10DigitToString(resultList.Sum(), "GT");

                if (isError)  //前の処理でエラーが出ていた場合、"GTE"と表示
                {
                    txtGT.Text = "GTE";
                    isError = false;
                }
                else
                {
                    if (resultList.Sum() != 0)
                    {
                        txtGT.Text = "GT";
                    }
                    else
                    {
                        txtGT.Text = "";
                    }
                }
            }

            isCalcBtnOn = true;
            isEqualBtnOn = true;
            isPercentBtnOn = false;
        }

        /// <summary>
        /// 計算処理のメソッド
        /// </summary>
        private void Calculate()
        {
            if (!pointAdd2.Checked)
            {
                inputNum = Convert(inputNum);
            }

            switch (calcSym)
            {
                case " + ":
                    result = result + decimal.Parse(inputNum);
                    break;
                case " - ":
                    result = result - decimal.Parse(inputNum);
                    break;
                case " * ":
                    result = result * decimal.Parse(inputNum);
                    break;
                case " / ":
                    try
                    {
                        result = result / decimal.Parse(inputNum);
                    }
                    catch (DivideByZeroException e)  //0除算の例外処理
                    {
                        txtResultTop.Text = outputTop;
                        txtMessage.Text = "E";

                        if (result == 0)
                        {
                            txtResultBottom.Text = "結果が定義されていません";
                        }
                        else
                        {
                            txtResultBottom.Text = "0で割ることはできません";
                        }

                        isError = true;

                        return;
                    }

                    break;
                case "":
                    result = decimal.Parse(RemoveComma(outputBottom));

                    //ADD2モードで小数点が追加された場合はresultを100で割る
                    if (pointAdd2.Checked && isAdd2Used)
                    {
                        result = result / 100;
                        isAdd2Used = false;
                    }

                    break;
            }

            result = decimal.Parse(Convert(result.ToString()));  //余分な0を取り除く
        }

        /// <summary>
        /// GrandTotalを求めるメソッド
        /// </summary>
        private void GrandTotal()
        {
            if (isError)
            {
                return;
            }

            resultTotal = resultList.Sum();  //resultList内の値を全て合計する
            inputNum = Shape10DigitToString(resultTotal,"GT");

            if (pointAdd2.Checked)
            {
                PrtTxtRound(inputNum);
            }
            else
            {
                PrtCommaTxt(inputNum);
            }

            if (isError)  //通常のエラーになっている場合は「GTE」の表示を消す
            {
                txtGT.Text = "";
            }

            isGTBtnOn = true;
            TaxClear();
        }

        #endregion

        #region メモリー

        /// <summary>
        /// MCボタンのメソッド
        /// ※isMemoryBtnOnフラグは立てる
        /// </summary>
        private void MemoryClear()
        {
            memory = 0;
            isMemoryBtnOn = true;
            isMemoryError = false;
            txtMemory.Text = "";
        }

        /// <summary>
        /// MRボタンのメソッド
        /// inputNumにmemoryの値を入れる。
        /// </summary>
        private void MemoryRecall()
        {
            if (isError)
            {
                return;
            }

            isCalcBtnOn = false;

            if (pointAdd2.Checked)
            {
                inputNum = memory.ToString("0.00#######");
                PrtTxtRoundFull(decimal.Parse(Convert(inputNum)).ToString("0.00#######"));
            }
            else
            {
                inputNum = memory.ToString();
                PrtTxtRoundFull(Convert(inputNum));
            }

            if (isError)
            {
                txtMemory.Text = "";
            }

            isMemoryBtnOn = true;
        }

        /// <summary>
        /// MSボタンのメソッド
        /// memoryを上書きする。
        /// </summary>
        private void MemoryStore()
        {
            if (isError)
            {
                return;
            }

            SetDotAdd2(ref outputBottom);  //ADD2モードの時の処理

            memory = decimal.Parse(Convert(outputBottom));

            if (isMemoryError)
            {
                isMemoryError = false;
            }

            PrtMemory();
        }

        /// <summary>
        /// M+ボタンのメソッド
        /// memoryに加える
        /// </summary>
        private void MemoryPlus()
        {
            if (isError || isMemoryError)
            {
                return;
            }

            SetDotAdd2(ref outputBottom);  //ADD2モードの時の処理

            memory += decimal.Parse(Convert(outputBottom));

            PrtMemory();
        }

        /// <summary>
        /// M-ボタンのメソッド
        /// memoryから引く
        /// </summary>
        private void MemoryMinus()
        {
            if (isError || isMemoryError)
            {
                return;
            }

            SetDotAdd2(ref outputBottom);  //ADD2モードの時の処理

            memory -= decimal.Parse(Convert(outputBottom));

            PrtMemory();
        }

        /// <summary>
        /// isMemoryBtnOnフラグを立て、メモリーに入れた数字を表示するメソッド。
        /// memoryそのものを表示するわけではない
        /// </summary>
        private void PrtMemory()
        {
            isMemoryBtnOn = true;

            if (pointAdd2.Checked)
            {
                PrtTxtRoundFull(decimal.Parse(outputBottom).ToString("0.00#######"));
            }
            else
            {
                //PrtTxt内で桁数のカウントが正常に行われるようにするため、桁区切りを取り除いてから、Convertメソッドを通してPrtTxtに入れる。
                PrtTxtRoundFull(Convert(RemoveComma(outputBottom)));
            }

            //メモリーの使用、メモリーエラーの判定を行い、txtMemoryにメッセージを表示する。
            Shape10DigitToString(memory);
        }

        #endregion

        #region 税込・税抜

        /// <summary>
        /// 税込・税抜きボタンを押すときのメソッド
        /// </summary>
        private void TaxBtn(string text)
        {
            if (isError)
            {
                return;
            }

            bool isTaxAfterEqual = false;

            if (isCalcBtnOn)  //計算ボタンの後に押される場合
            {
                if (isEqualBtnOn)  //Equalの直後に押される場合
                {
                    isTaxAfterEqual = true;
                }
                else
                {
                    return;
                }
            }

            if (text == "税込")
            {
                TaxIncluded();
            }
            else if (text == "税抜")
            {
                TaxExcluded();
            }

            if (isEqualBtnOn)  //イコールボタンを押された後の場合はresultListをいれかえる
            {
                if (resultList.Count >= 1 && isTaxAfterEqual)
                {
                    resultList.RemoveAt(resultList.Count - 1);
                }

                resultList.Add(decimal.Parse(inputNum));

                //GT使用状況の表示
                Shape10DigitToString(resultList.Sum(), "GT");

                if (isError)  //前の処理でエラーが出ていた場合、"GTE"と表示
                {
                    txtGT.Text = "GTE";
                    isError = false;
                }
                else
                {
                    if (resultList.Sum() != 0)
                    {
                        txtGT.Text = "GT";
                    }
                    else
                    {
                        txtGT.Text = "";
                    }
                }
            }
        }

        /// <summary>
        /// 税込計算のメソッド
        /// </summary>
        private void TaxIncluded()
        {
            if (!isTaxInBtnOn)
            {
                taxArray[0] = decimal.Parse(RemoveComma(outputBottom)) * (1 + taxRate);
                taxArray[1] = decimal.Parse(RemoveComma(outputBottom)) * taxRate;

                TaxClear();
                isTaxInBtnOn = true;
            }

            if (!isTaxIn)
            {
                inputNum = Convert(taxArray[0].ToString());
                PrtTxt(inputNum);
                txtTax.Text = "税込";

                isTaxIn = true;
            }
            else
            {
                inputNum = Convert(taxArray[1].ToString());
                PrtTxt(inputNum);
                txtTax.Text = "税";

                isTaxIn = false;
            }
        }

        /// <summary>
        /// 税抜き計算のメソッド
        /// </summary>
        private void TaxExcluded()
        {
            if (!isTaxExBtnOn)
            {
                taxArray[0] = decimal.Parse(RemoveComma(outputBottom)) / (1 + taxRate);
                taxArray[1] = decimal.Parse(RemoveComma(outputBottom)) * taxRate / (1 + taxRate);

                TaxClear();
                isTaxExBtnOn = true;
            }

            if (!isTaxEx)
            {
                inputNum = Convert(taxArray[0].ToString());
                PrtTxt(inputNum);
                txtTax.Text = "税抜";

                isTaxEx = true;
            }
            else
            {
                inputNum = Convert(taxArray[1].ToString());
                PrtTxt(inputNum);
                txtTax.Text = "税";

                isTaxEx = false;
            }
        }

        #endregion

        #region 削除

        /// <summary>
        /// AllClearメソッド
        /// Clear()メソッドにプラスでメモリー初期化
        /// </summary>
        private void AllClear()
        {
            MemoryClear();
            Clear();
        }

        /// <summary>
        /// Clearメソッド
        /// ClearEntry()にプラスで計算履歴、result、calcSymを初期化
        /// </summary>
        private void Clear()
        {
            ClearRecord();
            ClearCurrent();
        }

        /// <summary>
        /// CEボタンのメソッド
        /// inputNum、isError、isCalcBtnOn、outputBottomを初期化
        /// </summary>
        private void ClearEntry()
        {
            if (isError)
            {
                ClearRecord();
            }

            ClearCurrent();
        }

        /// <summary>
        /// 計算履歴、result、calcSym、isCalcSymを初期化するメソッド
        /// </summary>
        private void ClearRecord()
        {
            //stringの初期化
            outputTop = "";
            calcSym = "";
            constant = "0";
            txtGT.Text = "";
            //decimalの初期化
            result = 0;
            resultTotal = 0;
            //Listの初期化
            resultList.Clear();
            //boolの初期化
            isCalcBtnOn = false;
            isEqualBtnOn = false;
        }

        /// <summary>
        /// 現在のoutputBottomなどを初期化するメソッド。
        /// </summary>
        private void ClearCurrent()
        {
            if (isCalcBtnOn)
            {
                if (isEqualBtnOn)  //イコールボタンの後に押された場合はinputNumではなくresultが0になる。isCalcBtnOnもそのまま残す。
                {
                    result = 0;
                }
                else  //計算ボタンの後に押された場合はinputNumを0にする
                {
                    isCalcBtnOn = false;
                    inputNum = "0";
                }
            }
            else
            {
                inputNum = "0";
            }
            
            PrtTxtRoundFull("0");  //ここでoutputBottomも0になる
            txtMessage.Text = "";

            TaxClear();
            isPercentBtnOn = false;
            isError = false;
        }

        /// <summary>
        /// 税関係のフラグをまとめてオフにするメソッド
        /// 税表示もまとめて消す。
        /// </summary>
        private void TaxClear()
        {
            txtTax.Text = "";

            isTaxInBtnOn = false;
            isTaxIn = false;
            isTaxExBtnOn = false;
            isTaxEx = false;
        }

        /// <summary>
        /// Deleteメソッド
        /// 負の一桁の場合、正の一桁の場合、-0.から削除ボタンを押した場合は0をinputnumに代入。
        /// それ以外の場合は1文字削除する
        /// </summary>
        private void Delete()
        {
            if (isError || isCalcBtnOn)  //エラーの際は無効。計算ボタンの直後も無効。
            {
                return;
            }

            txtMessage.Text = "";

            //"-x"、"x"、"-0."を"0にする"
            if ((inputNum.Length == 2 && inputNum.Substring(0, 1) == "-") ||
                (inputNum.Length == 1) ||
                (inputNum == "-0."))
            {
                inputNum = "0";
            }
            else  //上記以外の時、後ろの1文字削除
            {
                inputNum = inputNum.Substring(0, inputNum.Length - 1);
            }

            PrtTxtRoundFull(inputNum);
        }

        #endregion

        #region その他

        /// <summary>
        /// ADD2モードの際、numberに自動で小数第2位に小数点を打つメソッド
        /// </summary>
        /// <param name="number"></param>
        private void SetDotAdd2(ref string number)
        {
            //ADD2モードの時の処理
            if (pointAdd2.Checked && !number.Contains("."))
            {
                number = (decimal.Parse(number) / 100).ToString("0.00");
                isAdd2Used = true;  //ADD2によって自動で小数点が追加されたことを表すフラグを立てる。
            }
            else
            {
                number = Convert(number);
                isAdd2Used = false;
            }
        }

        /// <summary>
        /// 無意味な0や小数点を省略するメソッド
        /// "0.0000"や"1."などを"0"、"1"などに変換する
        /// </summary>
        private string Convert(string number)
        {
            //"0."、"0.00"などを"0"に変換する
            if (number.Contains("."))
            {
                string[] array = number.Split('.');

                //array[1]の最後の文字が0の間はそれを削除する。
                while (array[1].EndsWith("0"))
                {
                    array[1] = array[1].Substring(0, array[1].Length - 1);
                }

                if (array[1] == "")  //array[1]が空になった場合はarray[0]のみをnumberに代入
                {
                    number = array[0];
                }
                else  //array[1]があればコンマでつなげてnumberに代入
                {
                    number = array[0] + "." + array[1];
                }
            }

            return number;
        }

        /// <summary>
        /// 桁区切りをなくすメソッド
        /// </summary>
        private string RemoveComma(string output)
        {
            //","で区切って配列に入れた後、その配列をつなげる。
            string[] array = output.Split(',');
            return String.Join("", array);
        }

        /// <summary>
        /// 桁数を取得するメソッド
        /// countでinputnumの文字数を入れ、マイナス符号・小数点があれば-1する。
        /// countを戻り値として返す
        /// </summary>
        /// <param name="inputnum"></param>
        /// <returns></returns>
        private int CountTxt(string inputnum)
        {
            int count = inputnum.Length;  //桁数

            if (inputnum.Contains("-"))
            {
                count -= 1;
            }

            if (inputnum.Contains("."))
            {
                count -= 1;
            }

            return count;
        }

        /// <summary>
        /// decimal型の引数numberをstring型のnumberstrに桁数を整理して変換するメソッド
        /// memoryとresultTotalに使用
        /// 第2引数には、memoryの場合"M"、resultTotalの場合"GT"を入れる
        /// </summary>
        /// <param name="number"></param>
        /// <returns></returns>
        private string Shape10DigitToString(decimal number, string str = "M")
        {
            number = decimal.Parse(Convert(number.ToString()));

            string numberstr = number.ToString();

            if (CountTxt(numberstr) > 10)  //numberstrが10桁を超える場合
            {
                ShapeNum10Digit(ref numberstr);  //10桁以内に変換

                if (isError && str == "M")  //ShapeNum10Digitでエラーが出た際、memoryの場合はisMemoryErrorフラグに立て替え、画面にエラー表示する。
                {
                    isError = false;
                    isMemoryError = true;
                    txtMemory.Text = "ME";
                }
            }
            else
            {
                if (str == "M")  //第1引数がmemoryの場合はメモリーの表示を判定する。
                {
                    if (numberstr != "0")
                    {
                        txtMemory.Text = "M";
                    }
                    else if (numberstr == "0")  //memoryの値が0の時は"M"の表示は消える。
                    {
                        txtMemory.Text = "";
                    }
                }
            }

            return numberstr;
        }

        /// <summary>
        /// 符号を入れ替えるメソッド
        /// 0の場合はなにもしない
        /// 先頭がマイナス符号の場合、マイナス符号を消す
        /// そのほかの場合には先頭にマイナス符号をつける
        /// </summary>
        private void ChangePlusMinus()
        {
            if (isError)  //エラーの際は無効
            {
                return;
            }

            if (isCalcBtnOn)  //計算ボタンの直後に押された場合
            {
                isCalcBtnOn = false;  //この直後に計算ボタンを押しても続けて計算できるようにフラグをオフにする。
                isPMBtnOn = true;  //±ボタンを押したフラグを立てる。
            }

            //inputNumに画面下部に表示されている数字から桁区切りを抜いたものを代入する。
            inputNum = RemoveComma(outputBottom);

            if (inputNum != "0")
            {
                if (inputNum.Substring(0, 1) == "-")  //先頭がマイナス
                {
                    inputNum = inputNum.Substring(1, inputNum.Length - 1);
                }
                else
                {
                    inputNum = "-" + inputNum;
                }
            }

            PrtTxtRoundFull(inputNum);
        }

        /// <summary>
        /// %ボタンを押したときのメソッド
        /// </summary>
        private void Percent()
        {
            if (isError || isPercentBtnOn)
            {
                return;
            }

            inputNum = Convert((result * decimal.Parse(inputNum) / 100).ToString());
            PrtTxtRoundFull(inputNum);

            if (!isError)
            {
                outputTop += outputBottom;
                txtResultTop.Text = outputTop;
            }
            else
            {
                txtResultTop.Text = "";
            }

            if (isEqualBtnOn)
            {
                calcSym = "";
            }

            isPercentBtnOn = true;
        }

        /// <summary>
        /// 電源のオンオフを切り替えるメソッド
        /// </summary>
        private void PowerOnOff()
        {
            if (isPowerOn)
            {
                AllClear();  //初期化
                txtResultBottom.Text = "";

                foreach (Control item in Controls)
                {
                    item.Enabled = false;
                }

                //電源ボタンは有効にしておく
                btnOnOff.Enabled = true;

                //電源オンフラグをオフにする
                isPowerOn = false;
            }
            else
            {
                txtResultBottom.Text = "0";

                foreach (Control item in Controls)
                {
                    item.Enabled = true;
                }

                //画面を無効にしておく
                panelDisplay.Enabled = false;  //panelDisplay上のコントロールを一括で無効

                //ラウンドセレクターがFになっている場合は小数点セレクターを無効にする
                if (roundF.Checked)
                {
                    decimalPointSelecter.Enabled = false;
                }

                //電源オンフラグをオンにする
                isPowerOn = true;
            }
        }

        #endregion

        #endregion

        /// <summary>
        /// 税率ボタンを押したときの処理
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnTaxRate_Click(object sender, EventArgs e)
        {
            if (isError)
            {
                return;
            }

            //税率確認フォームを開く
            TaxRateViewForm frmtaxview = new TaxRateViewForm(taxRate);
            DialogResult dialogResult = frmtaxview.ShowDialog();

            if (dialogResult == DialogResult.OK)  //変更ボタンが押されたときは税率変更フォームを開く
            {
                TaxRateEditForm frmtaxRateEdit = new TaxRateEditForm(taxRate);
                DialogResult drRet = frmtaxRateEdit.ShowDialog();

                if (drRet == DialogResult.OK)
                {
                    string str = frmtaxRateEdit.TextBoxText;
                    taxRate = decimal.Parse(str) / 100;
                }
            }
        }
    }
}