using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TDD
{
    public class Validation
    {
        private IAccountDao _accDao;
        private IHash _hash;
        public Validation(IAccountDao accDao, IHash hash)
        {
            _accDao = accDao;
            _hash = hash;
        }
        public bool CheckAuthentication(string id, string password)
        {
            var pwdByDao = _accDao.GetPassword(id);
            var hashResult = _hash.GetHashResult(password);
            return pwdByDao == hashResult;
        }
    }
}
