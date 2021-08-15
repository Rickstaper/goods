using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Goods
{
    class OptionException : ApplicationException
    {
        public OptionException (string text) : base (text) { }

        public override string ToString ()
        {
            return Message;
        }
    }
}
