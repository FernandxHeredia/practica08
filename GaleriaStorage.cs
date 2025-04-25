using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practica08
{
    /// <summary>
    /// Clase estática que actúa como almacenamiento temporal en memoria
    /// para los animales seleccionados por el usuario al crear una galería personalizada.
    /// 
    /// Esta clase permite compartir datos entre páginas sin necesidad de pasar parámetros directamente.
    /// </summary>
    class GaleriaStorage
    {
        /// <summary>
        /// Lista estática que contiene los animales seleccionados por el usuario.
        /// Se accede desde cualquier parte de la aplicación.
        /// </summary>
        public static List<Animal> AnimalesSeleccionados { get; set; } = new();
    }
}
