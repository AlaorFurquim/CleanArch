﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanArch.Application.Products.Commands
{
    internal class ProductUpdateCommand : ProductsCommand
    {
        public int Id {  get; set; }
    }
}
