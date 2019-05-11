using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Mvc5_DIContainerForUnity.Service
{
    public class MessageService : IMessageService
    {
        public string Hello(string Name)
        {
            return string.Format("Hello,{0}", Name);
        }
    }
}