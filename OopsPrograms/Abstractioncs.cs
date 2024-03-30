using System;

namespace OopsPrograms
{
    interface ISound
    {
        void MakeSound();
    }
    class Dog : ISound
    {
        public void MakeSound()
        {
            Console.WriteLine("Dog : Bow Bow");
        }
    }
    class Cat : ISound
    {
        public void MakeSound()
        {
            Console.WriteLine("Cat : Meow Meow");
        }
    }
    class Bird : ISound
    {
        public void MakeSound()
        {
            Console.WriteLine("Bird : Chrip Chrip");
        }
    }
}
