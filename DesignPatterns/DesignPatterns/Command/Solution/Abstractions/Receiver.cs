namespace DesignPatterns.Command.Solution.Abstractions
{
    public abstract class Receiver
    {
        protected bool IsOn { get; set; }

        public abstract void On();
        public abstract void Off();
        public abstract void Up();
        public abstract void Down();        
    }
}
