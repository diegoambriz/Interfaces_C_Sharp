using System;
using System.Collections.Generic;
using System.Text;

namespace ExplicitImplementation
{
    public class Person : IPlayer, IMusician
    {
        void IPlayer.Play()
        {
            Console.WriteLine("Voy a jugar Xbox");
        }

        void IMusician.Play()
        {
            Console.WriteLine("Voy a tocar el piano");
        }

        public void Play()
        {
            Console.WriteLine("No se si tocar el piano o jugar Xbox");
        }
    }
}
