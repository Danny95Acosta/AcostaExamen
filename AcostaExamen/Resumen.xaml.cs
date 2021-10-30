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
    public partial class Resumen : ContentPage
    {
        public Resumen(string sususuario, string scontraseña)
        {
            InitializeComponent();
            lblUsuario.Text = sususuario;
            lblContraseña.Text = scontraseña;
            
        }
    }
}