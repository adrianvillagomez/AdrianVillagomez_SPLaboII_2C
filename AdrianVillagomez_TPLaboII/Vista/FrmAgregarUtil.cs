using Entidades;
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

namespace Vista
{
    public partial class FrmAgregarUtil : Form
    {
        public FrmAgregarUtil()
        {
            InitializeComponent();
        }

        private void FrmAgregarUtil_Load(object sender, EventArgs e)
        {
       
            cmbColor.DataSource = Enum.GetValues(typeof(Entidades.Color));

        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            Lapiz lapiz = new Lapiz();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
