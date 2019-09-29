using FactoryMethodMy.Message;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethodMy.Messanger
{
    public class TwitterMessanger : MessangerBase
    {
        public TwitterMessanger(string user, string pass) : base(user, pass)
        {

        }

        public override bool Authorize()
        {
            Console.WriteLine($"Twitter authorize: User: {UserName}, Password: {UserPass}, authorizated!");
            return true;
        }

        public override IMessage CreateMessage(string text, string source, string target)
        {
            var message = new TwitterMessage(text, source, target);
            return message;
        }
    }
}
