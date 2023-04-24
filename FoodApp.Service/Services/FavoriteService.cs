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
    public class FavoriteService : Service<Favorite>, IFavoriteService
    {

        private readonly IFavoriteRepository _favoriteRepository;
        private readonly IMapper _mapper;


        public FavoriteService(IGenericRepository<Favorite> repository, IUnitOfWork unitOfWork, IFavoriteRepository favoriteRepository, IMapper mapper) : base(repository, unitOfWork)
        {
            _favoriteRepository=favoriteRepository;
            _mapper=mapper;
        }

        public async Task<CustomResponseDto<List<FavoriteDto>>> GetRecipesWithCategory(int favoriteId)
        {
            var favorites = await _favoriteRepository.GetFavoriteAsync(favoriteId);

            var favoritesDto = _mapper.Map<List<FavoriteDto>>(favorites);

            return CustomResponseDto<List<FavoriteDto>>.Success(200, favoritesDto);
        }
    }
}
