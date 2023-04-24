using FoodApp.Core.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Infrastructure;

namespace FoodApp.API.Controllers
{
   
    public class CategoriesController : CustomBaseController
    {

        private readonly ICategoryService _categoryService;

        public CategoriesController(ICategoryService categoryService)
        {
            _categoryService=categoryService;
        }

        [HttpGet("[action]/{categoryId}")]
        public async Task<IActionResult> GetSingleCategoryByIdWithRecipes(int categoryId)
        {

            return CreateActionResult(await _categoryService.GetSingleCategoryByIdWithRecipesAsync(categoryId));

        }





    }
}
