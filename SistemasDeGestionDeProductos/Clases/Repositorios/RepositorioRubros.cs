using SistemasDeGestionDeProductos.Clases.Entidades;

namespace SistemasDeGestionDeProductos.Clases.Repositorios
{
    public class RepositorioRubros : RepositorioEntidad<Rubro>
    {
        public RepositorioRubros(string path) : base(path) { }

        public void Modificar(Guid id, string nombre, string descripcion)
        {
            var rubro = BuscarPorId(id);

            if (rubro != null)
            {
                rubro.Nombre = nombre;
                rubro.Descripcion = descripcion;
            }

            ActualizarArchivo();
        }
    }
}
