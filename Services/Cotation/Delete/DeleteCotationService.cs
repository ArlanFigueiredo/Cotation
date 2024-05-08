using Cotation.Repositories;

namespace Cotation.Services.Cotation.Delete
{
    public class DeleteCotationService(ICotationRepository cotationRepository)
    {

        private readonly ICotationRepository _cotationRepository = cotationRepository;
        public async Task Execute(int id)
        {
            var result = await _cotationRepository.GetCotationById(id) ?? throw new Exception("Cotação não existe");
            await _cotationRepository.DeleteCotation(result, id);
        }

    }
}
