using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiabloViewer.Exceptions
{
    class BattleTagInvalidException : Exception
    {
        public BattleTagInvalidException() : base() { }
        public BattleTagInvalidException(String message) : base(message) { }
        
    }
}
