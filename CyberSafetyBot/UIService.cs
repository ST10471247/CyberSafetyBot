using System;
using System.Threading;

namespace CyberSafetyBot
{
    public class UIService
    {
        public void DisplayAsciiArt()
        {
            Console.ForegroundColor = ConsoleColor.Cyan;
            string art = @"
    *********************************************
    *         CYBER SAFETY BOT          *
    *               ASSISTANT                  *
    *                                           *
    *              [  LOCK  ]                   *
    *              [ SHIELD ]                   *
    *              [ ALERT  ]                   *
    *                                           *
    *    Protecting South African Citizens     *
    *********************************************";
            Console.WriteLine(art);
            Console.ResetColor();
            Console.WriteLine();
        }

        public void ShowBorder(string text)
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("╔════════════════════════════════════════╗");
            Console.WriteLine($"║{text.PadLeft(34).PadRight(34)}║");
            Console.WriteLine("╚════════════════════════════════════════╝");
            Console.ResetColor();
            Console.WriteLine();
        }

        public string GetUserName()
        {
            Console.Write("Please enter your name: ");
            string name = Console.ReadLine();

            while (string.IsNullOrWhiteSpace(name))
            {
                Console.Write("Name cannot be empty. Please enter your name: ");
                name = Console.ReadLine();
            }

            return name;
        }

        public void ShowWelcomeMessage(string name)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine($"\nHello {name}! I'm your Cybersecurity Assistant.");
            Console.ResetColor();

            Console.WriteLine("I'm here to teach you about online safety.\n");

            ShowHelp();
        }

        public void ShowHelp()
        {
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine("What I can help you with:");
            Console.ResetColor();
            Console.WriteLine("• Password safety");
            Console.WriteLine("• Phishing scams");
            Console.WriteLine("• Safe browsing");
            Console.WriteLine("• Suspicious links");
            Console.WriteLine("• Type 'help' anytime to see this again");
            Console.WriteLine("• Type 'exit' to leave\n");
        }

        public string GetUserInput()
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write("\nYou > ");
            Console.ResetColor();

            return Console.ReadLine();
        }

        public void ShowBotResponse(string response)
        {
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.Write("Bot > ");
            Console.ResetColor();

            foreach (char c in response)
            {
                Console.Write(c);
                Thread.Sleep(15);
            }
            Console.WriteLine();
        }

        public void ShowMessage(string message, ConsoleColor color)
        {
            Console.ForegroundColor = color;
            Console.WriteLine(message);
            Console.ResetColor();
        }

        public void ShowGoodbye(string name)
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("\n*********************************************");
            Console.WriteLine("*           STAY SAFE ONLINE!              *");
            Console.WriteLine("*                                           *");
            Console.WriteLine("*      Remember: Think before you click!   *");
            Console.WriteLine("*********************************************");
            Console.ResetColor();
            Console.WriteLine($"\nGoodbye {name}! Keep learning about cybersecurity.");
        }
    }
}