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
    public class UserService : Service<User>, IUserService
    {

        private readonly IUserRepository _userRepository;
        private readonly IMapper _mapper;

        public UserService(IGenericRepository<User> repository, IUnitOfWork unitOfWork, IUserRepository userRepository, IMapper mapper) : base(repository, unitOfWork)
        {
            _userRepository=userRepository;
            _mapper=mapper;
        }

        public async Task<CustomResponseDto<List<UserWithRecipeDto>>> GetAllUsersWithRecipe(int userId)
        {
            var users = await _userRepository.GetAllUsersWithRecipe(userId);

            var userDto = _mapper.Map<List<UserWithRecipeDto>>(users);

            return CustomResponseDto<List<UserWithRecipeDto>>.Success(200, userDto);
        }
    }
}
