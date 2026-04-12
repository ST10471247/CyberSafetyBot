using System;
using System.Media;
using System.IO;

namespace CyberSafetyBot
{
    public class AudioService
    {
        public void PlayGreeting()
        {
            try
            {
                // Look for the audio file in different places
                string[] possiblePaths = {
                    "greeting.wav",
                    @"Resources\greeting.wav",
                    @"..\Resources\greeting.wav",
                    @"..\..\Resources\greeting.wav",
                    AppDomain.CurrentDomain.BaseDirectory + "greeting.wav",
                    AppDomain.CurrentDomain.BaseDirectory + @"Resources\greeting.wav"
                };

                string audioPath = null;

                foreach (string path in possiblePaths)
                {
                    if (File.Exists(path))
                    {
                        audioPath = path;
                        break;
                    }
                }

                if (audioPath != null)
                {
                    using (SoundPlayer player = new SoundPlayer(audioPath))
                    {
                        player.PlaySync();
                    }
                }
                else
                {
                    Console.WriteLine("[Voice greeting not found. Continuing with text mode.]");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"[Audio error: {ex.Message}]");
            }
        }
    }
}