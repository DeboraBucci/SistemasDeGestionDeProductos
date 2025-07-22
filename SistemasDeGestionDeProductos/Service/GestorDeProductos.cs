using SistemasDeGestionDeProductos.Entidades;
using SistemasDeGestionDeProductos.Repositorios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemasDeGestionDeProductos.Service
{
    internal class GestorDeProductos
    {
        private readonly RepositorioProductos repositorioProductos;

        public GestorDeProductos()
        {
            repositorioProductos = new RepositorioProductos();
        }

        public void CrearProducto(string nombre, string descripcion, double precioUnitario, int stock, Rubro rubro)
        {

        }
    }
}
