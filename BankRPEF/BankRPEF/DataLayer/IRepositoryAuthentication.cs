using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BankRPEF.Models;

namespace BankRPEF.DataLayer
{
    public interface IRepositoryAuthentication
    {
        UserInfo GetUserInfo(string username);
    }

}
