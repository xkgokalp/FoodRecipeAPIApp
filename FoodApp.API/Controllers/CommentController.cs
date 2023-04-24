using AutoMapper;
using FoodApp.Core.DTOs;
using FoodApp.Core.Models;
using FoodApp.Core.Services;
using FoodApp.Service.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace FoodApp.API.Controllers
{
    
    public class CommentController : CustomBaseController
    {
        private readonly ICommentService _commentService;

        private readonly IMapper _mapper;

        public CommentController(ICommentService commentService, IMapper mapper)
        {
            _commentService=commentService;
            _mapper=mapper;
        }

        [HttpGet]
        public async Task<IActionResult> All()
        {

            var comments = await _commentService.GetAllAsync();

            var commentsDtos = _mapper.Map<List<CommentDto>>(comments.ToList());

            //return Ok(CustomResponseDto<List<CategoryDto>>.Success(200 , categoriesDtos));

            return CreateActionResult(CustomResponseDto<List<CommentDto>>.Success(200, commentsDtos));

        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetById(int id)
        {

            var comment = await _commentService.GetByIdAsync(id);

            var commentsDto = _mapper.Map<CommentDto>(comment);

            return CreateActionResult(CustomResponseDto<CommentDto>.Success(200, commentsDto));

        }

        [HttpPost]
        public async Task<IActionResult> Save(CommentDto commentDto)
        {

            var comment = await _commentService.AddAsync(_mapper.Map<Comment>(commentDto));

            var commentsDto = _mapper.Map<CommentDto>(comment);

            return CreateActionResult(CustomResponseDto<CommentDto>.Success(201, commentsDto));

        }

        //[HttpPut]
        //public async Task<IActionResult> Update(RecipeUpdateDto recipeDto)
        //{

        //    await _commentService.UpdateAsync(_mapper.Map<Recipe>(recipeDto));

        //    return CreateActionResult(CustomResponseDto<NoContentDto>.Success(204));

        //}


        [HttpDelete("{id}")]
        public async Task<IActionResult> Remove(int id)
        {

            var comment = await _commentService.GetByIdAsync(id);

            _mapper.Map<CommentDto>(comment);

            return CreateActionResult(CustomResponseDto<NoContentDto>.Success(204));

        }

    }
}
