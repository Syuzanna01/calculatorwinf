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

            double a, b;
            a = Convert.ToDouble(Box1.Text);
            b = Convert.ToDouble(Box2.Text);

            switch (comboBox1.Text)
            {
                case "+":
                    Box1.Text = Convert.ToString(a + b);
                    Box3.Text = Convert.ToString($"{a} + {b} = {a + b}");
                    break;
                case "-":
                    Box1.Text = Convert.ToString(a - b);
                    Box3.Text = Convert.ToString($"{a} - {b} = {a - b}");
                    break;
                case "*":
                    Box1.Text = Convert.ToString(a * b);
                    Box3.Text = Convert.ToString($"{a} * {b} = {a * b}");
                    break;
                case "/":
                    {
                        if (b != 0)
                        {
                            Box1.Text = Convert.ToString(a / b);
                            Box3.Text = Convert.ToString($"{a} / {b} = {a / b}");
                        }
                        else
                            Box3.Text = "error";
                        break;
                    }
            }
        }
    }
}
