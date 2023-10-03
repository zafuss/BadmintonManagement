namespace BadmintonManagement.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("_SERVICE")]
    public partial class C_SERVICE
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public C_SERVICE()
        {
            SERVICE_DETAIL = new HashSet<SERVICE_DETAIL>();
        }

        [Key]
        [StringLength(20)]
        public string ServiceID { get; set; }

        [StringLength(100)]
        public string ServiceName { get; set; }

        [StringLength(20)]
        public string Unit { get; set; }

        public decimal? Price { get; set; }

        public int? Quantity { get; set; }

        [Column("_Status")]
        [StringLength(30)]
        public string C_Status { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<SERVICE_DETAIL> SERVICE_DETAIL { get; set; }
    }
}
