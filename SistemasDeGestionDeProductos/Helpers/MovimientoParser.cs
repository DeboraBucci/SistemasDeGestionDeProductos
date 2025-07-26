using System;
using System.Collections.Generic;
using System.IO;
using System.Text.Json;
using SistemasDeGestionDeProductos.Entidades;

public static class MovimientoParser
{
    private const string Path = "movimientos.json";

    public static List<MovimientoStock> LeerMovimientos()
    {
        if (!File.Exists(Path))
            return new List<MovimientoStock>();

        var json = File.ReadAllText(Path);
        using var doc = JsonDocument.Parse(json);

        var lista = new List<MovimientoStock>();
        foreach (var elem in doc.RootElement.EnumerateArray())
        {
            // 1) Leemos el campo Tipo como entero
            var tipoVal = elem.GetProperty("Tipo").GetInt32();
            var tipo = (TipoMovimiento)tipoVal;

            // 2) Convertimos TODO ese elemento a su texto crudo
            var raw = elem.GetRawText();

            // 3) Dependiendo del tipo, deserializamos
            MovimientoStock mov = tipo switch
            {
                TipoMovimiento.Ingreso => JsonSerializer
                    .Deserialize<IngresoStock>(raw)!,
                TipoMovimiento.Egreso => JsonSerializer
                    .Deserialize<EgresoStock>(raw)!,
                _ => throw new InvalidOperationException($"Tipo inválido: {tipo}")
            };

            lista.Add(mov);
        }

        return lista;
    }

    public static void GuardarMovimientos(IEnumerable<MovimientoStock> movimientos)
    {
        // Simplemente serializamos la lista entera — JSON plano con all props
        var options = new JsonSerializerOptions { WriteIndented = true };
        File.WriteAllText(Path,
            JsonSerializer.Serialize(movimientos, options));
    }
}
