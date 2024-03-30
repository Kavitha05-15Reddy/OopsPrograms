using System;

namespace OopsPrograms
{
    //Base class
    public class Vehicle
    {
        public string name;
        public string color;
        
        public Vehicle(string name)
        {
            this.name = name;
        }

        public virtual void Start()
        {
            Console.WriteLine("vehicle started");
        }
        public virtual void Stop()
        {
            Console.WriteLine("vehicle stopped");
        }
        public virtual void Display()
        {
            Console.WriteLine($"Name:{name} , Color:{color}");
        }
    }
    public class Car : Vehicle
    {
        public Car(string name,string color) : base(name) 
        {
            this.color = color;
        }
        public override void Start()
        {
            Console.WriteLine("car started");
        }
        public override void Display()
        {
            Console.WriteLine($"Name:{name} , Color:{color}");
        }
    }
    public class Truck : Vehicle
    {
        public Truck(string name, string color) : base(name)
        {
            this.color = color;
        }
        public override void Stop()
        {
            Console.WriteLine("Truck stopped");
        }
        public override void Display()
        {
            Console.WriteLine($"Name:{name} , Color:{color}");
        }
    }
    public class MotorCycle : Vehicle
    {
        public MotorCycle(string name, string color) : base(name)
        {
            this.color = color;
        }
        public void Break()
        {
            Console.WriteLine("Motorcycle is breaked");
        }
        public override void Display()
        {
            Console.WriteLine($"Name:{name} , Color:{color}");
        }

    }
}
