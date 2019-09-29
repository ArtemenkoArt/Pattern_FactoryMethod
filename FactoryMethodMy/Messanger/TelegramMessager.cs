using FactoryMethodMy.Message;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethodMy.Messanger
{
    public class TelegramMessager : MessangerBase
    {
        public TelegramMessager(string user, string pass) : base(user, pass)
        {

        }

        public override bool Authorize()
        {
            Console.WriteLine($"Telegram authorize: User: {UserName}, Password: {UserPass}, authorizated!");
            return true;
        }

        public override IMessage CreateMessage(string text, string source, string target)
        {
            var message = new TelegramMessage(text, source, target);
            return message;
        }
    }
}
