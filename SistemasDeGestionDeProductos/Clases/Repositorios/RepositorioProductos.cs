using SistemasDeGestionDeProductos.Clases.Entidades;

namespace SistemasDeGestionDeProductos.Clases.Repositorios
{
    public class RepositorioProductos : RepositorioEntidad<Producto>
    {
        public RepositorioProductos(string path) : base(path) { }

        public void Modificar(Guid id, string nombre, string descripcion, decimal precioUnitarioCompra, Guid idRubro)
        {
            var producto = BuscarPorId(id);

            if (producto != null)
            {
                producto.Nombre = nombre;
                producto.Descripcion = descripcion;
                producto.PrecioUnitarioCompra = precioUnitarioCompra;
                producto.IdRubro = idRubro;
            }

            ActualizarArchivo();
        }


        public IReadOnlyCollection<Producto> BuscarPorRubro(Guid idRubro) => BuscarActivos().Where(p => p.IdRubro == idRubro).ToList();
    }
}
