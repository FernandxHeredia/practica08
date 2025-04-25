using Microsoft.Maui.Storage;
namespace practica08;

/// <summary>
/// Página de configuración de la aplicación. Permite al usuario personaliar:
/// -Modo claro y oscuro
/// -Tamaño del texto
/// -Color del texto
/// -Color de fondo
/// Se implementa la persistencia mediante el uso de Preferences
/// </summary>

public partial class Configuracion : ContentPage
{
    /// <summary>
    /// Constructor de la página. Inicializa la parte visual
    /// y carga las configuraciones guardadas por el usuario.
    /// </summary>
	public Configuracion()
	{
        InitializeComponent();
        LoadSettings();
    }

    /// <summary>
    /// Carga las preferencias guardadas del usuario y actualiza la interfaz
    /// para reflejar esas configuraciones.
    /// </summary>
    private void LoadSettings()
    {
        // Cargar el estado del modo oscuro
        bool isDarkMode = Preferences.Get("isDarkMode", false);
        DarkModeSwitch.IsToggled = isDarkMode;

        // Cargar el tamaño del texto
        double textSize = Preferences.Get("textSize", 16.0);
        TextSizeSlider.Value = textSize;

        // Cargar el color del texto
        string textColor = Preferences.Get("textColor", "Negro");
        TextColorPicker.SelectedItem = textColor;

        // Cargar el color de fondo
        string backgroundColor = Preferences.Get("backgroundColor", "Blanco");
        BackgroundColorPicker.SelectedItem = backgroundColor;

        // Aplicar configuraciones iniciales
        ApplySettings();
    }
    /// <summary>
    /// Evento que se lanza al activar o desactivar el modo oscuro
    /// Guarda la preferencia y aplica los cambios visuales
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    private void OnDarkModeToggled(object sender, ToggledEventArgs e)
    {
        // Guardar el estado del modo oscuro
        Preferences.Set("isDarkMode", e.Value);

        // Aplicar el tema oscuro/claro
        ApplySettings();
    }
    /// <summary>
    /// Evento que se lanza al cambiar el tamaño del texto con el slider.
    /// Guarda el nuevo valor y lo aplica en tiempo real.
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    private void OnTextSizeChanged(object sender, ValueChangedEventArgs e)
    {
        // Guardar el tamaño del texto
        Preferences.Set("textSize", e.NewValue);

        // Aplicar el nuevo tamaño
        ApplySettings();
    }
    /// <summary>
    /// Evento que se lanza al cambiar el color del texto mediante el picker.
    /// Guarda la selección y actualiza el color dle texto en la interfaz
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    private void OnTextColorChanged(object sender, EventArgs e)
    {
        // Guardar el color del texto
        string selectedColor = TextColorPicker.SelectedItem.ToString();
        Preferences.Set("textColor", selectedColor);

        // Aplicar el nuevo color
        ApplySettings();
    }
    /// <summary>
    /// Evento que se lanza al cambiar de fondo mediante el picker.
    /// Guarda la seleccion y actualiza el fondo de los layouts.
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    private void OnBackgroundColorChanged(object sender, EventArgs e)
    {
        // Guardar el color de fondo
        string selectedBackgroundColor = BackgroundColorPicker.SelectedItem.ToString();
        Preferences.Set("backgroundColor", selectedBackgroundColor);

        // Aplicar el nuevo color de fondo
        ApplySettings();
    }
    /// <summary>
    /// Aplica todas las preferencias guardadas por el usuario a la interfaz de la aplicación.
    /// </summary>
    private void ApplySettings()
    {
        // Aplicar el modo oscuro
        if (Preferences.Get("isDarkMode", false))
        {
            Application.Current.UserAppTheme = AppTheme.Dark;
        }
        else
        {
            Application.Current.UserAppTheme = AppTheme.Light;
        }

        // Aplicar el tamaño del texto
        double textSize = Preferences.Get("textSize", 16.0);

        if (MainLayout != null)
        {
            foreach (var label in MainLayout.Children.OfType<Label>())
            {
                label.FontSize = textSize;
            }
        }

        // Aplicar el color del texto
        string textColor = Preferences.Get("textColor", "Negro");
        Color color = textColor switch
        {
            "Rojo" => Colors.Red,
            "Azul" => Colors.Blue,
            "Verde" => Colors.Green,
            "Gris" => Colors.Gray,
            _ => Colors.Black,
        };

        if (MainLayout != null)
        {
            foreach (var label in MainLayout.Children.OfType<Label>())
            {
                label.TextColor = color;
            }
        }

        // Aplicar el color de fondo
        string backgroundColor = Preferences.Get("backgroundColor", "Blanco");
        Color bgColor = backgroundColor switch
        {
            "Azul Claro" => Colors.LightBlue,
            "Verde Claro" => Colors.LightGreen,
            "Gris Claro" => Colors.LightGray,
            "Negro" => Colors.Black,
            _ => Colors.White,
        };

        // Cambiar el fondo del layout
        MainLayout.BackgroundColor = bgColor;
    }
}

