using Entidades;
using Entidades.GestorSQL;

namespace Vista
{
    public partial class FrmCartuchera : Form
    {
        Cartuchera<Utiles> cartuchera;
        public FrmCartuchera()
        {
            InitializeComponent();
            cartuchera = new Cartuchera<Utiles>(5,new List<Utiles>() );
        }

        private void btnAgregarUtil_Click(object sender, EventArgs e)
        {
            FrmAgregarUtil agregarLapiz = new FrmAgregarUtil(cartuchera);
            agregarLapiz.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FrmAgregarSacaPunta sacaPunta = new FrmAgregarSacaPunta();
            sacaPunta.ShowDialog();
        }

        private void btnAgregarGoma_Click(object sender, EventArgs e)
        {
            FrmAgregarGoma goma = new FrmAgregarGoma();
            goma.ShowDialog();
        }

        private void FrmCartuchera_Load(object sender, EventArgs e)
        {

            cartuchera.ListaDeElementos = LapizDAO.LeerListaLapiz();
        }
       
      
        private void btnVerUtiles_Click(object sender, EventArgs e)
        {
            FrmVerUtiles utiles = new FrmVerUtiles(cartuchera);
            utiles.ShowDialog();
        }
    }
}