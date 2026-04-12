using System;

namespace CyberSafetyBot
{
    public class Chatbot
    {
        private AudioService audio;
        private UIService ui;
        private ResponseHandler responder;
        private string userName;

        public Chatbot()
        {
            audio = new AudioService();
            ui = new UIService();
            responder = new ResponseHandler();
        }

        public void Start()
        {
            // Play voice greeting first
            audio.PlayGreeting();

            //Wait a moment for audio to finish before showing art
            Thread.Sleep(500);

            // Then show everything else
            ui.DisplayAsciiArt();
            ui.ShowBorder("WELCOME TO CYBERSECURITY AWARENESS BOT");

            userName = ui.GetUserName();
            ui.ShowWelcomeMessage(userName);

            RunConversation();
        }

        private void RunConversation()
        {
            bool running = true;

            while (running)
            {
                string input = ui.GetUserInput();

                if (string.IsNullOrWhiteSpace(input))
                {
                    ui.ShowMessage("Please type something. I can't read your mind yet!", ConsoleColor.Red);
                    continue;
                }

                if (input.ToLower() == "exit" || input.ToLower() == "quit" || input.ToLower() == "bye")
                {
                    ui.ShowGoodbye(userName);
                    running = false;
                    break;
                }

                string response = responder.GetResponse(input, userName);
                ui.ShowBotResponse(response);
            }
        }
    }
}