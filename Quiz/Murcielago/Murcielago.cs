using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Murcielago : Form
    {
        public Murcielago()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void cifrar_Click(object sender, EventArgs e)
        {
            Limpiar();
            CifrarCadena();
            label2.Text = "Cifrado";
        }

        void CifrarCadena()
        {
            int t, letras;
            string cadena = txtCadena.Text.ToLower();
            letras = cadena.Length;
            char[] ch = new char[letras];
            for (int i = 0; i < letras; i++)
            {
                if (cadena[i].Equals(Char.Parse("m")))
                {
                    ch[i] = Char.Parse("0");
                }
                else
                {
                    if (cadena[i].Equals(Char.Parse("u")))
                    {
                        ch[i] = Char.Parse("1");
                    }
                    else
                    {
                        if (cadena[i].Equals(Char.Parse("r")))
                        {
                            ch[i] = Char.Parse("2");
                        }
                        else
                        {
                            if (cadena[i].Equals(Char.Parse("c")))
                            {
                                ch[i] = Char.Parse("3");
                            }
                            else
                            {
                                if (cadena[i].Equals(Char.Parse("i")))
                                {
                                    ch[i] = Char.Parse("4");
                                }
                                else
                                {
                                    if (cadena[i].Equals(Char.Parse("e")))
                                    {
                                        ch[i] = Char.Parse("5");
                                    }
                                    else
                                    {
                                        if (cadena[i].Equals(Char.Parse("l")))
                                        {
                                            ch[i] = Char.Parse("6");
                                        }
                                        else
                                        {
                                            if (cadena[i].Equals(Char.Parse("a")))
                                            {
                                                ch[i] = Char.Parse("7");
                                            }
                                            else
                                            {
                                                if (cadena[i].Equals(Char.Parse("g")))
                                                {
                                                    ch[i] = Char.Parse("8");
                                                }
                                                else
                                                {
                                                    if (cadena[i].Equals(Char.Parse("o")))
                                                    {
                                                        ch[i] = Char.Parse("9");
                                                    }
                                                    else
                                                    {
                                                        ch[i] = cadena[i];
                                                    }
                                                }
                                            }
                                        }
                                    }
                                }
                            }
                        }
                    }
                }
                txtLista.Items.Add(ch[i]);
            }


        }

        void DescifrarCadena()
        {
            int t, letras;
            string cadena = txtCadena.Text.ToLower();
            letras = cadena.Length;
            char[] ch = new char[letras];
            for (int i = 0; i < letras; i++)
            {
                if (cadena[i].Equals(Char.Parse("0")))
                {
                    ch[i] = Char.Parse("m");
                }
                else
                {
                    if (cadena[i].Equals(Char.Parse("1")))
                    {
                        ch[i] = Char.Parse("u");
                    }
                    else
                    {
                        if (cadena[i].Equals(Char.Parse("2")))
                        {
                            ch[i] = Char.Parse("r");
                        }
                        else
                        {
                            if (cadena[i].Equals(Char.Parse("3")))
                            {
                                ch[i] = Char.Parse("c");
                            }
                            else
                            {
                                if (cadena[i].Equals(Char.Parse("4")))
                                {
                                    ch[i] = Char.Parse("i");
                                }
                                else
                                {
                                    if (cadena[i].Equals(Char.Parse("5")))
                                    {
                                        ch[i] = Char.Parse("e");
                                    }
                                    else
                                    {
                                        if (cadena[i].Equals(Char.Parse("6")))
                                        {
                                            ch[i] = Char.Parse("l");
                                        }
                                        else
                                        {
                                            if (cadena[i].Equals(Char.Parse("7")))
                                            {
                                                ch[i] = Char.Parse("a");
                                            }
                                            else
                                            {
                                                if (cadena[i].Equals(Char.Parse("8")))
                                                {
                                                    ch[i] = Char.Parse("g");
                                                }
                                                else
                                                {
                                                    if (cadena[i].Equals(Char.Parse("9")))
                                                    {
                                                        ch[i] = Char.Parse("o");
                                                    }
                                                    else
                                                    {
                                                        ch[i] = cadena[i];
                                                    }
                                                }
                                            }
                                        }
                                    }
                                }
                            }
                        }
                    }
                }
                txtLista.Items.Add(ch[i]);
            }
        }

        void Limpiar()
        {
            txtLista.Items.Clear();
        }

        private void descifrar_Click(object sender, EventArgs e)
        {
            Limpiar();
            DescifrarCadena();
            label2.Text = "Descifrado";
        }
    }
}
