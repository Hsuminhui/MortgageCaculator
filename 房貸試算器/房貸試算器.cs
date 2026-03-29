using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.AxHost;

namespace 房貸試算器
{
    public partial class 房貸試算器 : Form
    {

        public 房貸試算器()
        {
            InitializeComponent();
            downpayment.SelectedIndex = 0; //預設自備款比例(%)或輸入金額
            comboBox1.SelectedIndex = 0; //預設寬限期為無
            this.AcceptButton = btncaculate;

        }

        private void btncaculate_Click(object sender, EventArgs e)
        {
            int index = downpayment.SelectedIndex; //選比例or輸入金額

            int year, grace;
            double houseprice, rate, ownmoney;

            grace = comboBox1.SelectedIndex;
            bool ishouseprice = double.TryParse(input1.Text, out houseprice);
            bool isownmoney = double.TryParse(input2.Text, out ownmoney);
            bool israte = double.TryParse(input3.Text, out rate);
            bool isyear = int.TryParse(input4.Text, out year);

            if (!ishouseprice || !isownmoney || !israte || !isyear)
            {
                MessageBox.Show("請輸入有效的數值。", "輸入錯誤", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (houseprice <= 0)
            {
                MessageBox.Show("房屋總價必須大於 0。", "輸入錯誤", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                input1.Focus();
                return;
            }

            if (ownmoney < 0)
            {
                MessageBox.Show("自備款不可小於 0。", "輸入錯誤", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                input2.Focus();
                return;
            }

            if (rate <= 0)
            {
                MessageBox.Show("年利率必須大於 0。", "輸入錯誤", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                input3.Focus();
                return;
            }

            if (year <= 0)
            {
                MessageBox.Show("貸款年限必須大於 0。", "輸入錯誤", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                input4.Focus();
                return;
            }

            // 寬限期不可大於或等於貸款年限（0 代表無寬限期，例外）
            if (grace != 0 && grace >= year)
            {
                MessageBox.Show("寬限期必須小於貸款年限。", "輸入錯誤", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                comboBox1.Focus();
                return;
            }

            caculate();
            
        }
        private void caculate()
        {
            double houseprice = double.Parse(input1.Text);
            double ownmoney = 0;
            double loanamount = 0;
            double rate = double.Parse(input3.Text) / 100.0; // 年利率轉小數
            int year = int.Parse(input4.Text);
            int grace = comboBox1.SelectedIndex;             // 0=無寬限期，1=1年，2=2年...
            double firstInterest, money;                     // 首期利息、首期本金
            double totalInterest, totalPayment;              // 總利息、總還款

            // 計算自備款
            if (downpayment.SelectedIndex == 0) // 輸入的是百分比
            {
                double percentage = double.Parse(input2.Text);
                ownmoney = houseprice * percentage / 100.0;

                if (percentage < 0 || percentage >= 100)
                {
                    MessageBox.Show("自備款比例請輸入 0 ~ 99.99 之間的數值。", "輸入錯誤", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    input2.Focus();
                    return;
                }
            }
            else // 輸入的是自備款金額
            {
                ownmoney = double.Parse(input2.Text);
                if (ownmoney < 0 || ownmoney >= houseprice)
                {
                    MessageBox.Show("自備款金額請輸入大於或等於 0 且小於房價的數值。", "輸入錯誤", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    input2.Focus();
                    return;
                }
            }

            // 計算貸款金額
            loanamount = houseprice - ownmoney;

            if (loanamount <= 0)
            {
                MessageBox.Show("貸款金額必須大於 0。", "計算錯誤", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            output1.Text = $"{loanamount:N2}";

            double r = rate / 12.0;      // 月利率
            int totalMonths = year * 12; // 總期數

            if (grace == 0) // 無寬限期
            {
                double monthlypayment = loanamount * r * Math.Pow(1 + r, totalMonths)
                                      / (Math.Pow(1 + r, totalMonths) - 1);

                firstInterest = loanamount * r;           // 首期利息
                money = monthlypayment - firstInterest;   // 首期本金

                totalPayment = monthlypayment * totalMonths;   // 總還款金額
                totalInterest = totalPayment - loanamount;     // 總利息支出

                output2.Text = $"{monthlypayment:N2}";    // 每月還款金額
                output3.Text = $"{firstInterest:N2}";     // 首期利息
                output4.Text = $"{money:N2}";             // 首期本金
                output5.Text = $"{totalInterest:N2}";     // 總利息支出
                output6.Text = $"{totalPayment:N2}";      // 總還款金額
            }
            else // 有寬限期
            {
                int graceMonths = grace * 12;                 // 寬限期月數
                int remainMonths = totalMonths - graceMonths; // 剩餘攤還月數

                // 寬限期內每月只繳利息
                double gracepayment = loanamount * r;

                // 寬限期後每月本息攤還
                double monthlypaymentAfterGrace = loanamount * r * Math.Pow(1 + r, remainMonths)
                                                / (Math.Pow(1 + r, remainMonths) - 1);

                firstInterest = loanamount * r;   // 首期利息
                money = 0;                        // 寬限期內首期本金為 0

                double graceTotal = gracepayment * graceMonths;                     // 寬限期總付款
                double afterGraceTotal = monthlypaymentAfterGrace * remainMonths;   // 寬限期後總付款

                totalPayment = graceTotal + afterGraceTotal;    // 總還款金額
                totalInterest = totalPayment - loanamount;      // 總利息支出

                output2.Text = $"{gracepayment:N2}";       // 寬限期每月還款金額
                output3.Text = $"{firstInterest:N2}";      // 首期利息
                output4.Text = $"{money:N2}";              // 首期本金
                output5.Text = $"{totalInterest:N2}";      // 總利息支出
                output6.Text = $"{totalPayment:N2}";       // 總還款金額
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            input1.Text = "";
            input2.Text = "";
            input3.Text = "";
            input4.Text = "";
            output1.Text = "";
            output2.Text = "";
            output3.Text = "";
            output4.Text = "";
            output5.Text = "";
            output6.Text = "";
        }
    }
}
