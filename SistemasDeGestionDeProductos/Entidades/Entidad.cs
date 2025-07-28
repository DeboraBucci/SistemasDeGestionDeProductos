using SistemasDeGestionDeProductos.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemasDeGestionDeProductos.Entidades
{
    public abstract class Entidad : INombre, IConId
    {
        public Guid Id { get;  set; }
        public string Nombre { get; set; } = string.Empty;
        public bool Eliminado { get; set; } = false;
        
        public Entidad()
        {
            Id = Guid.NewGuid();
        }

        public void Eliminar() => Eliminado = true;
    }
}
