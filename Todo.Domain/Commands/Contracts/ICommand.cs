using Flunt.Validations;

namespace Todo.Domain.Commands.Contracts
{
    public interface ICommand : IValidatable
    {
         //bool Validate(); IValidatable já possui o Validate()
    }
}