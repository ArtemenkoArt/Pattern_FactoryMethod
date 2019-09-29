using System;

namespace FactoryMethodMy.Message
{
    public class TwitterMessage : MessageBase
    {
        public TwitterMessage(string text, string source, string target) : base(text, source, target)
        {
            //Some logic for twitter
        }

        public override void Send()
        {
            Console.WriteLine($"Twitter Mesaage: From: {Source}, to: {Target}, Text: {Text}");
        }
    }
}
