using Cotation.Models;
using Cotation.Models.Requests;
using Cotation.Repositories;

namespace Cotation.Services.Cotation.Update
{
    public class UpdateCotationService(ICotationRepository cotationRepository)
    {
        private readonly ICotationRepository _cotationRepository = cotationRepository;

        public async Task<CotationModel> Execute(RequestRegisterCotation request, int id)
        {
            _ = await _cotationRepository.GetCotationById(id) ?? throw new Exception("Cotação não existe");
            var resultCotationUpdate = await _cotationRepository.UpdateCotation(request, id);
            return resultCotationUpdate;
        }
    }
}
