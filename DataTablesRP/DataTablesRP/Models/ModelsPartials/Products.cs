﻿using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
namespace DataTablesRP.Models
{
    // following is the way to add data annotations to a class
    // generated by the EF
    [ModelMetadataType(typeof(ProductsMetadata))]
    public partial class Products
    {
    }
    public class ProductsMetadata
    {
        [Range(0, 1000, ErrorMessage = "invalid stocklevel..")]
        public short? UnitsInStock { get; set; }
    }
}
