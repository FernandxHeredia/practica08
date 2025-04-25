namespace practica08;

/// <summary>
/// Página que muestra la galería personalizada del usuario en forma de cuadrícula (Grid).
/// Crea dinámicamente botones con imágenes de los animales seleccionados previamente en el CreadorDeGalerias.
/// Cada botón permite acceder a los detalles de ese animal al hacer clic.
/// </summary>
public partial class Galeria : ContentPage
{
    /// <summary>
    /// Constructor de la página de galería.
    /// Inicializa la interfaz y genera la cuadrícula de animales seleccionados.
    /// </summary>
    public Galeria()
	{
		InitializeComponent();
        MostrarGaleria();
    }

    /// <summary>
    /// Genera y muestra los botones en la cuadrícula (Grid) según los animales seleccionados por el usuario.
    /// Cada botón representa un animal, muestra su imagen y al hacer clic navega a la página de detalles.
    /// </summary>
    private void MostrarGaleria()
    {
        // Limpiar cualquier contenido previo en el grid
        GaleriaGrid.Children.Clear();

        int columnas = 2; // Numero de columnas en la cuadricula
        int fila = 0, columna = 0;

        // Recorrer los animales seleccionados en la galería
        foreach (var animal in GaleriaStorage.AnimalesSeleccionados)
        {
            //Crea el botón con la imagen del animal
            var boton = new Button
            {
                ImageSource = animal.Imagen,
                BackgroundColor = Colors.Transparent,
                HeightRequest = 120,
                WidthRequest = 120
            };

            // Al hacer clic, navegar a la página de detalles, pasando el animal como BindingContext
            boton.Clicked += (s, e) =>
            {
                Navigation.PushAsync(new Detalles(animal)); // Aquí va el BindingContext implícito
            };

            // Añadir el botón al grid en la posición actual
            GaleriaGrid.Add(boton, columna, fila);

            // Avanzar en la cuadrícula
            columna++;
            if (columna >= columnas)
            {
                columna = 0;
                fila++;
            }
        }
    }
}
