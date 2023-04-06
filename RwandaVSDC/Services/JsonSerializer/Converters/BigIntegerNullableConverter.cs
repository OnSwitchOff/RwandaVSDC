using RwandaVSDC.Services.JsonSerializer.Extensions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Reflection;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace RwandaVSDC.Services.JsonSerializer.Converters
{
    public class BigIntegerNullableConverter : JsonConverter<BigInteger?>
    {
        public override BigInteger? Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
        {
            string? input = Encoding.UTF8.GetString(reader.ValueSpan); 
            return string.IsNullOrEmpty(input) ? null : BigInteger.Parse(input);
        }

        public override void Write(Utf8JsonWriter writer, BigInteger? value, JsonSerializerOptions options)
        {
            if (value is null)
            {
                writer.WriteNullValue();
                return;
            }
            writer.WriteBigIntegerNullableValue((BigInteger)value!);
        }
    }
}
