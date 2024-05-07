using System.Text.Json;
using System.Text;

namespace gRPC.template.server.Filters.Internal;

public static class Base64Serializer
{
    public static string ToBase64(this object obj)
    {
        string json = JsonSerializer.Serialize(obj);

        byte[] bytes = Encoding.Default.GetBytes(json);

        return Convert.ToBase64String(bytes);
    }
}
