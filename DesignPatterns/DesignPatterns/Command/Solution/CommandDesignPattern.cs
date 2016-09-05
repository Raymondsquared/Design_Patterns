using System;
using System.Collections.Generic;
using DesignPatterns.Abstractions;
using DesignPatterns.Command.Solution.Abstractions;
using DesignPatterns.Command.Solution.Commands;
using DesignPatterns.Command.Solution.Models;

namespace DesignPatterns.Command.Solution
{
    public class CommandDesignPattern : IDesignPattern
    {
        public CommandDesignPattern()
        {
            
        }

        public CONSTANTS.DESIGN_PATTERN_TYPE Type()
        {
            return CONSTANTS.DESIGN_PATTERN_TYPE.COMMAND;
        }

        public void Run()
        {
            var lamp = new Lamp();
            var television = new Television();

            var masterReceivers = new List<Receiver>() { lamp, television };
            var tvReceivers = new List<Receiver>() { television };

            IInvoker onMasterInvoker = new Invoker(new OnCommand(masterReceivers));
            IInvoker offMasterInvoker = new Invoker(new OffCommand(masterReceivers));
            IInvoker upMasterInvoker = new Invoker(new UpCommand(masterReceivers));
            IInvoker downMasterInvoker = new Invoker(new DownCommand(masterReceivers));        

            IInvoker onTvInvoker = new Invoker(new OnCommand(tvReceivers));
            IInvoker offTvInvoker = new Invoker(new OffCommand(tvReceivers));
            IInvoker upTvInvoker = new Invoker(new UpCommand(tvReceivers));
            IInvoker downTvInvoker = new Invoker(new DownCommand(tvReceivers));

            Console.WriteLine(lamp);
            Console.WriteLine(television);      
            
            Console.WriteLine("\nSwitching All On :");
            onMasterInvoker.Invoke();

            Console.WriteLine(lamp);
            Console.WriteLine(television);

            Console.WriteLine("\nPressing All Down :");
            downMasterInvoker.Invoke();

            Console.WriteLine(lamp);
            Console.WriteLine(television);

            Console.WriteLine("\nPressing All Up 13x :");
            upMasterInvoker.Invoke();
            upMasterInvoker.Invoke();
            upMasterInvoker.Invoke();
            upMasterInvoker.Invoke();
            upMasterInvoker.Invoke();
            upMasterInvoker.Invoke();
            upMasterInvoker.Invoke();
            upMasterInvoker.Invoke();
            upMasterInvoker.Invoke();
            upMasterInvoker.Invoke();
            upMasterInvoker.Invoke();
            upMasterInvoker.Invoke();
            upMasterInvoker.Invoke();
            upMasterInvoker.Invoke();

            Console.WriteLine(lamp);
            Console.WriteLine(television);

            Console.WriteLine("\nSwitching All Off :");
            offMasterInvoker.Invoke();

            Console.WriteLine(lamp);
            Console.WriteLine(television);

            Console.WriteLine("\nSwitching Only TV On :");
            onTvInvoker.Invoke();

            Console.WriteLine(lamp);
            Console.WriteLine(television);
        }
    }
}
