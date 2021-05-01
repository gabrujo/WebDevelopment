using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;

namespace BankRPSQL.DataLayer
{
    public interface IEntity
    {
        void SetFields(DataRow dr);
    }
}
