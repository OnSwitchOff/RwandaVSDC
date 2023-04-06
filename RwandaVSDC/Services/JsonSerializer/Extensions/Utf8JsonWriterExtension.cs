using Newtonsoft.Json.Linq;
using System;
using System.Buffers.Text;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Numerics;
using System.Reflection;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace RwandaVSDC.Services.JsonSerializer.Extensions
{
    public static class Utf8JsonWriterExtension
    {
        public static void WriteBigIntegerNullableValue(this Utf8JsonWriter writer, BigInteger bigInteger)
        {
            string input = bigInteger.ToString()!;

            // Split the BigInteger value into multiple numbers of at most 19 digits.
            const int maxLength = 19;
            int length = input.Length;
            int count = (length + maxLength - 1) / maxLength; // Round up division
            decimal[] result = new decimal[count];
            for (int i = 0; i < count; i++)
            {
                int start = i * maxLength;
                int end = Math.Min(start + maxLength, length);
                result[i] = decimal.Parse(input.Substring(start, end - start));

                // If there are more numbers to write, use the minimized number format.
                if (i < count - 1)
                {
                    var method = typeof(Utf8JsonWriter).GetMethod("WriteNumberValueMinimized", BindingFlags.Instance | BindingFlags.NonPublic, null, new[] { typeof(decimal) }, null);
                    if (method != null)
                    {
                        method.Invoke(writer, new object[] { result[i] });
                        continue;
                    }
                }
                // Write the number value using the default number format.
                writer.WriteNumberValue(result[i]);
            }



            //int bytesPending = writer.BytesPending;

            //var memoryfield = typeof(Utf8JsonWriter).GetField("_memory", BindingFlags.Instance | BindingFlags.NonPublic);
            //var memoryValue = (Memory<byte>)memoryfield!.GetValue(writer)!;

            //Span<byte> output = memoryValue.Span;

            //var baseStr = Encoding.UTF8.GetString(output.Slice(0, bytesPending).ToArray());

            //var additional = Encoding.UTF8.GetBytes(bigInteger.ToString());

            //Memory<byte> memory = new Memory<byte>(Encoding.UTF8.GetBytes(baseStr + bigInteger.ToString()));

            //memoryfield!.SetValue(writer, memory);

            //var bytesPendingProperty = typeof(Utf8JsonWriter).GetProperty("BytesPending");
            //bytesPendingProperty!.SetValue(writer, bytesPending + additional.Length);

            //var method = typeof(Utf8JsonWriter).GetMethod("SetFlagToAddListSeparatorBeforeNextItem", BindingFlags.Instance | BindingFlags.NonPublic);
            //if (method != null)
            //{
            //    method.Invoke(writer, new object?[] {} );
            //}

            //var tokenTypefield = typeof(Utf8JsonWriter).GetField("_tokenType", BindingFlags.Instance | BindingFlags.NonPublic);
            //tokenTypefield!.SetValue(writer, JsonTokenType.Number);
        }
    }
}
