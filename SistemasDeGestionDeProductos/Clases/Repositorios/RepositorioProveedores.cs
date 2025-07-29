using SistemasDeGestionDeProductos.Clases.Entidades;

namespace SistemasDeGestionDeProductos.Clases.Repositorios
{
    public class RepositorioProveedores : RepositorioEntidad<Proveedor>
    {
        public RepositorioProveedores(string path) : base(path) { }

        public void Modificar(Guid id, string nombre, string contacto, string telefono, string direccion)
        {
            var proveedor = BuscarPorId(id);

            if (proveedor != null)
            {
                proveedor.Nombre = nombre;
                proveedor.Contacto = contacto;
                proveedor.Telefono = telefono;
                proveedor.Direccion = direccion;
            }

            ActualizarArchivo();
        }
    }
}
