using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BankRPSQL.Models;

namespace BankRPSQL.ServicesBusiness
{
    public interface IBusinessAuthentication
    {
        UserInfo GetUserInfo(string username);
    }
}
