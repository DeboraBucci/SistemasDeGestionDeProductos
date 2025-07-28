using SistemasDeGestionDeProductos.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace SistemasDeGestionDeProductos.Entidades
{
    public class Proveedor : INombre, IConId
    {
        public Guid Id { get; private set;  }
        public string Nombre { get; set; } = string.Empty;
        public string Contacto { get; set; } = string.Empty;
        public string Telefono { get; set; } = string.Empty;
        public string Direccion {  get; set; } = string.Empty;

        public Proveedor()
        {
            Id = Guid.NewGuid();
        }

        [JsonConstructor]
        public Proveedor(Guid id, string nombre, string contacto, string telefono, string direccion)
        {
            Id = id;
            Nombre = nombre;
            Contacto = contacto;
            Telefono = telefono;
            Direccion = direccion;
        }
    }
}
