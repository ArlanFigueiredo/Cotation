using Cotation.Models;
using Cotation.Models.Requests;

namespace Cotation.Repositories {
    public interface ICotationRepository {

        public Task<List<CotationModel>> GetAllCotations();
        public Task<CotationModel> CreateCotation(CotationModel cotation);
        public Task<CotationModel> GetCotationById(int id);
        public Task<CotationModel> UpdateCotation(RequestRegisterCotation cotation, int id);
        public Task DeleteCotation(CotationModel cotation, int id);
    }
}
