using System.ComponentModel.DataAnnotations;

namespace assignmentConsultTik.Models
{
    public class PurchaseOrderHeader
    {
        [Key]
        [StringLength(20)]
        public string PurchId { get; set; }

        [StringLength(20)]
        public string Vendor { get; set; }

        [StringLength(3)]
        public string CurrencyCode { get; set; }

        public DateTime Date { get; set; }

        public Vendor VendorDetails { get; set; }
        public Currency CurrencyDetails { get; set; }
        public ICollection<PurchaseOrderLine> PurchaseOrderLines { get; set; }
    }
}
