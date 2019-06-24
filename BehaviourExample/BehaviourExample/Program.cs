using System;

namespace BehaviourExample
{
    class Program
    {
        static void Main(string[] args)
        {
            var car = new Car { Driver = new Person() };
            var game = new Game { Player = new Person() };
            var game2 = new Game { Player = new Dog() };

            car.Start();
            game.Play();
            game2.Play();
            Console.ReadLine();
        }
    }
}
