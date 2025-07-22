using SistemasDeGestionDeProductos.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemasDeGestionDeProductos.Repositorios
{
    internal class RepositorioProductos
    {
        private readonly List<Producto> productos;

        public RepositorioProductos()
        {
            productos = new List<Producto>();
        }

        public void AgregarProducto(Producto producto) => productos.Add(producto);
    }
}
