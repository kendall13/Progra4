using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Quiz
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        double a;
        double b;
        string c;
        string funciones;

        private void button1_Click(object sender, EventArgs e)
        {
            if (Pantalla.Text == "")
            {
                Pantalla.Text = "1";
            }
            else
            {
                Pantalla.Text = Pantalla.Text + "1";
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (Pantalla.Text == "")
            {
                Pantalla.Text = "4";
            }
            else
            {
                Pantalla.Text = Pantalla.Text + "4";
            }
        }

        

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void num2_Click(object sender, EventArgs e)
        {
            if (Pantalla.Text == "")
            {
                Pantalla.Text = "2";
            }
            else
            {
                Pantalla.Text = Pantalla.Text + "2";
            }
        }

        private void num3_Click(object sender, EventArgs e)
        {
            if (Pantalla.Text == "")
            {
                Pantalla.Text = "3";
            }
            else
            {
                Pantalla.Text = Pantalla.Text + "3";
            }
        }

        private void num5_Click(object sender, EventArgs e)
        {
            if (Pantalla.Text == "")
            {
                Pantalla.Text = "5";
            }
            else
            {
                Pantalla.Text = Pantalla.Text + "5";
            }
        }

        private void num6_Click(object sender, EventArgs e)
        {
            if (Pantalla.Text == "")
            {
                Pantalla.Text = "6";
            }
            else
            {
                Pantalla.Text = Pantalla.Text + "6";
            }
        }

        private void num7_Click(object sender, EventArgs e)
        {
            if (Pantalla.Text == "")
            {
                Pantalla.Text = "7";
            }
            else
            {
                Pantalla.Text = Pantalla.Text + "7";
            }
        }

        private void num8_Click(object sender, EventArgs e)
        {
            if (Pantalla.Text == "")
            {
                Pantalla.Text = "8";
            }
            else
            {
                Pantalla.Text = Pantalla.Text + "8";
            }
        }

        private void num9_Click(object sender, EventArgs e)
        {
            if (Pantalla.Text == "")
            {
                Pantalla.Text = "9";
            }
            else
            {
                Pantalla.Text = Pantalla.Text + "9";
            }
        }

        private void num0_Click(object sender, EventArgs e)
        {
            if (Pantalla.Text == "")
            {
                Pantalla.Text = "0";
            }
            else
            {
                Pantalla.Text = Pantalla.Text + "0";
            }
        }

        private void divide_Click(object sender, EventArgs e)
        {
            if (Pantalla.Text == "")
            { Pantalla.Text = ""; }
            else { 
                a = Convert.ToDouble(this.Pantalla.Text);
            c = "/";
            this.Pantalla.Clear();
            this.Pantalla.Focus();
        }
        }

        private void mult_Click(object sender, EventArgs e)
        {
            if (Pantalla.Text == "")
            { Pantalla.Text = ""; }
            else { 
                a = Convert.ToDouble(this.Pantalla.Text);
            c = "x";
            this.Pantalla.Clear();
            this.Pantalla.Focus();
        }
        }

        private void resta_Click(object sender, EventArgs e)
        {
            if (Pantalla.Text == "")
            { Pantalla.Text = ""; }
            else { 
                a = Convert.ToDouble(this.Pantalla.Text);
            c = "-";
            this.Pantalla.Clear();
            this.Pantalla.Focus();
        }
        }

        private void mas_Click(object sender, EventArgs e)
        {
            if (Pantalla.Text == "")
            { Pantalla.Text = ""; }
            else { 
                a = Convert.ToDouble(this.Pantalla.Text);
            c = "+";
            this.Pantalla.Clear();
            this.Pantalla.Focus();
        }
        }

        private void coma_Click(object sender, EventArgs e)
        {
            if (this.Pantalla.Text.Contains(',') == false)
            {
                this.Pantalla.Text = this.Pantalla.Text + ",";
            }
        }

        private void igual_Click(object sender, EventArgs e)
        {
            if (Pantalla.Text == "")
            { Pantalla.Text = ""; }
            else { 
                b = Convert.ToDouble(this.Pantalla.Text);
            switch (c)
            {
                case "+":
                    this.Pantalla.Text = Convert.ToString(b + a);
                    break;

                case "-":
                    this.Pantalla.Text = Convert.ToString(a - b);
                    break;

                case "*":
                    this.Pantalla.Text = Convert.ToString(b * a);
                    break;

                case "/":
                    this.Pantalla.Text = Convert.ToString(a / b);
                    break;

                case "potencia":
                    this.Pantalla.Text = Convert.ToString(Math.Pow(a,b));
                    break;
            }
            }
        }

        private void ce_Click(object sender, EventArgs e)
        {
            this.Pantalla.Text = "";
           
        }
        private void trigonometria()
        {
            if (Pantalla.Text == "")
            { Pantalla.Text = ""; }
            else { 
                switch (funciones)
                {
                    case "sen":
                        a = Convert.ToDouble(Pantalla.Text);
                        //Pantalla.Text = "sin(" + a.ToString() + ")";
                        Pantalla.Text = Convert.ToString(Math.Sin(Math.PI * (a) / 180));
                        break;

                    case "cos":
                        a = Convert.ToDouble(Pantalla.Text);
                        //Pantalla.Text = "sin(" + a.ToString() + ")";
                        Pantalla.Text = Convert.ToString(Math.Cos(Math.PI * (a) / 180));
                        break;

                    case "tan":
                        a = Convert.ToDouble(Pantalla.Text);
                        //Pantalla.Text = "sin(" + a.ToString() + ")";
                        Pantalla.Text = Convert.ToString(Math.Tan(Math.PI * (a) / 180));
                        break;

                    case "raiz":
                    a = Convert.ToDouble(Pantalla.Text);
                    //Pantalla.Text = "sin(" + a.ToString() + ")";
                    Pantalla.Text = Convert.ToString(Math.Sqrt(a));
                    break;

            }
        }
    }
        private void cos_Click(object sender, EventArgs e)
        {
            funciones = "cos";
            trigonometria();

        }

        private void tan_Click(object sender, EventArgs e)
        {
            funciones = "tan";
            trigonometria();
        }
        private void button21_Click(object sender, EventArgs e)
        {
            funciones = "sen";
            trigonometria();
        }

        private void raiz_Click(object sender, EventArgs e)
        {
            funciones = "raiz";
            trigonometria();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            if (Pantalla.Text == "")
            { Pantalla.Text = ""; }
            else
                a = Convert.ToDouble(this.Pantalla.Text);
            c = "potencia";
            this.Pantalla.Clear();
            this.Pantalla.Focus();
        }
    }
}
