using System;
using System.Collections.Generic;
using System.Text;

namespace MultiPublisher
{
    public class FacebookMessagingService : IMessagingService
    {
        public void SendMessage(string message)
        {
            Console.WriteLine($"Enviando Mensaje por Facebook: {message}");
        }
    }
}
