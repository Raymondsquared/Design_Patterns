using DesignPatterns.Command.Solution.Abstractions;

namespace DesignPatterns.Command.Solution.Models
{
    public class Invoker : IInvoker
    {
        private readonly ICommand _command;

        public Invoker(ICommand command)
        {
            _command = command;
        }

        public void Invoke()
        {
            _command.Execute();
        }
    }
}
