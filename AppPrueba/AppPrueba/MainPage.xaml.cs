using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace AppPrueba
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class MainPage : ContentPage
    {
        //partial indica que la totalidad de la clase no está totalmente definida aqui
        public MainPage()
        {
            InitializeComponent();

        }

        private void Inicializar(object sender, EventArgs e)
        {
            labelTexto.Text = entryTexto.Text;
        }

        private void CambiarPes(object sender, EventArgs e)
        {
            //movernos a otra página
            Navigation.PushAsync(new Page1());
        }
    }
}