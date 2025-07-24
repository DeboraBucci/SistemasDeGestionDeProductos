using SistemasDeGestionDeProductos.Service;

namespace SistemasDeGestionDeProductos
{
    internal static class Program
    {
        public static GestorDeRubros GestorDeRubros = new();
        public static GestorDeProductos GestorDeProductos = new();
        public static GestorDeProveedores GestorDeProveedores = new();

        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            Application.Run(new Menu());
        }
    }
}