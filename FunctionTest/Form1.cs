using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FunctionTest
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            TestFunction1();
            TestFunctuon2();
            TestIf();
            TestSwitch();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            txtResult.Text = "";
        }

        public void TestFunction1()
        {
            int nSum = Sum(10, 20);
            string sResult = string.Format("Sum = {0}", nSum);
            Console.WriteLine(sResult);

            txtResult.Text = sResult + "\n";

            txtResult.Text += "~~~~~~~~~~~~~~~~~~~~~~";
        }

        public void TestFunctuon2()
        {
            int a = 100;
            int b = 200;
            string sResult = "";

            sResult = string.Format("a = {0}, b = {1}", a, b);
            txtResult.Text += sResult + "\n";

            SwapTest(a, b);
            sResult = string.Format("a = {0}, b = {1}", a, b);
            txtResult.Text += sResult + "\n";

            Swap(ref a, ref b);
            sResult = string.Format("a = {0}, b = {1}", a, b);
            txtResult.Text += sResult + "\n";

            txtResult.Text += "~~~~~~~~~~~~~~~~~~~~~~";
        }

        public int Sum(int a, int b)
        {
            return (a + b);
        }

        public void SwapTest(int a, int b)
        {
            int c = a;
            a = b;
            b = c;
        }

        public void Swap(ref int a, ref int b)
        {
            int c = a;
            a = b;
            b = c;
        }

        public void TestIf()
        {
            string sResult = "";
            int a = 10;
            int b = 20;

            if (b > a)
                sResult = "b 가 a 보다 큽니다.";
            else if (a > b)
                sResult = "a 가 b 보다 큽니다.";
            else
                sResult = "a 와 b 는 같다.";

            txtResult.Text += sResult + "\n";
            txtResult.Text += "~~~~~~~~~~~~~~~~~~~~~~";
        }

        public void TestSwitch()
        {
            string sResult = "";
            const int apple = 1;
            const int orange = 2;
            const int banana = 3;
            int a = orange;
            switch (a)
            {
                case apple:
                    sResult = "사과입니다.";
                    break;
                case orange:
                    sResult = "오렌지입니다.";
                    break;
                case banana:
                    sResult = "바나나입니다.";
                    break;
                default:
                    break;
            }

            txtResult.Text += sResult + "\n";
            txtResult.Text += "~~~~~~~~~~~~~~~~~~~~~~";
        }
    }
}
