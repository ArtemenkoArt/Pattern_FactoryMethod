using System;

namespace FactoryMethodMy.Message
{
    public class TelegramMessage : MessageBase
    {
        public TelegramMessage(string text, string source, string target) : base(text, source, target)
        {
            //Some logic for twitter
        }

        public override void Send()
        {
            Console.WriteLine($"Telegram Mesaage: From: {Source}, to: {Target}, Text: {Text}");
        }
    }
}
