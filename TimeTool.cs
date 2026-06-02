using System.ComponentModel;
using ModelContextProtocol.Server;

namespace SimpleMcpServer;

[McpServerToolType, Description("Includes 'Time' tools.")]
public static class TimeTool
{
    [McpServerTool, Description("Returns the current UTC time.")]
    public static string GetUtcTime() => DateTime.UtcNow.ToString("O");
}
