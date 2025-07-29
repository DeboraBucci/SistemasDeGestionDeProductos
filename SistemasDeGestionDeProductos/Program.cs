using SistemasDeGestionDeProductos.Repositorios;
using SistemasDeGestionDeProductos.Service;

namespace SistemasDeGestionDeProductos
{
    internal static class Program
    {
        private static RepositorioProductos _repositorioProductos = new("productos.json");
        private static RepositorioRubros _repositorioRubros = new("rubros.json");
        private static RepositorioProveedores _repositorioProveedores = new("proveedores.json");


        public static GestorDeProductos GestorDeProductos = new(_repositorioProductos);
        public static GestorDeRubros GestorDeRubros = new(_repositorioRubros);
        public static GestorDeProveedores GestorDeProveedores = new(_repositorioProveedores);

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