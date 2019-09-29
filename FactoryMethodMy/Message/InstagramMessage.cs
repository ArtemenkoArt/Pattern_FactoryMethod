using System;

namespace FactoryMethodMy.Message
{
    public class InstagramMessage : MessageBase
    {
        public InstagramMessage(string text, string source, string target) : base(text, source, target)
        {
            //Some logic for Instagram
        }

        public override void Send()
        {
            Console.WriteLine($"Instagram Mesaage: From: {Source}, to: {Target}, Text: {Text}");
        }
    }
}
