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
        private static readonly string archivoMovimientos = "movimientos.json";
        private readonly List<MovimientoStock> _movimientos
          = JsonHelper.LeerDesdeArchivo<MovimientoStock>(archivoMovimientos);

        public void Agregar(MovimientoStock m)
        {
            _movimientos.Add(m);
            JsonHelper.GuardarEnArchivo(_movimientos, archivoMovimientos);
        }

        public IReadOnlyCollection<MovimientoStock> BuscarTodos()
          => _movimientos.AsReadOnly();
    }
}
