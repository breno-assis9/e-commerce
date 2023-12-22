
using FluentValidation.Results;
using MediatR;
using sgc.Core.Messages;

namespace sgc.Core.Mediator
{
    public class MediatorHandler : IMediatorHandler
    {
        private readonly IMediator _mediator;

        public MediatorHandler(IMediator mediator)
        {
            _mediator = mediator;
        }

        public async Task PublicEvent<T>(T events) where T : Event
        {
            await _mediator.Publish(events);
        }

        public async Task<ValidationResult> SendCommand<T>(T comands) where T : Command
        {
            return await _mediator.Send(comands);
        }
    }
}
