using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public enum ErrorName
    {
        empty
    }

    internal class NameException : Exception
    {
        public NameException(ErrorName code)
        {
            Code = code;
        }
        public ErrorName Code { get; }
    }
}
