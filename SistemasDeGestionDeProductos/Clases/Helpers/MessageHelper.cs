using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemasDeGestionDeProductos.Clases.Helpers
{
    public static class MessageHelper
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

        public static void ShowSuccessfulMessage(string msg)
        {
            MessageBox.Show(
                    text: msg,
                    caption: "Exito!",
                    buttons: MessageBoxButtons.OK,
                    icon: MessageBoxIcon.Information
            );
        }
    }
}
