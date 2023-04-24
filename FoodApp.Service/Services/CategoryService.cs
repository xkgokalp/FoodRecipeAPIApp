using AutoMapper;
using FoodApp.Core.DTOs;
using FoodApp.Core.Models;
using FoodApp.Core.Repositories;
using FoodApp.Core.Services;
using FoodApp.Core.UnitOfWorks;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FoodApp.Service.Services
{
    public class CategoryService : Service<Category> , ICategoryService
    {

        private readonly ICategoryRepository _categoryRepository;
        private readonly IMapper _mapper;


        public CategoryService(IGenericRepository<Category> repository, IUnitOfWork unitOfWork, ICategoryRepository categoryRepository, IMapper mapper) : base(repository, unitOfWork)
        {
            _categoryRepository=categoryRepository;
            _mapper=mapper;
        }

        public async Task<CustomResponseDto<CategoryWithRecipesDto>> GetSingleCategoryByIdWithRecipesAsync(int categoryId)
        {
            var category = await _categoryRepository.GetSingleCategoryByIdWithRecipesAsync(categoryId);

            var categoryDto = _mapper.Map<CategoryWithRecipesDto>(category);

            return CustomResponseDto<CategoryWithRecipesDto>.Success(200, categoryDto);
        }
    }
}
