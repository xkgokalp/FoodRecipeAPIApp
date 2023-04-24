using AutoMapper;
using FoodApp.Core.DTOs;
using FoodApp.Core.Models;
using FoodApp.Core.Services;
using FoodApp.Service.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace FoodApp.API.Controllers
{

    public class FavoriteController : CustomBaseController
    {
        private readonly IMapper _mapper;
        private readonly IFavoriteService _favoriteService;

        public FavoriteController(IMapper mapper, IFavoriteService favoriteService)
        {
            _mapper=mapper;
            _favoriteService=favoriteService;
        }


        [HttpGet]
        public async Task<IActionResult> All()
        {

            var favorites = await _favoriteService.GetAllAsync();

            var favoritesDtos = _mapper.Map<List<FavoriteDto>>(favorites.ToList());

            //return Ok(CustomResponseDto<List<CategoryDto>>.Success(200 , categoriesDtos));

            return CreateActionResult(CustomResponseDto<List<FavoriteDto>>.Success(200, favoritesDtos));

        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetById(int id)
        {

            var favorite = await _favoriteService.GetByIdAsync(id);

            var favoritesDto = _mapper.Map<FavoriteDto>(favorite);

            return CreateActionResult(CustomResponseDto<FavoriteDto>.Success(200, favoritesDto));

        }

        [HttpPost]
        public async Task<IActionResult> Save(FavoriteDto favoriteDto)
        {

            var favorite = await _favoriteService.AddAsync(_mapper.Map<Favorite>(favoriteDto));

            var favoritesDto = _mapper.Map<FavoriteDto>(favorite);

            return CreateActionResult(CustomResponseDto<FavoriteDto>.Success(201, favoritesDto));

        }

        //[HttpPut]
        //public async Task<IActionResult> Update(UserUpdateDto userDto)
        //{

        //    await _favoriteService.UpdateAsync(_mapper.Map<Favorite>(userDto));

        //    return CreateActionResult(CustomResponseDto<NoContentDto>.Success(204));

        //}


        [HttpDelete("{id}")]
        public async Task<IActionResult> Remove(int id)
        {

            var favorite = await _favoriteService.GetByIdAsync(id);

            _mapper.Map<FavoriteDto>(favorite);

            return CreateActionResult(CustomResponseDto<NoContentDto>.Success(204));

        }

    }
}
