using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    public class Notification
    {
        internal string Text="Salam P116";
        protected internal string Title;
        private protected int Count;
        public string getMessage()
        {
            return Text;
        }
    }

    internal class SmsNotification: Notification
    {
        public SmsNotification()
        {
            Title = "Hello";
            Count = 6;
        }
    }

    internal class Library
    {
        public Library()
        {
            Notification n = new Notification();
            n.Text = "Your have new notify";
            n.Title = "Hi";
            
        }
    }
}
