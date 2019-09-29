using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethodMy
{
    public abstract class MessangerBase : IMessager
    {
        public string UserName { get; }

        public string UserPass { get; }

        public bool Connected { get; }

        public MessangerBase(string user, string pass)
        {
            if (!(string.IsNullOrWhiteSpace(user) && (string.IsNullOrWhiteSpace(pass))))
            {
                UserName = user;
                UserPass = pass;
                Connected = Authorize();
            }
            else
            {
                Connected = false;
            }
        }

        public abstract bool Authorize();

        public abstract IMessage CreateMessage(string text, string source, string target);
    }
}
