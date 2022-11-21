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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using Color = Entidades.Color;

namespace Vista
{
    public partial class FrmAgregarUtil : Form
    {
        Cartuchera<Utiles> cartuchera;
        public FrmAgregarUtil(Cartuchera<Utiles> cartuchera)
        {
            InitializeComponent();
            this.cartuchera = cartuchera;
        }

        private void FrmAgregarUtil_Load(object sender, EventArgs e)
        {

            cmbColor.DataSource = Enum.GetValues(typeof(Entidades.Color));

        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            bool resutlado = int.TryParse(txtPrecio.Text, out int val);
            Color color;
            Enum.TryParse<Color>(cmbColor.SelectedValue.ToString(), out color);
            if (resutlado)
            {
                Lapiz lapiz = new Lapiz(txtMarca.Text, val, color);
                try
                {
                    _ = cartuchera + lapiz;
                    LapizDAO.Alta(lapiz);

                }
                catch (CartucheraLlenaException ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            this.Close();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
