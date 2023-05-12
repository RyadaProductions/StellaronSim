using StellaronSim.Data.Models;

namespace StellaronSim.Data;

public class Parser
{
    public CalculatorConfig GetSimulationData(string json)
    {
        return CalculatorConfig.FromJson(json);
    }
}