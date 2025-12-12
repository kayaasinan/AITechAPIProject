using AITech.Business.Services.FAQServices;
using AITech.DTO.FAQDtos;
using Microsoft.AspNetCore.Mvc;

namespace AITech.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FAQsController(IFAQService _fAQService) : ControllerBase
    {
        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            var faqs = await _fAQService.TGetAllAsync();
            return Ok(faqs);
        }
        [HttpGet("{id}")]
        public async Task<IActionResult> GetById(int id)
        {
            var faq = await _fAQService.TGetByIdAsync(id);
            return Ok(faq);
        }
        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            await _fAQService.TDeleteAsync(id);
            return NoContent();
        }
        [HttpPost]
        public async Task<IActionResult> Create(CreateFAQDto dto)
        {
            await _fAQService.TCreateAsync(dto);
            return Created();
        }
        [HttpPut]
        public async Task<IActionResult> Update(UpdateFAQDto dto)
        {
            await _fAQService.TUpdateAsync(dto);
            return NoContent();
        }
    }
}
