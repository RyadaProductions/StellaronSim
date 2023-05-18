using System.Diagnostics.Contracts;

namespace StellaronSim.Data.Converting;

internal static class LongExtensions
{
    [Pure]
    internal static int ToInt(this long value)
    {
        return Convert.ToInt32(value);
    }
}