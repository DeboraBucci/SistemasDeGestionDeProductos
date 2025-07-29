using SistemasDeGestionDeProductos.Clases.Entidades;
using SistemasDeGestionDeProductos.Clases.Helpers;
using SistemasDeGestionDeProductos.Clases.Repositorios;

namespace SistemasDeGestionDeProductos.Clases.Service
{
    public class GestorDeRubros : GestorBase<Rubro, RepositorioRubros>
    {
        public GestorDeRubros(RepositorioRubros repositorio) : base(repositorio) { }

        public void Crear(string nombre, string descripcion)
        {
            try
            {
                if (_repositorio.BuscarPorNombre(nombre) != null)
                    throw new Exception("Ya existe un rubro con ese nombre, intenta con otro.");

                Rubro rubro = new()
                {
                    Nombre = nombre,
                    Descripcion = descripcion
                };

                _repositorio.Agregar(rubro);

            }
            catch (Exception ex)
            {
                MessageHelper.ShowErrorMessage(ex.Message);
            }
        }


        public void Modificar(Guid? rubroId, string nombre, string descripcion)
        {
            if (rubroId != null)
                _repositorio.Modificar(rubroId.Value, nombre, descripcion);
        }

        public override bool Eliminar(Rubro rubro)
        {
            var productosDelRubro = Program.GestorDeProductos.BuscarPorRubro(rubro.Nombre ?? string.Empty);

            if (productosDelRubro?.Count > 0)
                throw new Exception("El rubro seleccionado no puede eliminarse ya que tiene productos asociados.");

            return base.Eliminar(rubro);
        }
    }
}
