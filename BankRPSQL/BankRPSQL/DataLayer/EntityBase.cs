using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;

namespace BankRPSQL.DataLayer
{
    public class EntityBase : IEntity
    {
        public void SetFields(DataRow dr)
        {
            // use reflection to set the fields of a class object from DataRow
            Type tp = this.GetType();
            foreach (PropertyInfo pi in tp.GetProperties())
            {
                if (null != pi && pi.CanWrite)
                {
                    string nm = pi.PropertyType.Name.ToUpper();
                    string nmfull = pi.PropertyType.FullName.ToUpper();
                }
            }
        }
    }
}
