using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cesar
{
    public partial class Cesar : Form
    {
        public Cesar()
        {
            InitializeComponent();
        }

        private void cifrar_Click(object sender, EventArgs e)
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
            string cadena = txtCadena.Text;
            letras = cadena.Length;
            char[] ch = new char[letras];
            for (int i = 0; i < letras; i++)
            {
                t = (int)cadena[i];
                ch[i] = (char)(t + 3);
                txtListas.Items.Add(ch[i]);

            }

        }

        void DescifrarCadena()
        {
            int t, letras;
            string cadena = txtCadena.Text;
            letras = cadena.Length;
            char[] ch = new char[letras];
            for (int i = 0; i < letras; i++)
            {
                t = (int)cadena[i];
                ch[i] = (char)(t - 3);
                txtListas.Items.Add(ch[i]);

            }

        }

        void Limpiar()
        {
            txtListas.Items.Clear();
        }
    }
}
