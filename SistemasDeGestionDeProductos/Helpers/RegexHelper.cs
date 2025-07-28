using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace SistemasDeGestionDeProductos.Helpers
{
    public abstract class RegexHelper
    {
        private const string _emailPattern = @"^[A-Za-z0-9._%+-]+@[A-Za-z0-9.-]+\.[A-Za-z]{2,}$";
        private static readonly Regex _emailRegex = new(_emailPattern, RegexOptions.Compiled | RegexOptions.IgnoreCase);

        private const string _telefonoPattern = @"^\+?[1-9]\d{1,14}$";
        private static readonly Regex _telefonoRegex = new(_telefonoPattern, RegexOptions.Compiled);


        public static bool FormatoEmailValido(string email) => _emailRegex.IsMatch(email);

        public static bool FormatoTelefonoValido(string telefono) => _telefonoRegex.IsMatch(telefono);
    }
}
