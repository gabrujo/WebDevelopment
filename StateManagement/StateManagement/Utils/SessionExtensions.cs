using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Newtonsoft.Json;

namespace StateManagement.Utils
{
    public static class SessionExtensions // all methods are static
    {
        // extend ISession for generic Set<T> and Get<T> type safe access to Session
        public static void Set<T>(this ISession session, string key, T val)
        {
            session.SetString(key, JsonConvert.SerializeObject(val));
        }
        public static T Get<T>(this ISession session, string key)
        {
            var objstr = session.GetString(key);
            if (objstr == null)
                return default(T);
            else
                return JsonConvert.DeserializeObject<T>(objstr);
        }
    }
}
