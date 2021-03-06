﻿using System;
using System.Collections.Generic;
using DesignPatterns.Command.Solution.Abstractions;

namespace DesignPatterns.Command.Solution.Commands
{
    public class OffCommand : ICommand
    {
        private readonly IEnumerable<Receiver> _receivers;
        public OffCommand(IEnumerable<Receiver> receivers)
        {
            _receivers = receivers;
        }

        public void Execute()
        {
            foreach (var receiver in _receivers)
            {
                try
                {
                    receiver.Off();
                }
                catch (Exception)
                {
                    // ignored
                }
            }
        }
    }
}
