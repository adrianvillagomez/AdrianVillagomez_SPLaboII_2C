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
using Color = Entidades.Color;

namespace Vista
{
    public partial class FrmVerUtiles : Form
    {
        Cartuchera<Utiles> cartuchera;
        Lapiz lapizDeserializar;
        public FrmVerUtiles(Cartuchera<Utiles> cartuchera)
        {
            InitializeComponent();
            this.cartuchera = cartuchera;
            this.lapizDeserializar = new Lapiz();
        }

        private void FrmVerUtiles_Load(object sender, EventArgs e)
        {
            RefrescarDtvUtilesLapiz();
            RefrescarDtvSacaPuntas();
            RefrescarDtvUtilesGoma();
        }
        public void RefrescarDtvSacaPuntas()
        {
            dtvSacapuntaz.DataSource = null;
            List<SacaPuntas> sacaPuntas = new List<SacaPuntas>();
            foreach (SacaPuntas item in SacaPuntasDAO.LeerListaSacaPuntas())
            {
                if (item is SacaPuntas)
                {
                    SacaPuntas sacapunta = item as SacaPuntas;
                    sacaPuntas.Add(sacapunta);
                }
            }
            dtvSacapuntaz.DataSource = sacaPuntas;
        }
        public void RefrescarDtvUtilesLapiz()
        {
            dtvLapices.DataSource = null;
            List<Lapiz> lapices = new List<Lapiz>();
            foreach (Lapiz item in LapizDAO.LeerListaLapiz())
            {
                if (item is Lapiz)
                {
                    Lapiz lapiz = item as Lapiz;
                    lapices.Add(lapiz);
                }
            }
            dtvLapices.DataSource = lapices;
        }
        public void RefrescarDtvUtilesGoma()
        {
            dtvGoma.DataSource = null;
            List<Goma> gomas = new List<Goma>();
            foreach (Goma item in GomaDao.LeerListaDeGomas())
            {
                if (item is Goma)
                {
                    Goma lapiz = item as Goma;
                    gomas.Add(lapiz);
                }
            }
            dtvGoma.DataSource = gomas;
        }
        private void dtvUtiles_DoubleClick(object sender, EventArgs e)
        {

            Lapiz lapiz = dtvLapices.CurrentCell.Value as Lapiz;
            string color = dtvLapices.CurrentRow.Cells["color"].Value.ToString();
            Color colorLapiz;
            Enum.TryParse<Color>(color, out colorLapiz);
            string marca = dtvLapices.CurrentRow.Cells["Marca"].Value.ToString();
            string precio = dtvLapices.CurrentRow.Cells["Precio"].Value.ToString();
            string id = dtvLapices.CurrentRow.Cells["Id"].Value.ToString();
            int.TryParse(id, out int idInt);
            int.TryParse(precio, out int precioInt);
            lapiz = new Lapiz(marca, precioInt, colorLapiz);
            lapiz.Id = idInt;
            FrmSerializar frmSerializar = new FrmSerializar(lapiz);
            frmSerializar.ShowDialog();
            RefrescarDtvUtilesLapiz();

        }

        private void btnDeserializar_Click(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog openFile = new OpenFileDialog();       
                openFile.Filter = "archivojson|*.json";
                DialogResult resultado = openFile.ShowDialog();
                if (resultado == DialogResult.OK)
                {
                    Lapiz lapizDeserializadoJson = lapizDeserializar.Json(openFile.FileName);
                    MessageBox.Show(lapizDeserializadoJson.ToString(),"Dezerializacion Json", MessageBoxButtons.OK);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"{ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog openFile = new OpenFileDialog();
                openFile.Filter = "archivoxml|*.xml";
                DialogResult resultado = openFile.ShowDialog();
                if (resultado == DialogResult.OK)
                {
                    Lapiz lapizDeserializadoXml = lapizDeserializar.Xml(openFile.FileName);
                    MessageBox.Show(lapizDeserializadoXml.ToString(),"Dezerializacion XMl",MessageBoxButtons.OK);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"{ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
