using System.ComponentModel.DataAnnotations;

namespace Cotation.Models {
    public class CotationModel {
        [Key]
        public int Id { get; set; }
        public  string Name { get; set; }
        public  string Phone { get; set; }
        public string Email { get; set; } = string.Empty;
        public  int QuantityAdults { get; set; }
        public  int? NumberOfChildrenOver3Years { get; set; } = 0;
        public  DateTime Checkin { get; set; }
        public  DateTime Checkout { get; set;}
        public DateTime CreatedAt { get; set; } = DateTime.Now.ToLocalTime();
    }
}
