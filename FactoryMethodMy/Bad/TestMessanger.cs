using System;

namespace FactoryMethodMy
{
    public class TestMessanger
    {
        public string UserName { get; set; }
        public string UserPass { get; set; }
        public bool Connected { get; set; }

        public TestMessanger(string user, string pass)
        {
            if (!(string.IsNullOrWhiteSpace(user) && (string.IsNullOrWhiteSpace(pass))))
            {
                UserName = user;
                UserPass = pass;
                Connected = ConnectToTwitter();
            }
            else
            {
                throw new ArgumentNullException(nameof(user), "pass or user is emty!!");
            }
        }

        public void SendMessage(string text, string source, string target)
        {
            if (string.IsNullOrWhiteSpace(text))
            {
                throw new ArgumentNullException(nameof(text)," The text is can`t be empty!");
            }

            if (string.IsNullOrWhiteSpace(source))
            {
                throw new ArgumentNullException(nameof(source), " The sourse is can`t be empty!");
            }

            if (string.IsNullOrWhiteSpace(target))
            {
                throw new ArgumentNullException(nameof(target), " The target is can`t be empty!");
            }

            var message = new TestMessange(text, source, target);

            SendMessageToTwitter(message);
        }

        public void SendMessageToTwitter(TestMessange messange)
        {
            Console.WriteLine($"Twitter: {messange.Text}");
        }

        public bool ConnectToTwitter()
        {
            Console.WriteLine($"Connect to Twitter user: {UserName}, pass: {UserPass}");
            return true;
        }
    }
}
