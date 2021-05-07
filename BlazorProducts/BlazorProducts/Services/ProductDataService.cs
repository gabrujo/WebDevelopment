﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorProducts.Services
{
    public class ProductDataService
    {
        private readonly Models.CoreDBContext _context;
        public ProductDataService(Models.CoreDBContext context)
        {
            _context = context;
        }
        public async Task<List<Products>> GetAllProducts()
        {
            List<Products> PList = await _context.Products.ToListAsync();
            return PList;
        }
        public async Task<List<Products>> GetProductsByCatId(int catid)
        {
            List<Products> PList = await _context.Products.Where(p => p.CategoryId ==
           catid).ToListAsync();
            return PList;
        }
        public async Task<List<Categories>> GetCategories()
        {
            List<Categories> CList = await _context.Categories.ToListAsync();
            return CList;
        }
        public async Task<Products> GetProductById(int prodid)
        {
            var prod = await _context.Products.FindAsync(prodid); // find works on
            primary key
        return prod;
        }
    }


}

