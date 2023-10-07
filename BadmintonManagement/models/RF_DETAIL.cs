namespace BadmintonManagement.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class RF_DETAIL
    {
        [Key]
        [Column(Order = 0)]
        [StringLength(20)]
        public string ReservationNo { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(20)]
        public string CourtID { get; set; }

        [StringLength(255)]
        public string Note { get; set; }

        public virtual COURT COURT { get; set; }

        public virtual RESERVATION RESERVATION { get; set; }
    }
}
