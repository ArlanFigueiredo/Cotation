using Cotation.Models.Requests;
using Cotation.Services.Cotation.Update;
using Microsoft.AspNetCore.Mvc;

namespace Cotation.Controllers.Cotation {
    public class UpdateCotationController(UpdateCotationService updateCotationService) : ControllerBase {
        private readonly UpdateCotationService _updateCotationService = updateCotationService;

        [HttpPut("/cotation/{id}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public async Task<IActionResult> UpdateCotation([FromBody] RequestRegisterCotation request, [FromRoute] int id) {
            try {

                var result = await _updateCotationService.Execute(request, id);

                return Ok(result);
            }
            catch (Exception ex) {
                return BadRequest(ex.Message);
            }
        }
    }
}
