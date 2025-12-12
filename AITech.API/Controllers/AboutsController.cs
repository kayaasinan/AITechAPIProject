using AITech.Business.Services.AboutServices;
using AITech.DTO.AboutDtos;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace AITech.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AboutsController(IAboutService _aboutService) : ControllerBase
    {
        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            var abouts = await _aboutService.TGetAllAsync();
            return Ok(abouts);
        }
        [HttpGet("{id}")]
        public async Task<IActionResult> GetById(int id)
        {
            var about = await _aboutService.TGetByIdAsync(id);
            return Ok(about);
        }
        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            await _aboutService.TDeleteAsync(id);
            return NoContent();
        }
        [HttpPost]
        public async Task<IActionResult> Create(CreateAboutDto dto)
        {
            await _aboutService.TCreateAsync(dto);
            return Created();
        }
        [HttpPut]
        public async Task<IActionResult> Update(UpdateAboutDto dto)
        {
            await _aboutService.TUpdateAsync(dto);
            return NoContent();
        }
    }
}
