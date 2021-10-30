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
    public partial class Login : ContentPage
    {
        public Login()
        {
            InitializeComponent();
        }

        private async void btAbrir_Clicked(object sender, EventArgs e)
        {
            // Alacenar los datos en variable
            string susuario = txtUsuario.Text;
            string scontraseña = txtContraseña.Text;
            if ((susuario == "estudiante2021") && (scontraseña == "uisrael2021"))
            {
                await Navigation.PushAsync(new Registro(susuario,scontraseña));
            }
            else
            {
                lblResultado.Text = "El usuario o la contraseña son incorrectos!";
            }
            //Navegando ventana 2
            // await Navigation.PushAsync(new viewDos(usuario, contraseña));
        }
    }
}