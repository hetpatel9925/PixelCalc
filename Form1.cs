using System;
using System.Drawing;
using System.Windows.Forms;

namespace CalculatorApp
{
    public class Form1 : Form
    {
        TextBox textBox1;
        Button btnAdd, btnEqual;

        double num1, num2;
        string op;

        public Form1()
        {
            this.Text = "PixelCalc";
            this.Size = new Size(300, 200);

            textBox1 = new TextBox();
            textBox1.Location = new Point(20, 20);
            textBox1.Width = 200;
            this.Controls.Add(textBox1);

            btnAdd = new Button();
            btnAdd.Text = "+";
            btnAdd.Location = new Point(20, 60);
            btnAdd.Click += BtnAdd_Click;
            this.Controls.Add(btnAdd);

            btnEqual = new Button();
            btnEqual.Text = "=";
            btnEqual.Location = new Point(100, 60);
            btnEqual.Click += BtnEqual_Click;
            this.Controls.Add(btnEqual);
        }

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            num1 = Convert.ToDouble(textBox1.Text);
            op = "+";
            textBox1.Clear();
        }

        private void BtnEqual_Click(object sender, EventArgs e)
        {
            num2 = Convert.ToDouble(textBox1.Text);
            if (op == "+")
                textBox1.Text = (num1 + num2).ToString();
        }
    }
}
