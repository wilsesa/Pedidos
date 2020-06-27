using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Pedidos
{
    public class Client
    {
        public string Name { get; set; }
        public string email { get; set; }
        public DateTime BirtDate { get; set; }

        public Client()
        {
        }

        public Client(string name, string email, DateTime birtDate)
        {
            Name = name;
            this.email = email;
            BirtDate = birtDate;
        }
    }
}