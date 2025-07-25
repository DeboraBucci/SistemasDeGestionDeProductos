using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemasDeGestionDeProductos.Validadores
{
    public class RubroInput
    {
        public string Nombre;
        public string Descripcion;

        public RubroInput(string nombre, string descripcion)
        {
            Nombre = nombre;
            Descripcion = descripcion;
        }
    }

    public static class ValidadorInputRubro
    {
        public static RubroInput ValidarInformacion(string nombreTxt, string descripcionTxt)
        {
            string nombre = nombreTxt.Trim();
            string descripcion = descripcionTxt.Trim();

            if (nombre == "")
                throw new Exception("El nombre del rubro no puede estar vacio.");

            return new RubroInput(nombre, descripcion);
        }
    }
}
