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

            if (ishouseprice && isownmoney && israte && isyear)
            {
                caculate();
            }
            else
            {
                MessageBox.Show("請輸入有效的數值");
            }
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
            }
            else // 輸入的是自備款金額
            {
                ownmoney = double.Parse(input2.Text);
            }

            // 計算貸款金額
            loanamount = houseprice - ownmoney;
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
    }
}
