using System.ComponentModel.DataAnnotations;

namespace assignmentConsultTik.Models
{
    public class Currency
    {
        [Key]
        [StringLength(3)]
        public string CurrencyCode { get; set; }

        [StringLength(15)]
        public string CurrencyName { get; set; }

        public ICollection<PurchaseOrderHeader> PurchaseOrderHeaders { get; set; }
    }
}
