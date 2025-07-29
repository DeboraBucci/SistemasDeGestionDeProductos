using SistemasDeGestionDeProductos.Entidades;
using SistemasDeGestionDeProductos.Helpers;
using SistemasDeGestionDeProductos.Repositorios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace SistemasDeGestionDeProductos.Service
{
    public class GestorDeProductos : GestorBase<Producto, RepositorioProductos>
    {

        public GestorDeProductos(RepositorioProductos repositorio) : base(repositorio) { }


        public Producto Crear(string nombre, string descripcion, decimal precioUnitarioCompra, string nombreRubro)
        {
            // VERIFICAR SI EXISTE PRODUCTO
            var productoYaExistente = _repositorio.BuscarPorNombre(nombre);

            if (productoYaExistente != null)
                throw new InvalidOperationException("Ya existe un producto con el mismo nombre.");

            var rubroId = BuscarIdRubro(nombreRubro);

            if (rubroId == null)
                throw new InvalidOperationException("El rubro es invalido.");

            // CREAR PRODUCTO
            Producto producto = new()
            {
                Nombre = nombre,
                Descripcion = descripcion,
                PrecioUnitarioCompra = precioUnitarioCompra,
                IdRubro = rubroId.Value,
            };

            _repositorio.Agregar(producto);

            return producto;
        }

        public void Modificar(Guid? productoId, string nombre, string descripcion, decimal precioUnitarioCompra, string nombreRubro)
        {
            var rubroId = BuscarIdRubro(nombreRubro);

            if (productoId != null && rubroId != null)
                _repositorio.Modificar(productoId.Value, nombre, descripcion, precioUnitarioCompra, rubroId.Value);
        }


        public override IReadOnlyCollection<Producto> BuscarPorFiltro(string txt)
        {
            var texto = txt.Trim();
            IReadOnlyCollection<Producto> productosFiltrados = new List<Producto>();

            if (Guid.TryParse(texto, out var id))
            {
                var producto = _repositorio.BuscarPorId(id);

                if (producto != null)
                    productosFiltrados = Array.AsReadOnly(new[] {producto});
            }

            else
            {
                productosFiltrados = _repositorio.BuscarPorNombreContiene(texto);
            }

            return productosFiltrados;
        }


        public IReadOnlyCollection<Producto>? BuscarPorRubro(string nombreRubro)
        {
            var rubroId = BuscarIdRubro(nombreRubro);

            if (rubroId == null)
                return null;

            return _repositorio.BuscarPorRubro(rubroId.Value).Where(p => !p.Eliminado).ToList();
        }

        // MOVER A GESTOR RUBROS
        private Guid? BuscarIdRubro(string nombre)
        {
            var rubro = Program.GestorDeRubros.BuscarPorNombre(nombre);

            if (rubro == null)
                return null;

            return rubro.Id;
        }
    }
}
