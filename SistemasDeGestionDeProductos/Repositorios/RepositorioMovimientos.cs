using SistemasDeGestionDeProductos.Entidades;
using SistemasDeGestionDeProductos.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemasDeGestionDeProductos.Repositorios
{
    public class RepositorioMovimientos
    {
        private const string Archivo = "movimientos.json";
        private readonly List<MovimientoStock> _movimientos
          = JsonHelper.LeerDesdeArchivo<MovimientoStock>(Archivo);

        public void Agregar(MovimientoStock m)
        {
            _movimientos.Add(m);
            JsonHelper.GuardarEnArchivo(_movimientos, Archivo);
        }

        public IReadOnlyCollection<MovimientoStock> BuscarTodos()
          => _movimientos.AsReadOnly();
    }
}
