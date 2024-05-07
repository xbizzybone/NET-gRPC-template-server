using MemoryPack;
using System.Runtime.Serialization.Formatters.Binary;

namespace gRPC.template.server.Filters.Internal;

internal static class BinarySerializer
{
    public static byte[] ToBytes<T>(this T objectToSerialize)
    {
        return MemoryPackSerializer.Serialize(objectToSerialize);
    }
}
