using AutoMapper;
using FoodApp.Core.DTOs;
using FoodApp.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FoodApp.Service.Mapping
{
    public class MapProfile : Profile
    {
        public MapProfile()
        {
            CreateMap<Recipe, CategoryDto>().ReverseMap();

            CreateMap<Comment, CommentDto>().ReverseMap();

            CreateMap<Favorite, FavoriteDto>().ReverseMap();

            CreateMap<Recipe, RecipeDto>().ReverseMap();

            CreateMap<Category, CategoryDto>().ReverseMap();

            CreateMap<User, UserDto>().ReverseMap();

            CreateMap<RecipeUpdateDto, Recipe>();

            CreateMap<Recipe , RecipeWithCategoryDto>();

            CreateMap<Category, CategoryWithRecipesDto>();

            CreateMap<UserUpdateDto, User>();

            CreateMap<User, UserWithRecipeDto>();

            CreateMap<Recipe , UserDto>().ReverseMap();

            CreateMap<Recipe , CommentDto>().ReverseMap();

        }
    }
}
