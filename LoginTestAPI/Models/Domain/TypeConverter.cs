/*using System.Text.Json;
using System.Text.Json.Serialization;
using Newtonsoft.Json.Serialization;

namespace LoginTestAPI.Models.Domain
{
    public class TypeConverter : JsonConverter<Type>
    {
        public override Type? Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
        {
            throw new NotImplementedException("Deserialization of System.Type is not supported.");
        }

        public override void Write(Utf8JsonWriter writer, Type value, JsonSerializerOptions options)
        {
            throw new NotImplementedException();
        }
    }
}
*/