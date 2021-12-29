using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace AppPrueba
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            //añadimos la pantalla que queremos que se inicie
            //debemos meterle el Navigation, para indicar la página raiz, y que funcione la navegación entre
            //las páginas
            MainPage = new NavigationPage(new MainPage());
        }


        //CICLOS DE VIDA 

        protected override void OnStart()
        {
            //Cuando inicia la app
        }

        protected override void OnSleep()
        {
            //cuando está en segundo plano
        }

        protected override void OnResume()
        {
            //cuando la app pasa de segundo a plano a despertar
        }
    }
}
