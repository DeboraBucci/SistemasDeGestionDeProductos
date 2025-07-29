using System.Text.Json.Serialization;

namespace SistemasDeGestionDeProductos.Clases.Entidades
{
    public class Rubro : Entidad
    {
        public string Descripcion { get; set; } = string.Empty;

        public Rubro() { }

        [JsonConstructor]
        public Rubro(Guid id, string nombre, string descripcion)
        {
            Id = id;
            Nombre = nombre;
            Descripcion = descripcion;
        }
    }
}
