using SistemasDeGestionDeProductos.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Text.Json;
using System.Threading.Tasks;

namespace SistemasDeGestionDeProductos.Helpers
{
    public class MovimientoStockConverter : JsonConverter<MovimientoStock>
    {
            // TODO: REVISAR CLASE
            public override MovimientoStock? Read(
                ref Utf8JsonReader reader,
                Type typeToConvert,
                JsonSerializerOptions options)
            {
                using var doc = JsonDocument.ParseValue(ref reader);
                var root = doc.RootElement;

                if (!root.TryGetProperty("Tipo", out var tipoProp))
                    throw new JsonException("Falta la propiedad 'Tipo'.");

                TipoMovimiento tipo;

                if (tipoProp.ValueKind == JsonValueKind.String)
                    tipo = Enum.Parse<TipoMovimiento>(tipoProp.GetString()!);

                else if (tipoProp.ValueKind == JsonValueKind.Number)
                    tipo = (TipoMovimiento)tipoProp.GetInt32();

                else
                    throw new JsonException($"Tipo inválido: {tipoProp.ValueKind}");

                MovimientoStock mov = tipo switch
                {
                    TipoMovimiento.Ingreso => JsonSerializer.Deserialize<IngresoStock>(root.GetRawText(), options)!,
                    TipoMovimiento.Egreso => JsonSerializer.Deserialize<EgresoStock>(root.GetRawText(), options)!,
                    _ => throw new JsonException($"Tipo desconocido: {tipo}")
                };

                return mov;
            }

            public override void Write(
                Utf8JsonWriter writer,
                MovimientoStock value,
                JsonSerializerOptions options)
            {
                switch (value)
                {
                    case IngresoStock ingreso:
                        JsonSerializer.Serialize(writer, ingreso, options);
                        break;

                    case EgresoStock egreso:
                        JsonSerializer.Serialize(writer, egreso, options);
                        break;

                    default:
                        throw new JsonException("Tipo de movimiento no soportado.");
                }
            }
    }
}
