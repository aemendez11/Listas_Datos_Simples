using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Listas_Datos_Simples
{
    public partial class Form1 : Form
    {
        //lista declararla como globlal
        List<int> listaEntero = new List<int>();
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonIngresar_Click(object sender, EventArgs e)
        {
            int numero = 0;
            bool seConvirtio = int.TryParse(textBoxnumero.Text, out numero);

            if (seConvirtio)
            {
                listaEntero.Add(numero);
                mostrar();
            }
            else
            {
                MessageBox.Show("Debe ingresar un numero");
            }
        }
        private void mostrar()
        {
            //opcion 2: automatio
            //funciona con: combobox, listbox, Datagridview
            listBox1.DataSource = null;
            listBox1.Refresh();
            listBox1.DataSource = listaEntero;
        }
        private void buttonMostrar_Click(object sender, EventArgs e)
        {
            //opción 1: manual
            //for (int i = 0; i < listaEntero.Count; i++)
            //{
            //    listBox1.Items.Add(listaEntero[i]);
            //}

            mostrar();  
        }

        private void buttonordenar_Click(object sender, EventArgs e)
        {
            listaEntero.Sort();
            mostrar();
        }

        private void buttonDescendente_Click(object sender, EventArgs e)
        {
            listaEntero.Sort();
            listaEntero.Reverse();
            mostrar();
        }

        private void buttonEliminar_Click(object sender, EventArgs e)
        {
            int numero = 0;
            bool seConvirtio = int.TryParse(textBoxnumero.Text, out numero);

            if (seConvirtio)
            {
                listaEntero.Remove(numero);
                mostrar();
            }
            else
            {
                MessageBox.Show("Debe ingresar un numero");
            }
        }
    }
}
