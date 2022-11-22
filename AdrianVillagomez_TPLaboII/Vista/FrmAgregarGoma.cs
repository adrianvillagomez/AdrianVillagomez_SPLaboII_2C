using Entidades;
using Entidades.Excepciones;
using Entidades.GestorSQL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Vista
{
    public partial class FrmAgregarGoma : Form
    {
        Cartuchera<Utiles> cartuchera;
        public FrmAgregarGoma(Cartuchera<Utiles> cartuchera)
        {
            InitializeComponent();
            this.cartuchera = cartuchera;
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            bool respuesta = int.TryParse(txtPrecio.Text, out int precio);
            if (respuesta)
            {
                Goma goma = new Goma(txtMarca.Text, precio);
                try
                {
                    _=cartuchera + goma;
                    GomaDao.Alta(goma);
                }
                catch (CartucheraLlenaException ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }
    }
}
