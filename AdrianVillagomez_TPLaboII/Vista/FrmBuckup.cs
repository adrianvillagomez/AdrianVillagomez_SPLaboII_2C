using Entidades.GestorDeArchivo;
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
    public partial class FrmBuckup : Form
    {
        public FrmBuckup()
        {
            InitializeComponent();
        }

        private void FrmBuckup_Load(object sender, EventArgs e)
        {
            richTextBox1.Text = LogBackUp.Leer();
        }
    }
}
