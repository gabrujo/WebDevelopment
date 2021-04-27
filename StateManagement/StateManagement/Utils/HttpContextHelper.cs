using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;

namespace StateManagement.Utils
{
    public class HttpContextHelper
    {
        static IHttpContextAccessor _ihttpCtxAccessor = null;
        public static void Configure(IHttpContextAccessor accessor)
        {
            _ihttpCtxAccessor = accessor;
        }
        public static HttpContext HttpCtx
        {
            get { return _ihttpCtxAccessor.HttpContext; }
        }
    }

}
