using System;

namespace FactoryMethodMy
{
    public class TestMessange
    {
        public string Text { get; set; }
        public string Target { get; set; }
        public string Source { get; set; }

        public TestMessange(string text, string source, string target)
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
    }
}
