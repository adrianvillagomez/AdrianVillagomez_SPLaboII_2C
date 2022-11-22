using Entidades;
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
    public partial class FrmAgregarSacaPunta : Form
    {
        Cartuchera<Utiles> cartuchera;
        public FrmAgregarSacaPunta(Cartuchera<Utiles> cartuchera)
        {
            InitializeComponent();
            this.cartuchera = cartuchera;
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            bool repuesta = int.TryParse(txtPrecio.Text, out int precio);
            if (repuesta)
            {
                SacaPuntas sacapuntas = new SacaPuntas(txtMarca.Text,precio,txtMaterial.Text);
                try
                {
                    _=cartuchera + sacapuntas;
                    SacaPuntasDAO.Alta(sacapuntas);
                    MessageBox.Show("Agregado con exito","Exito");
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            else
            {
                MessageBox.Show("Ingrese un valor numerico","Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
                return;
            }
            this.Close();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
