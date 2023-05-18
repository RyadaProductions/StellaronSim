namespace StellaronSim.Data.Converting;

internal static class LongExtensions
{
    internal static int ToInt(this long value)
    {
        return Convert.ToInt32(value);
    }
}