namespace HealthLife
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        Estructura midigital = new Estructura();

        private void rtbHealthLife_TextChanged(object sender, EventArgs e)
        {

        }

        private void Txtprecio_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }
        
        
        private void btnRegistro_Click_1(object sender, EventArgs e)
        {
            midigital.insertar(int.Parse(txtDNI.Text),txtNombre.Text, txtApellido.Text, int.Parse(txtNumeroHistoria.Text),
                    cobEspecialidad.Text, cobMedico.Text, dtpFecha.Text, int.Parse(txtprecio.Text));
            midigital.mostrar(rtbHealthLife);
            
        
        }

        private void btnBusqueda_Click_1(object sender, EventArgs e)
        {
            
            midigital.buscard(int.Parse(txtBuscar.Text));
          
        }

        private void btnBusquedaH_Click(object sender, EventArgs e)
        {
            midigital.buscarh(int.Parse(txtBuscar.Text));
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            tabControlPrincipal.SelectedTab = tabControlPrincipal.TabPages[0];
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            tabControlPrincipal.SelectedTab = tabControlPrincipal.TabPages[1];
        }

        private void btnMedicinaGeneral_Click(object sender, EventArgs e)
        {
            midigital.clasificarMedicinaGeneral(rtbMedicina);
        }

        private void btnNutricion_Click(object sender, EventArgs e)
        {
            midigital.clasificarNutricion(rtbNutricion);
        }

        private void btnOrdenAlfabetico_Click(object sender, EventArgs e)
        {
            midigital.ordenarAscendente();
            midigital.mostrar1(rtbOrdenAlfabetico);
        }

        private void btnConteoGeneral_Click(object sender, EventArgs e)
        {
            midigital.conteoGeneral();
        }

        private void btnConteoMedicinaGeneral_Click(object sender, EventArgs e)
        {
            midigital.conteoMedicinaGeneral();
        }

        private void btnConteoNutricion_Click(object sender, EventArgs e)
        {
            midigital.conteoNutricion();
        }

        private void btnConteoIngresoGeneral_Click(object sender, EventArgs e)
        {
            midigital.conteoDineroGeneral();
        }

        private void btnConteoIngresoMedicinaGeneral_Click(object sender, EventArgs e)
        {
            midigital.conteoDineroMedicinaGeneral();
        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }

        private void btnConteoIngresoNutricion_Click(object sender, EventArgs e)
        {
            midigital.conteoDineroNutricion();
        }
    }
}