using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TDD;

namespace TddTest._5Day
{
    class StubAccountDao : IAccountDao
    {
        public string GetPassword(string id)
        {
            return "password";
            //throw new NotImplementedException();
        }
    }
}
