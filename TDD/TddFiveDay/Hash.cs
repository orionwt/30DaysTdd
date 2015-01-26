using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TDD
{
    public interface IHash
    {
        string GetHashResult(string password);
    }
    class Hash : IHash
    {
        public string GetHashResult(string password)
        {
            //return "255";
            throw new NotImplementedException();
        }
    }
}
