﻿using System.Data;
using StellaronSim.Data.Models;
using StellaronSim.Data.Models.Generated;

namespace StellaronSim.Data.Converting;

public static class DamageTypeExtensions
{
    public static Element ToElement(this DamageType damageType)
    {
        if (!Enum.TryParse(damageType.Name, out Element element))
            throw new DataException($"Database is either corrupted or contains non existing/new element. Element name: {damageType.Name}");
            
        return element;
    }
}