using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace practicaUD10
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void tListaSocios_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string Nombre = tNombre.Text;
            string Apellido = tApellidos.Text;
            string Telefono = tTelefono.Text;

            string Socios = Nombre + " " + Apellido + " " + Telefono + Environment.NewLine;

            tListaSocios.Text = Socios + tListaSocios.Text;
        }
    }
}
