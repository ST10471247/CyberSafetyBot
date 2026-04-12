using System;

namespace CyberSafetyBot
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Cyber Safety Bot Protecting Mzansi!!";
            Chatbot bot = new Chatbot();
            bot.Start();

            Console.WriteLine("\nPress any key to exit...");
            Console.ReadKey();
        }
    }
}