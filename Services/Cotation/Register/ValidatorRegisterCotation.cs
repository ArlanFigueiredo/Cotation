using Cotation.Models;
using FluentValidation;

namespace Cotation.Services.Cotation.Register {
    public class ValidatorRegisterCotation : AbstractValidator<CotationModel> {

        [Obsolete]
        public ValidatorRegisterCotation() {

            CascadeMode = CascadeMode.StopOnFirstFailure;

            RuleFor(cotation => cotation.Name)
                .NotEmpty()
                .WithMessage("O nome é obrigatorio");

            RuleFor(cotation => cotation.Phone)
                .NotEmpty()
                .WithMessage("O Telefone é obrigatorio");

            RuleFor(cotation => cotation.Email)
                .NotEmpty()
                .WithMessage("O e-mail é obrigatorio");

            RuleFor(cotation => cotation.QuantityAdults)
                .NotEmpty()
                .WithMessage("A quantidade de adultos é obrigatorio");

            RuleFor(cotation => cotation.NumberOfChildrenOver3Years)
                .NotEmpty()
                .WithMessage("A quantidade de crianças é obrigatorio");

            RuleFor(cotation => cotation.Checkin)
                .NotEmpty()
                .WithMessage("Check-in é obrigatorio");

            RuleFor(cotation => cotation.Checkout)
                .NotEmpty()
                .NotEqual(DateTime.Now).WithMessage("Check-out é obrigatorio");
        }
    }
}
