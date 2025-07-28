using SistemasDeGestionDeProductos.Service;

namespace SistemasDeGestionDeProductos
{
    internal static class Program
    {
        public static GestorDeRubros GestorDeRubros = new("rubros.json");
        public static GestorDeProductos GestorDeProductos = new("productos.json");
        public static GestorDeProveedores GestorDeProveedores = new("proveedores.json");
        public static GestorDeMovimientos GestorDeMovimientos = new("movimientos.json");

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