namespace practica08;
/// <summary>
/// P�gina que permite al usuario seleccionar animales para construir una galer�a personalizada.
/// Cada animal seleccionado se guarda como objeto de tipo <see cref="Animal"/> en GaleriaStorage.
/// </summary>
public partial class CreadorDeGalerias : ContentPage
{
    
    public CreadorDeGalerias()
	{
		InitializeComponent();
	}

    /// <summary>
    /// Evento que se ejecuta cuando el usuario pulsa el bot�n para guardar los animales seleccionados.
    /// Por cada checkbox marcado, se crea un objeto <see cref="Animal"/> y se guarda en <see cref="GaleriaStorage"/>.
    /// </summary>
    private void OnSeleccionarAnimales(object sender, EventArgs e)
    {
        // Limpiar selecci�n anterior
        GaleriaStorage.AnimalesSeleccionados.Clear();

        // A�adir animales seleccionados con sus datos completos (nombre, imagen, especie, descripci�n)
        if (checkPerro.IsChecked)
            GaleriaStorage.AnimalesSeleccionados.Add(new Animal("Perro", "perro.jpg", "Canis lupus familiaris","El perro es un mam�fero dom�stico de la familia de los c�nidos. Es un animal sociable, leal y afectuoso con los humanos. "));
        if (checkGato.IsChecked)
            GaleriaStorage.AnimalesSeleccionados.Add(new Animal("Gato", "gato.jpg", "Felis catus","Los gatos son mam�feros carn�voros con cuerpo cubierto de pelo, cuatro patas, cola, hocico corto, cabeza redondeada y orejas que pueden rotar. Son animales sociales y juguetones que pueden convivir con los humanos como mascotas. "));
        if (checkLeon.IsChecked)
            GaleriaStorage.AnimalesSeleccionados.Add(new Animal("Le�n", "leon.jpg", "Panthera leo","El le�n es un mam�fero carn�voro africano de gran tama�o, cabeza grande, dientes fuertes y cola larga. Es el segundo felino m�s grande en la actualidad, despu�s del tigre. "));
        if (checkCaballo.IsChecked)
            GaleriaStorage.AnimalesSeleccionados.Add(new Animal("Caballo", "caballo.jpg", "Equus caballus","El caballo es un mam�fero herb�voro, de gran tama�o y extremidades largas, que pertenece a la familia de los �quidos. "));
        if (checkElefante.IsChecked)
            GaleriaStorage.AnimalesSeleccionados.Add(new Animal("Elefante", "elefante.jpg", "Elephantidae","El elefante es un mam�fero terrestre de gran tama�o, con orejas grandes, trompa prensil y colmillos. Es el animal terrestre m�s grande del mundo. "));
        
        //Confirmaci�n visual
        DisplayAlert("Listo", "Animales a�adidos a la galer�a personalizada", "OK");
    }
}
    



