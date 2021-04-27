using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using StateManagement.Models;

namespace StateManagement.Services
{
    public interface IProducts
    {
        List<Product> GetProducts();
    }

}
