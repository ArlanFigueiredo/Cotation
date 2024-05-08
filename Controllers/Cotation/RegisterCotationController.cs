using Cotation.Models;
using Cotation.Repositories;
using Cotation.Services.Cotation.Register;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Cotation.Controllers.Cotation
{
    [Route("api/[controller]")]
    [ApiController]
    public class RegisterCotationController(RegisterCotationService registerCotationService, ValidatorRegisterCotation validator) : ControllerBase {
        private readonly RegisterCotationService _registerService = registerCotationService;
        private readonly ValidatorRegisterCotation _validator = validator;

        [HttpPost("/cotation")]
        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public async Task<IActionResult> RegisterCotation([FromBody] CotationModel request) {
            var responseError = new ResponseError(_validator, request);
            try {
                var errors = await responseError.GetErrors();

                if (errors.Count > 0) {
                    return BadRequest(errors);
                }
                var result = await _registerService.Execute(request);
                return Created($"/cotation/{result.Id}", result);
            }
            catch (Exception ex) {
                return BadRequest(ex.Message);
            }
        }
    }

}
