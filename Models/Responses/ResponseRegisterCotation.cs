namespace Cotation.Models.Responses {
    public class ResponseRegisterCotation {
        public required string Name { get; set; }
        public required string Phone { get; set; }
        public string Email { get; set; } = string.Empty;
        public required int QuantityAdults { get; set; }
        public required int numberOfChildrenOver3Years { get; set; } 
        public required DateTime Checkin { get; set; }
        public required DateTime Checkout { get; set; }
    }

    
}
