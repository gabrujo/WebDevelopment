using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using StateManagement.Models;

namespace StateManagement.Utils
{
    public class SessionFacade
    {
        // purpose of Facade pattern is to provide safe access to a resource
        // In this case, the Session object, so that name of the key
        // cannot be mistyped, also the datatype being stored in a key
        // cannot create type casting errors
        const string studentkey = "stiudentkey"; // key field
        public static Student STU
        {
            get
            {
                return HttpContextHelper.HttpCtx.Session.Get<Student>(studentkey);
            }
            set
            {
                HttpContextHelper.HttpCtx.Session.Set<Student>(studentkey, value);
            }
        }
        const string productkey = "productkey"; // key field
        public static Product PROD
        {
            get
            {
                return HttpContextHelper.HttpCtx.Session.Get<Product>(productkey);
            }
            set
            {
                HttpContextHelper.HttpCtx.Session.Set<Product>(productkey, value);
            }
        }
    }

}
