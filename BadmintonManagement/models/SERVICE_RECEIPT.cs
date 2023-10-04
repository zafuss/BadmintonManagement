namespace BadmintonManagement.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class SERVICE_RECEIPT
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public SERVICE_RECEIPT()
        {
            SERVICE_DETAIL = new HashSet<SERVICE_DETAIL>();
        }

        [Key]
        [StringLength(20)]
        public string ServiceReceiptNo { get; set; }

        public DateTime? CreateDate { get; set; }

        public decimal? Total { get; set; }

        [StringLength(13)]
        public string PhoneNumber { get; set; }

        [StringLength(50)]
        public string Username { get; set; }

        public virtual C_USER C_USER { get; set; }

        public virtual CUSTOMER CUSTOMER { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<SERVICE_DETAIL> SERVICE_DETAIL { get; set; }
    }
}
