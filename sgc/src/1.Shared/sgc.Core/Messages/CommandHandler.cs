using FluentValidation.Results;
using sgc.Core.Data;

namespace sgc.Core.Messages
{
    public abstract class CommandHandler
    {
        protected ValidationResult ValidationResult;

        protected CommandHandler()
        {
            ValidationResult = new ValidationResult();
        }

        protected void AddError(string mensagem)
        {
            ValidationResult.Errors.Add(new ValidationFailure(string.Empty, mensagem));
        }

        protected void AddErrors(List<ValidationFailure> falhasValidacoes)
        {
            ValidationResult.Errors.AddRange(falhasValidacoes);
        }

        protected async Task<ValidationResult> PersistiData(IUnitOfWork uow)
        {
            if (!await uow.Commit()) AddError("Houve um erro ao persistir os dados");

            return ValidationResult;
        }
    }
}
