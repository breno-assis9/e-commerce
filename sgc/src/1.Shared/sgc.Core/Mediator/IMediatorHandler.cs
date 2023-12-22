using FluentValidation.Results;
using sgc.Core.Messages;

namespace sgc.Core.Mediator
{
    public interface IMediatorHandler
    {
        Task PublicEvent<T>(T events) where T : Event;
        Task<ValidationResult> SendCommand<T>(T comands) where T : Command;
    }
}
