namespace pryDeganiVentas
{
    public partial class FmrMain : Form
    {
        public FmrMain()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void lstProductos_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstProductos.Text != " ")
            {
                dudCantidad.Enabled = true;    
            }
            else 
            {
                dudCantidad.Enabled = false;
            }
        }
    }
}
