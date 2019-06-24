using System;
using System.Collections.Generic;
using System.Text;

namespace CarExample
{
	public class Person : IPlayer, IDrive
	{

		public void Drive()
		{
			Console.WriteLine("¡Empiezo a conducir!");
		}

		public void Play()
		{
			Console.WriteLine("¡Me voy a poner a jugar!");
		}
	}
}
