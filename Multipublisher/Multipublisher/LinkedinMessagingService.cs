using System;
using System.Collections.Generic;
using System.Text;

namespace MultiPublisher
{
    public class LinkedinMessagingService : IMessagingService
    {
        public void SendMessage(string message)
        {
            Console.WriteLine($"Enviando Mensaje por Linkedin: {message}");
        }
    }
}
