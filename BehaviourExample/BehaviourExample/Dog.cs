using System;
using System.Collections.Generic;
using System.Text;

namespace BehaviourExample
{
    public class Dog : IPlayer
    {
        public void Play()
        {
            Console.WriteLine("Voy a jugar con mi Pelota");
        }
    }
}
