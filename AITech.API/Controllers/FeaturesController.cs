using AITech.Business.Services.FeatureServices;
using AITech.DTO.FeatureDtos;
using Microsoft.AspNetCore.Mvc;

namespace AITech.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FeaturesController(IFeatureService _featureService) : ControllerBase
    {
        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            var features = await _featureService.TGetAllAsync();
            return Ok(features);
        }
        [HttpGet("{id}")]
        public async Task<IActionResult> GetById(int id)
        {
            var feature = await _featureService.TGetByIdAsync(id);
            return Ok(feature);
        }
        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            await _featureService.TDeleteAsync(id);
            return NoContent();
        }
        [HttpPost]
        public async Task<IActionResult> Create(CreateFeatureDto dto)
        {
            await _featureService.TCreateAsync(dto);
            return Created();
        }
        [HttpPut]
        public async Task<IActionResult> Update(UpdateFeatureDto dto)
        {
            await _featureService.TUpdateAsync(dto);
            return NoContent();
        }
    }
}
