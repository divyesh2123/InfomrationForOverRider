using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InfomrationForOverRider
{
    public class Notification : ISMSNotification, IEmailNotification
    {
        private int a = 1;

        public int Display
        {
            get
            {
                return a;
            }
        }
         void ISMSNotification.sendNotification(string to, string message)
        {
            a = 2;
           Console.WriteLine("this is code for sms");
        }

         void IEmailNotification.sendNotification(string to, string message)
        {
            Console.WriteLine("this is code for email");
        }
    }
}
