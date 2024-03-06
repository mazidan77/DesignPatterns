using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_Patterns.Observer
{
    public class Offer
    {
        public string Message { get; set; }

        public Offer(string Message)
        {
            this.Message = Message;
        }
    }
}
