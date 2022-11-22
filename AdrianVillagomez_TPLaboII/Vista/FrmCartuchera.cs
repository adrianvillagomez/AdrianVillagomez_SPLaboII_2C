using Entidades;
using Entidades.GestorDeArchivo;
using Entidades.GestorSQL;

namespace Vista
{
    public partial class FrmCartuchera : Form
    {
        Cartuchera<Utiles> cartuchera;
        public FrmCartuchera()
        {
            InitializeComponent();
            cartuchera = new Cartuchera<Utiles>(3,new List<Utiles>() );
        }

        private void btnAgregarUtil_Click(object sender, EventArgs e)
        {
            FrmAgregarUtil agregarLapiz = new FrmAgregarUtil(cartuchera);
            agregarLapiz.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FrmAgregarSacaPunta sacaPunta = new FrmAgregarSacaPunta(cartuchera);
            sacaPunta.ShowDialog();
        }

        private void btnAgregarGoma_Click(object sender, EventArgs e)
        {
            FrmAgregarGoma goma = new FrmAgregarGoma(cartuchera);
            goma.ShowDialog();
        }

        private void FrmCartuchera_Load(object sender, EventArgs e)
        {          
            cartuchera.ListaDeElementos = LlenarCartuchera();
            cartuchera.EventoPrecio += ImprimirEnTicket;
        }
       
      
        private void btnVerUtiles_Click(object sender, EventArgs e)
        {
            FrmVerUtiles utiles = new FrmVerUtiles(cartuchera);
            utiles.ShowDialog();
        }
        public List<Utiles> LlenarCartuchera()
        {
            List<Utiles> utiles = new List<Utiles>();
            foreach (SacaPuntas item in SacaPuntasDAO.LeerListaSacaPuntas())
            {
                utiles.Add(item);
            }
            foreach (Lapiz item in LapizDAO.LeerListaLapiz())
            {
                utiles.Add(item);
            }
            foreach (Goma item in GomaDao.LeerListaDeGomas())
            {
                utiles.Add(item);
            }
            return utiles;
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            cartuchera.ListaDeElementos = LlenarCartuchera();
            MessageBox.Show(cartuchera.ToString(),"Ticket Cartuchera");
        }
        public void ImprimirEnTicket()
        {
            Log log= new Log();
            log.Escribir(cartuchera.ToString());
            MessageBox.Show("Se disparo el evento");
        }
    }
}