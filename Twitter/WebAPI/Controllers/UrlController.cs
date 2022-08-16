using Business.Abstract;
using Business.Repositories.TweetParameterRepository;
using Business.Repositories.UrlRepository;
using Core.Utilities.Security.JWT;
using Entities.Concrete;
using Entities.Dtos;
using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UrlController : ControllerBase
    {
        private readonly IUrlService _urlService;

        public UrlController(IUrlService urlService)
        {
            _urlService = urlService;
        }

        [HttpPost("[action]")]
        public async Task<IActionResult> Add(Url url)
        {
            var result = await _urlService.Add(url);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result.Message);
        }

        [HttpPost("[action]")]
       public async Task<IActionResult> Delete(Url url)
        {
            var result = await _urlService.Delete(url);
            if(result.Success)
            {
                return Ok(result);
            }

            return BadRequest(result.Message);
        }
        [HttpPost("[action]")]
        public async Task<IActionResult> Update(Url url)
        {
            var result = await _urlService.Update(url);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result.Message);
        }

        [HttpGet("[action]/{id}")]
        public async Task<IActionResult> GetById(int id)
        {
            var result = await _urlService.GetById(id);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result.Message);
        }

        [HttpGet("[action]")]
        public async Task<IActionResult> GetList()
        {
            var result = await _urlService.GetList();
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result.Message);
        }
    }
}
