using System;
using System.Collections.Generic;
using System.Text;

namespace ElephantObjects
{
    public class Elephant
    {
        public int EarSize;
        public string Name = "";

        public void WhoAmI()
        {
            Console.WriteLine("My name is " + Name + ".");
            Console.WriteLine("My ears are " + EarSize + " inches tall.");
        }

        public void HearMessage(string message, Elephant whoSaidit)
        {
            Console.WriteLine(Name + " heard a message");
            Console.WriteLine(whoSaidit.Name + " said this: " + message);
        }

        public void SpeakTo(Elephant whoToTalkTo, string message)
        {
            whoToTalkTo.HearMessage("Hi, Lloyd!", this);
        }
    }
}
