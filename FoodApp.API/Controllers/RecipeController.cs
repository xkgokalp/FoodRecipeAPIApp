using AutoMapper;
using FoodApp.Core.DTOs;
using FoodApp.Core.Models;
using FoodApp.Core.Services;
using FoodApp.Service.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace FoodApp.API.Controllers
{
    
    public class RecipeController : CustomBaseController
    {
        private readonly IMapper _mapper;


        private readonly IRecipeService _service;

        public RecipeController(IMapper mapper, IService<Recipe> service, IRecipeService recipeService)
        {
            _mapper=mapper;

            _service=recipeService;
        }


        [HttpGet("[action]/{recipeId}")]
        public async Task<IActionResult> GetFeaturesForRecipeById(int recipeId)
        {

            return CreateActionResult(await _service.GetFeaturesForRecipeById(recipeId));

        }



        [HttpGet("[action]")]
        public async Task<IActionResult> GetRecipesWithCategory()
        {
            return CreateActionResult(await _service.GetRecipesWithCategory());
        }





        [HttpGet]
        public async Task<IActionResult> All()
        {

            var recipes = await _service.GetAllAsync();

            var recipesDtos = _mapper.Map<List<RecipeDto>>(recipes.ToList());

            //return Ok(CustomResponseDto<List<CategoryDto>>.Success(200 , categoriesDtos));

            return CreateActionResult(CustomResponseDto<List<RecipeDto>>.Success(200, recipesDtos));

        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetById(int id)
        {

            var recipe = await _service.GetByIdAsync(id);

            var recipesDto = _mapper.Map<RecipeDto>(recipe);

            return CreateActionResult(CustomResponseDto<RecipeDto>.Success(200, recipesDto));

        }

        [HttpPost]
        public async Task<IActionResult> Save(RecipeDto recipeDto)
        {

            var recipe = await _service.AddAsync(_mapper.Map<Recipe>(recipeDto));

            var recipesDto = _mapper.Map<RecipeDto>(recipe);

            return CreateActionResult(CustomResponseDto<RecipeDto>.Success(201, recipesDto));

        }

        [HttpPut]
        public async Task<IActionResult> Update(RecipeUpdateDto recipeDto) 
        {

           await _service.UpdateAsync(_mapper.Map<Recipe>(recipeDto));

            return CreateActionResult(CustomResponseDto<NoContentDto>.Success(204));

        }


        [HttpDelete("{id}")]
        public async Task<IActionResult> Remove(int id)
        {

            var recipe = await _service.GetByIdAsync(id);

            _mapper.Map<RecipeDto>(recipe);

            return CreateActionResult(CustomResponseDto<NoContentDto>.Success(204));

        }






    }
}
