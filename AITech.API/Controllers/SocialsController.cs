using AITech.Business.Services.SocialServices;
using AITech.DTO.SocialDtos;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace AITech.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SocialsController(ISocialService _socialService) : ControllerBase
    {
        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            var socials = await _socialService.TGetAllAsync();
            return Ok(socials);
        }
        [HttpGet("{id}")]
        public async Task<IActionResult> GetById(int id)
        {
            var social = await _socialService.TGetByIdAsync(id);
            return Ok(social);
        }
        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            await _socialService.TDeleteAsync(id);
            return NoContent();
        }
        [HttpPost]
        public async Task<IActionResult> Create(CreateSocialDto dto)
        {
            await _socialService.TCreateAsync(dto);
            return Created();
        }
        [HttpPut]
        public async Task<IActionResult> Update(UpdateSocialDto dto)
        {
            await _socialService.TUpdateAsync(dto);
            return NoContent();
        }
    }
}
