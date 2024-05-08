namespace Cotation.Models.Requests {
    public class RequestRegisterCotation {
        public  string Name { get; set; }
        public  string Phone { get; set; }
        public string Email { get; set; } = string.Empty;
        public  int QuantityAdults { get; set; }
        public  int? NumberOfChildrenOver3Years { get; set; } = null;
        public  DateTime Checkin { get; set; }
        public  DateTime Checkout { get; set; }

        public static implicit operator RequestRegisterCotation(CotationModel v) {
            throw new NotImplementedException();
        }
    }
}
