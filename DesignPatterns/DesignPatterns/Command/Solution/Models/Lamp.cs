using DesignPatterns.Command.Solution.Abstractions;

namespace DesignPatterns.Command.Solution.Models
{
    public class Lamp : Receiver
    {
        private int _brightness;

        public Lamp()
        {
            IsOn = false;
            _brightness = 0;
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
            if (IsOn && _brightness < 100) _brightness += 10;
        }

        public override void Down()
        {
            if(IsOn && _brightness > 10) _brightness -= 10;
        }
        public override string ToString()
        {
            return $"Lamp IsOn : {IsOn} - Brightness : {_brightness}";
        }
    }
}
