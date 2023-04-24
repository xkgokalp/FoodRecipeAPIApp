using AutoMapper;
using FoodApp.Core.DTOs;
using FoodApp.Core.Models;
using FoodApp.Core.Services;
using FoodApp.Service.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace FoodApp.API.Controllers
{

    public class UserController : CustomBaseController
    {

        private readonly IMapper _mapper;
        private readonly IUserService _userService;

        public UserController(IMapper mapper, IUserService userService)
        {
            _mapper=mapper;
            _userService=userService;
        }


        [HttpGet("[action]/{userId}")]
        public async Task<IActionResult> GetUsersByIdWithRecipesAsync(int userId)
        {

            return CreateActionResult(await _userService.GetAllUsersWithRecipe(userId));

        }




        [HttpGet]
        public async Task<IActionResult> All()
        {

            var users = await _userService.GetAllAsync();

            var usersDtos = _mapper.Map<List<UserDto>>(users.ToList());

            //return Ok(CustomResponseDto<List<CategoryDto>>.Success(200 , categoriesDtos));

            return CreateActionResult(CustomResponseDto<List<UserDto>>.Success(200, usersDtos));

        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetById(int id)
        {

            var user = await _userService.GetByIdAsync(id);

            var usersDto = _mapper.Map<UserDto>(user);

            return CreateActionResult(CustomResponseDto<UserDto>.Success(200, usersDto));

        }

        [HttpPost]
        public async Task<IActionResult> Save(UserDto userDto)
        {

            var user = await _userService.AddAsync(_mapper.Map<User>(userDto));

            var usersDto = _mapper.Map<UserDto>(user);

            return CreateActionResult(CustomResponseDto<UserDto>.Success(201, usersDto));

        }

        [HttpPut]
        public async Task<IActionResult> Update(UserUpdateDto userDto)
        {

            await _userService.UpdateAsync(_mapper.Map<User>(userDto));

            return CreateActionResult(CustomResponseDto<NoContentDto>.Success(204));

        }


        [HttpDelete("{id}")]
        public async Task<IActionResult> Remove(int id)
        {

            var user = await _userService.GetByIdAsync(id);

            _mapper.Map<UserDto>(user);

            return CreateActionResult(CustomResponseDto<NoContentDto>.Success(204));

        }




    }
}
