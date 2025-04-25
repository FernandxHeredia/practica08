namespace practica08;
/// <summary>
/// Página de inicio de sesión.
/// Permite al usuario ingresar un nombre de usuario y contraseña,
/// valida si son correctos, y si lo son, los guarda usando `Preferences` y navega al `MainPage`.
/// También carga automáticamente el usuario y la contraseña guardados si ya existen.
/// </summary>
public partial class LoginPage : ContentPage
{
    /// <summary>
    /// Constructor de la página. 
    /// Carga automáticamente el nombre de usuario y la contraseña guardados previamente en `Preferences`.
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
    /// Evento que se ejecuta cuando se pulsa el botón de "Iniciar sesión".
    /// Valida si las credenciales son correctas y, si lo son, guarda los datos y navega al MainPage.
    /// Si no son válidas, muestra un mensaje de error.
    /// Usuario correcto = "admin", contraseña correcta = "1234".
    /// </summary>
    private async void OnLoginClicked(object sender, EventArgs e)
    {
        string username = UsernameEntry.Text;
        string password = PasswordEntry.Text;

        // Validación de credenciales simple
        if (username == "admin" && password == "1234")
        {
            //Guardar datos si son correctos
            Preferences.Set("username", username);
            Preferences.Set("password", password);

            // Mostrar mensaje de texto
            await DisplayAlert("Éxito", "Inicio de sesión correcto", "Continuar");

            // Navegar a la página principal
            Navigation.PushAsync(new MainPage());
        }
        else
        {
            // Mostrar error si las credenciales son incorrectas
            await DisplayAlert("Error", "Los datos introducidos son incorrectos", "Volver a intentar");
        }
    }
}