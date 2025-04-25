using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practica08
{
 /// <summary>
 /// Clase que representa un animal dentro de la aplicación.
 /// Contiene información básica como nombre, imagen, nombre científico y descripción.
 /// </summary>
    public class Animal
    {
        // <summary>
        /// Nombre común del animal (por ejemplo: Perro, Gato, León).
        /// </summary>

        public string Nombre {get; set;}
        /// <summary>
        /// Ruta o nombre del archivo de imagen que representa al animal.
        /// Se espera que esté en Resources/Images del proyecto MAUI.
        /// </summary>
        public string Imagen {get; set;}
        /// <summary>
        /// Nombre científico del animal (por ejemplo: Canis lupus familiaris).
        /// </summary>
        public string NombreCientifico { get; set; }
        /// <summary>
        /// Descripción del animal. Texto explicativo que puede ser mostrado en la página de detalles.
        /// </summary>
        public string Descripcion { get; set; }
        /// <summary>
        /// Constructor de la clase Animal.
        /// Permite crear una instancia con todos los campos requeridos.
        /// </summary>
        /// <param name="nombre">Nombre común del animal.</param>
        /// <param name="imagen">Nombre o ruta del archivo de imagen.</param>
        /// <param name="nombreCientifico">Nombre científico del animal.</param>
        /// <param name="descripcion">Descripción detallada del animal.</param>
        public Animal(string nombre, string imagen, string nombreCientifico, string descripcion)
        {
            Nombre = nombre;
            Imagen = imagen;
            NombreCientifico = nombreCientifico;
            Descripcion = descripcion;
        }
    }
}
