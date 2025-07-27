using SistemasDeGestionDeProductos.Entidades;
using SistemasDeGestionDeProductos.Helpers;
using SistemasDeGestionDeProductos.Repositorios;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemasDeGestionDeProductos.Service
{
    public class GestorDeRubros
    {
        private readonly RepositorioRubros repositorioRubros;

        public GestorDeRubros()
        {
            repositorioRubros = new();
        }

        public void CrearRubro(string nombre, string descripcion)
        {
            try
            {
                if (repositorioRubros.BuscarPorNombre(nombre) != null)
                    throw new Exception("Ya existe un rubro con ese nombre, intenta con otro.");

                Rubro rubro = new()
                {
                    Nombre = nombre,
                    Descripcion = descripcion
                };

                repositorioRubros.Agregar(rubro);

            }
            catch (Exception ex)
            {
                ErrorMessage.ShowErrorMessage(ex.Message);
            }

        }


        public bool EliminarRubro(Rubro rubro)
        {
            if (rubro.Nombre != null)
             return repositorioRubros.Eliminar(rubro);

            return false;
        }

        public void ModificarRubro(Guid? rubroId, string nombre, string descripcion)
        {
            if (rubroId != null)
                repositorioRubros.Modificar(rubroId.Value, nombre, descripcion);
        }

        public IReadOnlyCollection<Rubro> BuscarRubros() => repositorioRubros.BuscarTodos();

        public Rubro? BuscarRubroPorNombre(string nombre) => repositorioRubros.BuscarPorNombre(nombre);
        public Rubro? BuscarRubroPorId(Guid id)
        {
            var rubro = repositorioRubros.BuscarPorId(id);
            return rubro;
        }
    }
}
