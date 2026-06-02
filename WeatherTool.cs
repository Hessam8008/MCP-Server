using System.ComponentModel;
using ModelContextProtocol.Server;

namespace SimpleMcpServer;

[McpServerToolType, Description("Includes 'Weather' tools.")]
public static class WeatherTool
{
    [McpServerTool, Description("Returns the current temperature of the city.")]
    public static string GetTemprature(
        [Description("City name for getting temperature.")] string city
    ) => $"Temperature of the {city} is {Random.Shared.Next(10, 60)} °C (Centigrade)";
}
