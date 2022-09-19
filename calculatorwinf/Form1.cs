using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace calculatorwinf
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double num1, num2;
            char sign;
            string str, n1 = null, n2 = null;
            str = Box1.Text;
            for (int i = 0; i < str.Length; i++)
            {
                if (str[i] == '+' | str[i] == '-' | str[i] == '*' | str[i] == '/')
                {
                    bool isParsable1 = Int32.TryParse(n1, out _);
                    if (isParsable1)
                    {
                        sign = str[i];
                        num1 = Int32.Parse(n1);
                        for (int j = i + 1; j < str.Length + 1; j++)
                        {
                            if (j == str.Length)
                            {
                                bool isParsable2 = Int32.TryParse(n2, out _);
                                if (isParsable2)
                                {
                                    num2 = Int32.Parse(n2);

                                    switch (sign)
                                    {
                                        case '+':
                                            Box1.Text = Convert.ToString(num1 + num2);
                                            break;
                                        case '-':
                                            Box1.Text = Convert.ToString(num1 - num2);
                                            break;
                                        case '*':
                                            Box1.Text = Convert.ToString(num1 * num2);
                                            break;
                                        case '/':
                                            {
                                                if (num1 != 0)
                                                {
                                                    Box1.Text = Convert.ToString(num1 / num2);
                                                }
                                                break;
                                            }
                                    }
                                    break;
                                }
                                else
                                {
                                    Box1.Text = "error";
                                    break;
                                }
                            }
                            n2 += str[j];
                        }
                        break;
                    }
                    else
                        Box1.Text = "error";
                }
                n1 += str[i];
            }
        }
    }
}
