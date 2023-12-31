namespace BadmintonManagement.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("_USER")]
    public partial class C_USER
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public C_USER()
        {
            RESERVATION = new HashSet<RESERVATION>();
            RECEIPT = new HashSet<RECEIPT>();
            SERVICE_RECEIPT = new HashSet<SERVICE_RECEIPT>();
        }

        [Key]
        [StringLength(50)]
        public string Username { get; set; }

        [Column("_Password")]
        [Required]
        [StringLength(50)]
        public string C_Password { get; set; }

        [Column("_Name")]
        [Required]
        [StringLength(100)]
        public string C_Name { get; set; }

        [Column("_Role")]
        [Required]
        [StringLength(30)]
        public string C_Role { get; set; }

        [Required]
        [StringLength(60)]
        public string Email { get; set; }

        [Required]
        [StringLength(13)]
        public string PhoneNumber { get; set; }

        [Column("_Status")]
        [Required]
        [StringLength(30)]
        public string C_Status { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<RESERVATION> RESERVATION { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<RECEIPT> RECEIPT { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<SERVICE_RECEIPT> SERVICE_RECEIPT { get; set; }
    }
}
