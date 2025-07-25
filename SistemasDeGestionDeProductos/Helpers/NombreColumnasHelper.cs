﻿using SistemasDeGestionDeProductos.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemasDeGestionDeProductos.Helpers
{
    public class NombreColumna
    {
        public string Nombre { get; }
        public string HeaderTxt { get; }

        internal NombreColumna(string nombre, string headerTxt)
        {
            Nombre = nombre;
            HeaderTxt = headerTxt;
        }
    }

    public static class NombreColumnasHelper
    {
        public static NombreColumna[] nombresColumnasProductos = [
            new("Nombre", "Nombre"),
            new("Descripcion", "Descripción"),
            new("PrecioUnitarioCompra", "Compra c/u"),
            new("PrecioUnitarioVenta", "Venta c/u"),
            new("Rubro", "Rubro"),
            new("Id", "Id"),
            ];

        public static NombreColumna[] nombresColumnasRubro = [
            new("Nombre", "Nombre"),
            new("Descripcion", "Descripción"),
            new("Id", "Id"),
            ];

        public static NombreColumna[] nombresColumnasProveedor = [
            new("Nombre", "Nombre"),
            new("Contacto", "Contacto"),
            new("Telefono", "Teléfono"),
            new("Direccion", "Dirección"),
            new("Id", "Id"),
            ];

        public static NombreColumna[] nombresColumnasMovimientos = [
            new("Producto", "Producto"),
            new("Tipo", "Tipo"),
            new("Stock", "Stock"),
            new("FechaMovimiento", "Fecha de Movimiento"),
            new("FechaVencimiento", "Fecha de Vencimiento"),
            new("Id", "Id"),
            ];

    }

}

