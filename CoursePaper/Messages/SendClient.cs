using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoursePaper.Messages
{
    public class SendClient
    {
        public Client Client { get; set; }
        public SendClient(Client client)
        {
            this.Client = client;
        }
    }
}
