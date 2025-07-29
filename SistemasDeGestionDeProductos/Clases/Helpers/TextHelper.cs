using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemasDeGestionDeProductos.Clases.Helpers
{
    public static class TextHelper
    {
        public static bool SonIgualesSinTildes(string a, string b)
        {
            var cmp = CultureInfo.CurrentCulture.CompareInfo;

            return cmp.Compare(a, b,
                CompareOptions.IgnoreCase | // IGNORECASE = ignorar mayúsculas/minúsculas
                CompareOptions.IgnoreNonSpace) == 0; // IGNORENONSPACE = ignorar diacríticos (tildes, diéresis, etc.)
        }
    }
}
