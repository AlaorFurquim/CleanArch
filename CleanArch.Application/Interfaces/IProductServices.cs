using CleanArch.Application.DTOs;
using CleanArch.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanArch.Application.Interfaces
{
    public interface IProductServices
    {
        Task<IEnumerable<ProductDTO>> GetProducts();
        Task<ProductDTO> GetById(int? id);
        Task<ProductDTO> GetProductCategoryId(int? id);

        Task CreateAsync(ProductDTO productDto);
        Task UpdateAsync(ProductDTO productDto);
        Task RemoveAsync(ProductDTO productDto);
    }
}
