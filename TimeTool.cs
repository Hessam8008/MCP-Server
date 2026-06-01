using System.ComponentModel;
using ModelContextProtocol.Server;

namespace SimpleMcpServer;

[McpServerToolType, Description("Includes time and weather tools.")]
public static class TimeTool
{
    [McpServerTool, Description("Returns the current UTC time.")]
    public static string GetTime()
        => DateTime.UtcNow.ToString("O");

    [McpServerTool, Description("Returns the current temperature of the city.")]
    public static string GetTemprature(string city)
        => $"Temperature of the {city} is {Random.Shared.Next(10, 60)} °C (Centigrade)";

}
