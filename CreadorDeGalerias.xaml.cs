namespace practica08;
/// <summary>
/// Página que permite al usuario seleccionar animales para construir una galería personalizada.
/// Cada animal seleccionado se guarda como objeto de tipo <see cref="Animal"/> en GaleriaStorage.
/// </summary>
public partial class CreadorDeGalerias : ContentPage
{
    
    public CreadorDeGalerias()
	{
		InitializeComponent();
	}

    /// <summary>
    /// Evento que se ejecuta cuando el usuario pulsa el botón para guardar los animales seleccionados.
    /// Por cada checkbox marcado, se crea un objeto <see cref="Animal"/> y se guarda en <see cref="GaleriaStorage"/>.
    /// </summary>
    private void OnSeleccionarAnimales(object sender, EventArgs e)
    {
        // Limpiar selección anterior
        GaleriaStorage.AnimalesSeleccionados.Clear();

        // Añadir animales seleccionados con sus datos completos (nombre, imagen, especie, descripción)
        if (checkPerro.IsChecked)
            GaleriaStorage.AnimalesSeleccionados.Add(new Animal("Perro", "perro.jpg", "Canis lupus familiaris","El perro es un mamífero doméstico de la familia de los cánidos. Es un animal sociable, leal y afectuoso con los humanos. "));
        if (checkGato.IsChecked)
            GaleriaStorage.AnimalesSeleccionados.Add(new Animal("Gato", "gato.jpg", "Felis catus","Los gatos son mamíferos carnívoros con cuerpo cubierto de pelo, cuatro patas, cola, hocico corto, cabeza redondeada y orejas que pueden rotar. Son animales sociales y juguetones que pueden convivir con los humanos como mascotas. "));
        if (checkLeon.IsChecked)
            GaleriaStorage.AnimalesSeleccionados.Add(new Animal("León", "leon.jpg", "Panthera leo","El león es un mamífero carnívoro africano de gran tamaño, cabeza grande, dientes fuertes y cola larga. Es el segundo felino más grande en la actualidad, después del tigre. "));
        if (checkCaballo.IsChecked)
            GaleriaStorage.AnimalesSeleccionados.Add(new Animal("Caballo", "caballo.jpg", "Equus caballus","El caballo es un mamífero herbívoro, de gran tamaño y extremidades largas, que pertenece a la familia de los équidos. "));
        if (checkElefante.IsChecked)
            GaleriaStorage.AnimalesSeleccionados.Add(new Animal("Elefante", "elefante.jpg", "Elephantidae","El elefante es un mamífero terrestre de gran tamaño, con orejas grandes, trompa prensil y colmillos. Es el animal terrestre más grande del mundo. "));
        
        //Confirmación visual
        DisplayAlert("Listo", "Animales añadidos a la galería personalizada", "OK");
    }
}
    



