using SistemasDeGestionDeProductos.Entidades;
using SistemasDeGestionDeProductos.Helpers;
using SistemasDeGestionDeProductos.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemasDeGestionDeProductos.Repositorios
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
