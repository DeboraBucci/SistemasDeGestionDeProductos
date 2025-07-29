using SistemasDeGestionDeProductos.Clases.Entidades;
using SistemasDeGestionDeProductos.Clases.Repositorios;

namespace SistemasDeGestionDeProductos.Clases.Service
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

        public IReadOnlyCollection<Producto> BuscarPorFiltro(Guid? idRubro = null, string? txt = null) =>
            _repositorio
            .BuscarActivos()
            .Where(p => idRubro == null || p.IdRubro == idRubro)
            .Where(p => 
                    txt == null || 
                    p.Nombre.Contains(txt, StringComparison.OrdinalIgnoreCase) ||
                    p.Id.ToString().Contains(txt))
            .ToList()
            .AsReadOnly();

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
