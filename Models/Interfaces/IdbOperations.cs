using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TwilioWeb.Interfaces
{
    public interface IdbOperations
    {
        string Insert();
        IEnumerable<object> Select();
    }
}
