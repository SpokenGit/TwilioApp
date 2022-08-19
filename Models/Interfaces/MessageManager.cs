using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TwilioWeb.Interfaces;

namespace TwilioWeb.Models.Interfaces
{
    public class MessageManager
    {
        private readonly IdbOperations _operations;
        public MessageManager(IdbOperations Operations)
        {
            _operations = Operations;
        }

        public string Insert()
        {
            return _operations.Insert();
        }

        public IEnumerable<object> Select()
        {

            return _operations.Select();
        }
    }
}
