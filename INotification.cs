using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InfomrationForOverRider
{
    internal interface INotification
    {
        public bool SendNotification(string to, string title, string message1);
    }
}
