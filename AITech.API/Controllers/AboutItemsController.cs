using AITech.Business.Services.AboutItemServices;
using AITech.DTO.AboutItemDtos;
using AITech.Entity.Entities;
using Microsoft.AspNetCore.Mvc;

namespace AITech.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AboutItemsController(IAboutItemService _aboutItemService) : Controller
    {
        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            var aboutItems = await _aboutItemService.TGetAllAsync();
            return Ok(aboutItems);
        }
        [HttpGet("{id}")]
        public async Task<IActionResult> GetById(int id)
        {
            var aboutItem = await _aboutItemService.TGetByIdAsync(id);
            return Ok(aboutItem);
        }
        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            await _aboutItemService.TDeleteAsync(id);
            return NoContent();
        }
        [HttpPost]
        public async Task<IActionResult> Create(CreateAboutItemDto dto)
        {
            await _aboutItemService.TCreateAsync(dto);
            return Created();
        }
        [HttpPut]
        public async Task<IActionResult> Update(UpdateAboutItemDto dto)
        {
            await _aboutItemService.TUpdateAsync(dto);
            return NoContent();
        }
    }
}
