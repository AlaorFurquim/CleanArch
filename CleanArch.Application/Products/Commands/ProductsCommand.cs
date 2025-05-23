﻿using CleanArch.Domain.Entities;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanArch.Application.Products.Commands
{
    public abstract class ProductsCommand : IRequest<Product>
    {
        public  string Name { get; set; }
        public  string Description { get; set;}
        public decimal Price {  get; set;}
        public int Stock {  get; set;}
        public string Image {  get; set;}
        public int CategoryId { get; set;}
    }
}
