using Cotation.Services.Cotation.Delete;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Cotation.Controllers.Cotation {
    [Route("api/[controller]")]
    [ApiController]
    public class DeleteCotationController(DeleteCotationService deleteCotationService) : ControllerBase {

        private readonly DeleteCotationService _deleteCotationService = deleteCotationService;

        [HttpDelete("/cotation{id}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public async Task<IActionResult> DeleteCotation([FromRoute] int id) {
            try {
            await _deleteCotationService.Execute(id);
                return Ok("Cotação deletado com sucesso.");
            }catch (Exception ex) {
                return BadRequest(ex.Message);
            }
        }
    }
}
