using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace AcostaExamen
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Registro : ContentPage
    {
        public Registro(string sususuario,string scontraseña)
        {
            InitializeComponent();

            lblUsuario.Text = sususuario;
            lblContraseña.Text = scontraseña;
           // txtUsuario.Text = sususuario;
            //txtContraseña.Text = scontraseña;
        }

        private void txtDatoUno_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void btnSuma_Clicked(object sender, EventArgs e)
        {
         //   double datoUno = Convert.ToDouble(txtDatoUno.Text);
            double datoDos = Convert.ToDouble(txtDatoDos.Text);
            double datoTres = Convert.ToDouble(txtDatoTres.Text);

            //  double multi = datoDos - datoTres;
            double multi = ((datoDos - datoTres) / 3);
            double fin = multi * 0.05;
            txtResultado.Text = Convert.ToString(fin);

        }

        private void txtDatoDos_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void txtDatoTres_TextChanged(object sender, TextChangedEventArgs e)
        {
            try
            {
                double dato = Convert.ToDouble(txtDatoTres.Text);
                if (dato > 1799)
                {
                    DisplayAlert("Mensaje de Alerta", "No se permite datos Mayores a 10", "OK");
                // txtDatoUno.Text = "";
 }
            }
            catch (Exception ex)
            {
                // DisplayAlert("Alerta", ex.Message, "OK");
            }
        }

        private void btnGuardar_Clicked(object sender, EventArgs e)
        {

        }
    }
}