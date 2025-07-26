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
        private readonly List<MovimientoStock> _movimientos
          = MovimientoParser.LeerMovimientos();

        public void Agregar(MovimientoStock m)
        {
            _movimientos.Add(m);
            MovimientoParser.GuardarMovimientos(_movimientos);
        }

        public IReadOnlyCollection<MovimientoStock> BuscarTodos()
          => _movimientos.AsReadOnly();
    }
}
