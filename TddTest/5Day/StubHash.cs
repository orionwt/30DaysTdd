using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TDD;

namespace TddTest._5Day
{
    class StubHash : IHash
    {
        public string GetHashResult(string password)
        {
            return "password";
            //throw new NotImplementedException();
        }
    }
}
