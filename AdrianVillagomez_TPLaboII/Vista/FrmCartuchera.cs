using Entidades;

namespace Vista
{
    public partial class FrmCartuchera : Form
    {
        Cartuchera<Utiles> cartuchera;
        List<Utiles> utiles;
        public FrmCartuchera()
        {
            InitializeComponent();
            cartuchera = new Cartuchera<Utiles>(10,utiles);
        }

        private void btnAgregarUtil_Click(object sender, EventArgs e)
        {
            FrmAgregarUtil agregarLapiz = new FrmAgregarUtil();
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
    }
}