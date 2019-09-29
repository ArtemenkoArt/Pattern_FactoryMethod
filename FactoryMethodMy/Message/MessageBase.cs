using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethodMy
{
    public abstract class MessageBase : IMessage
    {
        public string Text { get; protected set; }

        public string Target { get; }

        public string Source { get; }

        public MessageBase(string text, string source, string target)
        {
            if (string.IsNullOrWhiteSpace(text))
            {
                throw new ArgumentNullException(nameof(text), " The text is can`t be empty!");
            }

            if (string.IsNullOrWhiteSpace(source))
            {
                throw new ArgumentNullException(nameof(source), " The sourse is can`t be empty!");
            }

            if (string.IsNullOrWhiteSpace(target))
            {
                throw new ArgumentNullException(nameof(target), " The target is can`t be empty!");
            }

            Text = text;
            Source = source;
            Target = target;
        }

        public abstract void Send();
    }
}
