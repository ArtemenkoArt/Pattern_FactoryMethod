using FactoryMethodMy.Messanger;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethodMy
{
    class Program
    {
        static void Main(string[] args)
        {
            var messanger = new TestMessanger("SuperUser", "SuperPass");
            messanger.SendMessage("Test message 1", "Admin", "CommonUser");

            Console.WriteLine(new String('-', 40));

            var twitter = new TwitterMessanger("SuperUser", "SuperPass");
            var twit = twitter.CreateMessage("Twitter test message!", "Admin", "CommonUser");
            twit.Send();

            Console.WriteLine(new String('-', 40));

            var instagram = new InstagramMessanger("SuperUser", "SuperPass");
            var insta = instagram.CreateMessage("Instagram test message!", "Admin", "CommonUser");
            insta.Send();

            Console.WriteLine(new String('-', 40));

            var telegram = new TelegramMessager("SuperUser", "SuperPass");
            var teleg = telegram.CreateMessage("Telegram test message!", "Admin", "CommonUser");
            teleg.Send();

            Console.ReadLine();
        }
    }
}
