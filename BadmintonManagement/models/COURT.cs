namespace BadmintonManagement.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("COURT")]
    public partial class COURT
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public COURT()
        {
            RF_DETAIL = new HashSet<RF_DETAIL>();
        }

        [StringLength(20)]
        public string CourtID { get; set; }

        [StringLength(50)]
        public string CourtName { get; set; }

        [Column("_Status")]
        [StringLength(30)]
        public string C_Status { get; set; }

        public DateTime? StartDate { get; set; }

        [StringLength(20)]
        public string BranchID { get; set; }

        public virtual BRANCH BRANCH { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<RF_DETAIL> RF_DETAIL { get; set; }
    }
}
