using System.ComponentModel.DataAnnotations;

namespace assignmentConsultTik.Models
{
    public class PurchaseOrderLine
    {
        [Key]
        [StringLength(20)]
        public string PurchId { get; set; }

        [StringLength(30)]
        public string ItemId { get; set; }

        public decimal Qty { get; set; }
        public decimal UnitPrice { get; set; }
        public decimal Amount { get; set; }

        public PurchaseOrderHeader PurchaseOrderHeader { get; set; }
    }
}
