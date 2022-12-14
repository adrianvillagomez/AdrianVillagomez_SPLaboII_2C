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
using Color = System.Drawing.Color;

namespace Vista
{
    public partial class FrmSerializar : Form
    {
        Lapiz lapiz;
        Cartuchera<Utiles> cartuchera;
        public FrmSerializar(Lapiz lapiz, Cartuchera<Utiles> cartuchera)
        {
            InitializeComponent();
            this.lapiz = lapiz;
            this.cartuchera = cartuchera;
        }

        private void btnSerialziarJson_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtNombreArchivo.Text))
            {
                lblError.Text = "*Ingrese un Nombre";
                lblError.ForeColor = Color.Red;
                lblError.Visible = true;
                return;
            }
            lapiz.SerializarJson(txtNombreArchivo.Text);
            MessageBox.Show("Serializacion Json con exito", "exito", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            lblError.Visible = false;
        }

        private void btnSerializarXML_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtNombreArchivo.Text))
            {
                lblError.Text = "*Ingrese un Nombre";
                lblError.ForeColor = Color.Red;
                lblError.Visible = true;
                return;
            }
            lapiz.SerializarXml(txtNombreArchivo.Text);
            MessageBox.Show("Serializacion Xml con exito", "exito", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            lblError.Visible = false;
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            DialogResult respuesta = MessageBox.Show("Esta Seguro de eliminar el lapiz?", "Cuidado", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            if (respuesta == DialogResult.OK)
            {
                LapizDAO.Eliminar(lapiz.Id);
                cartuchera.ListaDeElementos.Remove(lapiz);
                this.Close();
            }

        }

    }
}
