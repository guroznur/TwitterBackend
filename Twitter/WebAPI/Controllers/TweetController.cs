using Business.Abstract;
using Business.Repositories.TweetParameterRepository;
using Core.Utilities.Security.JWT;
using Entities.Concrete;
using Entities.Dtos;
using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TweetController : ControllerBase
    {
        private readonly ITweetService _tweetService;

        public TweetController(ITweetService tweetService)
        {
            _tweetService = tweetService;
        }

        [HttpPost("[action]")]
        public async Task<IActionResult> Add(Tweet tweet)
        {
            var result = await _tweetService.Add(tweet);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result.Message);
        }

        [HttpPost("[action]")]
       public async Task<IActionResult> Delete(Tweet tweet)
        {
            var result = await _tweetService.Delete(tweet);
            if(result.Success)
            {
                return Ok(result);
            }

            return BadRequest(result.Message);
        }
        [HttpPost("[action]")]
        public async Task<IActionResult> Update(Tweet tweet)
        {
            var result = await _tweetService.Update(tweet);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result.Message);
        }

        [HttpGet("[action]/{id}")]
        public async Task<IActionResult> GetById(int id)
        {
            var result = await _tweetService.GetById(id);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result.Message);
        }

        [HttpGet("[action]")]
        public async Task<IActionResult> GetList()
        {
            var result = await _tweetService.GetList();
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result.Message);
        }
    }
}
