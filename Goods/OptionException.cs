using System;

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
