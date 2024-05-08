using Cotation.Services.Cotation.Get;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Cotation.Controllers.Cotation {
    [Route("api/[controller]")]
    [ApiController]
    public class GetCotationController(GetCotationService getCotationService) : ControllerBase {

        private readonly GetCotationService _getCotationService = getCotationService;

        [HttpGet]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public async Task<IActionResult> GetAllCotations() {

            try {
                var result = await _getCotationService.Execute();
                return Ok(result);
            }catch (Exception ex) { 
                return BadRequest(ex.Message);
            }
        }
    }
}
