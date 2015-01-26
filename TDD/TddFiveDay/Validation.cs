using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TDD.TddFiveDay;

namespace TDD
{
    public class Validation
    {
        private IAccountDao _accDao;
        private IHash _hash;
        private IRandomGenerator _randomGen;
        public Validation(IAccountDao accDao, IHash hash, IRandomGenerator randomGen)
        {
            _accDao = accDao;
            _hash = hash;
            _randomGen = randomGen;
        }
        public bool CheckAuthentication(string id, string password)
        {
            var pwdByDao = _accDao.GetPassword(id);
            //var hashResult = _hash.GetHashResult(password);
            var randomPwd = _randomGen.RandomStr;
            return password == pwdByDao + randomPwd;
        }
    }
}
