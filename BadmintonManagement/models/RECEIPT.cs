namespace BadmintonManagement.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("RECEIPT")]
    public partial class RECEIPT
    {
        [Key]
        [StringLength(20)]
        public string ReceiptNo { get; set; }

        [Column("_Date")]
        public DateTime? C_Date { get; set; }

        public decimal? Total { get; set; }

        public double? ExtraTime { get; set; }

        [StringLength(20)]
        public string ReservationNo { get; set; }

        [StringLength(50)]
        public string Username { get; set; }

        public virtual C_USER C_USER { get; set; }

        public virtual RESERVATION RESERVATION { get; set; }
    }
}
