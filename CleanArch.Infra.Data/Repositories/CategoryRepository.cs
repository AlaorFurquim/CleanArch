using CleanArch.Domain.Entities;
using CleanArch.Domain.Interfaces;
using CleanArch.Infra.Data.Context;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanArch.Infra.Data.Repositories
{
    public class CategoryRepository : IcategoryRepository
    {
        ApplicationDbContext _cateoryContext;
        public CategoryRepository(ApplicationDbContext dbContext)
        {
            _cateoryContext = dbContext;
        }

        public async Task<Category> Create(Category category)
        {
            _cateoryContext.Categories.Add(category);
            await _cateoryContext.SaveChangesAsync();
            return category;
        }

        public async Task<Category> GetById(int? id)
        {
            return await _cateoryContext.Categories.FindAsync(id);
        }

        public async Task<IEnumerable<Category>> GetCategories()
        {
            return await _cateoryContext.Categories.ToListAsync();
        }

        public async Task<Category> Remove(Category category)
        {
            _cateoryContext.Categories.Remove(category);
            await _cateoryContext.SaveChangesAsync();
            return category;
        }

        public async Task<Category> Update(Category category)
        {
            _cateoryContext.Categories.Update(category);
            await _cateoryContext.SaveChangesAsync();
            return category;
        }
    }
}
