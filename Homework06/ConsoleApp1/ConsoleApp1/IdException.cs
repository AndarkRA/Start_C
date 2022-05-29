using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{

    public enum ErrorCodes
    {
        empty
    }

    internal class IdException : Exception
    {
        public IdException(ErrorCodes code)
        {
            Code = code;
        }
        public ErrorCodes Code { get; }
    }
}
