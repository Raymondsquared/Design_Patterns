using System.Collections.Generic;
using DesignPatterns.Command.Solution.Abstractions;

namespace DesignPatterns.Command.Solution.Models
{
    public class Television : Receiver
    {
        private readonly LinkedList<string> _channels;

        private LinkedListNode<string> _channel;

        public Television()
        {
            IsOn = false;            
            _channels = new LinkedList<string>(new List<string>()
            {
                "A",
                "B",
                "C",
                "D",
                "E"
            });
            _channel = _channels.First;
        }

        public override void On()
        {
            IsOn = true;
        }

        public override void Off()
        {
            IsOn = false;
        }
        public override void Up()
        {
            if (IsOn)
            {
                var next = _channel.Next;
                _channel = next ?? _channels.First;
            }
        }

        public override void Down()
        {
            if (IsOn)
            {
                var previous = _channel.Previous;
                _channel = previous ?? _channels.Last;
            }
        }
        public override string ToString()
        {
            return $"Television IsOn : {IsOn} - Channel : {_channel.Value}";
        }
    }
}
