using System;
using System.Collections.Generic;
using System.Text;

namespace CarExample
{
	class Dog : IPlayer
	{
		public void Play()
		{
			Console.WriteLine("¡Voy a jugar con mmi pelota!");
		}
	}
}
