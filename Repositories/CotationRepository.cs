using Cotation.Data;
using Cotation.Models;
using Cotation.Models.Requests;
using Microsoft.EntityFrameworkCore;

namespace Cotation.Repositories {
    public class CotationRepository(AppDbContext context) : ICotationRepository {

        private readonly AppDbContext _context = context;

        public async Task<List<CotationModel>> GetAllCotations() {
            var result = await _context.Cotations.AsNoTracking().ToListAsync();
            return result;
        }

        public async Task<CotationModel> GetCotationById(int id) {
            var result = await _context.Cotations.FirstOrDefaultAsync(x => x.Id == id);
            return result;  

        }

        public async Task<CotationModel> CreateCotation(CotationModel cotation) {
            var _cotation = new CotationModel() {
                Name = cotation.Name,
                Phone = cotation.Phone,
                Email = cotation.Email,
                QuantityAdults = cotation.QuantityAdults,
                NumberOfChildrenOver3Years = cotation.NumberOfChildrenOver3Years,
                Checkin = cotation.Checkin,
                Checkout = cotation.Checkout,
                CreatedAt = DateTime.Now.ToLocalTime(),
            };
            var result = await _context.Cotations.AddAsync(_cotation);
            await _context.SaveChangesAsync();
            return result.Entity;
        }

        public async Task<CotationModel> UpdateCotation(RequestRegisterCotation cotation, int id) {
            var resultCotation = await _context.Cotations.FirstAsync(x => x.Id == id);
            resultCotation.Name = cotation.Name;
            resultCotation.Phone = cotation.Phone;
            resultCotation.Email = cotation.Email;
            resultCotation.QuantityAdults = cotation.QuantityAdults;
            resultCotation.NumberOfChildrenOver3Years = cotation.NumberOfChildrenOver3Years;
            resultCotation.Checkin = cotation.Checkin;
            resultCotation.Checkout = cotation.Checkout;
            var result =  _context.Cotations.Update(resultCotation);
            await _context.SaveChangesAsync();
            return result.Entity;
        }
        public async Task DeleteCotation(CotationModel cotation, int id) {
            _context.Cotations.Remove(cotation);
            await _context.SaveChangesAsync();
        }
    }
}
