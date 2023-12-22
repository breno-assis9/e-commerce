using Microsoft.Extensions.DependencyInjection;
using sgc.MessageBus.Messages;

namespace sgc.MessageBus.Configurations
{
    public static class DependencyInjectionExtensions
    {
        public static IServiceCollection AddMessageBus(this IServiceCollection services, string connectionString)
        {
            if (string.IsNullOrEmpty(connectionString)) throw new ArgumentNullException();

            services.AddSingleton<IMessageBus>(new MessageBus.Messages.MessageBus(connectionString));

            return services;
        }
    }
}
