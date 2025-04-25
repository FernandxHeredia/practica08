namespace practica08;
/// <summary>
/// P�gina de inicio de sesi�n.
/// Permite al usuario ingresar un nombre de usuario y contrase�a,
/// valida si son correctos, y si lo son, los guarda usando `Preferences` y navega al `MainPage`.
/// Tambi�n carga autom�ticamente el usuario y la contrase�a guardados si ya existen.
/// </summary>
public partial class LoginPage : ContentPage
{
    /// <summary>
    /// Constructor de la p�gina. 
    /// Carga autom�ticamente el nombre de usuario y la contrase�a guardados previamente en `Preferences`.
    /// </summary>
    public LoginPage()
	{
        // Obtener datos guardados previamente (si existen)

        InitializeComponent();
        string savedUser = Preferences.Get("username", string.Empty);
        string savedPass = Preferences.Get("password", string.Empty);

        // Mostrar los datos guardados en los campos de entrada
        UsernameEntry.Text = savedUser;
        PasswordEntry.Text = savedPass;
    }

    /// <summary>
    /// Evento que se ejecuta cuando se pulsa el bot�n de "Iniciar sesi�n".
    /// Valida si las credenciales son correctas y, si lo son, guarda los datos y navega al MainPage.
    /// Si no son v�lidas, muestra un mensaje de error.
    /// Usuario correcto = "admin", contrase�a correcta = "1234".
    /// </summary>
    private async void OnLoginClicked(object sender, EventArgs e)
    {
        string username = UsernameEntry.Text;
        string password = PasswordEntry.Text;

        // Validaci�n de credenciales simple
        if (username == "admin" && password == "1234")
        {
            //Guardar datos si son correctos
            Preferences.Set("username", username);
            Preferences.Set("password", password);

            // Mostrar mensaje de texto
            await DisplayAlert("�xito", "Inicio de sesi�n correcto", "Continuar");

            // Navegar a la p�gina principal
            Navigation.PushAsync(new MainPage());
        }
        else
        {
            // Mostrar error si las credenciales son incorrectas
            await DisplayAlert("Error", "Los datos introducidos son incorrectos", "Volver a intentar");
        }
    }
}