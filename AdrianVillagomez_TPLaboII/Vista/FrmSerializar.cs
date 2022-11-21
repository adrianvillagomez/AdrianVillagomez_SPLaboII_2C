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
        public FrmSerializar(Lapiz lapiz)
        {
            InitializeComponent();
            this.lapiz = lapiz;
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
            LapizDAO.Eliminar(lapiz.Id);
        }
    }
}
