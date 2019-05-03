using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Malespin
{
    public partial class Malespin : Form
    {
        public Malespin()
        {
            InitializeComponent();
        }

        private void Cifrar_Click(object sender, EventArgs e)
        {
            Limpiar();
            CifrarCadena();
            label2.Text = "Cifrado";
        }

        private void Descifrar_Click(object sender, EventArgs e)
        {
            Limpiar();
            DescifrarCadena();
            label2.Text = "Descifrado";
        }

        void CifrarCadena()
        {
            int t, letras;
            string cadena = txtCadena.Text.ToLower();
            letras = cadena.Length;
            char[] ch = new char[letras];
            for (int i = 0; i < letras; i++)
            {
                if (cadena[i].Equals(Char.Parse("a")))
                {
                    ch[i] = Char.Parse("e");
                }
                else
                {
                    if (cadena[i].Equals(Char.Parse("i")))
                    {
                        ch[i] = Char.Parse("o");
                    }
                    else
                    {
                        if (cadena[i].Equals(Char.Parse("b")))
                        {
                            ch[i] = Char.Parse("t");
                        }
                        else
                        {
                            if (cadena[i].Equals(Char.Parse("p")))
                            {
                                ch[i] = Char.Parse("m");
                            }
                            else
                            {
                                if (cadena[i].Equals(Char.Parse("f")))
                                {
                                    ch[i] = Char.Parse("g");
                                }
                                else
                                {
                                    ch[i] = cadena[i];
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
                if (cadena[i].Equals(Char.Parse("e")))
                {
                    ch[i] = Char.Parse("a");
                }
                else
                {
                    if (cadena[i].Equals(Char.Parse("o")))
                    {
                        ch[i] = Char.Parse("i");
                    }
                    else
                    {
                        if (cadena[i].Equals(Char.Parse("t")))
                        {
                            ch[i] = Char.Parse("b");
                        }
                        else
                        {
                            if (cadena[i].Equals(Char.Parse("m")))
                            {
                                ch[i] = Char.Parse("p");
                            }
                            else
                            {
                                if (cadena[i].Equals(Char.Parse("g")))
                                {
                                    ch[i] = Char.Parse("f");
                                }
                                else
                                {
                                    ch[i] = cadena[i];
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
    }
}
