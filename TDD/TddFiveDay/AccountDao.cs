using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TDD
{
    public interface IAccountDao
    {
        string GetPassword(string id);
    }
    class AccountDao : IAccountDao
    {
        public string GetPassword(string id)
        {
            //return "255";
            throw new NotImplementedException();
        }
    }
}
