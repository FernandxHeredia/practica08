namespace practica08;

/// <summary>
/// P�gina de detalles que muestra la informaci�n de una nimal.
/// Utiliza BindingCOntext para recibir y enlazar un objeto de tipo Animal desde otra p�gina.
/// </summary>
public partial class Detalles : ContentPage
{
	/// <summary>
	/// Constructor de la p�gina, recibe un objeto animal y lo asigna como BindingContext.
	/// Esto permite mostrar las propiedades del animal a la interfaz de usuario con data binding.
	/// </summary>
	/// <param name="animal">Es el animal que se envia para mostrar los detalles</param>
	public Detalles(Animal animal)
	{
		InitializeComponent();
		BindingContext= animal;
	}
}