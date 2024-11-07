using System.ComponentModel.DataAnnotations;

namespace assignmentConsultTik.Models
{
    public class Vendor
    {
        [Key]
        [StringLength(20)]
        public string VendorId { get; set; }

        [StringLength(160)]
        public string VendorName { get; set; }

        public ICollection<PurchaseOrderHeader> PurchaseOrderHeaders { get; set; }
    }
}
