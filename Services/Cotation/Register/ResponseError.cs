using Cotation.Models;
using Cotation.Models.Requests;
using Cotation.Services.Cotation.Update;
using FluentValidation;

namespace Cotation.Services.Cotation.Register {
    public class ResponseError(ValidatorRegisterCotation validator, CotationModel request) {

        private readonly ValidatorRegisterCotation _validator = validator;
        private readonly CotationModel _request = request;

        public async Task<List<ValidationError>> GetErrors() {
            var validatorResult = _validator.Validate(_request);
            var errors = new List<ValidationError>();

            if (!validatorResult.IsValid) {
                foreach (var error in validatorResult.Errors) {
                    errors.Add(new ValidationError {
                        PropertyName = error.PropertyName,
                        ErrorMessage = error.ErrorMessage
                    });
                }
            }

            return errors;
        }
    }
    public class ValidationError {
        public string PropertyName { get; set; }
        public string ErrorMessage { get; set; }
    }

}
