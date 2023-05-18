using System.Data;
using System.Diagnostics.Contracts;
using StellaronSim.Data.Models;
using StellaronSim.Data.Models.Generated;

namespace StellaronSim.Data.Converting;

internal static class KeyExtensions
{
    [Pure]
    internal static BuffEffect ToBuffEffect(this Key key)
    {
        if (!Enum.TryParse(key.ToString(), out BuffEffect effect))
            throw new DataException("Database is either corrupted or contains non existing/new element.");

        return effect;
    }
}