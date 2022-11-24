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
    public partial class FrmBajaModificar : Form
    {
        Utiles util;
        Cartuchera<Utiles> cartuchera;
        public FrmBajaModificar(Utiles utiles, Cartuchera<Utiles> cartuchera)
        {
            InitializeComponent();
            this.util = utiles;
            this.cartuchera = cartuchera;
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (util is SacaPuntas)
            {
                DialogResult respuesta = MessageBox.Show("Esta Seguro de eliminar el Sacapuntas?", "Cuidado", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
                if (respuesta == DialogResult.OK)
                {
                    SacaPuntasDAO.Eliminar(util.Id);
                    cartuchera.ListaDeElementos.Remove(util);
                    this.Close();
                }
            }
            else
            {
                if (util is Goma)
                {
                    DialogResult respuesta = MessageBox.Show("Esta Seguro de eliminar la goma?", "Cuidado", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
                    if (respuesta == DialogResult.OK)
                    {
                        GomaDao.Eliminar(util.Id);
                        cartuchera.ListaDeElementos.Remove(util);
                        this.Close();
                    }
                }
            }
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            int.TryParse(txtPrecio.Text, out int precio);
            if (util is SacaPuntas)
            {
                DialogResult respuesta = MessageBox.Show("Esta Seguro de Modificar??", "Cuidado", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
                if (respuesta == DialogResult.OK)
                {
                    SacaPuntas sacaPuntas = new SacaPuntas(txtMarca.Text,precio,txtMaterial.Text);
                    SacaPuntasDAO.Actualizar(sacaPuntas, util.Id);      
                    this.Close();
                }
            }
            else
            {
                if (util is Goma)
                {
                    DialogResult respuesta = MessageBox.Show("Esta Seguro de Modificar??", "Cuidado", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
                    if (respuesta == DialogResult.OK)
                    {
                        Goma goma = new Goma(txtMarca.Text, precio);
                        GomaDao.Actualizar(goma, util.Id);
                        this.Close();
                    }
                }
            }
        }
    }
}
