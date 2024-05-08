using Cotation.Models;
using Cotation.Repositories;

namespace Cotation.Services.Cotation.Get
{
    public class GetByIdCotationService(ICotationRepository cotationRepository)
    {

        private readonly ICotationRepository _cotationRepository = cotationRepository;

        public async Task<CotationModel> Execute(int id)
        {
            var resultCotation = await _cotationRepository.GetCotationById(id);
            return resultCotation ?? throw new Exception("Cotação não encontrado");
        }
    }
}
