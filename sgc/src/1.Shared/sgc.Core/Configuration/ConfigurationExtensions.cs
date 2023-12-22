using Microsoft.Extensions.Configuration;

namespace sgc.Core.Configuration
{
    public static class ConfigurationExtensions
    {
        public static string? GetMessageQueueConnection(this IConfiguration configuration, string name)
            => configuration?.GetSection("MessageQueueConnection")?[name];
    }
}
