namespace BadmintonManagement.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("_User")]
    public partial class C_User
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public C_User()
        {
            RESERVATIONs = new HashSet<RESERVATION>();
        }

        [Key]
        [StringLength(50)]
        public string Username { get; set; }

        [Column("_Password")]
        [StringLength(50)]
        public string C_Password { get; set; }

        [Column("_Name")]
        [StringLength(100)]
        public string C_Name { get; set; }

        [Column("_Role")]
        [StringLength(30)]
        public string C_Role { get; set; }

        [StringLength(60)]
        public string Email { get; set; }

        [StringLength(13)]
        public string PhoneNumber { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<RESERVATION> RESERVATIONs { get; set; }
    }
}
