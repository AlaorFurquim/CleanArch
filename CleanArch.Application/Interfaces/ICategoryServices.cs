using CleanArch.Application.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanArch.Application.Interfaces
{
    public interface ICategoryServices
    {
        Task<IEnumerable<CategoryDTO>> GetCategories();
        Task<IEnumerable<CategoryDTO>> GetById(int? id);
        Task Add(CategoryDTO categoryDTO);
        Task Update(CategoryDTO categoryDTO);
        Task Remove(int id);
    }
}
