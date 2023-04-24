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
    public class RecipeService : Service<Recipe>, IRecipeService
    {

        private readonly IRecipeRepository _recipeRepository;
        private readonly IMapper _mapper;

        public RecipeService(IGenericRepository<Recipe> repository, IUnitOfWork unitOfWork, IRecipeRepository recipeRepository, IMapper mapper) : base(repository, unitOfWork)
        {
            _recipeRepository=recipeRepository;
            _mapper=mapper;
        }


        public async Task<CustomResponseDto<List<RecipeWithCategoryDto>>> GetRecipesWithCategory()
        {
            
            var recipes = await _recipeRepository.GetRecipesWithCategory();


            var recipesDto = _mapper.Map<List<RecipeWithCategoryDto>>(recipes);

            return CustomResponseDto<List<RecipeWithCategoryDto>>.Success(200, recipesDto);


        }


        public async Task<CustomResponseDto<RecipeDto>> GetFeaturesForRecipeById(int recipeId)
        {
            var recipe = await _recipeRepository.GetCategoryForRecipeByIdAsync(recipeId);

            var user = await _recipeRepository.GetUserForRecipeByIdAsync(recipe.UserId);

            var comment = await _recipeRepository.GetCommentsForRecipeByIdAsync(recipeId);

            var recipeDto = _mapper.Map<RecipeDto>(recipe);

            var userDto = _mapper.Map<UserDto>(user);

            var commentDto = _mapper.Map<List<CommentDto>>(comment);

            recipeDto.User= userDto;

            recipeDto.Comments = commentDto;

            return CustomResponseDto<RecipeDto>.Success(200 , recipeDto);
        }
    }
}
