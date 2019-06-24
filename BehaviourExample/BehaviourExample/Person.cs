using System;
using System.Collections.Generic;
using System.Text;

namespace BehaviourExample
{
    public class Person : IPlayer, IDriver
    {
        public void Drive()
        {
            Console.WriteLine("Voy a Conducir");
        }

        public void Play()
        {
            Console.WriteLine("Voy a jugar con mi Consola");
        }
    }
}
