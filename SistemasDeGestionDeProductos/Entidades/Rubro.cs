using SistemasDeGestionDeProductos.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace SistemasDeGestionDeProductos.Entidades
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
