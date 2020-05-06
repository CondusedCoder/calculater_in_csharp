using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculater
{
    public partial class Form1 : Form
    {
        public string num1 = "0";
        public string num2 = "0";
        public string opo = "";
        public int numberon = 1;
        
        public Form1()
        {
            InitializeComponent();
        }
        double factorial(double number)
        {
            for (double i = number-1; i >0; i--)
            {
                number *= i;

            }
            return number;


        }

        private void btn1_Click(object sender, EventArgs e)
        {
            if (numberon == 1)
            {
                num1 += "1";

            }
            if (numberon == 2)
            {
                num2 += "1";

            }
            num1txt.Text = num1;
            num2txt.Text = num2;

        }

        private void btn2_Click(object sender, EventArgs e)
        {
            if (numberon == 1)
            {
                num1 += "2";

            }
            if (numberon == 2)
            {
                num2 += "2";

            }

            num1txt.Text = num1;
            num2txt.Text = num2;

        }

        private void btn3_Click(object sender, EventArgs e)
        {
            if (numberon == 1)
            {
                num1 += "3";

            }
            if (numberon == 2)
            {
                num2 += "3";

            }

            num1txt.Text = num1;
            num2txt.Text = num2;

        }

        private void btn4_Click(object sender, EventArgs e)
        {
            if (numberon == 1)
            {
                num1 += "4";

            }
            if (numberon == 2)
            {
                num2 += "4";

            }

            num1txt.Text = num1;
            num2txt.Text = num2;

        }

        private void btn5_Click(object sender, EventArgs e)
        {
            if (numberon == 1)
            {
                num1 += "5";

            }
            if (numberon == 2)
            {
                num2 += "5";

            }

            num1txt.Text = num1;
            num2txt.Text = num2;

        }

        private void btn6_Click(object sender, EventArgs e)
        {
            if (numberon == 1)
            {
                num1 += "6";

            }
            if (numberon == 2)
            {
                num2 += "6";

            }

            num1txt.Text = num1;
            num2txt.Text = num2;

        }

        private void btn7_Click(object sender, EventArgs e)
        {
            if (numberon == 1)
            {
                num1 += "7";

            }
            if (numberon == 2)
            {
                num2 += "7";

            }

            num1txt.Text = num1;
            num2txt.Text = num2;

        }

        private void btn8_Click(object sender, EventArgs e)
        {
            if (numberon == 1)
            {
                num1 += "8";

            }
            if (numberon == 2)
            {
                num2 += "8";

            }

            num1txt.Text = num1;
            num2txt.Text = num2;



        }

        private void btn9_Click(object sender, EventArgs e)
        {
            if (numberon == 1)
            {
                num1 += "9";

            }
            if (numberon == 2)
            {
                num2 += "9";

            }

            num1txt.Text = num1;
            num2txt.Text = num2;

        }

        private void dotbtn_Click(object sender, EventArgs e)
        {
            if (numberon == 1)
            {
                num1 += ".";

            }
            if (numberon == 2)
            {
                num2 += ".";

            }

            num1txt.Text = num1;
            num2txt.Text = num2;

        }

        private void btn0_Click(object sender, EventArgs e)
        {
            if (numberon == 1)
            {
                num1 += "0";

            }
            if (numberon == 2)
            {
                num2 += "0";

            }

            num1txt.Text = num1;
            num2txt.Text = num2;

        }

        private void equalsbtn_Click(object sender, EventArgs e)
        {
            double num1double = Convert.ToDouble(num1);
            double num2double = Convert.ToDouble(num2);
            if (opo == "+")
            {
                sumtxt.Text = Convert.ToString(num1double + num2double);
                num1 = "0";
                num2 = "0";
                numberon = 1;
                opo = "+-/*";
                num1txt.Text = num1;

                num2txt.Text = num2;

                opotxt.Text = opo;



            }

            if (opo == "-")
            {
                sumtxt.Text = Convert.ToString(num1double - num2double);
                num1 = "0";
                num2 = "0";
                numberon = 1;
                opo = "+-/*";
                num1txt.Text = num1;

                num2txt.Text = num2;

                opotxt.Text = opo;



            }

            if (opo == "*")
            {
                sumtxt.Text = Convert.ToString(num1double * num2double);
                num1 = "0";
                num2 = "0";
                numberon = 1;
                opo = "+-/*";
                num1txt.Text = num1;

                num2txt.Text = num2;

                opotxt.Text = opo;



            }

            if (opo == "/")
            {
                sumtxt.Text = Convert.ToString(num1double / num2double);
                num1 = "0";
                num2 = "0";
                numberon = 1;
                opo = "+-/*";
                num1txt.Text = num1;

                num2txt.Text = num2;

                opotxt.Text = opo;



            }
            if (opo == "^")
            {
                double num1number = Convert.ToDouble(num1);
                double num2number = Convert.ToDouble(num2);
                sumtxt.Text = Convert.ToString(Math.Pow(num1number, num2number));
                num1 = "0";
                num2 = "0";
                numberon = 1;
                opo = "+-/*";
                num1txt.Text = num1;

                num2txt.Text = num2;

                opotxt.Text = opo;

            }
            if (opo == "%")
            {
                sumtxt.Text = Convert.ToString((num2double / 100) * num1double);
                num1 = "0";
                num2 = "0";
                numberon = 1;
                opo = "+-/*";
                num1txt.Text = num1;

                num2txt.Text = num2;

                opotxt.Text = opo;

            }
            
            

        }

        private void plusbtn_Click(object sender, EventArgs e)
        {
            opo = "+";
            numberon = 2;
            opotxt.Text = opo;

        }

        private void minusbtn_Click(object sender, EventArgs e)
        {
            opo = "-";
            numberon = 2;
            opotxt.Text = opo;

        }

        private void multiplybtn_Click(object sender, EventArgs e)
        {
            opo = "*";
            numberon = 2;
            opotxt.Text = opo;

        }

        private void dividebtn_Click(object sender, EventArgs e)
        {
            opo = "/";
            numberon = 2;
            opotxt.Text = opo;

        }

        private void squarebtn_Click(object sender, EventArgs e)
        {
            if (numberon == 1)
            {
                double num1double = Convert.ToDouble(num1);
                num1double *= num1double;
                num1 = Convert.ToString(num1double);
                num1txt.Text = num1;

            }
            if (numberon == 2)
            {
                double num2double = Convert.ToDouble(num2);
                num2double *= num2double;
                num2 = Convert.ToString(num2double);
                num2txt.Text = num2;


            }
        }

        private void pibtn_Click(object sender, EventArgs e)
        {
            if (numberon == 1)
            {
                num1 = Convert.ToString(Math.PI);
                num1txt.Text = "pi";

            }
            if (numberon == 2)
            {
                num2 = Convert.ToString(Math.PI);
                num2txt.Text = "pi";
                
            }
        }

        private void sqrtbtn_Click(object sender, EventArgs e)
        {
            if (numberon == 1)
            {
                double num1double = Convert.ToDouble(num1);
                num1double = Math.Sqrt(num1double);
                num1 = Convert.ToString(num1double);
                num1txt.Text = num1;

            }
            if (numberon == 2)
            {
                double num2double = Convert.ToDouble(num2);
                num2double = Math.Sqrt(num2double);
                num2 = Convert.ToString(num2double);
                num2txt.Text = num2;

            }
        }

        private void powbtn_Click(object sender, EventArgs e)
        {
            opo = "^";
            numberon = 2;
            opotxt.Text = opo;

        }

        private void factorialbtn_Click(object sender, EventArgs e)
        {
            if (numberon == 1)
            {
                double num1double = Convert.ToDouble(num1);
                num1double = factorial(num1double);
                num1 = Convert.ToString(num1double);
                num1txt.Text = num1;

            }
            if (numberon == 2)
            {
                double num2double = Convert.ToDouble(num2);
                num2double = factorial(num2double);
                num2 = Convert.ToString(num2double);
                num2txt.Text = num2;

            }
        }

        private void clearbtn_Click(object sender, EventArgs e)
        {
            num1 = "0";
            num2 = "0";
            sumtxt.Text = "0";
            num1txt.Text = num1;
            num2txt.Text = num2;
            opo = "+-*/";

            opotxt.Text = opo;

        }

        private void backspacebtn_Click(object sender, EventArgs e)
        {
            if (numberon == 1 && num1.Length >= 2)
            {
                num1 = num1.Remove(num1.Length - 1, 1);
                num1txt.Text = num1;

            }
            if (numberon == 2 && num2.Length >= 2)
            {
                num2 = num2.Remove(num2.Length - 1, 1);
                num2txt.Text = num2;


            }
        }

        private void percentbtn_Click(object sender, EventArgs e)
        {
            opo = "%";
            numberon = 2;
            opotxt.Text = opo;

        }
    }
}
