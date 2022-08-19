using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TwilioWeb.Models
{
    public class sentmessages
    {
        public int Id { get; set; }
        public int messagesId { get; set; }
        public messages messages { get; set; }
        public DateTime sentdate { get; set; }
        public string cofirmationcode { get; set; }
    }
}
