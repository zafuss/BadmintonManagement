namespace BadmintonManagement.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("BRANCH")]
    public partial class BRANCH
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public BRANCH()
        {
            COURT = new HashSet<COURT>();
        }

        [StringLength(20)]
        public string BranchID { get; set; }

        [StringLength(50)]
        public string BranchName { get; set; }

        [Column("_Address")]
        [StringLength(50)]
        public string C_Address { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<COURT> COURT { get; set; }
    }
}
