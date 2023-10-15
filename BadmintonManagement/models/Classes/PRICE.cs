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
            RESERVATION = new HashSet<RESERVATION>();
        }

        [StringLength(20)]
        public string PriceID { get; set; }

        public decimal PriceTag { get; set; }

        public double TimeFactor { get; set; }

        public double DateFactor { get; set; }

        [Column("_Status")]
        public int C_Status { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<RESERVATION> RESERVATION { get; set; }
    }
}
