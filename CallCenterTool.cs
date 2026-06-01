using System.ComponentModel;
using ModelContextProtocol.Server;

namespace SimpleMcpServer;

[McpServerToolType, Description("Includes call center information.")]
public static class CallCenterTool
{
    [McpServerTool, Description("Returns count of calls by date.")]
    public static string GetCountOfCalls(DateOnly date)
        => $"At {date}, we had {Random.Shared.Next(1234, 4321)} calls.";
}