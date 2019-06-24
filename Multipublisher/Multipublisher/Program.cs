using MultiPublisher;
using System;

namespace Multipublisher
{
    class Program
    {
        static void Main(string[] args)
        {
            var twitterMessagingService = new TwitterMessagingService();
            var facebookMesaagingService = new FacebookMessagingService();
            var linkedinMessagingService = new LinkedinMessagingService();
            MessagingHelper.SayHelloAllServices(twitterMessagingService, facebookMesaagingService, linkedinMessagingService);
        }
    }
}
