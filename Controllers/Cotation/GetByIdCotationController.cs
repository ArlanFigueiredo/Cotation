using Cotation.Services.Cotation.Get;
using Microsoft.AspNetCore.Mvc;

namespace Cotation.Controllers.Cotation {
    [Route("api/[controller]")]
    [ApiController]
    public class GetByIdCotationController(GetByIdCotationService getByIdCotationService) : ControllerBase {

        private readonly GetByIdCotationService _getByIdCotationService = getByIdCotationService;

        [HttpGet]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public async Task<IActionResult> GetCotationById([FromRoute] int id) {
            try {
                var result = await _getByIdCotationService.Execute(id);
                return Ok(result);
            }
            catch  (Exception ex) {
                return BadRequest(ex.Message);
            }
        }
    }
}
