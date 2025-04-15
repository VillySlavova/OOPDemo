using System;

namespace OOPDemo.Models
{
    
    public class BaseMachine
    {
        public virtual string Model { get; set; }

        public virtual void ShowInfo()
        {
            Console.WriteLine($"BaseMachine: {Model}");
        }
    }


    public abstract class IntermediateMachine : BaseMachine

    {
        public override void ShowInfo()
        {
            Console.WriteLine($"IntermediateMachine: {Model}");
        }

        public abstract void Start(); 
    }

    
    public class AdvancedMachine : IntermediateMachine
    {
        public override string Model { get; set; }

        public sealed override void ShowInfo()
        {
            Console.WriteLine($"AdvancedMachine: {Model}");
        }

        public override void Start()
        {
            Console.WriteLine("AdvancedMachine starting...");
        }
    }

    
    internal class UltraMachine : AdvancedMachine
    {
        public override string Model { get; set; }

    }
}
