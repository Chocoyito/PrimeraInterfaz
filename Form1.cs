using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapturarDatosNumericos
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public void grabarNumero_Click(object sender, EventArgs e)
        {
            decimal valor = listaNumeros.Value;
            imprimirResultados.Text = "El número grabado fue " + valor; // Cadena + numero = Cadena, si no valor.ToString.
        }
        public void limpiarNumeros_Click(object sender, EventArgs e)
        {
            imprimirResultados.Text = "";
            listaNumeros.Value = 0;
        }
    }
}
