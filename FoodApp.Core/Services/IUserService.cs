﻿using FoodApp.Core.DTOs;
using FoodApp.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FoodApp.Core.Services
{
    public interface IUserService : IService<User>
    {
        Task<CustomResponseDto<List<UserWithRecipeDto>>> GetAllUsersWithRecipe(int userId);

    }
}
