using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BankRPSQL.DataLayer;
using BankRPSQL.Models;

namespace BankRPSQL.ServicesBusiness
{
    public class BusinessAuthentication : IBusinessAuthentication
    {
        IRepositoryAuthentication _irepauth = null;
        public BusinessAuthentication(IRepositoryAuthentication irepauth)
        {
            _irepauth = irepauth;
        }
        public BusinessAuthentication() : this(new Repository())
        { }
        public UserInfo GetUserInfo(string username)
        {
            return _irepauth.GetUserInfo(username);
        }

        UserInfo IBusinessAuthentication.GetUserInfo(string username)
        {
            throw new NotImplementedException();
        }
    }

}
