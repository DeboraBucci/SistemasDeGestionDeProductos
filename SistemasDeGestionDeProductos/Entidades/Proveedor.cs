using SistemasDeGestionDeProductos.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace SistemasDeGestionDeProductos.Entidades
{
    public class Proveedor : Entidad
    {
        public string Contacto { get; set; } = string.Empty;
        public string Telefono { get; set; } = string.Empty;
        public string Direccion {  get; set; } = string.Empty;

        public Proveedor() { }

        [JsonConstructor]
        public Proveedor(Guid id, string nombre, string contacto, string telefono, string direccion, bool eliminado)
        {
            Id = id;
            Nombre = nombre;
            Contacto = contacto;
            Telefono = telefono;
            Direccion = direccion;
           Eliminado = eliminado;
        }
    }
}
