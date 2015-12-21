using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiabloViewer.Exceptions
{
    class BattleTagNotFoundException : Exception
    {
        public BattleTagNotFoundException()
            : base()
        {

        }
        public BattleTagNotFoundException(String message) : base(message)
        {

        }
    }
}
