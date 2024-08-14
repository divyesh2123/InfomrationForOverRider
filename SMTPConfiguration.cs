using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InfomrationForOverRider
{
    public class SMTPConfiguration
    {
        public string Host { get; set; }

        protected int Port { get; set; }

        protected bool EnableSsl { get; set; }

        protected string FromPassword { get; set; }

        protected string FromEmail { get; set; }

        public virtual void SetEmailConfiguration()
        {
            Host = "smtp.gmail.com";
            Port = 587;
            EnableSsl = true;
            FromPassword = "xric uqge ifga piql";
            FromEmail = "divyesh.weltec@gmail.com";

        }

    }
}
