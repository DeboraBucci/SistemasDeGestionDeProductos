using SistemasDeGestionDeProductos.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace SistemasDeGestionDeProductos.Entidades
{
    public class Proveedor : INombre
    {
        public Guid Id { get; private set;  }
        public string? Nombre { get; set; } = null;
        public string? Contacto { get; set; } = null;
        public string? Telefono { get; set; } = null;
        public string? Direccion {  get; set; } = null;

        public Proveedor()
        {
            Id = Guid.NewGuid();
        }

        [JsonConstructor]
        public Proveedor(Guid id, string? nombre, string? contacto, string? telefono, string? direccion)
        {
            Id = id;
            Nombre = nombre;
            Contacto = contacto;
            Telefono = telefono;
            Direccion = direccion;
        }
    }
}
