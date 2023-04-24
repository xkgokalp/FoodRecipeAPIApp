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
    public class CommentService : Service<Comment>, ICommentService
    {
        private readonly ICommentsRepository _commentsRepository;
        private readonly IMapper _mapper;

        public CommentService(IGenericRepository<Comment> repository, IUnitOfWork unitOfWork, ICommentsRepository commentsRepository, IMapper mapper) : base(repository, unitOfWork)
        {
            _commentsRepository=commentsRepository;
            _mapper=mapper;
        }

        //public async Task<CustomResponseDto<List<CommentDto>>> GetAllCommentsForRecipes()
        //{
        //    var comments = await _commentsRepository.GetAllCommentsForRecipes();

        //    var commentsDto = _mapper.Map<List<Comment>>(comments);

        //    return CustomResponseDto<List<CommentDto>>.Success(200, commentsDto);


        //}
    }
}
