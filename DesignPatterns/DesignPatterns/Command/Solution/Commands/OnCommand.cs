using System;
using System.Collections.Generic;
using DesignPatterns.Command.Solution.Abstractions;

namespace DesignPatterns.Command.Solution.Commands
{
    public class OnCommand : ICommand
    {
        private readonly IEnumerable<Receiver> _receivers;

        public OnCommand(IEnumerable<Receiver> receivers)
        {
            _receivers = receivers;
        }
        
        public void Execute()
        {
            foreach (var receiver in _receivers)
            {
                try
                {
                    receiver.On();
                }
                catch (Exception)
                {
                    // ignored
                }
            }
        }
    }
}
