using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemasDeGestionDeProductos.Helpers
{
    public static class ErrorMessage 
    {
        public static void ShowErrorMessage(string msg)
        {
            MessageBox.Show(
                    text: msg,
                    caption: "Error",
                    buttons: MessageBoxButtons.OK,
                    icon: MessageBoxIcon.Error
            );
        }
    }
}
