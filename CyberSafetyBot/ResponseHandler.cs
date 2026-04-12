using System;
using System.Collections.Generic;

namespace CyberSafetyBot
{
    public class ResponseHandler
    {
        private Dictionary<string, string> responses;
        private Dictionary<string, string> topics;

        public ResponseHandler()
        {
            SetupResponses();
        }

        private void SetupResponses()
        {
            responses = new Dictionary<string, string>(StringComparer.OrdinalIgnoreCase);
            topics = new Dictionary<string, string>(StringComparer.OrdinalIgnoreCase);

            responses.Add("how are you", "I'm functioning well, thanks for asking! Ready to help you learn about cybersecurity.");
            responses.Add("what is your purpose", "My purpose is to educate people about online threats like phishing, malware, and social engineering scams.");
            responses.Add("what can i ask", "You can ask me about passwords, phishing, safe browsing, or suspicious links.");
            responses.Add("help", "I can teach you about:\n- Creating strong passwords\n- Spotting phishing emails\n- Safe internet browsing\n- Recognizing fake links\n\nJust type any of these topics!");
            responses.Add("hello", "Hi there! Want to learn about staying safe online?");
            responses.Add("hi", "Hello! I'm your cybersecurity guide. Ask me anything about online safety.");
            responses.Add("thanks", "You're welcome! Stay safe out there.");
            responses.Add("thank you", "Happy to help! Remember to always be careful online.");

            topics.Add("password", @"=== PASSWORD SAFETY TIPS ===

1. Use at least 12 characters in your passwords
2. Mix uppercase letters, lowercase letters, numbers, and symbols
3. Never reuse passwords across different websites
4. Use a password manager to keep track of everything
5. Turn on two-factor authentication whenever possible
6. change your password every 3-6 months

Bad passwords to avoid: password123, qwerty, your name, or 12345678");

            topics.Add("phishing", @"=== SPOTTING PHISHING SCAMS ===

Warning signs to look for:
• Emails asking you to 'verify your account immediately'
• Bad spelling and grammar mistakes
• Sender email addresses that look slightly wrong
• Links that don't match where they say they go
• Threats or urgent deadlines trying to scare you

If something seems suspicious, don't click anything! Contact the company directly using their official website.");

            topics.Add("safe browsing", @"=== SAFE BROWSING PRACTICES ===

• Look for 'https://' and the padlock icon in your address bar
• Don't download files from websites you don't trust
• Keep your browser updated to the latest version
• Be careful what you click on social media
• Use different passwords for different accounts
• Clear your browsing history and cache regularly");

            topics.Add("link", @"=== CHECKING SUSPICIOUS LINKS ===

Before clicking any link:
• Hover your mouse over it to see the real address
• Look for misspellings (like faceb00k.com instead of facebook.com)
• Be very careful with shortened links from bit.ly or tinyurl
• When in doubt, type the website address yourself
• Use a link scanner like VirusTotal to check suspicious links

One wrong click can lead to malware or stolen information!");
        }

        public string GetResponse(string input, string userName)
        {
            foreach (var response in responses)
            {
                if (input.ToLower().Contains(response.Key.ToLower()))
                {
                    return response.Value;
                }
            }

            foreach (var topic in topics)
            {
                if (input.ToLower().Contains(topic.Key.ToLower()))
                {
                    return topic.Value;
                }
            }

            return "I'm not sure I understand. Could you rephrase that? Try asking about passwords, phishing, safe browsing, or suspicious links. Type 'help' to see what I can do.";
        }
    }
}