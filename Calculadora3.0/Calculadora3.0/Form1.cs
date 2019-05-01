using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculadora3._0
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

        string funciones;
        double a;
        double b;
        string c;

        private void buttonPunto_Click(object sender, EventArgs e)
        {
            if (this.textResultado.Text.Contains(',') == false)
            {
                this.textResultado.Text = this.textResultado.Text + ",";
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textResultado.Text == "")
            {
                textResultado.Text = "1";
            }
            else
            {
                textResultado.Text = textResultado.Text + "1";
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {

            if (textResultado.Text == "")
            {
                textResultado.Text = "2";
            }
            else
            {
                textResultado.Text = textResultado.Text + "2";
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {

            if (textResultado.Text == "")
            {
                textResultado.Text = "3";
            }
            else
            {
                textResultado.Text = textResultado.Text + "3";
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {

            if (textResultado.Text == "")
            {
                textResultado.Text = "4";
            }
            else
            {
                textResultado.Text = textResultado.Text + "4";
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {

            if (textResultado.Text == "")
            {
                textResultado.Text = "5";
            }
            else
            {
                textResultado.Text = textResultado.Text + "5";
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {

            if (textResultado.Text == "")
            {
                textResultado.Text = "6";
            }
            else
            {
                textResultado.Text = textResultado.Text + "6";
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {

            if (textResultado.Text == "")
            {
                textResultado.Text = "7";
            }
            else
            {
                textResultado.Text = textResultado.Text + "7";
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {

            if (textResultado.Text == "")
            {
                textResultado.Text = "8";
            }
            else
            {
                textResultado.Text = textResultado.Text + "8";
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {

            if (textResultado.Text == "")
            {
                textResultado.Text = "9";
            }
            else
            {
                textResultado.Text = textResultado.Text + "9";
            }
        }

        private void button0_Click(object sender, EventArgs e)
        {

            if (textResultado.Text == "")
            {
                textResultado.Text = "0";
            }
            else
            {
                textResultado.Text = textResultado.Text + "0";
            }
        }

        private void buttonSuma_Click(object sender, EventArgs e)
        {
            if (textResultado.Text == "")
            { textResultado.Text = ""; }
            else { 

            a = Convert.ToDouble(this.textResultado.Text);
            c = "+";
            this.textResultado.Clear();
            this.textResultado.Focus();
            }
        }
        private void trigonometria()
        {
            switch (funciones)
            {
                case "sen":
                    if (textResultado.Text == "")
                    { textResultado.Text = ""; }
                    else { 
                        a = Convert.ToDouble(textResultado.Text);
                    textResultado.Text = Convert.ToString(Math.Sin(Math.PI * (a) / 180));
            }

            break;

                case "cos":
                    if (textResultado.Text == "")
                    { textResultado.Text = ""; }
                    else { 
                        a = Convert.ToDouble(textResultado.Text);
                    textResultado.Text = Convert.ToString(Math.Cos(Math.PI * (a) / 180));
                    }
                    break;

                case "tan":
                    if (textResultado.Text == "")
                    { textResultado.Text = ""; }
                    else{
                        a = Convert.ToDouble(textResultado.Text);
                    textResultado.Text = Convert.ToString(Math.Tan(Math.PI * (a) / 180));
                    }
                    break;
                case "raiz":
                    if (textResultado.Text == "")
                    { textResultado.Text = ""; }
                    else { 
                        a = Convert.ToDouble(textResultado.Text);
                    textResultado.Text = Convert.ToString(Math.Sqrt(a));
            }
            break;

               
            }
        }
        private void buttonIgual_Click(object sender, EventArgs e)
        {

            if (textResultado.Text == "")
            { textResultado.Text = ""; }
            else 
                b = Convert.ToDouble(this.textResultado.Text);
            switch (c)
            {
                case "+":
                    this.textResultado.Text = Convert.ToString(b + a);
                    break;

                case "-":
                    this.textResultado.Text = Convert.ToString(a - b);
                    break;

                case "*":
                    this.textResultado.Text = Convert.ToString(b * a);
                    break;

                case "/":
                    this.textResultado.Text = Convert.ToString(a / b);
                    break;
                case "^":
                    this.textResultado.Text = Convert.ToString(Math.Pow(a,b));
                    break;
            }
        }

        private void buttonResta_Click(object sender, EventArgs e)
        {
            if (textResultado.Text == "")
            { textResultado.Text = ""; }
            else { 
                a = Convert.ToDouble(this.textResultado.Text);
            c = "-";
            this.textResultado.Clear();
            this.textResultado.Focus();
            }
        }

        private void buttonClear_Click(object sender, EventArgs e)
        {
            this.textResultado.Text = "";
        }

        private void buttonMulti_Click(object sender, EventArgs e)
        {
            if (textResultado.Text == "")
            { textResultado.Text = ""; }
            else { 
                a = Convert.ToDouble(this.textResultado.Text);
            c = "*";
            this.textResultado.Clear();
            this.textResultado.Focus();
            }
        }

        private void buttonDivision_Click(object sender, EventArgs e)
        {
            if (textResultado.Text == "")
            { textResultado.Text = ""; }
            else { 
                a = Convert.ToDouble(this.textResultado.Text);
            c = "/";
            this.textResultado.Clear();
            this.textResultado.Focus();
            }
        }

        private void buttonSen_Click(object sender, EventArgs e)
        {
            funciones = "sen";
            trigonometria();

        }

        private void buttonCos_Click(object sender, EventArgs e)
        {
            funciones = "cos";
            trigonometria();
        }

        private void buttonTan_Click(object sender, EventArgs e)
        {
            funciones = "tan";
            trigonometria();
        }

        private void button12_Click(object sender, EventArgs e)
        {
            funciones = "raiz";
            trigonometria();
        }

        private void buttonElevar_Click(object sender, EventArgs e)
        {
            if (textResultado.Text == "")
            { textResultado.Text = "";
            }
            else
            {
             a = Convert.ToDouble(this.textResultado.Text);
            c = "^";
            this.textResultado.Clear();
            this.textResultado.Focus();
            }
        }
    }
}
