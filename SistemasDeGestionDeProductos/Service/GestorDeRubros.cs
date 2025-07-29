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
    public class GestorDeRubros : GestorBase<Rubro, RepositorioRubros>
    {
        public GestorDeRubros(RepositorioRubros repositorio) : base(repositorio)  {  }

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
    }
}
