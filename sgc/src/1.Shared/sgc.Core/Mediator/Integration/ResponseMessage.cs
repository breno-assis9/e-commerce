using FluentValidation.Results;
using sgc.Core.Messages;

namespace sgc.Core.Mediator.Integration
{
    public class ResponseMessage : Message
    {
        public ValidationResult ValidationResult { get; private set; }

        public ResponseMessage(ValidationResult validationResult)
        {
            ValidationResult = validationResult;
        }
    }
}
