using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InfomrationForOverRider
{
    public interface ISMSNotification
    {
        public void sendNotification(string to, string message);
    }
}
