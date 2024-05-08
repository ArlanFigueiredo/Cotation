using Cotation.Models;
using Cotation.Repositories;

namespace Cotation.Services.Cotation.Register
{
    public class RegisterCotationService(ICotationRepository cotationRepository)
    {

        private readonly ICotationRepository _cotationRepository = cotationRepository;

        public async Task<CotationModel> Execute(CotationModel request)
        {
            var cotation = await _cotationRepository.CreateCotation(request);
            return cotation;
        }
    }
}
