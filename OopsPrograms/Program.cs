using System;

namespace OopsPrograms
{
    class Program
    {
        static void Main(string[] args)
        {
            //Inheritance:
            Car c = new Car("BMW", "red");
            c.Start();
            c.Display();
            Truck t = new Truck("Mahendra", "Blue");
            t.Stop();
            t.Display();
            MotorCycle m = new MotorCycle("Bullet", "Black");
            m.Break();
            m.Display();

            //Polymorphism:
            Circle circle = new Circle();
            circle.CalculateArea();
            Rectangle r = new Rectangle();
            r.CalculateArea();
            Triangle tri = new Triangle();
            tri.CalculateArea();

            //Abstaction:
            Dog dog = new Dog();
            dog.MakeSound();    
            Cat cat = new Cat();
            cat.MakeSound();
            Bird bird = new Bird();
            bird.MakeSound();

            //Constructor_Overloading:
            Student s1 = new Student("Ram" , 01);
            Student s2 = new Student(01 , 23);
            Student s3 = new Student("Sri", 01 , 25);

            //Encpasulation:
            BankAccount account = new BankAccount();
            account.Deposit(1000);
            account.Withdraw(500);
            account.GetBalance();
            SavingsAccount s = new SavingsAccount(1000);
            Console.WriteLine("Interest on savings account:" + s.CalculateInterest());
            CurrentAccount c1 = new CurrentAccount(2000);
            Console.WriteLine("Interest on current account:" + c1.CalculateInterest());


        }
    }
}
