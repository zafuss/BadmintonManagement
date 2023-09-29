namespace BadmintonManagement.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("PRICE")]
    public partial class PRICE
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public PRICE()
        {
            RF_DETAIL = new HashSet<RF_DETAIL>();
        }

        [StringLength(20)]
        public string PriceID { get; set; }

        public decimal? PriceTag { get; set; }

        public double? TimeFactor { get; set; }

        public double? DateFactor { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<RF_DETAIL> RF_DETAIL { get; set; }
    }
}
