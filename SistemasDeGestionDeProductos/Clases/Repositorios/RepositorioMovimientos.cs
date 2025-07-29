using SistemasDeGestionDeProductos.Clases.Entidades;

namespace SistemasDeGestionDeProductos.Clases.Repositorios
{
    public class RepositorioMovimientos : RepositorioBase<MovimientoStock>
    {
        public RepositorioMovimientos(string path) : base(path) { }

        public IReadOnlyCollection<MovimientoStock> BuscarPorProveedor(Guid proveedorId) =>
            _items
            .Where(m => m.Tipo == TipoMovimiento.Ingreso && m.ProveedorId == proveedorId)
            .ToList();

        public IReadOnlyCollection<MovimientoStock> BuscarPorTipo(TipoMovimiento tipo) =>
            _items
            .Where(m => m.Tipo == tipo)
            .ToList();
    }
}
