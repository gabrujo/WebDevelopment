﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.Extensions.Caching.Distributed;

namespace BankRPEF.Utils
{
    public class RedisCacheHelper
    {
        public static IDistributedCache IDISTCACHE = null;
    }

}
