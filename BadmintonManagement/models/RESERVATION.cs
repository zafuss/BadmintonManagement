namespace BadmintonManagement.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("RESERVATION")]
    public partial class RESERVATION
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public RESERVATION()
        {
            RECEIPTs = new HashSet<RECEIPT>();
            RF_DETAIL = new HashSet<RF_DETAIL>();
        }

        [Key]
        [StringLength(20)]
        public string ReservationNo { get; set; }

        [StringLength(50)]
        public string Username { get; set; }

        [StringLength(13)]
        public string PhoneNumber { get; set; }

        [StringLength(20)]
        public string CourtID { get; set; }

        public decimal? Deposite { get; set; }

        public DateTime? CreateDate { get; set; }

        public DateTime? BookingDate { get; set; }

        public virtual C_User C_User { get; set; }

        public virtual CUSTOMER CUSTOMER { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<RECEIPT> RECEIPTs { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<RF_DETAIL> RF_DETAIL { get; set; }
    }
}