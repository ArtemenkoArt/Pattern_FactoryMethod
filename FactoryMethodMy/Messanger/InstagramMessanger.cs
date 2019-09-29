using FactoryMethodMy.Message;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethodMy.Messanger
{
    public class InstagramMessanger : MessangerBase
    {
        public InstagramMessanger(string user, string pass) : base(user, pass)
        {

        }

        public override bool Authorize()
        {
            Console.WriteLine($"Instagram authorize: User: {UserName}, Password: {UserPass}, authorizated!");
            return true;
        }

        public override IMessage CreateMessage(string text, string source, string target)
        {
            var message = new InstagramMessage(text, source, target);
            return message;
        }
    }
}
