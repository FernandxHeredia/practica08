namespace practica08;

/// <summary>
/// P�gina que muestra la galer�a personalizada del usuario en forma de cuadr�cula (Grid).
/// Crea din�micamente botones con im�genes de los animales seleccionados previamente en el CreadorDeGalerias.
/// Cada bot�n permite acceder a los detalles de ese animal al hacer clic.
/// </summary>
public partial class Galeria : ContentPage
{
    /// <summary>
    /// Constructor de la p�gina de galer�a.
    /// Inicializa la interfaz y genera la cuadr�cula de animales seleccionados.
    /// </summary>
    public Galeria()
	{
		InitializeComponent();
        MostrarGaleria();
    }

    /// <summary>
    /// Genera y muestra los botones en la cuadr�cula (Grid) seg�n los animales seleccionados por el usuario.
    /// Cada bot�n representa un animal, muestra su imagen y al hacer clic navega a la p�gina de detalles.
    /// </summary>
    private void MostrarGaleria()
    {
        // Limpiar cualquier contenido previo en el grid
        GaleriaGrid.Children.Clear();

        int columnas = 2; // Numero de columnas en la cuadricula
        int fila = 0, columna = 0;

        // Recorrer los animales seleccionados en la galer�a
        foreach (var animal in GaleriaStorage.AnimalesSeleccionados)
        {
            //Crea el bot�n con la imagen del animal
            var boton = new Button
            {
                ImageSource = animal.Imagen,
                BackgroundColor = Colors.Transparent,
                HeightRequest = 120,
                WidthRequest = 120
            };

            // Al hacer clic, navegar a la p�gina de detalles, pasando el animal como BindingContext
            boton.Clicked += (s, e) =>
            {
                Navigation.PushAsync(new Detalles(animal)); // Aqu� va el BindingContext impl�cito
            };

            // A�adir el bot�n al grid en la posici�n actual
            GaleriaGrid.Add(boton, columna, fila);

            // Avanzar en la cuadr�cula
            columna++;
            if (columna >= columnas)
            {
                columna = 0;
                fila++;
            }
        }
    }
}
