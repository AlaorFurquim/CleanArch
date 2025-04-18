using AutoMapper;
using CleanArch.Application.DTOs;
using CleanArch.Application.Interfaces;
using CleanArch.Domain.Entities;
using CleanArch.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanArch.Application.Services
{
    public class CategoryServices : ICategoryServices
    {
        private IcategoryRepository _categoryRepository;
        private readonly IMapper _mapper;
        public CategoryServices(IcategoryRepository categoryServices, IMapper mapper)
        {
            _categoryRepository = categoryServices;
            _mapper = mapper;
        }

        public async Task<IEnumerable<CategoryDTO>> GetCategories()
        {
            var categoryEntity = await _categoryRepository.GetCategories();
            return _mapper.Map<IEnumerable<CategoryDTO>>(categoryEntity);
        }

        public async Task<IEnumerable<CategoryDTO>> GetById(int? id)
        {
            var categoryEnitity = await _categoryRepository.GetById(id);
            return _mapper.Map<IEnumerable<CategoryDTO>>(categoryEnitity);
        }

        public async Task Add(CategoryDTO categoryDTO)
        {
            var categoryEntity = _mapper.Map<Category>(categoryDTO);
            await _categoryRepository.Create(categoryEntity);
        }

        public async Task Update(CategoryDTO categoryDTO)
        {
            var categoryEntity = _mapper.Map<Category>(categoryDTO);
            await _categoryRepository.Update(categoryEntity);
        }

        public async Task Remove(int id)
        {
            var categoryEntity = _categoryRepository.GetById(id).Result;
            await _categoryRepository.Remove(categoryEntity);
        }
    }
}
