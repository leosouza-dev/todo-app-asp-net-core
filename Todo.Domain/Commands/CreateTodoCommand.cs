using System;
using Todo.Domain.Commands.Contracts;

namespace Todo.Domain.Commands
{
    public class CreateTodoCommand : ICommand // será usado na api - como entrada (da tela pra api)
    {
        public CreateTodoCommand()
        {
            
        }

        public CreateTodoCommand(string title, string user, DateTime date)
        {
            Title = title;
            User = user;
            Date = date;
        }

        // ação para criar um todoItem - precisamos das propriedades
        public string Title { get; set; }
        public string User { get; set; }
        public DateTime Date { get; set; }

        public void Validate()
        {
            throw new NotImplementedException();
        }
    }
}