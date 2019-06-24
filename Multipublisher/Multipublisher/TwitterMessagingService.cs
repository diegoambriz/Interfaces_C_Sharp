using System;
using System.Collections.Generic;
using System.Text;

namespace MultiPublisher
{
    class TwitterMessagingService : IMessagingService
    {
        public void SendMessage(string message)
        {
            Console.WriteLine($"¡Enviando Mensaje por Twitter:  {message}");
        }
    }
}
