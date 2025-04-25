namespace practica08
{
    /// <summary>
    /// Es la página principal (Home) de la aplicación que actúa como centro de navegación.
    /// Desde aquí se puede acceder a la galería de animales, configuración y al creador de galerias.
    /// También permite cerrar sesión y volver a la pagina de login.
    /// </summary>
    public partial class MainPage : ContentPage
    {

        public MainPage()
        {
            InitializeComponent();
        }
        /// <summary>
        /// Evento que se ejecuta cuando el usuario hace click en "Cerrar sesión".
        /// Muestra una alerta de confirmación y, si acepta, lo redirige a la página de login.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private async void OnLogoutClicked(object sender, EventArgs e)
        {
            bool confirm = await DisplayAlert("Confirmación", "¿Deseas cerrar sesión?", "Sí", "No");
            if (confirm)
            {
                Navigation.PushAsync(new LoginPage());
            }
        }

        /// <summary>
        /// Navega a la página de Galería de animales.
        /// </summary>
        private async void IrAGaleriaClicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new Galeria());
        }

        /// <summary>
        /// Navega a la página de Configuración.
        /// </summary>
        private async void IrAConfigClicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new Configuracion());
        }

        /// <summary>
        /// Navega a la página de creación de galerias personalizadas.
        /// </summary>
        private async void IrACrearGaleriaClicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new CreadorDeGalerias());
        }
    }

}
