using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TwilioWeb.Data;
using TwilioWeb.Interfaces;

namespace TwilioWeb.Models.Interfaces
{
    public class Sqlmessage:IdbOperations
    {
        private messages messages_;
        private readonly MyContext _context;
        public Sqlmessage(messages messages, MyContext context) 
        {
            messages_ = messages;
            _context = context;
        }

        public Sqlmessage()
        { }

            public string Insert()
        {
            try {
                messages_.datecreated = DateTime.Now;
                _context.Add(messages_);
                _context.SaveChanges();
                return messages_.id.ToString();
            } catch (Exception e) {
                return "Error: " + e.Message;
            }
            
        }

        public IEnumerable<object> Select()
        {
            throw new NotImplementedException();
        }
    }
}
