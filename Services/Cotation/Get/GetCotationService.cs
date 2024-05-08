using Cotation.Models;
using Cotation.Repositories;

namespace Cotation.Services.Cotation.Get
{
    public class GetCotationService(ICotationRepository cotationRepository)
    {

        private readonly ICotationRepository _cotationRepository = cotationRepository;

        public async Task<List<CotationModel>> Execute()
        {
            return await _cotationRepository.GetAllCotations();
        }
    }
}
